
// Type: SAP2012.SAP_Read




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012
{
  [StandardModule]
  internal sealed class SAP_Read
  {
    public static bool DisplayOnce;

    public static void ReadProjectDetails()
    {
      SAP_Module.NoCalc = true;
      MyProject.Forms.SAPForm.txtProjName.Text = SAP_Module.Proj.Name;
      MyProject.Forms.SAPForm.txtPRef.Text = SAP_Module.Proj.Reference;
      MyProject.Forms.SAPForm.txtPAdd1.Text = SAP_Module.Proj.Address.Line1;
      MyProject.Forms.SAPForm.txtPAdd2.Text = SAP_Module.Proj.Address.Line2;
      MyProject.Forms.SAPForm.txtPAdd2.Text = SAP_Module.Proj.Address.Line3;
      MyProject.Forms.SAPForm.txtPCity.Text = SAP_Module.Proj.Address.City;
      MyProject.Forms.SAPForm.txtPCountry.Text = SAP_Module.Proj.Address.Country;
      MyProject.Forms.SAPForm.txtPPCode.Text = SAP_Module.Proj.Address.PostCost;
      MyProject.Forms.SAPForm.txtPCNAme.Text = SAP_Module.Proj.Client.Name;
      MyProject.Forms.SAPForm.txtPCAdd1.Text = SAP_Module.Proj.Client.Address.Line1;
      MyProject.Forms.SAPForm.txtPCAdd2.Text = SAP_Module.Proj.Client.Address.Line2;
      MyProject.Forms.SAPForm.txtPCAdd3.Text = SAP_Module.Proj.Client.Address.Line3;
      MyProject.Forms.SAPForm.txtPCCity.Text = SAP_Module.Proj.Client.Address.City;
      MyProject.Forms.SAPForm.txtPCCountry.Text = SAP_Module.Proj.Client.Address.Country;
      MyProject.Forms.SAPForm.txtPCPCode.Text = SAP_Module.Proj.Client.Address.PostCost;
      MyProject.Forms.SAPForm.txtPCPhone.Text = SAP_Module.Proj.Client.Phone;
      MyProject.Forms.SAPForm.txtPCFax.Text = SAP_Module.Proj.Client.Fax;
      MyProject.Forms.SAPForm.txtPCEmail.Text = SAP_Module.Proj.Client.Email;
      SAP_Module.NoCalc = false;
    }

    public static void LockData()
    {
      if (Functions.LodgementLock(SAP_Module.CurrDwelling))
      {
        MyProject.Forms.SAPForm.PanelHouseDetails.Enabled = false;
        MyProject.Forms.SAPForm.PanelProject.Enabled = false;
        MyProject.Forms.SAPForm.PanelOpenings.Enabled = false;
        MyProject.Forms.SAPForm.PanelVentilation.Enabled = false;
        MyProject.Forms.SAPForm.TabMainHeating.Enabled = false;
        MyProject.Forms.SAPForm.PanelOverheating.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox39.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox40.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox73.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox37.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox38.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox70.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox51.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox35.Enabled = false;
        MyProject.Forms.SAPForm.TabPage1.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox69.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox31.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox32.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox33.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox34.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox86.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox24Sec.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox23Sec.Enabled = false;
        MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = false;
        MyProject.Forms.SAPForm.grpSecEfficiency.Enabled = false;
        MyProject.Forms.SAPForm.GrpSecmainHeatingFrac.Enabled = false;
        MyProject.Forms.SAPForm.grpSecBoilerInfo.Enabled = false;
        MyProject.Forms.SAPForm.grpCommHSec.Enabled = false;
        MyProject.Forms.SAPForm.cmdHtb.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox14.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox11.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox12.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox30.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox29.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox45.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox48.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox49.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox50.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox13.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox10.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox86.Enabled = false;
        MyProject.Forms.SAPForm.Button2.Enabled = false;
        MyProject.Forms.SAPForm.GroupBox28.Enabled = false;
        MyProject.Forms.SAPForm.ChkIncSecMain.Enabled = false;
      }
      else
      {
        MyProject.Forms.SAPForm.PanelHouseDetails.Enabled = true;
        MyProject.Forms.SAPForm.PanelProject.Enabled = true;
        MyProject.Forms.SAPForm.PanelOpenings.Enabled = true;
        MyProject.Forms.SAPForm.PanelOpenings.Enabled = true;
        MyProject.Forms.SAPForm.PanelVentilation.Enabled = true;
        MyProject.Forms.SAPForm.TabMainHeating.Enabled = true;
        MyProject.Forms.SAPForm.PanelOverheating.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox39.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox40.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox73.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox37.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox38.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox70.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox51.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox35.Enabled = true;
        MyProject.Forms.SAPForm.TabPage1.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox69.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox31.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox32.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox33.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox34.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox86.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox24Sec.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox23Sec.Enabled = true;
        MyProject.Forms.SAPForm.grpSecHETASMain.Enabled = true;
        MyProject.Forms.SAPForm.grpSecEfficiency.Enabled = true;
        MyProject.Forms.SAPForm.GrpSecmainHeatingFrac.Enabled = true;
        MyProject.Forms.SAPForm.grpSecBoilerInfo.Enabled = true;
        MyProject.Forms.SAPForm.grpCommHSec.Enabled = true;
        MyProject.Forms.SAPForm.cmdHtb.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox14.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox11.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox12.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox30.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox29.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox45.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox48.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox49.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox50.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox13.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox10.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox86.Enabled = true;
        MyProject.Forms.SAPForm.Button2.Enabled = true;
        MyProject.Forms.SAPForm.GroupBox28.Enabled = true;
        MyProject.Forms.SAPForm.ChkIncSecMain.Enabled = true;
      }
    }

    public static void ReadDwellingDetails()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.txtDName.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
      MyProject.Forms.SAPForm.txtDRef.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference;
      MyProject.Forms.SAPForm.txtSAPOnly.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SAPOnly;
      MyProject.Forms.SAPForm.txtOverHeat.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat;
      MyProject.Forms.SAPForm.txtStatus.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status;
      MyProject.Forms.SAPForm.txtDDate.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DateAssessment);
      MyProject.Forms.SAPForm.txtCDate.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DateCertificate);
      MyProject.Forms.SAPForm.txtRPD.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RPD;
      MyProject.Forms.SAPForm.txtTransaction.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Transaction;
      MyProject.Forms.SAPForm.txtTenure.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Tenure;
      MyProject.Forms.SAPForm.txtDAdd1.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1;
      MyProject.Forms.SAPForm.txtDAdd2.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line2;
      MyProject.Forms.SAPForm.txtDAdd3.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line3;
      MyProject.Forms.SAPForm.txtDCity.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.City;
      MyProject.Forms.SAPForm.txtDCountry.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country;
      MyProject.Forms.SAPForm.txtDPostCode.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost;
      MyProject.Forms.SAPForm.txtUPRN.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].UPRN;
      MyProject.Forms.SAPForm.txtEPCLanguage.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage;
      MyProject.Forms.SAPForm.ScotGraphs.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOfScotGraphs != 0 ? Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOfScotGraphs) : Conversions.ToString(2);
      MyProject.Forms.SAPForm.txtScotFrontPageOnly.Text = !SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DisplayScotFrontpageOnly ? "No" : "Yes";
      MyProject.Forms.SAPForm.CboDwellingAbove.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsAbove);
      MyProject.Forms.SAPForm.CboDwellingBelow.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsBelow);
      try
      {
        MyProject.Forms.SAPForm.lblImported.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Imported09);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      MyProject.Forms.SAPForm.txtPropertyType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PropertyType;
      MyProject.Forms.SAPForm.txtBuiltForm.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].BuildForm;
      MyProject.Forms.SAPForm.txtFlatType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].FlatType;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt == 0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt = 2013;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt < 1900)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt = 1900;
      MyProject.Forms.SAPForm.txtYearBuilt.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt);
      MyProject.Forms.SAPForm.txtLocation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location;
      MyProject.Forms.SAPForm.txtShelteredSides.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ShelteredSides);
      MyProject.Forms.SAPForm.txtTerrain.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Terrain;
      MyProject.Forms.SAPForm.txtOrientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation;
      MyProject.Forms.SAPForm.txtSmokeArea.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SmokeArea;
      MyProject.Forms.SAPForm.txtShading.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overshading;
      MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
      MyProject.Forms.SAPForm.txtTMP.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.Type;
      MyProject.Forms.SAPForm.TMP();
      MyProject.Forms.SAPForm.txtTMPIndicative.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.Indicative;
      MyProject.Forms.SAPForm.txtTMPUser.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.UserDefined);
      MyProject.Forms.SAPForm.chkMax125Litre.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LessThan125Litre;
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadDimensions()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.Dims.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys > 0U)
      {
        MyProject.Forms.SAPForm.Dims.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.Dims[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Basement;
          MyProject.Forms.SAPForm.Dims[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Area;
          MyProject.Forms.SAPForm.Dims[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Height;
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.chkRoomInRoof.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TrueRoof;
      SAP_Module.ChangeNow = false;
      MyProject.Forms.SAPForm.RedoDims();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFractionSpecified)
        MyProject.Forms.SAPForm.txtLivingFraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFraction);
      else
        MyProject.Forms.SAPForm.txtLivingArea.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingArea);
      SAP_Module.NoCalc = false;
    }

    public static void ReadFloors()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.Floors.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors > 0U)
      {
        MyProject.Forms.SAPForm.Floors.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.Floors[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].Name;
          MyProject.Forms.SAPForm.Floors[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].Type;
          MyProject.Forms.SAPForm.Floors[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].Construction;
          MyProject.Forms.SAPForm.Floors[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].Area;
          MyProject.Forms.SAPForm.Floors[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].U_Value;
          MyProject.Forms.SAPForm.Floors[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].K;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex].UValueSelected)
          {
            MyProject.Forms.SAPForm.Floors[5, rowIndex].ReadOnly = true;
            MyProject.Forms.SAPForm.Floors[5, rowIndex].Style.BackColor = Color.DarkGray;
          }
          else
          {
            MyProject.Forms.SAPForm.Floors[5, rowIndex].ReadOnly = false;
            MyProject.Forms.SAPForm.Floors[5, rowIndex].Style.BackColor = Color.White;
          }
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.PartyFloors.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors > 0U)
      {
        MyProject.Forms.SAPForm.PartyFloors.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.PartyFloors[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex].Name;
          MyProject.Forms.SAPForm.PartyFloors[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex].Construction;
          MyProject.Forms.SAPForm.PartyFloors[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex].Area;
          MyProject.Forms.SAPForm.PartyFloors[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex].K;
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.InternalFloor.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors > 0U)
      {
        MyProject.Forms.SAPForm.InternalFloor.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.InternalFloor[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex].Name;
          MyProject.Forms.SAPForm.InternalFloor[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex].Construction;
          MyProject.Forms.SAPForm.InternalFloor[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex].Area;
          MyProject.Forms.SAPForm.InternalFloor[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex].K;
          checked { ++rowIndex; }
        }
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadWalls()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.Walls.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls > 0U)
      {
        MyProject.Forms.SAPForm.Walls.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.Walls[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].Name;
          MyProject.Forms.SAPForm.Walls[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].Type;
          MyProject.Forms.SAPForm.Walls[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].Construction;
          MyProject.Forms.SAPForm.Walls[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].Area;
          MyProject.Forms.SAPForm.Walls[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].U_Value;
          MyProject.Forms.SAPForm.Walls[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].Ru;
          MyProject.Forms.SAPForm.Walls[8, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].Curtain;
          MyProject.Forms.SAPForm.Walls[9, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].K;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex].UValueSelected)
          {
            MyProject.Forms.SAPForm.Walls[5, rowIndex].ReadOnly = true;
            MyProject.Forms.SAPForm.Walls[5, rowIndex].Style.BackColor = Color.DarkGray;
          }
          else
          {
            MyProject.Forms.SAPForm.Walls[5, rowIndex].ReadOnly = false;
            MyProject.Forms.SAPForm.Walls[5, rowIndex].Style.BackColor = Color.White;
          }
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.PartyWalls.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls > 0U)
      {
        MyProject.Forms.SAPForm.PartyWalls.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.PartyWalls[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex].Name;
          MyProject.Forms.SAPForm.PartyWalls[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex].Type;
          MyProject.Forms.SAPForm.PartyWalls[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex].Construction;
          MyProject.Forms.SAPForm.PartyWalls[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex].Area;
          MyProject.Forms.SAPForm.PartyWalls[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex].U_Value;
          MyProject.Forms.SAPForm.PartyWalls[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex].K;
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.InternalWall.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls > 0U)
      {
        MyProject.Forms.SAPForm.InternalWall.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.InternalWall[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex].Name;
          MyProject.Forms.SAPForm.InternalWall[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex].Construction;
          MyProject.Forms.SAPForm.InternalWall[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex].Area;
          MyProject.Forms.SAPForm.InternalWall[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex].K;
          checked { ++rowIndex; }
        }
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadRoofs()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.Roofs.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs > 0U)
      {
        MyProject.Forms.SAPForm.Roofs.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.Roofs[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].Name;
          MyProject.Forms.SAPForm.Roofs[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].Type;
          MyProject.Forms.SAPForm.Roofs[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].Construction;
          MyProject.Forms.SAPForm.Roofs[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].Area;
          MyProject.Forms.SAPForm.Roofs[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].U_Value;
          MyProject.Forms.SAPForm.Roofs[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].Ru;
          MyProject.Forms.SAPForm.Roofs[8, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].K;
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex].UValueSelected)
          {
            MyProject.Forms.SAPForm.Roofs[5, rowIndex].ReadOnly = true;
            MyProject.Forms.SAPForm.Roofs[5, rowIndex].Style.BackColor = Color.DarkGray;
          }
          else
          {
            MyProject.Forms.SAPForm.Roofs[5, rowIndex].ReadOnly = false;
            MyProject.Forms.SAPForm.Roofs[5, rowIndex].Style.BackColor = Color.White;
          }
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.PartyCeilings.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings > 0U)
      {
        MyProject.Forms.SAPForm.PartyCeilings.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.PartyCeilings[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex].Name;
          MyProject.Forms.SAPForm.PartyCeilings[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex].Construction;
          MyProject.Forms.SAPForm.PartyCeilings[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex].Area;
          MyProject.Forms.SAPForm.PartyCeilings[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex].K;
          checked { ++rowIndex; }
        }
      }
      MyProject.Forms.SAPForm.InternalCeiling.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings > 0U)
      {
        MyProject.Forms.SAPForm.InternalCeiling.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.InternalCeiling[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex].Name;
          MyProject.Forms.SAPForm.InternalCeiling[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex].Construction;
          MyProject.Forms.SAPForm.InternalCeiling[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex].Area;
          MyProject.Forms.SAPForm.InternalCeiling[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex].K;
          checked { ++rowIndex; }
        }
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadDoors()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.DataDoors.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors > 0U)
      {
        MyProject.Forms.SAPForm.DataDoors.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.DataDoors[0, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Name;
          MyProject.Forms.SAPForm.DataDoors[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Location;
          MyProject.Forms.SAPForm.DataDoors[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].UValueSource;
          MyProject.Forms.SAPForm.DataDoors[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].DoorType;
          MyProject.Forms.SAPForm.DataDoors[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Orientation;
          MyProject.Forms.SAPForm.DataDoors[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Overshading;
          MyProject.Forms.SAPForm.DataDoors[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].GlazingType;
          MyProject.Forms.SAPForm.DataDoors[7, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].AirGap;
          MyProject.Forms.SAPForm.DataDoors[8, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].FrameType;
          MyProject.Forms.SAPForm.DataDoors[9, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].ThermalBreak;
          MyProject.Forms.SAPForm.DataDoors[10, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Area;
          if (((ulong) checked ((long) Math.Round((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Width)) & (ulong) -((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Height == 0.0 ? 1 : 0)) > 0UL)
          {
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Area != 0.0)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Width = 1f;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Height = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Height * 1000f / (float) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Count;
            }
            else
            {
              MyProject.Forms.SAPForm.DataDoors[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Width;
              MyProject.Forms.SAPForm.DataDoors[12, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Height;
            }
          }
          else
          {
            MyProject.Forms.SAPForm.DataDoors[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Width;
            MyProject.Forms.SAPForm.DataDoors[12, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Height;
          }
          MyProject.Forms.SAPForm.DataDoors[13, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Count;
          MyProject.Forms.SAPForm.DataDoors[14, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].g;
          MyProject.Forms.SAPForm.DataDoors[15, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].FF;
          MyProject.Forms.SAPForm.DataDoors[16, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].U;
          checked { ++rowIndex; }
        }
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadWindows()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.DataWindows.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows > 0U)
      {
        MyProject.Forms.SAPForm.DataWindows.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.DataWindows[0, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Name;
          MyProject.Forms.SAPForm.DataWindows[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Location;
          MyProject.Forms.SAPForm.DataWindows[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].UValueSource;
          MyProject.Forms.SAPForm.DataWindows[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Orientation;
          MyProject.Forms.SAPForm.DataWindows[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Overshading;
          MyProject.Forms.SAPForm.DataWindows[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].GlazingType;
          MyProject.Forms.SAPForm.DataWindows[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].AirGap;
          MyProject.Forms.SAPForm.DataWindows[7, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].FrameType;
          MyProject.Forms.SAPForm.DataWindows[8, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].ThermalBreak;
          if (((ulong) checked ((long) Math.Round((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Width)) & (ulong) -((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Height == 0.0 ? 1 : 0)) > 0UL)
          {
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Area != 0.0)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Width = 1f;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Height = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Height * 1000f / (float) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Count;
            }
            else
            {
              MyProject.Forms.SAPForm.DataWindows[10, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Width;
              MyProject.Forms.SAPForm.DataWindows[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Height;
            }
          }
          else
          {
            MyProject.Forms.SAPForm.DataWindows[10, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Width;
            MyProject.Forms.SAPForm.DataWindows[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Height;
          }
          MyProject.Forms.SAPForm.DataWindows[9, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Area;
          MyProject.Forms.SAPForm.DataWindows[12, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Count;
          MyProject.Forms.SAPForm.DataWindows[13, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].OverhangWidth;
          MyProject.Forms.SAPForm.DataWindows[14, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].OverhangDepth;
          MyProject.Forms.SAPForm.DataWindows[15, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].CurtainType;
          MyProject.Forms.SAPForm.DataWindows[16, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].FractionClosed;
          MyProject.Forms.SAPForm.DataWindows[17, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].g;
          MyProject.Forms.SAPForm.DataWindows[18, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].FF;
          MyProject.Forms.SAPForm.DataWindows[19, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].U;
          checked { ++rowIndex; }
        }
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadRoofLights()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.DataRoofLights.Rows.Clear();
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights > 0U)
      {
        MyProject.Forms.SAPForm.DataRoofLights.Rows.Add(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights);
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.DataRoofLights[0, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Name;
          MyProject.Forms.SAPForm.DataRoofLights[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Location;
          MyProject.Forms.SAPForm.DataRoofLights[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].UValueSource;
          MyProject.Forms.SAPForm.DataRoofLights[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Pitch;
          MyProject.Forms.SAPForm.DataRoofLights[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Orientation;
          MyProject.Forms.SAPForm.DataRoofLights[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Overshading;
          MyProject.Forms.SAPForm.DataRoofLights[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].GlazingType;
          MyProject.Forms.SAPForm.DataRoofLights[7, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].AirGap;
          MyProject.Forms.SAPForm.DataRoofLights[8, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].FrameType;
          MyProject.Forms.SAPForm.DataRoofLights[9, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].ThermalBreak;
          MyProject.Forms.SAPForm.DataRoofLights[10, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Area;
          MyProject.Forms.SAPForm.DataRoofLights[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Width;
          MyProject.Forms.SAPForm.DataRoofLights[12, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height;
          if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Width == 0.0 & (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height == 0.0)
          {
            if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Area != 0.0)
            {
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Width = 1f;
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height * 1000f / (float) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Count;
            }
            else
            {
              MyProject.Forms.SAPForm.DataRoofLights[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Width;
              MyProject.Forms.SAPForm.DataRoofLights[12, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height;
            }
          }
          else
          {
            MyProject.Forms.SAPForm.DataRoofLights[11, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Width;
            MyProject.Forms.SAPForm.DataRoofLights[12, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height;
          }
          MyProject.Forms.SAPForm.DataRoofLights[13, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Count;
          MyProject.Forms.SAPForm.DataRoofLights[14, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].OverhangWidth;
          MyProject.Forms.SAPForm.DataRoofLights[15, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].OverhangDepth;
          MyProject.Forms.SAPForm.DataRoofLights[16, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].CurtainType;
          MyProject.Forms.SAPForm.DataRoofLights[17, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].FractionClosed;
          MyProject.Forms.SAPForm.DataRoofLights[18, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].g;
          MyProject.Forms.SAPForm.DataRoofLights[19, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].FF;
          MyProject.Forms.SAPForm.DataRoofLights[20, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].U;
          checked { ++rowIndex; }
        }
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadVentilation()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.txtNoofChmneys.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Chimneys);
      MyProject.Forms.SAPForm.txtNoofChmneysMain.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ChimneysMain);
      MyProject.Forms.SAPForm.txtNoofChmneysSec.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ChimneysSec);
      MyProject.Forms.SAPForm.txtNoofChmneysOther.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ChimneysOther);
      MyProject.Forms.SAPForm.txtNoofOpenFlues.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Flues);
      MyProject.Forms.SAPForm.txtNoofOpenFluesMain.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.FluesMain);
      MyProject.Forms.SAPForm.txtNoofOpenFluesSec.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.FluesSec);
      MyProject.Forms.SAPForm.txtNoofOpenFluesOther.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.FluesOther);
      MyProject.Forms.SAPForm.txtNoofFans.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Fans);
      MyProject.Forms.SAPForm.txtNoofPassiveVents.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Vents);
      MyProject.Forms.SAPForm.txtNoofFlueGasFires.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Fires);
      MyProject.Forms.SAPForm.txtNoofShelteredSides.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Shelter);
      MyProject.Forms.SAPForm.txtMechVentilation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent;
      MyProject.Forms.SAPForm.txtParamters.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters;
      MyProject.Forms.SAPForm.txtWetRooms.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.WetRooms);
      MyProject.Forms.SAPForm.txtDuctInsulation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DuctType;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters, "User defined", false) == 0)
        MyProject.Forms.SAPForm.lblUserDefined.Visible = true;
      else
        MyProject.Forms.SAPForm.lblUserDefined.Visible = false;
      MyProject.Forms.SAPForm.txtMechProductName.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName;
      MyProject.Forms.SAPForm.txtMechDucting.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.DuctingType;
      MyProject.Forms.SAPForm.txtMechFan.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.SFP);
      MyProject.Forms.SAPForm.txtMechHeat.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.HEE);
      MyProject.Forms.SAPForm.chkApprovedScheme.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ApprovedScheme;
      MyProject.Forms.SAPForm.txtMechDecKSPF1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF1);
      MyProject.Forms.SAPForm.txtMechDecKSPF2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF2);
      MyProject.Forms.SAPForm.txtMechDecKSPF3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF3);
      MyProject.Forms.SAPForm.txtMechDecOSPF1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF1);
      MyProject.Forms.SAPForm.txtMechDecOSPF2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF2);
      MyProject.Forms.SAPForm.txtMechDecOSPF3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF3);
      MyProject.Forms.SAPForm.txtMechDecKTF1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP1);
      MyProject.Forms.SAPForm.txtMechDecKTF2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP2);
      MyProject.Forms.SAPForm.txtMechDecKTF3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP3);
      MyProject.Forms.SAPForm.txtMechDecOTF1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP1);
      MyProject.Forms.SAPForm.txtMechDecOTF2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP2);
      MyProject.Forms.SAPForm.txtMechDecOTF3.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP3);
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID > 0U)
      {
        MyProject.Forms.SAPForm.lblDataProduct.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID) + ":-" + SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductName;
        MyProject.Forms.SAPForm.lblDataProduct.Visible = true;
        MyProject.Forms.SAPForm.grpVentData.Visible = true;
        SAP_Read.ReadInVentalationData();
      }
      else
      {
        MyProject.Forms.SAPForm.lblDataProduct.Visible = false;
        MyProject.Forms.SAPForm.grpVentData.Visible = false;
      }
      MyProject.Forms.SAPForm.txtAirTest.Items.Clear();
      string status = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status;
      if (Operators.CompareString(status, "New dwelling as built", false) != 0 && Operators.CompareString(status, "New extension to existing dwelling", false) != 0 && Operators.CompareString(status, "New dwelling created by change of use", false) != 0)
      {
        if (Operators.CompareString(status, "New dwelling design stage", false) != 0)
        {
          if (Operators.CompareString(status, "Existing dwelling (SAP)", false) == 0)
            MyProject.Forms.SAPForm.txtAirTest.Items.Add((object) "Calculated");
        }
        else
        {
          MyProject.Forms.SAPForm.txtAirTest.Items.Add((object) "Assumed");
          MyProject.Forms.SAPForm.txtAirTest.Items.Add((object) "As designed");
        }
      }
      else
      {
        MyProject.Forms.SAPForm.txtAirTest.Items.Add((object) "Assumed");
        MyProject.Forms.SAPForm.txtAirTest.Items.Add((object) "As built");
      }
      MyProject.Forms.SAPForm.txtAirTest.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure;
      MyProject.Forms.SAPForm.txtDesignAir.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir);
      MyProject.Forms.SAPForm.txtMeasuredAir.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MeasuredAir);
      MyProject.Forms.SAPForm.txtPressureDate.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DateAir);
      MyProject.Forms.SAPForm.txtAssumedAir.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir);
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) == 0)
      {
        MyProject.Forms.SAPForm.chkAverageValue.Checked = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AveragePerm = false;
      }
      else
        MyProject.Forms.SAPForm.chkAverageValue.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AveragePerm;
      MyProject.Forms.SAPForm.txtDetConstruction.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Construction;
      MyProject.Forms.SAPForm.txtDetLobby.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Lobby;
      MyProject.Forms.SAPForm.txtDetFloor.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Floor;
      MyProject.Forms.SAPForm.txtDetPercentDraught.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.DraguthP);
      MyProject.Forms.SAPForm.ChkMulSystem.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MultiSystem;
      MyProject.Forms.SAPForm.txtDraught.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Draught);
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadInVentalationData()
    {
      DataGridView dgVentData = MyProject.Forms.SAPForm.DGVentData;
      string text = MyProject.Forms.SAPForm.txtMechVentilation.Text;
      object Instance;
      if (Operators.CompareString(text, "Balanced with heat recovery", false) != 0 && Operators.CompareString(text, "Centralised whole house extract", false) != 0)
      {
        if (Operators.CompareString(text, "Decentralised whole house extract", false) == 0)
        {
          List<PCDF.Products322> products322s = SAP_Module.PCDFData.Products322s;
          Func<PCDF.Products322, bool> predicate;
          // ISSUE: reference to a compiler-generated field
          if (SAP_Read._Closure\u0024__.\u0024I12\u002D1 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate = SAP_Read._Closure\u0024__.\u0024I12\u002D1;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Read._Closure\u0024__.\u0024I12\u002D1 = predicate = (Func<PCDF.Products322, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID.ToString()));
          }
          Instance = (object) products322s.Where<PCDF.Products322>(predicate).SingleOrDefault<PCDF.Products322>();
        }
        else
        {
          MyProject.Forms.SAPForm.grpVentData.Visible = false;
          return;
        }
      }
      else
      {
        List<PCDF.Products321> products321s = SAP_Module.PCDFData.Products321s;
        Func<PCDF.Products321, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I12\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = SAP_Read._Closure\u0024__.\u0024I12\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I12\u002D0 = predicate = (Func<PCDF.Products321, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ProductID.ToString()));
        }
        Instance = (object) products321s.Where<PCDF.Products321>(predicate).SingleOrDefault<PCDF.Products321>();
      }
      try
      {
        dgVentData[1, 0].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "Manufacturer", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dgVentData[1, 1].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "Brand", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dgVentData[1, 2].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "Model", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dgVentData[1, 3].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "ModelQualifier", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dgVentData[1, 4].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "FirstManu", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dgVentData[1, 5].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "FinManu", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        object Left1 = NewLateBinding.LateGet(Instance, (System.Type) null, "MainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if (Operators.ConditionalCompareObjectEqual(Left1, (object) 1, false))
          dgVentData[1, 6].Value = (object) "centralised mechanical extract ventilation";
        else if (Operators.ConditionalCompareObjectEqual(Left1, (object) 2, false))
          dgVentData[1, 6].Value = (object) "decentralised mechanical extract ventilation";
        else if (Operators.ConditionalCompareObjectEqual(Left1, (object) 3, false))
          dgVentData[1, 6].Value = (object) "balanced whole-house mechanical ventilation with heat recovery";
        else if (Operators.ConditionalCompareObjectEqual(Left1, (object) 4, false))
          dgVentData[1, 6].Value = (object) "balanced whole-house mechanical ventilation without heat recovery";
        object Left2 = NewLateBinding.LateGet(Instance, (System.Type) null, "DuctingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if (Operators.ConditionalCompareObjectEqual(Left2, (object) 1, false))
          dgVentData[1, 7].Value = (object) "flexible ducting";
        else if (Operators.ConditionalCompareObjectEqual(Left2, (object) 2, false))
          dgVentData[1, 7].Value = (object) "rigid ducting,";
        dgVentData[1, 9].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "Date1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void ReadMainHeating()
    {
      SAP_Module.NoCalc = true;
      MyProject.Forms.SAPForm.txtPrimary.Text = "";
      MyProject.Forms.SAPForm.txtSubGroup.Text = "";
      MyProject.Forms.SAPForm.txtSubGroup.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtHeatingSource.Enabled = false;
      MyProject.Forms.SAPForm.txtBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.txtMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingEmitter.Text = "";
      MyProject.Forms.SAPForm.txtHeatingEmitter.Enabled = false;
      MyProject.Forms.SAPForm.txtHeatingControls.Text = "";
      MyProject.Forms.SAPForm.txtHeatingControls.Enabled = false;
      MyProject.Forms.SAPForm.txtMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.txtElectricityTariff.Text = "";
      try
      {
        MyProject.Forms.SAPForm.txtPrimary.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup;
        Heating.PrimaryHeatingGroupCheck();
        MyProject.Forms.SAPForm.txtSubGroup.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup;
        Heating.PrimaryHeatingSubGroupCheck();
        MyProject.Forms.SAPForm.txtHeatingSource.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource;
        Heating.CheckSource();
        MyProject.Forms.SAPForm.txtBoilerSub.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup;
        Heating.CheckBoilerSub();
        MyProject.Forms.SAPForm.txtMainHeatingType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType;
        Heating.CheckFuelTypeForSAPTable(MyProject.Forms.SAPForm.txtMainHeatingType.Text, MyProject.Forms.SAPForm.txtSubGroup.Text, MyProject.Forms.SAPForm.txtBoilerSub.Text);
        MyProject.Forms.SAPForm.txtHeatingEmitter.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter;
        MyProject.Forms.SAPForm.txtHeatingControls.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Controls;
        MyProject.Forms.SAPForm.chkDelayedStart.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.DelayedStart;
        MyProject.Forms.SAPForm.txtMainFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel;
        MyProject.Forms.SAPForm.chkOilPump.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.OilPump;
        MyProject.Forms.SAPForm.txtBFuelBurningType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.FuelBurningType;
        MyProject.Forms.SAPForm.txtEfficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff);
        MyProject.Forms.SAPForm.txtPumpHP.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpHP;
        MyProject.Forms.SAPForm.txtPumpType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpType;
        MyProject.Forms.SAPForm.cboBoilerFlowTemp.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlowTemp;
        MyProject.Forms.SAPForm.txtBILock.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.BILock;
        MyProject.Forms.SAPForm.txtDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.Description;
        MyProject.Forms.SAPForm.txtBFlueType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType;
        MyProject.Forms.SAPForm.txtFanFlued.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FanFlued;
        MyProject.Forms.SAPForm.chkMainHLoadWeather.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.LoadWeather;
        MyProject.Forms.SAPForm.txtHETASMain.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HETAS;
        MyProject.Forms.SAPForm.txtLoadWeather.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.LoadWeatherType;
        MyProject.Forms.SAPForm.txtElectricityTariff.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ElectricityTariff;
        MyProject.Forms.SAPForm.chkMCS.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MCSCert;
        MyProject.Forms.SAPForm.chkKeepHot.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.IncludeKeepHot;
        MyProject.Forms.SAPForm.txtKeepHotFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotFuel;
        MyProject.Forms.SAPForm.chkKeepHotTimed.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotTimed;
        MyProject.Forms.SAPForm.txtRangeCase.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Range.CasekW);
        MyProject.Forms.SAPForm.txtRangeWater.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Range.WaterkW);
        MyProject.Forms.SAPForm.txtCompensator.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Compensator;
        MyProject.Forms.SAPForm.lblControlWeather.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDFWeather;
        MyProject.Forms.SAPForm.lblControlTTZ.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ControlCodePCDF;
        MyProject.Forms.SAPForm.txtCommHB1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1Efficiency);
        MyProject.Forms.SAPForm.txtCommHB1HFraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1HeatFraction);
        MyProject.Forms.SAPForm.ChkKnown.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.KnownLoss;
        MyProject.Forms.SAPForm.txtLossKnown.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.KnownLossValue);
        MyProject.Forms.SAPForm.txtCommHDS.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatDSystem;
        MyProject.Forms.SAPForm.txtCommHB1HeatToPower.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatToPowerRatio);
        MyProject.Forms.SAPForm.txtCommHNoOfAdditional.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources);
        List<PCDF.Table4a_B> table4aBs1 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate1;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I13\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate1 = SAP_Read._Closure\u0024__.\u0024I13\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I13\u002D0 = predicate1 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Type.ToString()));
        }
        PCDF.Table4a_B table4aB1 = table4aBs1.Where<PCDF.Table4a_B>(predicate1).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB1 != null)
        {
          MyProject.Forms.SAPForm.txtCommHAdd1Type.Text = table4aB1.Description;
          MyProject.Forms.SAPForm.txtCommHAdd1Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel;
          MyProject.Forms.SAPForm.txtCommHAdd1Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.HeatFraction);
          MyProject.Forms.SAPForm.txtCommHAdd1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Efficiency);
        }
        List<PCDF.Table4a_B> table4aBs2 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I13\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Read._Closure\u0024__.\u0024I13\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I13\u002D1 = predicate2 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Type.ToString()));
        }
        PCDF.Table4a_B table4aB2 = table4aBs2.Where<PCDF.Table4a_B>(predicate2).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB2 != null)
        {
          MyProject.Forms.SAPForm.txtCommHAdd2Type.Text = table4aB2.Description;
          MyProject.Forms.SAPForm.txtCommHAdd2Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel;
          MyProject.Forms.SAPForm.txtCommHAdd2Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.HeatFraction);
          MyProject.Forms.SAPForm.txtCommHAdd2Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Efficiency);
        }
        List<PCDF.Table4a_B> table4aBs3 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I13\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = SAP_Read._Closure\u0024__.\u0024I13\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I13\u002D2 = predicate3 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Type.ToString()));
        }
        PCDF.Table4a_B table4aB3 = table4aBs3.Where<PCDF.Table4a_B>(predicate3).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB3 != null)
        {
          MyProject.Forms.SAPForm.txtCommHAdd3Type.Text = table4aB3.Description;
          MyProject.Forms.SAPForm.txtCommHAdd3Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel;
          MyProject.Forms.SAPForm.txtCommHAdd3Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.HeatFraction);
          MyProject.Forms.SAPForm.txtCommHAdd3Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Efficiency);
        }
        List<PCDF.Table4a_B> table4aBs4 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate4;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I13\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate4 = SAP_Read._Closure\u0024__.\u0024I13\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I13\u002D3 = predicate4 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Type.ToString()));
        }
        PCDF.Table4a_B table4aB4 = table4aBs4.Where<PCDF.Table4a_B>(predicate4).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB4 != null)
        {
          MyProject.Forms.SAPForm.txtCommHAdd4Type.Text = table4aB4.Description;
          MyProject.Forms.SAPForm.txtCommHAdd4Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel;
          MyProject.Forms.SAPForm.txtCommHAdd4Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.HeatFraction);
          MyProject.Forms.SAPForm.txtCommHAdd4Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Efficiency);
        }
        MyProject.Forms.SAPForm.dtaStorage.DataSource = (object) new BindingSource()
        {
          DataSource = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.StorageHeaters
        };
        MyProject.Forms.SAPForm.chkSEDBUK2005.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK2005;
        if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "SAP Tables", false) == 0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode < 150)
          MyProject.Forms.SAPForm.pnlMainEff2.BringToFront();
        else
          MyProject.Forms.SAPForm.pnlMainEff1.BringToFront();
        SAP_Read.CheckCommunitySEDBUK();
        SAP_Read.CheckSEDBUK();
        SAP_Read.ReadCoolingSystem();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadMainHeating2()
    {
      SAP_Module.NoCalc = true;
      MyProject.Forms.SAPForm.txtSECPrimary.Text = "";
      MyProject.Forms.SAPForm.txtSecSubGroup.Text = "";
      MyProject.Forms.SAPForm.txtSecSubGroup.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingSource.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingSource.Enabled = false;
      MyProject.Forms.SAPForm.txtSecBoilerSub.Text = "";
      MyProject.Forms.SAPForm.txtSecBoilerSub.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Text = "";
      MyProject.Forms.SAPForm.txtSecMainHeatingType.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingEmitter.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = false;
      MyProject.Forms.SAPForm.txtSecHeatingControls.Text = "";
      MyProject.Forms.SAPForm.txtSecHeatingControls.Enabled = false;
      MyProject.Forms.SAPForm.txtSecMainFuel.Text = "";
      MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
      MyProject.Forms.SAPForm.ChkIncSecMain.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2;
      try
      {
        MyProject.Forms.SAPForm.txtSECPrimary.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup;
        Heating2.PrimaryHeatingGroupCheck2();
        MyProject.Forms.SAPForm.txtSecSubGroup.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup;
        Heating2.PrimaryHeatingSubGroupCheck2();
        MyProject.Forms.SAPForm.txtSecHeatingSource.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource;
        Heating2.CheckSource2();
        MyProject.Forms.SAPForm.txtSecBoilerSub.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup;
        Heating2.CheckBoilerSubSec();
        MyProject.Forms.SAPForm.txtSecMainHeatingType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType;
        Heating2.CheckFuelTypeForSAPTable2(MyProject.Forms.SAPForm.txtSecMainHeatingType.Text, MyProject.Forms.SAPForm.txtSecSubGroup.Text, MyProject.Forms.SAPForm.txtSecBoilerSub.Text);
        MyProject.Forms.SAPForm.txtSecHeatingEmitter.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter;
        MyProject.Forms.SAPForm.txtSecHeatingControls.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Controls;
        MyProject.Forms.SAPForm.chkSecDelayedStart.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.DelayedStart;
        MyProject.Forms.SAPForm.txtSecMainFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel;
        MyProject.Forms.SAPForm.chkSecOilPump.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.OilPump;
        MyProject.Forms.SAPForm.txtSecBFuelBurningType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.FuelBurningType;
        MyProject.Forms.SAPForm.txtSecEfficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff);
        MyProject.Forms.SAPForm.txtSecPumpHP.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpHP;
        MyProject.Forms.SAPForm.txtSecBILock.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.BILock;
        MyProject.Forms.SAPForm.txtSecDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.Description;
        MyProject.Forms.SAPForm.txtSecBFlueType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType;
        MyProject.Forms.SAPForm.txtSecFanFlued.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FanFlued;
        MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.LoadWeather;
        MyProject.Forms.SAPForm.txtSecHETASMain.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HETAS;
        MyProject.Forms.SAPForm.txtSecLoadWeather.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.LoadWeatherType;
        MyProject.Forms.SAPForm.txtSecPumpType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpType;
        MyProject.Forms.SAPForm.cboSecBoilerFlowTemp.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlowTemp;
        MyProject.Forms.SAPForm.chkSecMCS.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MCSCert;
        MyProject.Forms.SAPForm.chkSecKeepHot.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.IncludeKeepHot;
        MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotFuel;
        MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotTimed;
        MyProject.Forms.SAPForm.txtRangeCase.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Range.CasekW);
        MyProject.Forms.SAPForm.txtSecRangeWater.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Range.WaterkW);
        MyProject.Forms.SAPForm.txtSecCompensator.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Compensator;
        MyProject.Forms.SAPForm.txtSecCommHB1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.Boiler1Efficiency);
        MyProject.Forms.SAPForm.txtSecCommHB1HFraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.Boiler1HeatFraction);
        MyProject.Forms.SAPForm.txtSecCommHDS.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatDSystem;
        MyProject.Forms.SAPForm.txtSecCommHB1HeatToPower.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatToPowerRatio);
        MyProject.Forms.SAPForm.txtSecCommHNoOfAdditional.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources);
        List<PCDF.Table4a_B> table4aBs1 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate1;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I14\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate1 = SAP_Read._Closure\u0024__.\u0024I14\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I14\u002D0 = predicate1 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.Type));
        }
        PCDF.Table4a_B table4aB1 = table4aBs1.Where<PCDF.Table4a_B>(predicate1).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB1 != null)
        {
          MyProject.Forms.SAPForm.txtSecCommHAdd1Type.Text = table4aB1.Description;
          MyProject.Forms.SAPForm.txtSecCommHAdd1Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.Fuel;
          MyProject.Forms.SAPForm.txtSecCommHAdd1Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.HeatFraction);
          MyProject.Forms.SAPForm.txtSecCommHAdd1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.Efficiency);
        }
        List<PCDF.Table4a_B> table4aBs2 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I14\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Read._Closure\u0024__.\u0024I14\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I14\u002D1 = predicate2 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.Type));
        }
        PCDF.Table4a_B table4aB2 = table4aBs2.Where<PCDF.Table4a_B>(predicate2).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB2 != null)
        {
          MyProject.Forms.SAPForm.txtSecCommHAdd2Type.Text = table4aB2.Description;
          MyProject.Forms.SAPForm.txtSecCommHAdd2Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.Fuel;
          MyProject.Forms.SAPForm.txtSecCommHAdd2Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.HeatFraction);
          MyProject.Forms.SAPForm.txtSecCommHAdd2Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.Efficiency);
        }
        List<PCDF.Table4a_B> table4aBs3 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I14\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = SAP_Read._Closure\u0024__.\u0024I14\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I14\u002D2 = predicate3 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.Type));
        }
        PCDF.Table4a_B table4aB3 = table4aBs3.Where<PCDF.Table4a_B>(predicate3).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB3 != null)
        {
          MyProject.Forms.SAPForm.txtSecCommHAdd3Type.Text = table4aB3.Description;
          MyProject.Forms.SAPForm.txtSecCommHAdd3Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.Fuel;
          MyProject.Forms.SAPForm.txtSecCommHAdd3Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.HeatFraction);
          MyProject.Forms.SAPForm.txtSecCommHAdd3Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.Efficiency);
        }
        List<PCDF.Table4a_B> table4aBs4 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate4;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I14\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate4 = SAP_Read._Closure\u0024__.\u0024I14\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I14\u002D3 = predicate4 = (Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.Type));
        }
        PCDF.Table4a_B table4aB4 = table4aBs4.Where<PCDF.Table4a_B>(predicate4).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB4 != null)
        {
          MyProject.Forms.SAPForm.txtSecCommHAdd4Type.Text = table4aB4.Description;
          MyProject.Forms.SAPForm.txtSecCommHAdd4Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.Fuel;
          MyProject.Forms.SAPForm.txtSecCommHAdd4Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.HeatFraction);
          MyProject.Forms.SAPForm.txtSecCommHAdd4Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.Efficiency);
        }
        MyProject.Forms.SAPForm.ChkWholep.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Include_SecMain_Heat_Whole;
        MyProject.Forms.SAPForm.ChkSeparateP.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Include_SecMain_Heat_Separat_Part;
        MyProject.Forms.SAPForm.TxtHeatFraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec);
        MyProject.Forms.SAPForm.chkSecSEDBUK2005.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK2005;
        if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "SAP Tables", false) == 0 & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode < 150)
          MyProject.Forms.SAPForm.pnlMainSecEff2.BringToFront();
        else
          MyProject.Forms.SAPForm.pnlMainSecEff1.BringToFront();
        SAP_Read.CheckSEDBUK2();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Read.ReadCoolingSystem();
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void CheckCommunitySEDBUK()
    {
      MyProject.Forms.SAPForm.grpCommunitySEDBUK.Visible = false;
      MyProject.Forms.SAPForm.grpCommunitySourceSEDBUK.Visible = false;
      MyProject.Forms.SAPForm.dtaCommunity.Rows.Clear();
      if (MyProject.Forms.SAPForm.dtaCommunity.ColumnCount == 0)
      {
        MyProject.Forms.SAPForm.dtaCommunity.Columns.Add("C1", "C1");
        MyProject.Forms.SAPForm.dtaCommunity.Columns.Add("C2", "C2");
      }
      if (!(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup.Equals("Community heating schemes") & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource.Equals("Boiler Database")))
        return;
      List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
      Func<PCDF.CommunityScheme, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Read._Closure\u0024__.\u0024I15\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = SAP_Read._Closure\u0024__.\u0024I15\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Read._Closure\u0024__.\u0024I15\u002D0 = predicate1 = (Func<PCDF.CommunityScheme, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
      }
      PCDF.CommunityScheme communityScheme = communitySchemes.Where<PCDF.CommunityScheme>(predicate1).SingleOrDefault<PCDF.CommunityScheme>();
      if (communityScheme != null)
      {
        MyProject.Forms.SAPForm.grpBoiler.Visible = false;
        MyProject.Forms.SAPForm.grpCommunitySEDBUK.Visible = true;
        MyProject.Forms.SAPForm.grpCommunitySourceSEDBUK.Visible = true;
        if (MyProject.Forms.SAPForm.dtaCommunity.RowCount == 0)
          MyProject.Forms.SAPForm.dtaCommunity.Rows.Add(30);
        else if (MyProject.Forms.SAPForm.dtaCommunity.RowCount == 1)
          MyProject.Forms.SAPForm.dtaCommunity.Rows.Add(30);
        MyProject.Forms.SAPForm.dtaCommunity.Columns[0].Width = 120;
        MyProject.Forms.SAPForm.dtaCommunity.Columns[1].Width = 250;
        MyProject.Forms.SAPForm.dtaCommunity.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        MyProject.Forms.SAPForm.dtaCommunity[0, 0].Value = (object) "ID";
        MyProject.Forms.SAPForm.dtaCommunity[0, 1].Value = (object) "Heat Network Version";
        MyProject.Forms.SAPForm.dtaCommunity[0, 2].Value = (object) "DB Entry";
        MyProject.Forms.SAPForm.dtaCommunity[0, 3].Value = (object) "Description of Network";
        MyProject.Forms.SAPForm.dtaCommunity[0, 4].Value = (object) "Validity End Date";
        MyProject.Forms.SAPForm.dtaCommunity[0, 5].Value = (object) "Community Heat Network";
        MyProject.Forms.SAPForm.dtaCommunity[0, 6].Value = (object) "Postcode Energy Centre";
        MyProject.Forms.SAPForm.dtaCommunity[0, 7].Value = (object) "Locality";
        MyProject.Forms.SAPForm.dtaCommunity[0, 8].Value = (object) "Town Name";
        MyProject.Forms.SAPForm.dtaCommunity[0, 9].Value = (object) "Administrative Area";
        MyProject.Forms.SAPForm.dtaCommunity[0, 10].Value = (object) "Date Initial Operation";
        MyProject.Forms.SAPForm.dtaCommunity[0, 11].Value = (object) "Total Number of Dwellings";
        MyProject.Forms.SAPForm.dtaCommunity[0, 12].Value = (object) "Number of Flats";
        MyProject.Forms.SAPForm.dtaCommunity[0, 13].Value = (object) "NonDom Floor Area";
        MyProject.Forms.SAPForm.dtaCommunity[0, 14].Value = (object) "Total Number of Existing Dwellings";
        MyProject.Forms.SAPForm.dtaCommunity[0, 15].Value = (object) "Service Provision";
        MyProject.Forms.SAPForm.dtaCommunity[0, 16].Value = (object) "Data Type";
        MyProject.Forms.SAPForm.dtaCommunity[0, 17].Value = (object) "Year";
        MyProject.Forms.SAPForm.dtaCommunity[0, 18].Value = (object) "Heat Metering";
        MyProject.Forms.SAPForm.dtaCommunity[0, 19].Value = (object) "Total MWh Heat Network";
        MyProject.Forms.SAPForm.dtaCommunity[0, 20].Value = (object) "Total MWh Heat Delivered";
        MyProject.Forms.SAPForm.dtaCommunity[0, 21].Value = (object) "Individual Dwelling Heat Metering";
        MyProject.Forms.SAPForm.dtaCommunity[0, 22].Value = (object) "Total MWh Heat per Annum";
        MyProject.Forms.SAPForm.dtaCommunity[0, 23].Value = (object) "Route Length";
        MyProject.Forms.SAPForm.dtaCommunity[0, 24].Value = (object) "Linear Loss";
        MyProject.Forms.SAPForm.dtaCommunity[0, 25].Value = (object) "Distribution Loss Factor";
        MyProject.Forms.SAPForm.dtaCommunity[0, 26].Value = (object) "Pump Elec Energy";
        MyProject.Forms.SAPForm.dtaCommunity[0, 27].Value = (object) "Pump Elec Energy Per Dwelling";
        MyProject.Forms.SAPForm.dtaCommunity[0, 28].Value = (object) "Carbon Dioxide Intensity";
        MyProject.Forms.SAPForm.dtaCommunity[0, 29].Value = (object) "Primary Energy Factor";
        MyProject.Forms.SAPForm.dtaCommunity[1, 0].Value = (object) communityScheme.ID;
        MyProject.Forms.SAPForm.dtaCommunity[1, 1].Value = (object) communityScheme.HeatNetworkVersion;
        MyProject.Forms.SAPForm.dtaCommunity[1, 2].Value = (object) communityScheme.DBEntry;
        MyProject.Forms.SAPForm.dtaCommunity[1, 3].Value = (object) communityScheme.DescriptionofNetwork;
        MyProject.Forms.SAPForm.dtaCommunity[1, 4].Value = (object) communityScheme.ValidityEndDate;
        MyProject.Forms.SAPForm.dtaCommunity[1, 5].Value = (object) communityScheme.CommunityHeatNetwork;
        MyProject.Forms.SAPForm.dtaCommunity[1, 6].Value = (object) communityScheme.PostcodeEnergyCentre;
        MyProject.Forms.SAPForm.dtaCommunity[1, 7].Value = (object) communityScheme.Locality;
        MyProject.Forms.SAPForm.dtaCommunity[1, 8].Value = (object) communityScheme.TownName;
        MyProject.Forms.SAPForm.dtaCommunity[1, 9].Value = (object) communityScheme.AdministrativeArea;
        MyProject.Forms.SAPForm.dtaCommunity[1, 10].Value = (object) communityScheme.DateInitialOperation;
        MyProject.Forms.SAPForm.dtaCommunity[1, 11].Value = (object) communityScheme.TotNumbDwellings;
        MyProject.Forms.SAPForm.dtaCommunity[1, 12].Value = (object) communityScheme.NumberFlats;
        MyProject.Forms.SAPForm.dtaCommunity[1, 13].Value = (object) communityScheme.NonDomFloorArea;
        MyProject.Forms.SAPForm.dtaCommunity[1, 14].Value = (object) communityScheme.TotNumbExistDwellings;
        string serviceProvision = communityScheme.ServiceProvision;
        if (Operators.CompareString(serviceProvision, "1", false) != 0)
        {
          if (Operators.CompareString(serviceProvision, "3", false) != 0)
          {
            if (Operators.CompareString(serviceProvision, "4", false) == 0)
              MyProject.Forms.SAPForm.dtaCommunity[1, 15].Value = (object) "Water heating only";
          }
          else
            MyProject.Forms.SAPForm.dtaCommunity[1, 15].Value = (object) "Space heating only";
        }
        else
          MyProject.Forms.SAPForm.dtaCommunity[1, 15].Value = (object) "Space and water heating";
        string dataType = communityScheme.DataType;
        if (Operators.CompareString(dataType, "1", false) != 0)
        {
          if (Operators.CompareString(dataType, "2", false) == 0)
            MyProject.Forms.SAPForm.dtaCommunity[1, 16].Value = (object) "Actual data";
        }
        else
          MyProject.Forms.SAPForm.dtaCommunity[1, 16].Value = (object) "Provisional data";
        MyProject.Forms.SAPForm.dtaCommunity[1, 17].Value = (object) communityScheme.Year;
        MyProject.Forms.SAPForm.dtaCommunity[1, 18].Value = (object) communityScheme.HeatMetering;
        MyProject.Forms.SAPForm.dtaCommunity[1, 19].Value = (object) communityScheme.TotalMWhHeatNetwork;
        MyProject.Forms.SAPForm.dtaCommunity[1, 20].Value = (object) communityScheme.TotalMWhHeatDelivered;
        MyProject.Forms.SAPForm.dtaCommunity[1, 21].Value = (object) communityScheme.IndividualDwellingHeatMetering;
        MyProject.Forms.SAPForm.dtaCommunity[1, 22].Value = (object) communityScheme.TotalMWhHeatperAnnum;
        MyProject.Forms.SAPForm.dtaCommunity[1, 23].Value = (object) communityScheme.RouteLength;
        MyProject.Forms.SAPForm.dtaCommunity[1, 24].Value = (object) communityScheme.LinearLoss;
        MyProject.Forms.SAPForm.dtaCommunity[1, 25].Value = (object) communityScheme.DistributionLossFactor;
        MyProject.Forms.SAPForm.dtaCommunity[1, 26].Value = (object) communityScheme.PumpElecEnergy;
        MyProject.Forms.SAPForm.dtaCommunity[1, 27].Value = (object) communityScheme.PumpElecEnergyPerDwelling;
        MyProject.Forms.SAPForm.dtaCommunity[1, 28].Value = (object) communityScheme.CarbonDioxIntensity;
        MyProject.Forms.SAPForm.dtaCommunity[1, 29].Value = (object) communityScheme.PrimaryEnergyFactor;
        List<PCDF.CommunityScheme_Sub> communitySchemesSub = SAP_Module.PCDFData.CommunitySchemes_Sub;
        Func<PCDF.CommunityScheme_Sub, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I15\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Read._Closure\u0024__.\u0024I15\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I15\u002D1 = predicate2 = (Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
        }
        List<PCDF.CommunityScheme_Sub> list = communitySchemesSub.Where<PCDF.CommunityScheme_Sub>(predicate2).ToList<PCDF.CommunityScheme_Sub>();
        if (list != null)
        {
          MyProject.Forms.SAPForm.dtaCommunitySource.DataSource = (object) list;
          if (Operators.CompareString(list[0].CommunityFuel, "99", false) != 0)
          {
            MyProject.Forms.SAPForm.txtMainFuel.Text = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[0].CommunityFuel))));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[0].CommunityFuel))));
          }
        }
        MyProject.Forms.SAPForm.lblCommHeatWarning.Visible = false;
        try
        {
          if (DateTime.Compare(Conversions.ToDate(communityScheme.ValidityEndDate), DateAndTime.Now) < 0)
            MyProject.Forms.SAPForm.lblCommHeatWarning.Visible = true;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public static void CheckCommunityWaterSEDBUK()
    {
      MyProject.Forms.SAPForm.grdCommunityWater.Visible = false;
      MyProject.Forms.SAPForm.grdCommunityWaterSources.Visible = false;
      MyProject.Forms.SAPForm.dtaCommunityWater.Rows.Clear();
      if (MyProject.Forms.SAPForm.dtaCommunityWater.ColumnCount == 0)
      {
        MyProject.Forms.SAPForm.dtaCommunityWater.Columns.Add("C1", "C1");
        MyProject.Forms.SAPForm.dtaCommunityWater.Columns.Add("C2", "C2");
      }
      if (!(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase & !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef)))
        return;
      List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
      Func<PCDF.CommunityScheme, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Read._Closure\u0024__.\u0024I16\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = SAP_Read._Closure\u0024__.\u0024I16\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Read._Closure\u0024__.\u0024I16\u002D0 = predicate1 = (Func<PCDF.CommunityScheme, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef));
      }
      PCDF.CommunityScheme communityScheme = communitySchemes.Where<PCDF.CommunityScheme>(predicate1).SingleOrDefault<PCDF.CommunityScheme>();
      if (communityScheme != null)
      {
        MyProject.Forms.SAPForm.optCommunityDatabase.Checked = true;
        MyProject.Forms.SAPForm.grdCommunityWater.Visible = true;
        MyProject.Forms.SAPForm.grdCommunityWaterSources.Visible = true;
        if (MyProject.Forms.SAPForm.dtaCommunityWater.RowCount == 0)
          MyProject.Forms.SAPForm.dtaCommunityWater.Rows.Add(30);
        else if (MyProject.Forms.SAPForm.dtaCommunityWater.RowCount == 1)
          MyProject.Forms.SAPForm.dtaCommunityWater.Rows.Add(30);
        MyProject.Forms.SAPForm.dtaCommunityWater.Columns[0].Width = 120;
        MyProject.Forms.SAPForm.dtaCommunityWater.Columns[1].Width = 250;
        MyProject.Forms.SAPForm.dtaCommunityWater.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 0].Value = (object) "ID";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 1].Value = (object) "Heat Network Version";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 2].Value = (object) "DB Entry";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 3].Value = (object) "Description of Network";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 4].Value = (object) "Validity End Date";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 5].Value = (object) "Community Heat Network";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 6].Value = (object) "Postcode Energy Centre";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 7].Value = (object) "Locality";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 8].Value = (object) "Town Name";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 9].Value = (object) "Administrative Area";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 10].Value = (object) "Date Initial Operation";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 11].Value = (object) "Total Number of Dwellings";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 12].Value = (object) "Number of Flats";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 13].Value = (object) "NonDom Floor Area";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 14].Value = (object) "Total Number of Existing Dwellings";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 15].Value = (object) "Service Provision";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 16].Value = (object) "Data Type";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 17].Value = (object) "Year";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 18].Value = (object) "Heat Metering";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 19].Value = (object) "Total MWh Heat Network";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 20].Value = (object) "Total MWh Heat Delivered";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 21].Value = (object) "Individual Dwelling Heat Metering";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 22].Value = (object) "Total MWh Heat per Annum";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 23].Value = (object) "Route Length";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 24].Value = (object) "Linear Loss";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 25].Value = (object) "Distribution Loss Factor";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 26].Value = (object) "Pump Elec Energy";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 27].Value = (object) "Pump Elec Energy Per Dwelling";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 28].Value = (object) "Carbon Dioxide Intensity";
        MyProject.Forms.SAPForm.dtaCommunityWater[0, 29].Value = (object) "Primary Energy Factor";
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 0].Value = (object) communityScheme.ID;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 1].Value = (object) communityScheme.HeatNetworkVersion;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 2].Value = (object) communityScheme.DBEntry;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 3].Value = (object) communityScheme.DescriptionofNetwork;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 4].Value = (object) communityScheme.ValidityEndDate;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 5].Value = (object) communityScheme.CommunityHeatNetwork;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 6].Value = (object) communityScheme.PostcodeEnergyCentre;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 7].Value = (object) communityScheme.Locality;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 8].Value = (object) communityScheme.TownName;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 9].Value = (object) communityScheme.AdministrativeArea;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 10].Value = (object) communityScheme.DateInitialOperation;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 11].Value = (object) communityScheme.TotNumbDwellings;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 12].Value = (object) communityScheme.NumberFlats;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 13].Value = (object) communityScheme.NonDomFloorArea;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 14].Value = (object) communityScheme.TotNumbExistDwellings;
        string serviceProvision = communityScheme.ServiceProvision;
        if (Operators.CompareString(serviceProvision, "1", false) != 0)
        {
          if (Operators.CompareString(serviceProvision, "3", false) != 0)
          {
            if (Operators.CompareString(serviceProvision, "4", false) == 0)
              MyProject.Forms.SAPForm.dtaCommunityWater[1, 15].Value = (object) "Water heating only";
          }
          else
            MyProject.Forms.SAPForm.dtaCommunityWater[1, 15].Value = (object) "Space heating only";
        }
        else
          MyProject.Forms.SAPForm.dtaCommunityWater[1, 15].Value = (object) "Space and water heating";
        string dataType = communityScheme.DataType;
        if (Operators.CompareString(dataType, "1", false) != 0)
        {
          if (Operators.CompareString(dataType, "2", false) == 0)
            MyProject.Forms.SAPForm.dtaCommunityWater[1, 16].Value = (object) "Actual data";
        }
        else
          MyProject.Forms.SAPForm.dtaCommunityWater[1, 16].Value = (object) "Provisional data";
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 17].Value = (object) communityScheme.Year;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 18].Value = (object) communityScheme.HeatMetering;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 19].Value = (object) communityScheme.TotalMWhHeatNetwork;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 20].Value = (object) communityScheme.TotalMWhHeatDelivered;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 21].Value = (object) communityScheme.IndividualDwellingHeatMetering;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 22].Value = (object) communityScheme.TotalMWhHeatperAnnum;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 23].Value = (object) communityScheme.RouteLength;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 24].Value = (object) communityScheme.LinearLoss;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 25].Value = (object) communityScheme.DistributionLossFactor;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 26].Value = (object) communityScheme.PumpElecEnergy;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 27].Value = (object) communityScheme.PumpElecEnergyPerDwelling;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 28].Value = (object) communityScheme.CarbonDioxIntensity;
        MyProject.Forms.SAPForm.dtaCommunityWater[1, 29].Value = (object) communityScheme.PrimaryEnergyFactor;
        List<PCDF.CommunityScheme_Sub> communitySchemesSub = SAP_Module.PCDFData.CommunitySchemes_Sub;
        Func<PCDF.CommunityScheme_Sub, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Read._Closure\u0024__.\u0024I16\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Read._Closure\u0024__.\u0024I16\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Read._Closure\u0024__.\u0024I16\u002D1 = predicate2 = (Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef));
        }
        List<PCDF.CommunityScheme_Sub> list = communitySchemesSub.Where<PCDF.CommunityScheme_Sub>(predicate2).ToList<PCDF.CommunityScheme_Sub>();
        if (list != null)
        {
          MyProject.Forms.SAPForm.dtaCommunitySourceWater.DataSource = (object) list;
          if (Operators.CompareString(list[0].CommunityFuel, "99", false) == 0)
          {
            MyProject.Forms.SAPForm.txtWaterFuel.Text = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[0].FuelDescription))));
          }
          else
          {
            MyProject.Forms.SAPForm.txtWaterFuel.Text = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[0].CommunityFuel))));
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[0].CommunityFuel))));
          }
        }
        MyProject.Forms.SAPForm.lblCommHeatWarningWater.Visible = false;
        try
        {
          if (DateTime.Compare(Conversions.ToDate(communityScheme.ValidityEndDate), DateAndTime.Now) < 0)
            MyProject.Forms.SAPForm.lblCommHeatWarningWater.Visible = true;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public static void CheckSEDBUK()
    {
      SAP_Module.ChangeNow = true;
      try
      {
        MyProject.Forms.SAPForm.grpBoiler.Visible = false;
        MyProject.Forms.SAPForm.grpCHP.Visible = false;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.IntegralPFGHRS = false;
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK) & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup, "Community heating schemes", false) > 0U)
        {
          MyProject.Forms.SAPForm.txtMainFuel.Items.Clear();
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtHeatingSource.Text, "Boiler Database", false) == 0 & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK, "", false) > 0U)
          {
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = 0;
            bool flag;
            if (Operators.CompareString(MyProject.Forms.SAPForm.txtSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
            {
              MyProject.Forms.SAPForm.chkMainHLoadWeather.Enabled = true;
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = SAP_Read._Closure\u0024__.\u0024I17\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              MyProject.Forms.SAPForm.DataInfo.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfo.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfo.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(87);
              else if (MyProject.Forms.SAPForm.DataInfo.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(58);
              MyProject.Forms.SAPForm.DataInfo.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfo[0, 0].Value = (object) "Index";
              MyProject.Forms.SAPForm.DataInfo[0, 1].Value = (object) "Manufacturer Reference";
              MyProject.Forms.SAPForm.DataInfo[0, 2].Value = (object) "DB Entry Updated";
              MyProject.Forms.SAPForm.DataInfo[0, 3].Value = (object) "Manufacturer Name";
              MyProject.Forms.SAPForm.DataInfo[0, 4].Value = (object) "Brand Name";
              MyProject.Forms.SAPForm.DataInfo[0, 5].Value = (object) "Model Name";
              MyProject.Forms.SAPForm.DataInfo[0, 6].Value = (object) "ModelQualifier";
              MyProject.Forms.SAPForm.DataInfo[0, 7].Value = (object) "Boiler ID";
              MyProject.Forms.SAPForm.DataInfo[0, 8].Value = (object) "First Year of Manufacture";
              MyProject.Forms.SAPForm.DataInfo[0, 9].Value = (object) "Final Year of Manufacture";
              MyProject.Forms.SAPForm.DataInfo[0, 10].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfo[0, 11].Value = (object) "Mount Position";
              MyProject.Forms.SAPForm.DataInfo[0, 12].Value = (object) "Exposure Rating";
              MyProject.Forms.SAPForm.DataInfo[0, 13].Value = (object) "Main Type";
              MyProject.Forms.SAPForm.DataInfo[0, 14].Value = (object) "Subsidiary Type";
              MyProject.Forms.SAPForm.DataInfo[0, 15].Value = (object) "Subsidiary Type  Table";
              MyProject.Forms.SAPForm.DataInfo[0, 16].Value = (object) "Subsidiary Type Index";
              MyProject.Forms.SAPForm.DataInfo[0, 17].Value = (object) "Condensing";
              MyProject.Forms.SAPForm.DataInfo[0, 18].Value = (object) "Flue Type";
              MyProject.Forms.SAPForm.DataInfo[0, 19].Value = (object) "Fan Assistance";
              MyProject.Forms.SAPForm.DataInfo[0, 20].Value = (object) "Boiler Power (bottom of range)";
              MyProject.Forms.SAPForm.DataInfo[0, 21].Value = (object) "Boiler Power (top of range)";
              MyProject.Forms.SAPForm.DataInfo[0, 22].Value = (object) "Energy Efficiency Class";
              MyProject.Forms.SAPForm.DataInfo[0, 23].Value = (object) "Annual Seasonal Efficiency";
              MyProject.Forms.SAPForm.DataInfo[0, 24].Value = (object) "SAP Winter Seasonal Efficiency";
              MyProject.Forms.SAPForm.DataInfo[0, 25].Value = (object) "SAP Summer Seasonal Efficiency";
              MyProject.Forms.SAPForm.DataInfo[0, 26].Value = (object) "Hot Water Efficiency";
              MyProject.Forms.SAPForm.DataInfo[0, 27].Value = (object) "SAP 2005 Efficiency";
              MyProject.Forms.SAPForm.DataInfo[0, 28].Value = (object) "Efficiency Category";
              MyProject.Forms.SAPForm.DataInfo[0, 29].Value = (object) "Test gas for LPG";
              MyProject.Forms.SAPForm.DataInfo[0, 30].Value = (object) "Test Correction for LPG";
              MyProject.Forms.SAPForm.DataInfo[0, 31].Value = (object) "SAP Equation Used";
              MyProject.Forms.SAPForm.DataInfo[0, 32].Value = (object) "Ignition";
              MyProject.Forms.SAPForm.DataInfo[0, 33].Value = (object) "Burner Control";
              MyProject.Forms.SAPForm.DataInfo[0, 34].Value = (object) "Electrical power while boiler is firing";
              MyProject.Forms.SAPForm.DataInfo[0, 35].Value = (object) "Electrical power while boiler is not firing";
              MyProject.Forms.SAPForm.DataInfo[0, 36].Value = (object) "Store Type";
              MyProject.Forms.SAPForm.DataInfo[0, 37].Value = (object) "Store loss in test";
              MyProject.Forms.SAPForm.DataInfo[0, 38].Value = (object) "Separate store";
              MyProject.Forms.SAPForm.DataInfo[0, 39].Value = (object) "Store boiler volume";
              MyProject.Forms.SAPForm.DataInfo[0, 40].Value = (object) "Store solar volume";
              MyProject.Forms.SAPForm.DataInfo[0, 41].Value = (object) "Store insulation thickness";
              MyProject.Forms.SAPForm.DataInfo[0, 42].Value = (object) "Store insulation type";
              MyProject.Forms.SAPForm.DataInfo[0, 43].Value = (object) "Store temperature";
              MyProject.Forms.SAPForm.DataInfo[0, 44].Value = (object) "Store heat loss rate";
              MyProject.Forms.SAPForm.DataInfo[0, 45].Value = (object) "Separate DHW tests";
              MyProject.Forms.SAPForm.DataInfo[0, 46].Value = (object) "Fuel energy for HW test 1";
              MyProject.Forms.SAPForm.DataInfo[0, 47].Value = (object) "Electrical energy for HW test 1";
              MyProject.Forms.SAPForm.DataInfo[0, 48].Value = (object) "Rejected energy r1 in HW test 1";
              MyProject.Forms.SAPForm.DataInfo[0, 49].Value = (object) "Storage loss factor F1";
              MyProject.Forms.SAPForm.DataInfo[0, 50].Value = (object) "Fuel energy for HW test 2";
              MyProject.Forms.SAPForm.DataInfo[0, 51].Value = (object) "Electrical energy for HW test 2";
              MyProject.Forms.SAPForm.DataInfo[0, 52].Value = (object) "Rejected energy r2 in HW test 2";
              MyProject.Forms.SAPForm.DataInfo[0, 53].Value = (object) "Storage loss factor F2";
              MyProject.Forms.SAPForm.DataInfo[0, 54].Value = (object) "Storage loss factor F3";
              MyProject.Forms.SAPForm.DataInfo[0, 55].Value = (object) "'Keep-hot' facility";
              MyProject.Forms.SAPForm.DataInfo[0, 56].Value = (object) "'Keep-hot' timer";
              MyProject.Forms.SAPForm.DataInfo[0, 57].Value = (object) "'Keep-hot' electric heater";
              MyProject.Forms.SAPForm.DataInfo[0, 58].Value = (object) "Control capabilities";
              MyProject.Forms.SAPForm.DataInfo[1, 0].Value = (object) sedbuk.ID;
              MyProject.Forms.SAPForm.DataInfo[1, 1].Value = (object) sedbuk.RefNo;
              MyProject.Forms.SAPForm.DataInfo[1, 2].Value = (object) sedbuk.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfo[1, 3].Value = (object) sedbuk.CurrManu;
              MyProject.Forms.SAPForm.DataInfo[1, 4].Value = (object) sedbuk.BrandName;
              MyProject.Forms.SAPForm.DataInfo[1, 5].Value = (object) sedbuk.ModelName;
              MyProject.Forms.SAPForm.DataInfo[1, 6].Value = (object) sedbuk.ModelQualifier;
              MyProject.Forms.SAPForm.DataInfo[1, 7].Value = (object) sedbuk.BoilerID;
              MyProject.Forms.SAPForm.DataInfo[1, 8].Value = (object) sedbuk.FirstManu;
              MyProject.Forms.SAPForm.DataInfo[1, 9].Value = (object) sedbuk.FinManu;
              double num1 = Conversion.Val(sedbuk.Fuel);
              if (num1 == 1.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "Gas/LNG";
                flag = true;
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "mains gas");
              }
              else if (num1 == 2.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "LPG";
                flag = true;
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bulk LPG");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bottled LPG");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "LPG subject to Special Condition 18");
              }
              else if (num1 == 4.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "Oil";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "heating oil";
                MyProject.Forms.SAPForm.chkOilPump.Visible = true;
              }
              else if (num1 == 72.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "biodiesel from used cooking oil only";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "biodiesel from used cooking oil only";
              }
              else if (num1 == 71.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "biodiesel from any biomass source";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "biodiesel from any biomass source";
              }
              else if (num1 == 73.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "rapeseed oil";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "rapeseed oil";
              }
              else if (num1 == 74.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "appliances able to use mineral oil or liquid biofuel";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "appliances able to use mineral oil or liquid biofuel";
              }
              else if (num1 == 75.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "B30K";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "B30K";
              }
              double num2 = Conversion.Val(sedbuk.MountPosition);
              if (num2 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "Unknown";
              else if (num2 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "Floor";
              else if (num2 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "Wall";
              else if (num2 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "Either floor or wall";
              else if (num2 == 4.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "Back boiler";
              double num3 = Conversion.Val(sedbuk.ExposureRating);
              if (num3 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "Unknown";
              else if (num3 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "Indoor only";
              else if (num3 == 4.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "Outdoor";
              double num4 = Conversion.Val(sedbuk.MainType);
              if (num4 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "Unknown";
              else if (num4 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "Regular";
              else if (num4 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "Combi";
              else if (num4 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "CPSU";
              double num5 = Conversion.Val(sedbuk.SubType);
              if (num5 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "normal";
              else if (num5 == 1.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "with integral PFGHRD";
                MyProject.Forms.SAPForm.DataInfo[1, 15].Value = (object) sedbuk.SubTypeTable;
                MyProject.Forms.SAPForm.DataInfo[1, 16].Value = (object) sedbuk.SubTypeIndex;
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.IntegralPFGHRS = true;
              }
              double num6 = Conversion.Val(sedbuk.Condensing);
              if (num6 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 17].Value = (object) "Unknown";
              else if (num6 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 17].Value = (object) "Non-condensing";
              else if (num6 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 17].Value = (object) "Condensing";
              double num7 = Conversion.Val(sedbuk.FlueType);
              if (num7 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) "Unknown";
              else if (num7 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) "Open";
              else if (num7 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) "Room-sealed";
              else if (num7 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) "Open or room-sealed";
              double num8 = Conversion.Val(sedbuk.FanAssist);
              if (num8 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 19].Value = (object) "Unknown";
              else if (num8 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 19].Value = (object) "No fan";
              else if (num8 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 19].Value = (object) "Fan";
              MyProject.Forms.SAPForm.DataInfo[1, 20].Value = (object) sedbuk.BoilPowBot;
              MyProject.Forms.SAPForm.DataInfo[1, 21].Value = (object) sedbuk.BoilPowTop;
              MyProject.Forms.SAPForm.DataInfo[1, 22].Value = (object) sedbuk.EngEffClss;
              MyProject.Forms.SAPForm.DataInfo[1, 23].Value = (object) sedbuk.AnnualEff;
              MyProject.Forms.SAPForm.DataInfo[1, 24].Value = (object) sedbuk.WinterEff;
              MyProject.Forms.SAPForm.DataInfo[1, 25].Value = (object) sedbuk.SummerEff;
              MyProject.Forms.SAPForm.DataInfo[1, 26].Value = (object) sedbuk.HotWaterEff;
              MyProject.Forms.SAPForm.DataInfo[1, 27].Value = (object) sedbuk.SAPEff;
              double num9 = Conversion.Val(sedbuk.EffCat);
              if (num9 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 28].Value = (object) "Unknown";
              else if (num9 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 28].Value = (object) "SEDBUK based on validated and certified data";
              else if (num9 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 28].Value = (object) "SEDBUK based on certified data";
              else if (num9 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 28].Value = (object) "Estimated (for obsolete boilers only)";
              double num10 = Conversion.Val(sedbuk.LPGTstGas);
              MyProject.Forms.SAPForm.DataInfo[1, 29].Value = num10 != 0.0 ? (num10 != 1.0 ? (object) "" : (object) "The tests were carried out using natural gas and the modified calculation procedure") : (object) "The efficiency tests from which SEDBUK was calculated were carried out using LPG";
              double num11 = Conversion.Val(sedbuk.LPGTstCorrection);
              MyProject.Forms.SAPForm.DataInfo[1, 30].Value = num11 != 0.0 ? (num11 != 1.0 ? (object) "" : (object) "The correction was not applied") : (object) "The correction was not applied to the results on the test certificate";
              MyProject.Forms.SAPForm.DataInfo[1, 31].Value = (object) sedbuk.SAPEqUsed;
              double num12 = Conversion.Val(sedbuk.Ignition);
              if (num12 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 32].Value = (object) "Unknown";
              else if (num12 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 32].Value = (object) "No";
              else if (num12 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 32].Value = (object) "Yes";
              double num13 = Conversion.Val(sedbuk.BurnCont);
              if (num13 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 33].Value = (object) "Unknown";
              else if (num13 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 33].Value = (object) "On-off";
              else if (num13 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 33].Value = (object) "variable (stepped or modulating)";
              MyProject.Forms.SAPForm.DataInfo[1, 34].Value = (object) sedbuk.ElPowFire;
              MyProject.Forms.SAPForm.DataInfo[1, 35].Value = (object) sedbuk.ElPowNtFire;
              double num14 = Conversion.Val(sedbuk.StrType);
              if (num14 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 36].Value = (object) "Unknown";
              else if (num14 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 36].Value = (object) "A storage combination boiler with Primary Store";
              else if (num14 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 36].Value = (object) "A storage combination boiler with Secondary Store";
              else if (num14 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 36].Value = (object) "CPSU";
              double num15 = Conversion.Val(sedbuk.StrLoss);
              MyProject.Forms.SAPForm.DataInfo[1, 37].Value = num15 != 0.0 ? (num15 != 1.0 ? (num15 != 2.0 ? (object) "" : (object) "Heat loss from the internal hot water store has been included in the efficiency test values reported") : (object) "Heat loss from the internal hot water store has been excluded in the efficiency test values reported") : (object) "Unknown";
              double num16 = Conversion.Val(sedbuk.StrSep);
              MyProject.Forms.SAPForm.DataInfo[1, 38].Value = num16 != 1.0 ? (num16 != 2.0 ? (object) "Unknown/Inapplicable" : (object) "Yes") : (object) "Hot water store is within the boiler casing";
              MyProject.Forms.SAPForm.DataInfo[1, 39].Value = (object) sedbuk.StrVol;
              MyProject.Forms.SAPForm.DataInfo[1, 40].Value = (object) sedbuk.StrSolarVol;
              MyProject.Forms.SAPForm.DataInfo[1, 41].Value = (object) sedbuk.StrInsThk;
              double num17 = Conversion.Val(sedbuk.StrInsType);
              MyProject.Forms.SAPForm.DataInfo[1, 42].Value = num17 != 1.0 ? (num17 != 2.0 ? (num17 != 3.0 ? (num17 != 4.0 ? (num17 != 5.0 ? (num17 != 6.0 ? (object) "Unknown/Inapplicable" : (object) "Closest to MW (glass)") : (object) "Closest to PU") : (object) "Closest to MW (rock)") : (object) "Mineral wool (glass)") : (object) "Polyurethane foam") : (object) "Mineral wool (rock)";
              MyProject.Forms.SAPForm.DataInfo[1, 43].Value = (object) sedbuk.StrTemp;
              MyProject.Forms.SAPForm.DataInfo[1, 44].Value = (object) sedbuk.StrHtLoss;
              double num18 = Conversion.Val(sedbuk.SeperateDHWTests);
              if (num18 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 45].Value = (object) "none or not applicable";
              else if (num18 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 45].Value = (object) "one test, using schedule 2";
              else if (num18 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 45].Value = (object) "two tests, using schedules 2 and 3";
              else if (num18 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 45].Value = (object) "two tests, using schedules 2 and 1";
              MyProject.Forms.SAPForm.DataInfo[1, 46].Value = (object) sedbuk.FuelEnergyT1;
              MyProject.Forms.SAPForm.DataInfo[1, 47].Value = (object) sedbuk.ElecEnergyT1;
              MyProject.Forms.SAPForm.DataInfo[1, 48].Value = (object) sedbuk.RejEnergy_r1T1;
              MyProject.Forms.SAPForm.DataInfo[1, 49].Value = (object) sedbuk.StoLossF1;
              MyProject.Forms.SAPForm.DataInfo[1, 50].Value = (object) sedbuk.FuelEnergyT2;
              MyProject.Forms.SAPForm.DataInfo[1, 51].Value = (object) sedbuk.ElecEnergyT2;
              MyProject.Forms.SAPForm.DataInfo[1, 52].Value = (object) sedbuk.RejEnergy_r2T2;
              MyProject.Forms.SAPForm.DataInfo[1, 53].Value = (object) sedbuk.StoLossF2;
              MyProject.Forms.SAPForm.DataInfo[1, 54].Value = (object) sedbuk.StoLossF3;
              if (!Information.IsDBNull((object) sedbuk.KpHtFac))
              {
                double num19 = Conversion.Val(sedbuk.KpHtFac);
                MyProject.Forms.SAPForm.DataInfo[1, 55].Value = num19 != 0.0 ? (num19 != 1.0 ? (num19 != 2.0 ? (num19 != 3.0 ? (object) "Unknown/Inapplicable" : (object) "A 'keep-hot' facility both fuelled by gas/oil and powered by electricity") : (object) "A 'keep-hot' facility powered by electricity") : (object) "A 'keep-hot' facility fuelled by gas/oil only") : (object) "No 'keep-hot' facility";
              }
              if (!Information.IsDBNull((object) sedbuk.KpHtTmr))
              {
                double num20 = Conversion.Val(sedbuk.KpHtTmr);
                MyProject.Forms.SAPForm.DataInfo[1, 56].Value = num20 != 0.0 ? (num20 != 1.0 ? (object) "Unknown/Inapplicable" : (object) "A time-switch control which turns off the facility overnight") : (object) "No such control";
              }
              MyProject.Forms.SAPForm.DataInfo[1, 57].Value = (object) sedbuk.KpHtElcHtr;
              MyProject.Forms.SAPForm.DataInfo[1, 58].Value = (object) sedbuk.ControlCapabilities;
              MyProject.Forms.SAPForm.txtEfficiency.Text = sedbuk.AnnualEff;
            }
            else if (Operators.CompareString(MyProject.Forms.SAPForm.txtSubGroup.Text, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              MyProject.Forms.SAPForm.DataInfo.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfo.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfo.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(25);
              else if (MyProject.Forms.SAPForm.DataInfo.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(24);
              MyProject.Forms.SAPForm.DataInfo.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfo[0, 0].Value = (object) "ID";
              MyProject.Forms.SAPForm.DataInfo[0, 1].Value = (object) "ManuRef";
              MyProject.Forms.SAPForm.DataInfo[0, 2].Value = (object) "EntryUpdate";
              MyProject.Forms.SAPForm.DataInfo[0, 3].Value = (object) "APM";
              MyProject.Forms.SAPForm.DataInfo[0, 4].Value = (object) "Manu";
              MyProject.Forms.SAPForm.DataInfo[0, 5].Value = (object) "Brand";
              MyProject.Forms.SAPForm.DataInfo[0, 6].Value = (object) "Model";
              MyProject.Forms.SAPForm.DataInfo[0, 7].Value = (object) "Qualifier";
              MyProject.Forms.SAPForm.DataInfo[0, 8].Value = (object) "1st_year";
              MyProject.Forms.SAPForm.DataInfo[0, 9].Value = (object) "Last_Year";
              MyProject.Forms.SAPForm.DataInfo[0, 10].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfo[0, 11].Value = (object) "Condensing";
              MyProject.Forms.SAPForm.DataInfo[0, 12].Value = (object) "Flue_Type";
              MyProject.Forms.SAPForm.DataInfo[0, 13].Value = (object) "ServiceProvision";
              MyProject.Forms.SAPForm.DataInfo[0, 14].Value = (object) "HWVessel";
              MyProject.Forms.SAPForm.DataInfo[0, 15].Value = (object) "Class";
              MyProject.Forms.SAPForm.DataInfo[0, 16].Value = (object) "WHEffSch2";
              MyProject.Forms.SAPForm.DataInfo[0, 17].Value = (object) "NetElecConsumedSch2";
              MyProject.Forms.SAPForm.DataInfo[0, 18].Value = (object) "WHEffSch3";
              MyProject.Forms.SAPForm.DataInfo[0, 19].Value = (object) "NetElecConsumedSch3";
              MyProject.Forms.SAPForm.DataInfo[0, 20].Value = (object) "CogenPPowerBottom";
              MyProject.Forms.SAPForm.DataInfo[0, 21].Value = (object) "CogenPPowerTop";
              MyProject.Forms.SAPForm.DataInfo[0, 22].Value = (object) "HeatingDuration";
              MyProject.Forms.SAPForm.DataInfo[0, 23].Value = (object) "SepCirculator";
              MyProject.Forms.SAPForm.DataInfo[0, 24].Value = (object) "PSR_Numb";
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate1;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate1 = SAP_Read._Closure\u0024__.\u0024I17\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D1 = predicate1 = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate1).SingleOrDefault<PCDF.CHP>();
              MyProject.Forms.SAPForm.DataInfo[1, 0].Value = (object) chp.ID;
              MyProject.Forms.SAPForm.DataInfo[1, 1].Value = (object) chp.ManuRef;
              MyProject.Forms.SAPForm.DataInfo[1, 2].Value = (object) chp.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfo[1, 3].Value = (object) chp.APM;
              MyProject.Forms.SAPForm.DataInfo[1, 4].Value = (object) chp.Manu;
              MyProject.Forms.SAPForm.DataInfo[1, 5].Value = (object) chp.Brand;
              MyProject.Forms.SAPForm.DataInfo[1, 6].Value = (object) chp.Model;
              MyProject.Forms.SAPForm.DataInfo[1, 7].Value = (object) chp.Qualifier;
              MyProject.Forms.SAPForm.DataInfo[1, 8].Value = (object) chp._1st_year;
              MyProject.Forms.SAPForm.DataInfo[1, 9].Value = (object) chp.Last_Year;
              MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) chp.Fuel;
              MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) chp.Condensing;
              MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) chp.Flue_Type;
              MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) chp.ServiceProvision;
              MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) chp.HWVessel;
              MyProject.Forms.SAPForm.DataInfo[1, 15].Value = (object) chp._Class;
              MyProject.Forms.SAPForm.DataInfo[1, 16].Value = (object) chp.WHEffSch2;
              MyProject.Forms.SAPForm.DataInfo[1, 17].Value = (object) chp.NetElecConsumedSch2;
              MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) chp.WHEffSch3;
              MyProject.Forms.SAPForm.DataInfo[1, 19].Value = (object) chp.NetElecConsumedSch3;
              MyProject.Forms.SAPForm.DataInfo[1, 20].Value = (object) chp.CogenPPowerBottom;
              MyProject.Forms.SAPForm.DataInfo[1, 21].Value = (object) chp.CogenPPowerTop;
              MyProject.Forms.SAPForm.DataInfo[1, 22].Value = (object) chp.HeatingDuration;
              MyProject.Forms.SAPForm.DataInfo[1, 23].Value = (object) chp.SepCirculator;
              MyProject.Forms.SAPForm.DataInfo[1, 24].Value = (object) chp.PSR_Numb;
              double num21 = Conversion.Val(chp.Fuel);
              if (num21 == 1.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "mains gas";
              else if (num21 == 2.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "bulk LPG";
              else if (num21 == 4.0)
              {
                MyProject.Forms.SAPForm.txtMainFuel.Text = "heating oil";
                MyProject.Forms.SAPForm.chkOilPump.Visible = true;
              }
              else if (num21 == 11.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "house coal";
              else if (num21 == 12.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "manufactured smokeless fuel";
              else if (num21 == 13.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "anthracite";
              else if (num21 == 14.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "heating oil";
              else if (num21 == 20.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood logs";
              else if (num21 == 21.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood chips";
              else if (num21 == 23.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
              double num22 = Conversion.Val(chp.Condensing);
              if (num22 == 2.0)
                MyProject.Forms.SAPForm.chkMainHLoadWeather.Enabled = true;
              else if (num22 == 1.0)
              {
                MyProject.Forms.SAPForm.chkMainHLoadWeather.Enabled = false;
                MyProject.Forms.SAPForm.chkMainHLoadWeather.Checked = false;
              }
              List<PCDF.CHP_Sub> chPsSub = SAP_Module.PCDFData.CHPs_Sub;
              Func<PCDF.CHP_Sub, bool> predicate2;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate2 = SAP_Read._Closure\u0024__.\u0024I17\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D2 = predicate2 = (Func<PCDF.CHP_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              List<PCDF.CHP_Sub> list = chPsSub.Where<PCDF.CHP_Sub>(predicate2).ToList<PCDF.CHP_Sub>();
              if (MyProject.Forms.SAPForm.DataInfoSub.Columns.Count == 0)
              {
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("ID", "ID");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("PSR", "PSR");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("Space ", "Space heating efficiency");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("electricity", "Net specific electricity consumed");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("Running", "Running Hours");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("Key", "Key");
              }
              else
                MyProject.Forms.SAPForm.DataInfoSub.Rows.Clear();
              MyProject.Forms.SAPForm.DataInfoSub.Columns[4].Visible = false;
              MyProject.Forms.SAPForm.DataInfoSub.Columns[5].Visible = false;
              MyProject.Forms.SAPForm.DataInfoSub.Rows.Add(list.Count);
              int num23 = checked (list.Count - 1);
              int index = 0;
              while (index <= num23)
              {
                MyProject.Forms.SAPForm.DataInfoSub.Rows.Add((object) list[index].ID, (object) list[index].PSR, (object) list[index].Efficiency, (object) list[index].ElecConsumed);
                checked { ++index; }
              }
              MyProject.Forms.SAPForm.grpCHP.Visible = true;
              MyProject.Forms.SAPForm.txtEfficiency.Text = "";
            }
            else if (Operators.CompareString(MyProject.Forms.SAPForm.txtSubGroup.Text, "Solid fuel boilers", false) == 0)
            {
              MyProject.Forms.SAPForm.DataInfo.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfo.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfo.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(32);
              else if (MyProject.Forms.SAPForm.DataInfo.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(31);
              MyProject.Forms.SAPForm.DataInfo.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfo[0, 0].Value = (object) "ID";
              MyProject.Forms.SAPForm.DataInfo[0, 1].Value = (object) "RefNo";
              MyProject.Forms.SAPForm.DataInfo[0, 2].Value = (object) "Entry Update";
              MyProject.Forms.SAPForm.DataInfo[0, 3].Value = (object) "Manufacturer";
              MyProject.Forms.SAPForm.DataInfo[0, 4].Value = (object) "Brand Name";
              MyProject.Forms.SAPForm.DataInfo[0, 5].Value = (object) "Model Name";
              MyProject.Forms.SAPForm.DataInfo[0, 6].Value = (object) "Model Qualifier";
              MyProject.Forms.SAPForm.DataInfo[0, 7].Value = (object) "Product ID";
              MyProject.Forms.SAPForm.DataInfo[0, 8].Value = (object) "First Manu";
              MyProject.Forms.SAPForm.DataInfo[0, 9].Value = (object) "Final Manu";
              MyProject.Forms.SAPForm.DataInfo[0, 10].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfo[0, 11].Value = (object) "Main Type";
              MyProject.Forms.SAPForm.DataInfo[0, 12].Value = (object) "Flue";
              MyProject.Forms.SAPForm.DataInfo[0, 13].Value = (object) "Fan Assististed";
              MyProject.Forms.SAPForm.DataInfo[0, 14].Value = (object) "Fuel Feed";
              MyProject.Forms.SAPForm.DataInfo[0, 15].Value = (object) "Boiler Power (bottom of range)";
              MyProject.Forms.SAPForm.DataInfo[0, 16].Value = (object) "Boiler Power (top of range)";
              MyProject.Forms.SAPForm.DataInfo[0, 17].Value = (object) "Boiler Power at minimum burn rate";
              MyProject.Forms.SAPForm.DataInfo[0, 18].Value = (object) "Energy efficiency class";
              MyProject.Forms.SAPForm.DataInfo[0, 19].Value = (object) "SAP Efficiency efficiency of boiler";
              MyProject.Forms.SAPForm.DataInfo[0, 20].Value = (object) "Efficiency Catagory";
              MyProject.Forms.SAPForm.DataInfo[0, 21].Value = (object) "Measured fuel input at nominal output power";
              MyProject.Forms.SAPForm.DataInfo[0, 22].Value = (object) "Measured heat to water at nominal output";
              MyProject.Forms.SAPForm.DataInfo[0, 23].Value = (object) "Measured heat to room at nominal output power";
              MyProject.Forms.SAPForm.DataInfo[0, 24].Value = (object) "Measured fuel input at part output power";
              MyProject.Forms.SAPForm.DataInfo[0, 25].Value = (object) "Measured heat to water at part output power";
              MyProject.Forms.SAPForm.DataInfo[0, 26].Value = (object) "Measured heat to room at part output power";
              MyProject.Forms.SAPForm.DataInfo[0, 27].Value = (object) "Ple test method";
              MyProject.Forms.SAPForm.DataInfo[0, 28].Value = (object) "Burner control boiler is firing";
              MyProject.Forms.SAPForm.DataInfo[0, 29].Value = (object) "Electrical power while boiler is firing";
              MyProject.Forms.SAPForm.DataInfo[0, 30].Value = (object) "Electrical power while boiler is not firing";
              MyProject.Forms.SAPForm.DataInfo[0, 31].Value = (object) "Additional ventilation rate";
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = SAP_Read._Closure\u0024__.\u0024I17\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              MyProject.Forms.SAPForm.DataInfo[1, 0].Value = (object) sedbukSolid.ID;
              MyProject.Forms.SAPForm.DataInfo[1, 1].Value = (object) sedbukSolid.RefNo;
              MyProject.Forms.SAPForm.DataInfo[1, 2].Value = (object) sedbukSolid.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfo[1, 3].Value = (object) sedbukSolid.Manu;
              MyProject.Forms.SAPForm.DataInfo[1, 4].Value = (object) sedbukSolid.BrandName;
              MyProject.Forms.SAPForm.DataInfo[1, 5].Value = (object) sedbukSolid.ModelName;
              MyProject.Forms.SAPForm.DataInfo[1, 6].Value = (object) sedbukSolid.ModelQualifier;
              MyProject.Forms.SAPForm.DataInfo[1, 7].Value = (object) sedbukSolid.ProductID;
              MyProject.Forms.SAPForm.DataInfo[1, 8].Value = (object) sedbukSolid.FirstManu;
              MyProject.Forms.SAPForm.DataInfo[1, 9].Value = (object) sedbukSolid.FinManu;
              MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) sedbukSolid.Fuel;
              MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) sedbukSolid.MainType;
              MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) sedbukSolid.Flue;
              MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) sedbukSolid.FanAssist;
              MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) sedbukSolid.FuelFeed;
              MyProject.Forms.SAPForm.DataInfo[1, 15].Value = (object) sedbukSolid.BoilPowBot;
              MyProject.Forms.SAPForm.DataInfo[1, 16].Value = (object) sedbukSolid.BoilPowTop;
              MyProject.Forms.SAPForm.DataInfo[1, 17].Value = (object) sedbukSolid.BoilPowMinBurn;
              MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) sedbukSolid.EngEffClss;
              MyProject.Forms.SAPForm.DataInfo[1, 19].Value = (object) sedbukSolid.SAPEff;
              MyProject.Forms.SAPForm.DataInfo[1, 20].Value = (object) sedbukSolid.EffCat;
              MyProject.Forms.SAPForm.DataInfo[1, 21].Value = (object) sedbukSolid.input_full;
              MyProject.Forms.SAPForm.DataInfo[1, 22].Value = (object) sedbukSolid.water_full;
              MyProject.Forms.SAPForm.DataInfo[1, 23].Value = (object) sedbukSolid.room_full;
              MyProject.Forms.SAPForm.DataInfo[1, 24].Value = (object) sedbukSolid.input_part;
              MyProject.Forms.SAPForm.DataInfo[1, 25].Value = (object) sedbukSolid.water_part;
              MyProject.Forms.SAPForm.DataInfo[1, 26].Value = (object) sedbukSolid.room_part;
              MyProject.Forms.SAPForm.DataInfo[1, 27].Value = (object) sedbukSolid.ple_test;
              MyProject.Forms.SAPForm.DataInfo[1, 28].Value = (object) sedbukSolid.Burner;
              MyProject.Forms.SAPForm.DataInfo[1, 29].Value = (object) sedbukSolid.Elect_1;
              MyProject.Forms.SAPForm.DataInfo[1, 30].Value = (object) sedbukSolid.Elect_2;
              MyProject.Forms.SAPForm.DataInfo[1, 31].Value = (object) sedbukSolid.Add_Vent;
              double num24 = Conversion.Val(sedbukSolid.Fuel);
              if (num24 == 11.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "house coal";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "house coal";
              }
              else if (num24 == 12.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "smokeless fuel";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "manufactured smokeless fuel";
              }
              else if (num24 == 13.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "anthracite";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "anthracite";
              }
              else if (num24 == 20.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "wood logs";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood logs";
              }
              else if (num24 == 21.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "wood chips";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood chips";
              }
              else if (num24 == 23.0)
              {
                MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) "wood pellets";
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
              }
              double num25 = Conversion.Val(sedbukSolid.MainType);
              if (num25 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "open fire with boiler";
              else if (num25 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "closed room heater with boiler";
              else if (num25 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) "independent boiler";
              double num26 = Conversion.Val(sedbukSolid.Flue);
              if (num26 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "unknown";
              else if (num26 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "open";
              else if (num26 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "room-sealed";
              else if (num26 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) "open or room-sealed";
              double num27 = Conversion.Val(sedbukSolid.FanAssist);
              if (num27 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "unknown";
              else if (num27 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "no fan";
              else if (num27 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) "fan";
              double num28 = Conversion.Val(sedbukSolid.FuelFeed);
              if (num28 == 0.0)
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "unknown";
              else if (num28 == 1.0)
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "manual feed";
              else if (num28 == 2.0)
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "gravity feed";
              else if (num28 == 3.0)
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "screw feed";
              else if (num28 == 4.0)
                MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) "other";
              MyProject.Forms.SAPForm.txtEfficiency.Text = Conversion.Val(sedbukSolid.SAPEff) != 0.0 ? sedbukSolid.SAPEff : Conversions.ToString(Functions.CalcMissingEff(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
            }
            else if (MyProject.Forms.SAPForm.txtSubGroup.Text.Contains("heat pumps"))
            {
              MyProject.Forms.SAPForm.DataInfo.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfo.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfo.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfo.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(36);
              else if (MyProject.Forms.SAPForm.DataInfo.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfo.Rows.Add(37);
              MyProject.Forms.SAPForm.DataInfo.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfo.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfo[0, 0].Value = (object) "ID";
              MyProject.Forms.SAPForm.DataInfo[0, 1].Value = (object) "ManuRef";
              MyProject.Forms.SAPForm.DataInfo[0, 2].Value = (object) "EntryUpdate";
              MyProject.Forms.SAPForm.DataInfo[0, 3].Value = (object) "APM";
              MyProject.Forms.SAPForm.DataInfo[0, 4].Value = (object) "Manu";
              MyProject.Forms.SAPForm.DataInfo[0, 5].Value = (object) "Brand";
              MyProject.Forms.SAPForm.DataInfo[0, 6].Value = (object) "Model";
              MyProject.Forms.SAPForm.DataInfo[0, 7].Value = (object) "Qualifier";
              MyProject.Forms.SAPForm.DataInfo[0, 8].Value = (object) "1st_year";
              MyProject.Forms.SAPForm.DataInfo[0, 9].Value = (object) "Last_Year";
              MyProject.Forms.SAPForm.DataInfo[0, 10].Value = (object) "DataQty";
              MyProject.Forms.SAPForm.DataInfo[0, 11].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfo[0, 12].Value = (object) "Emitter_Type";
              MyProject.Forms.SAPForm.DataInfo[0, 13].Value = (object) "Flue_Type";
              MyProject.Forms.SAPForm.DataInfo[0, 14].Value = (object) "Heat_Source";
              MyProject.Forms.SAPForm.DataInfo[0, 15].Value = (object) "ServiceProvision";
              MyProject.Forms.SAPForm.DataInfo[0, 16].Value = (object) "HWvessel";
              MyProject.Forms.SAPForm.DataInfo[0, 17].Value = (object) "VesselVol";
              MyProject.Forms.SAPForm.DataInfo[0, 18].Value = (object) "VesselHeat_Loss";
              MyProject.Forms.SAPForm.DataInfo[0, 19].Value = (object) "VesselHeat_Exchanger";
              MyProject.Forms.SAPForm.DataInfo[0, 20].Value = (object) "Energy_eff_Class";
              MyProject.Forms.SAPForm.DataInfo[0, 21].Value = (object) "WaterHeatingEff1";
              MyProject.Forms.SAPForm.DataInfo[0, 22].Value = (object) "NetSpecific_electric";
              MyProject.Forms.SAPForm.DataInfo[0, 23].Value = (object) "WaterHeatingEff2";
              MyProject.Forms.SAPForm.DataInfo[0, 24].Value = (object) "NetSpecify_elec";
              MyProject.Forms.SAPForm.DataInfo[0, 25].Value = (object) "Reversible";
              MyProject.Forms.SAPForm.DataInfo[0, 26].Value = (object) "ERR";
              MyProject.Forms.SAPForm.DataInfo[0, 27].Value = (object) "Max_Output";
              MyProject.Forms.SAPForm.DataInfo[0, 28].Value = (object) "Heating_Duration";
              MyProject.Forms.SAPForm.DataInfo[0, 29].Value = (object) "MEV_MVHR";
              MyProject.Forms.SAPForm.DataInfo[0, 30].Value = (object) "Compen_Effect";
              MyProject.Forms.SAPForm.DataInfo[0, 31].Value = (object) "SepCirculator";
              MyProject.Forms.SAPForm.DataInfo[0, 32].Value = (object) "No_AirFlowrates";
              MyProject.Forms.SAPForm.DataInfo[0, 33].Value = (object) "AirFlow1";
              MyProject.Forms.SAPForm.DataInfo[0, 34].Value = (object) "AirFlow2";
              MyProject.Forms.SAPForm.DataInfo[0, 35].Value = (object) "AirFlow3";
              MyProject.Forms.SAPForm.DataInfo[0, 36].Value = (object) "No_PlantSize";
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate3;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D4 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate3 = SAP_Read._Closure\u0024__.\u0024I17\u002D4;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D4 = predicate3 = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate3).SingleOrDefault<PCDF.HeatPump>();
              MyProject.Forms.SAPForm.DataInfo[1, 0].Value = (object) heatPump.ID;
              MyProject.Forms.SAPForm.DataInfo[1, 1].Value = (object) heatPump.ManuRef;
              MyProject.Forms.SAPForm.DataInfo[1, 2].Value = (object) heatPump.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfo[1, 3].Value = (object) heatPump.APM;
              MyProject.Forms.SAPForm.DataInfo[1, 4].Value = (object) heatPump.Manu;
              MyProject.Forms.SAPForm.DataInfo[1, 5].Value = (object) heatPump.Brand;
              MyProject.Forms.SAPForm.DataInfo[1, 6].Value = (object) heatPump.Model;
              MyProject.Forms.SAPForm.DataInfo[1, 7].Value = (object) heatPump.Qualifier;
              MyProject.Forms.SAPForm.DataInfo[1, 8].Value = (object) heatPump._1st_year;
              MyProject.Forms.SAPForm.DataInfo[1, 9].Value = (object) heatPump.Last_Year;
              MyProject.Forms.SAPForm.DataInfo[1, 10].Value = (object) heatPump.DataQty;
              MyProject.Forms.SAPForm.DataInfo[1, 11].Value = (object) heatPump.Fuel;
              MyProject.Forms.SAPForm.DataInfo[1, 12].Value = (object) heatPump.Emitter_Type;
              MyProject.Forms.SAPForm.DataInfo[1, 13].Value = (object) heatPump.Flue_Type;
              MyProject.Forms.SAPForm.DataInfo[1, 14].Value = (object) heatPump.Heat_Source;
              MyProject.Forms.SAPForm.DataInfo[1, 15].Value = (object) heatPump.ServiceProvision;
              MyProject.Forms.SAPForm.DataInfo[1, 16].Value = (object) heatPump.HWvessel;
              MyProject.Forms.SAPForm.DataInfo[1, 17].Value = (object) heatPump.VesselVol;
              MyProject.Forms.SAPForm.DataInfo[1, 18].Value = (object) heatPump.VesselHeat_Loss;
              MyProject.Forms.SAPForm.DataInfo[1, 19].Value = (object) heatPump.VesselHeat_Exchanger;
              MyProject.Forms.SAPForm.DataInfo[1, 20].Value = (object) heatPump.Energy_eff_Class;
              MyProject.Forms.SAPForm.DataInfo[1, 21].Value = (object) heatPump.WHEffSch2;
              MyProject.Forms.SAPForm.DataInfo[1, 22].Value = (object) heatPump.NetElecConsumedSch2;
              MyProject.Forms.SAPForm.DataInfo[1, 23].Value = (object) heatPump.WHEffSch3;
              MyProject.Forms.SAPForm.DataInfo[1, 24].Value = (object) heatPump.NetElecConsumedSch3;
              MyProject.Forms.SAPForm.DataInfo[1, 25].Value = (object) heatPump.Reversible;
              MyProject.Forms.SAPForm.DataInfo[1, 26].Value = (object) heatPump.ERR;
              MyProject.Forms.SAPForm.DataInfo[1, 27].Value = (object) heatPump.Max_Output;
              MyProject.Forms.SAPForm.DataInfo[1, 28].Value = (object) heatPump.Heating_Duration;
              MyProject.Forms.SAPForm.DataInfo[1, 29].Value = (object) heatPump.MEV_MVHR;
              MyProject.Forms.SAPForm.DataInfo[1, 30].Value = (object) heatPump.Compen_Effect;
              MyProject.Forms.SAPForm.DataInfo[1, 31].Value = (object) heatPump.SepCirculator;
              MyProject.Forms.SAPForm.DataInfo[1, 32].Value = (object) heatPump.No_AirFlowrates;
              MyProject.Forms.SAPForm.DataInfo[1, 33].Value = (object) heatPump.AirFlow1;
              MyProject.Forms.SAPForm.DataInfo[1, 34].Value = (object) heatPump.AirFlow2;
              MyProject.Forms.SAPForm.DataInfo[1, 35].Value = (object) heatPump.AirFlow3;
              MyProject.Forms.SAPForm.DataInfo[1, 36].Value = (object) heatPump.No_PlantSize;
              double num29 = Conversion.Val(heatPump.Fuel);
              if (num29 == 1.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "mains gas";
              else if (num29 == 2.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "bulk LPG";
              else if (num29 == 4.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "heating oil";
              else if (num29 == 11.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "house coal";
              else if (num29 == 12.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "manufactured smokeless fuel";
              else if (num29 == 13.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "anthracite";
              else if (num29 == 14.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "heating oil";
              else if (num29 == 20.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood logs";
              else if (num29 == 21.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood chips";
              else if (num29 == 23.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
              else if (num29 == 39.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "Electricity";
              List<PCDF.HeatPump_Sub> heatPumpsSub = SAP_Module.PCDFData.HeatPumps_Sub;
              Func<PCDF.HeatPump_Sub, bool> predicate4;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D5 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate4 = SAP_Read._Closure\u0024__.\u0024I17\u002D5;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D5 = predicate4 = (Func<PCDF.HeatPump_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              List<PCDF.HeatPump_Sub> list = heatPumpsSub.Where<PCDF.HeatPump_Sub>(predicate4).ToList<PCDF.HeatPump_Sub>();
              if (MyProject.Forms.SAPForm.DataInfoSub.Columns.Count == 0)
              {
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("ID", "ID");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("PSR", "PSR");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("Space ", "Space heating efficiency");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("electricity", "Net specific electricity consumed");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("Running", "Running Hours");
                MyProject.Forms.SAPForm.DataInfoSub.Columns.Add("Key", "Key");
              }
              else
                MyProject.Forms.SAPForm.DataInfoSub.Rows.Clear();
              MyProject.Forms.SAPForm.DataInfoSub.Columns[4].Visible = true;
              MyProject.Forms.SAPForm.DataInfoSub.Columns[5].Visible = false;
              int num30 = checked (list.Count - 1);
              int index = 0;
              while (index <= num30)
              {
                MyProject.Forms.SAPForm.DataInfoSub.Rows.Add((object) list[index].ID, (object) list[index].PlantSize_Ratio, (object) list[index].SpaceHeating, (object) list[index].Specific_Elec_Consumed);
                checked { ++index; }
              }
              MyProject.Forms.SAPForm.grpCHP.Visible = true;
              MyProject.Forms.SAPForm.txtEfficiency.Text = "";
            }
            else if (Operators.CompareString(MyProject.Forms.SAPForm.txtPrimary.Text, "Heat pumps with radiators or underfloor heating", false) == 0)
            {
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "mains gas");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "LNG");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "Electricity");
              MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bulk LPG");
              flag = true;
            }
            else if (MyProject.Forms.SAPForm.txtPrimary.Text.Equals("Warm air systems (Not heat pump)"))
            {
              List<PCDF.WarmAir> warmAirs = SAP_Module.PCDFData.WarmAirs;
              Func<PCDF.WarmAir, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I17\u002D6 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = SAP_Read._Closure\u0024__.\u0024I17\u002D6;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I17\u002D6 = predicate = (Func<PCDF.WarmAir, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
              }
              double num = Conversion.Val(warmAirs.Where<PCDF.WarmAir>(predicate).SingleOrDefault<PCDF.WarmAir>().Fuel);
              if (num == 1.0)
              {
                flag = true;
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "mains gas");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "LNG");
              }
              else if (num == 2.0)
              {
                flag = true;
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bulk LPG");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "bottled LPG");
                MyProject.Forms.SAPForm.txtMainFuel.Items.Add((object) "LPG subject to Special Condition 18");
              }
              else if (num == 4.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "heating oil";
              else if (num == 72.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "biodiesel from used cooking oil only";
              else if (num == 71.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "biodiesel from any biomass source";
              else if (num == 73.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "rapeseed oil";
              else if (num == 74.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "appliances able to use mineral oil or liquid biofuel";
              else if (num == 75.0)
                MyProject.Forms.SAPForm.txtMainFuel.Text = "B30K";
            }
            MyProject.Forms.SAPForm.txtPumpHP.Enabled = true;
            MyProject.Forms.SAPForm.txtBILock.Enabled = true;
            MyProject.Forms.SAPForm.txtBFlueType.Enabled = false;
            MyProject.Forms.SAPForm.txtFanFlued.Enabled = false;
            MyProject.Forms.SAPForm.grpBoiler.Visible = true;
            MyProject.Forms.SAPForm.grpBoilerInfo.Visible = true;
            if (!flag)
              MyProject.Forms.SAPForm.txtMainFuel.Enabled = false;
            else
              MyProject.Forms.SAPForm.txtMainFuel.Enabled = true;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
      SAP_Module.ChangeNow = false;
    }

    public static void CheckSEDBUK2()
    {
      SAP_Module.ChangeNow = true;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.IntegralPFGHRS = false;
      try
      {
        MyProject.Forms.SAPForm.TxtHeatFraction.Enabled = true;
        MyProject.Forms.SAPForm.GrpSecBoiler.Visible = false;
        MyProject.Forms.SAPForm.grpSecCHP.Visible = false;
        if (!string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK))
        {
          if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecHeatingSource.Text, "Boiler Database", false) == 0 & (uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK, "", false) > 0U)
          {
            MyProject.Forms.SAPForm.txtSecMainFuel.Items.Clear();
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SAPTableCode = 0;
            bool flag;
            if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecSubGroup.Text, "Gas boilers and oil boilers", false) == 0)
            {
              MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Enabled = true;
              List<PCDF.SEDBUK> boilers = SAP_Module.PCDFData.Boilers;
              Func<PCDF.SEDBUK, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I18\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = SAP_Read._Closure\u0024__.\u0024I18\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I18\u002D0 = predicate = (Func<PCDF.SEDBUK, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.SEDBUK sedbuk = boilers.Where<PCDF.SEDBUK>(predicate).SingleOrDefault<PCDF.SEDBUK>();
              MyProject.Forms.SAPForm.DataInfoSec.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfoSec.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(57);
              else if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(57);
              MyProject.Forms.SAPForm.DataInfoSec.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfoSec[0, 0].Value = (object) "Index";
              MyProject.Forms.SAPForm.DataInfoSec[0, 1].Value = (object) "Manufacturer Reference";
              MyProject.Forms.SAPForm.DataInfoSec[0, 2].Value = (object) "DB Entry Updated";
              MyProject.Forms.SAPForm.DataInfoSec[0, 3].Value = (object) "Manufacturer Name";
              MyProject.Forms.SAPForm.DataInfoSec[0, 4].Value = (object) "Brand Name";
              MyProject.Forms.SAPForm.DataInfoSec[0, 5].Value = (object) "Model Name";
              MyProject.Forms.SAPForm.DataInfoSec[0, 6].Value = (object) "ModelQualifier";
              MyProject.Forms.SAPForm.DataInfoSec[0, 7].Value = (object) "Boiler ID";
              MyProject.Forms.SAPForm.DataInfoSec[0, 8].Value = (object) "First Year of Manufacture";
              MyProject.Forms.SAPForm.DataInfoSec[0, 9].Value = (object) "Final Year of Manufacture";
              MyProject.Forms.SAPForm.DataInfoSec[0, 10].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfoSec[0, 11].Value = (object) "Mount Position";
              MyProject.Forms.SAPForm.DataInfoSec[0, 12].Value = (object) "Exposure Rating";
              MyProject.Forms.SAPForm.DataInfoSec[0, 13].Value = (object) "Main Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 14].Value = (object) "Subsidiary Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 15].Value = (object) "Subsidiary Type  Table";
              MyProject.Forms.SAPForm.DataInfoSec[0, 16].Value = (object) "Subsidiary Type Index";
              MyProject.Forms.SAPForm.DataInfoSec[0, 17].Value = (object) "Condensing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 18].Value = (object) "Flue Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 19].Value = (object) "Fan Assistance";
              MyProject.Forms.SAPForm.DataInfoSec[0, 20].Value = (object) "Boiler Power (bottom of range)";
              MyProject.Forms.SAPForm.DataInfoSec[0, 21].Value = (object) "Boiler Power (top of range)";
              MyProject.Forms.SAPForm.DataInfoSec[0, 22].Value = (object) "Energy Efficiency Class";
              MyProject.Forms.SAPForm.DataInfoSec[0, 23].Value = (object) "Annual Seasonal Efficiency";
              MyProject.Forms.SAPForm.DataInfoSec[0, 24].Value = (object) "SAP Winter Seasonal Efficiency";
              MyProject.Forms.SAPForm.DataInfoSec[0, 25].Value = (object) "SAP Summer Seasonal Efficiency";
              MyProject.Forms.SAPForm.DataInfoSec[0, 26].Value = (object) "Hot Water Efficiency";
              MyProject.Forms.SAPForm.DataInfoSec[0, 27].Value = (object) "SAP 2005 Efficiency";
              MyProject.Forms.SAPForm.DataInfoSec[0, 28].Value = (object) "Efficiency Category";
              MyProject.Forms.SAPForm.DataInfoSec[0, 29].Value = (object) "Test gas for LPG";
              MyProject.Forms.SAPForm.DataInfoSec[0, 30].Value = (object) "Test Correction for LPG";
              MyProject.Forms.SAPForm.DataInfoSec[0, 31].Value = (object) "SAP Equation Used";
              MyProject.Forms.SAPForm.DataInfoSec[0, 32].Value = (object) "Ignition";
              MyProject.Forms.SAPForm.DataInfoSec[0, 33].Value = (object) "Burner Control";
              MyProject.Forms.SAPForm.DataInfoSec[0, 34].Value = (object) "Electrical power while boiler is firing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 35].Value = (object) "Electrical power while boiler is not firing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 36].Value = (object) "Store Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 37].Value = (object) "Store loss in test";
              MyProject.Forms.SAPForm.DataInfoSec[0, 38].Value = (object) "Separate store";
              MyProject.Forms.SAPForm.DataInfoSec[0, 39].Value = (object) "Store boiler volume";
              MyProject.Forms.SAPForm.DataInfoSec[0, 40].Value = (object) "Store solar volume";
              MyProject.Forms.SAPForm.DataInfoSec[0, 41].Value = (object) "Store insulation thickness";
              MyProject.Forms.SAPForm.DataInfoSec[0, 42].Value = (object) "Store insulation type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 43].Value = (object) "Store temperature";
              MyProject.Forms.SAPForm.DataInfoSec[0, 44].Value = (object) "Store heat loss rate";
              MyProject.Forms.SAPForm.DataInfoSec[0, 45].Value = (object) "Separate DHW tests";
              MyProject.Forms.SAPForm.DataInfoSec[0, 46].Value = (object) "Fuel energy for HW test 1";
              MyProject.Forms.SAPForm.DataInfoSec[0, 47].Value = (object) "Electrical energy for HW test 1";
              MyProject.Forms.SAPForm.DataInfoSec[0, 48].Value = (object) "Rejected energy r1 in HW test 1";
              MyProject.Forms.SAPForm.DataInfoSec[0, 49].Value = (object) "Storage loss factor F1";
              MyProject.Forms.SAPForm.DataInfoSec[0, 50].Value = (object) "Fuel energy for HW test 2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 51].Value = (object) "Electrical energy for HW test 2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 52].Value = (object) "Rejected energy r2 in HW test 2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 53].Value = (object) "Storage loss factor F2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 54].Value = (object) "Storage loss factor F3";
              MyProject.Forms.SAPForm.DataInfoSec[0, 55].Value = (object) "'Keep-hot' facility";
              MyProject.Forms.SAPForm.DataInfoSec[0, 56].Value = (object) "'Keep-hot' timer";
              MyProject.Forms.SAPForm.DataInfoSec[0, 57].Value = (object) "'Keep-hot' electric heater";
              MyProject.Forms.SAPForm.DataInfoSec[1, 0].Value = (object) sedbuk.ID;
              MyProject.Forms.SAPForm.DataInfoSec[1, 1].Value = (object) sedbuk.RefNo;
              MyProject.Forms.SAPForm.DataInfoSec[1, 2].Value = (object) sedbuk.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfoSec[1, 3].Value = (object) sedbuk.CurrManu;
              MyProject.Forms.SAPForm.DataInfoSec[1, 4].Value = (object) sedbuk.BrandName;
              MyProject.Forms.SAPForm.DataInfoSec[1, 5].Value = (object) sedbuk.ModelName;
              MyProject.Forms.SAPForm.DataInfoSec[1, 6].Value = (object) sedbuk.ModelQualifier;
              MyProject.Forms.SAPForm.DataInfoSec[1, 7].Value = (object) sedbuk.BoilerID;
              MyProject.Forms.SAPForm.DataInfoSec[1, 8].Value = (object) sedbuk.FirstManu;
              MyProject.Forms.SAPForm.DataInfoSec[1, 9].Value = (object) sedbuk.FinManu;
              double num1 = Conversion.Val(sedbuk.Fuel);
              if (num1 == 1.0)
              {
                flag = true;
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "Gas/LNG";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "mains gas";
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "mains gas");
              }
              else if (num1 == 2.0)
              {
                flag = true;
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "LPG";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "bulk LPG";
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "bottled LPG");
                MyProject.Forms.SAPForm.txtSecMainFuel.Items.Add((object) "LPG subject to Special Condition 18");
              }
              else if (num1 == 4.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "Oil";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
                MyProject.Forms.SAPForm.chkSecOilPump.Visible = true;
              }
              else if (num1 == 72.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "biodiesel from used cooking oil only";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "biodiesel from used cooking oil only";
              }
              else if (num1 == 71.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "biodiesel from any biomass source";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "biodiesel from any biomass source";
              }
              else if (num1 == 73.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "rapeseed oil";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "rapeseed oil";
              }
              else if (num1 == 74.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "appliances able to use mineral oil or liquid biofuel";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "appliances able to use mineral oil or liquid biofuel";
              }
              else if (num1 == 75.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "B30K";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "B30K";
              }
              double num2 = Conversion.Val(sedbuk.MountPosition);
              if (num2 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "Unknown";
              else if (num2 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "Floor";
              else if (num2 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "Wall";
              else if (num2 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "Either floor or wall";
              else if (num2 == 4.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "Back boiler";
              double num3 = Conversion.Val(sedbuk.ExposureRating);
              if (num3 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "Unknown";
              else if (num3 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "Indoor only";
              else if (num3 == 4.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "Outdoor";
              double num4 = Conversion.Val(sedbuk.MainType);
              if (num4 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "Unknown";
              else if (num4 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "Regular";
              else if (num4 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "Combi";
              else if (num4 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "CPSU";
              double num5 = Conversion.Val(sedbuk.SubType);
              if (num5 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "normal";
              else if (num5 == 1.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "with integral PFGHRD";
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.IntegralPFGHRS = true;
              }
              MyProject.Forms.SAPForm.DataInfoSec[1, 15].Value = (object) sedbuk.SubTypeTable;
              MyProject.Forms.SAPForm.DataInfoSec[1, 16].Value = (object) sedbuk.SubTypeIndex;
              double num6 = Conversion.Val(sedbuk.Condensing);
              if (num6 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 17].Value = (object) "Unknown";
              else if (num6 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 17].Value = (object) "Non-condensing";
              else if (num6 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 17].Value = (object) "Condensing";
              double num7 = Conversion.Val(sedbuk.FlueType);
              if (num7 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) "Unknown";
              else if (num7 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) "Open";
              else if (num7 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) "Room-sealed";
              else if (num7 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) "Open or room-sealed";
              double num8 = Conversion.Val(sedbuk.FanAssist);
              if (num8 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 19].Value = (object) "Unknown";
              else if (num8 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 19].Value = (object) "No fan";
              else if (num8 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 19].Value = (object) "Fan";
              MyProject.Forms.SAPForm.DataInfoSec[1, 20].Value = (object) sedbuk.BoilPowBot;
              MyProject.Forms.SAPForm.DataInfoSec[1, 21].Value = (object) sedbuk.BoilPowTop;
              MyProject.Forms.SAPForm.DataInfoSec[1, 22].Value = (object) sedbuk.EngEffClss;
              MyProject.Forms.SAPForm.DataInfoSec[1, 23].Value = (object) sedbuk.AnnualEff;
              MyProject.Forms.SAPForm.DataInfoSec[1, 24].Value = (object) sedbuk.WinterEff;
              MyProject.Forms.SAPForm.DataInfoSec[1, 25].Value = (object) sedbuk.SummerEff;
              MyProject.Forms.SAPForm.DataInfoSec[1, 26].Value = (object) sedbuk.HotWaterEff;
              MyProject.Forms.SAPForm.DataInfoSec[1, 27].Value = (object) sedbuk.SAPEff;
              double num9 = Conversion.Val(sedbuk.EffCat);
              if (num9 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 28].Value = (object) "Unknown";
              else if (num9 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 28].Value = (object) "SEDBUK based on validated and certified data";
              else if (num9 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 28].Value = (object) "SEDBUK based on certified data";
              else if (num9 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 28].Value = (object) "Estimated (for obsolete boilers only)";
              double num10 = Conversion.Val(sedbuk.LPGTstGas);
              MyProject.Forms.SAPForm.DataInfoSec[1, 29].Value = num10 != 0.0 ? (num10 != 1.0 ? (object) "" : (object) "The tests were carried out using natural gas and the modified calculation procedure") : (object) "The efficiency tests from which SEDBUK was calculated were carried out using LPG";
              double num11 = Conversion.Val(sedbuk.LPGTstCorrection);
              MyProject.Forms.SAPForm.DataInfoSec[1, 30].Value = num11 != 0.0 ? (num11 != 1.0 ? (object) "" : (object) "The correction was not applied") : (object) "The correction was not applied to the results on the test certificate";
              try
              {
                MyProject.Forms.SAPForm.DataInfo[1, 31].Value = (object) sedbuk.SAPEqUsed;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              double num12 = Conversion.Val(sedbuk.Ignition);
              if (num12 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 32].Value = (object) "Unknown";
              else if (num12 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 32].Value = (object) "No";
              else if (num12 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 32].Value = (object) "Yes";
              double num13 = Conversion.Val(sedbuk.BurnCont);
              if (num13 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 33].Value = (object) "Unknown";
              else if (num13 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 33].Value = (object) "On-off";
              else if (num13 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 33].Value = (object) "variable (stepped or modulating)";
              MyProject.Forms.SAPForm.DataInfoSec[1, 34].Value = (object) sedbuk.ElPowFire;
              MyProject.Forms.SAPForm.DataInfoSec[1, 35].Value = (object) sedbuk.ElPowNtFire;
              double num14 = Conversion.Val(sedbuk.StrType);
              if (num14 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 36].Value = (object) "Unknown";
              else if (num14 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 36].Value = (object) "A storage combination boiler with Primary Store";
              else if (num14 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 36].Value = (object) "A storage combination boiler with Secondary Store";
              else if (num14 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 36].Value = (object) "CPSU";
              double num15 = Conversion.Val(sedbuk.StrLoss);
              MyProject.Forms.SAPForm.DataInfoSec[1, 37].Value = num15 != 0.0 ? (num15 != 1.0 ? (num15 != 2.0 ? (object) "" : (object) "Heat loss from the internal hot water store has been included in the efficiency test values reported") : (object) "Heat loss from the internal hot water store has been excluded in the efficiency test values reported") : (object) "Unknown";
              double num16 = Conversion.Val(sedbuk.StrSep);
              MyProject.Forms.SAPForm.DataInfoSec[1, 38].Value = num16 != 1.0 ? (num16 != 2.0 ? (object) "Unknown/Inapplicable" : (object) "Yes") : (object) "Hot water store is within the boiler casing";
              MyProject.Forms.SAPForm.DataInfoSec[1, 39].Value = (object) sedbuk.StrVol;
              MyProject.Forms.SAPForm.DataInfoSec[1, 40].Value = (object) sedbuk.StrSolarVol;
              MyProject.Forms.SAPForm.DataInfoSec[1, 41].Value = (object) sedbuk.StrInsThk;
              double num17 = Conversion.Val(sedbuk.StrInsType);
              MyProject.Forms.SAPForm.DataInfoSec[1, 42].Value = num17 != 1.0 ? (num17 != 2.0 ? (num17 != 3.0 ? (num17 != 4.0 ? (num17 != 5.0 ? (num17 != 6.0 ? (object) "Unknown/Inapplicable" : (object) "Closest to MW (glass)") : (object) "Closest to PU") : (object) "Closest to MW (rock)") : (object) "Mineral wool (glass)") : (object) "Polyurethane foam") : (object) "Mineral wool (rock)";
              MyProject.Forms.SAPForm.DataInfoSec[1, 43].Value = (object) sedbuk.StrTemp;
              MyProject.Forms.SAPForm.DataInfoSec[1, 44].Value = (object) sedbuk.StrHtLoss;
              double num18 = Conversion.Val(sedbuk.SeperateDHWTests);
              if (num18 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 45].Value = (object) "none or not applicable";
              else if (num18 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 45].Value = (object) "one test, using schedule 2";
              else if (num18 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 45].Value = (object) "two tests, using schedules 2 and 3";
              else if (num18 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 45].Value = (object) "two tests, using schedules 2 and 1";
              MyProject.Forms.SAPForm.DataInfoSec[1, 46].Value = (object) sedbuk.FuelEnergyT1;
              MyProject.Forms.SAPForm.DataInfoSec[1, 47].Value = (object) sedbuk.ElecEnergyT1;
              MyProject.Forms.SAPForm.DataInfoSec[1, 48].Value = (object) sedbuk.RejEnergy_r1T1;
              MyProject.Forms.SAPForm.DataInfoSec[1, 49].Value = (object) sedbuk.StoLossF1;
              MyProject.Forms.SAPForm.DataInfoSec[1, 50].Value = (object) sedbuk.FuelEnergyT2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 51].Value = (object) sedbuk.ElecEnergyT2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 52].Value = (object) sedbuk.RejEnergy_r2T2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 53].Value = (object) sedbuk.StoLossF2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 54].Value = (object) sedbuk.StoLossF3;
              if (!Information.IsDBNull((object) sedbuk.KpHtFac))
              {
                double num19 = Conversion.Val(sedbuk.KpHtFac);
                MyProject.Forms.SAPForm.DataInfoSec[1, 55].Value = num19 != 0.0 ? (num19 != 1.0 ? (num19 != 2.0 ? (num19 != 3.0 ? (object) "Unknown/Inapplicable" : (object) "A 'keep-hot' facility both fuelled by gas/oil and powered by electricity") : (object) "A 'keep-hot' facility powered by electricity") : (object) "A 'keep-hot' facility fuelled by gas/oil only") : (object) "No 'keep-hot' facility";
              }
              if (!Information.IsDBNull((object) sedbuk.KpHtTmr))
              {
                double num20 = Conversion.Val(sedbuk.KpHtTmr);
                MyProject.Forms.SAPForm.DataInfoSec[1, 56].Value = num20 != 0.0 ? (num20 != 1.0 ? (object) "Unknown/Inapplicable" : (object) "A time-switch control which turns off the facility overnight") : (object) "No such control";
              }
              MyProject.Forms.SAPForm.DataInfoSec[1, 57].Value = (object) sedbuk.KpHtElcHtr;
              MyProject.Forms.SAPForm.txtSecEfficiency.Text = sedbuk.AnnualEff;
            }
            else if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecSubGroup.Text, "Micro-cogeneration (micro-CHP)", false) == 0)
            {
              List<PCDF.CHP> chPs = SAP_Module.PCDFData.CHPs;
              Func<PCDF.CHP, bool> predicate1;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I18\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate1 = SAP_Read._Closure\u0024__.\u0024I18\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I18\u002D1 = predicate1 = (Func<PCDF.CHP, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.CHP chp = chPs.Where<PCDF.CHP>(predicate1).SingleOrDefault<PCDF.CHP>();
              MyProject.Forms.SAPForm.DataInfoSec.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfoSec.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(25);
              else if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(24);
              MyProject.Forms.SAPForm.DataInfoSec.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfoSec[0, 0].Value = (object) "ID";
              MyProject.Forms.SAPForm.DataInfoSec[0, 1].Value = (object) "ManuRef";
              MyProject.Forms.SAPForm.DataInfoSec[0, 2].Value = (object) "EntryUpdate";
              MyProject.Forms.SAPForm.DataInfoSec[0, 3].Value = (object) "APM";
              MyProject.Forms.SAPForm.DataInfoSec[0, 4].Value = (object) "Manu";
              MyProject.Forms.SAPForm.DataInfoSec[0, 5].Value = (object) "Brand";
              MyProject.Forms.SAPForm.DataInfoSec[0, 6].Value = (object) "Model";
              MyProject.Forms.SAPForm.DataInfoSec[0, 7].Value = (object) "Qualifier";
              MyProject.Forms.SAPForm.DataInfoSec[0, 8].Value = (object) "1st_year";
              MyProject.Forms.SAPForm.DataInfoSec[0, 9].Value = (object) "Last_Year";
              MyProject.Forms.SAPForm.DataInfoSec[0, 10].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfoSec[0, 11].Value = (object) "Condensing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 12].Value = (object) "Flue_Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 13].Value = (object) "ServiceProvision";
              MyProject.Forms.SAPForm.DataInfoSec[0, 14].Value = (object) "HWVessel";
              MyProject.Forms.SAPForm.DataInfoSec[0, 15].Value = (object) "Class";
              MyProject.Forms.SAPForm.DataInfoSec[0, 16].Value = (object) "WHEffSch2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 17].Value = (object) "NetElecConsumedSch2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 18].Value = (object) "WHEffSch3";
              MyProject.Forms.SAPForm.DataInfoSec[0, 19].Value = (object) "NetElecConsumedSch3";
              MyProject.Forms.SAPForm.DataInfoSec[0, 20].Value = (object) "CogenPPowerBottom";
              MyProject.Forms.SAPForm.DataInfoSec[0, 21].Value = (object) "CogenPPowerTop";
              MyProject.Forms.SAPForm.DataInfoSec[0, 22].Value = (object) "HeatingDuration";
              MyProject.Forms.SAPForm.DataInfoSec[0, 23].Value = (object) "SepCirculator";
              MyProject.Forms.SAPForm.DataInfoSec[0, 24].Value = (object) "PSR_Numb";
              MyProject.Forms.SAPForm.DataInfoSec[1, 0].Value = (object) chp.ID;
              MyProject.Forms.SAPForm.DataInfoSec[1, 1].Value = (object) chp.ManuRef;
              MyProject.Forms.SAPForm.DataInfoSec[1, 2].Value = (object) chp.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfoSec[1, 3].Value = (object) chp.APM;
              MyProject.Forms.SAPForm.DataInfoSec[1, 4].Value = (object) chp.Manu;
              MyProject.Forms.SAPForm.DataInfoSec[1, 5].Value = (object) chp.Brand;
              MyProject.Forms.SAPForm.DataInfoSec[1, 6].Value = (object) chp.Model;
              MyProject.Forms.SAPForm.DataInfoSec[1, 7].Value = (object) chp.Qualifier;
              MyProject.Forms.SAPForm.DataInfoSec[1, 8].Value = (object) chp._1st_year;
              MyProject.Forms.SAPForm.DataInfoSec[1, 9].Value = (object) chp.Last_Year;
              MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) chp.Fuel;
              MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) chp.Condensing;
              MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) chp.Flue_Type;
              MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) chp.ServiceProvision;
              MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) chp.HWVessel;
              MyProject.Forms.SAPForm.DataInfoSec[1, 15].Value = (object) chp._Class;
              MyProject.Forms.SAPForm.DataInfoSec[1, 16].Value = (object) chp.WHEffSch2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 17].Value = (object) chp.NetElecConsumedSch2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) chp.WHEffSch3;
              MyProject.Forms.SAPForm.DataInfoSec[1, 19].Value = (object) chp.NetElecConsumedSch3;
              MyProject.Forms.SAPForm.DataInfoSec[1, 20].Value = (object) chp.CogenPPowerBottom;
              MyProject.Forms.SAPForm.DataInfoSec[1, 21].Value = (object) chp.CogenPPowerTop;
              MyProject.Forms.SAPForm.DataInfoSec[1, 22].Value = (object) chp.HeatingDuration;
              MyProject.Forms.SAPForm.DataInfoSec[1, 23].Value = (object) chp.SepCirculator;
              MyProject.Forms.SAPForm.DataInfoSec[1, 24].Value = (object) chp.PSR_Numb;
              double num21 = Conversion.Val(chp.Fuel);
              if (num21 == 1.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "mains gas";
              else if (num21 == 2.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "bulk LPG";
              else if (num21 == 4.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
              else if (num21 == 11.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "house coal";
              else if (num21 == 12.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "manufactured smokeless fuel";
              else if (num21 == 13.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "anthracite";
              else if (num21 == 14.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
              else if (num21 == 20.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood logs";
              else if (num21 == 21.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood chips";
              else if (num21 == 23.0)
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
              double num22 = Conversion.Val(chp.Condensing);
              if (num22 == 2.0)
                MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Enabled = true;
              else if (num22 == 1.0)
              {
                MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Enabled = false;
                MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Checked = false;
              }
              List<PCDF.CHP_Sub> chPsSub = SAP_Module.PCDFData.CHPs_Sub;
              Func<PCDF.CHP_Sub, bool> predicate2;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I18\u002D2 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate2 = SAP_Read._Closure\u0024__.\u0024I18\u002D2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I18\u002D2 = predicate2 = (Func<PCDF.CHP_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              List<PCDF.CHP_Sub> list = chPsSub.Where<PCDF.CHP_Sub>(predicate2).ToList<PCDF.CHP_Sub>();
              if (MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Count == 0)
              {
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("ID", "ID");
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("PSR", "PSR");
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("Space ", "Space heating efficiency");
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("electricity", "Net specific electricity consumed");
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("Key", "Key");
              }
              else
                MyProject.Forms.SAPForm.DataSecInfoSub.Rows.Clear();
              int num23 = checked (list.Count - 1);
              int index = 0;
              while (index <= num23)
              {
                MyProject.Forms.SAPForm.DataSecInfoSub.Rows.Add((object) list[index].ID, (object) list[index].PSR, (object) list[index].Efficiency, (object) list[index].ElecConsumed);
                checked { ++index; }
              }
              MyProject.Forms.SAPForm.grpSecCHP.Visible = true;
              MyProject.Forms.SAPForm.txtSecEfficiency.Text = "";
            }
            else if (Operators.CompareString(MyProject.Forms.SAPForm.txtSecSubGroup.Text, "Solid fuel boilers", false) == 0)
            {
              MyProject.Forms.SAPForm.DataInfoSec.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfoSec.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(32);
              else if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(31);
              MyProject.Forms.SAPForm.DataInfoSec.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfoSec[0, 0].Value = (object) "ID";
              MyProject.Forms.SAPForm.DataInfoSec[0, 1].Value = (object) "RefNo";
              MyProject.Forms.SAPForm.DataInfoSec[0, 2].Value = (object) "Entry Update";
              MyProject.Forms.SAPForm.DataInfoSec[0, 3].Value = (object) "Manufacturer";
              MyProject.Forms.SAPForm.DataInfoSec[0, 4].Value = (object) "Brand Name";
              MyProject.Forms.SAPForm.DataInfoSec[0, 5].Value = (object) "Model Name";
              MyProject.Forms.SAPForm.DataInfoSec[0, 6].Value = (object) "Model Qualifier";
              MyProject.Forms.SAPForm.DataInfoSec[0, 7].Value = (object) "Product ID";
              MyProject.Forms.SAPForm.DataInfoSec[0, 8].Value = (object) "First Manu";
              MyProject.Forms.SAPForm.DataInfoSec[0, 9].Value = (object) "Final Manu";
              MyProject.Forms.SAPForm.DataInfoSec[0, 10].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfoSec[0, 11].Value = (object) "Main Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 12].Value = (object) "Flue";
              MyProject.Forms.SAPForm.DataInfoSec[0, 13].Value = (object) "Fan Assististed";
              MyProject.Forms.SAPForm.DataInfoSec[0, 14].Value = (object) "Fuel Feed";
              MyProject.Forms.SAPForm.DataInfoSec[0, 15].Value = (object) "Boiler Power (bottom of range)";
              MyProject.Forms.SAPForm.DataInfoSec[0, 16].Value = (object) "Boiler Power (top of range)";
              MyProject.Forms.SAPForm.DataInfoSec[0, 17].Value = (object) "Boiler Power at minimum burn rate";
              MyProject.Forms.SAPForm.DataInfoSec[0, 18].Value = (object) "Energy efficiency class";
              MyProject.Forms.SAPForm.DataInfoSec[0, 19].Value = (object) "SAP Efficiency efficiency of boiler";
              MyProject.Forms.SAPForm.DataInfoSec[0, 20].Value = (object) "Efficiency Catagory";
              MyProject.Forms.SAPForm.DataInfoSec[0, 21].Value = (object) "Measured fuel input at nominal output power";
              MyProject.Forms.SAPForm.DataInfoSec[0, 22].Value = (object) "Measured heat to water at nominal output";
              MyProject.Forms.SAPForm.DataInfoSec[0, 23].Value = (object) "Measured heat to room at nominal output power";
              MyProject.Forms.SAPForm.DataInfoSec[0, 24].Value = (object) "Measured fuel input at part output power";
              MyProject.Forms.SAPForm.DataInfoSec[0, 25].Value = (object) "Measured heat to water at part output power";
              MyProject.Forms.SAPForm.DataInfoSec[0, 26].Value = (object) "Measured heat to room at part output power";
              MyProject.Forms.SAPForm.DataInfoSec[0, 27].Value = (object) "Ple test method";
              MyProject.Forms.SAPForm.DataInfoSec[0, 28].Value = (object) "Burner control boiler is firing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 29].Value = (object) "Electrical power while boiler is firing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 30].Value = (object) "Electrical power while boiler is not firing";
              MyProject.Forms.SAPForm.DataInfoSec[0, 31].Value = (object) "Additional ventilation rate";
              List<PCDF.SEDBUK_Solid> solidBoilers = SAP_Module.PCDFData.Solid_Boilers;
              Func<PCDF.SEDBUK_Solid, bool> predicate;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I18\u002D3 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate = SAP_Read._Closure\u0024__.\u0024I18\u002D3;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I18\u002D3 = predicate = (Func<PCDF.SEDBUK_Solid, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.SEDBUK_Solid sedbukSolid = solidBoilers.Where<PCDF.SEDBUK_Solid>(predicate).SingleOrDefault<PCDF.SEDBUK_Solid>();
              MyProject.Forms.SAPForm.DataInfoSec[1, 0].Value = (object) sedbukSolid.ID;
              MyProject.Forms.SAPForm.DataInfoSec[1, 1].Value = (object) sedbukSolid.RefNo;
              MyProject.Forms.SAPForm.DataInfoSec[1, 2].Value = (object) sedbukSolid.EntryUpdate;
              MyProject.Forms.SAPForm.DataInfoSec[1, 3].Value = (object) sedbukSolid.Manu;
              MyProject.Forms.SAPForm.DataInfoSec[1, 4].Value = (object) sedbukSolid.BrandName;
              MyProject.Forms.SAPForm.DataInfoSec[1, 5].Value = (object) sedbukSolid.ModelName;
              MyProject.Forms.SAPForm.DataInfoSec[1, 6].Value = (object) sedbukSolid.ModelQualifier;
              MyProject.Forms.SAPForm.DataInfoSec[1, 7].Value = (object) sedbukSolid.ProductID;
              MyProject.Forms.SAPForm.DataInfoSec[1, 8].Value = (object) sedbukSolid.FirstManu;
              MyProject.Forms.SAPForm.DataInfoSec[1, 9].Value = (object) sedbukSolid.FinManu;
              MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) sedbukSolid.Fuel;
              MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) sedbukSolid.MainType;
              MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) sedbukSolid.Flue;
              MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) sedbukSolid.FanAssist;
              MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) sedbukSolid.FuelFeed;
              MyProject.Forms.SAPForm.DataInfoSec[1, 15].Value = (object) sedbukSolid.BoilPowBot;
              MyProject.Forms.SAPForm.DataInfoSec[1, 16].Value = (object) sedbukSolid.BoilPowTop;
              MyProject.Forms.SAPForm.DataInfoSec[1, 17].Value = (object) sedbukSolid.BoilPowMinBurn;
              MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) sedbukSolid.EngEffClss;
              MyProject.Forms.SAPForm.DataInfoSec[1, 19].Value = (object) sedbukSolid.SAPEff;
              MyProject.Forms.SAPForm.DataInfoSec[1, 20].Value = (object) sedbukSolid.EffCat;
              MyProject.Forms.SAPForm.DataInfoSec[1, 21].Value = (object) sedbukSolid.input_full;
              MyProject.Forms.SAPForm.DataInfoSec[1, 22].Value = (object) sedbukSolid.water_full;
              MyProject.Forms.SAPForm.DataInfoSec[1, 23].Value = (object) sedbukSolid.room_full;
              MyProject.Forms.SAPForm.DataInfoSec[1, 24].Value = (object) sedbukSolid.input_part;
              MyProject.Forms.SAPForm.DataInfoSec[1, 25].Value = (object) sedbukSolid.water_part;
              MyProject.Forms.SAPForm.DataInfoSec[1, 26].Value = (object) sedbukSolid.room_part;
              MyProject.Forms.SAPForm.DataInfoSec[1, 27].Value = (object) sedbukSolid.ple_test;
              MyProject.Forms.SAPForm.DataInfoSec[1, 28].Value = (object) sedbukSolid.Burner;
              MyProject.Forms.SAPForm.DataInfoSec[1, 29].Value = (object) sedbukSolid.Elect_1;
              MyProject.Forms.SAPForm.DataInfoSec[1, 30].Value = (object) sedbukSolid.Elect_2;
              MyProject.Forms.SAPForm.DataInfoSec[1, 31].Value = (object) sedbukSolid.Add_Vent;
              double num24 = Conversion.Val(sedbukSolid.Fuel);
              if (num24 == 11.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "house coal";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "house coal";
              }
              else if (num24 == 12.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "smokeless fuel";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "manufactured smokeless fuel";
              }
              else if (num24 == 13.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "anthracite";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "anthracite";
              }
              else if (num24 == 20.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "wood logs";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood logs";
              }
              else if (num24 == 21.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "wood chips";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood chips";
              }
              else if (num24 == 23.0)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) "wood pellets";
                MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
              }
              double num25 = Conversion.Val(sedbukSolid.MainType);
              if (num25 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "open fire with boiler";
              else if (num25 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "closed room heater with boiler";
              else if (num25 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) "independent boiler";
              double num26 = Conversion.Val(sedbukSolid.Flue);
              if (num26 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "unknown";
              else if (num26 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "open";
              else if (num26 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "room-sealed";
              else if (num26 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) "open or room-sealed";
              double num27 = Conversion.Val(sedbukSolid.FanAssist);
              if (num27 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "unknown";
              else if (num27 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "no fan";
              else if (num27 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) "fan";
              double num28 = Conversion.Val(sedbukSolid.FuelFeed);
              if (num28 == 0.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "unknown";
              else if (num28 == 1.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "manual feed";
              else if (num28 == 2.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "gravity feed";
              else if (num28 == 3.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "screw feed";
              else if (num28 == 4.0)
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) "other";
              MyProject.Forms.SAPForm.txtSecEfficiency.Text = Conversion.Val(sedbukSolid.SAPEff) != 0.0 ? sedbukSolid.SAPEff : Conversions.ToString(Functions.CalcMissingEff(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
            }
            else if (MyProject.Forms.SAPForm.txtSecSubGroup.Text.Contains("heat pumps"))
            {
              MyProject.Forms.SAPForm.DataInfoSec.Rows.Clear();
              if (MyProject.Forms.SAPForm.DataInfoSec.ColumnCount == 0)
              {
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C1", "C1");
                MyProject.Forms.SAPForm.DataInfoSec.Columns.Add("C2", "C2");
              }
              if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 0)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(36);
              else if (MyProject.Forms.SAPForm.DataInfoSec.RowCount == 1)
                MyProject.Forms.SAPForm.DataInfoSec.Rows.Add(37);
              MyProject.Forms.SAPForm.DataInfoSec.Columns[0].Width = 120;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].Width = 250;
              MyProject.Forms.SAPForm.DataInfoSec.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
              MyProject.Forms.SAPForm.DataInfoSec[0, 0].Value = (object) "ID";
              MyProject.Forms.SAPForm.DataInfoSec[0, 1].Value = (object) "ManuRef";
              MyProject.Forms.SAPForm.DataInfoSec[0, 2].Value = (object) "EntryUpdate";
              MyProject.Forms.SAPForm.DataInfoSec[0, 3].Value = (object) "APM";
              MyProject.Forms.SAPForm.DataInfoSec[0, 4].Value = (object) "Manu";
              MyProject.Forms.SAPForm.DataInfoSec[0, 5].Value = (object) "Brand";
              MyProject.Forms.SAPForm.DataInfoSec[0, 6].Value = (object) "Model";
              MyProject.Forms.SAPForm.DataInfoSec[0, 7].Value = (object) "Qualifier";
              MyProject.Forms.SAPForm.DataInfoSec[0, 8].Value = (object) "1st_year";
              MyProject.Forms.SAPForm.DataInfoSec[0, 9].Value = (object) "Last_Year";
              MyProject.Forms.SAPForm.DataInfoSec[0, 10].Value = (object) "DataQty";
              MyProject.Forms.SAPForm.DataInfoSec[0, 11].Value = (object) "Fuel";
              MyProject.Forms.SAPForm.DataInfoSec[0, 12].Value = (object) "Emitter_Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 13].Value = (object) "Flue_Type";
              MyProject.Forms.SAPForm.DataInfoSec[0, 14].Value = (object) "Heat_Source";
              MyProject.Forms.SAPForm.DataInfoSec[0, 15].Value = (object) "ServiceProvision";
              MyProject.Forms.SAPForm.DataInfoSec[0, 16].Value = (object) "HWvessel";
              MyProject.Forms.SAPForm.DataInfoSec[0, 17].Value = (object) "VesselVol";
              MyProject.Forms.SAPForm.DataInfoSec[0, 18].Value = (object) "VesselHeat_Loss";
              MyProject.Forms.SAPForm.DataInfoSec[0, 19].Value = (object) "VesselHeat_Exchanger";
              MyProject.Forms.SAPForm.DataInfoSec[0, 20].Value = (object) "Energy_eff_Class";
              MyProject.Forms.SAPForm.DataInfoSec[0, 21].Value = (object) "WaterHeatingEff1";
              MyProject.Forms.SAPForm.DataInfoSec[0, 22].Value = (object) "NetSpecific_electric";
              MyProject.Forms.SAPForm.DataInfoSec[0, 23].Value = (object) "WaterHeatingEff2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 24].Value = (object) "NetSpecify_elec";
              MyProject.Forms.SAPForm.DataInfoSec[0, 25].Value = (object) "Reversible";
              MyProject.Forms.SAPForm.DataInfoSec[0, 26].Value = (object) "ERR";
              MyProject.Forms.SAPForm.DataInfoSec[0, 27].Value = (object) "Max_Output";
              MyProject.Forms.SAPForm.DataInfoSec[0, 28].Value = (object) "Heating_Duration";
              MyProject.Forms.SAPForm.DataInfoSec[0, 29].Value = (object) "MEV_MVHR";
              MyProject.Forms.SAPForm.DataInfoSec[0, 30].Value = (object) "Compen_Effect";
              MyProject.Forms.SAPForm.DataInfoSec[0, 31].Value = (object) "SepCirculator";
              MyProject.Forms.SAPForm.DataInfoSec[0, 32].Value = (object) "No_AirFlowrates";
              MyProject.Forms.SAPForm.DataInfoSec[0, 33].Value = (object) "AirFlow1";
              MyProject.Forms.SAPForm.DataInfoSec[0, 34].Value = (object) "AirFlow2";
              MyProject.Forms.SAPForm.DataInfoSec[0, 35].Value = (object) "AirFlow3";
              MyProject.Forms.SAPForm.DataInfoSec[0, 36].Value = (object) "No_PlantSize";
              List<PCDF.HeatPump> heatPumps = SAP_Module.PCDFData.HeatPumps;
              Func<PCDF.HeatPump, bool> predicate3;
              // ISSUE: reference to a compiler-generated field
              if (SAP_Read._Closure\u0024__.\u0024I18\u002D4 != null)
              {
                // ISSUE: reference to a compiler-generated field
                predicate3 = SAP_Read._Closure\u0024__.\u0024I18\u002D4;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                SAP_Read._Closure\u0024__.\u0024I18\u002D4 = predicate3 = (Func<PCDF.HeatPump, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
              }
              PCDF.HeatPump heatPump = heatPumps.Where<PCDF.HeatPump>(predicate3).SingleOrDefault<PCDF.HeatPump>();
              if (heatPump != null)
              {
                MyProject.Forms.SAPForm.DataInfoSec[1, 0].Value = (object) heatPump.ID;
                MyProject.Forms.SAPForm.DataInfoSec[1, 1].Value = (object) heatPump.ManuRef;
                MyProject.Forms.SAPForm.DataInfoSec[1, 2].Value = (object) heatPump.EntryUpdate;
                MyProject.Forms.SAPForm.DataInfoSec[1, 3].Value = (object) heatPump.APM;
                MyProject.Forms.SAPForm.DataInfoSec[1, 4].Value = (object) heatPump.Manu;
                MyProject.Forms.SAPForm.DataInfoSec[1, 5].Value = (object) heatPump.Brand;
                MyProject.Forms.SAPForm.DataInfoSec[1, 6].Value = (object) heatPump.Model;
                MyProject.Forms.SAPForm.DataInfoSec[1, 7].Value = (object) heatPump.Qualifier;
                MyProject.Forms.SAPForm.DataInfoSec[1, 8].Value = (object) heatPump._1st_year;
                MyProject.Forms.SAPForm.DataInfoSec[1, 9].Value = (object) heatPump.Last_Year;
                MyProject.Forms.SAPForm.DataInfoSec[1, 10].Value = (object) heatPump.DataQty;
                MyProject.Forms.SAPForm.DataInfoSec[1, 11].Value = (object) heatPump.Fuel;
                MyProject.Forms.SAPForm.DataInfoSec[1, 12].Value = (object) heatPump.Emitter_Type;
                MyProject.Forms.SAPForm.DataInfoSec[1, 13].Value = (object) heatPump.Flue_Type;
                MyProject.Forms.SAPForm.DataInfoSec[1, 14].Value = (object) heatPump.Heat_Source;
                MyProject.Forms.SAPForm.DataInfoSec[1, 15].Value = (object) heatPump.ServiceProvision;
                MyProject.Forms.SAPForm.DataInfoSec[1, 16].Value = (object) heatPump.HWvessel;
                MyProject.Forms.SAPForm.DataInfoSec[1, 17].Value = (object) heatPump.VesselVol;
                MyProject.Forms.SAPForm.DataInfoSec[1, 18].Value = (object) heatPump.VesselHeat_Loss;
                MyProject.Forms.SAPForm.DataInfoSec[1, 19].Value = (object) heatPump.VesselHeat_Exchanger;
                MyProject.Forms.SAPForm.DataInfoSec[1, 20].Value = (object) heatPump.Energy_eff_Class;
                MyProject.Forms.SAPForm.DataInfoSec[1, 21].Value = (object) heatPump.WHEffSch2;
                MyProject.Forms.SAPForm.DataInfoSec[1, 22].Value = (object) heatPump.NetElecConsumedSch2;
                MyProject.Forms.SAPForm.DataInfoSec[1, 23].Value = (object) heatPump.WHEffSch3;
                MyProject.Forms.SAPForm.DataInfoSec[1, 24].Value = (object) heatPump.NetElecConsumedSch3;
                MyProject.Forms.SAPForm.DataInfoSec[1, 25].Value = (object) heatPump.Reversible;
                MyProject.Forms.SAPForm.DataInfoSec[1, 26].Value = (object) heatPump.ERR;
                MyProject.Forms.SAPForm.DataInfoSec[1, 27].Value = (object) heatPump.Max_Output;
                MyProject.Forms.SAPForm.DataInfoSec[1, 28].Value = (object) heatPump.Heating_Duration;
                MyProject.Forms.SAPForm.DataInfoSec[1, 29].Value = (object) heatPump.MEV_MVHR;
                MyProject.Forms.SAPForm.DataInfoSec[1, 30].Value = (object) heatPump.Compen_Effect;
                MyProject.Forms.SAPForm.DataInfoSec[1, 31].Value = (object) heatPump.SepCirculator;
                MyProject.Forms.SAPForm.DataInfoSec[1, 32].Value = (object) heatPump.No_AirFlowrates;
                MyProject.Forms.SAPForm.DataInfoSec[1, 33].Value = (object) heatPump.AirFlow1;
                MyProject.Forms.SAPForm.DataInfoSec[1, 34].Value = (object) heatPump.AirFlow2;
                MyProject.Forms.SAPForm.DataInfoSec[1, 35].Value = (object) heatPump.AirFlow3;
                MyProject.Forms.SAPForm.DataInfoSec[1, 36].Value = (object) heatPump.No_PlantSize;
                double num = Conversion.Val(heatPump.Fuel);
                if (num == 1.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "mains gas";
                else if (num == 2.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "bulk LPG";
                else if (num == 4.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
                else if (num == 11.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "house coal";
                else if (num == 12.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "manufactured smokeless fuel";
                else if (num == 13.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "anthracite";
                else if (num == 14.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
                else if (num == 20.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood logs";
                else if (num == 21.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood chips";
                else if (num == 23.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
                else if (num == 39.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "Electricity";
              }
              List<PCDF.HeatPump_Sub> heatPumpSubList;
              if (heatPumpSubList != null)
              {
                List<PCDF.HeatPump_Sub> heatPumpsSub = SAP_Module.PCDFData.HeatPumps_Sub;
                Func<PCDF.HeatPump_Sub, bool> predicate4;
                // ISSUE: reference to a compiler-generated field
                if (SAP_Read._Closure\u0024__.\u0024I18\u002D5 != null)
                {
                  // ISSUE: reference to a compiler-generated field
                  predicate4 = SAP_Read._Closure\u0024__.\u0024I18\u002D5;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  SAP_Read._Closure\u0024__.\u0024I18\u002D5 = predicate4 = (Func<PCDF.HeatPump_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK));
                }
                List<PCDF.HeatPump_Sub> list = heatPumpsSub.Where<PCDF.HeatPump_Sub>(predicate4).ToList<PCDF.HeatPump_Sub>();
                if (MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Count == 0)
                {
                  MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("ID", "ID");
                  MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("PSR", "PSR");
                  MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("Space ", "Space heating efficiency");
                  MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("electricity", "Net specific electricity consumed");
                  MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("Running", "Running Hours");
                  MyProject.Forms.SAPForm.DataSecInfoSub.Columns.Add("Key", "Key");
                }
                else
                  MyProject.Forms.SAPForm.DataSecInfoSub.Rows.Clear();
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns[4].Visible = true;
                MyProject.Forms.SAPForm.DataSecInfoSub.Columns[5].Visible = false;
                int num = checked (list.Count - 1);
                int index = 0;
                while (index <= num)
                {
                  MyProject.Forms.SAPForm.DataSecInfoSub.Rows.Add((object) list[index].ID, (object) list[index].PlantSize_Ratio, (object) list[index].SpaceHeating, (object) list[index].Specific_Elec_Consumed);
                  checked { ++index; }
                }
                MyProject.Forms.SAPForm.grpSecCHP.Visible = true;
                MyProject.Forms.SAPForm.txtSecEfficiency.Text = "";
              }
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump)
              {
                double num = Conversion.Val(heatPump.Fuel);
                if (num == 1.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "mains gas";
                else if (num == 2.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "bulk LPG";
                else if (num == 4.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
                else if (num == 11.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "house coal";
                else if (num == 12.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "manufactured smokeless fuel";
                else if (num == 13.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "anthracite";
                else if (num == 14.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "heating oil";
                else if (num == 20.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood logs";
                else if (num == 21.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood chips";
                else if (num == 23.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "wood pellets (bulk supply in bags, for main heating)";
                else if (num == 39.0)
                  MyProject.Forms.SAPForm.txtSecMainFuel.Text = "Electricity";
                MyProject.Forms.SAPForm.CboDHWVessel.Checked = true;
                MyProject.Forms.SAPForm.txtHeatPumpExchanger.Text = Conversions.ToString(0.01);
                MyProject.Forms.SAPForm.cboPipeWorkInsulated.Enabled = true;
                MyProject.Forms.SAPForm.optCyPipeWork.Enabled = true;
                MyProject.Forms.SAPForm.optCyTimed.Enabled = true;
                MyProject.Forms.SAPForm.chkSecMCS.Enabled = true;
                MyProject.Forms.SAPForm.txtSecPumpHP.Text = "";
                MyProject.Forms.SAPForm.txtSecHeatingEmitter.Text = "";
                MyProject.Forms.SAPForm.txtSecPumpType.Text = "";
                MyProject.Forms.SAPForm.txtSecBILock.Text = "";
                MyProject.Forms.SAPForm.cboSecBoilerFlowTemp.Text = "";
                MyProject.Forms.SAPForm.txtSecPumpHP.Enabled = false;
                MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = false;
                MyProject.Forms.SAPForm.txtSecPumpType.Enabled = false;
                MyProject.Forms.SAPForm.txtSecBILock.Enabled = false;
                MyProject.Forms.SAPForm.cboSecBoilerFlowTemp.Enabled = false;
                MyProject.Forms.SAPForm.txtSecHeatingEmitter.Enabled = false;
                MyProject.Forms.SAPForm.grpSecCHP.Visible = false;
              }
            }
            MyProject.Forms.SAPForm.txtSecPumpHP.Enabled = true;
            MyProject.Forms.SAPForm.txtSecBILock.Enabled = true;
            MyProject.Forms.SAPForm.txtSecBFlueType.Enabled = false;
            MyProject.Forms.SAPForm.txtSecFanFlued.Enabled = false;
            MyProject.Forms.SAPForm.GrpSecBoiler.Visible = true;
            MyProject.Forms.SAPForm.grpSecBoilerInfo.Visible = true;
            if (!flag)
              MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = false;
            else
              MyProject.Forms.SAPForm.txtSecMainFuel.Enabled = true;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message);
        ProjectData.ClearProjectError();
      }
      SAP_Module.ChangeNow = false;
    }

    public static void ReadThermal()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.chkHtb.Checked = false;
      MyProject.Forms.SAPForm.chky.Checked = false;
      MyProject.Forms.SAPForm.txtConstDetails.Text = "";
      MyProject.Forms.SAPForm.txtHtb.ReadOnly = true;
      MyProject.Forms.SAPForm.txtHtb.Text = Conversions.ToString(0);
      MyProject.Forms.SAPForm.txty.ReadOnly = true;
      MyProject.Forms.SAPForm.txty.Text = Conversions.ToString(0);
      MyProject.Forms.SAPForm.chkHtb.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb;
      MyProject.Forms.SAPForm.chky.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualY;
      MyProject.Forms.SAPForm.txtConstDetails.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ConstDetails;
      MyProject.Forms.SAPForm.txtHtb.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue);
      MyProject.Forms.SAPForm.txty.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue);
      MyProject.Forms.SAPForm.txtThermalReference.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.Reference;
      MyProject.Forms.SAPForm.txty.Enabled = false;
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadSecHeating()
    {
      SAP_Module.NoCalc = true;
      MyProject.Forms.SAPForm.txtSPrimary.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup;
      SecHeating.SPrimaryHeatingGroupCheck();
      MyProject.Forms.SAPForm.txtSSubGroup.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SGroup;
      SecHeating.SCheckSource();
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtSHeatingSource.Text, "SAP Tables", false) == 0)
        MyProject.Forms.SAPForm.grpManuDescription.Enabled = false;
      else
        MyProject.Forms.SAPForm.grpManuDescription.Enabled = true;
      MyProject.Forms.SAPForm.txtSHeatingSource.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.InforSource;
      MyProject.Forms.SAPForm.txtSMainHeatingType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType;
      SecHeating.SCheckFuelTypeForSAPTable(MyProject.Forms.SAPForm.txtSMainHeatingType.Text);
      MyProject.Forms.SAPForm.txtSMainFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.Fuel;
      MyProject.Forms.SAPForm.txtHETAS.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HETAS;
      MyProject.Forms.SAPForm.txtSEfficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SecEff);
      MyProject.Forms.SAPForm.txtSDescription.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MDescription;
      MyProject.Forms.SAPForm.txtSTested.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.TestMethod;
      MyProject.Forms.SAPForm.txtSFlueType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.FlueType;
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadSolar()
    {
      MyProject.Forms.SAPForm.txtWWHRSStore1.Enabled = false;
      MyProject.Forms.SAPForm.txtWWHRSStore2.Enabled = false;
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.chkSolar.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Inlcude;
      MyProject.Forms.SAPForm.txtSolarType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarType;
      MyProject.Forms.SAPForm.chkSolarOveride.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Overide;
      MyProject.Forms.SAPForm.txtSolarZero.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarZero);
      MyProject.Forms.SAPForm.txtSolarHLoss.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarHLoss);
      MyProject.Forms.SAPForm.txtSolarHLoss2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarHLoss2);
      MyProject.Forms.SAPForm.txtSolarArea.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarArea);
      MyProject.Forms.SAPForm.chkSolarGross.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Gross;
      MyProject.Forms.SAPForm.txtSolarTilt.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarTilt;
      MyProject.Forms.SAPForm.txtSolarOrientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation;
      MyProject.Forms.SAPForm.txtSolarOvershading.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading;
      MyProject.Forms.SAPForm.txtSolarVolume.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarVolume);
      MyProject.Forms.SAPForm.chkSolarSeperate.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarSeperate;
      MyProject.Forms.SAPForm.chkSolarPump.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Pumped;
      MyProject.Forms.SAPForm.cboSolarShower.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.ShowerType;
      if (MyProject.Forms.SAPForm.DGVWWHRS1.Columns.Count == 0)
      {
        MyProject.Forms.SAPForm.DGVWWHRS1.Columns.Add("Item", "Item");
        MyProject.Forms.SAPForm.DGVWWHRS1.Columns.Add("Description", "Description");
      }
      MyProject.Forms.SAPForm.DGVWWHRS1.Rows.Clear();
      if (MyProject.Forms.SAPForm.DGVWWHRS2.Columns.Count == 0)
      {
        MyProject.Forms.SAPForm.DGVWWHRS2.Columns.Add("Item", "Item");
        MyProject.Forms.SAPForm.DGVWWHRS2.Columns.Add("Description", "Description");
      }
      MyProject.Forms.SAPForm.DGVWWHRS2.Rows.Clear();
      MyProject.Forms.SAPForm.optWWHRS.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include;
      MyProject.Forms.SAPForm.txtWWHRSStore1.Text = Conversions.ToString(0);
      MyProject.Forms.SAPForm.txtWWHRSStore2.Text = Conversions.ToString(0);
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
      {
        MyProject.Forms.SAPForm.txtWWHRSTotalRooms.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.TotalRooms);
        MyProject.Forms.SAPForm.txtWWHRS1WithBath.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].WithBath);
        MyProject.Forms.SAPForm.txtWWHRS2WithBath.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].WithBath);
        MyProject.Forms.SAPForm.txtWWHRS1WithNoBath.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].WithNoBath);
        MyProject.Forms.SAPForm.txtWWHRS2WithNoBath.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].WithNoBath);
        MyProject.Forms.SAPForm.txtWWHRSStore1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].DedicatedStorage);
        MyProject.Forms.SAPForm.txtWWHRSStore2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].DedicatedStorage);
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef, "", false) > 0U)
        {
          MyProject.Forms.SAPForm.DGVWWHRS1.Rows.Add(11);
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 0].Value = (object) "ID";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 1].Value = (object) "RefNo";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 2].Value = (object) "Date";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 3].Value = (object) "Manufacturer";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 4].Value = (object) "Brand";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 5].Value = (object) "Model";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 6].Value = (object) "Model Qualifier";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 7].Value = (object) "FirstManu";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 8].Value = (object) "FinManu";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 9].Value = (object) "Efficiency";
          MyProject.Forms.SAPForm.DGVWWHRS1[0, 10].Value = (object) "Utilisation Factor";
          List<PCDF.WWHRS> wwhrSs = SAP_Module.PCDFData.WWHRSs;
          Func<PCDF.WWHRS, bool> predicate;
          // ISSUE: reference to a compiler-generated field
          if (SAP_Read._Closure\u0024__.\u0024I21\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate = SAP_Read._Closure\u0024__.\u0024I21\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Read._Closure\u0024__.\u0024I21\u002D0 = predicate = (Func<PCDF.WWHRS, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].SystemsRef));
          }
          PCDF.WWHRS wwhrs = wwhrSs.Where<PCDF.WWHRS>(predicate).SingleOrDefault<PCDF.WWHRS>();
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 0].Value = (object) wwhrs.ID;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 1].Value = (object) wwhrs.RefNo;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 2].Value = (object) wwhrs._Date;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 3].Value = (object) wwhrs.Manufacturer;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 4].Value = (object) wwhrs.Brand;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 5].Value = (object) wwhrs.Model;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 6].Value = (object) wwhrs.Model_Qualifier;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 7].Value = (object) wwhrs.FirstManu;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 8].Value = (object) wwhrs.FinManu;
          MyProject.Forms.SAPForm.DGVWWHRS1[1, 9].Value = (object) wwhrs.Efficiency;
          if (wwhrs.InstantaneousStorage.Equals("2"))
          {
            MyProject.Forms.SAPForm.txtWWHRSStore1.Enabled = true;
            MyProject.Forms.SAPForm.txtWWHRSStore1.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].DedicatedStorage);
          }
          else
            MyProject.Forms.SAPForm.txtWWHRSStore1.Text = Conversions.ToString(0);
        }
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].SystemsRef, "", false) > 0U)
        {
          MyProject.Forms.SAPForm.DGVWWHRS2.Rows.Add(11);
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 0].Value = (object) "ID";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 1].Value = (object) "RefNo";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 2].Value = (object) "Date";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 3].Value = (object) "Manufacturer";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 4].Value = (object) "Brand";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 5].Value = (object) "Model";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 6].Value = (object) "Model Qualifier";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 7].Value = (object) "FirstManu";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 8].Value = (object) "FinManu";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 9].Value = (object) "Efficiency";
          MyProject.Forms.SAPForm.DGVWWHRS2[0, 10].Value = (object) "Utilisation Factor";
          List<PCDF.WWHRS> wwhrSs = SAP_Module.PCDFData.WWHRSs;
          Func<PCDF.WWHRS, bool> predicate;
          // ISSUE: reference to a compiler-generated field
          if (SAP_Read._Closure\u0024__.\u0024I21\u002D1 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate = SAP_Read._Closure\u0024__.\u0024I21\u002D1;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Read._Closure\u0024__.\u0024I21\u002D1 = predicate = (Func<PCDF.WWHRS, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].SystemsRef));
          }
          PCDF.WWHRS wwhrs = wwhrSs.Where<PCDF.WWHRS>(predicate).SingleOrDefault<PCDF.WWHRS>();
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 0].Value = (object) wwhrs.ID;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 1].Value = (object) wwhrs.RefNo;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 2].Value = (object) wwhrs._Date;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 3].Value = (object) wwhrs.Manufacturer;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 4].Value = (object) wwhrs.Brand;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 5].Value = (object) wwhrs.Model;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 6].Value = (object) wwhrs.Model_Qualifier;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 7].Value = (object) wwhrs.FirstManu;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 8].Value = (object) wwhrs.FinManu;
          MyProject.Forms.SAPForm.DGVWWHRS2[1, 9].Value = (object) wwhrs.Efficiency;
          if (wwhrs.InstantaneousStorage.Equals("2"))
          {
            MyProject.Forms.SAPForm.txtWWHRSStore2.Enabled = true;
            MyProject.Forms.SAPForm.txtWWHRSStore2.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].DedicatedStorage);
          }
          else
            MyProject.Forms.SAPForm.txtWWHRSStore2.Text = Conversions.ToString(0);
        }
      }
      SAP_Read.ReadFGHRS();
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadFGHRS()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.ChkFGHRS.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include;
      if (MyProject.Forms.SAPForm.DGFGHRS1.Columns.Count == 0)
      {
        MyProject.Forms.SAPForm.DGFGHRS1.Columns.Add("Item", "Item");
        MyProject.Forms.SAPForm.DGFGHRS1.Columns.Add("Description", "Description");
      }
      MyProject.Forms.SAPForm.DGFGHRS1.Rows.Clear();
      MyProject.Forms.SAPForm.DGFGHRS2.DataSource = (object) null;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include)
      {
        if ((uint) Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo, "", false) > 0U)
        {
          MyProject.Forms.SAPForm.DGFGHRS1.Rows.Add(23);
          MyProject.Forms.SAPForm.DGFGHRS1[0, 0].Value = (object) "ID";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 1].Value = (object) "RefNo";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 2].Value = (object) "Date";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 3].Value = (object) "Manufacturer";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 4].Value = (object) "Brand";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 5].Value = (object) "Model";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 6].Value = (object) "Model Qualifier";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 7].Value = (object) "First Manu";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 8].Value = (object) "Final Manu";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 9].Value = (object) "Applicable Fuel";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 10].Value = (object) "Test Fuel";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 11].Value = (object) "Applicable Boiler Types";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 12].Value = (object) "Integral Only";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 13].Value = (object) "Heat Store";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 14].Value = (object) "Heat Store TV";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 15].Value = (object) "Heat Store RV";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 16].Value = (object) "Heat StoreLR";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 17].Value = (object) "Direct THR";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 18].Value = (object) "Direct UHR";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 19].Value = (object) "Power Con";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 20].Value = (object) "Photovoltaic Module";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 21].Value = (object) "Cable Loss";
          MyProject.Forms.SAPForm.DGFGHRS1[0, 22].Value = (object) "No of Equations";
          List<PCDF.FGHRS> fghrSs = SAP_Module.PCDFData.FGHRSs;
          Func<PCDF.FGHRS, bool> predicate1;
          // ISSUE: reference to a compiler-generated field
          if (SAP_Read._Closure\u0024__.\u0024I22\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate1 = SAP_Read._Closure\u0024__.\u0024I22\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            SAP_Read._Closure\u0024__.\u0024I22\u002D0 = predicate1 = (Func<PCDF.FGHRS, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo));
          }
          PCDF.FGHRS fghrs = fghrSs.Where<PCDF.FGHRS>(predicate1).SingleOrDefault<PCDF.FGHRS>();
          try
          {
            MyProject.Forms.SAPForm.DGFGHRS1[1, 0].Value = (object) fghrs.ID;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 1].Value = (object) fghrs.RefNo;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 2].Value = (object) fghrs._Date;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 3].Value = (object) fghrs.Manufacturer;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 4].Value = (object) fghrs.Brand;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 5].Value = (object) fghrs.Model;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 6].Value = (object) fghrs.Model_Qualifier;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 7].Value = (object) fghrs.FirstManu;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 8].Value = (object) fghrs.FinManu;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 9].Value = (object) fghrs.ApplicableFuel;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 10].Value = (object) fghrs.TestFuel;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 11].Value = (object) fghrs.ApplicableBoilerTypes;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 12].Value = (object) fghrs.IntegralOnly;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 13].Value = (object) fghrs.HeatStore;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 14].Value = (object) fghrs.HeatStoreTV;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 15].Value = (object) fghrs.HeatStoreRV;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 16].Value = (object) fghrs.HeatStoreLR;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 17].Value = (object) fghrs.DirectTHR;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 18].Value = (object) fghrs.DirectUHR;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 19].Value = (object) fghrs.PowerCon;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 20].Value = (object) fghrs.PhotovoltaicModule;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 21].Value = (object) fghrs.CableLoss;
            MyProject.Forms.SAPForm.DGFGHRS1[1, 22].Value = (object) fghrs.NoofEquations;
            if (Conversion.Val(fghrs.PhotovoltaicModule) == 1.0)
            {
              MyProject.Forms.SAPForm.grpFGHRS_PV.Enabled = true;
              MyProject.Forms.SAPForm.txtFGHRS_PV_PP.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PPower);
              MyProject.Forms.SAPForm.txtFGHRS_PV_Orientation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PCOrientation;
              MyProject.Forms.SAPForm.txtFGHRS_PV_OverShading.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.POvershading;
              MyProject.Forms.SAPForm.txtFGHRS_PV_Tilt.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PTilt;
            }
            else
            {
              MyProject.Forms.SAPForm.grpFGHRS_PV.Enabled = false;
              MyProject.Forms.SAPForm.txtFGHRS_PV_PP.Text = "";
              MyProject.Forms.SAPForm.txtFGHRS_PV_Orientation.Text = "";
              MyProject.Forms.SAPForm.txtFGHRS_PV_OverShading.Text = "";
              MyProject.Forms.SAPForm.txtFGHRS_PV_Tilt.Text = "";
            }
            List<PCDF.FGHRS_Sub> fghrSsSub = SAP_Module.PCDFData.FGHRSs_Sub;
            Func<PCDF.FGHRS_Sub, bool> predicate2;
            // ISSUE: reference to a compiler-generated field
            if (SAP_Read._Closure\u0024__.\u0024I22\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate2 = SAP_Read._Closure\u0024__.\u0024I22\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              SAP_Read._Closure\u0024__.\u0024I22\u002D1 = predicate2 = (Func<PCDF.FGHRS_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.IndexNo));
            }
            MyProject.Forms.SAPForm.DGFGHRS2.DataSource = (object) fghrSsSub.Where<PCDF.FGHRS_Sub>(predicate2).ToList<PCDF.FGHRS_Sub>();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      else
      {
        MyProject.Forms.SAPForm.grpFGHRS_PV.Enabled = false;
        MyProject.Forms.SAPForm.txtFGHRS_PV_PP.Text = "";
        MyProject.Forms.SAPForm.txtFGHRS_PV_Orientation.Text = "";
        MyProject.Forms.SAPForm.txtFGHRS_PV_OverShading.Text = "";
        MyProject.Forms.SAPForm.txtFGHRS_PV_Tilt.Text = "";
      }
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadWater()
    {
      SAP_Module.NoCalc = true;
      MyProject.Forms.SAPForm.txtWater.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System;
      MyProject.Forms.SAPForm.txtWaterFuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel;
      WaterHeating.CheckCylinder();
      MyProject.Forms.SAPForm.txtCyVolume.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume);
      MyProject.Forms.SAPForm.optCyManuLoss.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified;
      MyProject.Forms.SAPForm.txtCyDLoss.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss);
      MyProject.Forms.SAPForm.txtCyInsulation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation;
      MyProject.Forms.SAPForm.txtCyInsThick.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick);
      MyProject.Forms.SAPForm.optCyHSpace.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InHeatedSpace;
      MyProject.Forms.SAPForm.optCyThermostat.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Thermostat;
      MyProject.Forms.SAPForm.optCyPipeWork.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated;
      MyProject.Forms.SAPForm.cboPipeWorkInsulated.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulationType;
      MyProject.Forms.SAPForm.optCyTimed.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Timed;
      MyProject.Forms.SAPForm.optCySummer.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.SummerImmersion;
      MyProject.Forms.SAPForm.txtImmersion.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Immersion;
      MyProject.Forms.SAPForm.txtWCombiType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType;
      switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef)
      {
        case 907:
        case 908:
        case 909:
          MyProject.Forms.SAPForm.grpCylinder.Enabled = false;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CylinderInDwelling = false;
          break;
      }
      MyProject.Forms.SAPForm.txtCPSUTemp.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CPSUTemp);
      if (MyProject.Forms.SAPForm.optCyManuLoss.Enabled)
      {
        if (MyProject.Forms.SAPForm.optCyManuLoss.Checked)
        {
          MyProject.Forms.SAPForm.txtCyDLoss.Enabled = true;
          MyProject.Forms.SAPForm.txtCyInsulation.Enabled = false;
        }
        else
        {
          MyProject.Forms.SAPForm.txtCyDLoss.Enabled = false;
          MyProject.Forms.SAPForm.txtCyInsulation.Enabled = true;
        }
      }
      MyProject.Forms.SAPForm.chkDHWCommCylinder.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CylinderInDwelling;
      MyProject.Forms.SAPForm.grdCommunityWater.Visible = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase;
      MyProject.Forms.SAPForm.grdCommunityWaterSources.Visible = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CylinderInDwelling)
        MyProject.Forms.SAPForm.grpCylinder.Enabled = true;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].WaterOnlyHeatPump && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HPOnly.HotWaterHP_Integral)
        MyProject.Forms.SAPForm.grpCylinder.Enabled = false;
      if ((double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CHPRatio > 0.0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CHPPowerEff = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CHPRatio;
      switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef)
      {
        case 950:
          MyProject.Forms.SAPForm.txtDHWCommCHP.Enabled = false;
          break;
        case 951:
          MyProject.Forms.SAPForm.txtDHWCommCHP.Enabled = true;
          break;
        case 952:
          MyProject.Forms.SAPForm.txtDHWCommCHP.Enabled = false;
          break;
      }
      MyProject.Forms.SAPForm.txtDHWCommCHP.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CHPPowerEff);
      MyProject.Forms.SAPForm.txtDHWCommHDS.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS;
      MyProject.Forms.SAPForm.txtDHWCommEff.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Efficiency);
      MyProject.Forms.SAPForm.txtDHWCommFraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Boiler1Fraction);
      MyProject.Forms.SAPForm.txtDHWCommHNoOfAdditional.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources);
      List<PCDF.Table4aWater> table4aWaters1 = SAP_Module.PCDFData.Table4aWaters;
      Func<PCDF.Table4aWater, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Read._Closure\u0024__.\u0024I23\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = SAP_Read._Closure\u0024__.\u0024I23\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Read._Closure\u0024__.\u0024I23\u002D0 = predicate1 = (Func<PCDF.Table4aWater, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type));
      }
      PCDF.Table4aWater table4aWater1 = table4aWaters1.Where<PCDF.Table4aWater>(predicate1).SingleOrDefault<PCDF.Table4aWater>();
      if (table4aWater1 != null)
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Type.Text = table4aWater1.Description;
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Efficiency);
      }
      else
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Efficiency);
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type)
        {
          case 950:
            MyProject.Forms.SAPForm.txtDHWCommHAdd1Type.Text = "From hot-water only community scheme - boilers";
            break;
          case 951:
            MyProject.Forms.SAPForm.txtDHWCommHAdd1Type.Text = "From hot-water only community scheme - CHP";
            break;
          case 952:
            MyProject.Forms.SAPForm.txtDHWCommHAdd1Type.Text = "From hot-water only community scheme - heat pump";
            break;
        }
      }
      List<PCDF.Table4aWater> table4aWaters2 = SAP_Module.PCDFData.Table4aWaters;
      Func<PCDF.Table4aWater, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Read._Closure\u0024__.\u0024I23\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = SAP_Read._Closure\u0024__.\u0024I23\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Read._Closure\u0024__.\u0024I23\u002D1 = predicate2 = (Func<PCDF.Table4aWater, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type));
      }
      PCDF.Table4aWater table4aWater2 = table4aWaters2.Where<PCDF.Table4aWater>(predicate2).SingleOrDefault<PCDF.Table4aWater>();
      if (table4aWater2 != null)
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Type.Text = table4aWater2.Description;
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Efficiency);
      }
      else
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd2Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Efficiency);
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type)
        {
          case 950:
            MyProject.Forms.SAPForm.txtDHWCommHAdd2Type.Text = "From hot-water only community scheme - boilers";
            break;
          case 951:
            MyProject.Forms.SAPForm.txtDHWCommHAdd2Type.Text = "From hot-water only community scheme - CHP";
            break;
          case 952:
            MyProject.Forms.SAPForm.txtDHWCommHAdd2Type.Text = "From hot-water only community scheme - heat pump";
            break;
        }
      }
      List<PCDF.Table4aWater> table4aWaters3 = SAP_Module.PCDFData.Table4aWaters;
      Func<PCDF.Table4aWater, bool> predicate3;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Read._Closure\u0024__.\u0024I23\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate3 = SAP_Read._Closure\u0024__.\u0024I23\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Read._Closure\u0024__.\u0024I23\u002D2 = predicate3 = (Func<PCDF.Table4aWater, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type));
      }
      PCDF.Table4aWater table4aWater3 = table4aWaters3.Where<PCDF.Table4aWater>(predicate3).SingleOrDefault<PCDF.Table4aWater>();
      if (table4aWater3 != null)
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Type.Text = table4aWater3.Description;
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Efficiency);
      }
      else
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd3Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Efficiency);
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type)
        {
          case 950:
            MyProject.Forms.SAPForm.txtDHWCommHAdd3Type.Text = "From hot-water only community scheme - boilers";
            break;
          case 951:
            MyProject.Forms.SAPForm.txtDHWCommHAdd3Type.Text = "From hot-water only community scheme - CHP";
            break;
          case 952:
            MyProject.Forms.SAPForm.txtDHWCommHAdd3Type.Text = "From hot-water only community scheme - heat pump";
            break;
        }
      }
      List<PCDF.Table4aWater> table4aWaters4 = SAP_Module.PCDFData.Table4aWaters;
      Func<PCDF.Table4aWater, bool> predicate4;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Read._Closure\u0024__.\u0024I23\u002D3 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate4 = SAP_Read._Closure\u0024__.\u0024I23\u002D3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Read._Closure\u0024__.\u0024I23\u002D3 = predicate4 = (Func<PCDF.Table4aWater, bool>) (b => b.Code.Equals((object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type));
      }
      PCDF.Table4aWater table4aWater4 = table4aWaters4.Where<PCDF.Table4aWater>(predicate4).SingleOrDefault<PCDF.Table4aWater>();
      if (table4aWater4 != null)
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Type.Text = table4aWater4.Description;
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Efficiency);
      }
      else
      {
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel;
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.HeatFraction);
        MyProject.Forms.SAPForm.txtDHWCommHAdd4Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Efficiency);
        switch (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type)
        {
          case 950:
            MyProject.Forms.SAPForm.txtDHWCommHAdd4Type.Text = "From hot-water only community scheme - boilers";
            break;
          case 951:
            MyProject.Forms.SAPForm.txtDHWCommHAdd4Type.Text = "From hot-water only community scheme - CHP";
            break;
          case 952:
            MyProject.Forms.SAPForm.txtDHWCommHAdd4Type.Text = "From hot-water only community scheme - heat pump";
            break;
        }
      }
      MyProject.Forms.SAPForm.txtKnownLoss.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.LossFactor);
      MyProject.Forms.SAPForm.chkKnownLoss.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.KnownLossFactor;
      MyProject.Forms.SAPForm.txtDHWCommCharging.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Charging;
      SAP_Read.CheckCommunityWaterSEDBUK();
      MyProject.Forms.SAPForm.chkThermal.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include;
      MyProject.Forms.SAPForm.txtThermalType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Type;
      MyProject.Forms.SAPForm.txtThermalLocation.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Location;
      MyProject.Forms.SAPForm.txtThermalConnection.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Connection;
      MyProject.Forms.SAPForm.txtHeatPumpImmersion.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion;
      MyProject.Forms.SAPForm.CboDHWVessel.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.DHWVessel;
      MyProject.Forms.SAPForm.txtHeatPumpExchanger.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPExchanger);
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadCoolingSystem()
    {
      SAP_Module.NoCalc = true;
      MyProject.Forms.SAPForm.txtCoolingSystemType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.SystemType;
      MyProject.Forms.SAPForm.txtEnergyLabelClass.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Energylabel;
      MyProject.Forms.SAPForm.CompressControl.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Compressorcontrol;
      MyProject.Forms.SAPForm.txtCooledArea.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Cooled_Area;
      MyProject.Forms.SAPForm.ChkCoolingSystem.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Include;
      MyProject.Forms.SAPForm.ChkEER.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.ERRMeasuredInclude;
      MyProject.Forms.SAPForm.txtEER.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.ERR);
      MyProject.Forms.SAPForm.txterrDesc.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Description;
    }

    public static void ReadRenewables()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.chkPInclude.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude;
      MyProject.Forms.SAPForm.txtPPower.Text = "";
      MyProject.Forms.SAPForm.txtPTilt.Text = "";
      MyProject.Forms.SAPForm.txtPCOrientation.Text = "";
      MyProject.Forms.SAPForm.txtPOvershading.Text = "";
      MyProject.Forms.SAPForm.chkPVDirect.Checked = false;
      MyProject.Forms.SAPForm.cboPVConnection.Text = "";
      MyProject.Forms.SAPForm.DGVPhotoVoltaics.Rows.Clear();
      MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Clear();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics != null)
      {
        if (MyProject.Forms.SAPForm.DGVPhotoVoltaics.ColumnCount == 0)
        {
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("ID", "ID");
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("PPower", "Power");
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("PTilt", "Tilt");
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("PCOrientation", "Orientation");
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("POvershading", "Overshading");
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("PDirectly", "Directly Connected");
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns.Add("PFlatConnection", "Flat Connection");
        }
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics.Length - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.DGVPhotoVoltaics.Rows.Add();
          BetterDataGrid dgvPhotoVoltaics = MyProject.Forms.SAPForm.DGVPhotoVoltaics;
          dgvPhotoVoltaics[0, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].ID;
          dgvPhotoVoltaics[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].PPower;
          dgvPhotoVoltaics[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].PTilt;
          dgvPhotoVoltaics[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].PCOrientation;
          dgvPhotoVoltaics[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].POvershading;
          dgvPhotoVoltaics[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].DirectlyConnected;
          dgvPhotoVoltaics[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Photovoltaics[rowIndex].FlatConnection;
          checked { ++rowIndex; }
        }
        MyProject.Forms.SAPForm.DGVPhotoVoltaics.Columns[0].Visible = false;
      }
      MyProject.Forms.SAPForm.chkWInclude.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.Inlcude;
      MyProject.Forms.SAPForm.txtWNumber.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WNumber);
      MyProject.Forms.SAPForm.txtWRDiameter.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WRDiameter;
      MyProject.Forms.SAPForm.txtWHeight.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WHeight;
      MyProject.Forms.SAPForm.chkSpecial.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Include;
      MyProject.Forms.SAPForm.DGSpecialFeatures.Rows.Clear();
      MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Clear();
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special != null)
      {
        if (MyProject.Forms.SAPForm.DGSpecialFeatures.ColumnCount == 0)
        {
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("ID", "ID");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Description", "Description");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Energy Used", "Energy Used");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Energy Saved", "Energy Saved");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Fuel Used", "Fuel Used");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Fuel Saved", "Fuel Saved");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Emissions Only", "Emissions Only");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Emmisions Saved", "Emmisions Saved");
          MyProject.Forms.SAPForm.DGSpecialFeatures.Columns.Add("Emmisions Used", "Emmisions Used");
        }
        int num = checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special.Length - 1);
        int rowIndex = 0;
        while (rowIndex <= num)
        {
          MyProject.Forms.SAPForm.DGSpecialFeatures.Rows.Add();
          BetterDataGrid dgSpecialFeatures = MyProject.Forms.SAPForm.DGSpecialFeatures;
          dgSpecialFeatures[0, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].ID;
          dgSpecialFeatures[1, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].Description;
          dgSpecialFeatures[2, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].EnergyUsed;
          dgSpecialFeatures[3, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].EnergySaved;
          dgSpecialFeatures[4, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].FuelUsed;
          dgSpecialFeatures[5, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].FuelSaved;
          dgSpecialFeatures[6, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].MakeEmissionsOnly;
          dgSpecialFeatures[7, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].EmissionsAmount;
          dgSpecialFeatures[8, rowIndex].Value = (object) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Special[rowIndex].EmissionsAmountCreated;
          checked { ++rowIndex; }
        }
        MyProject.Forms.SAPForm.DGSpecialFeatures.Columns[0].Visible = false;
      }
      MyProject.Forms.SAPForm.chkHydroInclude.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.Inlcude;
      MyProject.Forms.SAPForm.txtHydroGenerated.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.HydroGenerated);
      MyProject.Forms.SAPForm.txtHydroArea.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.TotalArea;
      MyProject.Forms.SAPForm.chkAAEGInclude.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.Inlcude;
      MyProject.Forms.SAPForm.txtAAEGGenerated.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.EGenerated);
      MyProject.Forms.SAPForm.txtAAEGArea.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.TotalArea;
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }

    public static void ReadOverHeating()
    {
      SAP_Module.NoCalc = true;
      SAP_Module.ChangeNow = true;
      MyProject.Forms.SAPForm.txtOverAirType.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType;
      MyProject.Forms.SAPForm.txtOverAirWindow.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow;
      MyProject.Forms.SAPForm.chkOverOveride.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACOveride;
      MyProject.Forms.SAPForm.txtOverAirach.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange);
      MyProject.Forms.SAPForm.chkNightVentilation.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.Night;
      int num = checked (MyProject.Forms.SAPForm.dataGridConstruction.Rows.Count - 1);
      int index = 0;
      while (index <= num)
      {
        MyProject.Forms.SAPForm.dataGridConstruction.Rows[index].Selected = false;
        checked { ++index; }
      }
      if ((uint) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMIllustrative > 0U)
        MyProject.Forms.SAPForm.dataGridConstruction.Rows[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMIllustrative - 1)].Selected = true;
      MyProject.Forms.SAPForm.chkOverThermalOveride.Checked = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMOveride;
      MyProject.Forms.SAPForm.txtOverThermalTMP.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMTMP);
      MyProject.Forms.SAPForm.txtFixedAirCon.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].AirCon;
      MyProject.Forms.SAPForm.txtConservatory.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Conservatory;
      MyProject.Forms.SAPForm.txtLELLights.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELLights);
      MyProject.Forms.SAPForm.txtLELOutlets.Value = new Decimal(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELOutlets);
      MyProject.Forms.SAPForm.txtLowEnergyLight.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LowEnergyLight);
      SAP_Module.ChangeNow = false;
      SAP_Module.NoCalc = false;
    }
  }
}
