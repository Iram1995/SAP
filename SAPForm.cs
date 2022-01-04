
// Type: SAP2012.SAPForm




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.ImportsArea;
using SAP2012.My;
using SAP2012.SAPRef;
using SAP2012.ScotlandService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using uValueCalc;

namespace SAP2012
{
  [DesignerGenerated]
  public class SAPForm : Form
  {
    private string[] AddressID;
    private bool DontSave;
    private string CurrElementControl;
    private bool DontAdd;
    public BetterDataGrid DGVPhotoVoltaics;
    public BetterDataGrid DGSpecialFeatures;
    private int CurrPhotoV;
    private int CurrSPecFeature;
    private bool Exiting;
    private bool Update_Database;
    private string UValueType;
    private bool DontShowUValueList;
    private object Addresses;
    private bool DoCheckFuel;
    private object Address_List;
    private bool _onlyOnce;
    private bool @bool;
    private IContainer components;

    public SAPForm()
    {
      this.FormClosing += new FormClosingEventHandler(this.SAPForm_FormClosing);
      this.Leave += new EventHandler(this.SAPForm_Leave);
      this.Load += new EventHandler(this.Form1_Load);
      this.Resize += new EventHandler(this.SAPForm_Resize);
      this.DGVPhotoVoltaics = new BetterDataGrid();
      this.DGSpecialFeatures = new BetterDataGrid();
      this.@bool = true;
      this.InitializeComponent();
    }

    private void SAPForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.Exiting)
        return;
      this.Exiting = true;
      if (MyProject.Forms.Save.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.EcoFormShow.PleaseClose = true;
        Application.Exit();
        this.Exiting = false;
      }
      else
      {
        e.Cancel = true;
        this.Exiting = false;
      }
    }

    public void AddTheHandler(object sender, EventArgs e) => ((ComboBox) sender).DroppedDown = true;

    public void AddCalcHandle()
    {
      if (SAP_Module.NoCalc)
        return;
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling != -1)
        Functions.CalculateNow();
    }

    public void AddCalcHandle2(object sender, KeyEventArgs e)
    {
      if (SAP_Module.NoCalc || e.KeyCode != Keys.Return)
        return;
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling != -1)
        Functions.CalculateNow();
    }

    private void SortComboBoxes(Control cc)
    {
      try
      {
        foreach (Control control in cc.Controls)
        {
          if (control.HasChildren)
            this.SortComboBoxes(control);
          if (control is ComboBox)
          {
            ComboBox comboBox = (ComboBox) control;
            control.Click += new EventHandler(this.AddTheHandler);
            comboBox.SelectedIndexChanged += (EventHandler) ((a0, a1) => this.AddCalcHandle());
          }
          if (control is TextBox)
          {
            control.LostFocus += (EventHandler) ((a0, a1) => this.AddCalcHandle());
            control.KeyDown += new KeyEventHandler(this.AddCalcHandle2);
          }
          if (control is CheckBox)
            ((CheckBox) control).CheckedChanged += (EventHandler) ((a0, a1) => this.AddCalcHandle());
          if (control is NumericUpDown)
            ((NumericUpDown) control).ValueChanged += (EventHandler) ((a0, a1) => this.AddCalcHandle());
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void SetColDropDownWith(DataGridView z, int Width)
    {
      try
      {
        foreach (object column in (BaseCollection) z.Columns)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(column);
          if (objectValue is DataGridViewComboBoxColumn)
            ((DataGridViewComboBoxColumn) objectValue).DropDownWidth = Width;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void SetCurrPhotoV()
    {
      this.CurrPhotoV = this.DGVPhotoVoltaics.SelectedRows[0].Index;
      this.txtPPower.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].PPower);
      this.txtPTilt.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].PTilt;
      this.txtPCOrientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].PCOrientation;
      this.txtPOvershading.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].POvershading;
      this.chkPVDirect.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].DirectlyConnected;
      this.cboPVConnection.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].FlatConnection;
    }

    private void SetCurrSpecialfeature()
    {
      this.CurrSPecFeature = this.DGSpecialFeatures.SelectedRows[0].Index;
      this.txtSpDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].Description;
      this.txtSpESaved.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EnergySaved);
      this.txtSpFSaved.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].FuelSaved;
      this.txtSpEUsed.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EnergyUsed);
      this.txtSpFUsed.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].FuelUsed;
      this.ChkMonInc.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].IncludeMonthly;
      this.chkEmissionsOnly.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].MakeEmissionsOnly;
      this.txtEmissionsOnly.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EmissionsAmount);
      this.txtEmissionsOnlyCreated.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EmissionsAmountCreated);
    }

    private void SAPForm_Leave(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string Left = "";
      if (!MySettingsProperty.Settings.SetDisplayNotes)
      {
        MySettingsProperty.Settings.SetDisplayNotes = true;
        MySettingsProperty.Settings.DisplayNotes = true;
      }
      this.LblError.Visible = false;
      this.ShowNotesToolStripMenuItem.Checked = MySettingsProperty.Settings.DisplayNotes;
      try
      {
        if (AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData != null && AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData.Length > 0)
          Left = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData[0];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Module.CurrDwelling = -1;
      this.pnlPhotoVoltaics.Controls.Add((Control) this.DGVPhotoVoltaics);
      this.DGVPhotoVoltaics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.DGVPhotoVoltaics.CellClick += (DataGridViewCellEventHandler) ((a0, a1) => this.SetCurrPhotoV());
      this.TabControl3.Controls.Remove((Control) this.TabPage7);
      this.PanelSpecFeatures.Controls.Add((Control) this.DGSpecialFeatures);
      this.DGSpecialFeatures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.DGSpecialFeatures.CellClick += (DataGridViewCellEventHandler) ((a0, a1) => this.SetCurrSpecialfeature());
      this.ReadClients();
      this.SetColDropDownWith(this.PartyFloors, 500);
      this.SetColDropDownWith(this.PartyWalls, 650);
      this.SetColDropDownWith(this.PartyCeilings, 500);
      this.SetColDropDownWith(this.Floors, 500);
      this.SetColDropDownWith(this.Walls, 500);
      this.SetColDropDownWith(this.Roofs, 500);
      this.SetColDropDownWith(this.InternalCeiling, 500);
      this.SetColDropDownWith(this.InternalFloor, 500);
      this.SetColDropDownWith(this.InternalWall, 500);
      SAP_Module.CurrVersion = Debugger.IsAttached ? "Debug Mode" : "Version: " + MyProject.Application.Deployment.CurrentVersion.ToString();
      try
      {
        object folderPath = (object) Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012")));
        if (!directoryInfo.Exists)
          directoryInfo.Create();
        FileInfo fileInfo = new FileInfo(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(folderPath, (object) "\\Stroma SAP 2012\\Settings.set")));
        if (fileInfo.Exists)
        {
          UserSettings.USettings = UserSettings.GetSettings(fileInfo.FullName);
          if (UserSettings.USettings.Files != null)
            Functions.FillFiles();
        }
        else
        {
          int num = checked (this.RecentProjectsToolStripMenuItem.DropDownItems.Count - 1);
          int index = 0;
          while (index <= num)
          {
            this.RecentProjectsToolStripMenuItem.DropDownItems[index].Visible = false;
            checked { ++index; }
          }
        }
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(UserSettings.USettings.Version, SAP_Module.CurrVersion, false) > 0U)
        {
          UserSettings.USettings.Version = SAP_Module.CurrVersion;
          int num = (int) MyProject.Forms.Updates.ShowDialog();
          UserSettings.SaveSettings(UserSettings.USettings, fileInfo.FullName);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.SortComboBoxes((Control) this);
      this.DoubleBuffered = true;
      SAP_Module.ChangeNow = true;
      SAP_Module.View = "Project Details";
      this.PanelHome.Dock = DockStyle.Fill;
      this.PanelHouseDetails.Dock = DockStyle.Fill;
      this.PanelProject.Dock = DockStyle.Fill;
      this.PanelDimensions.Dock = DockStyle.Fill;
      this.PanelElements.Dock = DockStyle.Fill;
      this.PanelHeating.Dock = DockStyle.Fill;
      this.PanelOpenings.Dock = DockStyle.Fill;
      this.PanelVentilation.Dock = DockStyle.Fill;
      Functions.ReDime();
      this.PanelHome.BringToFront();
      Functions.MakeTree();
      SAP_Module.PCDFData = new PCDF(Application.StartupPath + "\\Data\\pcdf2012.dat");
      this.txtYearBuilt.Value = new Decimal(DateAndTime.Now.Year);
      SAP_Module.ChangeNow = false;
      DateAndTime.Now.Year.ToString();
      DataGridView dgVentData = this.DGVentData;
      dgVentData.Columns.Clear();
      dgVentData.Rows.Clear();
      dgVentData.Columns.Add("C1", "C1");
      dgVentData.Columns.Add("C2", "C2");
      dgVentData.Rows.Add(10);
      dgVentData.Columns[1].Width = 230;
      dgVentData.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      dgVentData[0, 0].Value = (object) "Manufacturer";
      dgVentData[0, 1].Value = (object) "Brand";
      dgVentData[0, 2].Value = (object) "Model Name";
      dgVentData[0, 3].Value = (object) "Model Qualifier";
      dgVentData[0, 4].Value = (object) "First Manufactored";
      dgVentData[0, 5].Value = (object) "Last Manufactored";
      dgVentData[0, 6].Value = (object) "Main Type";
      dgVentData[0, 7].Value = (object) "Ducting Type";
      dgVentData[0, 8].Value = (object) "Exhaust";
      dgVentData[0, 9].Value = (object) "Date";
      dgVentData.Rows[6].Height = checked ((int) Math.Round(unchecked ((double) dgVentData.Rows[6].Height * 1.5)));
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) > 0U)
        {
          string str = Microsoft.VisualBasic.Strings.Mid(Left.Replace("%20", " "), 9);
          SAP_Module.Proj = Functions.GetFileContents(str);
          SAP_Module.CurrDwelling = -1;
          Functions.MakeTree();
          this.DontSave = true;
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
          SAP_Module.Proj.SaveFileName = str;
          Functions.AddFile(str);
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
        this.DontSave = false;
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.CurrVersion, "Debug Mode", false) > 0U)
        this.SEDBUKUPdate.RunWorkerAsync();
      this.lblStatus.Text = "Stroma FSAP 2012 " + SAP_Module.CurrVersion + "  :  " + Conversions.ToString(DateAndTime.Now) + "  :  Boiler Database Version = " + SAP_Module.PCDFData.Version + ", Dated : " + Conversions.ToString(SAP_Module.PCDFData.VersionDate);
      SAP_Module.DataBVersion = Conversions.ToInteger(SAP_Module.PCDFData.Version);
    }

    public bool Found(string Name)
    {
      bool flag;
      try
      {
        if (Name != null)
        {
          if (Name.Contains("/"))
            flag = true;
          if (Name.Contains("\\"))
            flag = true;
          if (Name.Contains(":"))
            flag = true;
          if (Name.Contains("."))
            flag = true;
          if (Name.Contains(";"))
            flag = true;
          if (Name.Contains("?"))
            flag = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private void TreeSAP_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.LblError.Visible = false;
      this.LblError.Text = "";
      this.lblImportedYvalue.Visible = false;
      this.lblImportedYvalue.Text = "";
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (!this.DontSave)
      {
        if (SAP_Module.CurrDwelling != -1)
          SAP_Write.SaveDetails();
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.View, "Project Details", false) == 0)
          SAP_Write.SaveDetails();
      }
      if (e.Node.Level == 1 | e.Node.Level == 2)
      {
        if ((double) SAP_Module.CurrDwelling != Conversion.Val(e.Node.Name))
          SAP_Module.CurrDwelling = checked ((int) Math.Round(Conversion.Val(e.Node.Name)));
        Functions.CalculateNow();
      }
      try
      {
        SAP_Read.LockData();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (e.Node.Level == 1)
      {
        if (this.Found(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name))
        {
          int num = (int) Interaction.MsgBox((object) "There is an invalid character in Dwelling name", MsgBoxStyle.Critical, (object) "Stroma Certification");
        }
        SAP_Read.ReadDwellingDetails();
        this.PanelHouseDetails.BringToFront();
        this.Check_Tenure();
        Validation.CheckErrors_Propertys(SAP_Module.CurrDwelling);
        this.cmdArea.Visible = false;
        SAP_Module.View = "House Details";
        PDFFunctions.Current_View = 0;
      }
      else if (e.Node.Level == 2)
      {
        switch (e.Node.Index)
        {
          case 0:
            SAP_Module.View = "Dimensions";
            SAP_Read.ReadDimensions();
            this.PanelDimensions.BringToFront();
            Validation.CheckErrors_Dims(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 1;
            break;
          case 1:
            SAP_Module.View = "Opaque Elements";
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Imported09)
            {
              if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb)
              {
                this.lblImportedYvalue.Visible = true;
                this.lblImportedYvalue.Text = "Imported Y-Value used is :" + Conversions.ToString(Math.Round(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ImportedYvalue, 2));
              }
              else
              {
                this.lblImportedYvalue.Visible = false;
                this.lblImportedYvalue.Text = "";
              }
            }
            else
            {
              this.lblImportedYvalue.Visible = false;
              this.lblImportedYvalue.Text = "";
            }
            SAP_Read.ReadFloors();
            SAP_Read.ReadWalls();
            SAP_Read.ReadRoofs();
            SAP_Read.ReadThermal();
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas = true;
            this.chkGross.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas;
            this.PanelElements.BringToFront();
            Validation.CheckErrors_Opaque(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 2;
            break;
          case 2:
            SAP_Module.View = "Openings";
            SAP_Read.ReadWindows();
            SAP_Read.ReadDoors();
            SAP_Read.ReadRoofLights();
            this.PanelOpenings.BringToFront();
            Validation.CheckErrors_Openings(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 3;
            break;
          case 3:
            SAP_Module.View = "Ventilation";
            SAP_Read.ReadVentilation();
            this.PanelVentilation.BringToFront();
            Validation.CheckErrors_Openings(SAP_Module.CurrDwelling);
            Validation.CheckErrors_Ventilation(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 4;
            break;
          case 4:
            SAP_Module.View = "Heating";
            SAP_Read.ReadMainHeating();
            SAP_Read.ReadMainHeating2();
            SAP_Read.ReadSecHeating();
            this.PanelHeating.BringToFront();
            Validation.CheckErrors_Heating(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 5;
            break;
          case 5:
            SAP_Module.View = "Water Heating";
            SAP_Read.ReadWater();
            SAP_Read.ReadSolar();
            this.PanelWater.BringToFront();
            Validation.CheckErrors_WaterHeating(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 6;
            break;
          case 6:
            SAP_Module.View = "Renewable";
            SAP_Read.ReadRenewables();
            this.PanelRenewable.BringToFront();
            Validation.CheckErrors_RenewableTech(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 7;
            break;
          case 7:
            SAP_Module.View = "OverHeating";
            if (this.dataGridConstruction.DataSource == null)
            {
              this.dataGridConstruction.DataSource = (object) SAP_Module.PCDFData.Table_P7s;
              this.dataGridConstruction.Columns[0].Visible = false;
              this.dataGridConstruction.Columns[1].Width = checked (this.dataGridConstruction.Width - 20);
              this.dataGridConstruction.Columns[2].Visible = false;
            }
            SAP_Read.ReadOverHeating();
            this.PanelOverheating.BringToFront();
            Validation.CheckErrors_Overheating(SAP_Module.CurrDwelling);
            PDFFunctions.Current_View = 8;
            break;
        }
        if ((uint) e.Node.Index > 0U)
          this.cmdArea.Visible = false;
      }
      else if (e.Node.Level == 0)
      {
        SAP_Read.ReadProjectDetails();
        this.PanelProject.BringToFront();
        this.cmdArea.Visible = false;
        SAP_Module.View = "Project Details";
        if (!SAP_Module.DontChange)
          SAP_Module.CurrDwelling = -1;
        this.DwellingDetails.Panel2Collapsed = true;
        this.SplitContainer2.Panel2Collapsed = true;
        this.Button3.Visible = false;
        this.lblDwellingDER.Visible = false;
        this.txtDwellingDER.Visible = false;
        this.Sep1.Visible = false;
        this.lblDwellingTER.Visible = false;
        this.txtDwellingTER.Visible = false;
        this.txtTFEE.Visible = false;
        this.lblDwellingTFEE.Visible = false;
        this.lblDwellingFEE.Visible = false;
        this.txtDwellingFEE.Visible = false;
        this.Sep2.Visible = false;
        this.cmdCompliance.Visible = false;
        MyProject.Forms.GenResults.Visible = false;
        this.lblSmoke.Text = "";
      }
      Functions.Updatelabel();
      if ((uint) e.Node.Level <= 0U)
        ;
      if (this.CheckHTB())
      {
        this.txtDwellingTER.Visible = false;
        this.txtTFEE.Visible = false;
        this.ReportsToolStripMenuItem.Enabled = false;
      }
      else
      {
        this.ReportsToolStripMenuItem.Enabled = true;
        try
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "England", false) == 0)
          {
            this.txtDwellingTER.Visible = true;
            this.txtTFEE.Visible = true;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public bool CheckHTB()
    {
      bool flag;
      if (SAP_Module.CurrDwelling != -1)
      {
        int count1;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions != null)
          count1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Count;
        int count2;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions != null)
          count2 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Count;
        int count3;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions != null)
          count3 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Count;
        if (count3 == 0 & count2 == 0 & count1 == 0 & (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue == 0.0)
          flag = true;
      }
      return flag;
    }

    private void ProjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.NoOfDwells > 0 | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Name, "", false) > 0U)
      {
        switch (Interaction.MsgBox((object) "Do you want to save the current project?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question, (object) "Open File?"))
        {
          case MsgBoxResult.Cancel:
            return;
          case MsgBoxResult.Yes:
            this.SaveProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
        }
      }
      SAP_Module.Proj = new SAP_Module.Project();
      SAP_Module.Proj.ProjectDate = DateAndTime.Now;
      SAP_Module.Proj.Version = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.CurrVersion, "Debug Mode", false) != 0 ? MyProject.Application.Deployment.CurrentVersion.ToString() : SAP_Module.DebugVersion;
      SAP_Module.CurrDwelling = -1;
      Functions.ReDime();
      this.PanelProject.BringToFront();
      SAP_Module.Proj.Name = "New Project";
      this.txtProjName.Text = SAP_Module.Proj.Name;
      this.txtProjName.Focus();
      Functions.MakeTree();
      this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
    }

    private void DwellingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        Application.DoEvents();
        // ISSUE: variable of a reference type
        int& local1;
        // ISSUE: explicit reference operation
        int num = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
        local1 = num;
        // ISSUE: variable of a reference type
        SAP_Module.Dwelling[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
        local2 = dwellingArray;
        SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = "House " + Conversions.ToString(SAP_Module.Proj.NoOfDwells);
        SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].YearBuilt = DateAndTime.Now.Year;
        SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Thermal.YValue = 0.15f;
        SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].DateDwellingCreated = DateAndTime.Now;
        SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Thermal.ConstDetails = "No information on thermal bridging (y=0.15)";
        SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
        Functions.MakeTree();
        SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void NewToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
    {
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Name, "", false) > 0U)
        this.DwellingToolStripMenuItem.Enabled = true;
      else
        this.DwellingToolStripMenuItem.Enabled = false;
    }

    private void ToolStripButton1_Click(object sender, EventArgs e) => this.ProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void ToolStripButton2_Click(object sender, EventArgs e) => this.DwellingToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void txtProjName_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(true);

    private void txtPRef_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPAdd1_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPAdd2_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPAdd3_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCountry_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPPCode_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCNAme_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCAdd1_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCAdd2_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCAdd3_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCCity_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCCountry_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCPCode_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCPhone_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCFax_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void txtPCEmail_LostFocus(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(false);

    private void SAPForm_Resize(object sender, EventArgs e)
    {
      if (!this._onlyOnce)
        this.SplitContainer2.SplitterDistance = checked (this.Width - this.SplitContainer1.SplitterDistance - 350);
      this._onlyOnce = true;
    }

    private void cmdShortAddress_MouseLeave(object sender, EventArgs e)
    {
    }

    private void cmdShortAddress_MouseMove(object sender, MouseEventArgs e)
    {
    }

    private void cmdLongAddress_MouseLeave(object sender, EventArgs e)
    {
    }

    private void cmdLongAddress_MouseMove(object sender, MouseEventArgs e)
    {
    }

    private void cmdShortAddress_Click(object sender, EventArgs e)
    {
    }

    private void cmdLongAddress_Click(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDPostCode.Text, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please enter a valid postcode first!", MsgBoxStyle.Critical, (object) "Missing Postcode");
      }
      else
      {
        try
        {
          this.cboAddress.DataSource = (object) null;
          this.cboAddress.Items.Clear();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        Application.DoEvents();
        this.txtPleaseWait1.Visible = true;
        Application.DoEvents();
        SAPSoapClient sapSoapClient = new SAPSoapClient();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        {
          Functions.Access_Details();
          Stroma_DomesticScotlandSoapClient scotlandSoapClient = new Stroma_DomesticScotlandSoapClient();
          ReturnObject returnObject = new ReturnObject();
          try
          {
            returnObject = scotlandSoapClient.AddressSearch(true, Microsoft.VisualBasic.Strings.UCase(this.txtDPostCode.Text), Functions.TransactionID, Functions.Encrypt);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num2 = (int) Interaction.MsgBox((object) "No addresses were found on this postcode!", MsgBoxStyle.Critical, (object) "Missing Postcode");
            ProjectData.ClearProjectError();
          }
          if (returnObject.Xdoc == null)
          {
            int num3 = (int) Interaction.MsgBox((object) "No addresses were found on this selection", MsgBoxStyle.Information, (object) "FSAP 2012");
            this.txtPleaseWait1.Visible = false;
            return;
          }
          XDocument xdocument1 = new XDocument();
          XDocument xdocument2 = XDocument.Parse(returnObject.Xdoc);
          XNamespace defaultNamespace = xdocument2.Root.GetDefaultNamespace();
          this.Address_List = (object) new List<SAPForm.ScotAddress>();
          IEnumerable<XElement> source = xdocument2.Descendants(defaultNamespace + "Property");
          Func<XElement, XElement> selector;
          // ISSUE: reference to a compiler-generated field
          if (SAPForm._Closure\u0024__.\u0024I59\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector = SAPForm._Closure\u0024__.\u0024I59\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            SAPForm._Closure\u0024__.\u0024I59\u002D0 = selector = (Func<XElement, XElement>) (b => b);
          }
          List<XElement> list = source.Select<XElement, XElement>(selector).ToList<XElement>();
          try
          {
            foreach (XElement xelement in list)
              NewLateBinding.LateCall(this.Address_List, (System.Type) null, "Add", new object[1]
              {
                (object) this.Get_Address(xelement, defaultNamespace)
              }, (string[]) null, (System.Type[]) null, (bool[]) null, true);
          }
          finally
          {
            List<XElement>.Enumerator enumerator;
            enumerator.Dispose();
          }
          this.cboAddress.DisplayMember = "DisplayAddress";
          this.cboAddress.DataSource = RuntimeHelpers.GetObjectValue(this.Address_List);
          if (this.cboAddress.Items.Count > 0)
            this.Panel2.Visible = true;
          this.txtPleaseWait1.Visible = false;
        }
        else
        {
          Functions.Access_Details();
          try
          {
            AddressRequest Request = new AddressRequest()
            {
              Security = new SecurityClass()
              {
                Encryption = Functions.Encrypt,
                Transaction = Functions.TransactionID
              },
              Selection = new SelectionClass()
              {
                Assessment = AssessmentType.SAP,
                Country = CountryType.England,
                Environment = EnviornmentType.LIVE
              }
            };
            AddressResult addressResult = sapSoapClient.AddressSearch(this.txtDPostCode.Text, Request);
            if (addressResult.Success)
            {
              AddressDetails[] address = addressResult.Address;
              Func<AddressDetails, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (SAPForm._Closure\u0024__.\u0024I59\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = SAPForm._Closure\u0024__.\u0024I59\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAPForm._Closure\u0024__.\u0024I59\u002D1 = predicate = (Func<AddressDetails, bool>) (b => b.UPRN.Contains("UPRN"));
              }
              IEnumerable<AddressDetails> source = ((IEnumerable<AddressDetails>) address).Where<AddressDetails>(predicate);
              Func<AddressDetails, AddressDetails> selector;
              // ISSUE: reference to a compiler-generated field
              if (SAPForm._Closure\u0024__.\u0024I59\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                selector = SAPForm._Closure\u0024__.\u0024I59\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAPForm._Closure\u0024__.\u0024I59\u002D2 = selector = (Func<AddressDetails, AddressDetails>) (b => b);
              }
              this.cboAddress.DataSource = (object) this.GetAddresses(source.Select<AddressDetails, AddressDetails>(selector).ToArray<AddressDetails>());
              this.cboAddress.DisplayMember = "DisplayAddress";
            }
            else
              this.cboAddress.DataSource = (object) null;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num4 = (int) Interaction.MsgBox((object) "No addresses were found on this postcode!", MsgBoxStyle.Critical, (object) "Missing Postcode");
            ProjectData.ClearProjectError();
          }
        }
        if (this.cboAddress.Items.Count > 0)
          this.Panel2.Visible = true;
        this.txtPleaseWait1.Visible = false;
      }
    }

    private List<SAPForm.ScotAddress> GetAddresses(AddressDetails[] addressDetails)
    {
      List<SAPForm.ScotAddress> addresses = new List<SAPForm.ScotAddress>();
      AddressDetails[] addressDetailsArray = addressDetails;
      int index = 0;
      while (index < addressDetailsArray.Length)
      {
        AddressDetails addressDetails1 = addressDetailsArray[index];
        SAPForm.ScotAddress scotAddress1 = new SAPForm.ScotAddress()
        {
          AddressLine1 = addressDetails1.AddressLine1,
          AddressLine2 = addressDetails1.AddressLine2,
          AddressLine3 = addressDetails1.AddressLine3,
          City = addressDetails1.City,
          Postcode = addressDetails1.PostCode,
          UPRN = addressDetails1.UPRN
        };
        scotAddress1.DisplayAddress = scotAddress1.AddressLine1 + ", ";
        SAPForm.ScotAddress scotAddress2;
        string str1 = (scotAddress2 = scotAddress1).DisplayAddress + scotAddress1.AddressLine2 + ", ";
        scotAddress2.DisplayAddress = str1;
        SAPForm.ScotAddress scotAddress3;
        string str2 = (scotAddress3 = scotAddress1).DisplayAddress + scotAddress1.AddressLine3 + ", ";
        scotAddress3.DisplayAddress = str2;
        SAPForm.ScotAddress scotAddress4;
        string str3 = (scotAddress4 = scotAddress1).DisplayAddress + scotAddress1.City + ", ";
        scotAddress4.DisplayAddress = str3;
        SAPForm.ScotAddress scotAddress5;
        string str4 = (scotAddress5 = scotAddress1).DisplayAddress + scotAddress1.Postcode;
        scotAddress5.DisplayAddress = str4;
        addresses.Add(scotAddress1);
        checked { ++index; }
      }
      return addresses;
    }

    private SAPForm.ScotAddress Get_Address(XElement Item, XNamespace NS)
    {
      SAPForm.ScotAddress address = new SAPForm.ScotAddress();
      XElement xelement = Item.Element(NS + "Address");
      if (xelement.Element(NS + "Address-Line-1") != null)
        address.AddressLine1 = xelement.Element(NS + "Address-Line-1").Value;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(address.AddressLine1, "", false) == 0)
      {
        if (xelement.Element(NS + "Address-Line-2") != null)
          address.AddressLine1 = xelement.Element(NS + "Address-Line-2").Value;
      }
      else if (xelement.Element(NS + "Address-Line-2") != null)
        address.AddressLine2 = xelement.Element(NS + "Address-Line-2").Value;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(address.AddressLine2, "", false) == 0)
      {
        if (xelement.Element(NS + "Address-Line-3") != null)
          address.AddressLine2 = xelement.Element(NS + "Address-Line-3").Value;
      }
      else if (xelement.Element(NS + "Address-Line-3") != null)
        address.AddressLine3 = xelement.Element(NS + "Address-Line-3").Value;
      if (xelement.Element(NS + "Post-Town") != null)
        address.City = xelement.Element(NS + "Post-Town").Value;
      if (xelement.Element(NS + "Postcode") != null)
        address.Postcode = xelement.Element(NS + "Postcode").Value;
      address.DisplayAddress = "";
      SAPForm.ScotAddress scotAddress1;
      string str1 = (scotAddress1 = address).DisplayAddress + address.AddressLine1 + ", ";
      scotAddress1.DisplayAddress = str1;
      SAPForm.ScotAddress scotAddress2;
      string str2 = (scotAddress2 = address).DisplayAddress + address.AddressLine2 + ", ";
      scotAddress2.DisplayAddress = str2;
      SAPForm.ScotAddress scotAddress3;
      string str3 = (scotAddress3 = address).DisplayAddress + address.AddressLine3 + ", ";
      scotAddress3.DisplayAddress = str3;
      SAPForm.ScotAddress scotAddress4;
      string str4 = (scotAddress4 = address).DisplayAddress + address.City + ", ";
      scotAddress4.DisplayAddress = str4;
      address.DisplayAddress = address.DisplayAddress.Substring(0, checked (address.DisplayAddress.Length - 3));
      address.UPRN = Item.Element(NS + "UPRN").Value;
      return address;
    }

    private void cmdAddressConfirm_Click(object sender, EventArgs e)
    {
      int num1;
      int num2;
      try
      {
        this.txtPleaseWait2.Visible = true;
        Application.DoEvents();
        ProjectData.ClearProjectError();
        num1 = 2;
        SAPSoapClient sapSoapClient = new SAPSoapClient();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAddress.Text, "", false) == 0)
        {
          this.txtPleaseWait2.Visible = false;
          goto label_13;
        }
        else
        {
          SAPForm.ScotAddress scotAddress = new SAPForm.ScotAddress();
          SAPForm.ScotAddress selectedItem = (SAPForm.ScotAddress) this.cboAddress.SelectedItem;
          this.txtDAdd1.Text = selectedItem.AddressLine1;
          this.txtDAdd2.Text = selectedItem.AddressLine2;
          this.txtDAdd3.Text = selectedItem.AddressLine3;
          this.txtDCity.Text = selectedItem.City;
          this.txtDPostCode.Text = selectedItem.Postcode;
          this.txtUPRN.Text = selectedItem.UPRN;
          SAP_Write.WriteDwellingDetails(false);
          this.txtPleaseWait2.Visible = false;
          this.Panel2.Visible = false;
          if (!this.DontSave & SAP_Module.CurrDwelling != -1)
            SAP_Write.SaveDetails();
          if (SAP_Module.CurrDwelling != -1)
          {
            Functions.CalculateNow();
            goto label_13;
          }
          else
            goto label_13;
        }
label_8:
        num2 = -1;
        switch (num1)
        {
          case 2:
            this.txtPleaseWait2.Visible = false;
            int num3 = (int) Interaction.MsgBox((object) Information.Err().Description);
            goto label_13;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_8;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_13:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void txtDName_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(true);

    private void txtDRef_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDDate_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDAdd1_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDAdd2_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDAdd3_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDCity_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDCountry_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtDPostCode_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void cmdGetMyDetails_Click(object sender, EventArgs e)
    {
    }

    private void Dims_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 2)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdArea.Top = checked (41 + e.RowIndex * 22);
        this.cmdArea.Visible = true;
        this.cmdArea.Left = checked (this.Dims.RowHeadersWidth + this.Dims.Columns[0].Width + this.Dims.Columns[1].Width + this.Dims.Columns[2].Width + 5);
      }
      else
        this.cmdArea.Visible = false;
      try
      {
        if (e.ColumnIndex == 0 | e.ColumnIndex == 4)
          SendKeys.Send("{TAB}");
        else if (e.ColumnIndex == 1 && (uint) e.RowIndex > 0U)
          SendKeys.Send("{TAB}");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      this.RedoDims();
      if (this.Visible)
        this.AddCalcHandle();
    }

    public void RedoDims()
    {
      SAP_Module.ChangeNow = true;
      if (this.Dims.RowCount > 2)
        this.chkRoomInRoof.Enabled = true;
      else
        this.chkRoomInRoof.Enabled = false;
      int num = checked (this.Dims.RowCount - 1);
      int rowIndex = 0;
      float Expression1;
      float Expression2;
      while (rowIndex <= num)
      {
        if (rowIndex != checked (this.Dims.RowCount - 1))
        {
          if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value)) & !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.Dims[3, rowIndex].Value)))
          {
            this.Dims[4, rowIndex].Value = (object) Microsoft.VisualBasic.Strings.Format((object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[3, rowIndex].Value))), "#0.00");
            Expression1 += (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[2, rowIndex].Value));
            Expression2 += (float) Conversion.Val(RuntimeHelpers.GetObjectValue(this.Dims[4, rowIndex].Value));
          }
          this.Dims[0, rowIndex].Value = rowIndex != 0 ? (object) ("+" + Conversions.ToString(rowIndex)) : (object) "Lowest Floor";
          if (this.Dims.RowCount > 2 & rowIndex == checked (this.Dims.RowCount - 2) & this.chkRoomInRoof.Enabled & this.chkRoomInRoof.Checked)
            this.Dims[0, rowIndex].Value = (object) "Roof room";
        }
        if ((uint) rowIndex > 0U)
        {
          this.Dims[1, rowIndex].ReadOnly = true;
          this.Dims[1, rowIndex].Style.BackColor = Color.LightGray;
        }
        else
        {
          this.Dims[1, rowIndex].ReadOnly = false;
          this.Dims[1, rowIndex].Style.BackColor = Color.White;
        }
        checked { ++rowIndex; }
      }
      this.txtDimStoreys.Text = Conversions.ToString(checked (this.Dims.RowCount - 1));
      this.txtDimsArea.Text = Microsoft.VisualBasic.Strings.Format((object) Expression1, "#0.00");
      this.txtDimsVolume.Text = Microsoft.VisualBasic.Strings.Format((object) Expression2, "#0.00");
      SAP_Write.WriteDimensions(false);
      SAP_Module.ChangeNow = false;
    }

    private void chkRoomInRoof_CheckedChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      this.RedoDims();
    }

    private void cmdArea_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow = this.Dims;
      if (this.Dims.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.Dims.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims.Length >= checked (SAP_Module.RowNow + 1))
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L1);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W1);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L2);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W2);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L3);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W3);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L4);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W4);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L5);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W5);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L6);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W6);
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      SendKeys.SendWait("\t");
    }

    private void Dims_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      this.RedoDims();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Floors_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 4)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdFloorArea.Left = checked (this.Floors.RowHeadersWidth + this.Floors.Columns[0].Width + this.Floors.Columns[1].Width + this.Floors.Columns[2].Width + this.Floors.Columns[3].Width + this.Floors.Columns[4].Width + 5);
        this.cmdFloorArea.Top = checked (this.Floors.Top + this.Floors.ColumnHeadersHeight + e.RowIndex * 22 - this.Floors.VerticalScrollingOffset);
        this.cmdFloorArea.Visible = true;
      }
      else
        this.cmdFloorArea.Visible = false;
      if (e.ColumnIndex == 5)
      {
        this.UValueType = "Floor";
        Point mousePosition = Control.MousePosition;
        checked { mousePosition.X += 3; }
        checked { mousePosition.Y += 10; }
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        if (!this.DontShowUValueList)
          this.ctxUValue.Show(mousePosition);
      }
    }

    private void cmdFloorArea_Click(object sender, EventArgs e)
    {
      if (this.Floors.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.Floors;
      SAP_Module.RowNow = this.Floors.CurrentCell.RowIndex;
      if (this.Floors.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.Floors.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void Walls_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 4)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdWallArea.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + this.Walls.Columns[4].Width + 5 - this.Walls.HorizontalScrollingOffset);
        this.cmdWallArea.Top = checked (this.Walls.Top + this.Walls.ColumnHeadersHeight + e.RowIndex * 22 - this.Walls.VerticalScrollingOffset);
        this.cmdGetWallArea.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + 5 - this.Walls.HorizontalScrollingOffset);
        this.cmdGetWallArea.Top = checked (this.Walls.Top + this.Walls.ColumnHeadersHeight + e.RowIndex * 22 - this.Walls.VerticalScrollingOffset);
        this.cmdWallArea.Visible = true;
      }
      else
      {
        this.cmdWallArea.Visible = false;
        this.cmdGetWallArea.Visible = false;
      }
      if (e.ColumnIndex == 5)
      {
        this.UValueType = "Wall";
        Point mousePosition = Control.MousePosition;
        checked { mousePosition.X += 3; }
        checked { mousePosition.Y += 10; }
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        if (!this.DontShowUValueList)
          this.ctxUValue.Show(mousePosition);
      }
      if (e.ColumnIndex == 6)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdWallShelter.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + this.Walls.Columns[4].Width + this.Walls.Columns[5].Width + this.Walls.Columns[6].Width + 5 - this.Walls.HorizontalScrollingOffset);
        this.cmdWallShelter.Top = checked (this.Walls.Top + this.Walls.ColumnHeadersHeight + e.RowIndex * 22 - this.Walls.VerticalScrollingOffset);
        this.cmdWallShelter.Visible = true;
      }
      else
        this.cmdWallShelter.Visible = false;
    }

    private void cmdWallArea_Click(object sender, EventArgs e)
    {
      if (this.Walls.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.Walls;
      SAP_Module.RowNow = this.Walls.CurrentCell.RowIndex;
      if (this.Walls.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.Walls.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void cmdRoofArea_Click(object sender, EventArgs e)
    {
      if (this.Roofs.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.Roofs;
      SAP_Module.RowNow = this.Roofs.CurrentCell.RowIndex;
      if (this.Roofs.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.Roofs.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void cmdFloorShelter_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow = this.Floors;
      if (MyProject.Forms.Shelter.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.Shelter.txtRu.Text;
      SendKeys.SendWait("\t");
    }

    private void cmdWallShelter_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow = this.Walls;
      if (MyProject.Forms.Shelter.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.Shelter.txtRu.Text;
      SendKeys.SendWait("\t");
    }

    private void cmdRoofShelter_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow = this.Roofs;
      Shelter shelter = new Shelter();
      shelter.TabControl1.TabPages.Remove(shelter.TabPage1);
      shelter.TabControl1.TabPages.Remove(shelter.TabPage2);
      if (shelter.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.Shelter.txtRu.Text;
      SendKeys.SendWait("\t");
    }

    private void Roofs_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 4)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdRoofArea.Left = checked (this.Roofs.RowHeadersWidth + this.Roofs.Columns[0].Width + this.Roofs.Columns[1].Width + this.Roofs.Columns[2].Width + this.Roofs.Columns[3].Width + this.Roofs.Columns[4].Width + 5);
        this.cmdRoofArea.Top = checked (this.Roofs.Top + this.Roofs.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdRoofArea.Visible = true;
      }
      else
        this.cmdRoofArea.Visible = false;
      if (e.ColumnIndex == 5)
      {
        this.UValueType = "Roof";
        Point mousePosition = Control.MousePosition;
        checked { mousePosition.X += 3; }
        checked { mousePosition.Y += 10; }
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        if (!this.DontShowUValueList)
          this.ctxUValue.Show(mousePosition);
      }
      if (e.ColumnIndex == 6)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdRoofShelter.Left = checked (this.Roofs.RowHeadersWidth + this.Roofs.Columns[0].Width + this.Roofs.Columns[1].Width + this.Roofs.Columns[2].Width + this.Roofs.Columns[3].Width + this.Roofs.Columns[4].Width + this.Roofs.Columns[5].Width + this.Roofs.Columns[6].Width + 5);
        this.cmdRoofShelter.Top = checked (this.Roofs.Top + this.Roofs.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdRoofShelter.Visible = true;
      }
      else
        this.cmdRoofShelter.Visible = false;
    }

    private void Floors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteFloors();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Walls_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (!SAP_Module.ChangeNow)
      {
        SAP_Write.WriteWalls();
        if (this.Visible)
          this.AddCalcHandle();
      }
      try
      {
        int num = checked (this.Walls.RowCount - 2);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.Walls[7, rowIndex].Value = (object) Microsoft.VisualBasic.Strings.Format(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject((object) 1, this.Walls[5, rowIndex].Value), this.Walls[6, rowIndex].Value)), "0.00");
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Roofs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (!SAP_Module.ChangeNow)
      {
        SAP_Write.WriteRoofs();
        if (this.Visible)
          this.AddCalcHandle();
      }
      try
      {
        int num = checked (this.Roofs.RowCount - 2);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          this.Roofs[7, rowIndex].Value = (object) Microsoft.VisualBasic.Strings.Format(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject((object) 1, Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject((object) 1, this.Roofs[5, rowIndex].Value), this.Roofs[6, rowIndex].Value)), "0.00");
          checked { ++rowIndex; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.Name.Contains("\\") | SAP_Module.Proj.Name.Contains("/") | SAP_Module.Proj.Name.Contains(":"))
      {
        int num1 = (int) Interaction.MsgBox((object) "Incorrect Project name! Please  avoid naming project name with slash or colons", MsgBoxStyle.Information, (object) "Save Project error.");
      }
      else if (string.IsNullOrEmpty(SAP_Module.Proj.Name))
      {
        int num2 = (int) Interaction.MsgBox((object) "Incorrect Project Name. Please make sure you have entered a Project Name. This is to prevent loss of work.", MsgBoxStyle.Information, (object) "Save Project error.");
      }
      else
      {
        SAP_Write.SaveDetails();
        string str;
        if (SAP_Module.Proj.SaveFileName != null)
        {
          str = SAP_Module.Proj.SaveFileName;
        }
        else
        {
          this.SaveFileDialog1.Filter = "Stroma SAPs (*.sts2012)|*.sts2012";
          int num3 = (int) this.SaveFileDialog1.ShowDialog();
          str = this.SaveFileDialog1.FileName;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0)
          return;
        SAP_Module.Proj.SaveFileName = str;
        Functions.SaveFile(SAP_Module.Proj, str);
        Functions.AddFile(str);
      }
    }

    private void IsFileOpen(FileInfo file)
    {
      try
      {
        System.IO.File.Open(file.FullName, FileMode.Open, FileAccess.Read, FileShare.None).Lock(0L, 100L);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) Interaction.MsgBox((object) "File is already open in another location", MsgBoxStyle.Information, (object) "File Information.");
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static bool IsFileLocked(Exception exception)
    {
      int num = Marshal.GetHRForException(exception) & (int) ushort.MaxValue;
      return num == 32 || num == 33;
    }

    private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (SAP_Module.Proj.NoOfDwells > 0)
        {
          switch (Interaction.MsgBox((object) "Do you want to save the current project?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question, (object) "Open File?"))
          {
            case MsgBoxResult.Cancel:
              return;
            case MsgBoxResult.Yes:
              this.SaveProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
              break;
          }
        }
        this.OpenFileDialog1.FileName = "";
        this.OpenFileDialog1.Filter = "Stroma SAPs (*.sts2012)|*.sts2012";
        int num1 = (int) this.OpenFileDialog1.ShowDialog();
        string fileName = this.OpenFileDialog1.FileName;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileName, "", false) == 0)
          return;
        SAP_Module.Proj.SaveFileName = fileName;
        SAP_Module.Proj = Functions.GetFileContents(fileName);
        SAP_Module.CurrDwelling = -1;
        int num2 = checked (SAP_Module.Proj.Dwellings.Length - 1);
        int house = 0;
        while (house <= num2)
        {
          try
          {
            Validation.Checkerrors_All(house);
            SAP_Module.Proj.Dwellings[house].NoofpFloors = SAP_Module.Proj.Dwellings[house].PFloors.Length;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++house; }
        }
        Functions.MakeTree();
        this.DontSave = true;
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        SAP_Module.Proj.SaveFileName = fileName;
        Functions.AddFile(fileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.DontSave = false;
      }
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(SAP_Module.Proj.Name))
      {
        int num1 = (int) Interaction.MsgBox((object) "Incorrect Project Name. Please make sure you have entered a Project Name. This is to prevent loss of work.", MsgBoxStyle.Information, (object) "Save Project error.");
      }
      else
      {
        SAP_Write.SaveDetails();
        this.SaveFileDialog1.Filter = "Stroma SAPs (*.sts2012)|*.sts2012";
        int num2 = (int) this.SaveFileDialog1.ShowDialog();
        string fileName = this.SaveFileDialog1.FileName;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileName, "", false) == 0)
          return;
        SAP_Module.Proj.SaveFileName = fileName;
        Functions.SaveFile(SAP_Module.Proj, fileName);
        Functions.AddFile(fileName);
      }
    }

    private void txtPrimary_LostFocus(object sender, EventArgs e) => SAP_Write.WriteMainHeating();

    private void txtPrimary_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating.PrimaryHeatingGroupCheck();
      this.grpBoiler.Visible = false;
      this.grpStorage.Visible = false;
    }

    private void txtSubGroup_LostFocus(object sender, EventArgs e) => SAP_Write.WriteMainHeating();

    private void txtSubGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
      {
        Heating.PrimaryHeatingSubGroupCheck();
        this.grpBoiler.Visible = false;
      }
      this.txtHeatingEmitter.Enabled = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrimary.Text, "Room heaters", false) == 0)
      {
        this.txtHeatingEmitter.Enabled = false;
        this.txtHeatingEmitter.Text = "";
      }
      else
      {
        this.txtHeatingEmitter.Items.Clear();
        this.txtHeatingEmitter.Items.Add((object) "Systems with radiators");
        this.txtHeatingEmitter.Items.Add((object) "Underfloor heating, pipes in insulated timber floor");
        this.txtHeatingEmitter.Items.Add((object) "Underfloor heating, pipes in screed above insulation");
        this.txtHeatingEmitter.Items.Add((object) "Underfloor heating, pipes in concrete slab");
        this.txtHeatingEmitter.Items.Add((object) "Underfloor heating and radiators, pipes in insulated timber floor");
        this.txtHeatingEmitter.Items.Add((object) "Underfloor heating and radiators, pipes in screed above insulation");
        this.txtHeatingEmitter.Items.Add((object) "Underfloor heating and radiators, pipes in concrete slab");
        this.txtHeatingEmitter.Items.Add((object) "Fan coil units");
      }
      this.grpStorage.Visible = false;
    }

    private void txtHeatingSource_LostFocus(object sender, EventArgs e)
    {
      SAP_Write.WriteMainHeating();
      this.DoCheckFuel = false;
    }

    private void txtHeatingSource_MouseDown(object sender, MouseEventArgs e) => this.DoCheckFuel = true;

    private void txtHeatingSource_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
      {
        Heating.CheckSource();
        this.grpBoiler.Visible = false;
        this.grpStorage.Visible = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtHeatingSource.Text, "", false) == 0)
        this.txtBFlueType.Enabled = true;
      if (this.DoCheckFuel)
      {
        try
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "", false) > 0U)
            WaterHeating.PaniCheck(1, this.txtMainFuel.Text, SAP_Module.CurrDwelling);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
        {
          this.chkOilPump.Enabled = true;
          this.LBlManu.Visible = true;
        }
        else
          this.LBlManu.Visible = false;
      }
      else
        this.LBlManu.Visible = false;
    }

    private void cmdBiolerData_Click(object sender, EventArgs e)
    {
      PDFFunctions.MainHeating2Search = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubGroup.Text, "Micro-cogeneration (micro-CHP)", false) == 0)
      {
        int num1 = (int) MyProject.Forms.CHP_Search.ShowDialog();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubGroup.Text, "Solid fuel boilers", false) == 0)
      {
        int num2 = (int) MyProject.Forms.Solid_Search.ShowDialog();
      }
      else if (this.txtSubGroup.Text.Contains("heat pumps"))
      {
        int num3 = (int) MyProject.Forms.HeatPump_SearchFrm.ShowDialog();
      }
      else if (this.txtPrimary.Text.Equals("Warm air systems (Not heat pump)"))
      {
        WarmAirSearch warmAirSearch = new WarmAirSearch();
        if (warmAirSearch.ShowDialog() == DialogResult.OK)
        {
          PCDF.WarmAir dataBoundItem = (PCDF.WarmAir) warmAirSearch.dtgWarmAir.SelectedRows[0].DataBoundItem;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = dataBoundItem.ID;
          SAP_Read.CheckSEDBUK();
        }
      }
      else if (this.txtPrimary.Text.Equals("Community heating schemes"))
      {
        int num4 = (int) new CommunitySearch(CommunitySearch.Type.Heating).ShowDialog();
      }
      else
      {
        MyProject.Forms.Boiler_Database.Type = 1;
        int num5 = (int) MyProject.Forms.Boiler_Database.ShowDialog();
      }
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling == -1)
        return;
      Functions.CalculateNow();
    }

    private void cmdNewDoor_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please add a minimum of 1 wall prior to adding a door", MsgBoxStyle.Information, (object) "Wall Definition");
      }
      else
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int index = 0;
        bool flag;
        while (index <= num2)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index].Name == null)
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
        if (flag)
        {
          int num3 = (int) Interaction.MsgBox((object) "Please complete the name of all walls prior to adding a door", MsgBoxStyle.Information, (object) "Wall Definition");
        }
        else
        {
          SAP_Module.EditRow = false;
          SAP_Module.RowEdit = this.DataDoors.RowCount;
          if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors > 0U)
            MyProject.Forms.Doors.cmdPrevious.Enabled = true;
          else
            MyProject.Forms.Doors.cmdPrevious.Enabled = false;
          MyProject.Forms.Doors.cmdNext.Enabled = false;
          int num4 = (int) MyProject.Forms.Doors.ShowDialog();
          MyProject.Forms.Doors.Close();
          this.AddCalcHandle();
        }
      }
    }

    private void cmdNewWindow_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please add a minimum of 1 wall prior to adding a window", MsgBoxStyle.Information, (object) "Wall Definition");
      }
      else
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int index = 0;
        bool flag;
        while (index <= num2)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index].Name == null)
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
        if (flag)
        {
          int num3 = (int) Interaction.MsgBox((object) "Please complete the name of all walls prior to adding a window", MsgBoxStyle.Information, (object) "Wall Definition");
        }
        else
        {
          SAP_Module.EditRow = false;
          SAP_Module.RowEdit = this.DataWindows.RowCount;
          if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows > 0U)
            MyProject.Forms.Windows.cmdPrevious.Enabled = true;
          else
            MyProject.Forms.Windows.cmdPrevious.Enabled = false;
          MyProject.Forms.Windows.cmdNext.Enabled = false;
          int num4 = (int) MyProject.Forms.Windows.ShowDialog();
          MyProject.Forms.Windows.Close();
          this.AddCalcHandle();
        }
      }
    }

    private void cmdNewRoofLight_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please add a minimum of 1 roof prior to adding a window", MsgBoxStyle.Information, (object) "Roof Definition");
      }
      else
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1);
        int index = 0;
        bool flag;
        while (index <= num2)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index].Name == null)
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
        if (flag)
        {
          int num3 = (int) Interaction.MsgBox((object) "Please complete the name of all roofs prior to adding a roof window", MsgBoxStyle.Information, (object) "Roof Definition");
        }
        else
        {
          SAP_Module.EditRow = false;
          SAP_Module.RowEdit = this.DataRoofLights.RowCount;
          if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights > 0U)
            MyProject.Forms.RoofWindows.cmdPrevious.Enabled = true;
          else
            MyProject.Forms.RoofWindows.cmdPrevious.Enabled = false;
          MyProject.Forms.RoofWindows.cmdNext.Enabled = false;
          int num4 = (int) MyProject.Forms.RoofWindows.ShowDialog();
          MyProject.Forms.RoofWindows.Close();
          this.AddCalcHandle();
        }
      }
    }

    private void cmdEditWindow_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataWindows.CurrentRow.Index > -1)
        {
          DataGridView dataWindows = this.DataWindows;
          MyProject.Forms.Windows.txtName.Text = Conversions.ToString(dataWindows[0, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtLocation.Text = Conversions.ToString(dataWindows[1, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtUSource.Text = Conversions.ToString(dataWindows[2, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtOrientation.Text = Conversions.ToString(dataWindows[3, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtOvershading.Text = Conversions.ToString(dataWindows[4, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtGlazingType.Text = Conversions.ToString(dataWindows[5, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtAirGap.Text = Conversions.ToString(dataWindows[6, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtFrameType.Text = Conversions.ToString(dataWindows[7, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtThermalBreak.Text = Conversions.ToString(dataWindows[8, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtWidth.Text = Conversions.ToString(dataWindows[10, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtHeight.Text = Conversions.ToString(dataWindows[11, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtArea.Text = Conversions.ToString(dataWindows[9, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtCount.Text = Conversions.ToString(dataWindows[12, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtOverWidth.Text = Conversions.ToString(dataWindows[13, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtOverDepth.Text = Conversions.ToString(dataWindows[14, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtCurtainType.Text = Conversions.ToString(dataWindows[15, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtFractionC.Text = Conversions.ToString(dataWindows[16, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtg.Text = Conversions.ToString(dataWindows[17, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtFF.Text = Conversions.ToString(dataWindows[18, this.DataWindows.CurrentRow.Index].Value);
          MyProject.Forms.Windows.txtU.Text = Conversions.ToString(dataWindows[19, this.DataWindows.CurrentRow.Index].Value);
          SAP_Module.EditRow = true;
          SAP_Module.RowEdit = this.DataWindows.CurrentRow.Index;
          if (SAP_Module.RowEdit == 0)
            MyProject.Forms.Windows.cmdPrevious.Enabled = false;
          if (SAP_Module.RowEdit == checked (this.DataWindows.RowCount - 1))
            MyProject.Forms.Windows.cmdNext.Enabled = false;
          int num = (int) MyProject.Forms.Windows.ShowDialog();
          MyProject.Forms.Windows.Close();
          this.AddCalcHandle();
        }
        else
        {
          int num1 = (int) Interaction.MsgBox((object) "Please select a Window to edit first!", MsgBoxStyle.Information, (object) "Edit Window");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please select a Window to edit first!", MsgBoxStyle.Information, (object) "Edit Window");
        ProjectData.ClearProjectError();
      }
    }

    private void DataWindows_DoubleClick(object sender, EventArgs e) => this.cmdEditWindow_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void cmdEditDoor_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataDoors.CurrentRow.Index > -1)
        {
          DataGridView dataDoors = this.DataDoors;
          MyProject.Forms.Doors.txtName.Text = Conversions.ToString(dataDoors[0, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtLocation.Text = Conversions.ToString(dataDoors[1, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtUSource.Text = Conversions.ToString(dataDoors[2, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtDoorType.Text = Conversions.ToString(dataDoors[3, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtOrientation.Text = Conversions.ToString(dataDoors[4, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtOvershading.Text = Conversions.ToString(dataDoors[5, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtGlazingType.Text = Conversions.ToString(dataDoors[6, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtAirGap.Text = Conversions.ToString(dataDoors[7, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtFrameType.Text = Conversions.ToString(dataDoors[8, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtThermalBreak.Text = Conversions.ToString(dataDoors[9, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtArea.Text = Conversions.ToString(dataDoors[10, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtWidth.Text = Conversions.ToString(dataDoors[11, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtHeight.Text = Conversions.ToString(dataDoors[12, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtCount.Text = Conversions.ToString(dataDoors[13, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtg.Text = Conversions.ToString(dataDoors[14, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtFF.Text = Conversions.ToString(dataDoors[15, this.DataDoors.CurrentRow.Index].Value);
          MyProject.Forms.Doors.txtU.Text = Conversions.ToString(dataDoors[16, this.DataDoors.CurrentRow.Index].Value);
          SAP_Module.EditRow = true;
          SAP_Module.RowEdit = this.DataDoors.CurrentRow.Index;
          if (SAP_Module.RowEdit == 0)
            MyProject.Forms.Doors.cmdPrevious.Enabled = false;
          if (SAP_Module.RowEdit == checked (this.DataDoors.RowCount - 1))
            MyProject.Forms.Doors.cmdNext.Enabled = false;
          int num = (int) MyProject.Forms.Doors.ShowDialog();
          MyProject.Forms.Doors.Close();
          this.AddCalcHandle();
        }
        else
        {
          int num1 = (int) Interaction.MsgBox((object) "Please select a Door to edit first!", MsgBoxStyle.Information, (object) "Edit Door");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please select a Door to edit first!", MsgBoxStyle.Information, (object) "Edit Door");
        ProjectData.ClearProjectError();
      }
    }

    private void DataDoors_DoubleClick(object sender, EventArgs e) => this.cmdEditDoor_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void cmdDeleteWindow_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataWindows.CurrentRow.Index <= -1 || Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete ", this.DataWindows[0, this.DataWindows.CurrentRow.Index].Value), (object) "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Window Delete") != MsgBoxResult.Yes)
          return;
        this.DataWindows.Rows.Remove(this.DataWindows.Rows[this.DataWindows.CurrentRow.Index]);
        SAP_Write.WriteWindows();
        this.AddCalcHandle();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please select a Window to delete first!", MsgBoxStyle.Information, (object) "Edit Roof Light");
        ProjectData.ClearProjectError();
      }
    }

    private void cmdDeleteDoor_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataDoors.CurrentRow.Index <= -1 || Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete ", this.DataDoors[0, this.DataDoors.CurrentRow.Index].Value), (object) "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Doors Delete") != MsgBoxResult.Yes)
          return;
        this.DataDoors.Rows.Remove(this.DataDoors.Rows[this.DataDoors.CurrentRow.Index]);
        SAP_Write.WriteDoors();
        this.AddCalcHandle();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please select a Door to delete first!", MsgBoxStyle.Information, (object) "Edit Roof Light");
        ProjectData.ClearProjectError();
      }
    }

    private void cmdDeleteRoofLight_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataRoofLights.CurrentRow.Index <= -1 || Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete ", this.DataRoofLights[0, this.DataRoofLights.CurrentRow.Index].Value), (object) "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Roof Lights Delete") != MsgBoxResult.Yes)
          return;
        this.DataRoofLights.Rows.Remove(this.DataRoofLights.Rows[this.DataRoofLights.CurrentRow.Index]);
        SAP_Write.WriteRoofLights();
        this.AddCalcHandle();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please select a Roof Light to delete first!", MsgBoxStyle.Information, (object) "Edit Roof Light");
        ProjectData.ClearProjectError();
      }
    }

    private void cmdEditRoofLight_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DataRoofLights.CurrentRow.Index > -1)
        {
          DataGridView dataRoofLights = this.DataRoofLights;
          MyProject.Forms.RoofWindows.txtName.Text = Conversions.ToString(dataRoofLights[0, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtLocation.Text = Conversions.ToString(dataRoofLights[1, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtUSource.Text = Conversions.ToString(dataRoofLights[2, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtPitch.Text = Conversions.ToString(dataRoofLights[3, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtOrientation.Text = Conversions.ToString(dataRoofLights[4, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtOvershading.Text = Conversions.ToString(dataRoofLights[5, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtGlazingType.Text = Conversions.ToString(dataRoofLights[6, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtAirGap.Text = Conversions.ToString(dataRoofLights[7, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtFrameType.Text = Conversions.ToString(dataRoofLights[8, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtThermalBreak.Text = Conversions.ToString(dataRoofLights[9, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtArea.Text = Conversions.ToString(dataRoofLights[10, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtWidth.Text = Conversions.ToString(dataRoofLights[11, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtHeight.Text = Conversions.ToString(dataRoofLights[12, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtCount.Text = Conversions.ToString(dataRoofLights[13, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtOverWidth.Text = Conversions.ToString(dataRoofLights[14, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtOverDepth.Text = Conversions.ToString(dataRoofLights[15, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtCurtainType.Text = Conversions.ToString(dataRoofLights[16, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtFractionC.Text = Conversions.ToString(dataRoofLights[17, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtg.Text = Conversions.ToString(dataRoofLights[18, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtFF.Text = Conversions.ToString(dataRoofLights[19, this.DataRoofLights.CurrentRow.Index].Value);
          MyProject.Forms.RoofWindows.txtU.Text = Conversions.ToString(dataRoofLights[20, this.DataRoofLights.CurrentRow.Index].Value);
          SAP_Module.EditRow = true;
          SAP_Module.RowEdit = this.DataRoofLights.CurrentRow.Index;
          if (SAP_Module.RowEdit == 0)
            MyProject.Forms.RoofWindows.cmdPrevious.Enabled = false;
          if (SAP_Module.RowEdit == checked (this.DataRoofLights.RowCount - 1))
            MyProject.Forms.RoofWindows.cmdNext.Enabled = false;
          int num = (int) MyProject.Forms.RoofWindows.ShowDialog();
          MyProject.Forms.RoofWindows.Close();
          this.AddCalcHandle();
        }
        else
        {
          int num1 = (int) Interaction.MsgBox((object) "Please select a Roof Light to edit first!", MsgBoxStyle.Information, (object) "Edit Roof Light");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Please select a Roof Light to edit first!", MsgBoxStyle.Information, (object) "Edit Roof Light");
        ProjectData.ClearProjectError();
      }
    }

    private void DataRoofLights_DoubleClick(object sender, EventArgs e) => this.cmdEditRoofLight_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void cmdProducts_Click(object sender, EventArgs e)
    {
      Products products = new Products();
      DataTable dataTable1 = new DataTable();
      dataTable1.TableName = "Products321";
      DataTable dataTable2 = new DataTable();
      dataTable1.Columns.Add("ID");
      dataTable1.Columns.Add("RefNo");
      dataTable1.Columns.Add("Date");
      dataTable1.Columns.Add("Manufacturer");
      dataTable1.Columns.Add("Brand");
      dataTable1.Columns.Add("Model");
      dataTable1.Columns.Add("ModelQualifier");
      dataTable1.Columns.Add("FirstManu");
      dataTable1.Columns.Add("FinManu");
      dataTable1.Columns.Add("MainType");
      dataTable1.Columns.Add("IntegralOnly");
      dataTable1.Columns.Add("DuctingType");
      dataTable1.Columns.Add("TestDuctSize");
      dataTable1.Columns.Add("SummerByPass");
      dataTable1.Columns.Add("NoofExhausts");
      dataTable2.Columns.Add("Ref");
      dataTable2.Columns.Add("AdditionalWetRoom");
      dataTable2.Columns.Add("TestFlowRate");
      dataTable2.Columns.Add("FanSpeed");
      dataTable2.Columns.Add("SFP");
      dataTable2.Columns.Add("HeatExchangerEfficiency");
      try
      {
        foreach (PCDF.Products321 products321 in SAP_Module.PCDFData.Products321s)
        {
          DataRow row = dataTable1.NewRow();
          DataRow dataRow = row;
          dataRow["ID"] = (object) products321.ID;
          dataRow["RefNo"] = (object) products321.RefNo;
          dataRow["Date"] = (object) products321.Date1;
          dataRow["Manufacturer"] = (object) products321.Manufacturer;
          dataRow["Brand"] = (object) products321.Brand;
          dataRow["Model"] = (object) products321.Model;
          dataRow["ModelQualifier"] = (object) products321.ModelQualifier;
          dataRow["FirstManu"] = (object) products321.FirstManu;
          dataRow["FinManu"] = (object) products321.FinManu;
          dataRow["MainType"] = (object) products321.MainType;
          dataRow["IntegralOnly"] = (object) products321.IntegralOnly;
          dataRow["DuctingType"] = (object) products321.DuctingType;
          dataRow["TestDuctSize"] = (object) products321.TestDuctSize;
          dataRow["SummerByPass"] = (object) products321.SummerByPass;
          dataRow["NoofExhausts"] = (object) products321.NoofExhausts;
          dataTable1.Rows.Add(row);
        }
      }
      finally
      {
        List<PCDF.Products321>.Enumerator enumerator;
        enumerator.Dispose();
      }
      try
      {
        foreach (PCDF.Products321_Sub products321Sub in SAP_Module.PCDFData.Products321s_Sub)
        {
          DataRow row = dataTable2.NewRow();
          DataRow dataRow = row;
          dataRow["Ref"] = (object) products321Sub.Ref;
          dataRow["AdditionalWetRoom"] = (object) products321Sub.AdditionalWetRoom;
          dataRow["TestFlowRate"] = (object) products321Sub.TestFlowRate;
          dataRow["FanSpeed"] = (object) products321Sub.FanSpeed;
          dataRow["SFP"] = (object) products321Sub.SFP;
          dataRow["HeatExchangerEfficiency"] = (object) products321Sub.HeatExchangerEfficiency;
          dataTable2.Rows.Add(row);
        }
      }
      finally
      {
        List<PCDF.Products321_Sub>.Enumerator enumerator;
        enumerator.Dispose();
      }
      DataTable dataTable3 = new DataTable();
      dataTable3.TableName = "Products322";
      DataTable dataTable4 = new DataTable();
      dataTable3.Columns.Add("ID");
      dataTable3.Columns.Add("RefNo");
      dataTable3.Columns.Add("Date");
      dataTable3.Columns.Add("Manufacturer");
      dataTable3.Columns.Add("Brand");
      dataTable3.Columns.Add("Model");
      dataTable3.Columns.Add("ModelQualifier");
      dataTable3.Columns.Add("FirstManu");
      dataTable3.Columns.Add("FinManu");
      dataTable3.Columns.Add("MainType");
      dataTable3.Columns.Add("DuctingType");
      dataTable3.Columns.Add("NumbConfigs");
      dataTable4.Columns.Add("Ref");
      dataTable4.Columns.Add("Configuration");
      dataTable4.Columns.Add("TestFlowRate");
      dataTable4.Columns.Add("FanSpeed");
      dataTable4.Columns.Add("SFP");
      try
      {
        foreach (PCDF.Products322 products322 in SAP_Module.PCDFData.Products322s)
        {
          DataRow row = dataTable3.NewRow();
          DataRow dataRow = row;
          dataRow["ID"] = (object) products322.ID;
          dataRow["RefNo"] = (object) products322.RefNo;
          dataRow["Date"] = (object) products322.Date1;
          dataRow["Manufacturer"] = (object) products322.Manufacturer;
          dataRow["Brand"] = (object) products322.Brand;
          dataRow["Model"] = (object) products322.Model;
          dataRow["ModelQualifier"] = (object) products322.ModelQualifier;
          dataRow["FirstManu"] = (object) products322.FirstManu;
          dataRow["FinManu"] = (object) products322.FinManu;
          dataRow["MainType"] = (object) products322.MainType;
          dataRow["DuctingType"] = (object) products322.DuctingType;
          dataRow["NumbConfigs"] = (object) products322.NumbConfigs;
          dataTable3.Rows.Add(row);
        }
      }
      finally
      {
        List<PCDF.Products322>.Enumerator enumerator;
        enumerator.Dispose();
      }
      try
      {
        foreach (PCDF.Products322_Sub products322Sub in SAP_Module.PCDFData.Products322s_Sub)
        {
          DataRow row = dataTable4.NewRow();
          DataRow dataRow = row;
          dataRow["Ref"] = (object) products322Sub.Ref;
          dataRow["Configuration"] = (object) products322Sub.Configuration;
          dataRow["TestFlowRate"] = (object) products322Sub.TestFlowRate;
          dataRow["FanSpeed"] = (object) products322Sub.FanSpeed;
          dataRow["SFP"] = (object) products322Sub.SFP;
          dataTable4.Rows.Add(row);
        }
      }
      finally
      {
        List<PCDF.Products322_Sub>.Enumerator enumerator;
        enumerator.Dispose();
      }
      products.Products321Sub = dataTable2;
      products.Products322Sub = dataTable4;
      string text = this.txtMechVentilation.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Balanced with heat recovery", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Centralised whole house extract", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Decentralised whole house extract", false) == 0)
          {
            products.dgvProducts.Table = dataTable3;
            products.SearchResults.DataSource = (object) products.dgvProducts;
            products.Rows = products.SearchResults.Rows.Count;
            products.Type = 2;
          }
        }
        else
        {
          products.dgvProducts.Table = dataTable1;
          products.dgvProducts.RowFilter = "MainType='1'";
          products.SearchResults.DataSource = (object) products.dgvProducts;
          products.Rows = products.SearchResults.Rows.Count;
          products.Type = 1;
        }
      }
      else
      {
        products.dgvProducts.Table = dataTable1;
        products.dgvProducts.RowFilter = "MainType='3'";
        products.SearchResults.DataSource = (object) products.dgvProducts;
        products.Rows = products.SearchResults.Rows.Count;
        products.Type = 1;
      }
      int num = (int) products.ShowDialog();
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling == -1)
        return;
      Functions.CalculateNow();
    }

    private void txtMechVentilation_LostFocus(object sender, EventArgs e) => SAP_Write.WriteVentilation();

    private void txtMechVentilation_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.grpVentData.Visible = false;
      this.lblFanPower.Visible = false;
      this.txtParamters.Items.Clear();
      this.txtParamters.Enabled = false;
      this.txtParamters.Text = "";
      this.txtWetRooms.Enabled = false;
      this.txtWetRooms.Value = 0M;
      this.txtDuctInsulation.Enabled = false;
      this.txtDuctInsulation.Text = "";
      this.cmdProducts.Enabled = false;
      this.lblDataProduct.Text = "";
      this.lblDataProduct.Visible = false;
      this.grpMechDetails.Visible = false;
      this.grpDecentralised.Visible = false;
      this.txtNoofFans.Enabled = true;
      string text = this.txtMechVentilation.Text;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(text))
      {
        case 625191264:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Balanced without heat recovery", false) != 0)
            break;
          this.txtParamters.Enabled = true;
          this.txtParamters.Items.Add((object) "SAP 2012");
          this.txtParamters.Items.Add((object) "User defined");
          this.chkApprovedScheme.Enabled = true;
          break;
        case 918396964:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Decentralised whole house extract", false) != 0)
            break;
          this.txtParamters.Enabled = true;
          this.txtParamters.Items.Add((object) "SAP 2012");
          this.txtParamters.Items.Add((object) "User defined");
          this.txtParamters.Items.Add((object) "Database");
          this.txtNoofFans.Enabled = false;
          this.txtNoofFans.Value = 0M;
          this.chkApprovedScheme.Enabled = true;
          break;
        case 1101494137:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Centralised whole house extract", false) != 0)
            break;
          this.txtParamters.Enabled = true;
          this.txtParamters.Items.Add((object) "SAP 2012");
          this.txtParamters.Items.Add((object) "User defined");
          this.txtParamters.Items.Add((object) "Database");
          this.txtNoofFans.Enabled = false;
          this.txtNoofFans.Value = 0M;
          this.chkApprovedScheme.Enabled = true;
          break;
        case 2533751361:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Positive input from loft", false) != 0)
            break;
          this.txtParamters.Text = "SAP 2012";
          this.chkApprovedScheme.Enabled = false;
          this.chkApprovedScheme.Checked = false;
          break;
        case 3225008057:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Positive input from outside", false) != 0)
            break;
          this.txtParamters.Enabled = true;
          this.txtParamters.Items.Add((object) "SAP 2012");
          this.txtParamters.Items.Add((object) "User defined");
          this.chkApprovedScheme.Enabled = true;
          break;
        case 3236691049:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Natural ventilation", false) != 0)
            break;
          this.chkApprovedScheme.Enabled = false;
          this.chkApprovedScheme.Checked = false;
          break;
        case 3255421954:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Balanced with heat recovery", false) != 0)
            break;
          this.txtParamters.Enabled = true;
          this.txtParamters.Items.Add((object) "SAP 2012");
          this.txtParamters.Items.Add((object) "User defined");
          this.txtParamters.Items.Add((object) "Database");
          this.txtNoofFans.Enabled = false;
          this.txtNoofFans.Value = 0M;
          this.chkApprovedScheme.Enabled = true;
          break;
      }
    }

    private void txtParamters_LostFocus(object sender, EventArgs e) => SAP_Write.WriteVentilation();

    private void txtParamters_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.grpVentData.Visible = false;
      this.lblFanPower.Visible = false;
      this.txtWetRooms.Enabled = false;
      this.txtWetRooms.Value = 0M;
      this.txtDuctInsulation.Enabled = false;
      this.txtDuctInsulation.Text = "";
      this.cmdProducts.Enabled = false;
      this.grpMechDetails.Visible = false;
      this.grpDecentralised.Visible = false;
      this.ChkMulSystem.Enabled = false;
      this.lblUserDefined.Visible = false;
      string text1 = this.txtParamters.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "SAP 2012", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "Database", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "User defined", false) != 0)
            return;
          this.ChkMulSystem.Enabled = true;
          this.lblUserDefined.Visible = true;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID = 0;
          this.txtMechDucting.Enabled = false;
          this.txtMechFan.Enabled = false;
          this.txtMechHeat.Enabled = false;
          string text2 = this.txtMechVentilation.Text;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Balanced without heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Centralised whole house extract", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Balanced with heat recovery", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Positive input from outside", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text2, "Decentralised whole house extract", false) != 0)
                  return;
                this.grpMechDetails.Visible = true;
                this.txtMechDucting.Enabled = true;
                this.grpDecentralised.Visible = true;
                this.txtMechDecKSPF1.Enabled = true;
                this.txtMechDecKSPF2.Enabled = true;
                this.txtMechDecKSPF3.Enabled = true;
                this.txtMechDecOSPF1.Enabled = true;
                this.txtMechDecOSPF2.Enabled = true;
                this.txtMechDecOSPF3.Enabled = true;
              }
              else
              {
                this.grpMechDetails.Visible = true;
                this.txtWetRooms.Enabled = true;
                this.txtMechDucting.Enabled = true;
                this.txtMechFan.Enabled = true;
              }
            }
            else
            {
              this.grpMechDetails.Visible = true;
              this.txtWetRooms.Enabled = true;
              this.txtDuctInsulation.Enabled = true;
              this.txtMechDucting.Enabled = true;
              this.txtMechFan.Enabled = true;
              this.txtMechHeat.Enabled = true;
            }
          }
          else
          {
            this.grpMechDetails.Visible = true;
            this.txtWetRooms.Enabled = true;
            this.txtMechDucting.Enabled = true;
            this.txtMechFan.Enabled = true;
          }
        }
        else
        {
          this.cmdProducts.Enabled = true;
          string text3 = this.txtMechVentilation.Text;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text3, "Balanced without heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text3, "Centralised whole house extract", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text3, "Balanced with heat recovery", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text3, "Decentralised whole house extract", false) != 0)
                return;
              this.grpDecentralised.Visible = true;
              this.txtMechDecKSPF1.Enabled = false;
              this.txtMechDecKSPF2.Enabled = false;
              this.txtMechDecKSPF3.Enabled = false;
              this.txtMechDecOSPF1.Enabled = false;
              this.txtMechDecOSPF2.Enabled = false;
              this.txtMechDecOSPF3.Enabled = false;
            }
            else
            {
              this.txtWetRooms.Enabled = true;
              this.txtDuctInsulation.Enabled = true;
            }
          }
          else
            this.txtWetRooms.Enabled = true;
        }
      }
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID = 0;
    }

    private void txtSAPOnly_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtOverHeat_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtPropertyType_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtBuiltForm_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtFlatType_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtYearBuilt_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtLocation_LostFocus(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtShelteredSides_LostFocus(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteDwellingDetails(false);
    }

    private void txtTerrain_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteDwellingDetails(false);
    }

    private void txtYearBuilt_LostFocus1(object sender, EventArgs e) => SAP_Write.WriteDwellingDetails(false);

    private void txtProjName_LostFocus1(object sender, EventArgs e) => SAP_Write.WriteProjectDetails(true);

    private void txtNoofChmneys_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteVentilation();
    }

    private void txtNoofOpenFlues_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteVentilation();
    }

    private void txtNoofFans_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteVentilation();
    }

    private void txtNoofPassiveVents_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteVentilation();
    }

    private void txtNoofFlueGasFires_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteVentilation();
    }

    private void txtNoofShelteredSides_LostFocus(object sender, EventArgs e) => SAP_Write.WriteVentilation();

    private void txtWetRooms_ValueChanged(object sender, EventArgs e) => SAP_Write.WriteVentilation();

    private void txtDuctInsulation_LostFocus(object sender, EventArgs e) => SAP_Write.WriteVentilation();

    private void txtBoilerSub_Click(object sender, EventArgs e)
    {
    }

    private void txtBoilerSub_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating.CheckBoilerSub();
    }

    private void txtMainHeatingType_LostFocus(object sender, EventArgs e)
    {
      SAP_Write.WriteMainHeating();
      this.DoCheckFuel = false;
    }

    private void txtMainHeatingType_MarginChanged(object sender, EventArgs e) => this.DoCheckFuel = true;

    private void txtMainHeatingType_MouseUp(object sender, MouseEventArgs e)
    {
    }

    private void txtMainHeatingType_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.txtHeatingEmitter.Enabled = true;
      if (!SAP_Module.ChangeNow && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainHeatingType.Text, "", false) > 0U)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK = (string) null;
        Heating.CheckFuelTypeForSAPTable(this.txtMainHeatingType.Text, this.txtSubGroup.Text, this.txtBoilerSub.Text);
        Heating.GetMainEfficiency(this.txtPrimary.Text, this.txtSubGroup.Text, this.txtBoilerSub.Text, this.txtMainHeatingType.Text);
        this.CheckElectCPSU();
        WaterHeating.CheckCylinder();
        this.grpStorage.Visible = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode == 409;
      }
      if (this.DoCheckFuel)
      {
        try
        {
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "", false) > 0U)
            WaterHeating.PaniCheck(1, this.txtMainFuel.Text, SAP_Module.CurrDwelling);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      string text = this.txtMainHeatingType.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Community boilers", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Community waste heat from power station", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Community heat pump", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Community geothermal heat source", false) == 0)
        this.txtCommHB1HeatToPower.Text = "";
      this.txtHeatingEmitter.Enabled = true;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode == 701)
      {
        this.txtHeatingEmitter.Text = "";
        this.txtHeatingEmitter.Enabled = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubGroup.Text, "Electric (direct acting) room heaters", false) == 0)
        this.txtHeatingEmitter.Enabled = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrimary.Text, "Room heaters", false) != 0)
        return;
      this.txtHeatingEmitter.Enabled = false;
      this.txtHeatingEmitter.Text = "";
    }

    private void txtHeatingEmitter_LostFocus(object sender, EventArgs e) => SAP_Write.WriteMainHeating();

    private void txtHeatingControls_LostFocus(object sender, EventArgs e) => SAP_Write.WriteMainHeating();

    private void txtMainFuel_LostFocus(object sender, EventArgs e)
    {
      SAP_Write.WriteMainHeating();
      this.DoCheckFuel = false;
    }

    private void txtSecMainFuel_LostFocus(object sender, EventArgs e)
    {
      SAP_Write.WriteMainHeating();
      this.DoCheckFuel = false;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
    }

    public string MD5_Hash(string SourceText)
    {
      string str;
      try
      {
        byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(SourceText));
        StringBuilder stringBuilder = new StringBuilder(checked ((int) Math.Round(unchecked ((double) checked (hash.Length * 2) + (double) hash.Length / 8.0))));
        int num = checked (hash.Length - 1);
        int startIndex = 0;
        while (startIndex <= num)
        {
          stringBuilder.Append(BitConverter.ToString(hash, startIndex, 1));
          checked { ++startIndex; }
        }
        str = stringBuilder.ToString().TrimEnd(' ').ToLower();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "0";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private void ToolStripButton4_Click(object sender, EventArgs e) => this.OpenProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void ToolStripButton3_Click(object sender, EventArgs e) => this.SaveProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void ToolStripButton5_Click(object sender, EventArgs e) => this.SaveAsToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void txtLivingArea_KeyDown(object sender, KeyEventArgs e)
    {
      if (!Versioned.IsNumeric((object) this.txtLivingArea.Text))
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified = false;
    }

    private void txtLivingFraction_KeyDown(object sender, KeyEventArgs e)
    {
      if (!Versioned.IsNumeric((object) this.txtLivingFraction.Text))
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified = true;
    }

    private void txtLivingArea_TextChanged(object sender, EventArgs e)
    {
      if (!Versioned.IsNumeric((object) this.txtLivingArea.Text) || SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified)
        return;
      this.txtLivingFraction.Text = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) (Conversions.ToDouble(this.txtLivingArea.Text) / Conversions.ToDouble(this.txtDimsArea.Text))), "#0.000");
    }

    private void txtLivingFraction_TextChanged(object sender, EventArgs e)
    {
      if (!Versioned.IsNumeric((object) this.txtLivingFraction.Text) || !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified)
        return;
      this.txtLivingArea.Text = Microsoft.VisualBasic.Strings.Format((object) Conversion.Val((object) (Conversions.ToDouble(this.txtLivingFraction.Text) * Conversions.ToDouble(this.txtDimsArea.Text))), "#0.00");
    }

    private void txtProjName_TextChanged(object sender, EventArgs e)
    {
      SAP_Module.Proj.Name = this.txtProjName.Text;
      if (this.TreeSAP.Nodes.Count <= 0)
        return;
      this.TreeSAP.Nodes[0].Text = SAP_Module.Proj.Name;
    }

    private void chkGross_CheckedChanged(object sender, EventArgs e) => SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas = this.chkGross.Checked;

    private void cmdNewDoor_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

    private void cmdNewDoor_MouseLeave(object sender, EventArgs e) => this.Cursor = Cursors.Default;

    private void chkHtb_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkHtb.Checked)
      {
        this.txtHtb.ReadOnly = false;
        this.cmdHtb.Enabled = true;
        this.txtConstDetails.Text = "";
        this.txtConstDetails.Enabled = false;
        this.chky.Enabled = false;
        this.chky.Checked = false;
        this.txty.Text = "";
        this.txty.ReadOnly = true;
      }
      else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) > 0U)
      {
        this.txty.Text = Conversions.ToString(0.15);
        this.txtConstDetails.Text = "No information on thermal bridging (y=0.15)";
        this.txtHtb.ReadOnly = true;
        this.cmdHtb.Text = "";
        this.cmdHtb.Enabled = false;
        this.chky.Enabled = true;
      }
    }

    private void chky_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chky.Checked)
      {
        this.txtConstDetails.Text = "";
        this.txtConstDetails.Enabled = false;
        this.txty.ReadOnly = true;
        this.txtThermalReference.Enabled = true;
        this.chkHtb.Checked = false;
      }
      else
      {
        this.txtConstDetails.Enabled = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        {
          this.txtConstDetails.Items.Clear();
          this.txtConstDetails.Items.Add((object) "Scotland simplified approach (y = 0.08)");
          this.txtConstDetails.Items.Add((object) "No information on thermal bridging (y=0.15)");
          this.txtConstDetails.Enabled = true;
        }
        else
        {
          this.txtConstDetails.Text = "No information on thermal bridging (y=0.15)";
          this.txtConstDetails.Enabled = false;
        }
        this.txty.ReadOnly = true;
        this.txtThermalReference.Enabled = false;
        this.txtThermalReference.Text = "";
      }
    }

    private void txtConstDetails_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtConstDetails.Text, "Scotland simplified approach (y = 0.08)", false) == 0)
        this.txty.Text = Conversions.ToString(0.08);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtConstDetails.Text, "No information on thermal bridging (y=0.15)", false) != 0)
        return;
      this.txty.Text = Conversions.ToString(0.15);
    }

    private void cmdHtb_Click(object sender, EventArgs e)
    {
      int num = (int) new Htb_Calculator2012().ShowDialog();
      Validation.CheckErrors_Opaque(SAP_Module.CurrDwelling);
      Functions.CalculateNow();
      this.txtHtb.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue);
    }

    private void cmdClearSecondary_Click(object sender, EventArgs e)
    {
      this.txtSPrimary.Text = "";
      this.txtSSubGroup.Text = "";
      this.txtSSubGroup.Items.Clear();
      this.txtSSubGroup.Enabled = false;
      this.txtSHeatingSource.Text = "";
      this.txtSHeatingSource.Items.Clear();
      this.txtSHeatingSource.Enabled = false;
      this.txtSMainHeatingType.Text = "";
      this.txtSMainHeatingType.Items.Clear();
      this.txtSMainHeatingType.Enabled = false;
      this.txtSMainFuel.Text = "";
      this.txtSMainFuel.Items.Clear();
      this.txtSMainFuel.Enabled = false;
      this.txtSEfficiency.Text = "";
      this.txtSEfficiency.Enabled = false;
      this.txtSDescription.Text = "";
      this.grpManuDescription.Enabled = false;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SAPTableCode = 0;
      SAP_Module.ChangeNow = false;
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling == -1)
        return;
      Functions.CalculateNow();
    }

    private void txtSPrimary_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SecHeating.SPrimaryHeatingGroupCheck();
    }

    private void txtSSubGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SecHeating.SPrimaryHeatingSubGroupCheck();
    }

    private void txtSHeatingSource_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
        SecHeating.SCheckSource();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSHeatingSource.Text, "SAP Tables", false) == 0)
      {
        this.grpManuDescription.Enabled = false;
        this.txtSFlueType.Enabled = false;
        this.txtSFlueType.Text = "";
      }
      else
      {
        this.grpManuDescription.Enabled = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSSubGroup.Text, "Gas (including LPG) room heaters", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSSubGroup.Text, "Oil room heaters", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSSubGroup.Text, "Solid fuel room heaters", false) == 0)
        {
          this.txtSFlueType.Enabled = true;
        }
        else
        {
          this.txtSFlueType.Enabled = false;
          this.txtSFlueType.Text = "";
        }
      }
    }

    private void txtSMainHeatingType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SecHeating.SCheckFuelTypeForSAPTable(this.txtSMainHeatingType.Text);
    }

    private void txtMainFuel_MouseDown(object sender, MouseEventArgs e) => this.DoCheckFuel = true;

    private void txtMainFuel_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
      {
        Heating.GetMainEfficiency(this.txtPrimary.Text, this.txtSubGroup.Text, this.txtBoilerSub.Text, this.txtMainHeatingType.Text);
        if (this.DoCheckFuel)
        {
          try
          {
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "", false) > 0U)
              WaterHeating.PaniCheck(1, this.txtMainFuel.Text, SAP_Module.CurrDwelling);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "heating oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "biodiesel from any biomass source", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "biodiesel from used cooking oil only", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "rapeseed oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "appliances able to use mineral oil or liquid biofuel", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "B30K", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "bioethanol from any biomass source", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrimary.Text, "Boiler systems with radiators or underfloor heating", false) == 0)
        {
          this.chkOilPump.Visible = true;
          this.chkOilPump.Enabled = true;
        }
        else
        {
          this.chkOilPump.Checked = false;
          this.chkOilPump.Visible = false;
        }
      }
      else
      {
        this.chkOilPump.Checked = false;
        this.chkOilPump.Visible = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "mains gas", false) == 0 | this.txtMainFuel.Text.Contains("LPG"))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtHeatingSource.Text, "Manufacturer Declaration", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
        {
          this.txtBFuelBurningType.Enabled = true;
        }
        else
        {
          this.txtBFuelBurningType.Enabled = false;
          this.txtBFuelBurningType.Text = "";
        }
      }
      else
      {
        this.txtBFuelBurningType.Enabled = false;
        this.txtBFuelBurningType.Text = "";
      }
    }

    private void txtHETAS_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SecHeating.GetSecEfficiency(this.txtSPrimary.Text, this.txtSSubGroup.Text, this.txtSMainHeatingType.Text);
    }

    private void txtSMainFuel_LostFocus(object sender, EventArgs e) => this.DoCheckFuel = false;

    private void txtSMainFuel_MouseDown(object sender, MouseEventArgs e) => this.DoCheckFuel = true;

    private void txtSMainFuel_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
        SecHeating.GetSecEfficiency(this.txtSPrimary.Text, this.txtSSubGroup.Text, this.txtSMainHeatingType.Text);
      if (!this.DoCheckFuel)
        return;
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSMainFuel.Text, "", false) > 0U)
          WaterHeating.PaniCheck(3, this.txtSMainFuel.Text, SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void chkSolar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSolar.Checked)
      {
        this.txtSolarType.Enabled = true;
        this.chkSolarOveride.Enabled = true;
        this.txtSolarArea.Enabled = true;
        this.chkSolarGross.Enabled = true;
        this.txtSolarTilt.Enabled = true;
        this.txtSolarOrientation.Enabled = true;
        this.txtSolarOvershading.Enabled = true;
        this.txtSolarVolume.Enabled = true;
        this.chkSolarSeperate.Enabled = true;
        this.chkSolarPump.Enabled = true;
        this.cboSolarShower.Enabled = true;
      }
      else
      {
        this.txtSolarType.Enabled = false;
        this.chkSolarOveride.Enabled = false;
        this.txtSolarZero.Enabled = false;
        this.txtSolarHLoss.Enabled = false;
        this.txtSolarHLoss2.Enabled = false;
        this.txtSolarArea.Enabled = false;
        this.chkSolarGross.Enabled = false;
        this.txtSolarTilt.Enabled = false;
        this.txtSolarOrientation.Enabled = false;
        this.txtSolarOvershading.Enabled = false;
        this.txtSolarVolume.Enabled = false;
        this.chkSolarSeperate.Enabled = false;
        this.chkSolarPump.Enabled = false;
        this.cboSolarShower.Enabled = false;
        this.cboSolarShower.Text = "";
        this.txtSolarType.Text = "";
        this.chkSolarOveride.Checked = false;
        this.txtSolarZero.Text = Conversions.ToString(0);
        this.txtSolarHLoss.Text = Conversions.ToString(0);
        this.txtSolarHLoss2.Text = Conversions.ToString(0);
        this.txtSolarArea.Text = Conversions.ToString(0);
        this.chkSolarGross.Checked = false;
        this.txtSolarTilt.Text = "";
        this.txtSolarOrientation.Text = "";
        this.txtSolarOvershading.Text = "";
        this.txtSolarVolume.Text = Conversions.ToString(0);
        this.chkSolarSeperate.Checked = false;
        this.chkSolarPump.Checked = false;
      }
    }

    private void chkSolarOveride_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSolarOveride.Checked)
      {
        this.txtSolarZero.Enabled = true;
        this.txtSolarHLoss.Enabled = true;
        this.txtSolarHLoss2.Enabled = true;
      }
      else
      {
        this.txtSolarZero.Enabled = false;
        this.txtSolarHLoss.Enabled = false;
        this.txtSolarHLoss2.Enabled = false;
      }
    }

    private void txtSolarType_SelectedIndexChanged(object sender, EventArgs e)
    {
      string text = this.txtSolarType.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Evacuated tube", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Flat plate, glazed", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Unglazed", false) != 0)
            return;
          this.txtSolarZero.Text = Conversions.ToString(0.9);
          this.txtSolarHLoss.Text = Conversions.ToString(20);
        }
        else
        {
          this.txtSolarZero.Text = Conversions.ToString(0.75);
          this.txtSolarHLoss.Text = Conversions.ToString(6);
        }
      }
      else
      {
        this.txtSolarZero.Text = Conversions.ToString(0.6);
        this.txtSolarHLoss.Text = Conversions.ToString(3);
      }
    }

    private void Button2_Click(object sender, EventArgs e) => this.SplitContainer2.Panel2Collapsed = false;

    private void Button3_Click(object sender, EventArgs e)
    {
      this.SplitContainer2.Panel2Collapsed = !this.SplitContainer2.Panel2Collapsed;
      if (this.SplitContainer2.Panel2Collapsed)
        this.Button3.Text = "<";
      else
        this.Button3.Text = ">";
    }

    private void txtWater_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
        WaterHeating.CheckWaterType_AndFuel(this.txtWater.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtWater.Text, "", false) != 0)
        return;
      this.txtWaterFuel.Enabled = false;
    }

    private void chkPInclude_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkPInclude.Checked)
      {
        this.CurrPhotoV = -1;
        this.txtPPower.Enabled = true;
        this.txtPTilt.Enabled = true;
        this.txtPCOrientation.Enabled = true;
        this.txtPOvershading.Enabled = true;
        this.pnlPhotoVoltaics.Visible = true;
        this.cmdPhotoDelete.Enabled = true;
        this.cmdPhotoNew.Enabled = true;
        this.cmdPhotoOK.Enabled = true;
      }
      else
      {
        this.txtPPower.Enabled = false;
        this.txtPTilt.Enabled = false;
        this.txtPCOrientation.Enabled = false;
        this.txtPOvershading.Enabled = false;
        this.txtPPower.Text = "";
        this.txtPTilt.Text = "";
        this.txtPCOrientation.Text = "";
        this.txtPOvershading.Text = "";
        this.pnlPhotoVoltaics.Visible = false;
        this.cmdPhotoDelete.Enabled = false;
        this.cmdPhotoNew.Enabled = false;
        this.cmdPhotoOK.Enabled = false;
      }
    }

    private void chkWInclude_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkWInclude.Checked)
      {
        this.txtWNumber.Enabled = true;
        this.txtWRDiameter.Enabled = true;
        this.txtWHeight.Enabled = true;
      }
      else
      {
        this.txtWNumber.Enabled = false;
        this.txtWRDiameter.Enabled = false;
        this.txtWHeight.Enabled = false;
        this.txtWNumber.Value = 0M;
        this.txtWRDiameter.Text = "";
        this.txtWHeight.Text = "";
      }
    }

    private void chkSpecial_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSpecial.Checked)
      {
        this.txtSpDescription.Enabled = true;
        this.txtSpESaved.Enabled = true;
        this.txtSpFSaved.Enabled = true;
        this.txtSpEUsed.Enabled = true;
        this.txtSpFUsed.Enabled = true;
        this.BtnSp_Feature_OK.Enabled = true;
        this.Btn_SPFeature_Del.Enabled = true;
        this.BtnSp_Feature_add.Enabled = true;
        this.ChkMonInc.Enabled = true;
      }
      else
      {
        this.txtSpDescription.Enabled = false;
        this.txtSpESaved.Enabled = false;
        this.txtSpFSaved.Enabled = false;
        this.txtSpEUsed.Enabled = false;
        this.txtSpFUsed.Enabled = false;
        this.ChkMonInc.Enabled = false;
        this.ChkMonInc.Checked = false;
        this.txtSpDescription.Text = "";
        this.txtSpESaved.Text = "";
        this.txtSpFSaved.Text = "";
        this.txtSpEUsed.Text = "";
        this.txtSpFUsed.Text = "";
        this.Btn_SPFeature_Del.Enabled = false;
        this.BtnSp_Feature_OK.Enabled = false;
        this.BtnSp_Feature_add.Enabled = false;
      }
    }

    private void chkHydroInclude_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkHydroInclude.Checked)
      {
        this.txtHydroArea.Enabled = true;
        this.txtHydroGenerated.Enabled = true;
      }
      else
      {
        this.txtHydroArea.Enabled = false;
        this.txtHydroGenerated.Enabled = false;
        this.txtHydroArea.Text = "";
        this.txtHydroGenerated.Text = "";
      }
    }

    private void chkAAEGInclude_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkAAEGInclude.Checked)
      {
        this.txtAAEGArea.Enabled = true;
        this.txtAAEGGenerated.Enabled = true;
      }
      else
      {
        this.txtAAEGArea.Enabled = false;
        this.txtAAEGGenerated.Enabled = false;
        this.txtAAEGArea.Text = "";
        this.txtAAEGGenerated.Text = "";
      }
    }

    private void chkOverOveride_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkOverOveride.Checked)
      {
        this.txtOverAirach.Enabled = true;
        this.CheckAir();
      }
      else
      {
        this.txtOverAirach.Enabled = false;
        this.txtOverAirach.Text = Conversions.ToString(0);
        this.CheckAir();
      }
    }

    private void chkOverThermalOveride_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkOverThermalOveride.Checked)
      {
        this.txtOverThermalTMP.Enabled = true;
      }
      else
      {
        this.txtOverThermalTMP.Enabled = false;
        this.txtOverThermalTMP.Text = Conversions.ToString(0);
      }
    }

    private void txtOverAirType_SelectedIndexChanged(object sender, EventArgs e) => this.CheckAir();

    private void txtOverAirWindow_SelectedIndexChanged(object sender, EventArgs e) => this.CheckAir();

    private void CheckAir()
    {
      try
      {
        PCDF.Table_P1 tableP1 = SAP_Module.PCDFData.Table_P1s.Where<PCDF.Table_P1>((Func<PCDF.Table_P1, bool>) (b => b.Build.Equals(this.txtOverAirType.Text) & b.Window.Equals(this.txtOverAirWindow.Text))).SingleOrDefault<PCDF.Table_P1>();
        if (tableP1 == null)
          return;
        this.txtOverAirach.Text = tableP1.ach;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void dataGridConstruction_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      SAPForm sapForm = this;
      DataGridViewCellEventArgs viewCellEventArgs = e;
      try
      {
        PCDF.Table_P7 tableP7 = SAP_Module.PCDFData.Table_P7s.Where<PCDF.Table_P7>((Func<PCDF.Table_P7, bool>) (b => b.Description.Equals(RuntimeHelpers.GetObjectValue(sapForm.dataGridConstruction[viewCellEventArgs.ColumnIndex, viewCellEventArgs.RowIndex].Value)))).SingleOrDefault<PCDF.Table_P7>();
        if (tableP7 == null)
          return;
        this.txtOverThermalTMP.Text = tableP7.TMP;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMIllustrative = Conversions.ToInteger(tableP7.ID);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CheckTransactionTypes()
    {
      this.txtTransaction.Items.Clear();
      this.txtTransaction.Items.Add((object) "Marketed sale");
      this.txtTransaction.Items.Add((object) "Non marketed sale");
      this.txtTransaction.Items.Add((object) "New dwelling");
      this.txtTransaction.Items.Add((object) "Rental");
      this.txtTransaction.Items.Add((object) "Assessment for Green Deal");
      this.txtTransaction.Items.Add((object) "Following Green Deal");
      this.txtTransaction.Items.Add((object) "FiT application");
      this.txtTransaction.Items.Add((object) "None of the above");
    }

    private void txtDCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.txtEPCLanguage.Items.Clear();
      this.txtLocation.Items.Clear();
      this.ScotGraphs.Visible = false;
      this.Button12.Enabled = true;
      this.cmdAddAddress.Enabled = true;
      this.chkMax125Litre.Enabled = true;
      this.chkAverageValue.Enabled = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDCountry.Text, "Scotland", false) == 0)
      {
        this.txtLocation.Items.Add((object) "East Scotland");
        this.txtLocation.Items.Add((object) "West Scotland");
        this.txtLocation.Items.Add((object) "North East Scotland");
        this.txtLocation.Items.Add((object) "South West Scotland");
        this.txtLocation.Items.Add((object) "Highland");
        this.txtLocation.Items.Add((object) "Western Isles");
        this.txtLocation.Items.Add((object) "Orkney");
        this.txtLocation.Items.Add((object) "Shetland");
        this.txtLocation.Items.Add((object) "Borders");
        this.cmdAddAddress.Enabled = false;
        this.Button12.Enabled = false;
        this.chkMax125Litre.Enabled = false;
        this.chkMax125Litre.Checked = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualY = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue = 0.0f;
        this.txtConstDetails.Text = "";
        this.txtConstDetails.Enabled = false;
        this.txty.Text = "";
        this.chky.Checked = false;
        this.chky.Enabled = false;
        this.txtThermalReference.Text = "";
        this.chkAverageValue.Enabled = false;
        this.chkAverageValue.Checked = false;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDCountry.Text, "Wales", false) == 0)
      {
        this.txtLocation.Items.Add((object) "Wales");
        this.txtLocation.Items.Add((object) "West Pennines");
        this.txtLocation.Items.Add((object) "Severn valley");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDCountry.Text, "Northern Ireland", false) == 0)
      {
        this.txtLocation.Items.Add((object) "Northern Ireland");
      }
      else
      {
        this.txtLocation.Items.Add((object) "Thames valley");
        this.txtLocation.Items.Add((object) "Severn valley");
        this.txtLocation.Items.Add((object) "South England");
        this.txtLocation.Items.Add((object) "South East England");
        this.txtLocation.Items.Add((object) "South West England");
        this.txtLocation.Items.Add((object) "Midlands");
        this.txtLocation.Items.Add((object) "East Anglia");
        this.txtLocation.Items.Add((object) "East Pennines");
        this.txtLocation.Items.Add((object) "West Pennines");
        this.txtLocation.Items.Add((object) "North West England");
        this.txtLocation.Items.Add((object) "North East England");
        this.txtLocation.Items.Add((object) "Borders");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDCountry.Text, "Wales", false) == 0)
      {
        this.txtEPCLanguage.Text = "";
        this.txtEPCLanguage.Items.Add((object) "English");
        this.txtEPCLanguage.Items.Add((object) "Welsh");
      }
      else
      {
        this.txtEPCLanguage.Text = "English";
        this.txtEPCLanguage.Items.Add((object) "English");
      }
      this.CheckTransactionTypes();
      this.Check_Tenure();
    }

    private void txtAirTest_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.grpDetails.Visible = false;
      this.chkAverageValue.Enabled = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAirTest.Text, "As designed", false) == 0)
      {
        this.txtDesignAir.Enabled = true;
        this.txtMeasuredAir.Enabled = false;
        this.txtPressureDate.Enabled = false;
        this.txtMeasuredAir.Text = "";
        this.txtAssumedAir.Text = "";
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAirTest.Text, "As built", false) == 0)
      {
        this.txtDesignAir.Enabled = false;
        this.txtMeasuredAir.Enabled = true;
        this.txtPressureDate.Enabled = true;
        this.txtAssumedAir.Text = "";
        this.txtDesignAir.Text = "";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDCountry.Text, "Scotland", false) == 0)
        {
          this.chkAverageValue.Enabled = false;
          this.chkAverageValue.Checked = false;
        }
        else
          this.chkAverageValue.Enabled = true;
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAirTest.Text, "Assumed", false) == 0)
      {
        this.txtMeasuredAir.Enabled = false;
        this.txtPressureDate.Enabled = false;
        this.txtDesignAir.Enabled = false;
        this.txtAssumedAir.Text = "15";
        this.txtMeasuredAir.Text = "";
        this.txtDesignAir.Text = "";
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAirTest.Text, "Calculated", false) != 0)
          return;
        this.grpDetails.Visible = true;
        this.txtMeasuredAir.Enabled = false;
        this.txtPressureDate.Enabled = false;
        this.txtDesignAir.Enabled = false;
        this.txtMeasuredAir.Text = "";
        this.txtDesignAir.Text = "";
        this.txtAssumedAir.Text = "";
      }
    }

    private void Check_Tenure()
    {
      try
      {
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtHeatingControls_MouseDown(object sender, MouseEventArgs e) => this.DoCheckFuel = true;

    private void txtHeatingControls_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtHeatingControls.Text, "", false) > 0U)
      {
        PCDF.Table4e table4e = SAP_Module.PCDFData.Table4es.Where<PCDF.Table4e>((Func<PCDF.Table4e, bool>) (b => b.Group.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.TableGroup.ToString()) & b.Description.ToUpper().Equals(this.txtHeatingControls.Text.ToUpper()))).SingleOrDefault<PCDF.Table4e>();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode = Conversions.ToInteger(table4e.Code);
      }
      try
      {
        int controlCode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode;
        if (controlCode >= 2101 && controlCode <= 2110)
        {
          this.chkDelayedStart.Visible = true;
        }
        else
        {
          this.chkDelayedStart.Visible = false;
          this.chkDelayedStart.Checked = false;
        }
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCode)
        {
          case 2112:
          case 2208:
            this.cmdMainControlSelect.Visible = true;
            break;
          default:
            this.cmdMainControlSelect.Visible = false;
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void optCyManuLoss_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.optCyManuLoss.Enabled)
        return;
      if (this.optCyManuLoss.Checked)
      {
        this.txtCyDLoss.Enabled = true;
        this.txtCyInsulation.Enabled = false;
        this.txtCyInsThick.Text = "";
        this.txtCyInsThick.Enabled = false;
      }
      else
      {
        this.txtCyDLoss.Enabled = false;
        this.txtCyDLoss.Text = "";
        this.txtCyInsulation.Enabled = true;
        this.txtCyInsThick.Enabled = true;
      }
    }

    private void txtCyInsThick_TextChanged(object sender, EventArgs e) => this.txtCyInsThick.Text = Functions.RestrictValue(this.txtCyInsThick, 500);

    private void txtEfficiency_TextChanged(object sender, EventArgs e) => this.txtEfficiency.Text = Functions.RestrictValue(this.txtEfficiency, 500);

    private void txtPropertyType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPropertyType.Text, "House", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPropertyType.Text, "Bungalow", false) == 0)
      {
        this.txtFlatType.Enabled = false;
        this.txtFlatType.Text = "";
      }
      else
        this.txtFlatType.Enabled = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDCountry.Text, "Scotland", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPropertyType.Text, "Flat", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPropertyType.Text, "Maisonette", false) == 0)
          this.GroupFlatPosition.Visible = true;
        else
          this.GroupFlatPosition.Visible = false;
      }
      else
        this.GroupFlatPosition.Visible = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPropertyType.Text, "Flat", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPropertyType.Text, "Maisonette", false) == 0)
      {
        this.txtBuiltForm.Enabled = false;
        this.txtBuiltForm.Text = "";
      }
      else
        this.txtBuiltForm.Enabled = true;
    }

    private void txtFlatType_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtHETASMain_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating.GetMainEfficiency(this.txtPrimary.Text, this.txtSubGroup.Text, this.txtBoilerSub.Text, this.txtMainHeatingType.Text);
    }

    private void optCySummer_CheckedChanged(object sender, EventArgs e)
    {
      if (this.optCySummer.Checked)
      {
        this.txtImmersion.Enabled = true;
      }
      else
      {
        this.txtImmersion.Text = "";
        this.txtImmersion.Enabled = false;
      }
    }

    private void cmdExpandAll_Click(object sender, EventArgs e) => this.TreeSAP.ExpandAll();

    private void cmdCollapseAll_Click(object sender, EventArgs e)
    {
      TreeNode selectedNode = this.TreeSAP.SelectedNode;
      this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
      this.TreeSAP.CollapseAll();
      this.TreeSAP.Nodes[0].Expand();
      this.TreeSAP.SelectedNode = selectedNode;
    }

    private void chkKeepHot_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkKeepHot.Checked)
      {
        this.txtKeepHotFuel.Enabled = true;
        this.chkKeepHotTimed.Enabled = true;
      }
      else
      {
        this.txtKeepHotFuel.Enabled = false;
        this.txtKeepHotFuel.Text = "";
        this.chkKeepHotTimed.Enabled = false;
        this.chkKeepHotTimed.Checked = false;
      }
    }

    private void CopyDwellingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (SAP_Module.Proj.NoOfDwells < 1)
        {
          int num1 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "Copy");
        }
        else if (SAP_Module.CurrDwelling < 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "Please select dwelling first!", MsgBoxStyle.Information, (object) "Copy");
        }
        else
        {
          if (SAP_Module.CurrDwelling == -1)
            return;
          int num3 = (int) MyProject.Forms.Copy_Dwelling.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void chkDHWCommCylinder_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.grpDHWComm.Enabled)
        return;
      if (this.chkDHWCommCylinder.Checked)
        this.grpCylinder.Enabled = true;
      else
        this.grpCylinder.Enabled = false;
    }

    private void chkThermal_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkThermal.Checked)
      {
        this.txtThermalType.Enabled = true;
        this.txtThermalLocation.Enabled = true;
        this.txtThermalConnection.Enabled = true;
      }
      else
      {
        this.txtThermalType.Enabled = false;
        this.txtThermalLocation.Enabled = false;
        this.txtThermalConnection.Enabled = false;
        this.txtThermalType.Text = "";
        this.txtThermalLocation.Text = "";
        this.txtThermalConnection.Text = "";
      }
    }

    private void chkCommHBoiler2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkCommHBoiler2.Checked)
      {
        this.txtCommHB1HFraction.Enabled = true;
        this.txtCommHB2Fuel.Enabled = true;
        this.txtCommHB2Efficiency.Enabled = true;
      }
      else
      {
        this.txtCommHB1HFraction.Enabled = false;
        this.txtCommHB1HFraction.Text = "";
        this.txtCommHB2Fuel.Enabled = false;
        this.txtCommHB2Fuel.Text = "";
        this.txtCommHB2Efficiency.Enabled = false;
        this.txtCommHB2Efficiency.Text = "";
      }
    }

    private void txtWCombiType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.grpWBoiler.Enabled & !SAP_Module.ChangeNow))
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtWCombiType.Text, "Instantaneous Combi", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtWCombiType.Text, "", false) == 0)
        this.grpCylinder.Enabled = false;
      else
        this.grpCylinder.Enabled = true;
    }

    private void CleanToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index = 0;
      while (index <= num1)
      {
        if (SAP_Module.Proj.Dwellings[index].Water.SystemRef == 951)
        {
          int num2 = (int) Interaction.MsgBox((object) SAP_Module.Proj.Dwellings[index].Name);
        }
        checked { ++index; }
      }
      int num3 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int house = 0;
      while (house <= num3)
      {
        Validation.Checkerrors_All(house);
        checked { ++house; }
      }
      Functions.MakeTree();
    }

    private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e) => SAP_Module.RoundFigure = checked ((int) Math.Round(Conversion.Val(this.ToolStripComboBox1.Text)));

    private void DraftPDFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CreatePDF createPdf = new CreatePDF();
    }

    private void SAPWorksheetToolStripMenuItem_Click(object sender, EventArgs e) => this.ToolStripButton6_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void NumericUpDown1_ValueChanged(object sender, EventArgs e) => SAP_Module.RoundFigure = Convert.ToInt32(this.NumericUpDown1.Value);

    private void cmdMoveUp_Click(object sender, EventArgs e)
    {
      SAP_Module.DontChange = true;
      try
      {
        if (SAP_Module.CurrDwelling > 0)
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
          SAP_Module.Dwelling Dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[checked (SAP_Module.CurrDwelling - 1)]);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.CurrDwelling - 1)] = Functions.CopyDwelling(Dwelling);
          Functions.MakeTree();
          this.TreeSAP.CollapseAll();
          this.TreeSAP.Nodes[0].Expand();
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0].Nodes[checked (SAP_Module.CurrDwelling - 1)];
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Module.DontChange = false;
    }

    private void cmdMoveDown_Click(object sender, EventArgs e)
    {
      SAP_Module.DontChange = true;
      try
      {
        if (SAP_Module.CurrDwelling < checked (SAP_Module.Proj.NoOfDwells - 1))
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
          SAP_Module.Dwelling Dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling]);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[checked (SAP_Module.CurrDwelling + 1)]);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.CurrDwelling + 1)] = Functions.CopyDwelling(Dwelling);
          Functions.MakeTree();
          this.TreeSAP.CollapseAll();
          this.TreeSAP.Nodes[0].Expand();
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0].Nodes[checked (SAP_Module.CurrDwelling + 1)];
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Module.DontChange = false;
    }

    private void txtMainFuel_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "heating oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "biodiesel from any biomass source", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "biodiesel from used cooking oil only", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "rapeseed oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "appliances able to use mineral oil or liquid biofuel", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "B30K", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMainFuel.Text, "bioethanol from any biomass source", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPrimary.Text, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          this.chkOilPump.Visible = true;
          this.chkOilPump.Enabled = true;
        }
        else
        {
          this.chkOilPump.Checked = false;
          this.chkOilPump.Visible = false;
        }
      }
      else
      {
        this.chkOilPump.Checked = false;
        this.chkOilPump.Visible = false;
      }
    }

    private void txtSecMainFuel_TextChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "heating oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "biodiesel from any biomass source", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "biodiesel from used cooking oil only", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "rapeseed oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "appliances able to use mineral oil or liquid biofuel", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "B30K", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "bioethanol from any biomass source", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSECPrimary.Text, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          this.chkSecOilPump.Visible = true;
        }
        else
        {
          this.chkSecOilPump.Checked = false;
          this.chkSecOilPump.Visible = false;
        }
      }
      else
      {
        this.chkSecOilPump.Checked = false;
        this.chkSecOilPump.Visible = false;
      }
    }

    private void ToolStripButton6_Click(object sender, EventArgs e)
    {
      try
      {
        if (SAP_Module.Proj.NoOfDwells < 1)
        {
          int num1 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "View Reports");
        }
        else if (SAP_Module.CurrDwelling < 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "Please select dwelling first!", MsgBoxStyle.Information, (object) "View Reports");
        }
        else
        {
          if (SAP_Module.CurrDwelling == -1)
            return;
          if (!Validation.LodgementStatusCheck(SAP_Module.CurrDwelling))
          {
            int num3 = (int) Interaction.MsgBox((object) "Dwelling incomplete, reports are unavailable!", MsgBoxStyle.Information, (object) "View Reports");
          }
          else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name, "", false) > 0U)
          {
            Reports reports = new Reports();
            int num4 = (int) reports.ShowDialog();
            reports.Close();
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void chkMainHLoadWeather_CheckedChanged(object sender, EventArgs e)
    {
      SAP_Module.DontChange = true;
      if (this.chkMainHLoadWeather.Checked)
      {
        this.cmdMainControlSelectWeather.Visible = true;
        if (!SAP_Module.Proj.OverRide)
        {
          this.chkDelayedStart.Checked = false;
          this.chkDelayedStart.Enabled = false;
        }
        else
          this.chkDelayedStart.Enabled = true;
      }
      else
      {
        this.cmdMainControlSelectWeather.Visible = false;
        if (!SAP_Module.Proj.OverRide)
        {
          this.ErrorPChecker.SetError((Control) this.chkMainHLoadWeather, "");
          this.txtLoadWeather.Text = "";
          this.lblControlWeather.Text = "";
          this.chkDelayedStart.Enabled = true;
        }
        else
          this.chkDelayedStart.Enabled = true;
      }
    }

    private void SAPInputToolStripMenuItem_Click(object sender, EventArgs e) => SAPInput.CreateSAPInput(SAP_Module.CurrDwelling, 1);

    private void ViewCheckListToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void OverheatingToolStripMenuItem_Click(object sender, EventArgs e) => SAPInput.CreateOverHeatingDoc(SAP_Module.CurrDwelling, 1);

    private void Button2_Click_1(object sender, EventArgs e)
    {
      if (this.Dims.SelectedRows.Count > 0)
      {
        try
        {
          this.Dims.Rows.RemoveAt(this.Dims.SelectedRows[0].Index);
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
          this.Dims.Rows.RemoveAt(this.Dims.CurrentRow.Index);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void Dims_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e) => this.cmdArea.Visible = false;

    private void BatchLodgementToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        MyProject.Forms.Batch_Lodgement.ReadInSurvey();
        int num = (int) MyProject.Forms.Batch_Lodgement.ShowDialog();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private bool CheckFont()
    {
      FontFamily[] families = new InstalledFontCollection().Families;
      int index = 0;
      while (index < families.Length)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(families[index].Name, "DejaVu Sans", false) == 0)
          return true;
        checked { ++index; }
      }
      int num = (int) Interaction.MsgBox((object) "Please note that to enable the production of EPCs\r\nYou need to install a required font.\r\nThe installation of the font will start\r\nfolling this message being closed.\r\n\r\nIMPORTANT:\r\nYou will also need to save your work and restart the application", MsgBoxStyle.Critical, (object) "Font Installation");
      Process.Start(Application.StartupPath + "\\Fonts\\DejaVuSans_0.ttf");
      return false;
    }

    private void ProjectLodgementHistoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Lodgement_History.FillHistory();
      int num = (int) MyProject.Forms.Lodgement_History.ShowDialog();
    }

    private void ViewReportsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.ToolStripButton6_Click(RuntimeHelpers.GetObjectValue(sender), e);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void LoginToStromaCertificationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.Members_Details.ShowDialog();
    }

    private void Floors_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e) => this.cmdFloorArea.Visible = false;

    private void Floors_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "Floor";

    private void Floors_RowHeadersWidthChanged(object sender, EventArgs e) => this.cmdFloorArea.Left = checked (this.Floors.RowHeadersWidth + this.Floors.Columns[0].Width + this.Floors.Columns[1].Width + this.Floors.Columns[2].Width + this.Floors.Columns[3].Width + 5);

    private void Walls_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "Wall";

    private void Walls_RowHeadersWidthChanged(object sender, EventArgs e)
    {
      this.cmdWallArea.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + 5 - this.Walls.HorizontalScrollingOffset);
      this.cmdGetWallArea.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + 5 - this.Walls.HorizontalScrollingOffset);
      this.cmdWallShelter.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + this.Walls.Columns[4].Width + this.Walls.Columns[5].Width + 5 - this.Walls.HorizontalScrollingOffset);
    }

    private void Roofs_RowHeadersWidthChanged(object sender, EventArgs e)
    {
      this.cmdRoofArea.Left = checked (this.Roofs.RowHeadersWidth + this.Roofs.Columns[0].Width + this.Roofs.Columns[1].Width + this.Roofs.Columns[2].Width + this.Roofs.Columns[3].Width + 5);
      this.cmdRoofShelter.Left = checked (this.Roofs.RowHeadersWidth + this.Roofs.Columns[0].Width + this.Roofs.Columns[1].Width + this.Roofs.Columns[2].Width + this.Roofs.Columns[3].Width + this.Roofs.Columns[4].Width + this.Roofs.Columns[5].Width + 5);
    }

    private void Walls_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdWallArea.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + this.Walls.Columns[4].Width + 5 - this.Walls.HorizontalScrollingOffset);
        this.cmdWallShelter.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + this.Walls.Columns[4].Width + this.Walls.Columns[5].Width + this.Walls.Columns[6].Width + 5 - this.Walls.HorizontalScrollingOffset);
        this.cmdWallArea.Top = checked (this.Walls.Top + this.Walls.ColumnHeadersHeight + this.Walls.CurrentCell.RowIndex * 22 - this.Walls.VerticalScrollingOffset);
        this.cmdWallShelter.Top = checked (this.Walls.Top + this.Walls.ColumnHeadersHeight + this.Walls.CurrentCell.RowIndex * 22 - this.Walls.VerticalScrollingOffset);
        this.cmdGetWallArea.Left = checked (this.Walls.RowHeadersWidth + this.Walls.Columns[0].Width + this.Walls.Columns[1].Width + this.Walls.Columns[2].Width + this.Walls.Columns[3].Width + 5 - this.Walls.HorizontalScrollingOffset);
        this.cmdGetWallArea.Top = checked (this.Walls.Top + this.Walls.ColumnHeadersHeight + this.Walls.CurrentCell.RowIndex * 22 - this.Walls.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Floors_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteFloors();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Roofs_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteRoofs();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void txtWetRooms_ValueChanged_1(object sender, EventArgs e)
    {
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID > 0U)
      {
        string text = this.txtMechVentilation.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Balanced with heat recovery", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Centralised whole house extract", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Decentralised whole house extract", false) != 0)
            return;
          this.lblFanPower.Visible = false;
        }
        else
        {
          List<PCDF.Products321_Sub> list = SAP_Module.PCDFData.Products321s_Sub.Where<PCDF.Products321_Sub>((Func<PCDF.Products321_Sub, bool>) (b => b.Ref.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID.ToString()) & b.AdditionalWetRoom.Equals(this.txtWetRooms.Value.ToString()))).ToList<PCDF.Products321_Sub>();
          if (list.Count == 0)
          {
            int num = (int) Interaction.MsgBox((object) "Wet room input Error - Please select correct number of wet rooms.", MsgBoxStyle.Information, (object) "Ventilation Section");
          }
          else if (list.Count == 1)
          {
            this.lblFanPower.Visible = true;
            this.lblFanPower.Text = "(SFP=" + list[0].SFP + ")";
          }
          else
            this.lblFanPower.Visible = false;
        }
      }
      else
        this.lblFanPower.Visible = false;
    }

    private void txtElectricityTariff_SelectedIndexChanged(object sender, EventArgs e) => this.CheckElectCPSU();

    private void CheckElectCPSU()
    {
      if (SAP_Module.ChangeNow || !(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode == 192 & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtElectricityTariff.Text, "10-hour tariff", false) > 0U))
        return;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtElectricityTariff.Text, "", false) > 0U)
      {
        if (Interaction.MsgBox((object) ("For Electric CPSU, only '10-hour tariff' should be select.\r\n\r\nAre you sure you want to use " + this.txtElectricityTariff.Text + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Electricity Tarrif") == MsgBoxResult.No)
          this.txtElectricityTariff.Text = "10-hour tariff";
      }
      else
        this.txtElectricityTariff.Text = "10-hour tariff";
    }

    private void CheckElectCPSU2()
    {
      if (SAP_Module.ChangeNow || SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode != 192)
        ;
    }

    private void txtMainHeatingType_SelectionChangeCommitted(object sender, EventArgs e)
    {
    }

    private void RemoveRowToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        string currElementControl = this.CurrElementControl;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(currElementControl))
        {
          case 227935478:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "InternalFloor", false) != 0)
              break;
            this.Button16_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 701293109:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "Wall", false) != 0)
              break;
            this.Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 1587810493:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "Floor", false) != 0)
              break;
            this.Button4_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 2245904436:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "InternalWall", false) != 0)
              break;
            this.Button19_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 2528020879:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "InternalCeiling", false) != 0)
              break;
            this.Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 2769539936:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "PartyWalls", false) != 0)
              break;
            this.Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 2938728559:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "Roof", false) != 0)
              break;
            this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 3095283595:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "PartyFloor", false) != 0)
              break;
            this.Button8_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
          case 4215615075:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(currElementControl, "PartyCeilings", false) != 0)
              break;
            this.Button14_Click(RuntimeHelpers.GetObjectValue(sender), e);
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (this.Floors.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.Floors.SelectedRows[0].Index;
          List<SAP_Module.Opaques> list = ((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors).ToList<SAP_Module.Opaques>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors) - 1);
          local = num;
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
          int index = this.Floors.CurrentRow.Index;
          List<SAP_Module.Opaques> list = ((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors).ToList<SAP_Module.Opaques>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadFloors();
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      if (this.Walls.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.Walls.SelectedRows[0].Index;
          List<SAP_Module.Opaques> list = ((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls).ToList<SAP_Module.Opaques>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls) - 1);
          local = num;
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
          int index = this.Walls.CurrentRow.Index;
          List<SAP_Module.Opaques> list = ((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls).ToList<SAP_Module.Opaques>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadWalls();
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      if (this.Roofs.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.Roofs.SelectedRows[0].Index;
          List<SAP_Module.Opaques> list = ((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs).ToList<SAP_Module.Opaques>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs) - 1);
          local = num;
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
          int index = this.Roofs.CurrentRow.Index;
          List<SAP_Module.Opaques> list = ((IEnumerable<SAP_Module.Opaques>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs).ToList<SAP_Module.Opaques>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadRoofs();
    }

    private void Roofs_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "Roof";

    private void dataGridConstruction_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (SAP_Module.NoCalc)
        return;
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling != -1)
        Functions.CalculateNow();
    }

    private void txtOverHeat_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.NoCalc)
        return;
      SAP_Write.SaveDetails();
      this.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Nodes[7].ImageIndex = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Validation.OverHeating_Check ? 7 : 6;
    }

    private void Roofs_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void AboutStromaFSAPToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.About.ShowDialog();
    }

    private void PartyFloors_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 3)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdPFloorArea.Left = checked (this.PartyFloors.RowHeadersWidth + this.PartyFloors.Columns[0].Width + this.PartyFloors.Columns[1].Width + this.PartyFloors.Columns[2].Width + this.PartyFloors.Columns[3].Width + 5);
        this.cmdPFloorArea.Top = checked (this.PartyFloors.Top + this.PartyFloors.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdPFloorArea.Visible = true;
      }
      else
        this.cmdPFloorArea.Visible = false;
    }

    private void PartyWalls_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 4)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdPWallArea.Left = checked (this.PartyWalls.RowHeadersWidth + this.PartyWalls.Columns[0].Width + this.PartyWalls.Columns[1].Width + this.PartyWalls.Columns[2].Width + this.PartyWalls.Columns[3].Width + this.PartyWalls.Columns[4].Width + 5);
        this.cmdPWallArea.Top = checked (this.PartyWalls.Top + this.PartyWalls.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdPWallArea.Visible = true;
      }
      else
        this.cmdPWallArea.Visible = false;
    }

    private void PartyCeilings_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 3)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdPCeilingArea.Left = checked (this.PartyCeilings.RowHeadersWidth + this.PartyCeilings.Columns[0].Width + this.PartyCeilings.Columns[1].Width + this.PartyCeilings.Columns[2].Width + this.PartyCeilings.Columns[3].Width + 5);
        this.cmdPCeilingArea.Top = checked (this.PartyCeilings.Top + this.PartyCeilings.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdPCeilingArea.Visible = true;
      }
      else
        this.cmdPCeilingArea.Visible = false;
    }

    private void cmdPFloorArea_Click(object sender, EventArgs e)
    {
      if (this.PartyFloors.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.PartyFloors;
      SAP_Module.RowNow = this.PartyFloors.CurrentCell.RowIndex;
      if (this.PartyFloors.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.PartyFloors.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void cmdPWallArea_Click(object sender, EventArgs e)
    {
      if (this.PartyWalls.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.PartyWalls;
      SAP_Module.RowNow = this.PartyWalls.CurrentCell.RowIndex;
      if (this.PartyWalls.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.PartyWalls.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void cmdPCeilingArea_Click(object sender, EventArgs e)
    {
      if (this.PartyCeilings.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.PartyCeilings;
      SAP_Module.RowNow = this.PartyCeilings.CurrentCell.RowIndex;
      if (this.PartyCeilings.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.PartyCeilings.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void InternalFloor_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 3)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdIFloorArea.Left = checked (this.InternalFloor.RowHeadersWidth + this.InternalFloor.Columns[0].Width + this.InternalFloor.Columns[1].Width + this.InternalFloor.Columns[2].Width + this.InternalFloor.Columns[3].Width + 5);
        this.cmdIFloorArea.Top = checked (this.InternalFloor.Top + this.InternalFloor.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdIFloorArea.Visible = true;
      }
      else
        this.cmdIFloorArea.Visible = false;
    }

    private void cmdIFloorArea_Click(object sender, EventArgs e)
    {
      if (this.InternalFloor.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.InternalFloor;
      SAP_Module.RowNow = this.InternalFloor.CurrentCell.RowIndex;
      if (this.InternalFloor.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.InternalFloor.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void cmdIWallArea_Click(object sender, EventArgs e)
    {
      if (this.InternalWall.CurrentCell == null)
        return;
      SAP_Module.ControlNow = this.InternalWall;
      SAP_Module.RowNow = this.InternalWall.CurrentCell.RowIndex;
      if (this.InternalWall.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.InternalWall.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
        SendKeys.SendWait("\t");
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
      }
    }

    private void cmdICeilingArea_Click(object sender, EventArgs e)
    {
      SAP_Module.ControlNow = this.InternalCeiling;
      SAP_Module.RowNow = this.InternalCeiling.CurrentCell.RowIndex;
      if (this.InternalCeiling.Rows[SAP_Module.RowNow].IsNewRow)
      {
        this.DontAdd = true;
        this.InternalCeiling.Rows.Add();
        SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
        this.DontAdd = false;
      }
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings != null)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings.Length >= checked (SAP_Module.RowNow + 1))
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L1);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W1);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L2);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W2);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L3);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W3);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L4);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W4);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L5);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W5);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L6);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W6);
        }
        else
        {
          MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
          MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
        }
      }
      else
      {
        MyProject.Forms.AreaCalc.txtL1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW1.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW2.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW3.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW4.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW5.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtL6.Text = Conversions.ToString(0);
        MyProject.Forms.AreaCalc.txtW6.Text = Conversions.ToString(0);
      }
      if (MyProject.Forms.AreaCalc.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow].Value = (object) MyProject.Forms.AreaCalc.txtArea.Text;
      SendKeys.SendWait("\t");
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W1 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W2 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W3 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL4.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W4 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW4.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL5.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W5 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW5.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.L6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtL6.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[SAP_Module.RowNow].Dims.W6 = (float) Conversion.Val(MyProject.Forms.AreaCalc.txtW6.Text);
    }

    private void InternalWall_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void InternalWall_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 3)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdIWallArea.Left = checked (this.InternalWall.RowHeadersWidth + this.InternalWall.Columns[0].Width + this.InternalWall.Columns[1].Width + this.InternalWall.Columns[2].Width + this.InternalWall.Columns[3].Width + 5);
        this.cmdIWallArea.Top = checked (this.InternalWall.Top + this.InternalWall.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdIWallArea.Visible = true;
      }
      else
        this.cmdIWallArea.Visible = false;
    }

    private void InternalCeiling_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DontAdd)
        return;
      if (e.ColumnIndex == 3)
      {
        SAP_Module.RowNow = e.RowIndex;
        SAP_Module.ColNow = e.ColumnIndex;
        this.cmdICeilingArea.Left = checked (this.InternalCeiling.RowHeadersWidth + this.InternalCeiling.Columns[0].Width + this.InternalCeiling.Columns[1].Width + this.InternalCeiling.Columns[2].Width + this.InternalCeiling.Columns[3].Width + 5);
        this.cmdICeilingArea.Top = checked (this.InternalCeiling.Top + this.InternalCeiling.ColumnHeadersHeight + e.RowIndex * 22);
        this.cmdICeilingArea.Visible = true;
      }
      else
        this.cmdICeilingArea.Visible = false;
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      if (this.PartyFloors.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.PartyFloors.SelectedRows[0].Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors) - 1);
          local = num;
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
          int index = this.PartyFloors.CurrentRow.Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadFloors();
    }

    private void Button11_Click(object sender, EventArgs e)
    {
      if (this.PartyWalls.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.PartyWalls.SelectedRows[0].Index;
          List<SAP_Module.PartyWall> list = ((IEnumerable<SAP_Module.PartyWall>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls).ToList<SAP_Module.PartyWall>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls) - 1);
          local = num;
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
          int index = this.PartyWalls.CurrentRow.Index;
          List<SAP_Module.PartyWall> list = ((IEnumerable<SAP_Module.PartyWall>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls).ToList<SAP_Module.PartyWall>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadWalls();
    }

    private void Button14_Click(object sender, EventArgs e)
    {
      if (this.PartyCeilings.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.PartyCeilings.SelectedRows[0].Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings) - 1);
          local = num;
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
          int index = this.PartyCeilings.CurrentRow.Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadRoofs();
    }

    private void Button16_Click(object sender, EventArgs e)
    {
      if (this.InternalFloor.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.InternalFloor.SelectedRows[0].Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors) - 1);
          local = num;
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
          int index = this.InternalFloor.CurrentRow.Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadFloors();
    }

    private void Button19_Click(object sender, EventArgs e)
    {
      if (this.InternalWall.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.InternalWall.SelectedRows[0].Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls) - 1);
          local = num;
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
          int index = this.InternalWall.CurrentRow.Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadWalls();
    }

    private void Button22_Click(object sender, EventArgs e)
    {
      if (this.InternalCeiling.SelectedRows.Count > 0)
      {
        try
        {
          int index = this.InternalCeiling.SelectedRows[0].Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings) - 1);
          local = num;
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
          int index = this.InternalCeiling.CurrentRow.Index;
          List<SAP_Module.PartyElements> list = ((IEnumerable<SAP_Module.PartyElements>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings).ToList<SAP_Module.PartyElements>();
          list.RemoveAt(index);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings = list.ToArray();
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings) - 1);
          local = num;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      SAP_Read.ReadRoofs();
    }

    private void PartyFloors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteFloors();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void InternalFloor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteFloors();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void PartyWalls_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteWalls();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void InternalWall_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteWalls();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void PartyCeilings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteRoofs();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void InternalCeiling_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteRoofs();
      if (this.Visible)
        this.AddCalcHandle();
    }

    public float ShowMeK(string Selection, int Type)
    {
      string str = Selection;
      float num;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 131582513:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dense plaster both sides. lightweight aggregate blocks, cavity", false) == 0)
          {
            num = 140f;
            break;
          }
          goto default;
        case 143263955:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dense plaster both sides, dense blocks, cavity", false) == 0)
          {
            num = 180f;
            break;
          }
          goto default;
        case 355490041:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plasterboard on timber frame", false) == 0)
          {
            num = 9f;
            break;
          }
          goto default;
        case 488099947:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Solid wall: plasterboard on dabs or battens, 210 mm brick, insulated externally", false) == 0)
          {
            num = 110f;
            break;
          }
          goto default;
        case 534080283:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Suspended timber, insulation between joists", false) == 0)
          {
            num = 20f;
            break;
          }
          goto default;
        case 647260388:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Timber I-joists, carpeted", false) == 0)
          {
            num = Type != 1 ? 20f : 30f;
            break;
          }
          goto default;
        case 693729476:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Solid wall: dense plaster, insulation, any outside structure", false) == 0)
          {
            num = 17f;
            break;
          }
          goto default;
        case 696615055:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Cavity wall: dense plaster, dense block, filled cavity, any outside structure", false) == 0)
          {
            num = 190f;
            break;
          }
          goto default;
        case 901879888:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Precast concrete plank floor (screed laid on insulation) ,carpeted", false) == 0)
          {
            num = Type != 1 ? 30f : 40f;
            break;
          }
          goto default;
        case 1129013689:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Single plasterboard on dabs both sides, lightweight aggregate blocks, cavity", false) == 0)
          {
            num = 110f;
            break;
          }
          goto default;
        case 1158182967:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dense block, dense plaster", false) == 0)
          {
            num = 100f;
            break;
          }
          goto default;
        case 1362660524:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plaster on dabs and single plasterboard on both sides, dense cellular blocks, cavity", false) == 0)
          {
            num = 70f;
            break;
          }
          goto default;
        case 1442313981:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Timber framed wall (one layer of plasterboard)", false) == 0)
          {
            num = 9f;
            break;
          }
          goto default;
        case 1545008587:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Cavity wall: dense plaster, AAC block, filled cavity, any outside structure", false) == 0)
          {
            num = 70f;
            break;
          }
          goto default;
        case 1663324492:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Timber framed wall (two layers of plasterboard)", false) == 0)
          {
            num = 18f;
            break;
          }
          goto default;
        case 1911876480:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Precast concrete plank floor (screed laid on rubber),carpeted", false) == 0)
          {
            num = Type != 1 ? 30f : 70f;
            break;
          }
          goto default;
        case 1965930503:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Cavity wall: plasterboard on dabs or battens, dense block, filled cavity, any outside structure", false) == 0)
          {
            num = 150f;
            break;
          }
          goto default;
        case 2117854937:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plasterboard ceiling, carpeted chipboard floor", false) == 0)
          {
            num = Type != 1 ? 9f : 18f;
            break;
          }
          goto default;
        case 2211866141:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Suspended concrete floor, carpeted", false) == 0)
          {
            num = 75f;
            break;
          }
          goto default;
        case 2225889964:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Single plasterboard on dabs on both sides, dense blocks, cavity", false) == 0)
          {
            num = 70f;
            break;
          }
          goto default;
        case 2329365093:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plasterboard on dabs mounted on cement render on both sides, AAC blocks, cavity", false) == 0)
          {
            num = 45f;
            break;
          }
          goto default;
        case 2398560694:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Steel frame wall (warm frame or hybrid construction)", false) == 0)
          {
            num = 14f;
            break;
          }
          goto default;
        case 2417615263:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Slab on ground, screed over insulation", false) == 0)
          {
            num = 110f;
            break;
          }
          goto default;
        case 2460427643:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Precast concrete planks floor, screed, carpeted", false) == 0)
          {
            num = Type != 1 ? 30f : 40f;
            break;
          }
          goto default;
        case 2678356784:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Timber exposed floor, insulation between joists", false) == 0)
          {
            num = 20f;
            break;
          }
          goto default;
        case 2722026195:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Cavity wall: plasterboard on dabs or battens, AAC block, filled cavity, any outside structure", false) == 0)
          {
            num = 60f;
            break;
          }
          goto default;
        case 2759240777:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Steel frame", false) == 0)
          {
            num = 20f;
            break;
          }
          goto default;
        case 2775502153:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Double plasterboard on both sides, twin timber frame with/without sheathing board", false) == 0)
          {
            num = 20f;
            break;
          }
          goto default;
        case 2956941634:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plasterboard, insulated slope", false) == 0)
          {
            num = 9f;
            break;
          }
          goto default;
        case 3096708938:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Concrete floor slab, carpeted", false) == 0)
          {
            num = Type != 1 ? 100f : 80f;
            break;
          }
          goto default;
        case 3304546979:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plasterboard, insulated at ceiling level", false) == 0)
          {
            num = 9f;
            break;
          }
          goto default;
        case 3463701588:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Solid wall: plasterboard on dabs or battens, insulation, any outside structure", false) == 0)
          {
            num = 9f;
            break;
          }
          goto default;
        case 3505235099:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Solid wall: dense plaster, 210 mm brick, insulated externally", false) == 0)
          {
            num = 135f;
            break;
          }
          goto default;
        case 3583406338:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Plasterboard, insulated flat roof", false) == 0)
          {
            num = 9f;
            break;
          }
          goto default;
        case 3842420687:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Solid wall: plasterboard on dabs or battens, 200 mm dense block, insulated externally", false) == 0)
          {
            num = 150f;
            break;
          }
          goto default;
        case 4021136919:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Dense block, plasterboard on dabs", false) == 0)
          {
            num = 75f;
            break;
          }
          goto default;
        case 4246915433:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "In-situ concrete slab supported by profiled metal deck, carpeted", false) == 0)
          {
            num = Type != 1 ? 90f : 64f;
            break;
          }
          goto default;
        case 4257882943:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Solid wall: dense plaster, 200 mm dense block, insulated externally", false) == 0)
          {
            num = 190f;
            break;
          }
          goto default;
        default:
          num = 0.0f;
          break;
      }
      return num;
    }

    private void PartyFloors_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.PartyFloors.CurrentCell.ColumnIndex != 2)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.PartyFloorComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.PartyFloorComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PartyFloorComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.PartyFloors[4, this.PartyFloors.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(((ComboBox) sender).SelectedItem), 1);

    private void PartyWalls_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.PartyWalls.CurrentCell.ColumnIndex == 3)
        {
          ComboBox control = (ComboBox) e.Control;
          control.Cursor = Cursors.Hand;
          if (control != null)
          {
            control.SelectedIndexChanged -= new EventHandler(this.PartyWallsComboBox_SelectedIndexChanged);
            control.SelectedIndexChanged += new EventHandler(this.PartyWallsComboBox_SelectedIndexChanged);
          }
        }
        if (this.PartyWalls.CurrentCell.ColumnIndex != 2)
          return;
        ComboBox control1 = (ComboBox) e.Control;
        control1.Cursor = Cursors.Hand;
        if (control1 != null)
        {
          control1.SelectedIndexChanged -= new EventHandler(this.ParyWallU_Value);
          control1.SelectedIndexChanged += new EventHandler(this.ParyWallU_Value);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ParyWallU_Value(object sender, EventArgs e)
    {
      object selectedItem = ((ComboBox) sender).SelectedItem;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, (object) "Solid", false))
        this.PartyWalls[5, this.PartyWalls.CurrentCell.RowIndex].Value = (object) 0.0;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, (object) "Unfilled cavity with no effective edge sealing", false))
        this.PartyWalls[5, this.PartyWalls.CurrentCell.RowIndex].Value = (object) 0.5;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, (object) "Unfilled cavity with effective sealing around all exposed edges and in line with insulation layers in abutting elements", false))
      {
        this.PartyWalls[5, this.PartyWalls.CurrentCell.RowIndex].Value = (object) 0.2;
      }
      else
      {
        if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(selectedItem, (object) "Fully filled cavity with effective sealing at all exposed edges and in line with insulation layers in abutting elements", false))
          return;
        this.PartyWalls[5, this.PartyWalls.CurrentCell.RowIndex].Value = (object) 0.0;
      }
    }

    private void PartyWallsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      object selectedItem = comboBox.SelectedItem;
      if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Solid", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Unfilled cavity with no effective edge sealing", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Unfilled cavity with effective sealing around all exposed edges and in line with insulation layers in abutting elements", false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Fully filled cavity with effective sealing at all exposed edges and in line with insulation layers in abutting elements", false)) ? 1 : 0))))
        return;
      this.PartyWalls[6, this.PartyWalls.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(comboBox.SelectedItem), 1);
    }

    private void PartyCeilings_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.PartyCeilings.CurrentCell.ColumnIndex != 2)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.PartyCeilingsComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.PartyCeilingsComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PartyCeilingsComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.PartyCeilings[4, this.PartyCeilings.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(((ComboBox) sender).SelectedItem), 2);

    private void InternalFloor_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.InternalFloor.CurrentCell.ColumnIndex != 2)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.InternalFloorComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.InternalFloorComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalFloorComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.InternalFloor[4, this.InternalFloor.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(((ComboBox) sender).SelectedItem), 1);

    private void InternalWall_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.InternalWall.CurrentCell.ColumnIndex != 2)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.InternalWallComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.InternalWallComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalWallComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.InternalWall[4, this.InternalWall.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(((ComboBox) sender).SelectedItem), 1);

    private void InternalCeiling_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.InternalCeiling.CurrentCell.ColumnIndex != 2)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.InternalCeilingComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.InternalCeilingComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalCeilingComboBox_SelectedIndexChanged(object sender, EventArgs e) => this.InternalCeiling[4, this.InternalCeiling.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(((ComboBox) sender).SelectedItem), 2);

    private void Floors_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.Floors.CurrentCell.ColumnIndex != 3)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.FloorsComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.FloorsComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void FloorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      object selectedItem = comboBox.SelectedItem;
      if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Basement floor", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Ground floor", false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Exposed floor", false)) ? 1 : 0))))
        return;
      this.Floors[6, this.Floors.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(comboBox.SelectedItem), 1);
    }

    private void Walls_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.Walls.CurrentCell.ColumnIndex != 3)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.WallsComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.WallsComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void WallsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      object selectedItem = comboBox.SelectedItem;
      if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Basement wall", false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Exposed wall", false)) ? 1 : 0))))
        return;
      this.Walls[9, this.Walls.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(comboBox.SelectedItem), 1);
    }

    private void Roofs_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      try
      {
        if (this.Roofs.CurrentCell.ColumnIndex != 3)
          return;
        ComboBox control = (ComboBox) e.Control;
        control.Cursor = Cursors.Hand;
        if (control != null)
        {
          control.SelectedIndexChanged -= new EventHandler(this.RoofsComboBox_SelectedIndexChanged);
          control.SelectedIndexChanged += new EventHandler(this.RoofsComboBox_SelectedIndexChanged);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void RoofsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      object selectedItem = comboBox.SelectedItem;
      if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Pichted - insulated rafters", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Pitched - insulated joists", false)) || Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Flat roof", false)) ? 1 : (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(selectedItem, (object) "Pitched - insulated rafters", false)) ? 1 : 0))))
        return;
      this.Roofs[8, this.Roofs.CurrentCell.RowIndex].Value = (object) this.ShowMeK(Conversions.ToString(comboBox.SelectedItem), 1);
    }

    private void txtTMP_SelectedIndexChanged(object sender, EventArgs e) => this.TMP();

    public void TMP()
    {
      this.LBlInstruction.Visible = false;
      string text = this.txtTMP.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Calculated", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Indicative Value", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "User Value", false) != 0)
            return;
          this.lblTMPIndicative.Visible = false;
          this.txtTMPIndicative.Visible = false;
          this.lblTMPUser.Visible = true;
          this.txtTMPUser.Visible = true;
          this.LBlInstruction.Visible = false;
        }
        else
        {
          this.lblTMPIndicative.Visible = true;
          this.txtTMPIndicative.Visible = true;
          this.lblTMPUser.Visible = false;
          this.txtTMPUser.Visible = false;
          this.LBlInstruction.Visible = false;
        }
      }
      else
      {
        this.lblTMPIndicative.Visible = false;
        this.txtTMPIndicative.Visible = false;
        this.lblTMPUser.Visible = false;
        this.txtTMPUser.Visible = false;
        this.LBlInstruction.Visible = true;
      }
    }

    private void cmdPhotoNew_Click(object sender, EventArgs e)
    {
      this.txtPPower.Text = "";
      this.txtPTilt.Text = "";
      this.txtPCOrientation.Text = "";
      this.txtPOvershading.Text = "";
      this.CurrPhotoV = -1;
    }

    private void cmdPhotoDelete_Click(object sender, EventArgs e)
    {
      if (this.CurrPhotoV == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select an item to delete", MsgBoxStyle.Information, (object) "Photovoltaic Section");
      }
      else
      {
        try
        {
          int currDwelling = SAP_Module.CurrDwelling;
          int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 2);
          int index = currDwelling;
          while (index <= num2)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[index] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (index + 1)];
            checked { ++index; }
          }
          // ISSUE: variable of a reference type
          SAP_Module.PhotoVoltaics[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 2 + 1)]);
          local = photoVoltaicsArray;
          SAP_Write.SaveDetails();
          Functions.CalculateNow();
          SAP_Read.ReadRenewables();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void cmdPhotoOK_Click(object sender, EventArgs e)
    {
      try
      {
        bool flag;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPPower.Text, "", false) == 0)
          flag = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPTilt.Text, "", false) == 0)
          flag = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPCOrientation.Text, "", false) == 0)
          flag = true;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPOvershading.Text, "", false) == 0)
          flag = true;
        if (!this.chkPVDirect.Checked & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboPVConnection.Text, "", false) == 0)
          flag = true;
        if (flag)
        {
          int num = (int) Interaction.MsgBox((object) "Incomplete, please complete all sections", MsgBoxStyle.Information, (object) "Photovoltaic Section");
        }
        else
        {
          if (this.CurrPhotoV == -1)
          {
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics == null)
            {
              // ISSUE: variable of a reference type
              SAP_Module.PhotoVoltaics[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[1]);
              local = photoVoltaicsArray;
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.PhotoVoltaics[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PhotoVoltaics[] photoVoltaicsArray = (SAP_Module.PhotoVoltaics[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics), (Array) new SAP_Module.PhotoVoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length + 1)]);
              local = photoVoltaicsArray;
            }
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)] = new SAP_Module.PhotoVoltaics();
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)].PPower = (float) Conversion.Val(this.txtPPower.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)].PTilt = this.txtPTilt.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)].PCOrientation = this.txtPCOrientation.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)].POvershading = this.txtPOvershading.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)].DirectlyConnected = this.chkPVDirect.Checked;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1)].FlatConnection = this.cboPVConnection.Text;
          }
          else
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].PPower = (float) Conversion.Val(this.txtPPower.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].PTilt = this.txtPTilt.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].PCOrientation = this.txtPCOrientation.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].POvershading = this.txtPOvershading.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].DirectlyConnected = this.chkPVDirect.Checked;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[this.CurrPhotoV].FlatConnection = this.cboPVConnection.Text;
          }
          SAP_Write.SaveDetails();
          Functions.CalculateNow();
          SAP_Read.ReadRenewables();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtNoofChmneysMain_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      this.txtNoofChmneys.Value = Decimal.Add(Decimal.Add(this.txtNoofChmneysMain.Value, this.txtNoofChmneysSec.Value), this.txtNoofChmneysOther.Value);
    }

    private void txtNoofOpenFluesMain_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      this.txtNoofOpenFlues.Value = Decimal.Add(Decimal.Add(this.txtNoofOpenFluesMain.Value, this.txtNoofOpenFluesSec.Value), this.txtNoofOpenFluesOther.Value);
    }

    private void cmdWWHRSSystem1Selection_Click(object sender, EventArgs e)
    {
      WWHRSForm wwhrsForm = new WWHRSForm();
      if (wwhrsForm.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef = wwhrsForm.SystemRef;
      SAP_Read.ReadSolar();
      this.AddCalcHandle();
    }

    private void optWWHRS_CheckedChanged(object sender, EventArgs e)
    {
      if (this.optWWHRS.Checked)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems == null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef = "";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].SystemsRef = "";
        }
        this.txtWWHRSTotalRooms.Enabled = true;
        this.grpWWHRS1.Enabled = true;
        this.grpWWHRS2.Enabled = true;
      }
      else
      {
        this.txtWWHRSTotalRooms.Enabled = false;
        this.grpWWHRS1.Enabled = false;
        this.grpWWHRS2.Enabled = false;
      }
    }

    private void cmdWWHRSSystem2Selection_Click(object sender, EventArgs e)
    {
      WWHRSForm wwhrsForm = new WWHRSForm();
      if (wwhrsForm.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].SystemsRef = wwhrsForm.SystemRef;
      SAP_Read.ReadSolar();
      this.AddCalcHandle();
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      FGHRS_Form fghrsForm = new FGHRS_Form();
      if (fghrsForm.ShowDialog() != DialogResult.OK)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo = fghrsForm.FGHRSSystemRef;
      SAP_Read.ReadFGHRS();
      this.AddCalcHandle();
    }

    private void ChkFGHRS_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkFGHRS.Checked)
      {
        this.grpFGHRSSelection.Enabled = true;
        this.grpFGHRSTestDetails.Enabled = true;
        this.cmdFGHRS.Enabled = true;
      }
      else
      {
        this.grpFGHRSSelection.Enabled = false;
        this.grpFGHRSTestDetails.Enabled = false;
        this.cmdFGHRS.Enabled = false;
      }
    }

    private void ChkCoolingSystem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkCoolingSystem.Checked)
      {
        this.txtEnergyLabelClass.Enabled = true;
        this.CompressControl.Enabled = true;
        this.txtCooledArea.Enabled = true;
        this.txtCoolingSystemType.Enabled = true;
        this.ChkEER.Enabled = true;
      }
      else
      {
        this.txtEnergyLabelClass.Enabled = false;
        this.CompressControl.Enabled = false;
        this.txtCooledArea.Enabled = false;
        this.txtCoolingSystemType.Enabled = false;
        this.ChkEER.Enabled = false;
      }
    }

    private void BtnSp_Feature_add_Click(object sender, EventArgs e)
    {
      this.txtSpDescription.Text = "";
      this.txtSpESaved.Text = "";
      this.txtSpFSaved.Text = "";
      this.txtSpEUsed.Text = "";
      this.txtSpFUsed.Text = "";
      this.CurrSPecFeature = -1;
    }

    private void BtnSp_Feature_OK_Click(object sender, EventArgs e)
    {
      try
      {
        bool flag;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSpDescription.Text, "", false) == 0)
          flag = true;
        if (this.chkEmissionsOnly.Checked)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtEmissionsOnly.Text, "", false) == 0)
            flag = true;
        }
        else
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSpESaved.Text, "", false) == 0)
            flag = true;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSpFSaved.Text, "", false) == 0)
            flag = true;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSpFUsed.Text, "", false) == 0)
            flag = true;
        }
        if (this.ChkMonInc.Checked)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special == null)
          {
            flag = true;
          }
          else
          {
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M1 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M2 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M3 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M4 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M5 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M6 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M7 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M8 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M9 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M10 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M11 == 0.0)
              flag = true;
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M12 == 0.0)
              flag = true;
          }
        }
        if (flag)
        {
          int num = (int) Interaction.MsgBox((object) "Incomplete, please complete all sections", MsgBoxStyle.Information, (object) "Special Feature Section");
        }
        else
        {
          if (this.CurrSPecFeature == -1)
          {
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special == null)
            {
              // ISSUE: variable of a reference type
              SAP_Module.SpecialFeatures[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[1]);
              local = specialFeaturesArray;
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.SpecialFeatures[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length + 1)]);
              local = specialFeaturesArray;
            }
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)] = new SAP_Module.SpecialFeatures();
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].EnergySaved = (float) Conversion.Val(this.txtSpESaved.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].FuelSaved = this.txtSpFSaved.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].EnergyUsed = (float) Conversion.Val(this.txtSpEUsed.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].FuelUsed = this.txtSpFUsed.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].Description = this.txtSpDescription.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].IncludeMonthly = this.ChkMonInc.Checked;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].MakeEmissionsOnly = this.chkEmissionsOnly.Checked;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].EmissionsAmount = (float) Conversion.Val(this.txtEmissionsOnly.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].EmissionsAmountCreated = (float) Conversion.Val(this.txtEmissionsOnlyCreated.Text);
          }
          else
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].Description = this.txtSpDescription.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EnergySaved = Conversions.ToSingle(this.txtSpESaved.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EnergyUsed = Conversions.ToSingle(this.txtSpEUsed.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].FuelSaved = this.txtSpFSaved.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].FuelUsed = this.txtSpFUsed.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].IncludeMonthly = this.ChkMonInc.Checked;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].MakeEmissionsOnly = this.chkEmissionsOnly.Checked;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EmissionsAmount = (float) Conversion.Val(this.txtEmissionsOnly.Text);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].EmissionsAmountCreated = (float) Conversion.Val(this.txtEmissionsOnlyCreated.Text);
          }
          this.txtSpDescription.Text = "";
          this.txtSpESaved.Text = "";
          this.txtSpEUsed.Text = "";
          this.txtSpFSaved.Text = "";
          this.txtSpFUsed.Text = "";
          this.ChkMonInc.Checked = false;
          SAP_Write.SaveDetails();
          Functions.CalculateNow();
          SAP_Read.ReadRenewables();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Btn_SPFeature_Del_Click(object sender, EventArgs e)
    {
      if (this.CurrSPecFeature == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select an item to delete", MsgBoxStyle.Information, (object) "Special Feature Section");
      }
      else
      {
        try
        {
          int currDwelling = SAP_Module.CurrDwelling;
          int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 2);
          int index = currDwelling;
          while (index <= num2)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[index] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (index + 1)];
            checked { ++index; }
          }
          // ISSUE: variable of a reference type
          SAP_Module.SpecialFeatures[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 2 + 1)]);
          local = specialFeaturesArray;
          SAP_Write.SaveDetails();
          Functions.CalculateNow();
          SAP_Read.ReadRenewables();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void ExportDwellingToolStripMenuItem_Click(object sender, EventArgs e) => Functions.export();

    private void ImportDwellingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SAP_Write.SaveDetails();
      Functions.Import();
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void ChkEER_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkEER.Checked)
      {
        this.txtEnergyLabelClass.Enabled = false;
        this.txtEER.Enabled = true;
        this.txterrDesc.Enabled = true;
      }
      else
      {
        this.txtEnergyLabelClass.Enabled = true;
        this.txtEER.Enabled = false;
        this.txtEER.Text = "";
        this.txtEnergyLabelClass.Text = "";
        this.txterrDesc.Enabled = false;
        this.txterrDesc.Text = "";
      }
    }

    private void PartyFloors_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteFloors();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Walls_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteWalls();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Ceilings_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteWalls();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void txtCommHNoOfAdditional_ValueChanged(object sender, EventArgs e)
    {
      Decimal d1 = this.txtCommHNoOfAdditional.Value;
      if (Decimal.Compare(d1, 0M) == 0)
      {
        this.grpCommHAdd1.Visible = false;
        this.grpCommHAdd2.Visible = false;
        this.grpCommHAdd3.Visible = false;
        this.grpCommHAdd4.Visible = false;
        this.grpCommH.Height = 175;
      }
      else if (Decimal.Compare(d1, 1M) == 0)
      {
        this.grpCommHAdd1.Visible = true;
        this.grpCommHAdd2.Visible = false;
        this.grpCommHAdd3.Visible = false;
        this.grpCommHAdd4.Visible = false;
        this.grpCommH.Height = 280;
      }
      else if (Decimal.Compare(d1, 2M) == 0)
      {
        this.grpCommHAdd1.Visible = true;
        this.grpCommHAdd2.Visible = true;
        this.grpCommHAdd3.Visible = false;
        this.grpCommHAdd4.Visible = false;
        this.grpCommH.Height = 385;
      }
      else if (Decimal.Compare(d1, 3M) == 0)
      {
        this.grpCommHAdd1.Visible = true;
        this.grpCommHAdd2.Visible = true;
        this.grpCommHAdd3.Visible = true;
        this.grpCommHAdd4.Visible = false;
        this.grpCommH.Height = 490;
      }
      else
      {
        if (Decimal.Compare(d1, 4M) != 0)
          return;
        this.grpCommHAdd1.Visible = true;
        this.grpCommHAdd2.Visible = true;
        this.grpCommHAdd3.Visible = true;
        this.grpCommHAdd4.Visible = true;
        this.grpCommH.Height = 595;
      }
    }

    private void txtDHWCommHNoOfAdditional_ValueChanged(object sender, EventArgs e)
    {
      Decimal d1 = this.txtDHWCommHNoOfAdditional.Value;
      if (Decimal.Compare(d1, 0M) == 0)
      {
        this.grpDHWCommHAdd1.Visible = false;
        this.grpDHWCommHAdd2.Visible = false;
        this.grpDHWCommHAdd3.Visible = false;
        this.grpDHWCommHAdd4.Visible = false;
        this.grpDHWComm.Height = 175;
      }
      else if (Decimal.Compare(d1, 1M) == 0)
      {
        this.grpDHWCommHAdd1.Visible = true;
        this.grpDHWCommHAdd2.Visible = false;
        this.grpDHWCommHAdd3.Visible = false;
        this.grpDHWCommHAdd4.Visible = false;
        this.grpDHWComm.Height = 280;
      }
      else if (Decimal.Compare(d1, 2M) == 0)
      {
        this.grpDHWCommHAdd1.Visible = true;
        this.grpDHWCommHAdd2.Visible = true;
        this.grpDHWCommHAdd3.Visible = false;
        this.grpDHWCommHAdd4.Visible = false;
        this.grpDHWComm.Height = 385;
      }
      else if (Decimal.Compare(d1, 3M) == 0)
      {
        this.grpDHWCommHAdd1.Visible = true;
        this.grpDHWCommHAdd2.Visible = true;
        this.grpDHWCommHAdd3.Visible = true;
        this.grpDHWCommHAdd4.Visible = false;
        this.grpDHWComm.Height = 490;
      }
      else
      {
        if (Decimal.Compare(d1, 4M) != 0)
          return;
        this.grpDHWCommHAdd1.Visible = true;
        this.grpDHWCommHAdd2.Visible = true;
        this.grpDHWCommHAdd3.Visible = true;
        this.grpDHWCommHAdd4.Visible = true;
        this.grpDHWComm.Height = 595;
      }
    }

    private void CboDHWVessel_SelectedIndexChanged(object sender, EventArgs e)
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.DHWVessel = Conversions.ToBoolean(this.CboDHWVessel.Text);
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.DHWVessel)
        this.grpCylinder.Enabled = false;
      else
        this.grpCylinder.Enabled = true;
    }

    private void CboDHWVessel_CheckedChanged(object sender, EventArgs e)
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.DHWVessel = this.CboDHWVessel.Checked;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.DHWVessel)
        this.grpCylinder.Enabled = false;
      else
        this.grpCylinder.Enabled = true;
    }

    private void ChkMonInc_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkMonInc.Checked)
        this.cmdSpecialQDetails.Enabled = true;
      else
        this.cmdSpecialQDetails.Enabled = false;
    }

    private void cmdSpecialQDetails_Click(object sender, EventArgs e)
    {
      Monthly_Form monthlyForm = new Monthly_Form();
      try
      {
        if (this.CurrSPecFeature != -1)
        {
          monthlyForm.TxtM1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M1);
          monthlyForm.TxtM2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M2);
          monthlyForm.TxtM3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M3);
          monthlyForm.TxtM4.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M4);
          monthlyForm.TxtM5.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M5);
          monthlyForm.TxtM6.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M6);
          monthlyForm.TxtM7.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M7);
          monthlyForm.TxtM8.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M8);
          monthlyForm.TxtM9.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M9);
          monthlyForm.TxtM10.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M10);
          monthlyForm.TxtM11.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M11);
          monthlyForm.TxtM12.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M12);
        }
        if (monthlyForm.ShowDialog() != DialogResult.OK)
          return;
        if (this.CurrSPecFeature == -1)
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special == null)
          {
            // ISSUE: variable of a reference type
            SAP_Module.SpecialFeatures[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[1]);
            local = specialFeaturesArray;
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.SpecialFeatures[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length + 1)]);
            local = specialFeaturesArray;
          }
          this.CurrSPecFeature = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1);
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M1 = Conversions.ToSingle(monthlyForm.TxtM1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M2 = Conversions.ToSingle(monthlyForm.TxtM2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M3 = Conversions.ToSingle(monthlyForm.TxtM3.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M4 = Conversions.ToSingle(monthlyForm.TxtM4.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M5 = Conversions.ToSingle(monthlyForm.TxtM5.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M6 = Conversions.ToSingle(monthlyForm.TxtM6.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M7 = Conversions.ToSingle(monthlyForm.TxtM7.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M8 = Conversions.ToSingle(monthlyForm.TxtM8.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M9 = Conversions.ToSingle(monthlyForm.TxtM9.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M10 = Conversions.ToSingle(monthlyForm.TxtM10.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M11 = Conversions.ToSingle(monthlyForm.TxtM11.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].M12 = Conversions.ToSingle(monthlyForm.TxtM12.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtSECPrimary_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating2.PrimaryHeatingGroupCheck2();
      this.GrpSecBoiler.Visible = false;
    }

    private void txtSecMainFuel_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
        Heating2.GetMainSecEfficiency(this.txtSECPrimary.Text, this.txtSecSubGroup.Text, this.txtSecBoilerSub.Text, this.txtSecMainHeatingType.Text);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "heating oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "biodiesel from any biomass source", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "biodiesel from used cooking oil only", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "rapeseed oil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "appliances able to use mineral oil or liquid biofuel", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "B30K", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "bioethanol from any biomass source", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSECPrimary.Text, "Central heating systems with radiators or underfloor heating", false) == 0)
        {
          this.chkSecOilPump.Visible = true;
        }
        else
        {
          this.chkSecOilPump.Checked = false;
          this.chkSecOilPump.Visible = false;
        }
      }
      else
      {
        this.chkSecOilPump.Checked = false;
        this.chkSecOilPump.Visible = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "mains gas", false) == 0 | this.txtSecMainFuel.Text.Contains("LPG"))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecHeatingSource.Text, "Manufacturer Declaration", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
        {
          this.txtSecBFuelBurningType.Enabled = true;
        }
        else
        {
          this.txtSecBFuelBurningType.Enabled = false;
          this.txtSecBFuelBurningType.Text = "";
        }
      }
      else
      {
        this.txtSecBFuelBurningType.Enabled = false;
        this.txtSecBFuelBurningType.Text = "";
      }
      if (!this.DoCheckFuel)
        return;
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "", false) > 0U)
          WaterHeating.PaniCheck(2, this.txtSecMainFuel.Text, SAP_Module.CurrDwelling);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtSecSubGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating2.PrimaryHeatingSubGroupCheck2();
      this.GrpSecBoiler.Visible = false;
    }

    private void txtSecBoilerSub_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating2.CheckBoilerSubSec();
    }

    private void txtSecHeatingSource_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow)
      {
        Heating2.CheckSource2();
        this.GrpSecBoiler.Visible = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecHeatingSource.Text, "SAP Tables", false) == 0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecHeatingSource.Text, "", false) != 0)
        return;
      this.txtSecBFlueType.Enabled = true;
    }

    private void txtSecMainHeatingType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainHeatingType.Text, "", false) > 0U)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = (string) null;
        Heating2.CheckFuelTypeForSAPTable2(this.txtSecMainHeatingType.Text, this.txtSecSubGroup.Text, this.txtSecBoilerSub.Text);
        Heating2.GetMainSecEfficiency(this.txtSECPrimary.Text, this.txtSecSubGroup.Text, this.txtSecBoilerSub.Text, this.txtSecMainHeatingType.Text);
        this.CheckElectCPSU2();
      }
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecMainFuel.Text, "", false) != 0)
          return;
        this.txtSecMainFuel.Enabled = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtHeatingEmitter_MouseClick(object sender, MouseEventArgs e)
    {
      this.txtHeatingEmitter.Items.Clear();
      this.txtHeatingEmitter.Items.Add((object) "Systems with radiators");
      this.txtHeatingEmitter.Items.Add((object) "Underfloor heating, pipes in insulated timber floor");
      this.txtHeatingEmitter.Items.Add((object) "Underfloor heating, pipes in screed above insulation");
      this.txtHeatingEmitter.Items.Add((object) "Underfloor heating, pipes in concrete slab");
      this.txtHeatingEmitter.Items.Add((object) "Underfloor heating and radiators, pipes in insulated timber floor");
      this.txtHeatingEmitter.Items.Add((object) "Underfloor heating and radiators, pipes in screed above insulation");
      this.txtHeatingEmitter.Items.Add((object) "Underfloor heating and radiators, pipes in concrete slab");
      this.txtHeatingEmitter.Items.Add((object) "Fan coil units");
    }

    private void txtHeatingEmitter_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtSecHeatingControls_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!SAP_Module.ChangeNow & (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecHeatingControls.Text, "", false) > 0U)
      {
        SAPForm sapForm = this;
        int num = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.TableGroup;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
          num = 1;
        PCDF.Table4e table4e = SAP_Module.PCDFData.Table4es.Where<PCDF.Table4e>((Func<PCDF.Table4e, bool>) (b => b.Group.Equals(num.ToString()) & b.Description.ToUpper().Equals(sapForm.txtSecHeatingControls.Text.ToUpper()))).SingleOrDefault<PCDF.Table4e>();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode = Conversions.ToInteger(table4e.Code);
      }
      try
      {
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode)
        {
          case 2103:
          case 2104:
          case 2105:
          case 2106:
            this.chkSecDelayedStart.Visible = true;
            break;
          default:
            this.chkSecDelayedStart.Visible = false;
            this.chkSecDelayedStart.Checked = false;
            break;
        }
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCode)
        {
          case 2112:
          case 2208:
            this.cmdSecControlSelect.Visible = true;
            break;
          default:
            this.cmdSecControlSelect.Visible = false;
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void txtSecElectricityTariff_SelectedIndexChanged(object sender, EventArgs e) => this.CheckElectCPSU();

    private void txtSecHETASMain_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      Heating2.GetMainSecEfficiency(this.txtSECPrimary.Text, this.txtSecSubGroup.Text, this.txtSecBoilerSub.Text, this.txtSecMainHeatingType.Text);
    }

    private void txtKeepHotFuel_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void chkKeepHotTimed_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void chkSecKeepHot_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSecKeepHot.Checked)
      {
        this.txtSecKeepHotFuel.Enabled = true;
        this.chkSecKeepHotTimed.Enabled = true;
      }
      else
      {
        this.txtSecKeepHotFuel.Enabled = false;
        this.txtSecKeepHotFuel.Text = "";
        this.chkSecKeepHotTimed.Enabled = false;
        this.chkSecKeepHotTimed.Checked = false;
      }
    }

    private void chkSecMainHLoadWeather_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSecMainHLoadWeather.Checked)
      {
        this.txtSecLoadWeather.Enabled = true;
      }
      else
      {
        this.txtSecLoadWeather.Enabled = false;
        this.txtSecLoadWeather.Text = "";
      }
    }

    private void txtCompensator_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmdBiolerData2_Click(object sender, EventArgs e)
    {
      PDFFunctions.MainHeating2Search = true;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecSubGroup.Text, "Micro-cogeneration (micro-CHP)", false) == 0)
      {
        int num1 = (int) MyProject.Forms.CHP_Search.ShowDialog();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSecSubGroup.Text, "Solid fuel boilers", false) == 0)
      {
        int num2 = (int) MyProject.Forms.Solid_Search.ShowDialog();
      }
      else if (this.txtSecSubGroup.Text.Contains("heat pumps"))
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump = true;
        int num3 = (int) MyProject.Forms.HeatPump_SearchFrm.ShowDialog();
      }
      else if (this.txtSecSubGroup.Text.Equals("Warm air systems (Not heat pump)"))
      {
        WarmAirSearch warmAirSearch = new WarmAirSearch();
        if (warmAirSearch.ShowDialog() == DialogResult.OK)
        {
          PCDF.WarmAir dataBoundItem = (PCDF.WarmAir) warmAirSearch.dtgWarmAir.SelectedRows[0].DataBoundItem;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = dataBoundItem.ID;
          SAP_Read.CheckSEDBUK2();
        }
      }
      else
      {
        MyProject.Forms.Boiler_Database.Type = 2;
        int num4 = (int) MyProject.Forms.Boiler_Database.ShowDialog();
      }
      if (!this.DontSave & SAP_Module.CurrDwelling != -1)
        SAP_Write.SaveDetails();
      if (SAP_Module.CurrDwelling == -1)
        return;
      Functions.CalculateNow();
    }

    private void txtSecCommHNoOfAdditional_ValueChanged(object sender, EventArgs e)
    {
      Decimal d1 = this.txtCommHNoOfAdditional.Value;
      if (Decimal.Compare(d1, 0M) == 0)
      {
        this.grpSecCommHAdd1.Visible = false;
        this.grpSecCommHAdd2.Visible = false;
        this.grpCommHAdd3.Visible = false;
        this.grpCommHAdd4.Visible = false;
      }
      else if (Decimal.Compare(d1, 1M) == 0)
      {
        this.grpSecCommHAdd1.Visible = true;
        this.grpSecCommHAdd2.Visible = false;
        this.grpSecCommHAdd3.Visible = false;
        this.grpSecCommHAdd4.Visible = false;
      }
      else if (Decimal.Compare(d1, 2M) == 0)
      {
        this.grpSecCommHAdd1.Visible = true;
        this.grpSecCommHAdd2.Visible = true;
        this.grpSecCommHAdd3.Visible = false;
        this.grpSecCommHAdd4.Visible = false;
      }
      else if (Decimal.Compare(d1, 3M) == 0)
      {
        this.grpSecCommHAdd1.Visible = true;
        this.grpSecCommHAdd2.Visible = true;
        this.grpSecCommHAdd3.Visible = true;
        this.grpSecCommHAdd4.Visible = false;
      }
      else
      {
        if (Decimal.Compare(d1, 4M) != 0)
          return;
        this.grpSecCommHAdd1.Visible = true;
        this.grpSecCommHAdd2.Visible = true;
        this.grpSecCommHAdd3.Visible = true;
        this.grpSecCommHAdd4.Visible = true;
      }
    }

    private void ChkIncSecMain_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkIncSecMain.Checked)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 = true;
        this.GrpSecmainHeatingFrac.Enabled = true;
        this.txtSECPrimary.Enabled = true;
        this.grpSecCHP.Enabled = true;
        this.GrpSecmainHeatingFrac.Enabled = true;
        this.grpSecEfficiency.Enabled = true;
        this.grpSecHETASMain.Enabled = true;
        this.GroupBox23Sec.Enabled = true;
        this.GroupBox24Sec.Enabled = true;
        this.GroupBox86.Enabled = true;
        this.txtSecMainFuel.Enabled = true;
      }
      else
      {
        this.txtSecCommHAdd1Type.Text = "";
        this.txtSecCommHAdd2Type.Text = "";
        this.txtSecCommHAdd3Type.Text = "";
        this.txtSecCommHAdd4Type.Text = "";
        this.txtSecCommHAdd1Fuel.Text = "";
        this.txtSecCommHAdd2Fuel.Text = "";
        this.txtSecCommHAdd3Fuel.Text = "";
        this.txtSecCommHAdd4Fuel.Text = "";
        this.txtSecCommHAdd1Fraction.Text = "";
        this.txtSecCommHAdd2Fraction.Text = "";
        this.txtSecCommHAdd3Fraction.Text = "";
        this.txtSecCommHAdd4Fraction.Text = "";
        this.txtSecCommHAdd1Efficiency.Text = "";
        this.txtSecCommHAdd2Efficiency.Text = "";
        this.txtSecCommHAdd3Efficiency.Text = "";
        this.txtSecCommHAdd4Efficiency.Text = "";
        this.txtSecLoadWeather.Text = "";
        this.txtSecPumpHP.Text = "";
        this.txtSecPumpType.Text = "";
        this.txtSecBILock.Text = "";
        this.cboSecBoilerFlowTemp.Text = "";
        this.txtSecDescription.Text = "";
        this.txtSecBFuelBurningType.Text = "";
        this.txtSecBFlueType.Text = "";
        this.txtSecFanFlued.Text = "";
        this.txtSecKeepHotFuel.Text = "";
        this.txtsecMainEffWinter.Text = "";
        this.txtsecMainEffSummer.Text = "";
        this.txtSecEfficiency.Text = "";
        this.TxtHeatFraction.Text = "";
        this.chkSecMainHLoadWeather.Checked = false;
        this.chkSecKeepHot.Checked = false;
        this.chkSecKeepHotTimed.Checked = false;
        this.chkSecSEDBUK2005.Checked = false;
        this.ChkWholep.Checked = false;
        this.ChkSeparateP.Checked = false;
        this.chkSecOilPump.Checked = false;
        this.chkSecOilPump.Checked = false;
        this.chkSecMCS.Checked = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 = false;
        this.GrpSecmainHeatingFrac.Enabled = false;
        this.txtSECPrimary.Text = "";
        this.txtSecSubGroup.Text = "";
        this.txtSecHeatingSource.Text = "";
        this.txtSecBoilerSub.Text = "";
        this.txtSecMainHeatingType.Text = "";
        this.txtSecHeatingEmitter.Text = "";
        this.txtSecHeatingControls.Text = "";
        this.txtSecMainFuel.Text = "";
        this.txtSecHETASMain.Text = "";
        this.TxtHeatFraction.Text = "";
        this.ChkSeparateP.Checked = false;
        this.ChkWholep.Checked = false;
        this.GroupBox86.Enabled = false;
        this.txtSecHeatingSource.Enabled = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump = false;
        try
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK = Conversions.ToString(0);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterOnlyHP = false;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.DeclaredValue = 0.0f;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.Vol = 0;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.SummaerEff = 0.0;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.WinterEff = 0.0;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.ManuSpecified = false;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterHP_Integral = false;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef == 914)
          {
            try
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = 0.0f;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = 0.0f;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = false;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.txtSECPrimary.Enabled = false;
        this.grpSecCHP.Enabled = false;
        this.GrpSecmainHeatingFrac.Enabled = false;
        this.grpSecEfficiency.Enabled = false;
        this.grpSecHETASMain.Enabled = false;
        this.GroupBox23Sec.Enabled = false;
        this.GroupBox24Sec.Enabled = false;
        this.GroupBox86.Enabled = false;
        this.txtSecMainFuel.Enabled = false;
      }
    }

    private void FileS1_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem) sender;
      try
      {
        if (SAP_Module.Proj.NoOfDwells > 0)
        {
          switch (Interaction.MsgBox((object) "Do you want to save the current project?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question, (object) "Open File?"))
          {
            case MsgBoxResult.Cancel:
              return;
            case MsgBoxResult.Yes:
              this.SaveProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
              break;
          }
        }
        string text = toolStripMenuItem.Text;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(text);
        SAP_Module.CurrDwelling = -1;
        int num = checked (SAP_Module.Proj.Dwellings.Length - 1);
        int house = 0;
        while (house <= num)
        {
          try
          {
            Validation.Checkerrors_All(house);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++house; }
        }
        Functions.MakeTree();
        this.DontSave = true;
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        SAP_Module.Proj.SaveFileName = text;
        Functions.AddFile(text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error Occured", MsgBoxStyle.Information, (object) "Open File Information");
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.DontSave = false;
      }
    }

    private void BlockComplianceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.NoOfDwells < 1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "View Reports");
      }
      else
      {
        Block_Compliance blockCompliance = new Block_Compliance();
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        int num2 = (int) blockCompliance.ShowDialog();
      }
    }

    private void ChkWholep_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.ChkWholep.Checked)
        return;
      this.ChkSeparateP.Checked = false;
    }

    private void ChkSeparateP_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.ChkSeparateP.Checked)
        return;
      this.ChkWholep.Checked = false;
    }

    private void CopyDwellingElementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select dwelling first!", MsgBoxStyle.Information);
      }
      else
      {
        Copy_Element copyElement = new Copy_Element();
        SAP_Write.SaveDetails();
        int num2 = (int) copyElement.ShowDialog();
      }
    }

    private void Floors_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void Floors_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      try
      {
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalFloor_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      try
      {
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PartyFloors_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      try
      {
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Floors_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdFloorArea.Top = checked (this.Floors.Top + this.Floors.ColumnHeadersHeight + this.Floors.CurrentCell.RowIndex * 22 - this.Floors.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Roofs_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdRoofArea.Top = checked (this.Roofs.Top + this.Roofs.ColumnHeadersHeight + this.Roofs.CurrentCell.RowIndex * 22 - this.Roofs.VerticalScrollingOffset);
        this.cmdRoofShelter.Top = checked (this.Roofs.Top + this.Roofs.ColumnHeadersHeight + this.Roofs.CurrentCell.RowIndex * 22 - this.Roofs.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PartyFloors_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdPFloorArea.Top = checked (this.PartyFloors.Top + this.PartyFloors.ColumnHeadersHeight + this.PartyFloors.CurrentCell.RowIndex * 22 - this.PartyFloors.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PartyWalls_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdPWallArea.Top = checked (this.PartyWalls.Top + this.PartyWalls.ColumnHeadersHeight + this.PartyWalls.CurrentCell.RowIndex * 22 - this.PartyWalls.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PartyCeilings_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdPCeilingArea.Top = checked (this.PartyCeilings.Top + this.PartyCeilings.ColumnHeadersHeight + this.PartyCeilings.CurrentCell.RowIndex * 22 - this.PartyCeilings.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalFloor_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdIFloorArea.Top = checked (this.InternalFloor.Top + this.InternalFloor.ColumnHeadersHeight + this.InternalFloor.CurrentCell.RowIndex * 22 - this.InternalFloor.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalWall_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdIWallArea.Top = checked (this.InternalWall.Top + this.InternalWall.ColumnHeadersHeight + this.InternalWall.CurrentCell.RowIndex * 22 - this.InternalWall.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void InternalCeiling_Scroll(object sender, ScrollEventArgs e)
    {
      try
      {
        this.cmdICeilingArea.Top = checked (this.InternalCeiling.Top + this.InternalCeiling.ColumnHeadersHeight + this.InternalCeiling.CurrentCell.RowIndex * 22 - this.InternalCeiling.VerticalScrollingOffset);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void lblDataProduct_Click(object sender, EventArgs e)
    {
    }

    private void cmdWWHRS2Remove_Click(object sender, EventArgs e)
    {
      try
      {
        this.txtWWHRS2WithBath.Value = 0M;
        this.txtWWHRS2WithNoBath.Value = 0M;
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems != null)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].SystemsRef = "";
        SAP_Read.ReadSolar();
        this.AddCalcHandle();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdSaveClient_Click(object sender, EventArgs e)
    {
      try
      {
        if (SAP_Module.ClientDetails.Tables.Count == 0)
        {
          SAP_Module.ClientDetails.Namespace = " Stroma FSAP";
          SAP_Module.ClientDetails.Tables.Add("Clients");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("Name");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("Address1");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("Address2");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("Address3");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("City");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("Country");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("PostCode");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("PhoneNumber");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("FaxNumber");
          SAP_Module.ClientDetails.Tables["Clients"].Columns.Add("Email");
        }
        int num = checked (SAP_Module.ClientDetails.Tables["Clients"].Rows.Count - 1);
        int index = 0;
        bool flag;
        while (index <= num)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(SAP_Module.ClientDetails.Tables["Clients"].Rows[index]["Name"], (object) this.txtPCNAme.Text, false))
            flag = true;
          checked { ++index; }
        }
        if (flag && Interaction.MsgBox((object) "This Client is already found in records, do you want to continue adding into records?", MsgBoxStyle.YesNo | MsgBoxStyle.Question) == MsgBoxResult.No)
          return;
        DataRow row = SAP_Module.ClientDetails.Tables["Clients"].NewRow();
        DataRow dataRow = row;
        dataRow["Name"] = (object) this.txtPCNAme.Text;
        dataRow["Address1"] = (object) this.txtPCAdd1.Text;
        dataRow["Address2"] = (object) this.txtPCAdd2.Text;
        dataRow["Address3"] = (object) this.txtPCAdd3.Text;
        dataRow["City"] = (object) this.txtPCCity.Text;
        dataRow["Country"] = (object) this.txtPCCountry.Text;
        dataRow["PostCode"] = (object) this.txtPCPCode.Text;
        dataRow["PhoneNumber"] = (object) this.txtPCPhone.Text;
        dataRow["FaxNumber"] = (object) this.txtPCFax.Text;
        dataRow["Email"] = (object) this.txtPCEmail.Text;
        SAP_Module.ClientDetails.Tables["Clients"].Rows.Add(row);
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        if (System.IO.File.Exists(path + "Clients.xml"))
          System.IO.File.Delete(path + "Clients.xml");
        SAP_Module.ClientDetails.WriteXml(path + "Clients.xml");
        this.ReadClients();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdUseClient_Click(object sender, EventArgs e)
    {
      try
      {
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboClientDetails.Text, "", false) <= 0U)
          return;
        DataRowView selectedItem = (DataRowView) this.cboClientDetails.SelectedItem;
        this.txtPCNAme.Text = Conversions.ToString(selectedItem["Name"]);
        this.txtPCAdd1.Text = Conversions.ToString(selectedItem["Address1"]);
        this.txtPCAdd2.Text = Conversions.ToString(selectedItem["Address2"]);
        this.txtPCAdd3.Text = Conversions.ToString(selectedItem["Address3"]);
        this.txtPCCity.Text = Conversions.ToString(selectedItem["City"]);
        this.txtPCCountry.Text = Conversions.ToString(selectedItem["Country"]);
        this.txtPCPCode.Text = Conversions.ToString(selectedItem["PostCode"]);
        this.txtPCPhone.Text = Conversions.ToString(selectedItem["PhoneNumber"]);
        this.txtPCFax.Text = Conversions.ToString(selectedItem["FaxNumber"]);
        this.txtPCEmail.Text = Conversions.ToString(selectedItem["Email"]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ReadClients()
    {
      try
      {
        SAP_Module.ClientDetails = new DataSet();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        if (!System.IO.File.Exists(path + "Clients.xml"))
          return;
        int num = (int) SAP_Module.ClientDetails.ReadXml(path + "Clients.xml");
        this.cboClientDetails.DataSource = (object) new DataView()
        {
          Table = SAP_Module.ClientDetails.Tables["Clients"],
          Sort = "Name"
        };
        this.cboClientDetails.DisplayMember = "Name";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void SelectALogoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (new Logo().ShowDialog() != DialogResult.OK)
        ;
    }

    private void cmdCompliance_Click(object sender, EventArgs e)
    {
      Functions.CalculateNow();
      MyProject.Forms.GenResults.Show();
      MyProject.Forms.GenResults.Left = checked (Control.MousePosition.X - 10);
      MyProject.Forms.GenResults.Top = checked (Control.MousePosition.Y - 10);
    }

    private void PartyFloors_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "PartyFloor";

    private void PartyWalls_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "PartyWalls";

    private void PartyCeilings_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "PartyCeilings";

    private void InternalFloor_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "InternalFloor";

    private void InternalWall_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "InternalWall";

    private void InternalCeiling_MouseMove(object sender, MouseEventArgs e) => this.CurrElementControl = "InternalCeiling";

    private void Walls_RowsRemoved1(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteWalls();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Floors_RowsRemoved1(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteFloors();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void Ceilings_RowsRemoved1(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (SAP_Module.ChangeNow)
        return;
      SAP_Write.WriteRoofs();
      if (this.Visible)
        this.AddCalcHandle();
    }

    private void txtLELOutlets_ValueChanged(object sender, EventArgs e)
    {
      if (SAP_Module.NoCalc || (uint) Decimal.Compare(this.txtLELOutlets.Value, 0M) <= 0U)
        return;
      this.txtLowEnergyLight.Text = Decimal.Compare(Decimal.Divide(Decimal.Multiply(100M, this.txtLELLights.Value), this.txtLELOutlets.Value), 100M) <= 0 ? Conversions.ToString(Math.Round(Decimal.Divide(Decimal.Multiply(100M, this.txtLELLights.Value), this.txtLELOutlets.Value), 1)) : Conversions.ToString(100);
      this.AddCalcHandle();
    }

    private void chkAverageValue_MouseLeave(object sender, EventArgs e)
    {
      this.lblHelp.Visible = false;
      this.pnlHelp.Visible = false;
    }

    private void chkAverageValue_MouseMove(object sender, MouseEventArgs e)
    {
      this.lblHelp.Text = "Select if the dwelling was not tested\r\n and where the value entered is the averaged\r\n air permeability over dwellings of the same type.";
      this.lblHelp.Visible = true;
      this.pnlHelp.Left = checked (this.GroupBox20.Left + this.chkAverageValue.Left + e.X + 2);
      this.pnlHelp.Top = checked (this.GroupBox20.Top + this.chkAverageValue.Top + e.Y + 2);
      this.pnlHelp.Visible = true;
    }

    private void ImportFSAP2005DwellingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Name, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please create a Project first!", MsgBoxStyle.Information, (object) "Key Results");
      }
      else
      {
        int num2 = (int) new Import2005().ShowDialog();
      }
    }

    private void Button10_Click_1(object sender, EventArgs e)
    {
      try
      {
        Process.Start(Application.StartupPath + "\\Resources\\Appendix K.pdf");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (SAP_Module.CurrDwelling <= -1 || Interaction.MsgBox((object) ("Delete " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Delete Dwelling?") != MsgBoxResult.Yes)
          return;
        SAP_Module.DontChange = true;
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        int currDwelling = SAP_Module.CurrDwelling;
        int num1 = checked (SAP_Module.Proj.NoOfDwells - 2);
        int index = currDwelling;
        while (index <= num1)
        {
          SAP_Module.Proj.Dwellings[index] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[checked (index + 1)]);
          checked { ++index; }
        }
        // ISSUE: variable of a reference type
        int& local1;
        // ISSUE: explicit reference operation
        int num2 = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) - 1);
        local1 = num2;
        // ISSUE: variable of a reference type
        SAP_Module.Dwelling[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
        local2 = dwellingArray;
        Functions.MakeTree();
        this.TreeSAP.CollapseAll();
        this.TreeSAP.Nodes[0].Expand();
        SAP_Module.CurrDwelling = -1;
        SAP_Module.DontChange = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void MoveTooToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      int num = (int) new MoveToo().ShowDialog();
    }

    private void ToolStripButton7_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      int num = (int) new MoveToo().ShowDialog();
    }

    private void ToolStripButton8_Click(object sender, EventArgs e) => this.DeleteToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

    private void cmdGetWallArea_Click(object sender, EventArgs e)
    {
    }

    private void cmdGetWallArea_MouseLeave(object sender, EventArgs e) => this.lblWallArea.Visible = false;

    private void cmdGetWallArea_MouseMove(object sender, MouseEventArgs e)
    {
      this.lblWallArea.Visible = true;
      this.lblWallArea.Left = checked (this.cmdGetWallArea.Left - this.lblWallArea.Width - 5);
      this.lblWallArea.Top = checked ((int) Math.Round(unchecked ((double) this.cmdGetWallArea.Top + (double) this.cmdGetWallArea.Height / 2.0 - (double) this.lblWallArea.Height / 2.0)));
    }

    private void txtOrientation_MouseLeave(object sender, EventArgs e)
    {
      this.lblOrientation.Visible = false;
      this.lblOrienWarning.Visible = false;
    }

    private void txtOrientation_MouseMove(object sender, MouseEventArgs e)
    {
      this.lblOrientation.Visible = true;
      this.lblOrienWarning.Visible = true;
    }

    private void Label77_MouseLeave(object sender, EventArgs e)
    {
      this.lblOrientation.Visible = false;
      this.lblOrienWarning.Visible = false;
    }

    private void Label77_MouseMove(object sender, MouseEventArgs e)
    {
      this.lblOrientation.Visible = true;
      this.lblOrienWarning.Visible = true;
    }

    private void EditClientDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Clients().ShowDialog();
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (System.IO.File.Exists(path + "Clients.xml"))
        System.IO.File.Delete(path + "Clients.xml");
      SAP_Module.ClientDetails.WriteXml(path + "Clients.xml");
      this.ReadClients();
    }

    private void cmdEditClientData_Click(object sender, EventArgs e)
    {
      int num = (int) new Clients().ShowDialog();
      string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Stroma SAP 2012\\";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (System.IO.File.Exists(path + "Clients.xml"))
        System.IO.File.Delete(path + "Clients.xml");
      SAP_Module.ClientDetails.WriteXml(path + "Clients.xml");
      this.ReadClients();
    }

    private void SEDBUKUPdate_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        using (StreamReader streamReader = new StreamReader(WebRequest.Create("http://www.sedbuk.com/data1/pcdf2012.dat").GetResponse().GetResponseStream()))
        {
          while (streamReader.Peek() != -1)
          {
            string str = streamReader.ReadLine();
            if (str.StartsWith("$001"))
            {
              string[] strArray = str.Split(',');
              int num = checked ((int) Math.Round(Conversion.Val(strArray[1])));
              Conversions.ToString(Conversion.Val(strArray[4])) + "/" + Conversions.ToString(Conversion.Val(strArray[3])) + "/" + Conversions.ToString(Conversion.Val(strArray[2]));
              if (num == SAP_Module.DataBVersion)
                break;
              string end = new StreamReader(WebRequest.Create("http://www.sedbuk.com/data1/pcdf2012.dat").GetResponse().GetResponseStream()).ReadToEnd();
              StreamWriter streamWriter = new StreamWriter((Stream) new FileStream(Application.StartupPath + "\\Data\\pcdf2012.dat", FileMode.Create, FileAccess.Write));
              streamWriter.Write(end);
              streamWriter.Close();
              this.Update_Database = true;
              break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void SEDBUKUPdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!this.Update_Database)
        return;
      int num = (int) Interaction.MsgBox((object) ("Product Characteristics Data File has been updated to version " + Conversions.ToString(SAP_Module.DataBVersion)), MsgBoxStyle.Information, (object) "Product Characteristics Data File");
    }

    private void CodeForSustainableHomesReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      EPC_Viewer epcViewer = new EPC_Viewer();
      epcViewer.Text = "Code for Sustainable Homes Report";
      epcViewer.EPCViewer.Navigate(SAPInput.CodeReport(SAP_Module.CurrDwelling));
      int num = (int) epcViewer.ShowDialog();
    }

    private void ProjectKeyResultsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.NoOfDwells < 1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "Key Results");
      }
      else
      {
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        int num2 = (int) new Key_Results().ShowDialog();
      }
    }

    private void GenerateBatchDwellingReportsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.Proj.NoOfDwells < 1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "View Reports");
      }
      else
      {
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        Batch_Report batchReport = new Batch_Report();
        int num2 = (int) batchReport.ShowDialog();
        batchReport.Close();
      }
    }

    private void cmdShowY_Click(object sender, EventArgs e)
    {
      try
      {
        if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Imported09)
        {
          int num1 = (int) Interaction.MsgBox((object) ("Equivalent y value based on the HTB and total area of external elements = " + Conversions.ToString(this.ShowY())));
        }
        else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb)
        {
          int num2 = (int) Interaction.MsgBox((object) ("Equivalent y value based on the HTB and total area of external elements = " + Conversions.ToString(this.ShowY())));
        }
        else
        {
          int num3 = (int) Interaction.MsgBox((object) ("Equivalent y value based on the HTB and total area of external elements = " + Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue)));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private double ShowY()
    {
      double num1;
      try
      {
        int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
        int index1 = 0;
        while (index1 <= num2)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Count;
          checked { ++index1; }
        }
        int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
        int index2 = 0;
        while (index2 <= num3)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Count;
          checked { ++index2; }
        }
        int num4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
        int index3 = 0;
        while (index3 <= num4)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Count;
          checked { ++index3; }
        }
        int num5 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors - 1);
        int index4 = 0;
        while (index4 <= num5)
        {
          num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[index4].Area;
          checked { ++index4; }
        }
        int num6 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int index5 = 0;
        while (index5 <= num6)
        {
          double area = (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index5].Area;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas)
          {
            int num7 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
            int index6 = 0;
            while (index6 <= num7)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index6].Location, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index5].Name, false) == 0)
                area -= (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index6].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index6].Count;
              checked { ++index6; }
            }
            int num8 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
            int index7 = 0;
            while (index7 <= num8)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index7].Location, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[index5].Name, false) == 0)
                area -= (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index7].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index7].Count;
              checked { ++index7; }
            }
          }
          num1 += area;
          checked { ++index5; }
        }
        int num9 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1);
        int index8 = 0;
        while (index8 <= num9)
        {
          double area = (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index8].Area;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].GrossAreas)
          {
            int num10 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
            int index9 = 0;
            while (index9 <= num10)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index9].Location, SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[index8].Name, false) == 0)
                area -= (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index9].Area * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index9].Count;
              checked { ++index9; }
            }
          }
          num1 += area;
          checked { ++index8; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue == 0.0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue = (float) Conversion.Val(this.txtHtb.Text);
      return Math.Round(Conversion.Val(this.txtHtb.Text) / num1, 4);
    }

    private void CreateXMLToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Calc2012 calc2012 = new Calc2012();
      calc2012.SETPCDF(SAP_Module.PCDFData);
      calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
      XML2012 xmL2012 = new XML2012();
      SAP_Module.Calculation2012 = calc2012;
      SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index = 0;
      while (index <= num)
      {
        SAP_Module.CurrDwelling = index;
        SAP_Module.Proj.Dwellings[index] = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        xmL2012.CreateSAPXML(SAP_Module.CurrDwelling, 4);
        checked { ++index; }
      }
    }

    private void SimplifyTestToolStripMenuItem_Click(object sender, EventArgs e) => MyProject.Forms.CalculationType_ScotlandOnly.Show();

    private void Dims_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void ScotGraphs_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(this.ScotGraphs.Text) == 1.0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOfScotGraphs = 1;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOfScotGraphs = 2;
    }

    private void UValueEditorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UValueCalc uvalueCalc = new UValueCalc();
      Output.UProjy = SAP_Module.Proj.SAPUValues;
      Output.Draft = !Validation.UserLogged;
      int num = (int) ((Form) uvalueCalc).ShowDialog();
      SAP_Module.Proj.SAPUValues = Output.UProjy;
      this.UValueCheckAlterations();
      ((Component) uvalueCalc).Dispose();
    }

    private void SelectUValueToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string uvalueType1 = this.UValueType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType1, "Floor", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType1, "Wall", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType1, "Roof", false) == 0)
          {
            SAP_Module.ControlNow = this.Roofs;
            if (this.Roofs.Rows[SAP_Module.RowNow].IsNewRow)
            {
              this.DontAdd = true;
              this.Roofs.Rows.Add();
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs == null)
              {
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs = new SAP_Module.Opaques[1];
              }
              else
              {
                // ISSUE: variable of a reference type
                SAP_Module.Opaques[]& local;
                // ISSUE: explicit reference operation
                SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs), (Array) new SAP_Module.Opaques[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs.Length + 1)]);
                local = opaquesArray;
              }
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs.Length;
              SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
              this.DontAdd = false;
            }
          }
        }
        else
        {
          SAP_Module.ControlNow = this.Walls;
          if (this.Walls.Rows[SAP_Module.RowNow].IsNewRow)
          {
            this.DontAdd = true;
            this.Walls.Rows.Add();
            if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls == null)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls = new SAP_Module.Opaques[1];
            }
            else
            {
              // ISSUE: variable of a reference type
              SAP_Module.Opaques[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls), (Array) new SAP_Module.Opaques[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls.Length + 1)]);
              local = opaquesArray;
            }
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls.Length;
            SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
            this.DontAdd = false;
          }
        }
      }
      else
      {
        SAP_Module.ControlNow = this.Floors;
        if (this.Floors.Rows[SAP_Module.RowNow].IsNewRow)
        {
          this.DontAdd = true;
          this.Floors.Rows.Add();
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors == null)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors = new SAP_Module.Opaques[1];
          }
          else
          {
            // ISSUE: variable of a reference type
            SAP_Module.Opaques[]& local;
            // ISSUE: explicit reference operation
            SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors), (Array) new SAP_Module.Opaques[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors.Length + 1)]);
            local = opaquesArray;
          }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors.Length;
          SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
          this.DontAdd = false;
        }
      }
      UValues uvalues = new UValues();
      uvalues.Type = this.UValueType;
      if (uvalues.ShowDialog() != DialogResult.OK)
        return;
      string uvalueType2 = this.UValueType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType2, "Floor", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType2, "Wall", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType2, "Roof", false) == 0)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].UValueSelected = true;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].UValueSelection = uvalues.SelectedUValue;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].U_Value = (float) Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[uvalues.SelectedUValue].uValue, 2, MidpointRounding.AwayFromZero);
            SAP_Read.ReadRoofs();
          }
        }
        else
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].UValueSelected = true;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].UValueSelection = uvalues.SelectedUValue;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].U_Value = (float) Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[uvalues.SelectedUValue].uValue, 2, MidpointRounding.AwayFromZero);
          SAP_Read.ReadWalls();
        }
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].UValueSelected = true;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].UValueSelection = uvalues.SelectedUValue;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].U_Value = (float) Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[uvalues.SelectedUValue].uValue, 2, MidpointRounding.AwayFromZero);
        SAP_Read.ReadFloors();
      }
      this.DontShowUValueList = true;
      SAP_Module.ControlNow.CurrentCell = SAP_Module.ControlNow[SAP_Module.ColNow, SAP_Module.RowNow];
      this.DontShowUValueList = false;
      SAP_Write.SaveDetails();
      Functions.CalculateNow();
    }

    private void RemoveUvalueToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string uvalueType = this.UValueType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Floor", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Wall", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Roof", false) != 0)
            return;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].UValueSelected = false;
          this.Roofs.CurrentCell.ReadOnly = false;
          this.Roofs.CurrentCell.Style.BackColor = Color.White;
        }
        else
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].UValueSelected = false;
          this.Walls.CurrentCell.ReadOnly = false;
          this.Walls.CurrentCell.Style.BackColor = Color.White;
        }
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].UValueSelected = false;
        this.Floors.CurrentCell.ReadOnly = false;
        this.Floors.CurrentCell.Style.BackColor = Color.White;
      }
    }

    private void ctxUValue_Opening(object sender, CancelEventArgs e)
    {
      bool uvalueSelected;
      int uvalueSelection;
      try
      {
        string uvalueType = this.UValueType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Floor", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Wall", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Roof", false) == 0)
            {
              if (!this.Roofs.Rows[SAP_Module.RowNow].IsNewRow)
                uvalueSelected = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].UValueSelected;
              if (uvalueSelected)
                uvalueSelection = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[SAP_Module.RowNow].UValueSelection;
            }
          }
          else
          {
            if (!this.Walls.Rows[SAP_Module.RowNow].IsNewRow)
              uvalueSelected = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].UValueSelected;
            if (uvalueSelected)
              uvalueSelection = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[SAP_Module.RowNow].UValueSelection;
          }
        }
        else
        {
          if (!this.Floors.Rows[SAP_Module.RowNow].IsNewRow)
            uvalueSelected = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].UValueSelected;
          if (uvalueSelected)
            uvalueSelection = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[SAP_Module.RowNow].UValueSelection;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.RemoveUvalueToolStripMenuItem.Enabled = uvalueSelected;
      if (uvalueSelected)
      {
        try
        {
          this.UValueConnection.Text = "(U-value connection with '" + SAP_Module.Proj.SAPUValues.SAPUValues[uvalueSelection].prop_Name + "')";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.UValueConnection.BackColor = Color.Beige;
      }
      else
        this.UValueConnection.Text = "(No U-value connection)";
      if (SAP_Module.Proj.SAPUValues.SAPUValues == null)
        this.SelectUValueToolStripMenuItem.Enabled = false;
      else if (SAP_Module.Proj.SAPUValues.SAPUValues.Length == 0)
      {
        this.SelectUValueToolStripMenuItem.Enabled = false;
      }
      else
      {
        bool flag = false;
        string uvalueType = this.UValueType;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Floor", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Wall", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(uvalueType, "Roof", false) == 0)
            {
              int num = checked (SAP_Module.Proj.SAPUValues.SAPUValues.Length - 1);
              int index = 0;
              while (index <= num)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SAPUValues.SAPUValues[index].prop_entity_type, "Roof", false) == 0)
                  flag = true;
                checked { ++index; }
              }
            }
          }
          else
          {
            int num = checked (SAP_Module.Proj.SAPUValues.SAPUValues.Length - 1);
            int index = 0;
            while (index <= num)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SAPUValues.SAPUValues[index].prop_entity_type, "Wall", false) == 0)
                flag = true;
              checked { ++index; }
            }
          }
        }
        else
        {
          int num = checked (SAP_Module.Proj.SAPUValues.SAPUValues.Length - 1);
          int index = 0;
          while (index <= num)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SAPUValues.SAPUValues[index].prop_entity_type, "Floor", false) == 0)
              flag = true;
            checked { ++index; }
          }
        }
        this.SelectUValueToolStripMenuItem.Enabled = flag;
      }
    }

    private void Floors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.ColumnIndex != 5)
        return;
      this.UValueType = "Floor";
      Point mousePosition = Control.MousePosition;
      checked { mousePosition.X += 3; }
      checked { mousePosition.Y += 10; }
      SAP_Module.RowNow = e.RowIndex;
      SAP_Module.ColNow = e.ColumnIndex;
      if (!this.DontShowUValueList)
        this.ctxUValue.Show(mousePosition);
    }

    private void walls_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.ColumnIndex != 5)
        return;
      this.UValueType = "Wall";
      Point mousePosition = Control.MousePosition;
      checked { mousePosition.X += 3; }
      checked { mousePosition.Y += 10; }
      SAP_Module.RowNow = e.RowIndex;
      SAP_Module.ColNow = e.ColumnIndex;
      if (!this.DontShowUValueList)
        this.ctxUValue.Show(mousePosition);
    }

    private void Roofs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.ColumnIndex != 5)
        return;
      this.UValueType = "Roof";
      Point mousePosition = Control.MousePosition;
      checked { mousePosition.X += 3; }
      checked { mousePosition.Y += 10; }
      SAP_Module.RowNow = e.RowIndex;
      SAP_Module.ColNow = e.ColumnIndex;
      if (!this.DontShowUValueList)
        this.ctxUValue.Show(mousePosition);
    }

    public void UValueCheckAlterations()
    {
      string Left = "";
      if (SAP_Module.Proj.SAPUValues.SAPUValues != null)
      {
        int num1 = checked (SAP_Module.Proj.SAPUValues.SAPUValues.Length - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          int num2 = checked (SAP_Module.Proj.NoOfDwells - 1);
          int House = 0;
          while (House <= num2)
          {
            double num3;
            if (SAP_Module.Proj.SAPUValues.SAPUValues[index1].prop_entity_type.Equals("Floor"))
            {
              int num4 = checked (SAP_Module.Proj.Dwellings[House].NoofFloors - 1);
              int index2 = 0;
              while (index2 <= num4)
              {
                if (!Functions.LodgementLock(House) && SAP_Module.Proj.Dwellings[House].Floors[index2].UValueSelected & SAP_Module.Proj.Dwellings[House].Floors[index2].UValueSelection == index1)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(((IEnumerable<char>) SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue.ToString().ToArray<char>()).ToList<char>().Last<char>()), "5", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    double& local;
                    // ISSUE: explicit reference operation
                    double num5 = ^(local = ref SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue) + 1E-05;
                    local = num5;
                  }
                  double num6 = Conversion.Val(SAP_Module.Proj.Dwellings[House].Floors[index2].U_Value.ToString());
                  num3 = Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue, 2, MidpointRounding.AwayFromZero);
                  double num7 = Conversion.Val(num3.ToString());
                  if (num6 != num7)
                  {
                    Math.Round(new Decimal(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue), 1);
                    SAP_Module.Proj.Dwellings[House].Floors[index2].U_Value = (float) Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue, 2, MidpointRounding.AwayFromZero);
                    Left = Left + "Change of U-value: (" + SAP_Module.Proj.SAPUValues.SAPUValues[index1].prop_Name + "): - House: " + SAP_Module.Proj.Dwellings[House].Name + " Floor: " + SAP_Module.Proj.Dwellings[House].Floors[index2].Name + "\r\n";
                  }
                }
                checked { ++index2; }
              }
            }
            if (SAP_Module.Proj.SAPUValues.SAPUValues[index1].prop_entity_type.Equals("Wall"))
            {
              int num8 = checked (SAP_Module.Proj.Dwellings[House].NoofWalls - 1);
              int index3 = 0;
              while (index3 <= num8)
              {
                if (!Functions.LodgementLock(House) && SAP_Module.Proj.Dwellings[House].Walls[index3].UValueSelected & SAP_Module.Proj.Dwellings[House].Walls[index3].UValueSelection == index1)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(((IEnumerable<char>) SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue.ToString().ToArray<char>()).ToList<char>().Last<char>()), "5", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    double& local;
                    // ISSUE: explicit reference operation
                    double num9 = ^(local = ref SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue) + 1E-05;
                    local = num9;
                  }
                  double num10 = Conversion.Val(SAP_Module.Proj.Dwellings[House].Walls[index3].U_Value.ToString());
                  num3 = Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue, 2, MidpointRounding.AwayFromZero);
                  double num11 = Conversion.Val(num3.ToString());
                  if (num10 != num11)
                  {
                    SAP_Module.Proj.Dwellings[House].Walls[index3].U_Value = (float) Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue, 2, MidpointRounding.AwayFromZero);
                    Left = Left + "Change of U-value: (" + SAP_Module.Proj.SAPUValues.SAPUValues[index1].prop_Name + "): - House: " + SAP_Module.Proj.Dwellings[House].Name + " Wall: " + SAP_Module.Proj.Dwellings[House].Walls[index3].Name + "\r\n";
                  }
                }
                checked { ++index3; }
              }
            }
            if (SAP_Module.Proj.SAPUValues.SAPUValues[index1].prop_entity_type.Equals("Roof"))
            {
              int num12 = checked (SAP_Module.Proj.Dwellings[House].NoofRoofs - 1);
              int index4 = 0;
              while (index4 <= num12)
              {
                if (!Functions.LodgementLock(House) && SAP_Module.Proj.Dwellings[House].Roofs[index4].UValueSelected & SAP_Module.Proj.Dwellings[House].Roofs[index4].UValueSelection == index1)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(((IEnumerable<char>) SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue.ToString().ToArray<char>()).ToList<char>().Last<char>()), "5", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    double& local;
                    // ISSUE: explicit reference operation
                    double num13 = ^(local = ref SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue) + 1E-05;
                    local = num13;
                  }
                  double num14 = Conversion.Val(SAP_Module.Proj.Dwellings[House].Roofs[index4].U_Value.ToString());
                  num3 = Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue, 2, MidpointRounding.AwayFromZero);
                  double num15 = Conversion.Val(num3.ToString());
                  if (num14 != num15)
                  {
                    SAP_Module.Proj.Dwellings[House].Roofs[index4].U_Value = (float) Math.Round(SAP_Module.Proj.SAPUValues.SAPUValues[index1].uValue, 2, MidpointRounding.AwayFromZero);
                    Left = Left + "Change of U-value: (" + SAP_Module.Proj.SAPUValues.SAPUValues[index1].prop_Name + "): - House: " + SAP_Module.Proj.Dwellings[House].Name + " Roof: " + SAP_Module.Proj.Dwellings[House].Roofs[index4].Name + "\r\n";
                  }
                }
                checked { ++index4; }
              }
            }
            checked { ++House; }
          }
          checked { ++index1; }
        }
      }
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) <= 0U)
        return;
      int num = (int) new UvalueChanges()
      {
        TextBox1 = {
          Text = Left
        }
      }.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.View, "Opaque Elements", false) == 0)
      {
        SAP_Read.ReadFloors();
        SAP_Read.ReadWalls();
        SAP_Read.ReadRoofs();
      }
      SAP_Write.SaveDetails();
      Functions.CalculateNow();
    }

    private void EditUvaluesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UValueCalc uvalueCalc = new UValueCalc();
      Output.UProjy = SAP_Module.Proj.SAPUValues;
      Output.Draft = !Validation.UserLogged;
      int num = (int) ((Form) uvalueCalc).ShowDialog();
      SAP_Module.Proj.SAPUValues = Output.UProjy;
      ((Component) uvalueCalc).Dispose();
      this.UValueCheckAlterations();
    }

    private void Walls_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void SingleEPCLodgementToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select dwelling first!", MsgBoxStyle.Information, (object) "Lodgement");
      }
      else if (SAP_Module.Proj.NoOfDwells < 1)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "Lodgement");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].UPRN, "", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Unable to lodge the dwelling, address details are incomplete!", MsgBoxStyle.Information, (object) "Lodgement");
      }
      else
      {
        if (SAP_Module.Proj.SaveFileName == null)
        {
          if (Interaction.MsgBox((object) "You need to save the file prior to making a lodgement", MsgBoxStyle.OkCancel | MsgBoxStyle.Information, (object) "Save File") != MsgBoxResult.Ok)
            return;
          this.SaveProjectToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
        }
        if (!Validation.LodgementStatusCheck(SAP_Module.CurrDwelling))
        {
          int num4 = (int) Interaction.MsgBox((object) "Unable to lodge the dwelling, dwelling input is incomplete!", MsgBoxStyle.Information, (object) "Lodgement");
        }
        else
        {
          if (SAP_Module.Proj.SaveFileName == null)
            return;
          int num5 = (int) MyProject.Forms.Lodgement.ShowDialog();
        }
      }
    }

    private void LodgementShowDialogToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Lodgement Error. Please select a dwelling for lodgement.", MsgBoxStyle.Critical, (object) "Lodgement");
      }
      else if (!Validation.UserLogged && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Login Error. Please login before viewing the draft.", MsgBoxStyle.Critical, (object) "EPC Generation");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].UPRN, "", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Missing UPRN . Please enter UPRN for the property before viewing the draft.", MsgBoxStyle.Critical, (object) "EPC Generation");
      }
      else
        MyProject.Forms.Lodgement.Show();
    }

    private void PredictedEPCToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.CurrDwelling == -1)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please select dwelling first!", MsgBoxStyle.Information, (object) "Lodgement");
      }
      else if (SAP_Module.Proj.NoOfDwells < 1)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please create dwelling first!", MsgBoxStyle.Information, (object) "View Reports");
      }
      else
      {
        Validation.PredicatedCheck = true;
        CreatePDF createPdf = new CreatePDF();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Northern Ireland", false) == 0)
          return;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Wales", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage, "Welsh", false) == 0)
          createPdf.GeneratePredictedPDF(2, SAP_Module.CurrDwelling);
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
          createPdf.GeneratePredictedPDF(4, SAP_Module.CurrDwelling);
        else
          createPdf.GeneratePredictedPDF(1, SAP_Module.CurrDwelling);
      }
    }

    private void ChangeDwellingTypeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[index].Status, "New dwelling design stage", false) == 0)
          SAP_Module.Proj.Dwellings[index].Status = "New dwelling as built";
        checked { ++index; }
      }
    }

    private void ShowAllSuccessfulLodgementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Lodgements_Successful().ShowDialog();
    }

    private void KToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new DataSet().ReadXml(Application.StartupPath + "\\Data\\ExternalDefinitions.xml");
    }

    private void NoWindowPresent_CheckedChanged(object sender, EventArgs e) => SAP_Write.WriteWindows();

    private void ReportsToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
    {
      try
      {
        if (SAP_Module.CurrDwelling != -1)
        {
          this.mnulblPreCSH.Enabled = true;
          this.mnulblPreCSH.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverrideEne7;
          this.mnulblPreCSH.Text = "Make Pre 12-08-2011 CSH Report for " + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
        }
        else
        {
          this.mnulblPreCSH.Enabled = false;
          this.mnulblPreCSH.Text = "";
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void mnulblPreCSH_Click(object sender, EventArgs e) => SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverrideEne7 = this.mnulblPreCSH.Checked;

    private void SelectHistoricCalculationVersionsToolStripMenuItem_Click(
      object sender,
      EventArgs e)
    {
      if (new Version().ShowDialog() != DialogResult.OK)
        return;
      Functions.CalculateNow();
    }

    private void cmdAddAddress_Click(object sender, EventArgs e)
    {
      if (SAPInput.TraineeUser)
      {
        int num1 = (int) Interaction.MsgBox((object) "Address  Error. You are not authorized to add a new address.", MsgBoxStyle.Critical, (object) "New Address");
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Please enter the country prior to requesting new address", MsgBoxStyle.Information, (object) "New Address");
      }
      else if (!Validation.UserLogged)
      {
        int num3 = (int) Interaction.MsgBox((object) "Please Login prior to requesting new address", MsgBoxStyle.Information, (object) "New Address");
      }
      else
      {
        AddNewAddress addNewAddress = new AddNewAddress();
        addNewAddress.txtAddNum.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1;
        addNewAddress.txtAddStreet.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line2;
        addNewAddress.txtAddLoc.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line3;
        addNewAddress.txtAddCity.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.City;
        addNewAddress.txtAddPcode.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost;
        addNewAddress.txtAddEA.Text = Validation.AssessorNO;
        if (addNewAddress.ShowDialog() == DialogResult.OK)
        {
          this.txtUPRN.Text = addNewAddress.UPRN;
          this.txtDAdd1.Text = addNewAddress.txtAddNum.Text + " " + addNewAddress.txtAddStreet.Text;
          this.txtDAdd2.Text = addNewAddress.txtAddLoc.Text;
          this.txtDCity.Text = addNewAddress.txtAddCity.Text;
          this.txtDPostCode.Text = addNewAddress.txtAddPcode.Text;
          SAP_Write.WriteDwellingDetails(false);
        }
      }
    }

    private void TreeSAP_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
        return;
      TreeView treeView = (TreeView) sender;
      TreeNode data = (TreeNode) e.Data.GetData("System.Windows.Forms.TreeNode");
      TreeNode selectedNode = treeView.SelectedNode;
      if (selectedNode.Level != 1)
        return;
      if (selectedNode == data)
        return;
      try
      {
        if (Interaction.MsgBox((object) ("Move " + data.Text + " before " + selectedNode.Text), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Delete Dwelling?") == MsgBoxResult.Yes)
        {
          SAP_Module.DontChange = true;
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
          SAP_Module.Dwelling Dwelling = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[data.Index]);
          if (data.Index < selectedNode.Index)
          {
            int index1 = data.Index;
            int num = checked (selectedNode.Index - 2);
            int index2 = index1;
            while (index2 <= num)
            {
              SAP_Module.Proj.Dwellings[index2] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[checked (index2 + 1)]);
              checked { ++index2; }
            }
            SAP_Module.Proj.Dwellings[checked (selectedNode.Index - 1)] = Functions.CopyDwelling(Dwelling);
          }
          else
          {
            int index3 = data.Index;
            int num = checked (selectedNode.Index + 1);
            int index4 = index3;
            while (index4 >= num)
            {
              SAP_Module.Proj.Dwellings[index4] = Functions.CopyDwelling(SAP_Module.Proj.Dwellings[checked (index4 - 1)]);
              checked { index4 += -1; }
            }
            SAP_Module.Proj.Dwellings[selectedNode.Index] = Functions.CopyDwelling(Dwelling);
          }
          Functions.MakeTree();
          this.TreeSAP.CollapseAll();
          this.TreeSAP.Nodes[0].Expand();
          SAP_Module.DontChange = false;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void TreeSAP_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
        e.Effect = DragDropEffects.Move;
      else
        e.Effect = DragDropEffects.None;
    }

    private void TreeSAP_DragOver(object sender, DragEventArgs e)
    {
      TreeNode data = (TreeNode) e.Data.GetData("System.Windows.Forms.TreeNode");
      if (!e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
        return;
      TreeView treeView = (TreeView) sender;
      Point client = ((Control) sender).PointToClient(new Point(e.X, e.Y));
      TreeNode nodeAt = treeView.GetNodeAt(client);
      try
      {
        if (nodeAt.Level != 1)
          return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (treeView.SelectedNode != nodeAt)
      {
        treeView.SelectedNode = nodeAt;
        if (nodeAt == data)
        {
          e.Effect = DragDropEffects.None;
          return;
        }
        if (nodeAt.Level != 1)
        {
          e.Effect = DragDropEffects.None;
          return;
        }
      }
      else
        e.Effect = DragDropEffects.None;
      e.Effect = DragDropEffects.Move;
    }

    private void TreeSAP_ItemDrag(object sender, ItemDragEventArgs e)
    {
      TreeNode data = (TreeNode) e.Item;
      if (data.Level != 1)
        return;
      int num = (int) this.DoDragDrop((object) data, DragDropEffects.Move);
    }

    private void ProjectNotesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Notes().ShowDialog();
      Functions.MakeTree();
    }

    private void TreeSAP_MouseMove(object sender, MouseEventArgs e)
    {
      if (!MySettingsProperty.Settings.DisplayNotes)
      {
        this.ToolTip2.SetToolTip((Control) this.TreeSAP, "");
      }
      else
      {
        TreeNode nodeAt = this.TreeSAP.GetNodeAt(e.X, e.Y);
        if (nodeAt != null)
        {
          if (nodeAt.Level == 2)
            return;
          if (nodeAt.Level == 1)
          {
            if (string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[nodeAt.Index].Comments))
            {
              if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.ToolTipTitle, nodeAt.Text, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.GetToolTip((Control) this.TreeSAP), "No notes recorded", false) > 0U)
              {
                this.ToolTip2.SetToolTip((Control) this.TreeSAP, "No notes recorded");
                this.ToolTip2.ToolTipTitle = SAP_Module.Proj.Dwellings[nodeAt.Index].Name;
              }
            }
            else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.ToolTipTitle, nodeAt.Text, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.GetToolTip((Control) this.TreeSAP), SAP_Module.Proj.Dwellings[nodeAt.Index].Comments, false) > 0U)
            {
              this.ToolTip2.SetToolTip((Control) this.TreeSAP, SAP_Module.Proj.Dwellings[nodeAt.Index].Comments);
              this.ToolTip2.ToolTipTitle = SAP_Module.Proj.Dwellings[nodeAt.Index].Name;
            }
          }
          if (nodeAt.Level != 0)
            return;
          if (string.IsNullOrEmpty(SAP_Module.Proj.Comments))
          {
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.ToolTipTitle, nodeAt.Text, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.GetToolTip((Control) this.TreeSAP), "No notes recorded", false) > 0U)
            {
              this.ToolTip2.SetToolTip((Control) this.TreeSAP, "No notes recorded");
              this.ToolTip2.ToolTipTitle = SAP_Module.Proj.Name;
            }
          }
          else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.ToolTipTitle, nodeAt.Text, false) > 0U | (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ToolTip2.GetToolTip((Control) this.TreeSAP), SAP_Module.Proj.Comments, false) > 0U)
          {
            this.ToolTip2.SetToolTip((Control) this.TreeSAP, SAP_Module.Proj.Comments);
            this.ToolTip2.ToolTipTitle = SAP_Module.Proj.Name;
          }
        }
        else
          this.ToolTip2.SetToolTip((Control) this.TreeSAP, "");
      }
    }

    private void ShowNotesToolStripMenuItem_Click(object sender, EventArgs e) => MySettingsProperty.Settings.DisplayNotes = !MySettingsProperty.Settings.DisplayNotes;

    private void NHERXMLImportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
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
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
      FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
      folderBrowserDialog2.RootFolder = Environment.SpecialFolder.Desktop;
      folderBrowserDialog2.SelectedPath = "c:\\windows";
      folderBrowserDialog2.Description = "Select the source directory";
      if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.Proj = new SAP_Module.Project();
        SAP_Module.CurrDwelling = 0;
        FileInfo[] files = new DirectoryInfo(folderBrowserDialog1.SelectedPath).GetFiles();
        int index = 0;
        while (index < files.Length)
        {
          FileInfo fileInfo = files[index];
          if (fileInfo.Name.Contains(".xml") | fileInfo.Name.Contains(".XML") | fileInfo.Name.Contains(".Xml"))
            OtherCompanies.CreateNHERData(fileInfo.FullName);
          checked { ++index; }
        }
      }
      ref SAP_Module.Project local = ref SAP_Module.Proj;
      string[] strArray = new string[6]
      {
        Environment.GetFolderPath(Environment.SpecialFolder.Personal),
        "\\",
        null,
        null,
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      strArray[2] = Conversions.ToString(now.Year);
      now = DateAndTime.Now;
      strArray[3] = Conversions.ToString(now.Month);
      now = DateAndTime.Now;
      strArray[4] = Conversions.ToString(now.Day);
      strArray[5] = ".STS2012";
      string str = string.Concat(strArray);
      local.SaveFileName = str;
      if (System.IO.File.Exists(SAP_Module.Proj.SaveFileName))
        System.IO.File.Delete(SAP_Module.Proj.SaveFileName);
      Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
        return;
      SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
      SAP_Module.CurrDwelling = -1;
      Functions.MakeTree();
      this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
      SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
      Functions.AddFile(SAP_Module.Proj.SaveFileName);
    }

    private void TimerAutoSave_Tick(object sender, EventArgs e)
    {
    }

    private void AutoSaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.AutoSaveToolStripMenuItem.Checked)
        this.TimerAutoSave.Enabled = true;
      else
        this.TimerAutoSave.Enabled = false;
    }

    private void TimerAutoSave_Tick_1(object sender, EventArgs e)
    {
      int num = (int) Interaction.MsgBox((object) "Please Save your work now", MsgBoxStyle.Information, (object) "Stoma Auto Save remnder");
    }

    private void cboAddress_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Button12_Click(object sender, EventArgs e)
    {
      string str = Interaction.InputBox("Enter UPRN", "UPRN Search");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0)
        return;
      try
      {
        this.txtDAdd1.Text = "";
        this.txtDAdd2.Text = "";
        this.txtDAdd3.Text = "";
        this.txtDCity.Text = "";
        this.txtDPostCode.Text = "";
        this.txtUPRN.Text = "";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
        {
          Stroma_DomesticScotlandSoapClient scotlandSoapClient = new Stroma_DomesticScotlandSoapClient();
          Functions.Access_Details();
          object obj = (object) scotlandSoapClient.AddressSearch_byUPRN(true, str, Functions.TransactionID, Functions.Encrypt);
        }
        else
        {
          Functions.Access_Details();
          SAPSoapClient sapSoapClient = new SAPSoapClient();
          AddressRequest Request = new AddressRequest()
          {
            Security = new SecurityClass()
            {
              Encryption = Functions.Encrypt,
              Transaction = Functions.TransactionID
            },
            Selection = new SelectionClass()
            {
              Assessment = AssessmentType.SAP,
              Country = CountryType.England,
              Environment = EnviornmentType.LIVE
            }
          };
          AddressResult addressResult = sapSoapClient.AddressByUPRN(str, Request);
          if (addressResult.Success && addressResult.Address.Length > 0)
          {
            this.txtDAdd1.Text = ((IEnumerable<AddressDetails>) addressResult.Address).First<AddressDetails>().AddressLine1;
            this.txtDAdd2.Text = ((IEnumerable<AddressDetails>) addressResult.Address).First<AddressDetails>().AddressLine2;
            this.txtDAdd3.Text = ((IEnumerable<AddressDetails>) addressResult.Address).First<AddressDetails>().AddressLine3;
            this.txtDCity.Text = ((IEnumerable<AddressDetails>) addressResult.Address).First<AddressDetails>().City;
            this.txtDPostCode.Text = ((IEnumerable<AddressDetails>) addressResult.Address).First<AddressDetails>().PostCode;
            this.txtUPRN.Text = ((IEnumerable<AddressDetails>) addressResult.Address).First<AddressDetails>().UPRN;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ConnectionCheckToolStripMenuItem_Click(object sender, EventArgs e) => MyProject.Forms.ConnectionCheck.Show();

    private void chkApprovedScheme_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void ToolStripMenuItem25_Click(object sender, EventArgs e)
    {
      Validation.OldFormat = true;
      try
      {
        MyProject.Forms.Lodgement.Show();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      Validation.OldFormat = false;
    }

    private void DwellingCountToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        int num = (int) Interaction.MsgBox((object) ("Total dwellings for this project are " + Conversions.ToString(SAP_Module.Proj.NoOfDwells)), MsgBoxStyle.Information, (object) "Stroma Dwelling count");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void cmdImportLig16_Click(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        if ((uint) openFileDialog.ShowDialog() <= 0U)
          return;
        using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
        {
          SAP_Module.Dwelling dwelling = new RdSAP_TO_SAP().Convert_2_SAP(new XML_To_Survey().Convert(streamReader.ReadToEnd()));
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
          Application.DoEvents();
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          int num = checked (^(local1 = ref SAP_Module.Proj.NoOfDwells) + 1);
          local1 = num;
          // ISSUE: variable of a reference type
          SAP_Module.Dwelling[]& local2;
          // ISSUE: explicit reference operation
          SAP_Module.Dwelling[] dwellingArray = (SAP_Module.Dwelling[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings), (Array) new SAP_Module.Dwelling[checked (SAP_Module.Proj.NoOfDwells - 1 + 1)]);
          local2 = dwellingArray;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)] = dwelling;
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = "House " + Conversions.ToString(SAP_Module.Proj.NoOfDwells);
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          Validation.Checkerrors_All(SAP_Module.CurrDwelling);
          Functions.MakeTree();
          SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ShowECOResultsFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (SAP_Module.EcoFormShow == null)
        SAP_Module.EcoFormShow = new ECOForm();
      SAP_Module.EcoFormShow.Show();
    }

    private void cmdMainControlSelect_Click(object sender, EventArgs e)
    {
      if (new Controls()
      {
        AppliedSystem = Controls.HeatingSystem.Main
      }.ShowDialog() != DialogResult.OK)
        return;
      this.lblControlTTZ.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDF;
    }

    private void cmdSecControlSelect_Click(object sender, EventArgs e)
    {
      if (new Controls()
      {
        AppliedSystem = Controls.HeatingSystem.SecondaryMain
      }.ShowDialog() != DialogResult.OK)
        return;
      this.lblSecControlTTZ.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDF;
    }

    private void txtPumpHP_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPumpHP.Text, "Yes", false) == 0)
      {
        this.txtPumpType.Enabled = true;
      }
      else
      {
        this.txtPumpType.Text = "";
        this.txtPumpType.Enabled = false;
      }
    }

    private void ProjectCreationDateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) Interaction.MsgBox((object) ("Project was created on " + Conversions.ToString(SAP_Module.Proj.ProjectDate)), MsgBoxStyle.Information, (object) "FSAP 2012");
    }

    private void DwellingCreationDateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        int num = (int) Interaction.MsgBox((object) ("Project was created on " + Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DateDwellingCreated)), MsgBoxStyle.Information, (object) "FSAP 2012");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void optCyPipeWork_CheckedChanged(object sender, EventArgs e) => this.cboPipeWorkInsulated.Enabled = this.optCyPipeWork.Checked;

    private void chkPVDirect_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.chkPVDirect.Checked)
      {
        try
        {
          if (this.cboPVConnection.Items.Count > 0)
            this.cboPVConnection.Items.Clear();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.cboPVConnection.Items.Add((object) "PV output goes to particular individual flats");
        this.cboPVConnection.Items.Add((object) "PV output goes to all flats in proportion to floor area");
        this.cboPVConnection.Enabled = true;
      }
      else
      {
        this.cboPVConnection.Text = "";
        this.cboPVConnection.Enabled = false;
      }
    }

    private void cmdStorage_Click(object sender, EventArgs e)
    {
      if (new StorageSelectionVessel().ShowDialog() != DialogResult.OK)
        return;
      SAP_Read.ReadMainHeating();
    }

    private void cmdMainControlSelectWeather_Click(object sender, EventArgs e)
    {
      if (new Controls()
      {
        AppliedSystem = Controls.HeatingSystem.Main,
        AppliedType = Controls.ControlType.Weather
      }.ShowDialog() == DialogResult.OK)
      {
        this.lblControlWeather.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDFWeather;
        if (!SAP_Module.Proj.OverRide)
        {
          if (Conversions.ToDouble(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlDelayedStart) == 2.0)
          {
            this.chkDelayedStart.Checked = false;
            this.chkDelayedStart.Enabled = false;
          }
          else
            this.chkDelayedStart.Enabled = true;
        }
        else
          this.chkDelayedStart.Enabled = true;
      }
      Validation.Checkerrors_All(SAP_Module.CurrDwelling);
    }

    private void optCommunityDatabase_CheckedChanged(object sender, EventArgs e)
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase = this.optCommunityDatabase.Checked;
      this.grdCommunityWater.Visible = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase;
      this.grdCommunityWaterSources.Visible = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase;
      this.cmdCommunityDatabase.Enabled = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase;
    }

    private void cmdCommunityDatabase_Click(object sender, EventArgs e)
    {
      int num = (int) new CommunitySearch(CommunitySearch.Type.Water).ShowDialog();
    }

    private void chkKnownLoss_CheckedChanged(object sender, EventArgs e)
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.KnownLossFactor = this.chkKnownLoss.Checked;
      this.txtDHWCommHDS.Enabled = !this.chkKnownLoss.Checked;
      this.txtKnownLoss.Enabled = this.chkKnownLoss.Checked;
    }

    private void chkEmissionsOnly_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkEmissionsOnly.Checked)
      {
        this.txtSpESaved.Enabled = false;
        this.txtSpEUsed.Enabled = false;
        this.txtSpFSaved.Enabled = false;
        this.txtSpFUsed.Enabled = false;
        this.txtEmissionsOnly.Enabled = true;
        this.txtEmissionsOnlyCreated.Enabled = true;
      }
      else
      {
        this.txtSpESaved.Enabled = true;
        this.txtSpEUsed.Enabled = true;
        this.txtSpFSaved.Enabled = true;
        this.txtSpFUsed.Enabled = true;
        this.txtEmissionsOnly.Enabled = false;
        this.txtEmissionsOnlyCreated.Enabled = false;
      }
      if (this.CurrSPecFeature == -1)
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special == null)
        {
          // ISSUE: variable of a reference type
          SAP_Module.SpecialFeatures[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[1]);
          local = specialFeaturesArray;
        }
        else
        {
          // ISSUE: variable of a reference type
          SAP_Module.SpecialFeatures[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length + 1)]);
          local = specialFeaturesArray;
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)] = new SAP_Module.SpecialFeatures();
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1)].MakeEmissionsOnly = this.chkEmissionsOnly.Checked;
      }
      else
      {
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special == null)
        {
          // ISSUE: variable of a reference type
          SAP_Module.SpecialFeatures[]& local;
          // ISSUE: explicit reference operation
          SAP_Module.SpecialFeatures[] specialFeaturesArray = (SAP_Module.SpecialFeatures[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special), (Array) new SAP_Module.SpecialFeatures[1]);
          local = specialFeaturesArray;
        }
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[this.CurrSPecFeature].MakeEmissionsOnly = this.chkEmissionsOnly.Checked;
      }
    }

    private void cmdSecMainControlSelectWeather_Click(object sender, EventArgs e)
    {
      if (new Controls()
      {
        AppliedSystem = Controls.HeatingSystem.SecondaryMain,
        AppliedType = Controls.ControlType.Weather
      }.ShowDialog() == DialogResult.OK)
        this.lblSecControlWeather.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.ControlCodePCDFWeather;
      Validation.Checkerrors_All(SAP_Module.CurrDwelling);
    }

    private void Import2009Dwelling_Click(object sender, EventArgs e)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Name, "", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Please create a Project first!", MsgBoxStyle.Information, (object) "FSAP 2012");
      }
      else
      {
        int num2 = (int) new Import2009Frm().ShowDialog();
      }
    }

    private void ChkKnown_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ChkKnown.Checked)
      {
        this.txtCommHDS.SelectedText = "";
        this.txtCommHDS.Text = "";
        this.txtLossKnown.Enabled = true;
        this.txtCommHDS.Enabled = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatDSystem = "";
      }
      else
      {
        this.txtLossKnown.Enabled = false;
        this.txtCommHDS.Enabled = true;
        this.txtLossKnown.Text = "";
      }
    }

    private void TabPage1_Click(object sender, EventArgs e)
    {
    }

    private void ReOrderingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        string saveFileName;
        if (SAP_Module.Proj.SaveFileName != null)
          saveFileName = SAP_Module.Proj.SaveFileName;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(saveFileName, "", false) == 0)
        {
          int num = (int) Interaction.MsgBox((object) "Please save the project before re-ordering.", MsgBoxStyle.Critical, (object) "Stroma Certification");
          return;
        }
        SAP_Write.SaveDetails();
        SAP_Module.Proj.SaveFileName = saveFileName;
        Functions.SaveFile(SAP_Module.Proj, saveFileName);
        Functions.AddFile(saveFileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      new Ordering().Show();
    }

    private void ClearBackColor()
    {
      TreeNodeCollection nodes = this.TreeSAP.Nodes;
      try
      {
        foreach (TreeNode treeNode in nodes)
          this.ClearRecursive(treeNode);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void FindByText(string value)
    {
      TreeNodeCollection nodes = this.TreeSAP.Nodes;
      try
      {
        foreach (TreeNode tNode in nodes)
          this.FindRecursive(tNode, value);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void ClearRecursive(TreeNode treeNode)
    {
      try
      {
        foreach (TreeNode node in treeNode.Nodes)
        {
          node.BackColor = Color.White;
          this.ClearRecursive(node);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void FindRecursive(TreeNode tNode, string Value)
    {
      try
      {
        foreach (TreeNode node in tNode.Nodes)
        {
          if (Microsoft.VisualBasic.Strings.LCase(node.Text).Contains(Microsoft.VisualBasic.Strings.LCase(Value)))
          {
            node.BackColor = Color.BlanchedAlmond;
            this.TreeSAP.SelectedNode = node;
            this.TreeSAP.SelectedNode.Expand();
          }
          this.FindRecursive(node, Value);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void SingleXMLToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!Validation.LodgementStatusCheck(SAP_Module.CurrDwelling))
      {
        int num1 = (int) Interaction.MsgBox((object) " Dwelling calculation failed. Please check your inputs.", MsgBoxStyle.Critical, (object) "Stroma Certification");
      }
      else if (!Validation.UserLogged)
      {
        int num2 = (int) Interaction.MsgBox((object) "User not logged in. Please log in first in order to create XML", MsgBoxStyle.Critical);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Community heating schemes", false) == 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2)
      {
        int num3 = (int) Interaction.MsgBox((object) "As the main heating system is community heating the secondary main should be blank. Please untick the secondary main heating system and try again.", MsgBoxStyle.Critical);
      }
      else
      {
        SAPSoapClient sapSoapClient = new SAPSoapClient();
        HQMResult hqmResult = new HQMResult();
        string str1 = "";
        bool flag = false;
        Calc2012 calc2012 = new Calc2012();
        // ISSUE: variable of a reference type
        int& local1;
        // ISSUE: explicit reference operation
        int num4 = checked (^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLAttempts) + 1);
        local1 = num4;
        // ISSUE: variable of a reference type
        SAP_Module.HQMLLodgement[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.HQMLLodgement[] hqmlLodgementArray = (SAP_Module.HQMLLodgement[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt), (Array) new SAP_Module.HQMLLodgement[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLAttempts - 1 + 1)]);
        local2 = hqmlLodgementArray;
        int index = checked (((IEnumerable<SAP_Module.HQMLLodgement>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt).Count<SAP_Module.HQMLLodgement>() - 1);
        Functions.Access_Details();
        calc2012.SETPCDF(SAP_Module.PCDFData);
        calc2012.Dwelling = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
        HQMXML hqmxml1 = new HQMXML();
        SAP_Module.Calculation2012 = calc2012;
        SAP_Module.Proj.NoOfDwells = SAP_Module.Proj.NoOfDwells;
        Functions.CalculateNow();
        HQMXML.HQMXMLReturn hqmxmlReturn = new HQMXML.HQMXMLReturn();
        HQMXML.HQMXMLReturn hqmxml2 = hqmxml1.CreateHQMXML(SAP_Module.CurrDwelling, 1);
        if (!hqmxml2.Validated)
        {
          int num5 = (int) Interaction.MsgBox((object) (hqmxml2.Msg + " -XML failed against the Schema"), MsgBoxStyle.Critical);
        }
        else if (hqmxml2.XML == null)
        {
          int num6 = (int) Interaction.MsgBox((object) "There is an error creating XML", MsgBoxStyle.Critical);
        }
        else
        {
          string str2;
          try
          {
            HQMRequest Request = new HQMRequest();
            hqmResult = new HQMResult();
            Request.AddressLine1 = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1;
            Request.Postcode = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost;
            Request.EacertificateNo = Validation.AssessorNO;
            if (Validation.RefNum == null)
              Validation.RefNum = "";
            Request.RRN = Validation.RefNum;
            Request.TransactionID = Functions.TransactionID;
            Request.Encrypt = Functions.Encrypt;
            Request.XML = hqmxml2.XML;
            hqmResult = sapSoapClient.UploadHQMXML(Request);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].RRN = Validation.RefNum;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            str2 = str1 + " Failed\r\n" + exception.Message + "\r\n\r\n";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].RRN = Validation.RefNum;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].Result = exception.Message + " " + hqmResult.ErrMsg;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].DateLodged = DateAndTime.Now;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HQMLodgemnt[index].Success = false;
            ProjectData.ClearProjectError();
            goto label_26;
          }
          ref SAP_Module.Dwelling local3 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling];
          if (hqmResult.Success)
          {
            str2 = str1 + " Successfully created.\r\n";
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].DateLodged = DateAndTime.Now;
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Result = "Successfully created.";
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].RRN = Validation.RefNum;
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Success = true;
            if (calc2012.Calculation.SAP_rating_11a.SAPRating == 0.0)
            {
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPBand = calc2012.Calculation.SAP_rating_11b.SAPBand;
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11b.SAPRating));
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPRating));
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11b.SAPBand;
            }
            else
            {
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPBand = calc2012.Calculation.SAP_rating_11a.SAPBand;
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.SAPRating = checked ((int) Math.Round(calc2012.Calculation.SAP_rating_11a.SAPRating));
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPRating));
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.SAPBand = SAP_Module.CalculationImprove2012.Calculation.SAP_rating_11a.SAPBand;
            }
            if (calc2012.Calculation.CO2_Emissions_12a.EIValue == 0.0)
            {
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12b.EIBand;
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12b.EIRating));
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIBand;
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12b.EIRating));
            }
            else
            {
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIBand = calc2012.Calculation.CO2_Emissions_12a.EIBand;
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].SAP.EIRating = checked ((int) Math.Round(calc2012.Calculation.CO2_Emissions_12a.Box274));
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIBand = SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.EIBand;
              local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].PSAP.EIRating = checked ((int) Math.Round(SAP_Module.CalculationImprove2012.Calculation.CO2_Emissions_12a.Box274));
            }
            try
            {
              Process.Start("explorer.exe", SAP_Module.HQMXMLPath);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num7 = (int) Interaction.MsgBox((object) ("error is here " + SAP_Module.HQMXMLName));
              ProjectData.ClearProjectError();
            }
          }
          else
          {
            string str3 = str1 + " Failed \r\n";
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].DateLodged = DateAndTime.Now;
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Result = str3 + " " + hqmResult.ErrMsg;
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].RRN = Validation.RefNum;
            local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Success = false;
          }
          local3.HQMLodgemnt[checked (local3.HQMLAttempts - 1)].Method = "Single";
label_26:
          Application.DoEvents();
          flag = false;
          Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        }
      }
    }

    private void BatchXMLsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!Validation.UserLogged)
      {
        int num = (int) Interaction.MsgBox((object) "User not logged in. Please log in first in order to create XML", MsgBoxStyle.Critical);
      }
      else
      {
        try
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
          MyProject.Forms.HQMLodgements.ReadHQM();
          MyProject.Forms.HQMLodgements.Show();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void XMLDownloadHistoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MyProject.Forms.HQMHistory.FillHQMHistory();
      MyProject.Forms.HQMHistory.Show();
    }

    private void VersionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new VersionHistroy().ShowDialog();
    }

    private void SignOffReportToolStripMenuItem_Click(object sender, EventArgs e) => DeveloperReport.CreateDeveloperReport(SAP_Module.CurrDwelling, 1);

    private void BREXMLImportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
      FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
      folderBrowserDialog2.RootFolder = Environment.SpecialFolder.Desktop;
      folderBrowserDialog2.SelectedPath = "c:\\windows";
      folderBrowserDialog2.Description = "Select the source directory";
      if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.Proj = new SAP_Module.Project();
        SAP_Module.CurrDwelling = 0;
        FileInfo[] files = new DirectoryInfo(folderBrowserDialog1.SelectedPath).GetFiles();
        List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
        int num = 1;
        FileInfo[] fileInfoArray = files;
        int index = 0;
        while (index < fileInfoArray.Length)
        {
          FileInfo fileInfo = fileInfoArray[index];
          if (fileInfo.Name.Contains(".xml") | fileInfo.Name.Contains(".XML") | fileInfo.Name.Contains(".Xml"))
          {
            SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
            SAP_Module.Dwelling dwelling2 = new XML_Import().Convert(new StreamReader(fileInfo.FullName).ReadToEnd()) with
            {
              Name = "Dwelling- " + Conversions.ToString(num)
            };
            dwellingList.Add(dwelling2);
            checked { ++num; }
          }
          checked { ++index; }
        }
        SAP_Module.Proj.Dwellings = dwellingList.ToArray();
        SAP_Module.Proj.NoOfDwells = dwellingList.Count;
        SAP_Module.Proj.Name = "SAP community 2012";
        ref SAP_Module.Project local = ref SAP_Module.Proj;
        string[] strArray = new string[6]
        {
          Environment.GetFolderPath(Environment.SpecialFolder.Personal),
          "\\",
          Conversions.ToString(DateAndTime.Now.Year),
          null,
          null,
          null
        };
        DateTime now = DateAndTime.Now;
        strArray[3] = Conversions.ToString(now.Month);
        now = DateAndTime.Now;
        strArray[4] = Conversions.ToString(now.Day);
        strArray[5] = ".STS2012";
        string str = string.Concat(strArray);
        local.SaveFileName = str;
        if (System.IO.File.Exists(SAP_Module.Proj.SaveFileName))
          System.IO.File.Delete(SAP_Module.Proj.SaveFileName);
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = -1;
        Functions.MakeTree();
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
      }
    }

    public void InitializeOpenFileDialog()
    {
      this.OpenFileDialog1.Filter = "Stroma Excel format (*.XLSX;*.XLS)|*.XLSX;*.XLS|All files (*.*)|*.*";
      this.OpenFileDialog1.Multiselect = true;
      this.OpenFileDialog1.Title = "EXCEL IMPORT";
      this.OpenFileDialog1.FileName = "";
    }

    private void ExcelImportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.InitializeOpenFileDialog();
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.Proj = new SAP_Module.Project();
        SAP_Module.CurrDwelling = 0;
        int num = 0;
        List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
        string[] fileNames = this.OpenFileDialog1.FileNames;
        int index = 0;
        while (index < fileNames.Length)
        {
          string str = fileNames[index];
          SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
          SAP_Module.Dwelling dwelling2 = new ExcelImport().ConvertToDwelling(str.ToString());
          dwellingList.Add(dwelling2);
          checked { ++num; }
          checked { ++index; }
        }
        SAP_Module.Proj.Dwellings = dwellingList.ToArray();
        SAP_Module.Proj.NoOfDwells = dwellingList.Count;
        SAP_Module.Proj.Name = "SAP ExcelImport 2012";
        ref SAP_Module.Project local = ref SAP_Module.Proj;
        string[] strArray = new string[6]
        {
          Environment.GetFolderPath(Environment.SpecialFolder.Personal),
          "\\",
          null,
          null,
          null,
          null
        };
        DateTime now = DateAndTime.Now;
        strArray[2] = Conversions.ToString(now.Year);
        now = DateAndTime.Now;
        strArray[3] = Conversions.ToString(now.Month);
        now = DateAndTime.Now;
        strArray[4] = Conversions.ToString(now.Day);
        strArray[5] = ".STS2012";
        string str1 = string.Concat(strArray);
        local.SaveFileName = str1;
        if (System.IO.File.Exists(SAP_Module.Proj.SaveFileName))
          System.IO.File.Delete(SAP_Module.Proj.SaveFileName);
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = -1;
        Functions.MakeTree();
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
      }
    }

    private void Import2012DwellingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Import2012Frm().ShowDialog();
    }

    private void txtOrientation_SelectedIndexChanged(object sender, EventArgs e)
    {
      string orientation = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
      if (this.@bool && !SAP_Module.ChangeNow && (uint) this.txtOrientation.SelectedIndex > 0U && (uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtOrientation.Text, "", false) > 0U)
      {
        switch (Interaction.MsgBox((object) "Do you want to change the orientation of the openings too?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question, (object) "Orientation change?"))
        {
          case MsgBoxResult.Cancel:
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation = orientation;
            this.@bool = false;
            this.txtOrientation.Text = orientation;
            this.@bool = true;
            return;
          case MsgBoxResult.Yes:
            try
            {
              int orientationChange = this.GetOrientationChange(this.txtOrientation.Text);
              int num1 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
              int index1 = 0;
              while (index1 <= num1)
              {
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index1].Orientation, orientationChange);
                checked { ++index1; }
              }
              int num2 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
              int index2 = 0;
              while (index2 <= num2)
              {
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index2].Orientation, orientationChange);
                checked { ++index2; }
              }
              int num3 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
              int index3 = 0;
              while (index3 <= num3)
              {
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Orientation = this.ChangeOrientation(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index3].Orientation, orientationChange);
                checked { ++index3; }
              }
              try
              {
                if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude)
                {
                  int num4 = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
                  int index4 = 0;
                  while (index4 <= num4)
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
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation = this.txtOrientation.Text;
              SAP_Read.ReadDwellingDetails();
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
              break;
            }
        }
      }
      this.@bool = true;
    }

    private string ChangeOrientation(string Orientation, int Change)
    {
      string str1 = Orientation;
      string str2;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 1128440633:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "North East", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "North West", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "East", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "North", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "West", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Horizontal", false) == 0)
          {
            str2 = "Horizontal";
            break;
          }
          goto default;
        case 2417407149:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "South West", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "South East", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "South", false) == 0)
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

    private int GetOrientationChange(string NewOrientation)
    {
      string orientation = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
      int orientationChange;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(orientation))
      {
        case 1128440633:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North East", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North West", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "East", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "North", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "West", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South West", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South East", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                  goto label_137;
                else
                  goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(orientation, "South", false) == 0)
          {
            string str = NewOrientation;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 1128440633:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North East", false) == 0)
                {
                  orientationChange = 5;
                  break;
                }
                goto label_137;
              case 1409318971:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North West", false) == 0)
                {
                  orientationChange = 3;
                  break;
                }
                goto label_137;
              case 1731397980:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "East", false) == 0)
                {
                  orientationChange = 6;
                  break;
                }
                goto label_137;
              case 1734234020:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "North", false) == 0)
                {
                  orientationChange = 4;
                  break;
                }
                goto label_137;
              case 1796576718:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "West", false) == 0)
                {
                  orientationChange = 2;
                  break;
                }
                goto label_137;
              case 2417407149:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South West", false) == 0)
                {
                  orientationChange = 1;
                  break;
                }
                goto label_137;
              case 2853841879:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South East", false) == 0)
                {
                  orientationChange = 7;
                  break;
                }
                goto label_137;
              case 3017973530:
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "South", false) == 0)
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

    private void ExcelImportToolStripMenuItem1_Click(object sender, EventArgs e)
    {
    }

    private void txtSecPumpHP_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void CSVImportApilcherToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog1.Filter = "Stroma CSV format (*.CSV;*.CSV)|*.CSV;*.CSV|All files (*.*)|*.*";
      this.OpenFileDialog1.Multiselect = true;
      this.OpenFileDialog1.Title = "CSV IMPORT";
      this.OpenFileDialog1.FileName = "";
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.CurrDwelling = 0;
        this.lblhomeWait.Visible = true;
        Application.DoEvents();
        string[] fileNames = this.OpenFileDialog1.FileNames;
        int index = 0;
        while (index < fileNames.Length)
        {
          new ExcelImportAreas().ConvertTCSVPSIToDwelling(fileNames[index].ToString());
          checked { ++index; }
        }
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = 0;
        Functions.MakeTree();
        try
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.Write("");
          ProjectData.ClearProjectError();
        }
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
      }
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.CurrDwelling = 0;
        this.lblhomeWait.Visible = true;
        Application.DoEvents();
        string[] fileNames = this.OpenFileDialog1.FileNames;
        int index = 0;
        while (index < fileNames.Length)
        {
          new ExcelImportAreas().ConvertTCSVToDImAreaDwelling(fileNames[index].ToString());
          checked { ++index; }
        }
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = 0;
        Functions.MakeTree();
        try
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.Write("");
          ProjectData.ClearProjectError();
        }
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
      }
      this.lblhomeWait.Visible = false;
      Application.DoEvents();
      this.InitializeOpenFileDialog();
      this.lblhomeWait.Visible = true;
      Application.DoEvents();
    }

    private void TxtHeatFraction_TextChanged(object sender, EventArgs e)
    {
    }

    private void DERTERKeyResultsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new DER_TER_Results().ShowDialog();
    }

    private void DwellingInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog1.Filter = "Stroma CSV format (*.CSV;*.CSV)|*.CSV;*.CSV|All files (*.*)|*.*";
      this.OpenFileDialog1.Multiselect = true;
      this.OpenFileDialog1.Title = "CSV IMPORT";
      this.OpenFileDialog1.FileName = "";
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.CurrDwelling = 0;
        int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          SAP_Module.Proj.Dwellings[index1].TMP.Type = "";
          SAP_Module.Proj.Dwellings[index1].TMP.UserDefined = 0.0f;
          SAP_Module.Proj.Dwellings[index1].LivingArea = 0.0f;
          SAP_Module.Proj.Dwellings[index1].Storeys = 0;
          SAP_Module.Proj.Dwellings[index1].Ventilation.Shelter = 0.0f;
          SAP_Module.Proj.Dwellings[index1].TrueRoof = false;
          try
          {
            int num2 = ((IEnumerable<SAP_Module.Dimensions>) SAP_Module.Proj.Dwellings[index1].Dims).Count<SAP_Module.Dimensions>();
            int index2 = 0;
            while (index2 <= num2)
            {
              SAP_Module.Proj.Dwellings[index1].Dims[index2] = new SAP_Module.Dimensions();
              checked { ++index2; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index1; }
        }
        this.lblhomeWait.Visible = true;
        Application.DoEvents();
        string[] fileNames = this.OpenFileDialog1.FileNames;
        int index3 = 0;
        while (index3 < fileNames.Length)
        {
          new ExcelImportAreas().ConvertTCSVToDImAreaDwelling(fileNames[index3].ToString());
          checked { ++index3; }
        }
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = 0;
        Functions.MakeTree();
        try
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.Write("");
          ProjectData.ClearProjectError();
        }
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
      }
      this.lblhomeWait.Visible = false;
      Application.DoEvents();
    }

    private void PSIToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog1.Filter = "Stroma CSV format (*.CSV;*.CSV)|*.CSV;*.CSV|All files (*.*)|*.*";
      this.OpenFileDialog1.Multiselect = true;
      this.OpenFileDialog1.Title = "CSV IMPORT";
      this.OpenFileDialog1.FileName = "";
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        int num = checked (SAP_Module.Proj.NoOfDwells - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
          SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
          SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
          checked { ++index1; }
        }
        SAP_Module.CurrDwelling = 0;
        this.lblhomeWait.Visible = true;
        Application.DoEvents();
        string[] fileNames = this.OpenFileDialog1.FileNames;
        int index2 = 0;
        while (index2 < fileNames.Length)
        {
          new ExcelImportAreas().ConvertTCSVPSIToDwelling(fileNames[index2].ToString());
          checked { ++index2; }
        }
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = 0;
        Functions.MakeTree();
        try
        {
          this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.Write("");
          ProjectData.ClearProjectError();
        }
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
      }
      this.lblhomeWait.Visible = false;
      Application.DoEvents();
    }

    private void AreaincludesAllImportsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.InitializeOpenFileDialog();
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        SAP_Module.CurrDwelling = 0;
        this.lblhomeWait.Visible = true;
        Application.DoEvents();
        string[] fileNames = this.OpenFileDialog1.FileNames;
        int index = 0;
        while (index < fileNames.Length)
        {
          new ExcelImportAreas().ConvertTExcelToDwelling(fileNames[index].ToString());
          checked { ++index; }
        }
        SAP_Module.Proj.Name = "SAP ExcelImport 2012";
        ref SAP_Module.Project local = ref SAP_Module.Proj;
        string[] strArray = new string[6]
        {
          Environment.GetFolderPath(Environment.SpecialFolder.Personal),
          "\\",
          null,
          null,
          null,
          null
        };
        DateTime now = DateAndTime.Now;
        strArray[2] = Conversions.ToString(now.Year);
        now = DateAndTime.Now;
        strArray[3] = Conversions.ToString(now.Month);
        now = DateAndTime.Now;
        strArray[4] = Conversions.ToString(now.Day);
        strArray[5] = ".STS2012";
        string str = string.Concat(strArray);
        local.SaveFileName = str;
        if (System.IO.File.Exists(SAP_Module.Proj.SaveFileName))
          System.IO.File.Delete(SAP_Module.Proj.SaveFileName);
        Functions.SaveFile(SAP_Module.Proj, SAP_Module.Proj.SaveFileName);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(SAP_Module.Proj.SaveFileName, "", false) == 0)
          return;
        SAP_Module.Proj = Functions.GetFileContents(SAP_Module.Proj.SaveFileName);
        SAP_Module.CurrDwelling = -1;
        Functions.MakeTree();
        this.TreeSAP.SelectedNode = this.TreeSAP.Nodes[0];
        SAP_Module.Proj.SaveFileName = SAP_Module.Proj.SaveFileName;
        Functions.AddFile(SAP_Module.Proj.SaveFileName);
        this.lblhomeWait.Visible = false;
        Application.DoEvents();
        this.InitializeOpenFileDialog();
        this.lblhomeWait.Visible = true;
        Application.DoEvents();
      }
      this.CSVImportApilcherToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
      this.lblhomeWait.Visible = false;
      Application.DoEvents();
      int num = (int) Interaction.MsgBox((object) "Import is complete.", MsgBoxStyle.Information, (object) "Stroma Certification");
    }

    private void txtStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
      string text = this.txtStatus.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "New dwelling as built", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "New dwelling created by change of use", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "New dwelling design stage", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Existing dwelling (SAP)", false) == 0)
          {
            this.txtAirTest.Text = "Calculated";
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = this.txtAirTest.Text;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MeasuredAir = 0.0f;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir = 0.0f;
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir = 0.0f;
            this.txtAssumedAir.Text = Conversions.ToString(0);
            this.txtDesignAir.Text = Conversions.ToString(0);
            this.txtMeasuredAir.Text = Conversions.ToString(0);
          }
          else
          {
            this.txtAirTest.Text = "";
            this.txtDesignAir.Text = Conversions.ToString(0);
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = "";
          }
        }
        else
        {
          this.txtAirTest.Text = "As designed";
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = this.txtAirTest.Text;
          this.txtMeasuredAir.Text = Conversions.ToString(0);
          this.txtAssumedAir.Text = Conversions.ToString(0);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir = 0.0f;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MeasuredAir = 0.0f;
        }
      }
      else
      {
        this.txtAirTest.Text = "As built";
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = this.txtAirTest.Text;
        this.txtDesignAir.Text = Conversions.ToString(0);
        this.txtAssumedAir.Text = Conversions.ToString(0);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir = 0.0f;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir = 0.0f;
      }
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
      // ISSUE: The method is too long to display (82561 instructions)
    }

    [field: AccessedThroughProperty("MenuStrip1")]
    internal virtual MenuStrip MenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FileToolStripMenuItem")]
    internal virtual ToolStripMenuItem FileToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStrip1")]
    internal virtual ToolStrip ToolStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("StatusStrip1")]
    internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SplitContainer1")]
    internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TreeImages")]
    internal virtual ImageList TreeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem NewToolStripMenuItem
    {
      get => this._NewToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.NewToolStripMenuItem_MouseMove);
        ToolStripMenuItem toolStripMenuItem1 = this._NewToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.MouseMove -= mouseEventHandler;
        this._NewToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._NewToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.MouseMove += mouseEventHandler;
      }
    }

    internal virtual ToolStripMenuItem ProjectToolStripMenuItem
    {
      get => this._ProjectToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ProjectToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ProjectToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ProjectToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ProjectToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem1")]
    internal virtual ToolStripSeparator ToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem DwellingToolStripMenuItem
    {
      get => this._DwellingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DwellingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DwellingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DwellingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DwellingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator1")]
    internal virtual ToolStripSeparator ToolStripSeparator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SaveProjectToolStripMenuItem
    {
      get => this._SaveProjectToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.SaveProjectToolStripMenuItem_Click);
        EventHandler eventHandler2 = new EventHandler(this.TimerAutoSave_Tick);
        ToolStripMenuItem toolStripMenuItem1 = this._SaveProjectToolStripMenuItem;
        if (toolStripMenuItem1 != null)
        {
          toolStripMenuItem1.Click -= eventHandler1;
          toolStripMenuItem1.Click -= eventHandler2;
        }
        this._SaveProjectToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SaveProjectToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler1;
        toolStripMenuItem2.Click += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem2")]
    internal virtual ToolStripSeparator ToolStripMenuItem2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ExitToolStripMenuItem
    {
      get => this._ExitToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ExitToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ExitToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ExitToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton1
    {
      get => this._ToolStripButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click);
        ToolStripButton toolStripButton1_1 = this._ToolStripButton1;
        if (toolStripButton1_1 != null)
          toolStripButton1_1.Click -= eventHandler;
        this._ToolStripButton1 = value;
        ToolStripButton toolStripButton1_2 = this._ToolStripButton1;
        if (toolStripButton1_2 == null)
          return;
        toolStripButton1_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton2
    {
      get => this._ToolStripButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton2_Click);
        ToolStripButton toolStripButton2_1 = this._ToolStripButton2;
        if (toolStripButton2_1 != null)
          toolStripButton2_1.Click -= eventHandler;
        this._ToolStripButton2 = value;
        ToolStripButton toolStripButton2_2 = this._ToolStripButton2;
        if (toolStripButton2_2 == null)
          return;
        toolStripButton2_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator2")]
    internal virtual ToolStripSeparator ToolStripSeparator2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton ToolStripButton3
    {
      get => this._ToolStripButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton3_Click);
        ToolStripButton toolStripButton3_1 = this._ToolStripButton3;
        if (toolStripButton3_1 != null)
          toolStripButton3_1.Click -= eventHandler;
        this._ToolStripButton3 = value;
        ToolStripButton toolStripButton3_2 = this._ToolStripButton3;
        if (toolStripButton3_2 == null)
          return;
        toolStripButton3_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator3")]
    internal virtual ToolStripSeparator ToolStripSeparator3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton ToolStripButton4
    {
      get => this._ToolStripButton4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton4_Click);
        ToolStripButton toolStripButton4_1 = this._ToolStripButton4;
        if (toolStripButton4_1 != null)
          toolStripButton4_1.Click -= eventHandler;
        this._ToolStripButton4 = value;
        ToolStripButton toolStripButton4_2 = this._ToolStripButton4;
        if (toolStripButton4_2 == null)
          return;
        toolStripButton4_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PanelHome")]
    internal virtual Panel PanelHome { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ImageLogo")]
    internal virtual PictureBox ImageLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelProject")]
    internal virtual Panel PanelProject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox3")]
    internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label19")]
    internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCEmail")]
    internal virtual TextBox txtPCEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label18")]
    internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCFax")]
    internal virtual TextBox txtPCFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCPhone")]
    internal virtual TextBox txtPCPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCPCode")]
    internal virtual TextBox txtPCPCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCCountry")]
    internal virtual TextBox txtPCCountry { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCCity")]
    internal virtual TextBox txtPCCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCAdd3")]
    internal virtual TextBox txtPCAdd3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCAdd2")]
    internal virtual TextBox txtPCAdd2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCAdd1")]
    internal virtual TextBox txtPCAdd1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCNAme")]
    internal virtual TextBox txtPCNAme { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox2")]
    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPRef")]
    internal virtual TextBox txtPRef { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtProjName
    {
      get => this._txtProjName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtProjName_LostFocus1);
        EventHandler eventHandler2 = new EventHandler(this.txtProjName_TextChanged);
        TextBox txtProjName1 = this._txtProjName;
        if (txtProjName1 != null)
        {
          txtProjName1.LostFocus -= eventHandler1;
          txtProjName1.TextChanged -= eventHandler2;
        }
        this._txtProjName = value;
        TextBox txtProjName2 = this._txtProjName;
        if (txtProjName2 == null)
          return;
        txtProjName2.LostFocus += eventHandler1;
        txtProjName2.TextChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("GroupBox1")]
    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPPCode")]
    internal virtual TextBox txtPPCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCountry")]
    internal virtual TextBox txtPCountry { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCity")]
    internal virtual TextBox txtPCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPAdd3")]
    internal virtual TextBox txtPAdd3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPAdd2")]
    internal virtual TextBox txtPAdd2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPAdd1")]
    internal virtual TextBox txtPAdd1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelHouseDetails")]
    internal virtual Panel PanelHouseDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDetails")]
    internal virtual Label lblDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox5")]
    internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label29")]
    internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDRef
    {
      get => this._txtDRef;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDRef_LostFocus);
        TextBox txtDref1 = this._txtDRef;
        if (txtDref1 != null)
          txtDref1.LostFocus -= eventHandler;
        this._txtDRef = value;
        TextBox txtDref2 = this._txtDRef;
        if (txtDref2 == null)
          return;
        txtDref2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label30")]
    internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDName
    {
      get => this._txtDName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDName_LostFocus);
        TextBox txtDname1 = this._txtDName;
        if (txtDname1 != null)
          txtDname1.LostFocus -= eventHandler;
        this._txtDName = value;
        TextBox txtDname2 = this._txtDName;
        if (txtDname2 == null)
          return;
        txtDname2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox6")]
    internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label31")]
    internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDPostCode
    {
      get => this._txtDPostCode;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDPostCode_LostFocus);
        TextBox txtDpostCode1 = this._txtDPostCode;
        if (txtDpostCode1 != null)
          txtDpostCode1.LostFocus -= eventHandler;
        this._txtDPostCode = value;
        TextBox txtDpostCode2 = this._txtDPostCode;
        if (txtDpostCode2 == null)
          return;
        txtDpostCode2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label32")]
    internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label33")]
    internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDCity
    {
      get => this._txtDCity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDCity_LostFocus);
        TextBox txtDcity1 = this._txtDCity;
        if (txtDcity1 != null)
          txtDcity1.LostFocus -= eventHandler;
        this._txtDCity = value;
        TextBox txtDcity2 = this._txtDCity;
        if (txtDcity2 == null)
          return;
        txtDcity2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label34")]
    internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDAdd3
    {
      get => this._txtDAdd3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDAdd3_LostFocus);
        TextBox txtDadd3_1 = this._txtDAdd3;
        if (txtDadd3_1 != null)
          txtDadd3_1.LostFocus -= eventHandler;
        this._txtDAdd3 = value;
        TextBox txtDadd3_2 = this._txtDAdd3;
        if (txtDadd3_2 == null)
          return;
        txtDadd3_2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label35")]
    internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDAdd2
    {
      get => this._txtDAdd2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDAdd2_LostFocus);
        TextBox txtDadd2_1 = this._txtDAdd2;
        if (txtDadd2_1 != null)
          txtDadd2_1.LostFocus -= eventHandler;
        this._txtDAdd2 = value;
        TextBox txtDadd2_2 = this._txtDAdd2;
        if (txtDadd2_2 == null)
          return;
        txtDadd2_2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label36")]
    internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtDAdd1
    {
      get => this._txtDAdd1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDAdd1_LostFocus);
        TextBox txtDadd1_1 = this._txtDAdd1;
        if (txtDadd1_1 != null)
          txtDadd1_1.LostFocus -= eventHandler;
        this._txtDAdd1 = value;
        TextBox txtDadd1_2 = this._txtDAdd1;
        if (txtDadd1_2 == null)
          return;
        txtDadd1_2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator4")]
    internal virtual ToolStripSeparator ToolStripSeparator4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton ToolStripButton5
    {
      get => this._ToolStripButton5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton5_Click);
        ToolStripButton toolStripButton5_1 = this._ToolStripButton5;
        if (toolStripButton5_1 != null)
          toolStripButton5_1.Click -= eventHandler;
        this._ToolStripButton5 = value;
        ToolStripButton toolStripButton5_2 = this._ToolStripButton5;
        if (toolStripButton5_2 == null)
          return;
        toolStripButton5_2.Click += eventHandler;
      }
    }

    internal virtual DateTimePicker txtDDate
    {
      get => this._txtDDate;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDDate_LostFocus);
        DateTimePicker txtDdate1 = this._txtDDate;
        if (txtDdate1 != null)
          txtDdate1.LostFocus -= eventHandler;
        this._txtDDate = value;
        DateTimePicker txtDdate2 = this._txtDDate;
        if (txtDdate2 == null)
          return;
        txtDdate2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label37")]
    internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtDCountry
    {
      get => this._txtDCountry;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtDCountry_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtDCountry_SelectedIndexChanged);
        ComboBox txtDcountry1 = this._txtDCountry;
        if (txtDcountry1 != null)
        {
          txtDcountry1.LostFocus -= eventHandler1;
          txtDcountry1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtDCountry = value;
        ComboBox txtDcountry2 = this._txtDCountry;
        if (txtDcountry2 == null)
          return;
        txtDcountry2.LostFocus += eventHandler1;
        txtDcountry2.SelectedIndexChanged += eventHandler2;
      }
    }

    internal virtual Button cmdLongAddress
    {
      get => this._cmdLongAddress;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdLongAddress_MouseLeave);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.cmdLongAddress_MouseMove);
        EventHandler eventHandler2 = new EventHandler(this.cmdLongAddress_Click);
        Button cmdLongAddress1 = this._cmdLongAddress;
        if (cmdLongAddress1 != null)
        {
          cmdLongAddress1.MouseLeave -= eventHandler1;
          cmdLongAddress1.MouseMove -= mouseEventHandler;
          cmdLongAddress1.Click -= eventHandler2;
        }
        this._cmdLongAddress = value;
        Button cmdLongAddress2 = this._cmdLongAddress;
        if (cmdLongAddress2 == null)
          return;
        cmdLongAddress2.MouseLeave += eventHandler1;
        cmdLongAddress2.MouseMove += mouseEventHandler;
        cmdLongAddress2.Click += eventHandler2;
      }
    }

    internal virtual Button cmdShortAddress
    {
      get => this._cmdShortAddress;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdShortAddress_MouseLeave);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.cmdShortAddress_MouseMove);
        EventHandler eventHandler2 = new EventHandler(this.cmdShortAddress_Click);
        Button cmdShortAddress1 = this._cmdShortAddress;
        if (cmdShortAddress1 != null)
        {
          cmdShortAddress1.MouseLeave -= eventHandler1;
          cmdShortAddress1.MouseMove -= mouseEventHandler;
          cmdShortAddress1.Click -= eventHandler2;
        }
        this._cmdShortAddress = value;
        Button cmdShortAddress2 = this._cmdShortAddress;
        if (cmdShortAddress2 == null)
          return;
        cmdShortAddress2.MouseLeave += eventHandler1;
        cmdShortAddress2.MouseMove += mouseEventHandler;
        cmdShortAddress2.Click += eventHandler2;
      }
    }

    internal virtual Button cmdAddressConfirm
    {
      get => this._cmdAddressConfirm;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAddressConfirm_Click);
        Button cmdAddressConfirm1 = this._cmdAddressConfirm;
        if (cmdAddressConfirm1 != null)
          cmdAddressConfirm1.Click -= eventHandler;
        this._cmdAddressConfirm = value;
        Button cmdAddressConfirm2 = this._cmdAddressConfirm;
        if (cmdAddressConfirm2 == null)
          return;
        cmdAddressConfirm2.Click += eventHandler;
      }
    }

    internal virtual ComboBox cboAddress
    {
      get => this._cboAddress;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cboAddress_SelectedIndexChanged);
        ComboBox cboAddress1 = this._cboAddress;
        if (cboAddress1 != null)
          cboAddress1.SelectedIndexChanged -= eventHandler;
        this._cboAddress = value;
        ComboBox cboAddress2 = this._cboAddress;
        if (cboAddress2 == null)
          return;
        cboAddress2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label38")]
    internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtUPRN")]
    internal virtual TextBox txtUPRN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public virtual TreeView TreeSAP
    {
      get => this._TreeSAP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TreeSAP_AfterSelect);
        DragEventHandler dragEventHandler1 = new DragEventHandler(this.TreeSAP_DragDrop);
        DragEventHandler dragEventHandler2 = new DragEventHandler(this.TreeSAP_DragEnter);
        DragEventHandler dragEventHandler3 = new DragEventHandler(this.TreeSAP_DragOver);
        ItemDragEventHandler dragEventHandler4 = new ItemDragEventHandler(this.TreeSAP_ItemDrag);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.TreeSAP_MouseMove);
        TreeView treeSap1 = this._TreeSAP;
        if (treeSap1 != null)
        {
          treeSap1.AfterSelect -= viewEventHandler;
          treeSap1.DragDrop -= dragEventHandler1;
          treeSap1.DragEnter -= dragEventHandler2;
          treeSap1.DragOver -= dragEventHandler3;
          treeSap1.ItemDrag -= dragEventHandler4;
          treeSap1.MouseMove -= mouseEventHandler;
        }
        this._TreeSAP = value;
        TreeView treeSap2 = this._TreeSAP;
        if (treeSap2 == null)
          return;
        treeSap2.AfterSelect += viewEventHandler;
        treeSap2.DragDrop += dragEventHandler1;
        treeSap2.DragEnter += dragEventHandler2;
        treeSap2.DragOver += dragEventHandler3;
        treeSap2.ItemDrag += dragEventHandler4;
        treeSap2.MouseMove += mouseEventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox4")]
    internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label28")]
    internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAssessor")]
    internal virtual TextBox txtAssessor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label21")]
    internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAssUserPass")]
    internal virtual TextBox txtAssUserPass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label20")]
    internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAssUserName")]
    internal virtual TextBox txtAssUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdGetMyDetails
    {
      get => this._cmdGetMyDetails;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdGetMyDetails_Click);
        Button cmdGetMyDetails1 = this._cmdGetMyDetails;
        if (cmdGetMyDetails1 != null)
          cmdGetMyDetails1.Click -= eventHandler;
        this._cmdGetMyDetails = value;
        Button cmdGetMyDetails2 = this._cmdGetMyDetails;
        if (cmdGetMyDetails2 == null)
          return;
        cmdGetMyDetails2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtPleaseWait1")]
    internal virtual TextBox txtPleaseWait1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPleaseWait2")]
    internal virtual TextBox txtPleaseWait2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox7")]
    internal virtual GroupBox GroupBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtBuiltForm
    {
      get => this._txtBuiltForm;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtBuiltForm_LostFocus);
        ComboBox txtBuiltForm1 = this._txtBuiltForm;
        if (txtBuiltForm1 != null)
          txtBuiltForm1.LostFocus -= eventHandler;
        this._txtBuiltForm = value;
        ComboBox txtBuiltForm2 = this._txtBuiltForm;
        if (txtBuiltForm2 == null)
          return;
        txtBuiltForm2.LostFocus += eventHandler;
      }
    }

    internal virtual ComboBox txtPropertyType
    {
      get => this._txtPropertyType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtPropertyType_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtPropertyType_SelectedIndexChanged);
        ComboBox txtPropertyType1 = this._txtPropertyType;
        if (txtPropertyType1 != null)
        {
          txtPropertyType1.LostFocus -= eventHandler1;
          txtPropertyType1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtPropertyType = value;
        ComboBox txtPropertyType2 = this._txtPropertyType;
        if (txtPropertyType2 == null)
          return;
        txtPropertyType2.LostFocus += eventHandler1;
        txtPropertyType2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label23")]
    internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label24")]
    internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtFlatType
    {
      get => this._txtFlatType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtFlatType_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtFlatType_SelectedIndexChanged);
        ComboBox txtFlatType1 = this._txtFlatType;
        if (txtFlatType1 != null)
        {
          txtFlatType1.LostFocus -= eventHandler1;
          txtFlatType1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtFlatType = value;
        ComboBox txtFlatType2 = this._txtFlatType;
        if (txtFlatType2 == null)
          return;
        txtFlatType2.LostFocus += eventHandler1;
        txtFlatType2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label22")]
    internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox8")]
    internal virtual GroupBox GroupBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtTerrain
    {
      get => this._txtTerrain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtTerrain_SelectedIndexChanged);
        ComboBox txtTerrain1 = this._txtTerrain;
        if (txtTerrain1 != null)
          txtTerrain1.SelectedIndexChanged -= eventHandler;
        this._txtTerrain = value;
        ComboBox txtTerrain2 = this._txtTerrain;
        if (txtTerrain2 == null)
          return;
        txtTerrain2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label27")]
    internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtLocation
    {
      get => this._txtLocation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLocation_LostFocus);
        ComboBox txtLocation1 = this._txtLocation;
        if (txtLocation1 != null)
          txtLocation1.LostFocus -= eventHandler;
        this._txtLocation = value;
        ComboBox txtLocation2 = this._txtLocation;
        if (txtLocation2 == null)
          return;
        txtLocation2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label39")]
    internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label40")]
    internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label25")]
    internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox9")]
    internal virtual GroupBox GroupBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label41")]
    internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label42")]
    internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label43")]
    internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSAPOnly
    {
      get => this._txtSAPOnly;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSAPOnly_LostFocus);
        ComboBox txtSapOnly1 = this._txtSAPOnly;
        if (txtSapOnly1 != null)
          txtSapOnly1.LostFocus -= eventHandler;
        this._txtSAPOnly = value;
        ComboBox txtSapOnly2 = this._txtSAPOnly;
        if (txtSapOnly2 == null)
          return;
        txtSapOnly2.LostFocus += eventHandler;
      }
    }

    internal virtual ComboBox txtOverHeat
    {
      get => this._txtOverHeat;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtOverHeat_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtOverHeat_SelectedIndexChanged);
        ComboBox txtOverHeat1 = this._txtOverHeat;
        if (txtOverHeat1 != null)
        {
          txtOverHeat1.LostFocus -= eventHandler1;
          txtOverHeat1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtOverHeat = value;
        ComboBox txtOverHeat2 = this._txtOverHeat;
        if (txtOverHeat2 == null)
          return;
        txtOverHeat2.LostFocus += eventHandler1;
        txtOverHeat2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("PanelDimensions")]
    internal virtual Panel PanelDimensions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox13")]
    internal virtual GroupBox GroupBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtStatus
    {
      get => this._txtStatus;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtStatus_SelectedIndexChanged);
        ComboBox txtStatus1 = this._txtStatus;
        if (txtStatus1 != null)
          txtStatus1.SelectedIndexChanged -= eventHandler;
        this._txtStatus = value;
        ComboBox txtStatus2 = this._txtStatus;
        if (txtStatus2 == null)
          return;
        txtStatus2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual DataGridView Dims
    {
      get => this._Dims;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.Dims_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
        DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.Dims_RowsRemoved);
        DataGridViewColumnEventHandler columnEventHandler = new DataGridViewColumnEventHandler(this.Dims_ColumnWidthChanged);
        DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.Dims_CellContentClick);
        DataGridView dims1 = this._Dims;
        if (dims1 != null)
        {
          dims1.CellEnter -= cellEventHandler1;
          dims1.CellValueChanged -= cellEventHandler2;
          dims1.RowsRemoved -= removedEventHandler;
          dims1.ColumnWidthChanged -= columnEventHandler;
          dims1.CellContentClick -= cellEventHandler3;
        }
        this._Dims = value;
        DataGridView dims2 = this._Dims;
        if (dims2 == null)
          return;
        dims2.CellEnter += cellEventHandler1;
        dims2.CellValueChanged += cellEventHandler2;
        dims2.RowsRemoved += removedEventHandler;
        dims2.ColumnWidthChanged += columnEventHandler;
        dims2.CellContentClick += cellEventHandler3;
      }
    }

    [field: AccessedThroughProperty("GroupBox10")]
    internal virtual GroupBox GroupBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label46")]
    internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDimStoreys")]
    internal virtual TextBox txtDimStoreys { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label49")]
    internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label48")]
    internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label47")]
    internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDimsVolume")]
    internal virtual TextBox txtDimsVolume { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label45")]
    internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDimsArea")]
    internal virtual TextBox txtDimsArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkRoomInRoof
    {
      get => this._chkRoomInRoof;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkRoomInRoof_CheckedChanged);
        CheckBox chkRoomInRoof1 = this._chkRoomInRoof;
        if (chkRoomInRoof1 != null)
          chkRoomInRoof1.CheckedChanged -= eventHandler;
        this._chkRoomInRoof = value;
        CheckBox chkRoomInRoof2 = this._chkRoomInRoof;
        if (chkRoomInRoof2 == null)
          return;
        chkRoomInRoof2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button cmdArea
    {
      get => this._cmdArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdArea_Click);
        Button cmdArea1 = this._cmdArea;
        if (cmdArea1 != null)
          cmdArea1.Click -= eventHandler;
        this._cmdArea = value;
        Button cmdArea2 = this._cmdArea;
        if (cmdArea2 == null)
          return;
        cmdArea2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("PanelElements")]
    internal virtual Panel PanelElements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox12")]
    internal virtual GroupBox GroupBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdFloorArea
    {
      get => this._cmdFloorArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdFloorArea_Click);
        Button cmdFloorArea1 = this._cmdFloorArea;
        if (cmdFloorArea1 != null)
          cmdFloorArea1.Click -= eventHandler;
        this._cmdFloorArea = value;
        Button cmdFloorArea2 = this._cmdFloorArea;
        if (cmdFloorArea2 == null)
          return;
        cmdFloorArea2.Click += eventHandler;
      }
    }

    internal virtual DataGridView Floors
    {
      get => this._Floors;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.Floors_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.Floors_CellValueChanged);
        DataGridViewColumnEventHandler columnEventHandler = new DataGridViewColumnEventHandler(this.Floors_ColumnWidthChanged);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Floors_MouseMove);
        EventHandler eventHandler = new EventHandler(this.Floors_RowHeadersWidthChanged);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.Floors_RowsRemoved);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.Floors_EditingControlShowing);
        DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.Floors_CellContentClick);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.Floors_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Floors_Scroll);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Floors_RowsRemoved1);
        DataGridViewCellMouseEventHandler mouseEventHandler2 = new DataGridViewCellMouseEventHandler(this.Floors_CellMouseClick);
        DataGridView floors1 = this._Floors;
        if (floors1 != null)
        {
          floors1.CellEnter -= cellEventHandler1;
          floors1.CellValueChanged -= cellEventHandler2;
          floors1.ColumnWidthChanged -= columnEventHandler;
          floors1.MouseMove -= mouseEventHandler1;
          floors1.RowHeadersWidthChanged -= eventHandler;
          floors1.RowsRemoved -= removedEventHandler1;
          floors1.EditingControlShowing -= showingEventHandler;
          floors1.CellContentClick -= cellEventHandler3;
          floors1.DataError -= errorEventHandler;
          floors1.Scroll -= scrollEventHandler;
          floors1.RowsRemoved -= removedEventHandler2;
          floors1.CellMouseClick -= mouseEventHandler2;
        }
        this._Floors = value;
        DataGridView floors2 = this._Floors;
        if (floors2 == null)
          return;
        floors2.CellEnter += cellEventHandler1;
        floors2.CellValueChanged += cellEventHandler2;
        floors2.ColumnWidthChanged += columnEventHandler;
        floors2.MouseMove += mouseEventHandler1;
        floors2.RowHeadersWidthChanged += eventHandler;
        floors2.RowsRemoved += removedEventHandler1;
        floors2.EditingControlShowing += showingEventHandler;
        floors2.CellContentClick += cellEventHandler3;
        floors2.DataError += errorEventHandler;
        floors2.Scroll += scrollEventHandler;
        floors2.RowsRemoved += removedEventHandler2;
        floors2.CellMouseClick += mouseEventHandler2;
      }
    }

    [field: AccessedThroughProperty("GroupBox11")]
    internal virtual GroupBox GroupBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdWallArea
    {
      get => this._cmdWallArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdWallArea_Click);
        Button cmdWallArea1 = this._cmdWallArea;
        if (cmdWallArea1 != null)
          cmdWallArea1.Click -= eventHandler;
        this._cmdWallArea = value;
        Button cmdWallArea2 = this._cmdWallArea;
        if (cmdWallArea2 == null)
          return;
        cmdWallArea2.Click += eventHandler;
      }
    }

    internal virtual DataGridView Walls
    {
      get => this._Walls;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.Walls_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.Walls_CellValueChanged);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Walls_MouseMove);
        EventHandler eventHandler = new EventHandler(this.Walls_RowHeadersWidthChanged);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Walls_Scroll);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.Walls_EditingControlShowing);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.Floors_DataError);
        DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.Walls_RowsRemoved1);
        DataGridViewCellMouseEventHandler mouseEventHandler2 = new DataGridViewCellMouseEventHandler(this.walls_CellMouseClick);
        DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.Walls_CellContentClick);
        DataGridView walls1 = this._Walls;
        if (walls1 != null)
        {
          walls1.CellEnter -= cellEventHandler1;
          walls1.CellValueChanged -= cellEventHandler2;
          walls1.MouseMove -= mouseEventHandler1;
          walls1.RowHeadersWidthChanged -= eventHandler;
          walls1.Scroll -= scrollEventHandler;
          walls1.EditingControlShowing -= showingEventHandler;
          walls1.DataError -= errorEventHandler;
          walls1.RowsRemoved -= removedEventHandler;
          walls1.CellMouseClick -= mouseEventHandler2;
          walls1.CellContentClick -= cellEventHandler3;
        }
        this._Walls = value;
        DataGridView walls2 = this._Walls;
        if (walls2 == null)
          return;
        walls2.CellEnter += cellEventHandler1;
        walls2.CellValueChanged += cellEventHandler2;
        walls2.MouseMove += mouseEventHandler1;
        walls2.RowHeadersWidthChanged += eventHandler;
        walls2.Scroll += scrollEventHandler;
        walls2.EditingControlShowing += showingEventHandler;
        walls2.DataError += errorEventHandler;
        walls2.RowsRemoved += removedEventHandler;
        walls2.CellMouseClick += mouseEventHandler2;
        walls2.CellContentClick += cellEventHandler3;
      }
    }

    internal virtual Button cmdWallShelter
    {
      get => this._cmdWallShelter;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdWallShelter_Click);
        Button cmdWallShelter1 = this._cmdWallShelter;
        if (cmdWallShelter1 != null)
          cmdWallShelter1.Click -= eventHandler;
        this._cmdWallShelter = value;
        Button cmdWallShelter2 = this._cmdWallShelter;
        if (cmdWallShelter2 == null)
          return;
        cmdWallShelter2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox14")]
    internal virtual GroupBox GroupBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdRoofShelter
    {
      get => this._cmdRoofShelter;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdRoofShelter_Click);
        Button cmdRoofShelter1 = this._cmdRoofShelter;
        if (cmdRoofShelter1 != null)
          cmdRoofShelter1.Click -= eventHandler;
        this._cmdRoofShelter = value;
        Button cmdRoofShelter2 = this._cmdRoofShelter;
        if (cmdRoofShelter2 == null)
          return;
        cmdRoofShelter2.Click += eventHandler;
      }
    }

    internal virtual Button cmdRoofArea
    {
      get => this._cmdRoofArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdRoofArea_Click);
        Button cmdRoofArea1 = this._cmdRoofArea;
        if (cmdRoofArea1 != null)
          cmdRoofArea1.Click -= eventHandler;
        this._cmdRoofArea = value;
        Button cmdRoofArea2 = this._cmdRoofArea;
        if (cmdRoofArea2 == null)
          return;
        cmdRoofArea2.Click += eventHandler;
      }
    }

    internal virtual DataGridView Roofs
    {
      get => this._Roofs;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.Roofs_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.Roofs_CellValueChanged);
        EventHandler eventHandler = new EventHandler(this.Roofs_RowHeadersWidthChanged);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.Roofs_RowsRemoved);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Roofs_MouseMove);
        DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.Roofs_CellContentClick);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.Roofs_EditingControlShowing);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.Floors_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Roofs_Scroll);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Ceilings_RowsRemoved1);
        DataGridViewCellMouseEventHandler mouseEventHandler2 = new DataGridViewCellMouseEventHandler(this.Roofs_CellMouseClick);
        DataGridView roofs1 = this._Roofs;
        if (roofs1 != null)
        {
          roofs1.CellEnter -= cellEventHandler1;
          roofs1.CellValueChanged -= cellEventHandler2;
          roofs1.RowHeadersWidthChanged -= eventHandler;
          roofs1.RowsRemoved -= removedEventHandler1;
          roofs1.MouseMove -= mouseEventHandler1;
          roofs1.CellContentClick -= cellEventHandler3;
          roofs1.EditingControlShowing -= showingEventHandler;
          roofs1.DataError -= errorEventHandler;
          roofs1.Scroll -= scrollEventHandler;
          roofs1.RowsRemoved -= removedEventHandler2;
          roofs1.CellMouseClick -= mouseEventHandler2;
        }
        this._Roofs = value;
        DataGridView roofs2 = this._Roofs;
        if (roofs2 == null)
          return;
        roofs2.CellEnter += cellEventHandler1;
        roofs2.CellValueChanged += cellEventHandler2;
        roofs2.RowHeadersWidthChanged += eventHandler;
        roofs2.RowsRemoved += removedEventHandler1;
        roofs2.MouseMove += mouseEventHandler1;
        roofs2.CellContentClick += cellEventHandler3;
        roofs2.EditingControlShowing += showingEventHandler;
        roofs2.DataError += errorEventHandler;
        roofs2.Scroll += scrollEventHandler;
        roofs2.RowsRemoved += removedEventHandler2;
        roofs2.CellMouseClick += mouseEventHandler2;
      }
    }

    [field: AccessedThroughProperty("SaveFileDialog1")]
    internal virtual SaveFileDialog SaveFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("OpenFileDialog1")]
    internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem OpenProjectToolStripMenuItem
    {
      get => this._OpenProjectToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenProjectToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._OpenProjectToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._OpenProjectToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._OpenProjectToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => this._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SaveAsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SaveAsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SaveAsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem3")]
    internal virtual ToolStripSeparator ToolStripMenuItem3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("BindingSource1")]
    internal virtual BindingSource BindingSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelHeating")]
    internal virtual Panel PanelHeating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl2")]
    internal virtual TabControl TabControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabMainHeating")]
    internal virtual TabPage TabMainHeating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox15")]
    internal virtual GroupBox GroupBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtPrimary
    {
      get => this._txtPrimary;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtPrimary_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtPrimary_SelectedIndexChanged);
        ComboBox txtPrimary1 = this._txtPrimary;
        if (txtPrimary1 != null)
        {
          txtPrimary1.LostFocus -= eventHandler1;
          txtPrimary1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtPrimary = value;
        ComboBox txtPrimary2 = this._txtPrimary;
        if (txtPrimary2 == null)
          return;
        txtPrimary2.LostFocus += eventHandler1;
        txtPrimary2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label52")]
    internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label53")]
    internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSubGroup
    {
      get => this._txtSubGroup;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtSubGroup_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtSubGroup_SelectedIndexChanged);
        ComboBox txtSubGroup1 = this._txtSubGroup;
        if (txtSubGroup1 != null)
        {
          txtSubGroup1.LostFocus -= eventHandler1;
          txtSubGroup1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtSubGroup = value;
        ComboBox txtSubGroup2 = this._txtSubGroup;
        if (txtSubGroup2 == null)
          return;
        txtSubGroup2.LostFocus += eventHandler1;
        txtSubGroup2.SelectedIndexChanged += eventHandler2;
      }
    }

    internal virtual Button cmdBiolerData
    {
      get => this._cmdBiolerData;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdBiolerData_Click);
        Button cmdBiolerData1 = this._cmdBiolerData;
        if (cmdBiolerData1 != null)
          cmdBiolerData1.Click -= eventHandler;
        this._cmdBiolerData = value;
        Button cmdBiolerData2 = this._cmdBiolerData;
        if (cmdBiolerData2 == null)
          return;
        cmdBiolerData2.Click += eventHandler;
      }
    }

    internal virtual ComboBox txtHeatingSource
    {
      get => this._txtHeatingSource;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtHeatingSource_LostFocus);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtHeatingSource_MouseDown);
        EventHandler eventHandler2 = new EventHandler(this.txtHeatingSource_SelectedIndexChanged);
        ComboBox txtHeatingSource1 = this._txtHeatingSource;
        if (txtHeatingSource1 != null)
        {
          txtHeatingSource1.LostFocus -= eventHandler1;
          txtHeatingSource1.MouseDown -= mouseEventHandler;
          txtHeatingSource1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtHeatingSource = value;
        ComboBox txtHeatingSource2 = this._txtHeatingSource;
        if (txtHeatingSource2 == null)
          return;
        txtHeatingSource2.LostFocus += eventHandler1;
        txtHeatingSource2.MouseDown += mouseEventHandler;
        txtHeatingSource2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label50")]
    internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelOpenings")]
    internal virtual Panel PanelOpenings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox18")]
    internal virtual GroupBox GroupBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStrip2")]
    internal virtual ToolStrip ToolStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripLabel1")]
    internal virtual ToolStripLabel ToolStripLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripSeparator5")]
    internal virtual ToolStripSeparator ToolStripSeparator5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdNewDoor
    {
      get => this._cmdNewDoor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdNewDoor_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdNewDoor1 = this._cmdNewDoor;
        if (cmdNewDoor1 != null)
        {
          cmdNewDoor1.Click -= eventHandler1;
          cmdNewDoor1.MouseEnter -= eventHandler2;
          cmdNewDoor1.MouseLeave -= eventHandler3;
        }
        this._cmdNewDoor = value;
        ToolStripButton cmdNewDoor2 = this._cmdNewDoor;
        if (cmdNewDoor2 == null)
          return;
        cmdNewDoor2.Click += eventHandler1;
        cmdNewDoor2.MouseEnter += eventHandler2;
        cmdNewDoor2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator6")]
    internal virtual ToolStripSeparator ToolStripSeparator6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdDeleteDoor
    {
      get => this._cmdDeleteDoor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdDeleteDoor_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdDeleteDoor1 = this._cmdDeleteDoor;
        if (cmdDeleteDoor1 != null)
        {
          cmdDeleteDoor1.Click -= eventHandler1;
          cmdDeleteDoor1.MouseEnter -= eventHandler2;
          cmdDeleteDoor1.MouseLeave -= eventHandler3;
        }
        this._cmdDeleteDoor = value;
        ToolStripButton cmdDeleteDoor2 = this._cmdDeleteDoor;
        if (cmdDeleteDoor2 == null)
          return;
        cmdDeleteDoor2.Click += eventHandler1;
        cmdDeleteDoor2.MouseEnter += eventHandler2;
        cmdDeleteDoor2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator7")]
    internal virtual ToolStripSeparator ToolStripSeparator7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox17")]
    internal virtual GroupBox GroupBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStrip4")]
    internal virtual ToolStrip ToolStrip4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripLabel3")]
    internal virtual ToolStripLabel ToolStripLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripSeparator11")]
    internal virtual ToolStripSeparator ToolStripSeparator11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdNewRoofLight
    {
      get => this._cmdNewRoofLight;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdNewRoofLight_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdNewRoofLight1 = this._cmdNewRoofLight;
        if (cmdNewRoofLight1 != null)
        {
          cmdNewRoofLight1.Click -= eventHandler1;
          cmdNewRoofLight1.MouseEnter -= eventHandler2;
          cmdNewRoofLight1.MouseLeave -= eventHandler3;
        }
        this._cmdNewRoofLight = value;
        ToolStripButton cmdNewRoofLight2 = this._cmdNewRoofLight;
        if (cmdNewRoofLight2 == null)
          return;
        cmdNewRoofLight2.Click += eventHandler1;
        cmdNewRoofLight2.MouseEnter += eventHandler2;
        cmdNewRoofLight2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator12")]
    internal virtual ToolStripSeparator ToolStripSeparator12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdDeleteRoofLight
    {
      get => this._cmdDeleteRoofLight;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdDeleteRoofLight_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdDeleteRoofLight1 = this._cmdDeleteRoofLight;
        if (cmdDeleteRoofLight1 != null)
        {
          cmdDeleteRoofLight1.Click -= eventHandler1;
          cmdDeleteRoofLight1.MouseEnter -= eventHandler2;
          cmdDeleteRoofLight1.MouseLeave -= eventHandler3;
        }
        this._cmdDeleteRoofLight = value;
        ToolStripButton cmdDeleteRoofLight2 = this._cmdDeleteRoofLight;
        if (cmdDeleteRoofLight2 == null)
          return;
        cmdDeleteRoofLight2.Click += eventHandler1;
        cmdDeleteRoofLight2.MouseEnter += eventHandler2;
        cmdDeleteRoofLight2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator13")]
    internal virtual ToolStripSeparator ToolStripSeparator13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox16")]
    internal virtual GroupBox GroupBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStrip3")]
    internal virtual ToolStrip ToolStrip3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripLabel2")]
    internal virtual ToolStripLabel ToolStripLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripSeparator8")]
    internal virtual ToolStripSeparator ToolStripSeparator8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdNewWindow
    {
      get => this._cmdNewWindow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdNewWindow_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdNewWindow1 = this._cmdNewWindow;
        if (cmdNewWindow1 != null)
        {
          cmdNewWindow1.Click -= eventHandler1;
          cmdNewWindow1.MouseEnter -= eventHandler2;
          cmdNewWindow1.MouseLeave -= eventHandler3;
        }
        this._cmdNewWindow = value;
        ToolStripButton cmdNewWindow2 = this._cmdNewWindow;
        if (cmdNewWindow2 == null)
          return;
        cmdNewWindow2.Click += eventHandler1;
        cmdNewWindow2.MouseEnter += eventHandler2;
        cmdNewWindow2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator9")]
    internal virtual ToolStripSeparator ToolStripSeparator9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdDeleteWindow
    {
      get => this._cmdDeleteWindow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdDeleteWindow_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdDeleteWindow1 = this._cmdDeleteWindow;
        if (cmdDeleteWindow1 != null)
        {
          cmdDeleteWindow1.Click -= eventHandler1;
          cmdDeleteWindow1.MouseEnter -= eventHandler2;
          cmdDeleteWindow1.MouseLeave -= eventHandler3;
        }
        this._cmdDeleteWindow = value;
        ToolStripButton cmdDeleteWindow2 = this._cmdDeleteWindow;
        if (cmdDeleteWindow2 == null)
          return;
        cmdDeleteWindow2.Click += eventHandler1;
        cmdDeleteWindow2.MouseEnter += eventHandler2;
        cmdDeleteWindow2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator10")]
    internal virtual ToolStripSeparator ToolStripSeparator10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public virtual DataGridView DataDoors
    {
      get => this._DataDoors;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DataDoors_DoubleClick);
        DataGridView dataDoors1 = this._DataDoors;
        if (dataDoors1 != null)
          dataDoors1.DoubleClick -= eventHandler;
        this._DataDoors = value;
        DataGridView dataDoors2 = this._DataDoors;
        if (dataDoors2 == null)
          return;
        dataDoors2.DoubleClick += eventHandler;
      }
    }

    public virtual DataGridView DataRoofLights
    {
      get => this._DataRoofLights;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DataRoofLights_DoubleClick);
        DataGridView dataRoofLights1 = this._DataRoofLights;
        if (dataRoofLights1 != null)
          dataRoofLights1.DoubleClick -= eventHandler;
        this._DataRoofLights = value;
        DataGridView dataRoofLights2 = this._DataRoofLights;
        if (dataRoofLights2 == null)
          return;
        dataRoofLights2.DoubleClick += eventHandler;
      }
    }

    public virtual DataGridView DataWindows
    {
      get => this._DataWindows;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DataWindows_DoubleClick);
        DataGridView dataWindows1 = this._DataWindows;
        if (dataWindows1 != null)
          dataWindows1.DoubleClick -= eventHandler;
        this._DataWindows = value;
        DataGridView dataWindows2 = this._DataWindows;
        if (dataWindows2 == null)
          return;
        dataWindows2.DoubleClick += eventHandler;
      }
    }

    internal virtual ToolStripButton cmdEditDoor
    {
      get => this._cmdEditDoor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdEditDoor_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdEditDoor1 = this._cmdEditDoor;
        if (cmdEditDoor1 != null)
        {
          cmdEditDoor1.Click -= eventHandler1;
          cmdEditDoor1.MouseEnter -= eventHandler2;
          cmdEditDoor1.MouseLeave -= eventHandler3;
        }
        this._cmdEditDoor = value;
        ToolStripButton cmdEditDoor2 = this._cmdEditDoor;
        if (cmdEditDoor2 == null)
          return;
        cmdEditDoor2.Click += eventHandler1;
        cmdEditDoor2.MouseEnter += eventHandler2;
        cmdEditDoor2.MouseLeave += eventHandler3;
      }
    }

    internal virtual ToolStripButton cmdEditRoofLight
    {
      get => this._cmdEditRoofLight;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdEditRoofLight_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdEditRoofLight1 = this._cmdEditRoofLight;
        if (cmdEditRoofLight1 != null)
        {
          cmdEditRoofLight1.Click -= eventHandler1;
          cmdEditRoofLight1.MouseEnter -= eventHandler2;
          cmdEditRoofLight1.MouseLeave -= eventHandler3;
        }
        this._cmdEditRoofLight = value;
        ToolStripButton cmdEditRoofLight2 = this._cmdEditRoofLight;
        if (cmdEditRoofLight2 == null)
          return;
        cmdEditRoofLight2.Click += eventHandler1;
        cmdEditRoofLight2.MouseEnter += eventHandler2;
        cmdEditRoofLight2.MouseLeave += eventHandler3;
      }
    }

    internal virtual ToolStripButton cmdEditWindow
    {
      get => this._cmdEditWindow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdEditWindow_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdNewDoor_MouseEnter);
        EventHandler eventHandler3 = new EventHandler(this.cmdNewDoor_MouseLeave);
        ToolStripButton cmdEditWindow1 = this._cmdEditWindow;
        if (cmdEditWindow1 != null)
        {
          cmdEditWindow1.Click -= eventHandler1;
          cmdEditWindow1.MouseEnter -= eventHandler2;
          cmdEditWindow1.MouseLeave -= eventHandler3;
        }
        this._cmdEditWindow = value;
        ToolStripButton cmdEditWindow2 = this._cmdEditWindow;
        if (cmdEditWindow2 == null)
          return;
        cmdEditWindow2.Click += eventHandler1;
        cmdEditWindow2.MouseEnter += eventHandler2;
        cmdEditWindow2.MouseLeave += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("PanelVentilation")]
    internal virtual Panel PanelVentilation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox22")]
    internal virtual GroupBox GroupBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label67")]
    internal virtual Label Label67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label56")]
    internal virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtNoofFlueGasFires
    {
      get => this._txtNoofFlueGasFires;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofFlueGasFires_ValueChanged);
        NumericUpDown noofFlueGasFires1 = this._txtNoofFlueGasFires;
        if (noofFlueGasFires1 != null)
          noofFlueGasFires1.ValueChanged -= eventHandler;
        this._txtNoofFlueGasFires = value;
        NumericUpDown noofFlueGasFires2 = this._txtNoofFlueGasFires;
        if (noofFlueGasFires2 == null)
          return;
        noofFlueGasFires2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label55")]
    internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtNoofPassiveVents
    {
      get => this._txtNoofPassiveVents;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofPassiveVents_ValueChanged);
        NumericUpDown noofPassiveVents1 = this._txtNoofPassiveVents;
        if (noofPassiveVents1 != null)
          noofPassiveVents1.ValueChanged -= eventHandler;
        this._txtNoofPassiveVents = value;
        NumericUpDown noofPassiveVents2 = this._txtNoofPassiveVents;
        if (noofPassiveVents2 == null)
          return;
        noofPassiveVents2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label54")]
    internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtNoofFans
    {
      get => this._txtNoofFans;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofFans_ValueChanged);
        NumericUpDown txtNoofFans1 = this._txtNoofFans;
        if (txtNoofFans1 != null)
          txtNoofFans1.ValueChanged -= eventHandler;
        this._txtNoofFans = value;
        NumericUpDown txtNoofFans2 = this._txtNoofFans;
        if (txtNoofFans2 == null)
          return;
        txtNoofFans2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label51")]
    internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtNoofOpenFlues
    {
      get => this._txtNoofOpenFlues;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofOpenFlues_ValueChanged);
        NumericUpDown txtNoofOpenFlues1 = this._txtNoofOpenFlues;
        if (txtNoofOpenFlues1 != null)
          txtNoofOpenFlues1.ValueChanged -= eventHandler;
        this._txtNoofOpenFlues = value;
        NumericUpDown txtNoofOpenFlues2 = this._txtNoofOpenFlues;
        if (txtNoofOpenFlues2 == null)
          return;
        txtNoofOpenFlues2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtNoofChmneys
    {
      get => this._txtNoofChmneys;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofChmneys_ValueChanged);
        NumericUpDown txtNoofChmneys1 = this._txtNoofChmneys;
        if (txtNoofChmneys1 != null)
          txtNoofChmneys1.ValueChanged -= eventHandler;
        this._txtNoofChmneys = value;
        NumericUpDown txtNoofChmneys2 = this._txtNoofChmneys;
        if (txtNoofChmneys2 == null)
          return;
        txtNoofChmneys2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label57")]
    internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtNoofShelteredSides
    {
      get => this._txtNoofShelteredSides;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofShelteredSides_LostFocus);
        TextBox noofShelteredSides1 = this._txtNoofShelteredSides;
        if (noofShelteredSides1 != null)
          noofShelteredSides1.LostFocus -= eventHandler;
        this._txtNoofShelteredSides = value;
        TextBox noofShelteredSides2 = this._txtNoofShelteredSides;
        if (noofShelteredSides2 == null)
          return;
        noofShelteredSides2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox19")]
    internal virtual GroupBox GroupBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtMechVentilation
    {
      get => this._txtMechVentilation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtMechVentilation_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtMechVentilation_SelectedIndexChanged);
        ComboBox txtMechVentilation1 = this._txtMechVentilation;
        if (txtMechVentilation1 != null)
        {
          txtMechVentilation1.LostFocus -= eventHandler1;
          txtMechVentilation1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtMechVentilation = value;
        ComboBox txtMechVentilation2 = this._txtMechVentilation;
        if (txtMechVentilation2 == null)
          return;
        txtMechVentilation2.LostFocus += eventHandler1;
        txtMechVentilation2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label63")]
    internal virtual Label Label63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtWetRooms
    {
      get => this._txtWetRooms;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtWetRooms_ValueChanged_1);
        NumericUpDown txtWetRooms1 = this._txtWetRooms;
        if (txtWetRooms1 != null)
          txtWetRooms1.ValueChanged -= eventHandler;
        this._txtWetRooms = value;
        NumericUpDown txtWetRooms2 = this._txtWetRooms;
        if (txtWetRooms2 == null)
          return;
        txtWetRooms2.ValueChanged += eventHandler;
      }
    }

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

    internal virtual ComboBox txtDuctInsulation
    {
      get => this._txtDuctInsulation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDuctInsulation_LostFocus);
        ComboBox txtDuctInsulation1 = this._txtDuctInsulation;
        if (txtDuctInsulation1 != null)
          txtDuctInsulation1.LostFocus -= eventHandler;
        this._txtDuctInsulation = value;
        ComboBox txtDuctInsulation2 = this._txtDuctInsulation;
        if (txtDuctInsulation2 == null)
          return;
        txtDuctInsulation2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label60")]
    internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label59")]
    internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtParamters
    {
      get => this._txtParamters;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtParamters_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtParamters_SelectedIndexChanged);
        ComboBox txtParamters1 = this._txtParamters;
        if (txtParamters1 != null)
        {
          txtParamters1.LostFocus -= eventHandler1;
          txtParamters1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtParamters = value;
        ComboBox txtParamters2 = this._txtParamters;
        if (txtParamters2 == null)
          return;
        txtParamters2.LostFocus += eventHandler1;
        txtParamters2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label58")]
    internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox20")]
    internal virtual GroupBox GroupBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label lblDataProduct
    {
      get => this._lblDataProduct;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblDataProduct_Click);
        Label lblDataProduct1 = this._lblDataProduct;
        if (lblDataProduct1 != null)
          lblDataProduct1.Click -= eventHandler;
        this._lblDataProduct = value;
        Label lblDataProduct2 = this._lblDataProduct;
        if (lblDataProduct2 == null)
          return;
        lblDataProduct2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label70")]
    internal virtual Label Label70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label66")]
    internal virtual Label Label66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMeasuredAir")]
    internal virtual TextBox txtMeasuredAir { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label68")]
    internal virtual Label Label68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label65")]
    internal virtual Label Label65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDesignAir")]
    internal virtual TextBox txtDesignAir { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label64")]
    internal virtual Label Label64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtStatus1")]
    internal virtual TextBox txtStatus1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label62")]
    internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtAirTest
    {
      get => this._txtAirTest;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtAirTest_SelectedIndexChanged);
        ComboBox txtAirTest1 = this._txtAirTest;
        if (txtAirTest1 != null)
          txtAirTest1.SelectedIndexChanged -= eventHandler;
        this._txtAirTest = value;
        ComboBox txtAirTest2 = this._txtAirTest;
        if (txtAirTest2 == null)
          return;
        txtAirTest2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label61")]
    internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPressureDate")]
    internal virtual DateTimePicker txtPressureDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox21")]
    internal virtual GroupBox GroupBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label74")]
    internal virtual Label Label74 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtShelteredSides
    {
      get => this._txtShelteredSides;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtShelteredSides_LostFocus);
        NumericUpDown txtShelteredSides1 = this._txtShelteredSides;
        if (txtShelteredSides1 != null)
          txtShelteredSides1.LostFocus -= eventHandler;
        this._txtShelteredSides = value;
        NumericUpDown txtShelteredSides2 = this._txtShelteredSides;
        if (txtShelteredSides2 == null)
          return;
        txtShelteredSides2.LostFocus += eventHandler;
      }
    }

    internal virtual NumericUpDown txtYearBuilt
    {
      get => this._txtYearBuilt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtYearBuilt_LostFocus1);
        NumericUpDown txtYearBuilt1 = this._txtYearBuilt;
        if (txtYearBuilt1 != null)
          txtYearBuilt1.LostFocus -= eventHandler;
        this._txtYearBuilt = value;
        NumericUpDown txtYearBuilt2 = this._txtYearBuilt;
        if (txtYearBuilt2 == null)
          return;
        txtYearBuilt2.LostFocus += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtDraught")]
    internal virtual TextBox txtDraught { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelWater")]
    internal virtual Panel PanelWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtMainHeatingType
    {
      get => this._txtMainHeatingType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtMainHeatingType_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtMainHeatingType_MarginChanged);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtMainHeatingType_MouseUp);
        EventHandler eventHandler3 = new EventHandler(this.txtMainHeatingType_SelectedIndexChanged);
        EventHandler eventHandler4 = new EventHandler(this.txtMainHeatingType_SelectionChangeCommitted);
        ComboBox txtMainHeatingType1 = this._txtMainHeatingType;
        if (txtMainHeatingType1 != null)
        {
          txtMainHeatingType1.LostFocus -= eventHandler1;
          txtMainHeatingType1.MarginChanged -= eventHandler2;
          txtMainHeatingType1.MouseUp -= mouseEventHandler;
          txtMainHeatingType1.SelectedIndexChanged -= eventHandler3;
          txtMainHeatingType1.SelectionChangeCommitted -= eventHandler4;
        }
        this._txtMainHeatingType = value;
        ComboBox txtMainHeatingType2 = this._txtMainHeatingType;
        if (txtMainHeatingType2 == null)
          return;
        txtMainHeatingType2.LostFocus += eventHandler1;
        txtMainHeatingType2.MarginChanged += eventHandler2;
        txtMainHeatingType2.MouseUp += mouseEventHandler;
        txtMainHeatingType2.SelectedIndexChanged += eventHandler3;
        txtMainHeatingType2.SelectionChangeCommitted += eventHandler4;
      }
    }

    [field: AccessedThroughProperty("Label26")]
    internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox23")]
    internal virtual GroupBox GroupBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtMainFuel
    {
      get => this._txtMainFuel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtMainFuel_LostFocus);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtMainFuel_MouseDown);
        EventHandler eventHandler2 = new EventHandler(this.txtMainFuel_SelectedIndexChanged);
        EventHandler eventHandler3 = new EventHandler(this.txtMainFuel_TextChanged);
        ComboBox txtMainFuel1 = this._txtMainFuel;
        if (txtMainFuel1 != null)
        {
          txtMainFuel1.LostFocus -= eventHandler1;
          txtMainFuel1.MouseDown -= mouseEventHandler;
          txtMainFuel1.SelectedIndexChanged -= eventHandler2;
          txtMainFuel1.TextChanged -= eventHandler3;
        }
        this._txtMainFuel = value;
        ComboBox txtMainFuel2 = this._txtMainFuel;
        if (txtMainFuel2 == null)
          return;
        txtMainFuel2.LostFocus += eventHandler1;
        txtMainFuel2.MouseDown += mouseEventHandler;
        txtMainFuel2.SelectedIndexChanged += eventHandler2;
        txtMainFuel2.TextChanged += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("Label72")]
    internal virtual Label Label72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox24")]
    internal virtual GroupBox GroupBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtHeatingControls
    {
      get => this._txtHeatingControls;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtHeatingControls_LostFocus);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtHeatingControls_MouseDown);
        EventHandler eventHandler2 = new EventHandler(this.txtHeatingControls_SelectedIndexChanged);
        ComboBox txtHeatingControls1 = this._txtHeatingControls;
        if (txtHeatingControls1 != null)
        {
          txtHeatingControls1.LostFocus -= eventHandler1;
          txtHeatingControls1.MouseDown -= mouseEventHandler;
          txtHeatingControls1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtHeatingControls = value;
        ComboBox txtHeatingControls2 = this._txtHeatingControls;
        if (txtHeatingControls2 == null)
          return;
        txtHeatingControls2.LostFocus += eventHandler1;
        txtHeatingControls2.MouseDown += mouseEventHandler;
        txtHeatingControls2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label44")]
    internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtHeatingEmitter
    {
      get => this._txtHeatingEmitter;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtHeatingEmitter_LostFocus);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtHeatingEmitter_MouseClick);
        EventHandler eventHandler2 = new EventHandler(this.txtHeatingEmitter_SelectedIndexChanged);
        ComboBox txtHeatingEmitter1 = this._txtHeatingEmitter;
        if (txtHeatingEmitter1 != null)
        {
          txtHeatingEmitter1.LostFocus -= eventHandler1;
          txtHeatingEmitter1.MouseClick -= mouseEventHandler;
          txtHeatingEmitter1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtHeatingEmitter = value;
        ComboBox txtHeatingEmitter2 = this._txtHeatingEmitter;
        if (txtHeatingEmitter2 == null)
          return;
        txtHeatingEmitter2.LostFocus += eventHandler1;
        txtHeatingEmitter2.MouseClick += mouseEventHandler;
        txtHeatingEmitter2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label69")]
    internal virtual Label Label69 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtBoilerSub
    {
      get => this._txtBoilerSub;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtBoilerSub_Click);
        EventHandler eventHandler2 = new EventHandler(this.txtBoilerSub_SelectedIndexChanged);
        ComboBox txtBoilerSub1 = this._txtBoilerSub;
        if (txtBoilerSub1 != null)
        {
          txtBoilerSub1.Click -= eventHandler1;
          txtBoilerSub1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtBoilerSub = value;
        ComboBox txtBoilerSub2 = this._txtBoilerSub;
        if (txtBoilerSub2 == null)
          return;
        txtBoilerSub2.Click += eventHandler1;
        txtBoilerSub2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label71")]
    internal virtual Label Label71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PEn")]
    internal virtual Label PEn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("En")]
    internal virtual Label En { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PSAP")]
    internal virtual Label PSAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SAP")]
    internal virtual Label SAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [field: AccessedThroughProperty("TextBox1")]
    internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox25")]
    internal virtual GroupBox GroupBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("recs")]
    internal virtual DataGridView recs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label73")]
    internal virtual Label Label73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCDate")]
    internal virtual DateTimePicker txtCDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtRPD")]
    internal virtual ComboBox txtRPD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label76")]
    internal virtual Label Label76 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTransaction")]
    internal virtual ComboBox txtTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label75")]
    internal virtual Label Label75 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtOrientation
    {
      get => this._txtOrientation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtOrientation_MouseLeave);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtOrientation_MouseMove);
        EventHandler eventHandler2 = new EventHandler(this.txtOrientation_SelectedIndexChanged);
        ComboBox txtOrientation1 = this._txtOrientation;
        if (txtOrientation1 != null)
        {
          txtOrientation1.MouseLeave -= eventHandler1;
          txtOrientation1.MouseMove -= mouseEventHandler;
          txtOrientation1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtOrientation = value;
        ComboBox txtOrientation2 = this._txtOrientation;
        if (txtOrientation2 == null)
          return;
        txtOrientation2.MouseLeave += eventHandler1;
        txtOrientation2.MouseMove += mouseEventHandler;
        txtOrientation2.SelectedIndexChanged += eventHandler2;
      }
    }

    internal virtual Label Label77
    {
      get => this._Label77;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label77_MouseLeave);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Label77_MouseMove);
        Label label77_1 = this._Label77;
        if (label77_1 != null)
        {
          label77_1.MouseLeave -= eventHandler;
          label77_1.MouseMove -= mouseEventHandler;
        }
        this._Label77 = value;
        Label label77_2 = this._Label77;
        if (label77_2 == null)
          return;
        label77_2.MouseLeave += eventHandler;
        label77_2.MouseMove += mouseEventHandler;
      }
    }

    [field: AccessedThroughProperty("Label78")]
    internal virtual Label Label78 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label79")]
    internal virtual Label Label79 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtLivingFraction
    {
      get => this._txtLivingFraction;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtLivingFraction_KeyDown);
        EventHandler eventHandler = new EventHandler(this.txtLivingFraction_TextChanged);
        TextBox txtLivingFraction1 = this._txtLivingFraction;
        if (txtLivingFraction1 != null)
        {
          txtLivingFraction1.KeyDown -= keyEventHandler;
          txtLivingFraction1.TextChanged -= eventHandler;
        }
        this._txtLivingFraction = value;
        TextBox txtLivingFraction2 = this._txtLivingFraction;
        if (txtLivingFraction2 == null)
          return;
        txtLivingFraction2.KeyDown += keyEventHandler;
        txtLivingFraction2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label80")]
    internal virtual Label Label80 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtLivingArea
    {
      get => this._txtLivingArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtLivingArea_KeyDown);
        EventHandler eventHandler = new EventHandler(this.txtLivingArea_TextChanged);
        TextBox txtLivingArea1 = this._txtLivingArea;
        if (txtLivingArea1 != null)
        {
          txtLivingArea1.KeyDown -= keyEventHandler;
          txtLivingArea1.TextChanged -= eventHandler;
        }
        this._txtLivingArea = value;
        TextBox txtLivingArea2 = this._txtLivingArea;
        if (txtLivingArea2 == null)
          return;
        txtLivingArea2.KeyDown += keyEventHandler;
        txtLivingArea2.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkGross
    {
      get => this._chkGross;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkGross_CheckedChanged);
        CheckBox chkGross1 = this._chkGross;
        if (chkGross1 != null)
          chkGross1.CheckedChanged -= eventHandler;
        this._chkGross = value;
        CheckBox chkGross2 = this._chkGross;
        if (chkGross2 == null)
          return;
        chkGross2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox28")]
    internal virtual GroupBox GroupBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox27")]
    internal virtual GroupBox GroupBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdHtb
    {
      get => this._cmdHtb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdHtb_Click);
        Button cmdHtb1 = this._cmdHtb;
        if (cmdHtb1 != null)
          cmdHtb1.Click -= eventHandler;
        this._cmdHtb = value;
        Button cmdHtb2 = this._cmdHtb;
        if (cmdHtb2 == null)
          return;
        cmdHtb2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtHtb")]
    internal virtual TextBox txtHtb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label81")]
    internal virtual Label Label81 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkHtb
    {
      get => this._chkHtb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkHtb_CheckedChanged);
        CheckBox chkHtb1 = this._chkHtb;
        if (chkHtb1 != null)
          chkHtb1.CheckedChanged -= eventHandler;
        this._chkHtb = value;
        CheckBox chkHtb2 = this._chkHtb;
        if (chkHtb2 == null)
          return;
        chkHtb2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chky
    {
      get => this._chky;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chky_CheckedChanged);
        CheckBox chky1 = this._chky;
        if (chky1 != null)
          chky1.CheckedChanged -= eventHandler;
        this._chky = value;
        CheckBox chky2 = this._chky;
        if (chky2 == null)
          return;
        chky2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox txtConstDetails
    {
      get => this._txtConstDetails;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtConstDetails_TextChanged);
        ComboBox txtConstDetails1 = this._txtConstDetails;
        if (txtConstDetails1 != null)
          txtConstDetails1.TextChanged -= eventHandler;
        this._txtConstDetails = value;
        ComboBox txtConstDetails2 = this._txtConstDetails;
        if (txtConstDetails2 == null)
          return;
        txtConstDetails2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label89")]
    internal virtual Label Label89 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txty")]
    internal virtual TextBox txty { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label88")]
    internal virtual Label Label88 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpBoilerInfo")]
    internal virtual GroupBox grpBoilerInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtBILock")]
    internal virtual ComboBox txtBILock { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtPumpHP
    {
      get => this._txtPumpHP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtPumpHP_SelectedIndexChanged);
        ComboBox txtPumpHp1 = this._txtPumpHP;
        if (txtPumpHp1 != null)
          txtPumpHp1.SelectedIndexChanged -= eventHandler;
        this._txtPumpHP = value;
        ComboBox txtPumpHp2 = this._txtPumpHP;
        if (txtPumpHp2 == null)
          return;
        txtPumpHp2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label94")]
    internal virtual Label Label94 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label95")]
    internal virtual Label Label95 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpBoiler")]
    internal virtual GroupBox grpBoiler { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataInfo")]
    internal virtual DataGridView DataInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ManuFac")]
    internal virtual Panel ManuFac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDescription")]
    internal virtual TextBox txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label90")]
    internal virtual Label Label90 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpEfficiency")]
    internal virtual GroupBox grpEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtEfficiency
    {
      get => this._txtEfficiency;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtEfficiency_TextChanged);
        TextBox txtEfficiency1 = this._txtEfficiency;
        if (txtEfficiency1 != null)
          txtEfficiency1.TextChanged -= eventHandler;
        this._txtEfficiency = value;
        TextBox txtEfficiency2 = this._txtEfficiency;
        if (txtEfficiency2 == null)
          return;
        txtEfficiency2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label91")]
    internal virtual Label Label91 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtBFlueType")]
    internal virtual ComboBox txtBFlueType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label92")]
    internal virtual Label Label92 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label93")]
    internal virtual Label Label93 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox31")]
    internal virtual GroupBox GroupBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label96")]
    internal virtual Label Label96 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSEfficiency")]
    internal virtual TextBox txtSEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label97")]
    internal virtual Label Label97 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox32")]
    internal virtual GroupBox GroupBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSMainHeatingType
    {
      get => this._txtSMainHeatingType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSMainHeatingType_SelectedIndexChanged);
        ComboBox smainHeatingType1 = this._txtSMainHeatingType;
        if (smainHeatingType1 != null)
          smainHeatingType1.SelectedIndexChanged -= eventHandler;
        this._txtSMainHeatingType = value;
        ComboBox smainHeatingType2 = this._txtSMainHeatingType;
        if (smainHeatingType2 == null)
          return;
        smainHeatingType2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label100")]
    internal virtual Label Label100 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSHeatingSource
    {
      get => this._txtSHeatingSource;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSHeatingSource_SelectedIndexChanged);
        ComboBox txtSheatingSource1 = this._txtSHeatingSource;
        if (txtSheatingSource1 != null)
          txtSheatingSource1.SelectedIndexChanged -= eventHandler;
        this._txtSHeatingSource = value;
        ComboBox txtSheatingSource2 = this._txtSHeatingSource;
        if (txtSheatingSource2 == null)
          return;
        txtSheatingSource2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label101")]
    internal virtual Label Label101 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSSubGroup
    {
      get => this._txtSSubGroup;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSSubGroup_SelectedIndexChanged);
        ComboBox txtSsubGroup1 = this._txtSSubGroup;
        if (txtSsubGroup1 != null)
          txtSsubGroup1.SelectedIndexChanged -= eventHandler;
        this._txtSSubGroup = value;
        ComboBox txtSsubGroup2 = this._txtSSubGroup;
        if (txtSsubGroup2 == null)
          return;
        txtSsubGroup2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox txtSPrimary
    {
      get => this._txtSPrimary;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSPrimary_SelectedIndexChanged);
        ComboBox txtSprimary1 = this._txtSPrimary;
        if (txtSprimary1 != null)
          txtSprimary1.SelectedIndexChanged -= eventHandler;
        this._txtSPrimary = value;
        ComboBox txtSprimary2 = this._txtSPrimary;
        if (txtSprimary2 == null)
          return;
        txtSprimary2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label102")]
    internal virtual Label Label102 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label103")]
    internal virtual Label Label103 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox33")]
    internal virtual GroupBox GroupBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSMainFuel
    {
      get => this._txtSMainFuel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtSMainFuel_LostFocus);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.txtSMainFuel_MouseDown);
        EventHandler eventHandler2 = new EventHandler(this.txtSMainFuel_SelectedIndexChanged);
        ComboBox txtSmainFuel1 = this._txtSMainFuel;
        if (txtSmainFuel1 != null)
        {
          txtSmainFuel1.LostFocus -= eventHandler1;
          txtSmainFuel1.MouseDown -= mouseEventHandler;
          txtSmainFuel1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtSMainFuel = value;
        ComboBox txtSmainFuel2 = this._txtSMainFuel;
        if (txtSmainFuel2 == null)
          return;
        txtSmainFuel2.LostFocus += eventHandler1;
        txtSmainFuel2.MouseDown += mouseEventHandler;
        txtSmainFuel2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label98")]
    internal virtual Label Label98 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdClearSecondary
    {
      get => this._cmdClearSecondary;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdClearSecondary_Click);
        Button cmdClearSecondary1 = this._cmdClearSecondary;
        if (cmdClearSecondary1 != null)
          cmdClearSecondary1.Click -= eventHandler;
        this._cmdClearSecondary = value;
        Button cmdClearSecondary2 = this._cmdClearSecondary;
        if (cmdClearSecondary2 == null)
          return;
        cmdClearSecondary2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox34")]
    internal virtual GroupBox GroupBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label104")]
    internal virtual Label Label104 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtHETAS
    {
      get => this._txtHETAS;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtHETAS_SelectedIndexChanged);
        ComboBox txtHetas1 = this._txtHETAS;
        if (txtHetas1 != null)
          txtHetas1.SelectedIndexChanged -= eventHandler;
        this._txtHETAS = value;
        ComboBox txtHetas2 = this._txtHETAS;
        if (txtHetas2 == null)
          return;
        txtHetas2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpManuDescription")]
    internal virtual GroupBox grpManuDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSDescription")]
    internal virtual TextBox txtSDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label99")]
    internal virtual Label Label99 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelOverheating")]
    internal virtual Panel PanelOverheating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox26")]
    internal virtual GroupBox GroupBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWaterFuel")]
    internal virtual ComboBox txtWaterFuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtWater
    {
      get => this._txtWater;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtWater_SelectedIndexChanged);
        EventHandler eventHandler2 = new EventHandler(this.chkDHWCommCylinder_CheckedChanged);
        ComboBox txtWater1 = this._txtWater;
        if (txtWater1 != null)
        {
          txtWater1.SelectedIndexChanged -= eventHandler1;
          txtWater1.SelectedIndexChanged -= eventHandler2;
        }
        this._txtWater = value;
        ComboBox txtWater2 = this._txtWater;
        if (txtWater2 == null)
          return;
        txtWater2.SelectedIndexChanged += eventHandler1;
        txtWater2.SelectedIndexChanged += eventHandler2;
      }
    }

    [field: AccessedThroughProperty("Label86")]
    internal virtual Label Label86 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label87")]
    internal virtual Label Label87 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl1")]
    internal virtual TabControl TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TabPage TabPage1
    {
      get => this._TabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TabPage1_Click);
        TabPage tabPage1_1 = this._TabPage1;
        if (tabPage1_1 != null)
          tabPage1_1.Click -= eventHandler;
        this._TabPage1 = value;
        TabPage tabPage1_2 = this._TabPage1;
        if (tabPage1_2 == null)
          return;
        tabPage1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox35")]
    internal virtual GroupBox GroupBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkSolar
    {
      get => this._chkSolar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSolar_CheckedChanged);
        CheckBox chkSolar1 = this._chkSolar;
        if (chkSolar1 != null)
          chkSolar1.CheckedChanged -= eventHandler;
        this._chkSolar = value;
        CheckBox chkSolar2 = this._chkSolar;
        if (chkSolar2 == null)
          return;
        chkSolar2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox txtSolarType
    {
      get => this._txtSolarType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSolarType_SelectedIndexChanged);
        ComboBox txtSolarType1 = this._txtSolarType;
        if (txtSolarType1 != null)
          txtSolarType1.SelectedIndexChanged -= eventHandler;
        this._txtSolarType = value;
        ComboBox txtSolarType2 = this._txtSolarType;
        if (txtSolarType2 == null)
          return;
        txtSolarType2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label106")]
    internal virtual Label Label106 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label107")]
    internal virtual Label Label107 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarHLoss")]
    internal virtual TextBox txtSolarHLoss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label108")]
    internal virtual Label Label108 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarZero")]
    internal virtual TextBox txtSolarZero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarArea")]
    internal virtual TextBox txtSolarArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label110")]
    internal virtual Label Label110 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label109")]
    internal virtual Label Label109 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarTilt")]
    internal virtual ComboBox txtSolarTilt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label105")]
    internal virtual Label Label105 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSolarGross")]
    internal virtual CheckBox chkSolarGross { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label111")]
    internal virtual Label Label111 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarOrientation")]
    internal virtual ComboBox txtSolarOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label112")]
    internal virtual Label Label112 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarOvershading")]
    internal virtual ComboBox txtSolarOvershading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label113")]
    internal virtual Label Label113 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label114")]
    internal virtual Label Label114 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarVolume")]
    internal virtual TextBox txtSolarVolume { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label115")]
    internal virtual Label Label115 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkSolarOveride
    {
      get => this._chkSolarOveride;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSolarOveride_CheckedChanged);
        CheckBox chkSolarOveride1 = this._chkSolarOveride;
        if (chkSolarOveride1 != null)
          chkSolarOveride1.CheckedChanged -= eventHandler;
        this._chkSolarOveride = value;
        CheckBox chkSolarOveride2 = this._chkSolarOveride;
        if (chkSolarOveride2 == null)
          return;
        chkSolarOveride2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chkSolarSeperate")]
    internal virtual CheckBox chkSolarSeperate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SplitContainer2")]
    internal virtual SplitContainer SplitContainer2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox36")]
    internal virtual GroupBox GroupBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual ComboBox txtElectricityTariff
    {
      get => this._txtElectricityTariff;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtElectricityTariff_SelectedIndexChanged);
        ComboBox electricityTariff1 = this._txtElectricityTariff;
        if (electricityTariff1 != null)
          electricityTariff1.SelectedIndexChanged -= eventHandler;
        this._txtElectricityTariff = value;
        ComboBox electricityTariff2 = this._txtElectricityTariff;
        if (electricityTariff2 == null)
          return;
        electricityTariff2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label82")]
    internal virtual Label Label82 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelRenewable")]
    internal virtual Panel PanelRenewable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox37")]
    internal virtual GroupBox GroupBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPCOrientation")]
    internal virtual ComboBox txtPCOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label116")]
    internal virtual Label Label116 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPTilt")]
    internal virtual ComboBox txtPTilt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label117")]
    internal virtual Label Label117 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPPower")]
    internal virtual TextBox txtPPower { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPOvershading")]
    internal virtual ComboBox txtPOvershading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label122")]
    internal virtual Label Label122 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label123")]
    internal virtual Label Label123 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkPInclude
    {
      get => this._chkPInclude;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkPInclude_CheckedChanged);
        CheckBox chkPinclude1 = this._chkPInclude;
        if (chkPinclude1 != null)
          chkPinclude1.CheckedChanged -= eventHandler;
        this._chkPInclude = value;
        CheckBox chkPinclude2 = this._chkPInclude;
        if (chkPinclude2 == null)
          return;
        chkPinclude2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label83")]
    internal virtual Label Label83 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox38")]
    internal virtual GroupBox GroupBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label118")]
    internal virtual Label Label118 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label119")]
    internal virtual Label Label119 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label120")]
    internal virtual Label Label120 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkWInclude
    {
      get => this._chkWInclude;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkWInclude_CheckedChanged);
        CheckBox chkWinclude1 = this._chkWInclude;
        if (chkWinclude1 != null)
          chkWinclude1.CheckedChanged -= eventHandler;
        this._chkWInclude = value;
        CheckBox chkWinclude2 = this._chkWInclude;
        if (chkWinclude2 == null)
          return;
        chkWinclude2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label121")]
    internal virtual Label Label121 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWHeight")]
    internal virtual TextBox txtWHeight { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label84")]
    internal virtual Label Label84 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWRDiameter")]
    internal virtual TextBox txtWRDiameter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWNumber")]
    internal virtual NumericUpDown txtWNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox39")]
    internal virtual GroupBox GroupBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label85")]
    internal virtual Label Label85 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label124")]
    internal virtual Label Label124 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSpFUsed")]
    internal virtual ComboBox txtSpFUsed { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSpFSaved")]
    internal virtual ComboBox txtSpFSaved { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label126")]
    internal virtual Label Label126 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSpESaved")]
    internal virtual TextBox txtSpESaved { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label127")]
    internal virtual Label Label127 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkSpecial
    {
      get => this._chkSpecial;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSpecial_CheckedChanged);
        CheckBox chkSpecial1 = this._chkSpecial;
        if (chkSpecial1 != null)
          chkSpecial1.CheckedChanged -= eventHandler;
        this._chkSpecial = value;
        CheckBox chkSpecial2 = this._chkSpecial;
        if (chkSpecial2 == null)
          return;
        chkSpecial2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label125")]
    internal virtual Label Label125 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSpEUsed")]
    internal virtual TextBox txtSpEUsed { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label128")]
    internal virtual Label Label128 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSpDescription")]
    internal virtual TextBox txtSpDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label129")]
    internal virtual Label Label129 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox40")]
    internal virtual GroupBox GroupBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label130")]
    internal virtual Label Label130 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAAEGArea")]
    internal virtual TextBox txtAAEGArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label131")]
    internal virtual Label Label131 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAAEGGenerated")]
    internal virtual TextBox txtAAEGGenerated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label132")]
    internal virtual Label Label132 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label133")]
    internal virtual Label Label133 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkAAEGInclude
    {
      get => this._chkAAEGInclude;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkAAEGInclude_CheckedChanged);
        CheckBox chkAaegInclude1 = this._chkAAEGInclude;
        if (chkAaegInclude1 != null)
          chkAaegInclude1.CheckedChanged -= eventHandler;
        this._chkAAEGInclude = value;
        CheckBox chkAaegInclude2 = this._chkAAEGInclude;
        if (chkAaegInclude2 == null)
          return;
        chkAaegInclude2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox41")]
    internal virtual GroupBox GroupBox41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox43")]
    internal virtual GroupBox GroupBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label139")]
    internal virtual Label Label139 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox42")]
    internal virtual GroupBox GroupBox42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label134")]
    internal virtual Label Label134 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtOverAirType
    {
      get => this._txtOverAirType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOverAirType_SelectedIndexChanged);
        ComboBox txtOverAirType1 = this._txtOverAirType;
        if (txtOverAirType1 != null)
          txtOverAirType1.SelectedIndexChanged -= eventHandler;
        this._txtOverAirType = value;
        ComboBox txtOverAirType2 = this._txtOverAirType;
        if (txtOverAirType2 == null)
          return;
        txtOverAirType2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label136")]
    internal virtual Label Label136 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtOverAirWindow
    {
      get => this._txtOverAirWindow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtOverAirWindow_SelectedIndexChanged);
        ComboBox txtOverAirWindow1 = this._txtOverAirWindow;
        if (txtOverAirWindow1 != null)
          txtOverAirWindow1.SelectedIndexChanged -= eventHandler;
        this._txtOverAirWindow = value;
        ComboBox txtOverAirWindow2 = this._txtOverAirWindow;
        if (txtOverAirWindow2 == null)
          return;
        txtOverAirWindow2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label137")]
    internal virtual Label Label137 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtOverAirach")]
    internal virtual TextBox txtOverAirach { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label138")]
    internal virtual Label Label138 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkOverOveride
    {
      get => this._chkOverOveride;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkOverOveride_CheckedChanged);
        CheckBox chkOverOveride1 = this._chkOverOveride;
        if (chkOverOveride1 != null)
          chkOverOveride1.CheckedChanged -= eventHandler;
        this._chkOverOveride = value;
        CheckBox chkOverOveride2 = this._chkOverOveride;
        if (chkOverOveride2 == null)
          return;
        chkOverOveride2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkOverThermalOveride
    {
      get => this._chkOverThermalOveride;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkOverThermalOveride_CheckedChanged);
        CheckBox overThermalOveride1 = this._chkOverThermalOveride;
        if (overThermalOveride1 != null)
          overThermalOveride1.CheckedChanged -= eventHandler;
        this._chkOverThermalOveride = value;
        CheckBox overThermalOveride2 = this._chkOverThermalOveride;
        if (overThermalOveride2 == null)
          return;
        overThermalOveride2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label135")]
    internal virtual Label Label135 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtOverThermalTMP")]
    internal virtual TextBox txtOverThermalTMP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label140")]
    internal virtual Label Label140 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView dataGridConstruction
    {
      get => this._dataGridConstruction;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.dataGridConstruction_CellContentClick);
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.dataGridConstruction_CellMouseUp);
        DataGridView gridConstruction1 = this._dataGridConstruction;
        if (gridConstruction1 != null)
        {
          gridConstruction1.CellContentClick -= cellEventHandler;
          gridConstruction1.CellMouseUp -= mouseEventHandler;
        }
        this._dataGridConstruction = value;
        DataGridView gridConstruction2 = this._dataGridConstruction;
        if (gridConstruction2 == null)
          return;
        gridConstruction2.CellContentClick += cellEventHandler;
        gridConstruction2.CellMouseUp += mouseEventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox44")]
    internal virtual GroupBox GroupBox44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtConservatory")]
    internal virtual ComboBox txtConservatory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label144")]
    internal virtual Label Label144 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFixedAirCon")]
    internal virtual ComboBox txtFixedAirCon { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label141")]
    internal virtual Label Label141 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label143")]
    internal virtual Label Label143 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLowEnergyLight")]
    internal virtual TextBox txtLowEnergyLight { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label142")]
    internal virtual Label Label142 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtEPCLanguage")]
    internal virtual ComboBox txtEPCLanguage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label145")]
    internal virtual Label Label145 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFanFlued")]
    internal virtual ComboBox txtFanFlued { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label146")]
    internal virtual Label Label146 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCylinder")]
    internal virtual GroupBox grpCylinder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label147")]
    internal virtual Label Label147 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCyInsulation")]
    internal virtual ComboBox txtCyInsulation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label151")]
    internal virtual Label Label151 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCyVolume")]
    internal virtual TextBox txtCyVolume { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label149")]
    internal virtual Label Label149 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label150")]
    internal virtual Label Label150 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCyDLoss")]
    internal virtual TextBox txtCyDLoss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label148")]
    internal virtual Label Label148 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox optCyManuLoss
    {
      get => this._optCyManuLoss;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.optCyManuLoss_CheckedChanged);
        CheckBox optCyManuLoss1 = this._optCyManuLoss;
        if (optCyManuLoss1 != null)
          optCyManuLoss1.CheckedChanged -= eventHandler;
        this._optCyManuLoss = value;
        CheckBox optCyManuLoss2 = this._optCyManuLoss;
        if (optCyManuLoss2 == null)
          return;
        optCyManuLoss2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox optCyPipeWork
    {
      get => this._optCyPipeWork;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.optCyPipeWork_CheckedChanged);
        CheckBox optCyPipeWork1 = this._optCyPipeWork;
        if (optCyPipeWork1 != null)
          optCyPipeWork1.CheckedChanged -= eventHandler;
        this._optCyPipeWork = value;
        CheckBox optCyPipeWork2 = this._optCyPipeWork;
        if (optCyPipeWork2 == null)
          return;
        optCyPipeWork2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("optCyHSpace")]
    internal virtual CheckBox optCyHSpace { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("optCyThermostat")]
    internal virtual CheckBox optCyThermostat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label153")]
    internal virtual Label Label153 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox txtCyInsThick
    {
      get => this._txtCyInsThick;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtCyInsThick_TextChanged);
        TextBox txtCyInsThick1 = this._txtCyInsThick;
        if (txtCyInsThick1 != null)
          txtCyInsThick1.TextChanged -= eventHandler;
        this._txtCyInsThick = value;
        TextBox txtCyInsThick2 = this._txtCyInsThick;
        if (txtCyInsThick2 == null)
          return;
        txtCyInsThick2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label152")]
    internal virtual Label Label152 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("optCyTimed")]
    internal virtual CheckBox optCyTimed { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Storey")]
    internal virtual DataGridViewTextBoxColumn Storey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Basement")]
    internal virtual DataGridViewComboBoxColumn Basement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Area")]
    internal virtual DataGridViewTextBoxColumn Area { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Height")]
    internal virtual DataGridViewTextBoxColumn Height { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Volume")]
    internal virtual DataGridViewTextBoxColumn Volume { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label154")]
    internal virtual Label Label154 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAssumedAir")]
    internal virtual TextBox txtAssumedAir { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label155")]
    internal virtual Label Label155 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpHETASMain")]
    internal virtual GroupBox grpHETASMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtHETASMain
    {
      get => this._txtHETASMain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtHETASMain_SelectedIndexChanged);
        ComboBox txtHetasMain1 = this._txtHETASMain;
        if (txtHetasMain1 != null)
          txtHetasMain1.SelectedIndexChanged -= eventHandler;
        this._txtHETASMain = value;
        ComboBox txtHetasMain2 = this._txtHETASMain;
        if (txtHetasMain2 == null)
          return;
        txtHetasMain2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label156")]
    internal virtual Label Label156 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtImmersion")]
    internal virtual ComboBox txtImmersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label157")]
    internal virtual Label Label157 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox optCySummer
    {
      get => this._optCySummer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.optCySummer_CheckedChanged);
        CheckBox optCySummer1 = this._optCySummer;
        if (optCySummer1 != null)
          optCySummer1.CheckedChanged -= eventHandler;
        this._optCySummer = value;
        CheckBox optCySummer2 = this._optCySummer;
        if (optCySummer2 == null)
          return;
        optCySummer2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtSmokeArea")]
    internal virtual ComboBox txtSmokeArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label158")]
    internal virtual Label Label158 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStrip5")]
    internal virtual ToolStrip ToolStrip5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdExpandAll
    {
      get => this._cmdExpandAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdExpandAll_Click);
        ToolStripButton cmdExpandAll1 = this._cmdExpandAll;
        if (cmdExpandAll1 != null)
          cmdExpandAll1.Click -= eventHandler;
        this._cmdExpandAll = value;
        ToolStripButton cmdExpandAll2 = this._cmdExpandAll;
        if (cmdExpandAll2 == null)
          return;
        cmdExpandAll2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton cmdCollapseAll
    {
      get => this._cmdCollapseAll;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdCollapseAll_Click);
        ToolStripButton cmdCollapseAll1 = this._cmdCollapseAll;
        if (cmdCollapseAll1 != null)
          cmdCollapseAll1.Click -= eventHandler;
        this._cmdCollapseAll = value;
        ToolStripButton cmdCollapseAll2 = this._cmdCollapseAll;
        if (cmdCollapseAll2 == null)
          return;
        cmdCollapseAll2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpKeepHot")]
    internal virtual GroupBox grpKeepHot { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkKeepHot
    {
      get => this._chkKeepHot;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkKeepHot_CheckedChanged);
        CheckBox chkKeepHot1 = this._chkKeepHot;
        if (chkKeepHot1 != null)
          chkKeepHot1.CheckedChanged -= eventHandler;
        this._chkKeepHot = value;
        CheckBox chkKeepHot2 = this._chkKeepHot;
        if (chkKeepHot2 == null)
          return;
        chkKeepHot2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkKeepHotTimed
    {
      get => this._chkKeepHotTimed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkKeepHotTimed_CheckedChanged);
        CheckBox chkKeepHotTimed1 = this._chkKeepHotTimed;
        if (chkKeepHotTimed1 != null)
          chkKeepHotTimed1.CheckedChanged -= eventHandler;
        this._chkKeepHotTimed = value;
        CheckBox chkKeepHotTimed2 = this._chkKeepHotTimed;
        if (chkKeepHotTimed2 == null)
          return;
        chkKeepHotTimed2.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox txtKeepHotFuel
    {
      get => this._txtKeepHotFuel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtKeepHotFuel_SelectedIndexChanged);
        ComboBox txtKeepHotFuel1 = this._txtKeepHotFuel;
        if (txtKeepHotFuel1 != null)
          txtKeepHotFuel1.SelectedIndexChanged -= eventHandler;
        this._txtKeepHotFuel = value;
        ComboBox txtKeepHotFuel2 = this._txtKeepHotFuel;
        if (txtKeepHotFuel2 == null)
          return;
        txtKeepHotFuel2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label161")]
    internal virtual Label Label161 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtThermalReference")]
    internal virtual TextBox txtThermalReference { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label162")]
    internal virtual Label Label162 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDetails")]
    internal virtual GroupBox grpDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDetLobby")]
    internal virtual ComboBox txtDetLobby { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label166")]
    internal virtual Label Label166 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDetPercentDraught")]
    internal virtual TextBox txtDetPercentDraught { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label167")]
    internal virtual Label Label167 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label170")]
    internal virtual Label Label170 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDetConstruction")]
    internal virtual ComboBox txtDetConstruction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label171")]
    internal virtual Label Label171 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDetFloor")]
    internal virtual ComboBox txtDetFloor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label163")]
    internal virtual Label Label163 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSolarPump")]
    internal virtual CheckBox chkSolarPump { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FunctionsToolStripMenuItem")]
    internal virtual ToolStripMenuItem FunctionsToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem CopyDwellingToolStripMenuItem
    {
      get => this._CopyDwellingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopyDwellingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._CopyDwellingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._CopyDwellingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._CopyDwellingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpMechDetails")]
    internal virtual GroupBox grpMechDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechProductName")]
    internal virtual TextBox txtMechProductName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label165")]
    internal virtual Label Label165 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label168")]
    internal virtual Label Label168 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDucting")]
    internal virtual ComboBox txtMechDucting { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label169")]
    internal virtual Label Label169 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label172")]
    internal virtual Label Label172 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label173")]
    internal virtual Label Label173 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechFan")]
    internal virtual TextBox txtMechFan { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechHeat")]
    internal virtual TextBox txtMechHeat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDecentralised")]
    internal virtual GroupBox grpDecentralised { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label164")]
    internal virtual Label Label164 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox46")]
    internal virtual GroupBox GroupBox46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecKTF1")]
    internal virtual NumericUpDown txtMechDecKTF1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecKSPF1")]
    internal virtual TextBox txtMechDecKSPF1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label175")]
    internal virtual Label Label175 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label174")]
    internal virtual Label Label174 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecKTF2")]
    internal virtual NumericUpDown txtMechDecKTF2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecKSPF2")]
    internal virtual TextBox txtMechDecKSPF2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox47")]
    internal virtual GroupBox GroupBox47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label179")]
    internal virtual Label Label179 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label180")]
    internal virtual Label Label180 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label181")]
    internal virtual Label Label181 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecOTF3")]
    internal virtual NumericUpDown txtMechDecOTF3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecOSPF3")]
    internal virtual TextBox txtMechDecOSPF3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecOTF2")]
    internal virtual NumericUpDown txtMechDecOTF2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecOSPF2")]
    internal virtual TextBox txtMechDecOSPF2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label182")]
    internal virtual Label Label182 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label183")]
    internal virtual Label Label183 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecOTF1")]
    internal virtual NumericUpDown txtMechDecOTF1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecOSPF1")]
    internal virtual TextBox txtMechDecOSPF1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label178")]
    internal virtual Label Label178 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label177")]
    internal virtual Label Label177 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label176")]
    internal virtual Label Label176 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecKTF3")]
    internal virtual NumericUpDown txtMechDecKTF3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMechDecKSPF3")]
    internal virtual TextBox txtMechDecKSPF3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkDelayedStart")]
    internal virtual CheckBox chkDelayedStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpRange")]
    internal virtual GroupBox grpRange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label193")]
    internal virtual Label Label193 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtRangeWater")]
    internal virtual TextBox txtRangeWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label194")]
    internal virtual Label Label194 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label190")]
    internal virtual Label Label190 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtRangeCase")]
    internal virtual TextBox txtRangeCase { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label192")]
    internal virtual Label Label192 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCompensator")]
    internal virtual GroupBox grpCompensator { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtCompensator
    {
      get => this._txtCompensator;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtCompensator_SelectedIndexChanged);
        ComboBox txtCompensator1 = this._txtCompensator;
        if (txtCompensator1 != null)
          txtCompensator1.SelectedIndexChanged -= eventHandler;
        this._txtCompensator = value;
        ComboBox txtCompensator2 = this._txtCompensator;
        if (txtCompensator2 == null)
          return;
        txtCompensator2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label195")]
    internal virtual Label Label195 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpHeapPumpImmersion")]
    internal virtual GroupBox grpHeapPumpImmersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtHeatPumpImmersion")]
    internal virtual ComboBox txtHeatPumpImmersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label196")]
    internal virtual Label Label196 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommH")]
    internal virtual GroupBox grpCommH { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label197")]
    internal virtual Label Label197 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHCHPHEfficiency")]
    internal virtual TextBox txtCommHCHPHEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label198")]
    internal virtual Label Label198 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label199")]
    internal virtual Label Label199 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHCHPEEfficiency")]
    internal virtual TextBox txtCommHCHPEEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label200")]
    internal virtual Label Label200 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHCHPHFraction")]
    internal virtual TextBox txtCommHCHPHFraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label202")]
    internal virtual Label Label202 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHDS")]
    internal virtual ComboBox txtCommHDS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label203")]
    internal virtual Label Label203 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label204")]
    internal virtual Label Label204 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHB2Efficiency")]
    internal virtual TextBox txtCommHB2Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label205")]
    internal virtual Label Label205 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHB1HFraction")]
    internal virtual TextBox txtCommHB1HFraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label207")]
    internal virtual Label Label207 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label208")]
    internal virtual Label Label208 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHB1Efficiency")]
    internal virtual TextBox txtCommHB1Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label209")]
    internal virtual Label Label209 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkCommHBoiler2
    {
      get => this._chkCommHBoiler2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkCommHBoiler2_CheckedChanged);
        CheckBox chkCommHboiler2_1 = this._chkCommHBoiler2;
        if (chkCommHboiler2_1 != null)
          chkCommHboiler2_1.CheckedChanged -= eventHandler;
        this._chkCommHBoiler2 = value;
        CheckBox chkCommHboiler2_2 = this._chkCommHBoiler2;
        if (chkCommHboiler2_2 == null)
          return;
        chkCommHboiler2_2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtCommHB2Fuel")]
    internal virtual ComboBox txtCommHB2Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label210")]
    internal virtual Label Label210 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCHP")]
    internal virtual GroupBox grpCHP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataInfoSub")]
    internal virtual DataGridView DataInfoSub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkMainHLoadWeather
    {
      get => this._chkMainHLoadWeather;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkMainHLoadWeather_CheckedChanged);
        CheckBox mainHloadWeather1 = this._chkMainHLoadWeather;
        if (mainHloadWeather1 != null)
          mainHloadWeather1.CheckedChanged -= eventHandler;
        this._chkMainHLoadWeather = value;
        CheckBox mainHloadWeather2 = this._chkMainHLoadWeather;
        if (mainHloadWeather2 == null)
          return;
        mainHloadWeather2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chkOilPump")]
    internal virtual CheckBox chkOilPump { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG1")]
    internal virtual PropertyGrid PG1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem CleanToolStripMenuItem
    {
      get => this._CleanToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CleanToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._CleanToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._CleanToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._CleanToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripComboBox ToolStripComboBox1
    {
      get => this._ToolStripComboBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripComboBox1_SelectedIndexChanged);
        ToolStripComboBox toolStripComboBox1_1 = this._ToolStripComboBox1;
        if (toolStripComboBox1_1 != null)
          toolStripComboBox1_1.SelectedIndexChanged -= eventHandler;
        this._ToolStripComboBox1 = value;
        ToolStripComboBox toolStripComboBox1_2 = this._ToolStripComboBox1;
        if (toolStripComboBox1_2 == null)
          return;
        toolStripComboBox1_2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabControl3")]
    internal virtual TabControl TabControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage3")]
    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage5")]
    internal virtual TabPage TabPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG2")]
    internal virtual PropertyGrid PG2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage6")]
    internal virtual TabPage TabPage6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG3")]
    internal virtual PropertyGrid PG3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label206")]
    internal virtual Label Label206 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown NumericUpDown1
    {
      get => this._NumericUpDown1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown1_ValueChanged);
        NumericUpDown numericUpDown1_1 = this._NumericUpDown1;
        if (numericUpDown1_1 != null)
          numericUpDown1_1.ValueChanged -= eventHandler;
        this._NumericUpDown1 = value;
        NumericUpDown numericUpDown1_2 = this._NumericUpDown1;
        if (numericUpDown1_2 == null)
          return;
        numericUpDown1_2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblDwellingDER")]
    internal virtual ToolStripLabel lblDwellingDER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDwellingDER")]
    internal virtual ToolStripTextBox txtDwellingDER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Sep1")]
    internal virtual ToolStripSeparator Sep1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDwellingTER")]
    internal virtual ToolStripLabel lblDwellingTER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDwellingTER")]
    internal virtual ToolStripTextBox txtDwellingTER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Sep2")]
    internal virtual ToolStripSeparator Sep2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage7")]
    internal virtual TabPage TabPage7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG4")]
    internal virtual PropertyGrid PG4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("SplitContainer3")]
    internal virtual SplitContainer SplitContainer3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG6")]
    internal virtual PropertyGrid PG6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl4")]
    internal virtual TabControl TabControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage8")]
    internal virtual TabPage TabPage8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage9")]
    internal virtual TabPage TabPage9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG5")]
    internal virtual PropertyGrid PG5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PGHeat")]
    internal virtual PropertyGrid PGHeat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DwellingDetails")]
    internal virtual SplitContainer DwellingDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaSummary")]
    internal virtual DataGridView dtaSummary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label211")]
    internal virtual Label Label211 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripButton cmdMoveUp
    {
      get => this._cmdMoveUp;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdMoveUp_Click);
        ToolStripButton cmdMoveUp1 = this._cmdMoveUp;
        if (cmdMoveUp1 != null)
          cmdMoveUp1.Click -= eventHandler;
        this._cmdMoveUp = value;
        ToolStripButton cmdMoveUp2 = this._cmdMoveUp;
        if (cmdMoveUp2 == null)
          return;
        cmdMoveUp2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton cmdMoveDown
    {
      get => this._cmdMoveDown;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdMoveDown_Click);
        ToolStripButton cmdMoveDown1 = this._cmdMoveDown;
        if (cmdMoveDown1 != null)
          cmdMoveDown1.Click -= eventHandler;
        this._cmdMoveDown = value;
        ToolStripButton cmdMoveDown2 = this._cmdMoveDown;
        if (cmdMoveDown2 == null)
          return;
        cmdMoveDown2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton6
    {
      get => this._ToolStripButton6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton6_Click);
        ToolStripButton toolStripButton6_1 = this._ToolStripButton6;
        if (toolStripButton6_1 != null)
          toolStripButton6_1.Click -= eventHandler;
        this._ToolStripButton6 = value;
        ToolStripButton toolStripButton6_2 = this._ToolStripButton6;
        if (toolStripButton6_2 == null)
          return;
        toolStripButton6_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripSeparator14")]
    internal virtual ToolStripSeparator ToolStripSeparator14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtShading")]
    internal virtual ComboBox txtShading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label212")]
    internal virtual Label Label212 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSTested")]
    internal virtual TextBox txtSTested { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label213")]
    internal virtual Label Label213 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLoadWeather")]
    internal virtual ComboBox txtLoadWeather { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSFlueType")]
    internal virtual ComboBox txtSFlueType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label214")]
    internal virtual Label Label214 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SAPInputToolStripMenuItem
    {
      get => this._SAPInputToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SAPInputToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SAPInputToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SAPInputToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SAPInputToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ErrorPChecker")]
    internal virtual ErrorProvider ErrorPChecker { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2
    {
      get => this._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click_1);
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

    [field: AccessedThroughProperty("LodgementToolStripMenuItem")]
    internal virtual ToolStripMenuItem LodgementToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem BatchLodgementToolStripMenuItem
    {
      get => this._BatchLodgementToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BatchLodgementToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._BatchLodgementToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._BatchLodgementToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._BatchLodgementToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem4")]
    internal virtual ToolStripSeparator ToolStripMenuItem4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ProjectLodgementHistoryToolStripMenuItem
    {
      get => this._ProjectLodgementHistoryToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ProjectLodgementHistoryToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ProjectLodgementHistoryToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ProjectLodgementHistoryToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ProjectLodgementHistoryToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem5")]
    internal virtual ToolStripSeparator ToolStripMenuItem5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ReportsToolStripMenuItem
    {
      get => this._ReportsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ReportsToolStripMenuItem_MouseMove);
        ToolStripMenuItem toolStripMenuItem1 = this._ReportsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.MouseMove -= mouseEventHandler;
        this._ReportsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ReportsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.MouseMove += mouseEventHandler;
      }
    }

    internal virtual ToolStripMenuItem ViewReportsToolStripMenuItem
    {
      get => this._ViewReportsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ViewReportsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ViewReportsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ViewReportsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ViewReportsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolsToolStripMenuItem")]
    internal virtual ToolStripMenuItem ToolsToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem LoginToStromaCertificationToolStripMenuItem
    {
      get => this._LoginToStromaCertificationToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LoginToStromaCertificationToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._LoginToStromaCertificationToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._LoginToStromaCertificationToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._LoginToStromaCertificationToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("HelpToolStripMenuItem")]
    internal virtual ToolStripMenuItem HelpToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem AboutStromaFSAPToolStripMenuItem
    {
      get => this._AboutStromaFSAPToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AboutStromaFSAPToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._AboutStromaFSAPToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._AboutStromaFSAPToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._AboutStromaFSAPToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TextBox2")]
    internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpVentData")]
    internal virtual GroupBox grpVentData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGVentData")]
    internal virtual DataGridView DGVentData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblFanPower")]
    internal virtual Label lblFanPower { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RemoveRow")]
    internal virtual ContextMenuStrip RemoveRow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem RemoveRowToolStripMenuItem
    {
      get => this._RemoveRowToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RemoveRowToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._RemoveRowToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._RemoveRowToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._RemoveRowToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

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

    [field: AccessedThroughProperty("lblStatus")]
    internal virtual ToolStripStatusLabel lblStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Timer1")]
    internal virtual System.Windows.Forms.Timer Timer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl5")]
    internal virtual TabControl TabControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage10")]
    internal virtual TabPage TabPage10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage11")]
    internal virtual TabPage TabPage11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox29")]
    internal virtual GroupBox GroupBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdPFloorArea
    {
      get => this._cmdPFloorArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPFloorArea_Click);
        Button cmdPfloorArea1 = this._cmdPFloorArea;
        if (cmdPfloorArea1 != null)
          cmdPfloorArea1.Click -= eventHandler;
        this._cmdPFloorArea = value;
        Button cmdPfloorArea2 = this._cmdPFloorArea;
        if (cmdPfloorArea2 == null)
          return;
        cmdPfloorArea2.Click += eventHandler;
      }
    }

    internal virtual Button Button8
    {
      get => this._Button8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button8_Click);
        Button button8_1 = this._Button8;
        if (button8_1 != null)
          button8_1.Click -= eventHandler;
        this._Button8 = value;
        Button button8_2 = this._Button8;
        if (button8_2 == null)
          return;
        button8_2.Click += eventHandler;
      }
    }

    internal virtual DataGridView PartyFloors
    {
      get => this._PartyFloors;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.PartyFloors_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.PartyFloors_CellValueChanged);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.PartyFloors_EditingControlShowing);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.PartyFloors_RowsRemoved);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.PartyFloors_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.PartyFloors_Scroll);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PartyFloors_MouseMove);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Floors_RowsRemoved1);
        DataGridView partyFloors1 = this._PartyFloors;
        if (partyFloors1 != null)
        {
          partyFloors1.CellEnter -= cellEventHandler1;
          partyFloors1.CellValueChanged -= cellEventHandler2;
          partyFloors1.EditingControlShowing -= showingEventHandler;
          partyFloors1.RowsRemoved -= removedEventHandler1;
          partyFloors1.DataError -= errorEventHandler;
          partyFloors1.Scroll -= scrollEventHandler;
          partyFloors1.MouseMove -= mouseEventHandler;
          partyFloors1.RowsRemoved -= removedEventHandler2;
        }
        this._PartyFloors = value;
        DataGridView partyFloors2 = this._PartyFloors;
        if (partyFloors2 == null)
          return;
        partyFloors2.CellEnter += cellEventHandler1;
        partyFloors2.CellValueChanged += cellEventHandler2;
        partyFloors2.EditingControlShowing += showingEventHandler;
        partyFloors2.RowsRemoved += removedEventHandler1;
        partyFloors2.DataError += errorEventHandler;
        partyFloors2.Scroll += scrollEventHandler;
        partyFloors2.MouseMove += mouseEventHandler;
        partyFloors2.RowsRemoved += removedEventHandler2;
      }
    }

    [field: AccessedThroughProperty("GroupBox30")]
    internal virtual GroupBox GroupBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdPWallArea
    {
      get => this._cmdPWallArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPWallArea_Click);
        Button cmdPwallArea1 = this._cmdPWallArea;
        if (cmdPwallArea1 != null)
          cmdPwallArea1.Click -= eventHandler;
        this._cmdPWallArea = value;
        Button cmdPwallArea2 = this._cmdPWallArea;
        if (cmdPwallArea2 == null)
          return;
        cmdPwallArea2.Click += eventHandler;
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

    [field: AccessedThroughProperty("GroupBox45")]
    internal virtual GroupBox GroupBox45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdPCeilingArea
    {
      get => this._cmdPCeilingArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPCeilingArea_Click);
        Button cmdPceilingArea1 = this._cmdPCeilingArea;
        if (cmdPceilingArea1 != null)
          cmdPceilingArea1.Click -= eventHandler;
        this._cmdPCeilingArea = value;
        Button cmdPceilingArea2 = this._cmdPCeilingArea;
        if (cmdPceilingArea2 == null)
          return;
        cmdPceilingArea2.Click += eventHandler;
      }
    }

    internal virtual Button Button14
    {
      get => this._Button14;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button14_Click);
        Button button14_1 = this._Button14;
        if (button14_1 != null)
          button14_1.Click -= eventHandler;
        this._Button14 = value;
        Button button14_2 = this._Button14;
        if (button14_2 == null)
          return;
        button14_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage12")]
    internal virtual TabPage TabPage12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox48")]
    internal virtual GroupBox GroupBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdIFloorArea
    {
      get => this._cmdIFloorArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdIFloorArea_Click);
        Button cmdIfloorArea1 = this._cmdIFloorArea;
        if (cmdIfloorArea1 != null)
          cmdIfloorArea1.Click -= eventHandler;
        this._cmdIFloorArea = value;
        Button cmdIfloorArea2 = this._cmdIFloorArea;
        if (cmdIfloorArea2 == null)
          return;
        cmdIfloorArea2.Click += eventHandler;
      }
    }

    internal virtual Button Button16
    {
      get => this._Button16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button16_Click);
        Button button16_1 = this._Button16;
        if (button16_1 != null)
          button16_1.Click -= eventHandler;
        this._Button16 = value;
        Button button16_2 = this._Button16;
        if (button16_2 == null)
          return;
        button16_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox49")]
    internal virtual GroupBox GroupBox49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdIWallArea
    {
      get => this._cmdIWallArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdIWallArea_Click);
        Button cmdIwallArea1 = this._cmdIWallArea;
        if (cmdIwallArea1 != null)
          cmdIwallArea1.Click -= eventHandler;
        this._cmdIWallArea = value;
        Button cmdIwallArea2 = this._cmdIWallArea;
        if (cmdIwallArea2 == null)
          return;
        cmdIwallArea2.Click += eventHandler;
      }
    }

    internal virtual Button Button19
    {
      get => this._Button19;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button19_Click);
        Button button19_1 = this._Button19;
        if (button19_1 != null)
          button19_1.Click -= eventHandler;
        this._Button19 = value;
        Button button19_2 = this._Button19;
        if (button19_2 == null)
          return;
        button19_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox50")]
    internal virtual GroupBox GroupBox50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdICeilingArea
    {
      get => this._cmdICeilingArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdICeilingArea_Click);
        Button cmdIceilingArea1 = this._cmdICeilingArea;
        if (cmdIceilingArea1 != null)
          cmdIceilingArea1.Click -= eventHandler;
        this._cmdICeilingArea = value;
        Button cmdIceilingArea2 = this._cmdICeilingArea;
        if (cmdIceilingArea2 == null)
          return;
        cmdIceilingArea2.Click += eventHandler;
      }
    }

    internal virtual Button Button22
    {
      get => this._Button22;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button22_Click);
        Button button22_1 = this._Button22;
        if (button22_1 != null)
          button22_1.Click -= eventHandler;
        this._Button22 = value;
        Button button22_2 = this._Button22;
        if (button22_2 == null)
          return;
        button22_2.Click += eventHandler;
      }
    }

    internal virtual DataGridView PartyWalls
    {
      get => this._PartyWalls;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.PartyWalls_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.PartyWalls_CellValueChanged);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.PartyWalls_EditingControlShowing);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.Walls_RowsRemoved);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.PartyFloors_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.PartyWalls_Scroll);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PartyWalls_MouseMove);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Walls_RowsRemoved1);
        DataGridView partyWalls1 = this._PartyWalls;
        if (partyWalls1 != null)
        {
          partyWalls1.CellEnter -= cellEventHandler1;
          partyWalls1.CellValueChanged -= cellEventHandler2;
          partyWalls1.EditingControlShowing -= showingEventHandler;
          partyWalls1.RowsRemoved -= removedEventHandler1;
          partyWalls1.DataError -= errorEventHandler;
          partyWalls1.Scroll -= scrollEventHandler;
          partyWalls1.MouseMove -= mouseEventHandler;
          partyWalls1.RowsRemoved -= removedEventHandler2;
        }
        this._PartyWalls = value;
        DataGridView partyWalls2 = this._PartyWalls;
        if (partyWalls2 == null)
          return;
        partyWalls2.CellEnter += cellEventHandler1;
        partyWalls2.CellValueChanged += cellEventHandler2;
        partyWalls2.EditingControlShowing += showingEventHandler;
        partyWalls2.RowsRemoved += removedEventHandler1;
        partyWalls2.DataError += errorEventHandler;
        partyWalls2.Scroll += scrollEventHandler;
        partyWalls2.MouseMove += mouseEventHandler;
        partyWalls2.RowsRemoved += removedEventHandler2;
      }
    }

    internal virtual DataGridView PartyCeilings
    {
      get => this._PartyCeilings;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.PartyCeilings_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.PartyCeilings_CellValueChanged);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.PartyCeilings_EditingControlShowing);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.Ceilings_RowsRemoved);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.PartyFloors_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.PartyCeilings_Scroll);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PartyCeilings_MouseMove);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Ceilings_RowsRemoved1);
        DataGridView partyCeilings1 = this._PartyCeilings;
        if (partyCeilings1 != null)
        {
          partyCeilings1.CellEnter -= cellEventHandler1;
          partyCeilings1.CellValueChanged -= cellEventHandler2;
          partyCeilings1.EditingControlShowing -= showingEventHandler;
          partyCeilings1.RowsRemoved -= removedEventHandler1;
          partyCeilings1.DataError -= errorEventHandler;
          partyCeilings1.Scroll -= scrollEventHandler;
          partyCeilings1.MouseMove -= mouseEventHandler;
          partyCeilings1.RowsRemoved -= removedEventHandler2;
        }
        this._PartyCeilings = value;
        DataGridView partyCeilings2 = this._PartyCeilings;
        if (partyCeilings2 == null)
          return;
        partyCeilings2.CellEnter += cellEventHandler1;
        partyCeilings2.CellValueChanged += cellEventHandler2;
        partyCeilings2.EditingControlShowing += showingEventHandler;
        partyCeilings2.RowsRemoved += removedEventHandler1;
        partyCeilings2.DataError += errorEventHandler;
        partyCeilings2.Scroll += scrollEventHandler;
        partyCeilings2.MouseMove += mouseEventHandler;
        partyCeilings2.RowsRemoved += removedEventHandler2;
      }
    }

    internal virtual DataGridView InternalFloor
    {
      get => this._InternalFloor;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.InternalFloor_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.InternalFloor_CellValueChanged);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.InternalFloor_EditingControlShowing);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.PartyFloors_RowsRemoved);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.InternalFloor_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.InternalFloor_Scroll);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.InternalFloor_MouseMove);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Floors_RowsRemoved1);
        DataGridView internalFloor1 = this._InternalFloor;
        if (internalFloor1 != null)
        {
          internalFloor1.CellEnter -= cellEventHandler1;
          internalFloor1.CellValueChanged -= cellEventHandler2;
          internalFloor1.EditingControlShowing -= showingEventHandler;
          internalFloor1.RowsRemoved -= removedEventHandler1;
          internalFloor1.DataError -= errorEventHandler;
          internalFloor1.Scroll -= scrollEventHandler;
          internalFloor1.MouseMove -= mouseEventHandler;
          internalFloor1.RowsRemoved -= removedEventHandler2;
        }
        this._InternalFloor = value;
        DataGridView internalFloor2 = this._InternalFloor;
        if (internalFloor2 == null)
          return;
        internalFloor2.CellEnter += cellEventHandler1;
        internalFloor2.CellValueChanged += cellEventHandler2;
        internalFloor2.EditingControlShowing += showingEventHandler;
        internalFloor2.RowsRemoved += removedEventHandler1;
        internalFloor2.DataError += errorEventHandler;
        internalFloor2.Scroll += scrollEventHandler;
        internalFloor2.MouseMove += mouseEventHandler;
        internalFloor2.RowsRemoved += removedEventHandler2;
      }
    }

    internal virtual DataGridView InternalWall
    {
      get => this._InternalWall;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.InternalWall_CellClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.InternalWall_CellEnter);
        DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.InternalWall_CellValueChanged);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.InternalWall_EditingControlShowing);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.Walls_RowsRemoved);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.InternalFloor_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.InternalWall_Scroll);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.InternalWall_MouseMove);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Walls_RowsRemoved1);
        DataGridView internalWall1 = this._InternalWall;
        if (internalWall1 != null)
        {
          internalWall1.CellClick -= cellEventHandler1;
          internalWall1.CellEnter -= cellEventHandler2;
          internalWall1.CellValueChanged -= cellEventHandler3;
          internalWall1.EditingControlShowing -= showingEventHandler;
          internalWall1.RowsRemoved -= removedEventHandler1;
          internalWall1.DataError -= errorEventHandler;
          internalWall1.Scroll -= scrollEventHandler;
          internalWall1.MouseMove -= mouseEventHandler;
          internalWall1.RowsRemoved -= removedEventHandler2;
        }
        this._InternalWall = value;
        DataGridView internalWall2 = this._InternalWall;
        if (internalWall2 == null)
          return;
        internalWall2.CellClick += cellEventHandler1;
        internalWall2.CellEnter += cellEventHandler2;
        internalWall2.CellValueChanged += cellEventHandler3;
        internalWall2.EditingControlShowing += showingEventHandler;
        internalWall2.RowsRemoved += removedEventHandler1;
        internalWall2.DataError += errorEventHandler;
        internalWall2.Scroll += scrollEventHandler;
        internalWall2.MouseMove += mouseEventHandler;
        internalWall2.RowsRemoved += removedEventHandler2;
      }
    }

    internal virtual DataGridView InternalCeiling
    {
      get => this._InternalCeiling;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.InternalCeiling_CellContentClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.InternalCeiling_CellValueChanged);
        DataGridViewEditingControlShowingEventHandler showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.InternalCeiling_EditingControlShowing);
        DataGridViewRowsRemovedEventHandler removedEventHandler1 = new DataGridViewRowsRemovedEventHandler(this.Ceilings_RowsRemoved);
        DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.InternalFloor_DataError);
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.InternalCeiling_Scroll);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.InternalCeiling_MouseMove);
        DataGridViewRowsRemovedEventHandler removedEventHandler2 = new DataGridViewRowsRemovedEventHandler(this.Ceilings_RowsRemoved1);
        DataGridView internalCeiling1 = this._InternalCeiling;
        if (internalCeiling1 != null)
        {
          internalCeiling1.CellContentClick -= cellEventHandler1;
          internalCeiling1.CellValueChanged -= cellEventHandler2;
          internalCeiling1.EditingControlShowing -= showingEventHandler;
          internalCeiling1.RowsRemoved -= removedEventHandler1;
          internalCeiling1.DataError -= errorEventHandler;
          internalCeiling1.Scroll -= scrollEventHandler;
          internalCeiling1.MouseMove -= mouseEventHandler;
          internalCeiling1.RowsRemoved -= removedEventHandler2;
        }
        this._InternalCeiling = value;
        DataGridView internalCeiling2 = this._InternalCeiling;
        if (internalCeiling2 == null)
          return;
        internalCeiling2.CellContentClick += cellEventHandler1;
        internalCeiling2.CellValueChanged += cellEventHandler2;
        internalCeiling2.EditingControlShowing += showingEventHandler;
        internalCeiling2.RowsRemoved += removedEventHandler1;
        internalCeiling2.DataError += errorEventHandler;
        internalCeiling2.Scroll += scrollEventHandler;
        internalCeiling2.MouseMove += mouseEventHandler;
        internalCeiling2.RowsRemoved += removedEventHandler2;
      }
    }

    [field: AccessedThroughProperty("txtTMPUser")]
    internal virtual TextBox txtTMPUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTMPUser")]
    internal virtual Label lblTMPUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTMPIndicative")]
    internal virtual ComboBox txtTMPIndicative { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblTMPIndicative")]
    internal virtual Label lblTMPIndicative { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtTMP
    {
      get => this._txtTMP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtTMP_SelectedIndexChanged);
        ComboBox txtTmp1 = this._txtTMP;
        if (txtTmp1 != null)
          txtTmp1.SelectedIndexChanged -= eventHandler;
        this._txtTMP = value;
        ComboBox txtTmp2 = this._txtTMP;
        if (txtTmp2 == null)
          return;
        txtTmp2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label215")]
    internal virtual Label Label215 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkMax125Litre")]
    internal virtual CheckBox chkMax125Litre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("RecentProjectsToolStripMenuItem")]
    internal virtual ToolStripMenuItem RecentProjectsToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem FileS1
    {
      get => this._FileS1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS1_1 = this._FileS1;
        if (fileS1_1 != null)
          fileS1_1.Click -= eventHandler;
        this._FileS1 = value;
        ToolStripMenuItem fileS1_2 = this._FileS1;
        if (fileS1_2 == null)
          return;
        fileS1_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS2
    {
      get => this._FileS2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS2_1 = this._FileS2;
        if (fileS2_1 != null)
          fileS2_1.Click -= eventHandler;
        this._FileS2 = value;
        ToolStripMenuItem fileS2_2 = this._FileS2;
        if (fileS2_2 == null)
          return;
        fileS2_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS3
    {
      get => this._FileS3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS3_1 = this._FileS3;
        if (fileS3_1 != null)
          fileS3_1.Click -= eventHandler;
        this._FileS3 = value;
        ToolStripMenuItem fileS3_2 = this._FileS3;
        if (fileS3_2 == null)
          return;
        fileS3_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS4
    {
      get => this._FileS4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS4_1 = this._FileS4;
        if (fileS4_1 != null)
          fileS4_1.Click -= eventHandler;
        this._FileS4 = value;
        ToolStripMenuItem fileS4_2 = this._FileS4;
        if (fileS4_2 == null)
          return;
        fileS4_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS5
    {
      get => this._FileS5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS5_1 = this._FileS5;
        if (fileS5_1 != null)
          fileS5_1.Click -= eventHandler;
        this._FileS5 = value;
        ToolStripMenuItem fileS5_2 = this._FileS5;
        if (fileS5_2 == null)
          return;
        fileS5_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS6
    {
      get => this._FileS6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS6_1 = this._FileS6;
        if (fileS6_1 != null)
          fileS6_1.Click -= eventHandler;
        this._FileS6 = value;
        ToolStripMenuItem fileS6_2 = this._FileS6;
        if (fileS6_2 == null)
          return;
        fileS6_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS7
    {
      get => this._FileS7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS7_1 = this._FileS7;
        if (fileS7_1 != null)
          fileS7_1.Click -= eventHandler;
        this._FileS7 = value;
        ToolStripMenuItem fileS7_2 = this._FileS7;
        if (fileS7_2 == null)
          return;
        fileS7_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS8
    {
      get => this._FileS8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS8_1 = this._FileS8;
        if (fileS8_1 != null)
          fileS8_1.Click -= eventHandler;
        this._FileS8 = value;
        ToolStripMenuItem fileS8_2 = this._FileS8;
        if (fileS8_2 == null)
          return;
        fileS8_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS9
    {
      get => this._FileS9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS9_1 = this._FileS9;
        if (fileS9_1 != null)
          fileS9_1.Click -= eventHandler;
        this._FileS9 = value;
        ToolStripMenuItem fileS9_2 = this._FileS9;
        if (fileS9_2 == null)
          return;
        fileS9_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS10
    {
      get => this._FileS10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS10_1 = this._FileS10;
        if (fileS10_1 != null)
          fileS10_1.Click -= eventHandler;
        this._FileS10 = value;
        ToolStripMenuItem fileS10_2 = this._FileS10;
        if (fileS10_2 == null)
          return;
        fileS10_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS11
    {
      get => this._FileS11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS11_1 = this._FileS11;
        if (fileS11_1 != null)
          fileS11_1.Click -= eventHandler;
        this._FileS11 = value;
        ToolStripMenuItem fileS11_2 = this._FileS11;
        if (fileS11_2 == null)
          return;
        fileS11_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem FileS12
    {
      get => this._FileS12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileS1_Click);
        ToolStripMenuItem fileS12_1 = this._FileS12;
        if (fileS12_1 != null)
          fileS12_1.Click -= eventHandler;
        this._FileS12 = value;
        ToolStripMenuItem fileS12_2 = this._FileS12;
        if (fileS12_2 == null)
          return;
        fileS12_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem7")]
    internal virtual ToolStripSeparator ToolStripMenuItem7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label216")]
    internal virtual Label Label216 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtBFuelBurningType")]
    internal virtual ComboBox txtBFuelBurningType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSEDBUK2005")]
    internal virtual CheckBox chkSEDBUK2005 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlMainEff1")]
    internal virtual Panel pnlMainEff1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlMainEff2")]
    internal virtual Panel pnlMainEff2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label217")]
    internal virtual Label Label217 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMainEffWinter")]
    internal virtual TextBox txtMainEffWinter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label218")]
    internal virtual Label Label218 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label219")]
    internal virtual Label Label219 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtMainEffSummer")]
    internal virtual TextBox txtMainEffSummer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label220")]
    internal virtual Label Label220 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabControl6")]
    internal virtual TabControl TabControl6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage13")]
    internal virtual TabPage TabPage13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel6")]
    internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlPhotoVoltaics")]
    internal virtual Panel pnlPhotoVoltaics { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel4")]
    internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage14")]
    internal virtual TabPage TabPage14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdPhotoOK
    {
      get => this._cmdPhotoOK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPhotoOK_Click);
        Button cmdPhotoOk1 = this._cmdPhotoOK;
        if (cmdPhotoOk1 != null)
          cmdPhotoOk1.Click -= eventHandler;
        this._cmdPhotoOK = value;
        Button cmdPhotoOk2 = this._cmdPhotoOK;
        if (cmdPhotoOk2 == null)
          return;
        cmdPhotoOk2.Click += eventHandler;
      }
    }

    internal virtual Button cmdPhotoNew
    {
      get => this._cmdPhotoNew;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPhotoNew_Click);
        Button cmdPhotoNew1 = this._cmdPhotoNew;
        if (cmdPhotoNew1 != null)
          cmdPhotoNew1.Click -= eventHandler;
        this._cmdPhotoNew = value;
        Button cmdPhotoNew2 = this._cmdPhotoNew;
        if (cmdPhotoNew2 == null)
          return;
        cmdPhotoNew2.Click += eventHandler;
      }
    }

    internal virtual Button cmdPhotoDelete
    {
      get => this._cmdPhotoDelete;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdPhotoDelete_Click);
        Button cmdPhotoDelete1 = this._cmdPhotoDelete;
        if (cmdPhotoDelete1 != null)
          cmdPhotoDelete1.Click -= eventHandler;
        this._cmdPhotoDelete = value;
        Button cmdPhotoDelete2 = this._cmdPhotoDelete;
        if (cmdPhotoDelete2 == null)
          return;
        cmdPhotoDelete2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label224")]
    internal virtual Label Label224 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label223")]
    internal virtual Label Label223 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label222")]
    internal virtual Label Label222 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label221")]
    internal virtual Label Label221 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtNoofOpenFluesOther
    {
      get => this._txtNoofOpenFluesOther;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofOpenFluesMain_ValueChanged);
        NumericUpDown noofOpenFluesOther1 = this._txtNoofOpenFluesOther;
        if (noofOpenFluesOther1 != null)
          noofOpenFluesOther1.ValueChanged -= eventHandler;
        this._txtNoofOpenFluesOther = value;
        NumericUpDown noofOpenFluesOther2 = this._txtNoofOpenFluesOther;
        if (noofOpenFluesOther2 == null)
          return;
        noofOpenFluesOther2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtNoofChmneysOther
    {
      get => this._txtNoofChmneysOther;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofChmneysMain_ValueChanged);
        NumericUpDown noofChmneysOther1 = this._txtNoofChmneysOther;
        if (noofChmneysOther1 != null)
          noofChmneysOther1.ValueChanged -= eventHandler;
        this._txtNoofChmneysOther = value;
        NumericUpDown noofChmneysOther2 = this._txtNoofChmneysOther;
        if (noofChmneysOther2 == null)
          return;
        noofChmneysOther2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtNoofOpenFluesSec
    {
      get => this._txtNoofOpenFluesSec;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofOpenFluesMain_ValueChanged);
        NumericUpDown noofOpenFluesSec1 = this._txtNoofOpenFluesSec;
        if (noofOpenFluesSec1 != null)
          noofOpenFluesSec1.ValueChanged -= eventHandler;
        this._txtNoofOpenFluesSec = value;
        NumericUpDown noofOpenFluesSec2 = this._txtNoofOpenFluesSec;
        if (noofOpenFluesSec2 == null)
          return;
        noofOpenFluesSec2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtNoofChmneysSec
    {
      get => this._txtNoofChmneysSec;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofChmneysMain_ValueChanged);
        NumericUpDown txtNoofChmneysSec1 = this._txtNoofChmneysSec;
        if (txtNoofChmneysSec1 != null)
          txtNoofChmneysSec1.ValueChanged -= eventHandler;
        this._txtNoofChmneysSec = value;
        NumericUpDown txtNoofChmneysSec2 = this._txtNoofChmneysSec;
        if (txtNoofChmneysSec2 == null)
          return;
        txtNoofChmneysSec2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtNoofOpenFluesMain
    {
      get => this._txtNoofOpenFluesMain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofOpenFluesMain_ValueChanged);
        NumericUpDown noofOpenFluesMain1 = this._txtNoofOpenFluesMain;
        if (noofOpenFluesMain1 != null)
          noofOpenFluesMain1.ValueChanged -= eventHandler;
        this._txtNoofOpenFluesMain = value;
        NumericUpDown noofOpenFluesMain2 = this._txtNoofOpenFluesMain;
        if (noofOpenFluesMain2 == null)
          return;
        noofOpenFluesMain2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtNoofChmneysMain
    {
      get => this._txtNoofChmneysMain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtNoofChmneysMain_ValueChanged);
        NumericUpDown txtNoofChmneysMain1 = this._txtNoofChmneysMain;
        if (txtNoofChmneysMain1 != null)
          txtNoofChmneysMain1.ValueChanged -= eventHandler;
        this._txtNoofChmneysMain = value;
        NumericUpDown txtNoofChmneysMain2 = this._txtNoofChmneysMain;
        if (txtNoofChmneysMain2 == null)
          return;
        txtNoofChmneysMain2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage15")]
    internal virtual TabPage TabPage15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox51")]
    internal virtual GroupBox GroupBox51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox optWWHRS
    {
      get => this._optWWHRS;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.optWWHRS_CheckedChanged);
        CheckBox optWwhrs1 = this._optWWHRS;
        if (optWwhrs1 != null)
          optWwhrs1.CheckedChanged -= eventHandler;
        this._optWWHRS = value;
        CheckBox optWwhrs2 = this._optWWHRS;
        if (optWwhrs2 == null)
          return;
        optWwhrs2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label225")]
    internal virtual Label Label225 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpWWHRS1")]
    internal virtual GroupBox grpWWHRS1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdWWHRSSystem1Selection
    {
      get => this._cmdWWHRSSystem1Selection;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdWWHRSSystem1Selection_Click);
        Button system1Selection1 = this._cmdWWHRSSystem1Selection;
        if (system1Selection1 != null)
          system1Selection1.Click -= eventHandler;
        this._cmdWWHRSSystem1Selection = value;
        Button system1Selection2 = this._cmdWWHRSSystem1Selection;
        if (system1Selection2 == null)
          return;
        system1Selection2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label228")]
    internal virtual Label Label228 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRS1WithNoBath")]
    internal virtual NumericUpDown txtWWHRS1WithNoBath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label227")]
    internal virtual Label Label227 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRS1WithBath")]
    internal virtual NumericUpDown txtWWHRS1WithBath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRSTotalRooms")]
    internal virtual NumericUpDown txtWWHRSTotalRooms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpWWHRS2")]
    internal virtual GroupBox grpWWHRS2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGVWWHRS2")]
    internal virtual DataGridView DGVWWHRS2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdWWHRSSystem2Selection
    {
      get => this._cmdWWHRSSystem2Selection;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdWWHRSSystem2Selection_Click);
        Button system2Selection1 = this._cmdWWHRSSystem2Selection;
        if (system2Selection1 != null)
          system2Selection1.Click -= eventHandler;
        this._cmdWWHRSSystem2Selection = value;
        Button system2Selection2 = this._cmdWWHRSSystem2Selection;
        if (system2Selection2 == null)
          return;
        system2Selection2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label226")]
    internal virtual Label Label226 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRS2WithNoBath")]
    internal virtual NumericUpDown txtWWHRS2WithNoBath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label229")]
    internal virtual Label Label229 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRS2WithBath")]
    internal virtual NumericUpDown txtWWHRS2WithBath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGVWWHRS1")]
    internal virtual DataGridView DGVWWHRS1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage18")]
    internal virtual TabPage TabPage18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage19")]
    internal virtual TabPage TabPage19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox69")]
    internal virtual GroupBox GroupBox69 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label281")]
    internal virtual Label Label281 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CompressControl")]
    internal virtual ComboBox CompressControl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label283")]
    internal virtual Label Label283 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtEnergyLabelClass")]
    internal virtual ComboBox txtEnergyLabelClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCoolingSystemType")]
    internal virtual ComboBox txtCoolingSystemType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label284")]
    internal virtual Label Label284 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label285")]
    internal virtual Label Label285 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage16")]
    internal virtual TabPage TabPage16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox52")]
    internal virtual GroupBox GroupBox52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridView1")]
    internal virtual DataGridView DataGridView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox53")]
    internal virtual GroupBox GroupBox53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox1")]
    internal virtual ComboBox ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox1")]
    internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox54")]
    internal virtual GroupBox GroupBox54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox2")]
    internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox2")]
    internal virtual ComboBox ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label230")]
    internal virtual Label Label230 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox3")]
    internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel5")]
    internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label231")]
    internal virtual Label Label231 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox3")]
    internal virtual ComboBox ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox4")]
    internal virtual ComboBox ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label232")]
    internal virtual Label Label232 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox5")]
    internal virtual ComboBox ComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label233")]
    internal virtual Label Label233 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox3")]
    internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label234")]
    internal virtual Label Label234 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox6")]
    internal virtual ComboBox ComboBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox7")]
    internal virtual ComboBox ComboBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label235")]
    internal virtual Label Label235 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label236")]
    internal virtual Label Label236 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox55")]
    internal virtual GroupBox GroupBox55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridView2")]
    internal virtual DataGridView DataGridView2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox56")]
    internal virtual GroupBox GroupBox56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label237")]
    internal virtual Label Label237 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox4")]
    internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label238")]
    internal virtual Label Label238 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label239")]
    internal virtual Label Label239 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox5")]
    internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label240")]
    internal virtual Label Label240 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox6")]
    internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label241")]
    internal virtual Label Label241 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox8")]
    internal virtual ComboBox ComboBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label242")]
    internal virtual Label Label242 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label243")]
    internal virtual Label Label243 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox7")]
    internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label244")]
    internal virtual Label Label244 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox8")]
    internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label245")]
    internal virtual Label Label245 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label246")]
    internal virtual Label Label246 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox9")]
    internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label247")]
    internal virtual Label Label247 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox4")]
    internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox9")]
    internal virtual ComboBox ComboBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label248")]
    internal virtual Label Label248 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox57")]
    internal virtual GroupBox GroupBox57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox10")]
    internal virtual ComboBox ComboBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label249")]
    internal virtual Label Label249 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox58")]
    internal virtual GroupBox GroupBox58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label250")]
    internal virtual Label Label250 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox10")]
    internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label251")]
    internal virtual Label Label251 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label252")]
    internal virtual Label Label252 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox11")]
    internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label253")]
    internal virtual Label Label253 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox59")]
    internal virtual GroupBox GroupBox59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox11")]
    internal virtual ComboBox ComboBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label254")]
    internal virtual Label Label254 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox60")]
    internal virtual GroupBox GroupBox60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel7")]
    internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label255")]
    internal virtual Label Label255 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox12")]
    internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label256")]
    internal virtual Label Label256 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox5")]
    internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel8")]
    internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label257")]
    internal virtual Label Label257 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox13")]
    internal virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label258")]
    internal virtual Label Label258 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label259")]
    internal virtual Label Label259 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox14")]
    internal virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label260")]
    internal virtual Label Label260 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox61")]
    internal virtual GroupBox GroupBox61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox6")]
    internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox12")]
    internal virtual ComboBox ComboBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label261")]
    internal virtual Label Label261 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox62")]
    internal virtual GroupBox GroupBox62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CheckBox7")]
    internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox13")]
    internal virtual ComboBox ComboBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label262")]
    internal virtual Label Label262 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox14")]
    internal virtual ComboBox ComboBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label263")]
    internal virtual Label Label263 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox63")]
    internal virtual GroupBox GroupBox63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox15")]
    internal virtual ComboBox ComboBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label264")]
    internal virtual Label Label264 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox16")]
    internal virtual ComboBox ComboBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label265")]
    internal virtual Label Label265 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox17")]
    internal virtual ComboBox ComboBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label266")]
    internal virtual Label Label266 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button7")]
    internal virtual Button Button7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox18")]
    internal virtual ComboBox ComboBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label267")]
    internal virtual Label Label267 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox19")]
    internal virtual ComboBox ComboBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox20")]
    internal virtual ComboBox ComboBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label268")]
    internal virtual Label Label268 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label269")]
    internal virtual Label Label269 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage17")]
    internal virtual TabPage TabPage17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox64")]
    internal virtual GroupBox GroupBox64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox15")]
    internal virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label270")]
    internal virtual Label Label270 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox16")]
    internal virtual TextBox TextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label271")]
    internal virtual Label Label271 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox65")]
    internal virtual GroupBox GroupBox65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox21")]
    internal virtual ComboBox ComboBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label272")]
    internal virtual Label Label272 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox66")]
    internal virtual GroupBox GroupBox66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox22")]
    internal virtual ComboBox ComboBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label273")]
    internal virtual Label Label273 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox67")]
    internal virtual GroupBox GroupBox67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label274")]
    internal virtual Label Label274 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox17")]
    internal virtual TextBox TextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label275")]
    internal virtual Label Label275 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox68")]
    internal virtual GroupBox GroupBox68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox23")]
    internal virtual ComboBox ComboBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label276")]
    internal virtual Label Label276 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Button9")]
    internal virtual Button Button9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox24")]
    internal virtual ComboBox ComboBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label277")]
    internal virtual Label Label277 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox25")]
    internal virtual ComboBox ComboBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label278")]
    internal virtual Label Label278 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox26")]
    internal virtual ComboBox ComboBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboBox27")]
    internal virtual ComboBox ComboBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label279")]
    internal virtual Label Label279 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label280")]
    internal virtual Label Label280 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCooledArea")]
    internal virtual TextBox txtCooledArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label282")]
    internal virtual Label Label282 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FGHRS")]
    internal virtual TabPage FGHRS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkCoolingSystem
    {
      get => this._ChkCoolingSystem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkCoolingSystem_CheckedChanged);
        CheckBox chkCoolingSystem1 = this._ChkCoolingSystem;
        if (chkCoolingSystem1 != null)
          chkCoolingSystem1.CheckedChanged -= eventHandler;
        this._ChkCoolingSystem = value;
        CheckBox chkCoolingSystem2 = this._ChkCoolingSystem;
        if (chkCoolingSystem2 == null)
          return;
        chkCoolingSystem2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox70")]
    internal virtual GroupBox GroupBox70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpFGHRSTestDetails")]
    internal virtual GroupBox grpFGHRSTestDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGFGHRS2")]
    internal virtual DataGridView DGFGHRS2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdFGHRS
    {
      get => this._cmdFGHRS;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button10_Click);
        Button cmdFghrs1 = this._cmdFGHRS;
        if (cmdFghrs1 != null)
          cmdFghrs1.Click -= eventHandler;
        this._cmdFGHRS = value;
        Button cmdFghrs2 = this._cmdFGHRS;
        if (cmdFghrs2 == null)
          return;
        cmdFghrs2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpFGHRSSelection")]
    internal virtual GroupBox grpFGHRSSelection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DGFGHRS1")]
    internal virtual DataGridView DGFGHRS1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkFGHRS
    {
      get => this._ChkFGHRS;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkFGHRS_CheckedChanged);
        CheckBox chkFghrs1 = this._ChkFGHRS;
        if (chkFghrs1 != null)
          chkFghrs1.CheckedChanged -= eventHandler;
        this._ChkFGHRS = value;
        CheckBox chkFghrs2 = this._ChkFGHRS;
        if (chkFghrs2 == null)
          return;
        chkFghrs2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("TabPage20")]
    internal virtual TabPage TabPage20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PG7")]
    internal virtual PropertyGrid PG7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkApprovedScheme
    {
      get => this._chkApprovedScheme;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkApprovedScheme_CheckedChanged);
        CheckBox chkApprovedScheme1 = this._chkApprovedScheme;
        if (chkApprovedScheme1 != null)
          chkApprovedScheme1.CheckedChanged -= eventHandler;
        this._chkApprovedScheme = value;
        CheckBox chkApprovedScheme2 = this._chkApprovedScheme;
        if (chkApprovedScheme2 == null)
          return;
        chkApprovedScheme2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel9")]
    internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PanelSpecFeatures")]
    internal virtual Panel PanelSpecFeatures { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button BtnSp_Feature_OK
    {
      get => this._BtnSp_Feature_OK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BtnSp_Feature_OK_Click);
        Button btnSpFeatureOk1 = this._BtnSp_Feature_OK;
        if (btnSpFeatureOk1 != null)
          btnSpFeatureOk1.Click -= eventHandler;
        this._BtnSp_Feature_OK = value;
        Button btnSpFeatureOk2 = this._BtnSp_Feature_OK;
        if (btnSpFeatureOk2 == null)
          return;
        btnSpFeatureOk2.Click += eventHandler;
      }
    }

    internal virtual Button BtnSp_Feature_add
    {
      get => this._BtnSp_Feature_add;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BtnSp_Feature_add_Click);
        Button btnSpFeatureAdd1 = this._BtnSp_Feature_add;
        if (btnSpFeatureAdd1 != null)
          btnSpFeatureAdd1.Click -= eventHandler;
        this._BtnSp_Feature_add = value;
        Button btnSpFeatureAdd2 = this._BtnSp_Feature_add;
        if (btnSpFeatureAdd2 == null)
          return;
        btnSpFeatureAdd2.Click += eventHandler;
      }
    }

    internal virtual Button Btn_SPFeature_Del
    {
      get => this._Btn_SPFeature_Del;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Btn_SPFeature_Del_Click);
        Button btnSpFeatureDel1 = this._Btn_SPFeature_Del;
        if (btnSpFeatureDel1 != null)
          btnSpFeatureDel1.Click -= eventHandler;
        this._Btn_SPFeature_Del = value;
        Button btnSpFeatureDel2 = this._Btn_SPFeature_Del;
        if (btnSpFeatureDel2 == null)
          return;
        btnSpFeatureDel2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem6")]
    internal virtual ToolStripSeparator ToolStripMenuItem6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ImportDwellingToolStripMenuItem
    {
      get => this._ImportDwellingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ImportDwellingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ImportDwellingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ImportDwellingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ImportDwellingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ExportDwellingToolStripMenuItem
    {
      get => this._ExportDwellingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExportDwellingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ExportDwellingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ExportDwellingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ExportDwellingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual CheckBox ChkEER
    {
      get => this._ChkEER;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkEER_CheckedChanged);
        CheckBox chkEer1 = this._ChkEER;
        if (chkEer1 != null)
          chkEer1.CheckedChanged -= eventHandler;
        this._ChkEER = value;
        CheckBox chkEer2 = this._ChkEER;
        if (chkEer2 == null)
          return;
        chkEer2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtEER")]
    internal virtual TextBox txtEER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblErr")]
    internal virtual Label lblErr { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txterrDesc")]
    internal virtual TextBox txterrDesc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label286")]
    internal virtual Label Label286 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtCommHNoOfAdditional
    {
      get => this._txtCommHNoOfAdditional;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtCommHNoOfAdditional_ValueChanged);
        NumericUpDown commHnoOfAdditional1 = this._txtCommHNoOfAdditional;
        if (commHnoOfAdditional1 != null)
          commHnoOfAdditional1.ValueChanged -= eventHandler;
        this._txtCommHNoOfAdditional = value;
        NumericUpDown commHnoOfAdditional2 = this._txtCommHNoOfAdditional;
        if (commHnoOfAdditional2 == null)
          return;
        commHnoOfAdditional2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label288")]
    internal virtual Label Label288 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHB1HeatToPower")]
    internal virtual TextBox txtCommHB1HeatToPower { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label287")]
    internal virtual Label Label287 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel10")]
    internal virtual Panel Panel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel11")]
    internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommHAdd4")]
    internal virtual GroupBox grpCommHAdd4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label304")]
    internal virtual Label Label304 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd4Efficiency")]
    internal virtual TextBox txtCommHAdd4Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label305")]
    internal virtual Label Label305 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd4Fraction")]
    internal virtual TextBox txtCommHAdd4Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label306")]
    internal virtual Label Label306 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd4Fuel")]
    internal virtual ComboBox txtCommHAdd4Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label307")]
    internal virtual Label Label307 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd4Type")]
    internal virtual ComboBox txtCommHAdd4Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label308")]
    internal virtual Label Label308 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommHAdd1")]
    internal virtual GroupBox grpCommHAdd1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label292")]
    internal virtual Label Label292 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd1Efficiency")]
    internal virtual TextBox txtCommHAdd1Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label293")]
    internal virtual Label Label293 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd1Fraction")]
    internal virtual TextBox txtCommHAdd1Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label291")]
    internal virtual Label Label291 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd1Fuel")]
    internal virtual ComboBox txtCommHAdd1Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label290")]
    internal virtual Label Label290 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd1Type")]
    internal virtual ComboBox txtCommHAdd1Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label289")]
    internal virtual Label Label289 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommHAdd3")]
    internal virtual GroupBox grpCommHAdd3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label299")]
    internal virtual Label Label299 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd3Efficiency")]
    internal virtual TextBox txtCommHAdd3Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label300")]
    internal virtual Label Label300 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd3Fraction")]
    internal virtual TextBox txtCommHAdd3Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label301")]
    internal virtual Label Label301 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd3Fuel")]
    internal virtual ComboBox txtCommHAdd3Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label302")]
    internal virtual Label Label302 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd3Type")]
    internal virtual ComboBox txtCommHAdd3Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label303")]
    internal virtual Label Label303 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommHAdd2")]
    internal virtual GroupBox grpCommHAdd2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label294")]
    internal virtual Label Label294 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd2Efficiency")]
    internal virtual TextBox txtCommHAdd2Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label295")]
    internal virtual Label Label295 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd2Fraction")]
    internal virtual TextBox txtCommHAdd2Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label296")]
    internal virtual Label Label296 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd2Fuel")]
    internal virtual ComboBox txtCommHAdd2Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label297")]
    internal virtual Label Label297 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCommHAdd2Type")]
    internal virtual ComboBox txtCommHAdd2Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label298")]
    internal virtual Label Label298 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GrpDHWVessel")]
    internal virtual GroupBox GrpDHWVessel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox CboDHWVessel
    {
      get => this._CboDHWVessel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CboDHWVessel_CheckedChanged);
        CheckBox cboDhwVessel1 = this._CboDHWVessel;
        if (cboDhwVessel1 != null)
          cboDhwVessel1.CheckedChanged -= eventHandler;
        this._CboDHWVessel = value;
        CheckBox cboDhwVessel2 = this._CboDHWVessel;
        if (cboDhwVessel2 == null)
          return;
        cboDhwVessel2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox ChkMonInc
    {
      get => this._ChkMonInc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkMonInc_CheckedChanged);
        CheckBox chkMonInc1 = this._ChkMonInc;
        if (chkMonInc1 != null)
          chkMonInc1.CheckedChanged -= eventHandler;
        this._ChkMonInc = value;
        CheckBox chkMonInc2 = this._ChkMonInc;
        if (chkMonInc2 == null)
          return;
        chkMonInc2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button cmdSpecialQDetails
    {
      get => this._cmdSpecialQDetails;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSpecialQDetails_Click);
        Button cmdSpecialQdetails1 = this._cmdSpecialQDetails;
        if (cmdSpecialQdetails1 != null)
          cmdSpecialQdetails1.Click -= eventHandler;
        this._cmdSpecialQDetails = value;
        Button cmdSpecialQdetails2 = this._cmdSpecialQDetails;
        if (cmdSpecialQdetails2 == null)
          return;
        cmdSpecialQdetails2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpCommHSec")]
    internal virtual GroupBox grpCommHSec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel13")]
    internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecCommHAdd4")]
    internal virtual GroupBox grpSecCommHAdd4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label332")]
    internal virtual Label Label332 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd4Efficiency")]
    internal virtual TextBox txtSecCommHAdd4Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label333")]
    internal virtual Label Label333 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd4Fraction")]
    internal virtual TextBox txtSecCommHAdd4Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label334")]
    internal virtual Label Label334 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd4Fuel")]
    internal virtual ComboBox txtSecCommHAdd4Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label335")]
    internal virtual Label Label335 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd4Type")]
    internal virtual ComboBox txtSecCommHAdd4Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label336")]
    internal virtual Label Label336 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecCommHAdd1")]
    internal virtual GroupBox grpSecCommHAdd1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label337")]
    internal virtual Label Label337 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd1Efficiency")]
    internal virtual TextBox txtSecCommHAdd1Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label338")]
    internal virtual Label Label338 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd1Fraction")]
    internal virtual TextBox txtSecCommHAdd1Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label339")]
    internal virtual Label Label339 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd1Fuel")]
    internal virtual ComboBox txtSecCommHAdd1Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label340")]
    internal virtual Label Label340 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd1Type")]
    internal virtual ComboBox txtSecCommHAdd1Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label341")]
    internal virtual Label Label341 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecCommHAdd3")]
    internal virtual GroupBox grpSecCommHAdd3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label342")]
    internal virtual Label Label342 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd3Efficiency")]
    internal virtual TextBox txtSecCommHAdd3Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label343")]
    internal virtual Label Label343 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd3Fraction")]
    internal virtual TextBox txtSecCommHAdd3Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label344")]
    internal virtual Label Label344 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd3Fuel")]
    internal virtual ComboBox txtSecCommHAdd3Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label345")]
    internal virtual Label Label345 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd3Type")]
    internal virtual ComboBox txtSecCommHAdd3Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label346")]
    internal virtual Label Label346 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecCommHAdd2")]
    internal virtual GroupBox grpSecCommHAdd2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label347")]
    internal virtual Label Label347 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd2Efficiency")]
    internal virtual TextBox txtSecCommHAdd2Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label348")]
    internal virtual Label Label348 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd2Fraction")]
    internal virtual TextBox txtSecCommHAdd2Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label349")]
    internal virtual Label Label349 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd2Fuel")]
    internal virtual ComboBox txtSecCommHAdd2Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label350")]
    internal virtual Label Label350 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHAdd2Type")]
    internal virtual ComboBox txtSecCommHAdd2Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label351")]
    internal virtual Label Label351 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtSecCommHNoOfAdditional
    {
      get => this._txtSecCommHNoOfAdditional;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecCommHNoOfAdditional_ValueChanged);
        NumericUpDown commHnoOfAdditional1 = this._txtSecCommHNoOfAdditional;
        if (commHnoOfAdditional1 != null)
          commHnoOfAdditional1.ValueChanged -= eventHandler;
        this._txtSecCommHNoOfAdditional = value;
        NumericUpDown commHnoOfAdditional2 = this._txtSecCommHNoOfAdditional;
        if (commHnoOfAdditional2 == null)
          return;
        commHnoOfAdditional2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label352")]
    internal virtual Label Label352 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHB1HeatToPower")]
    internal virtual TextBox txtSecCommHB1HeatToPower { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label353")]
    internal virtual Label Label353 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel10Sec")]
    internal virtual Panel Panel10Sec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSecCommHBoiler2")]
    internal virtual CheckBox chkSecCommHBoiler2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label354")]
    internal virtual Label Label354 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label355")]
    internal virtual Label Label355 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHCHPHEfficiency")]
    internal virtual TextBox txtSecCommHCHPHEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHB2Fuel")]
    internal virtual ComboBox txtSecCommHB2Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label356")]
    internal virtual Label Label356 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label357")]
    internal virtual Label Label357 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label358")]
    internal virtual Label Label358 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHB2Efficiency")]
    internal virtual TextBox txtSecCommHB2Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHCHPEEfficiency")]
    internal virtual TextBox txtSecCommHCHPEEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label359")]
    internal virtual Label Label359 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label360")]
    internal virtual Label Label360 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label361")]
    internal virtual Label Label361 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox30")]
    internal virtual TextBox TextBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHDS")]
    internal virtual ComboBox txtSecCommHDS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label362")]
    internal virtual Label Label362 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHB1HFraction")]
    internal virtual TextBox txtSecCommHB1HFraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label363")]
    internal virtual Label Label363 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label364")]
    internal virtual Label Label364 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCommHB1Efficiency")]
    internal virtual TextBox txtSecCommHB1Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label365")]
    internal virtual Label Label365 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecCHP")]
    internal virtual GroupBox grpSecCHP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataSecInfoSub")]
    internal virtual DataGridView DataSecInfoSub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecBoilerInfo")]
    internal virtual GroupBox grpSecBoilerInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecLoadWeather")]
    internal virtual ComboBox txtSecLoadWeather { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkSecMainHLoadWeather
    {
      get => this._chkSecMainHLoadWeather;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSecMainHLoadWeather_CheckedChanged);
        CheckBox mainHloadWeather1 = this._chkSecMainHLoadWeather;
        if (mainHloadWeather1 != null)
          mainHloadWeather1.CheckedChanged -= eventHandler;
        this._chkSecMainHLoadWeather = value;
        CheckBox mainHloadWeather2 = this._chkSecMainHLoadWeather;
        if (mainHloadWeather2 == null)
          return;
        mainHloadWeather2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpSecKeepHot")]
    internal virtual GroupBox grpSecKeepHot { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSecKeepHotTimed")]
    internal virtual CheckBox chkSecKeepHotTimed { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecKeepHotFuel")]
    internal virtual ComboBox txtSecKeepHotFuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label366")]
    internal virtual Label Label366 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkSecKeepHot
    {
      get => this._chkSecKeepHot;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSecKeepHot_CheckedChanged);
        CheckBox chkSecKeepHot1 = this._chkSecKeepHot;
        if (chkSecKeepHot1 != null)
          chkSecKeepHot1.CheckedChanged -= eventHandler;
        this._chkSecKeepHot = value;
        CheckBox chkSecKeepHot2 = this._chkSecKeepHot;
        if (chkSecKeepHot2 == null)
          return;
        chkSecKeepHot2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ManuFacSec")]
    internal virtual Panel ManuFacSec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label367")]
    internal virtual Label Label367 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecBFuelBurningType")]
    internal virtual ComboBox txtSecBFuelBurningType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecFanFlued")]
    internal virtual ComboBox txtSecFanFlued { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label368")]
    internal virtual Label Label368 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecBFlueType")]
    internal virtual ComboBox txtSecBFlueType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label369")]
    internal virtual Label Label369 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecDescription")]
    internal virtual TextBox txtSecDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label370")]
    internal virtual Label Label370 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecBILock")]
    internal virtual ComboBox txtSecBILock { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecPumpHP
    {
      get => this._txtSecPumpHP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecPumpHP_SelectedIndexChanged);
        ComboBox txtSecPumpHp1 = this._txtSecPumpHP;
        if (txtSecPumpHp1 != null)
          txtSecPumpHp1.SelectedIndexChanged -= eventHandler;
        this._txtSecPumpHP = value;
        ComboBox txtSecPumpHp2 = this._txtSecPumpHP;
        if (txtSecPumpHp2 == null)
          return;
        txtSecPumpHp2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label371")]
    internal virtual Label Label371 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label372")]
    internal virtual Label Label372 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GrpSecBoiler")]
    internal virtual GroupBox GrpSecBoiler { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataInfoSec")]
    internal virtual DataGridView DataInfoSec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecCompensator")]
    internal virtual GroupBox grpSecCompensator { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecCompensator")]
    internal virtual ComboBox txtSecCompensator { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label373")]
    internal virtual Label Label373 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecRange")]
    internal virtual GroupBox grpSecRange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label374")]
    internal virtual Label Label374 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecRangeWater")]
    internal virtual TextBox txtSecRangeWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label375")]
    internal virtual Label Label375 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label376")]
    internal virtual Label Label376 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TextBox35")]
    internal virtual TextBox TextBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label377")]
    internal virtual Label Label377 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecHETASMain")]
    internal virtual GroupBox grpSecHETASMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecHETASMain
    {
      get => this._txtSecHETASMain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecHETASMain_SelectedIndexChanged);
        ComboBox txtSecHetasMain1 = this._txtSecHETASMain;
        if (txtSecHetasMain1 != null)
          txtSecHetasMain1.SelectedIndexChanged -= eventHandler;
        this._txtSecHETASMain = value;
        ComboBox txtSecHetasMain2 = this._txtSecHETASMain;
        if (txtSecHetasMain2 == null)
          return;
        txtSecHetasMain2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label378")]
    internal virtual Label Label378 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpSecEfficiency")]
    internal virtual GroupBox grpSecEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlMainSecEff1")]
    internal virtual Panel pnlMainSecEff1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label379")]
    internal virtual Label Label379 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecEfficiency")]
    internal virtual TextBox txtSecEfficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label380")]
    internal virtual Label Label380 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSecSEDBUK2005")]
    internal virtual CheckBox chkSecSEDBUK2005 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlMainSecEff2")]
    internal virtual Panel pnlMainSecEff2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label381")]
    internal virtual Label Label381 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtsecMainEffSummer")]
    internal virtual TextBox txtsecMainEffSummer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label382")]
    internal virtual Label Label382 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label383")]
    internal virtual Label Label383 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtsecMainEffWinter")]
    internal virtual TextBox txtsecMainEffWinter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label384")]
    internal virtual Label Label384 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox24Sec")]
    internal virtual GroupBox GroupBox24Sec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSecDelayedStart")]
    internal virtual CheckBox chkSecDelayedStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecHeatingControls
    {
      get => this._txtSecHeatingControls;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecHeatingControls_SelectedIndexChanged);
        ComboBox secHeatingControls1 = this._txtSecHeatingControls;
        if (secHeatingControls1 != null)
          secHeatingControls1.SelectedIndexChanged -= eventHandler;
        this._txtSecHeatingControls = value;
        ComboBox secHeatingControls2 = this._txtSecHeatingControls;
        if (secHeatingControls2 == null)
          return;
        secHeatingControls2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label385")]
    internal virtual Label Label385 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox23Sec")]
    internal virtual GroupBox GroupBox23Sec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkSecOilPump")]
    internal virtual CheckBox chkSecOilPump { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecMainFuel
    {
      get => this._txtSecMainFuel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtSecMainFuel_LostFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtSecMainFuel_TextChanged);
        EventHandler eventHandler3 = new EventHandler(this.txtSecMainFuel_SelectedIndexChanged);
        ComboBox txtSecMainFuel1 = this._txtSecMainFuel;
        if (txtSecMainFuel1 != null)
        {
          txtSecMainFuel1.LostFocus -= eventHandler1;
          txtSecMainFuel1.TextChanged -= eventHandler2;
          txtSecMainFuel1.SelectedIndexChanged -= eventHandler3;
        }
        this._txtSecMainFuel = value;
        ComboBox txtSecMainFuel2 = this._txtSecMainFuel;
        if (txtSecMainFuel2 == null)
          return;
        txtSecMainFuel2.LostFocus += eventHandler1;
        txtSecMainFuel2.TextChanged += eventHandler2;
        txtSecMainFuel2.SelectedIndexChanged += eventHandler3;
      }
    }

    [field: AccessedThroughProperty("Label387")]
    internal virtual Label Label387 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox86")]
    internal virtual GroupBox GroupBox86 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecBoilerSub
    {
      get => this._txtSecBoilerSub;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecBoilerSub_SelectedIndexChanged);
        ComboBox txtSecBoilerSub1 = this._txtSecBoilerSub;
        if (txtSecBoilerSub1 != null)
          txtSecBoilerSub1.SelectedIndexChanged -= eventHandler;
        this._txtSecBoilerSub = value;
        ComboBox txtSecBoilerSub2 = this._txtSecBoilerSub;
        if (txtSecBoilerSub2 == null)
          return;
        txtSecBoilerSub2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label388")]
    internal virtual Label Label388 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecHeatingEmitter")]
    internal virtual ComboBox txtSecHeatingEmitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label389")]
    internal virtual Label Label389 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecMainHeatingType
    {
      get => this._txtSecMainHeatingType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecMainHeatingType_SelectedIndexChanged);
        ComboBox secMainHeatingType1 = this._txtSecMainHeatingType;
        if (secMainHeatingType1 != null)
          secMainHeatingType1.SelectedIndexChanged -= eventHandler;
        this._txtSecMainHeatingType = value;
        ComboBox secMainHeatingType2 = this._txtSecMainHeatingType;
        if (secMainHeatingType2 == null)
          return;
        secMainHeatingType2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label390")]
    internal virtual Label Label390 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdBiolerData2
    {
      get => this._cmdBiolerData2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdBiolerData2_Click);
        Button cmdBiolerData2_1 = this._cmdBiolerData2;
        if (cmdBiolerData2_1 != null)
          cmdBiolerData2_1.Click -= eventHandler;
        this._cmdBiolerData2 = value;
        Button cmdBiolerData2_2 = this._cmdBiolerData2;
        if (cmdBiolerData2_2 == null)
          return;
        cmdBiolerData2_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox txtSecHeatingSource
    {
      get => this._txtSecHeatingSource;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecHeatingSource_SelectedIndexChanged);
        ComboBox secHeatingSource1 = this._txtSecHeatingSource;
        if (secHeatingSource1 != null)
          secHeatingSource1.SelectedIndexChanged -= eventHandler;
        this._txtSecHeatingSource = value;
        ComboBox secHeatingSource2 = this._txtSecHeatingSource;
        if (secHeatingSource2 == null)
          return;
        secHeatingSource2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label391")]
    internal virtual Label Label391 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtSecSubGroup
    {
      get => this._txtSecSubGroup;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSecSubGroup_SelectedIndexChanged);
        ComboBox txtSecSubGroup1 = this._txtSecSubGroup;
        if (txtSecSubGroup1 != null)
          txtSecSubGroup1.SelectedIndexChanged -= eventHandler;
        this._txtSecSubGroup = value;
        ComboBox txtSecSubGroup2 = this._txtSecSubGroup;
        if (txtSecSubGroup2 == null)
          return;
        txtSecSubGroup2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox txtSECPrimary
    {
      get => this._txtSECPrimary;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtSECPrimary_SelectedIndexChanged);
        ComboBox txtSecPrimary1 = this._txtSECPrimary;
        if (txtSecPrimary1 != null)
          txtSecPrimary1.SelectedIndexChanged -= eventHandler;
        this._txtSECPrimary = value;
        ComboBox txtSecPrimary2 = this._txtSECPrimary;
        if (txtSecPrimary2 == null)
          return;
        txtSecPrimary2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label392")]
    internal virtual Label Label392 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label393")]
    internal virtual Label Label393 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkIncSecMain
    {
      get => this._ChkIncSecMain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkIncSecMain_CheckedChanged);
        CheckBox chkIncSecMain1 = this._ChkIncSecMain;
        if (chkIncSecMain1 != null)
          chkIncSecMain1.CheckedChanged -= eventHandler;
        this._ChkIncSecMain = value;
        CheckBox chkIncSecMain2 = this._ChkIncSecMain;
        if (chkIncSecMain2 == null)
          return;
        chkIncSecMain2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GrpSecmainHeatingFrac")]
    internal virtual GroupBox GrpSecmainHeatingFrac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TxtHeatFraction
    {
      get => this._TxtHeatFraction;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TxtHeatFraction_TextChanged);
        TextBox txtHeatFraction1 = this._TxtHeatFraction;
        if (txtHeatFraction1 != null)
          txtHeatFraction1.TextChanged -= eventHandler;
        this._TxtHeatFraction = value;
        TextBox txtHeatFraction2 = this._TxtHeatFraction;
        if (txtHeatFraction2 == null)
          return;
        txtHeatFraction2.TextChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label386")]
    internal virtual Label Label386 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkWholep
    {
      get => this._ChkWholep;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkWholep_CheckedChanged);
        CheckBox chkWholep1 = this._ChkWholep;
        if (chkWholep1 != null)
          chkWholep1.CheckedChanged -= eventHandler;
        this._ChkWholep = value;
        CheckBox chkWholep2 = this._ChkWholep;
        if (chkWholep2 == null)
          return;
        chkWholep2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox ChkSeparateP
    {
      get => this._ChkSeparateP;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkSeparateP_CheckedChanged);
        CheckBox chkSeparateP1 = this._ChkSeparateP;
        if (chkSeparateP1 != null)
          chkSeparateP1.CheckedChanged -= eventHandler;
        this._ChkSeparateP = value;
        CheckBox chkSeparateP2 = this._ChkSeparateP;
        if (chkSeparateP2 == null)
          return;
        chkSeparateP2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtHeatPumpExchanger")]
    internal virtual TextBox txtHeatPumpExchanger { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label395")]
    internal virtual Label Label395 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpFGHRS_PV")]
    internal virtual GroupBox grpFGHRS_PV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label394")]
    internal virtual Label Label394 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label396")]
    internal virtual Label Label396 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFGHRS_PV_Orientation")]
    internal virtual ComboBox txtFGHRS_PV_Orientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFGHRS_PV_PP")]
    internal virtual TextBox txtFGHRS_PV_PP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label397")]
    internal virtual Label Label397 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label398")]
    internal virtual Label Label398 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label399")]
    internal virtual Label Label399 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFGHRS_PV_Tilt")]
    internal virtual ComboBox txtFGHRS_PV_Tilt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtFGHRS_PV_OverShading")]
    internal virtual ComboBox txtFGHRS_PV_OverShading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblSmoke")]
    internal virtual ToolStripMenuItem lblSmoke { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDwellingFEE")]
    internal virtual ToolStripLabel lblDwellingFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDwellingFEE")]
    internal virtual ToolStripTextBox txtDwellingFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage21")]
    internal virtual TabPage TabPage21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel1
    {
      get => this._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.Panel1_Paint);
        Panel panel1_1 = this._Panel1;
        if (panel1_1 != null)
          panel1_1.Paint -= paintEventHandler;
        this._Panel1 = value;
        Panel panel1_2 = this._Panel1;
        if (panel1_2 == null)
          return;
        panel1_2.Paint += paintEventHandler;
      }
    }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkNightVentilation")]
    internal virtual CheckBox chkNightVentilation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem Import2009Dwelling
    {
      get => this._Import2009Dwelling;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Import2009Dwelling_Click);
        ToolStripMenuItem import2009Dwelling1 = this._Import2009Dwelling;
        if (import2009Dwelling1 != null)
          import2009Dwelling1.Click -= eventHandler;
        this._Import2009Dwelling = value;
        ToolStripMenuItem import2009Dwelling2 = this._Import2009Dwelling;
        if (import2009Dwelling2 == null)
          return;
        import2009Dwelling2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem8")]
    internal virtual ToolStripSeparator ToolStripMenuItem8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem BlockComplianceToolStripMenuItem
    {
      get => this._BlockComplianceToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BlockComplianceToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._BlockComplianceToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._BlockComplianceToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._BlockComplianceToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem9")]
    internal virtual ToolStripSeparator ToolStripMenuItem9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem CopyDwellingElementsToolStripMenuItem
    {
      get => this._CopyDwellingElementsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopyDwellingElementsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._CopyDwellingElementsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._CopyDwellingElementsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._CopyDwellingElementsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label400")]
    internal virtual Label Label400 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblUserDefined")]
    internal virtual Label lblUserDefined { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdWWHRS2Remove
    {
      get => this._cmdWWHRS2Remove;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdWWHRS2Remove_Click);
        Button cmdWwhrS2Remove1 = this._cmdWWHRS2Remove;
        if (cmdWwhrS2Remove1 != null)
          cmdWwhrS2Remove1.Click -= eventHandler;
        this._cmdWWHRS2Remove = value;
        Button cmdWwhrS2Remove2 = this._cmdWWHRS2Remove;
        if (cmdWwhrS2Remove2 == null)
          return;
        cmdWwhrS2Remove2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Spare1")]
    internal virtual DataGridViewTextBoxColumn Spare1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FloorName")]
    internal virtual DataGridViewTextBoxColumn FloorName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Type")]
    internal virtual DataGridViewComboBoxColumn Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Construction")]
    internal virtual DataGridViewComboBoxColumn Construction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("AreaRoof")]
    internal virtual DataGridViewTextBoxColumn AreaRoof { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("UValueFloor")]
    internal virtual DataGridViewTextBoxColumn UValueFloor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column19")]
    internal virtual DataGridViewTextBoxColumn Column19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn7")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn2")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column18")]
    internal virtual DataGridViewComboBoxColumn Column18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn8")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn9")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn10")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column13")]
    internal virtual DataGridViewTextBoxColumn Column13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column21")]
    internal virtual DataGridViewTextBoxColumn Column21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn53")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn54")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column22")]
    internal virtual DataGridViewComboBoxColumn Column22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn55")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column23")]
    internal virtual DataGridViewTextBoxColumn Column23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn57")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn58")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn4")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn9")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn59")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn60")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn61")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn62")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn63")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn10")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn64")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn66")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn56")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn65")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn3")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn67")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn68")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn69")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn69 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn70")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn5")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn71")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn72")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn73")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn74")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn74 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn6")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn75")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn75 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn76")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn76 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("GroupBox71")]
    internal virtual GroupBox GroupBox71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdUseClient
    {
      get => this._cmdUseClient;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdUseClient_Click);
        Button cmdUseClient1 = this._cmdUseClient;
        if (cmdUseClient1 != null)
          cmdUseClient1.Click -= eventHandler;
        this._cmdUseClient = value;
        Button cmdUseClient2 = this._cmdUseClient;
        if (cmdUseClient2 == null)
          return;
        cmdUseClient2.Click += eventHandler;
      }
    }

    internal virtual Button cmdSaveClient
    {
      get => this._cmdSaveClient;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSaveClient_Click);
        Button cmdSaveClient1 = this._cmdSaveClient;
        if (cmdSaveClient1 != null)
          cmdSaveClient1.Click -= eventHandler;
        this._cmdSaveClient = value;
        Button cmdSaveClient2 = this._cmdSaveClient;
        if (cmdSaveClient2 == null)
          return;
        cmdSaveClient2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("cboClientDetails")]
    internal virtual ComboBox cboClientDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label401")]
    internal virtual Label Label401 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem10")]
    internal virtual ToolStripSeparator ToolStripMenuItem10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SelectALogoToolStripMenuItem
    {
      get => this._SelectALogoToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SelectALogoToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SelectALogoToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SelectALogoToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SelectALogoToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton cmdCompliance
    {
      get => this._cmdCompliance;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdCompliance_Click);
        ToolStripButton cmdCompliance1 = this._cmdCompliance;
        if (cmdCompliance1 != null)
          cmdCompliance1.Click -= eventHandler;
        this._cmdCompliance = value;
        ToolStripButton cmdCompliance2 = this._cmdCompliance;
        if (cmdCompliance2 == null)
          return;
        cmdCompliance2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox72")]
    internal virtual GroupBox GroupBox72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtLELLights
    {
      get => this._txtLELLights;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLELOutlets_ValueChanged);
        NumericUpDown txtLelLights1 = this._txtLELLights;
        if (txtLelLights1 != null)
          txtLelLights1.ValueChanged -= eventHandler;
        this._txtLELLights = value;
        NumericUpDown txtLelLights2 = this._txtLELLights;
        if (txtLelLights2 == null)
          return;
        txtLelLights2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown txtLELOutlets
    {
      get => this._txtLELOutlets;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtLELOutlets_ValueChanged);
        NumericUpDown txtLelOutlets1 = this._txtLELOutlets;
        if (txtLelOutlets1 != null)
          txtLelOutlets1.ValueChanged -= eventHandler;
        this._txtLELOutlets = value;
        NumericUpDown txtLelOutlets2 = this._txtLELOutlets;
        if (txtLelOutlets2 == null)
          return;
        txtLelOutlets2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label403")]
    internal virtual Label Label403 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label402")]
    internal virtual Label Label402 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkAverageValue
    {
      get => this._chkAverageValue;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkAverageValue_MouseLeave);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.chkAverageValue_MouseMove);
        CheckBox chkAverageValue1 = this._chkAverageValue;
        if (chkAverageValue1 != null)
        {
          chkAverageValue1.MouseLeave -= eventHandler;
          chkAverageValue1.MouseMove -= mouseEventHandler;
        }
        this._chkAverageValue = value;
        CheckBox chkAverageValue2 = this._chkAverageValue;
        if (chkAverageValue2 == null)
          return;
        chkAverageValue2.MouseLeave += eventHandler;
        chkAverageValue2.MouseMove += mouseEventHandler;
      }
    }

    [field: AccessedThroughProperty("lblHelp")]
    internal virtual Label lblHelp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("pnlHelp")]
    internal virtual Panel pnlHelp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ImportFSAP2005DwellingToolStripMenuItem
    {
      get => this._ImportFSAP2005DwellingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ImportFSAP2005DwellingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ImportFSAP2005DwellingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ImportFSAP2005DwellingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ImportFSAP2005DwellingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual Button Button10
    {
      get => this._Button10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button10_Click_1);
        Button button10_1 = this._Button10;
        if (button10_1 != null)
          button10_1.Click -= eventHandler;
        this._Button10 = value;
        Button button10_2 = this._Button10;
        if (button10_2 == null)
          return;
        button10_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("EditMenu")]
    internal virtual ContextMenuStrip EditMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem DeleteToolStripMenuItem
    {
      get => this._DeleteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DeleteToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DeleteToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DeleteToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem14")]
    internal virtual ToolStripSeparator ToolStripMenuItem14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem MoveTooToolStripMenuItem
    {
      get => this._MoveTooToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MoveTooToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._MoveTooToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._MoveTooToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._MoveTooToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton7
    {
      get => this._ToolStripButton7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton7_Click);
        ToolStripButton toolStripButton7_1 = this._ToolStripButton7;
        if (toolStripButton7_1 != null)
          toolStripButton7_1.Click -= eventHandler;
        this._ToolStripButton7 = value;
        ToolStripButton toolStripButton7_2 = this._ToolStripButton7;
        if (toolStripButton7_2 == null)
          return;
        toolStripButton7_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButton8
    {
      get => this._ToolStripButton8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton8_Click);
        ToolStripButton toolStripButton8_1 = this._ToolStripButton8;
        if (toolStripButton8_1 != null)
          toolStripButton8_1.Click -= eventHandler;
        this._ToolStripButton8 = value;
        ToolStripButton toolStripButton8_2 = this._ToolStripButton8;
        if (toolStripButton8_2 == null)
          return;
        toolStripButton8_2.Click += eventHandler;
      }
    }

    internal virtual Button cmdGetWallArea
    {
      get => this._cmdGetWallArea;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cmdGetWallArea_Click);
        EventHandler eventHandler2 = new EventHandler(this.cmdGetWallArea_MouseLeave);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.cmdGetWallArea_MouseMove);
        Button cmdGetWallArea1 = this._cmdGetWallArea;
        if (cmdGetWallArea1 != null)
        {
          cmdGetWallArea1.Click -= eventHandler1;
          cmdGetWallArea1.MouseLeave -= eventHandler2;
          cmdGetWallArea1.MouseMove -= mouseEventHandler;
        }
        this._cmdGetWallArea = value;
        Button cmdGetWallArea2 = this._cmdGetWallArea;
        if (cmdGetWallArea2 == null)
          return;
        cmdGetWallArea2.Click += eventHandler1;
        cmdGetWallArea2.MouseLeave += eventHandler2;
        cmdGetWallArea2.MouseMove += mouseEventHandler;
      }
    }

    [field: AccessedThroughProperty("lblWallArea")]
    internal virtual Label lblWallArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblOrientation")]
    internal virtual Label lblOrientation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem11")]
    internal virtual ToolStripSeparator ToolStripMenuItem11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem EditClientDatabaseToolStripMenuItem
    {
      get => this._EditClientDatabaseToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EditClientDatabaseToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._EditClientDatabaseToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._EditClientDatabaseToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._EditClientDatabaseToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual Button cmdEditClientData
    {
      get => this._cmdEditClientData;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdEditClientData_Click);
        Button cmdEditClientData1 = this._cmdEditClientData;
        if (cmdEditClientData1 != null)
          cmdEditClientData1.Click -= eventHandler;
        this._cmdEditClientData = value;
        Button cmdEditClientData2 = this._cmdEditClientData;
        if (cmdEditClientData2 == null)
          return;
        cmdEditClientData2.Click += eventHandler;
      }
    }

    internal virtual BackgroundWorker SEDBUKUPdate
    {
      get => this._SEDBUKUPdate;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.SEDBUKUPdate_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.SEDBUKUPdate_RunWorkerCompleted);
        BackgroundWorker sedbukuPdate1 = this._SEDBUKUPdate;
        if (sedbukuPdate1 != null)
        {
          sedbukuPdate1.DoWork -= workEventHandler;
          sedbukuPdate1.RunWorkerCompleted -= completedEventHandler;
        }
        this._SEDBUKUPdate = value;
        BackgroundWorker sedbukuPdate2 = this._SEDBUKUPdate;
        if (sedbukuPdate2 == null)
          return;
        sedbukuPdate2.DoWork += workEventHandler;
        sedbukuPdate2.RunWorkerCompleted += completedEventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem12")]
    internal virtual ToolStripSeparator ToolStripMenuItem12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem CodeForSustainableHomesReportToolStripMenuItem
    {
      get => this._CodeForSustainableHomesReportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CodeForSustainableHomesReportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._CodeForSustainableHomesReportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._CodeForSustainableHomesReportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._CodeForSustainableHomesReportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem13")]
    internal virtual ToolStripSeparator ToolStripMenuItem13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ProjectKeyResultsToolStripMenuItem
    {
      get => this._ProjectKeyResultsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ProjectKeyResultsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ProjectKeyResultsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ProjectKeyResultsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ProjectKeyResultsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem15")]
    internal virtual ToolStripSeparator ToolStripMenuItem15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem GenerateBatchDwellingReportsToolStripMenuItem
    {
      get => this._GenerateBatchDwellingReportsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GenerateBatchDwellingReportsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._GenerateBatchDwellingReportsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._GenerateBatchDwellingReportsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._GenerateBatchDwellingReportsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual Button cmdShowY
    {
      get => this._cmdShowY;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdShowY_Click);
        Button cmdShowY1 = this._cmdShowY;
        if (cmdShowY1 != null)
          cmdShowY1.Click -= eventHandler;
        this._cmdShowY = value;
        Button cmdShowY2 = this._cmdShowY;
        if (cmdShowY2 == null)
          return;
        cmdShowY2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtScotFrontPageOnly")]
    internal virtual ComboBox txtScotFrontPageOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LBLScotDisplayFrontpageOnly")]
    internal virtual Label LBLScotDisplayFrontpageOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LblGraph")]
    internal virtual Label LblGraph { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SimplifyTestToolStripMenuItem
    {
      get => this._SimplifyTestToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SimplifyTestToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SimplifyTestToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SimplifyTestToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SimplifyTestToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem CreateXMLToolStripMenuItem1
    {
      get => this._CreateXMLToolStripMenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CreateXMLToolStripMenuItem1_Click);
        ToolStripMenuItem toolStripMenuItem1_1 = this._CreateXMLToolStripMenuItem1;
        if (toolStripMenuItem1_1 != null)
          toolStripMenuItem1_1.Click -= eventHandler;
        this._CreateXMLToolStripMenuItem1 = value;
        ToolStripMenuItem toolStripMenuItem1_2 = this._CreateXMLToolStripMenuItem1;
        if (toolStripMenuItem1_2 == null)
          return;
        toolStripMenuItem1_2.Click += eventHandler;
      }
    }

    internal virtual ComboBox ScotGraphs
    {
      get => this._ScotGraphs;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ScotGraphs_SelectedIndexChanged);
        ComboBox scotGraphs1 = this._ScotGraphs;
        if (scotGraphs1 != null)
          scotGraphs1.SelectedIndexChanged -= eventHandler;
        this._ScotGraphs = value;
        ComboBox scotGraphs2 = this._ScotGraphs;
        if (scotGraphs2 == null)
          return;
        scotGraphs2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem16")]
    internal virtual ToolStripSeparator ToolStripMenuItem16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem17")]
    internal virtual ToolStripSeparator ToolStripMenuItem17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem UValueEditorToolStripMenuItem
    {
      get => this._UValueEditorToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UValueEditorToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._UValueEditorToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._UValueEditorToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._UValueEditorToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip ctxUValue
    {
      get => this._ctxUValue;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ctxUValue_Opening);
        ContextMenuStrip ctxUvalue1 = this._ctxUValue;
        if (ctxUvalue1 != null)
          ctxUvalue1.Opening -= cancelEventHandler;
        this._ctxUValue = value;
        ContextMenuStrip ctxUvalue2 = this._ctxUValue;
        if (ctxUvalue2 == null)
          return;
        ctxUvalue2.Opening += cancelEventHandler;
      }
    }

    internal virtual ToolStripMenuItem SelectUValueToolStripMenuItem
    {
      get => this._SelectUValueToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SelectUValueToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SelectUValueToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SelectUValueToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SelectUValueToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem18")]
    internal virtual ToolStripSeparator ToolStripMenuItem18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem EditUvaluesToolStripMenuItem
    {
      get => this._EditUvaluesToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EditUvaluesToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._EditUvaluesToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._EditUvaluesToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._EditUvaluesToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem RemoveUvalueToolStripMenuItem
    {
      get => this._RemoveUvalueToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RemoveUvalueToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._RemoveUvalueToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._RemoveUvalueToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._RemoveUvalueToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem19")]
    internal virtual ToolStripSeparator ToolStripMenuItem19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("UValueConnection")]
    internal virtual ToolStripMenuItem UValueConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem20")]
    internal virtual ToolStripSeparator ToolStripMenuItem20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CancelToolStripMenuItem")]
    internal virtual ToolStripMenuItem CancelToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem21")]
    internal virtual ToolStripSeparator ToolStripMenuItem21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem LodgementShowDialogToolStripMenuItem
    {
      get => this._LodgementShowDialogToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LodgementShowDialogToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._LodgementShowDialogToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._LodgementShowDialogToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._LodgementShowDialogToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn1")]
    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column16")]
    internal virtual DataGridViewComboBoxColumn Column16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column12")]
    internal virtual DataGridViewTextBoxColumn Column12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Curtain")]
    internal virtual DataGridViewCheckBoxColumn Curtain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column20")]
    internal virtual DataGridViewTextBoxColumn Column20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label404")]
    internal virtual Label Label404 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem PredictedEPCToolStripMenuItem
    {
      get => this._PredictedEPCToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PredictedEPCToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._PredictedEPCToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._PredictedEPCToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._PredictedEPCToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("LBlInstruction")]
    internal virtual Label LBlInstruction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ChangeDwellingTypeToolStripMenuItem
    {
      get => this._ChangeDwellingTypeToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChangeDwellingTypeToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ChangeDwellingTypeToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ChangeDwellingTypeToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ChangeDwellingTypeToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem22")]
    internal virtual ToolStripSeparator ToolStripMenuItem22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ShowAllSuccessfulLodgementsToolStripMenuItem
    {
      get => this._ShowAllSuccessfulLodgementsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ShowAllSuccessfulLodgementsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ShowAllSuccessfulLodgementsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ShowAllSuccessfulLodgementsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ShowAllSuccessfulLodgementsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem mnulblPreCSH
    {
      get => this._mnulblPreCSH;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.mnulblPreCSH_Click);
        ToolStripMenuItem mnulblPreCsh1 = this._mnulblPreCSH;
        if (mnulblPreCsh1 != null)
          mnulblPreCsh1.Click -= eventHandler;
        this._mnulblPreCSH = value;
        ToolStripMenuItem mnulblPreCsh2 = this._mnulblPreCSH;
        if (mnulblPreCsh2 == null)
          return;
        mnulblPreCsh2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolStripMenuItem23")]
    internal virtual ToolStripSeparator ToolStripMenuItem23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SelectHistoricCalculationVersionsToolStripMenuItem
    {
      get => this._SelectHistoricCalculationVersionsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SelectHistoricCalculationVersionsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SelectHistoricCalculationVersionsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SelectHistoricCalculationVersionsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SelectHistoricCalculationVersionsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn33")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn34")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn35")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column11")]
    internal virtual DataGridViewTextBoxColumn Column11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn36")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn37")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn38")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn39")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn40")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn41")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn42")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn43")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn44")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn45")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn46")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn47")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn48")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn49")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn50")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn51")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn52")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn11")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn12")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn13")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn14")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn15")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn16")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn17")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn18")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn19")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn20")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn21")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn23")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn25")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn26")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn27")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn28")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn29")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn30")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn31")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn32")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn22")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ColLocation1")]
    internal virtual DataGridViewTextBoxColumn ColLocation1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ColUValueSource1")]
    internal virtual DataGridViewTextBoxColumn ColUValueSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column17")]
    internal virtual DataGridViewTextBoxColumn Column17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column1")]
    internal virtual DataGridViewTextBoxColumn Column1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column2")]
    internal virtual DataGridViewTextBoxColumn Column2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column3")]
    internal virtual DataGridViewTextBoxColumn Column3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column4")]
    internal virtual DataGridViewTextBoxColumn Column4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column5")]
    internal virtual DataGridViewTextBoxColumn Column5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column6")]
    internal virtual DataGridViewTextBoxColumn Column6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column7")]
    internal virtual DataGridViewTextBoxColumn Column7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column8")]
    internal virtual DataGridViewTextBoxColumn Column8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column9")]
    internal virtual DataGridViewTextBoxColumn Column9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column10")]
    internal virtual DataGridViewTextBoxColumn Column10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column14")]
    internal virtual DataGridViewTextBoxColumn Column14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Column15")]
    internal virtual DataGridViewTextBoxColumn Column15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn24")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdAddAddress
    {
      get => this._cmdAddAddress;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAddAddress_Click);
        Button cmdAddAddress1 = this._cmdAddAddress;
        if (cmdAddAddress1 != null)
          cmdAddAddress1.Click -= eventHandler;
        this._cmdAddAddress = value;
        Button cmdAddAddress2 = this._cmdAddAddress;
        if (cmdAddAddress2 == null)
          return;
        cmdAddAddress2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("NotesToolStripMenuItem")]
    internal virtual ToolStripMenuItem NotesToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ProjectNotesToolStripMenuItem
    {
      get => this._ProjectNotesToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ProjectNotesToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ProjectNotesToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ProjectNotesToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ProjectNotesToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ToolTip1")]
    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip2")]
    internal virtual ToolTip ToolTip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem24")]
    internal virtual ToolStripSeparator ToolStripMenuItem24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ShowNotesToolStripMenuItem
    {
      get => this._ShowNotesToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ShowNotesToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ShowNotesToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ShowNotesToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ShowNotesToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem NHERXMLImportToolStripMenuItem
    {
      get => this._NHERXMLImportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NHERXMLImportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._NHERXMLImportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._NHERXMLImportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._NHERXMLImportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("FolderBrowserDialog1")]
    internal virtual FolderBrowserDialog FolderBrowserDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem AutoSaveToolStripMenuItem
    {
      get => this._AutoSaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AutoSaveToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._AutoSaveToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._AutoSaveToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._AutoSaveToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer TimerAutoSave
    {
      get => this._TimerAutoSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TimerAutoSave_Tick_1);
        System.Windows.Forms.Timer timerAutoSave1 = this._TimerAutoSave;
        if (timerAutoSave1 != null)
          timerAutoSave1.Tick -= eventHandler;
        this._TimerAutoSave = value;
        System.Windows.Forms.Timer timerAutoSave2 = this._TimerAutoSave;
        if (timerAutoSave2 == null)
          return;
        timerAutoSave2.Tick += eventHandler;
      }
    }

    [field: AccessedThroughProperty("LblError")]
    internal virtual ToolStripLabel LblError { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button12
    {
      get => this._Button12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button12_Click);
        Button button12_1 = this._Button12;
        if (button12_1 != null)
          button12_1.Click -= eventHandler;
        this._Button12 = value;
        Button button12_2 = this._Button12;
        if (button12_2 == null)
          return;
        button12_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ConnectionCheckToolStripMenuItem
    {
      get => this._ConnectionCheckToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ConnectionCheckToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ConnectionCheckToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ConnectionCheckToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ConnectionCheckToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem DwellingCountToolStripMenuItem
    {
      get => this._DwellingCountToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DwellingCountToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DwellingCountToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DwellingCountToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DwellingCountToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtTenure")]
    internal virtual ComboBox txtTenure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label405")]
    internal virtual Label Label405 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolStripMenuItem26")]
    internal virtual ToolStripSeparator ToolStripMenuItem26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem cmdImportLig16
    {
      get => this._cmdImportLig16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdImportLig16_Click);
        ToolStripMenuItem cmdImportLig16_1 = this._cmdImportLig16;
        if (cmdImportLig16_1 != null)
          cmdImportLig16_1.Click -= eventHandler;
        this._cmdImportLig16 = value;
        ToolStripMenuItem cmdImportLig16_2 = this._cmdImportLig16;
        if (cmdImportLig16_2 == null)
          return;
        cmdImportLig16_2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ShowECOResultsFormToolStripMenuItem
    {
      get => this._ShowECOResultsFormToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ShowECOResultsFormToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ShowECOResultsFormToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ShowECOResultsFormToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ShowECOResultsFormToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual Button cmdMainControlSelect
    {
      get => this._cmdMainControlSelect;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdMainControlSelect_Click);
        Button mainControlSelect1 = this._cmdMainControlSelect;
        if (mainControlSelect1 != null)
          mainControlSelect1.Click -= eventHandler;
        this._cmdMainControlSelect = value;
        Button mainControlSelect2 = this._cmdMainControlSelect;
        if (mainControlSelect2 == null)
          return;
        mainControlSelect2.Click += eventHandler;
      }
    }

    internal virtual Button cmdSecControlSelect
    {
      get => this._cmdSecControlSelect;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSecControlSelect_Click);
        Button secControlSelect1 = this._cmdSecControlSelect;
        if (secControlSelect1 != null)
          secControlSelect1.Click -= eventHandler;
        this._cmdSecControlSelect = value;
        Button secControlSelect2 = this._cmdSecControlSelect;
        if (secControlSelect2 == null)
          return;
        secControlSelect2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label406")]
    internal virtual Label Label406 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSolarHLoss2")]
    internal virtual TextBox txtSolarHLoss2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label408")]
    internal virtual Label Label408 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label407")]
    internal virtual Label Label407 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtPumpType")]
    internal virtual ComboBox txtPumpType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label409")]
    internal virtual Label Label409 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ProjectCreationDateToolStripMenuItem
    {
      get => this._ProjectCreationDateToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ProjectCreationDateToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ProjectCreationDateToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ProjectCreationDateToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ProjectCreationDateToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem DwellingCreationDateToolStripMenuItem
    {
      get => this._DwellingCreationDateToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DwellingCreationDateToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DwellingCreationDateToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DwellingCreationDateToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DwellingCreationDateToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("cboPipeWorkInsulated")]
    internal virtual ComboBox cboPipeWorkInsulated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label410")]
    internal virtual Label Label410 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label411")]
    internal virtual Label Label411 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cboPVConnection")]
    internal virtual ComboBox cboPVConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkPVDirect
    {
      get => this._chkPVDirect;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkPVDirect_CheckedChanged);
        CheckBox chkPvDirect1 = this._chkPVDirect;
        if (chkPvDirect1 != null)
          chkPvDirect1.CheckedChanged -= eventHandler;
        this._chkPVDirect = value;
        CheckBox chkPvDirect2 = this._chkPVDirect;
        if (chkPvDirect2 == null)
          return;
        chkPvDirect2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("cboSolarShower")]
    internal virtual ComboBox cboSolarShower { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label412")]
    internal virtual Label Label412 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cboBoilerFlowTemp")]
    internal virtual ComboBox cboBoilerFlowTemp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label413")]
    internal virtual Label Label413 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpStorage")]
    internal virtual GroupBox grpStorage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaStorage")]
    internal virtual DataGridView dtaStorage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdStorage
    {
      get => this._cmdStorage;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdStorage_Click);
        Button cmdStorage1 = this._cmdStorage;
        if (cmdStorage1 != null)
          cmdStorage1.Click -= eventHandler;
        this._cmdStorage = value;
        Button cmdStorage2 = this._cmdStorage;
        if (cmdStorage2 == null)
          return;
        cmdStorage2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblDwellingTFEE")]
    internal virtual ToolStripLabel lblDwellingTFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtTFEE")]
    internal virtual ToolStripTextBox txtTFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label415")]
    internal virtual Label Label415 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRSStore2")]
    internal virtual TextBox txtWWHRSStore2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label414")]
    internal virtual Label Label414 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label416")]
    internal virtual Label Label416 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtWWHRSStore1")]
    internal virtual TextBox txtWWHRSStore1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label417")]
    internal virtual Label Label417 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdMainControlSelectWeather
    {
      get => this._cmdMainControlSelectWeather;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdMainControlSelectWeather_Click);
        Button controlSelectWeather1 = this._cmdMainControlSelectWeather;
        if (controlSelectWeather1 != null)
          controlSelectWeather1.Click -= eventHandler;
        this._cmdMainControlSelectWeather = value;
        Button controlSelectWeather2 = this._cmdMainControlSelectWeather;
        if (controlSelectWeather2 == null)
          return;
        controlSelectWeather2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblControlWeather")]
    internal virtual Label lblControlWeather { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblControlTTZ")]
    internal virtual Label lblControlTTZ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommunitySourceSEDBUK")]
    internal virtual GroupBox grpCommunitySourceSEDBUK { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaCommunitySource")]
    internal virtual DataGridView dtaCommunitySource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpCommunitySEDBUK")]
    internal virtual GroupBox grpCommunitySEDBUK { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaCommunity")]
    internal virtual DataGridView dtaCommunity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grdCommunityWaterSources")]
    internal virtual GroupBox grdCommunityWaterSources { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaCommunitySourceWater")]
    internal virtual DataGridView dtaCommunitySourceWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("chkMCS")]
    internal virtual CheckBox chkMCS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label185")]
    internal virtual Label Label185 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtEmissionsOnly")]
    internal virtual TextBox txtEmissionsOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label418")]
    internal virtual Label Label418 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkEmissionsOnly
    {
      get => this._chkEmissionsOnly;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkEmissionsOnly_CheckedChanged);
        CheckBox chkEmissionsOnly1 = this._chkEmissionsOnly;
        if (chkEmissionsOnly1 != null)
          chkEmissionsOnly1.CheckedChanged -= eventHandler;
        this._chkEmissionsOnly = value;
        CheckBox chkEmissionsOnly2 = this._chkEmissionsOnly;
        if (chkEmissionsOnly2 == null)
          return;
        chkEmissionsOnly2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label419")]
    internal virtual Label Label419 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtEmissionsOnlyCreated")]
    internal virtual TextBox txtEmissionsOnlyCreated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label420")]
    internal virtual Label Label420 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage22")]
    internal virtual TabPage TabPage22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage23")]
    internal virtual TabPage TabPage23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblSecControlWeather")]
    internal virtual Label lblSecControlWeather { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button cmdSecMainControlSelectWeather
    {
      get => this._cmdSecMainControlSelectWeather;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdSecMainControlSelectWeather_Click);
        Button controlSelectWeather1 = this._cmdSecMainControlSelectWeather;
        if (controlSelectWeather1 != null)
          controlSelectWeather1.Click -= eventHandler;
        this._cmdSecMainControlSelectWeather = value;
        Button controlSelectWeather2 = this._cmdSecMainControlSelectWeather;
        if (controlSelectWeather2 == null)
          return;
        controlSelectWeather2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("chkSecMCS")]
    internal virtual CheckBox chkSecMCS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("cboSecBoilerFlowTemp")]
    internal virtual ComboBox cboSecBoilerFlowTemp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label422")]
    internal virtual Label Label422 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtSecPumpType")]
    internal virtual ComboBox txtSecPumpType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label421")]
    internal virtual Label Label421 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblSecControlTTZ")]
    internal virtual Label lblSecControlTTZ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PGEPCCosts")]
    internal virtual PropertyGrid PGEPCCosts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PGTFEE")]
    internal virtual PropertyGrid PGTFEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblCommHeatWarningWater")]
    internal virtual Label lblCommHeatWarningWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblCommHeatWarning")]
    internal virtual Label lblCommHeatWarning { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("LBlManu")]
    internal virtual Label LBlManu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtLossKnown")]
    internal virtual TextBox txtLossKnown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox ChkKnown
    {
      get => this._ChkKnown;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChkKnown_CheckedChanged);
        CheckBox chkKnown1 = this._ChkKnown;
        if (chkKnown1 != null)
          chkKnown1.CheckedChanged -= eventHandler;
        this._ChkKnown = value;
        CheckBox chkKnown2 = this._ChkKnown;
        if (chkKnown2 == null)
          return;
        chkKnown2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupFlatPosition")]
    internal virtual GroupBox GroupFlatPosition { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label423")]
    internal virtual Label Label423 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CboDwellingBelow")]
    internal virtual ComboBox CboDwellingBelow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CboDwellingAbove")]
    internal virtual ComboBox CboDwellingAbove { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label426")]
    internal virtual Label Label426 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ReOrderingToolStripMenuItem
    {
      get => this._ReOrderingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ReOrderingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ReOrderingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ReOrderingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ReOrderingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("HQMToolStripMenuItem")]
    internal virtual ToolStripMenuItem HQMToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SingleXMLToolStripMenuItem
    {
      get => this._SingleXMLToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SingleXMLToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SingleXMLToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SingleXMLToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SingleXMLToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem BatchXMLsToolStripMenuItem
    {
      get => this._BatchXMLsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BatchXMLsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._BatchXMLsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._BatchXMLsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._BatchXMLsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem XMLDownloadHistoryToolStripMenuItem
    {
      get => this._XMLDownloadHistoryToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.XMLDownloadHistoryToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._XMLDownloadHistoryToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._XMLDownloadHistoryToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._XMLDownloadHistoryToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem VersionHistoryToolStripMenuItem
    {
      get => this._VersionHistoryToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.VersionHistoryToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._VersionHistoryToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._VersionHistoryToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._VersionHistoryToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("GroupBox73")]
    internal virtual GroupBox GroupBox73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label424")]
    internal virtual Label Label424 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtHydroArea")]
    internal virtual TextBox txtHydroArea { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label425")]
    internal virtual Label Label425 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtHydroGenerated")]
    internal virtual TextBox txtHydroGenerated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label427")]
    internal virtual Label Label427 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label428")]
    internal virtual Label Label428 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkHydroInclude
    {
      get => this._chkHydroInclude;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkHydroInclude_CheckedChanged);
        CheckBox chkHydroInclude1 = this._chkHydroInclude;
        if (chkHydroInclude1 != null)
          chkHydroInclude1.CheckedChanged -= eventHandler;
        this._chkHydroInclude = value;
        CheckBox chkHydroInclude2 = this._chkHydroInclude;
        if (chkHydroInclude2 == null)
          return;
        chkHydroInclude2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblImportedYvalue")]
    internal virtual Label lblImportedYvalue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblImported")]
    internal virtual Label lblImported { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem SignOffReportToolStripMenuItem
    {
      get => this._SignOffReportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SignOffReportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._SignOffReportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._SignOffReportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._SignOffReportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grdCommunityWater")]
    internal virtual GroupBox grdCommunityWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dtaCommunityWater")]
    internal virtual DataGridView dtaCommunityWater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDHWComm")]
    internal virtual GroupBox grpDHWComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtKnownLoss")]
    internal virtual TextBox txtKnownLoss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkKnownLoss
    {
      get => this._chkKnownLoss;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkKnownLoss_CheckedChanged);
        CheckBox chkKnownLoss1 = this._chkKnownLoss;
        if (chkKnownLoss1 != null)
          chkKnownLoss1.CheckedChanged -= eventHandler;
        this._chkKnownLoss = value;
        CheckBox chkKnownLoss2 = this._chkKnownLoss;
        if (chkKnownLoss2 == null)
          return;
        chkKnownLoss2.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button cmdCommunityDatabase
    {
      get => this._cmdCommunityDatabase;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdCommunityDatabase_Click);
        Button communityDatabase1 = this._cmdCommunityDatabase;
        if (communityDatabase1 != null)
          communityDatabase1.Click -= eventHandler;
        this._cmdCommunityDatabase = value;
        Button communityDatabase2 = this._cmdCommunityDatabase;
        if (communityDatabase2 == null)
          return;
        communityDatabase2.Click += eventHandler;
      }
    }

    internal virtual CheckBox optCommunityDatabase
    {
      get => this._optCommunityDatabase;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.optCommunityDatabase_CheckedChanged);
        CheckBox communityDatabase1 = this._optCommunityDatabase;
        if (communityDatabase1 != null)
          communityDatabase1.CheckedChanged -= eventHandler;
        this._optCommunityDatabase = value;
        CheckBox communityDatabase2 = this._optCommunityDatabase;
        if (communityDatabase2 == null)
          return;
        communityDatabase2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("txtDHWCommCharging")]
    internal virtual ComboBox txtDHWCommCharging { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label331")]
    internal virtual Label Label331 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual NumericUpDown txtDHWCommHNoOfAdditional
    {
      get => this._txtDHWCommHNoOfAdditional;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDHWCommHNoOfAdditional_ValueChanged);
        NumericUpDown commHnoOfAdditional1 = this._txtDHWCommHNoOfAdditional;
        if (commHnoOfAdditional1 != null)
          commHnoOfAdditional1.ValueChanged -= eventHandler;
        this._txtDHWCommHNoOfAdditional = value;
        NumericUpDown commHnoOfAdditional2 = this._txtDHWCommHNoOfAdditional;
        if (commHnoOfAdditional2 == null)
          return;
        commHnoOfAdditional2.ValueChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label330")]
    internal virtual Label Label330 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommFraction")]
    internal virtual TextBox txtDHWCommFraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label329")]
    internal virtual Label Label329 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel12")]
    internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDHWCommHAdd4")]
    internal virtual GroupBox grpDHWCommHAdd4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label309")]
    internal virtual Label Label309 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd4Efficiency")]
    internal virtual TextBox txtDHWCommHAdd4Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label310")]
    internal virtual Label Label310 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd4Fraction")]
    internal virtual TextBox txtDHWCommHAdd4Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label311")]
    internal virtual Label Label311 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd4Fuel")]
    internal virtual ComboBox txtDHWCommHAdd4Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label312")]
    internal virtual Label Label312 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd4Type")]
    internal virtual ComboBox txtDHWCommHAdd4Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label313")]
    internal virtual Label Label313 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDHWCommHAdd1")]
    internal virtual GroupBox grpDHWCommHAdd1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label314")]
    internal virtual Label Label314 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd1Efficiency")]
    internal virtual TextBox txtDHWCommHAdd1Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label315")]
    internal virtual Label Label315 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd1Fraction")]
    internal virtual TextBox txtDHWCommHAdd1Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label316")]
    internal virtual Label Label316 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd1Fuel")]
    internal virtual ComboBox txtDHWCommHAdd1Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label317")]
    internal virtual Label Label317 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd1Type")]
    internal virtual ComboBox txtDHWCommHAdd1Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label318")]
    internal virtual Label Label318 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDHWCommHAdd3")]
    internal virtual GroupBox grpDHWCommHAdd3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label319")]
    internal virtual Label Label319 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd3Efficiency")]
    internal virtual TextBox txtDHWCommHAdd3Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label320")]
    internal virtual Label Label320 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd3Fraction")]
    internal virtual TextBox txtDHWCommHAdd3Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label321")]
    internal virtual Label Label321 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd3Fuel")]
    internal virtual ComboBox txtDHWCommHAdd3Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label322")]
    internal virtual Label Label322 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd3Type")]
    internal virtual ComboBox txtDHWCommHAdd3Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label323")]
    internal virtual Label Label323 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpDHWCommHAdd2")]
    internal virtual GroupBox grpDHWCommHAdd2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label324")]
    internal virtual Label Label324 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd2Efficiency")]
    internal virtual TextBox txtDHWCommHAdd2Efficiency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label325")]
    internal virtual Label Label325 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd2Fraction")]
    internal virtual TextBox txtDHWCommHAdd2Fraction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label326")]
    internal virtual Label Label326 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd2Fuel")]
    internal virtual ComboBox txtDHWCommHAdd2Fuel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label327")]
    internal virtual Label Label327 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHAdd2Type")]
    internal virtual ComboBox txtDHWCommHAdd2Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label328")]
    internal virtual Label Label328 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommEff")]
    internal virtual TextBox txtDHWCommEff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label186")]
    internal virtual Label Label186 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommHDS")]
    internal virtual ComboBox txtDHWCommHDS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label187")]
    internal virtual Label Label187 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDHWCommCHP")]
    internal virtual TextBox txtDHWCommCHP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkDHWCommCylinder
    {
      get => this._chkDHWCommCylinder;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkDHWCommCylinder_CheckedChanged);
        CheckBox chkDhwCommCylinder1 = this._chkDHWCommCylinder;
        if (chkDhwCommCylinder1 != null)
          chkDhwCommCylinder1.CheckedChanged -= eventHandler;
        this._chkDHWCommCylinder = value;
        CheckBox chkDhwCommCylinder2 = this._chkDHWCommCylinder;
        if (chkDhwCommCylinder2 == null)
          return;
        chkDhwCommCylinder2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label191")]
    internal virtual Label Label191 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpWBoiler")]
    internal virtual GroupBox grpWBoiler { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox txtWCombiType
    {
      get => this._txtWCombiType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtWCombiType_SelectedIndexChanged);
        ComboBox txtWcombiType1 = this._txtWCombiType;
        if (txtWcombiType1 != null)
          txtWcombiType1.SelectedIndexChanged -= eventHandler;
        this._txtWCombiType = value;
        ComboBox txtWcombiType2 = this._txtWCombiType;
        if (txtWcombiType2 == null)
          return;
        txtWcombiType2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("Label201")]
    internal virtual Label Label201 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("grpThermalStore")]
    internal virtual GroupBox grpThermalStore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtThermalConnection")]
    internal virtual ComboBox txtThermalConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label189")]
    internal virtual Label Label189 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtThermalLocation")]
    internal virtual ComboBox txtThermalLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label188")]
    internal virtual Label Label188 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtThermalType")]
    internal virtual ComboBox txtThermalType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label184")]
    internal virtual Label Label184 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox chkThermal
    {
      get => this._chkThermal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkThermal_CheckedChanged);
        CheckBox chkThermal1 = this._chkThermal;
        if (chkThermal1 != null)
          chkThermal1.CheckedChanged -= eventHandler;
        this._chkThermal = value;
        CheckBox chkThermal2 = this._chkThermal;
        if (chkThermal2 == null)
          return;
        chkThermal2.CheckedChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("grpCPSU")]
    internal virtual GroupBox grpCPSU { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtCPSUTemp")]
    internal virtual TextBox txtCPSUTemp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label159")]
    internal virtual Label Label159 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label160")]
    internal virtual Label Label160 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label429")]
    internal virtual Label Label429 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem BREXMLImportToolStripMenuItem
    {
      get => this._BREXMLImportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BREXMLImportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._BREXMLImportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._BREXMLImportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._BREXMLImportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ExcelImportToolStripMenuItem
    {
      get => this._ExcelImportToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExcelImportToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._ExcelImportToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._ExcelImportToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._ExcelImportToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem Import2012DwellingToolStripMenuItem
    {
      get => this._Import2012DwellingToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Import2012DwellingToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._Import2012DwellingToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._Import2012DwellingToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._Import2012DwellingToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblOrienWarning")]
    internal virtual Label lblOrienWarning { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem ExcelImportToolStripMenuItem1
    {
      get => this._ExcelImportToolStripMenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExcelImportToolStripMenuItem1_Click);
        ToolStripMenuItem toolStripMenuItem1_1 = this._ExcelImportToolStripMenuItem1;
        if (toolStripMenuItem1_1 != null)
          toolStripMenuItem1_1.Click -= eventHandler;
        this._ExcelImportToolStripMenuItem1 = value;
        ToolStripMenuItem toolStripMenuItem1_2 = this._ExcelImportToolStripMenuItem1;
        if (toolStripMenuItem1_2 == null)
          return;
        toolStripMenuItem1_2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblhomeWait")]
    internal virtual Label lblhomeWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem CSVImportApilcherToolStripMenuItem
    {
      get => this._CSVImportApilcherToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CSVImportApilcherToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._CSVImportApilcherToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._CSVImportApilcherToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._CSVImportApilcherToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    [field: AccessedThroughProperty("ChkMulSystem")]
    internal virtual CheckBox ChkMulSystem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem DERTERKeyResultsToolStripMenuItem
    {
      get => this._DERTERKeyResultsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DERTERKeyResultsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DERTERKeyResultsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DERTERKeyResultsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DERTERKeyResultsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem DwellingInformationToolStripMenuItem
    {
      get => this._DwellingInformationToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DwellingInformationToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._DwellingInformationToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._DwellingInformationToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._DwellingInformationToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem PSIToolStripMenuItem
    {
      get => this._PSIToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PSIToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._PSIToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._PSIToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._PSIToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem AreaincludesAllImportsToolStripMenuItem
    {
      get => this._AreaincludesAllImportsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AreaincludesAllImportsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem1 = this._AreaincludesAllImportsToolStripMenuItem;
        if (toolStripMenuItem1 != null)
          toolStripMenuItem1.Click -= eventHandler;
        this._AreaincludesAllImportsToolStripMenuItem = value;
        ToolStripMenuItem toolStripMenuItem2 = this._AreaincludesAllImportsToolStripMenuItem;
        if (toolStripMenuItem2 == null)
          return;
        toolStripMenuItem2.Click += eventHandler;
      }
    }

    public class ScotAddress
    {
      public string DisplayAddress { get; set; }

      public string AddressLine1 { get; set; }

      public string AddressLine2 { get; set; }

      public string AddressLine3 { get; set; }

      public string City { get; set; }

      public string Postcode { get; set; }

      public string UPRN { get; set; }
    }
  }
}
