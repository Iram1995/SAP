
// Type: SAP2012.SAP_Write




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SAP2012
{
  [StandardModule]
  internal sealed class SAP_Write
  {
    public static void WriteProjectDetails(bool MakeTree)
    {
      try
      {
        SAP_Module.Proj.Name = MyProject.Forms.SAPForm.txtProjName.Text;
        if (MakeTree)
          MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Text = SAP_Module.Proj.Name;
        SAP_Module.Proj.Reference = MyProject.Forms.SAPForm.txtPRef.Text;
        SAP_Module.Proj.Address.Line1 = MyProject.Forms.SAPForm.txtPAdd1.Text;
        SAP_Module.Proj.Address.Line2 = MyProject.Forms.SAPForm.txtPAdd2.Text;
        SAP_Module.Proj.Address.Line3 = MyProject.Forms.SAPForm.txtPAdd2.Text;
        SAP_Module.Proj.Address.City = MyProject.Forms.SAPForm.txtPCity.Text;
        SAP_Module.Proj.Address.Country = MyProject.Forms.SAPForm.txtPCountry.Text;
        SAP_Module.Proj.Address.PostCost = MyProject.Forms.SAPForm.txtPPCode.Text;
        SAP_Module.Proj.Client.Name = MyProject.Forms.SAPForm.txtPCNAme.Text;
        SAP_Module.Proj.Client.Address.Line1 = MyProject.Forms.SAPForm.txtPCAdd1.Text;
        SAP_Module.Proj.Client.Address.Line2 = MyProject.Forms.SAPForm.txtPCAdd2.Text;
        SAP_Module.Proj.Client.Address.Line3 = MyProject.Forms.SAPForm.txtPCAdd3.Text;
        SAP_Module.Proj.Client.Address.City = MyProject.Forms.SAPForm.txtPCCity.Text;
        SAP_Module.Proj.Client.Address.Country = MyProject.Forms.SAPForm.txtPCCountry.Text;
        SAP_Module.Proj.Client.Address.PostCost = MyProject.Forms.SAPForm.txtPCPCode.Text;
        SAP_Module.Proj.Client.Phone = MyProject.Forms.SAPForm.txtPCPhone.Text;
        SAP_Module.Proj.Client.Fax = MyProject.Forms.SAPForm.txtPCFax.Text;
        SAP_Module.Proj.Client.Email = MyProject.Forms.SAPForm.txtPCEmail.Text;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void WriteDwellingDetails(bool MakeTree)
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name = MyProject.Forms.SAPForm.txtDName.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Reference = MyProject.Forms.SAPForm.txtDRef.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SAPOnly = MyProject.Forms.SAPForm.txtSAPOnly.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overheat = MyProject.Forms.SAPForm.txtOverHeat.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status = MyProject.Forms.SAPForm.txtStatus.Text;
      if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Status, "Existing dwelling (SAP)", false) == 0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = "Calculated";
      else if (Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure, "Calculated", false) == 0)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = "";
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DateAssessment = Conversions.ToDate(MyProject.Forms.SAPForm.txtDDate.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DateCertificate = Conversions.ToDate(MyProject.Forms.SAPForm.txtCDate.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RPD = MyProject.Forms.SAPForm.txtRPD.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Transaction = MyProject.Forms.SAPForm.txtTransaction.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Tenure = MyProject.Forms.SAPForm.txtTenure.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line1 = MyProject.Forms.SAPForm.txtDAdd1.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line2 = MyProject.Forms.SAPForm.txtDAdd2.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Line3 = MyProject.Forms.SAPForm.txtDAdd3.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.City = MyProject.Forms.SAPForm.txtDCity.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country = MyProject.Forms.SAPForm.txtDCountry.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.PostCost = MyProject.Forms.SAPForm.txtDPostCode.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].UPRN = MyProject.Forms.SAPForm.txtUPRN.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].EPCLanguage = MyProject.Forms.SAPForm.txtEPCLanguage.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PropertyType = MyProject.Forms.SAPForm.txtPropertyType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].BuildForm = MyProject.Forms.SAPForm.txtBuiltForm.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].FlatType = MyProject.Forms.SAPForm.txtFlatType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].YearBuilt = Conversions.ToInteger(MyProject.Forms.SAPForm.txtYearBuilt.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsAbove = Conversions.ToInteger(MyProject.Forms.SAPForm.CboDwellingAbove.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOFDwellingsBelow = Conversions.ToInteger(MyProject.Forms.SAPForm.CboDwellingBelow.Text);
      try
      {
        if (Operators.CompareString(MyProject.Forms.SAPForm.lblImported.Text, "True", false) == 0)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Imported09 = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].DisplayScotFrontpageOnly = Operators.CompareString(MyProject.Forms.SAPForm.txtScotFrontPageOnly.Text, "Yes", false) == 0;
      MyProject.Forms.SAPForm.ScotGraphs.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoOfScotGraphs != 1 ? Conversions.ToString(2) : Conversions.ToString(1);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Location = MyProject.Forms.SAPForm.txtLocation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ShelteredSides = Convert.ToInt32(MyProject.Forms.SAPForm.txtShelteredSides.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Terrain = MyProject.Forms.SAPForm.txtTerrain.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Orientation = MyProject.Forms.SAPForm.txtOrientation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SmokeArea = MyProject.Forms.SAPForm.txtSmokeArea.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Overshading = MyProject.Forms.SAPForm.txtShading.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.Type = MyProject.Forms.SAPForm.txtTMP.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.Indicative = MyProject.Forms.SAPForm.txtTMPIndicative.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TMP.UserDefined = (float) Conversion.Val(MyProject.Forms.SAPForm.txtTMPUser.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LessThan125Litre = MyProject.Forms.SAPForm.chkMax125Litre.Checked;
      if (!MakeTree)
        return;
      MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling].Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Name;
    }

    public static void WriteDimensions(bool SaveFraction)
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_27;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys = checked (MyProject.Forms.SAPForm.Dims.RowCount - 1);
label_5:
        num3 = 5;
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: explicit reference operation
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims), (Array) new SAP_Module.Dimensions[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Storeys - 1 + 1)]);
        local = dimensionsArray;
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.Dims.RowCount - 1);
        int rowIndex = 0;
        goto label_11;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Basement = Conversions.ToString(MyProject.Forms.SAPForm.Dims[1, rowIndex].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Dims[2, rowIndex].Value));
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Dims[rowIndex].Height = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Dims[3, rowIndex].Value));
label_10:
        num3 = 10;
        checked { ++rowIndex; }
label_11:
        if (rowIndex <= num4)
          goto label_7;
label_12:
        num3 = 11;
        if (!MyProject.Forms.SAPForm.chkRoomInRoof.Checked)
          goto label_14;
label_13:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TrueRoof = true;
        goto label_16;
label_14:
        num3 = 14;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].TrueRoof = false;
label_15:
label_16:
        num3 = 16;
        if (!SaveFraction)
          goto label_20;
label_17:
        num3 = 17;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingFraction = Conversions.ToSingle(MyProject.Forms.SAPForm.txtLivingFraction.Text);
label_18:
        num3 = 18;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LivingArea = Conversions.ToSingle(MyProject.Forms.SAPForm.txtLivingArea.Text);
label_19:
label_20:
        goto label_27;
label_22:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
            {
              case 1:
                goto label_2;
              case 2:
              case 20:
                goto label_27;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_12;
              case 12:
                goto label_13;
              case 13:
              case 16:
                goto label_16;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_22;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_27:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteFloors()
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_40;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors = checked (MyProject.Forms.SAPForm.Floors.RowCount - 1);
label_5:
        num3 = 5;
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local1;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors), (Array) new SAP_Module.Opaques[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofFloors - 1 + 1)]);
        local1 = opaquesArray;
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.Floors.RowCount - 1);
        int rowIndex1 = 0;
        goto label_15;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].Name = Conversions.ToString(MyProject.Forms.SAPForm.Floors[1, rowIndex1].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].Type = Conversions.ToString(MyProject.Forms.SAPForm.Floors[2, rowIndex1].Value);
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].Construction = Conversions.ToString(MyProject.Forms.SAPForm.Floors[3, rowIndex1].Value);
label_10:
        num3 = 10;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Floors[4, rowIndex1].Value));
label_11:
        num3 = 11;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].U_Value = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Floors[5, rowIndex1].Value));
label_12:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].Ru = 0.0f;
label_13:
        num3 = 13;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Floors[rowIndex1].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Floors[6, rowIndex1].Value));
label_14:
        num3 = 14;
        checked { ++rowIndex1; }
label_15:
        if (rowIndex1 <= num4)
          goto label_7;
label_16:
        num3 = 15;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors = checked (MyProject.Forms.SAPForm.PartyFloors.RowCount - 1);
label_17:
        num3 = 16;
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.PartyElements[] partyElementsArray1 = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors), (Array) new SAP_Module.PartyElements[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofpFloors - 1 + 1)]);
        local2 = partyElementsArray1;
label_18:
        num3 = 17;
        int num5 = checked (MyProject.Forms.SAPForm.PartyFloors.RowCount - 1);
        int rowIndex2 = 0;
        goto label_24;
label_19:
        num3 = 18;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex2].Name = Conversions.ToString(MyProject.Forms.SAPForm.PartyFloors[1, rowIndex2].Value);
label_20:
        num3 = 19;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex2].Construction = Conversions.ToString(MyProject.Forms.SAPForm.PartyFloors[2, rowIndex2].Value);
label_21:
        num3 = 20;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex2].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyFloors[3, rowIndex2].Value));
label_22:
        num3 = 21;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PFloors[rowIndex2].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyFloors[4, rowIndex2].Value));
label_23:
        num3 = 22;
        checked { ++rowIndex2; }
label_24:
        if (rowIndex2 <= num5)
          goto label_19;
label_25:
        num3 = 23;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors = checked (MyProject.Forms.SAPForm.InternalFloor.RowCount - 1);
label_26:
        num3 = 24;
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local3;
        // ISSUE: explicit reference operation
        SAP_Module.PartyElements[] partyElementsArray2 = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local3 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors), (Array) new SAP_Module.PartyElements[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIFloors - 1 + 1)]);
        local3 = partyElementsArray2;
label_27:
        num3 = 25;
        int num6 = checked (MyProject.Forms.SAPForm.InternalFloor.RowCount - 1);
        int rowIndex3 = 0;
        goto label_33;
label_28:
        num3 = 26;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex3].Name = Conversions.ToString(MyProject.Forms.SAPForm.InternalFloor[1, rowIndex3].Value);
label_29:
        num3 = 27;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex3].Construction = Conversions.ToString(MyProject.Forms.SAPForm.InternalFloor[2, rowIndex3].Value);
label_30:
        num3 = 28;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex3].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.InternalFloor[3, rowIndex3].Value));
label_31:
        num3 = 29;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IFloors[rowIndex3].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.InternalFloor[4, rowIndex3].Value));
label_32:
        num3 = 30;
        checked { ++rowIndex3; }
label_33:
        if (rowIndex3 <= num6)
          goto label_28;
        else
          goto label_40;
label_35:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num7 = num2 + 1;
            num2 = 0;
            switch (num7)
            {
              case 1:
                goto label_2;
              case 2:
              case 31:
                goto label_40;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
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
                goto label_25;
              case 24:
                goto label_26;
              case 25:
                goto label_27;
              case 26:
                goto label_28;
              case 27:
                goto label_29;
              case 28:
                goto label_30;
              case 29:
                goto label_31;
              case 30:
                goto label_32;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_35;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_40:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteWalls()
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_43;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls = checked (MyProject.Forms.SAPForm.Walls.RowCount - 1);
label_5:
        num3 = 5;
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local1;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls), (Array) new SAP_Module.Opaques[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWalls - 1 + 1)]);
        local1 = opaquesArray;
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.Walls.RowCount - 1);
        int rowIndex1 = 0;
        goto label_16;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].Name = Conversions.ToString(MyProject.Forms.SAPForm.Walls[1, rowIndex1].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].Type = Conversions.ToString(MyProject.Forms.SAPForm.Walls[2, rowIndex1].Value);
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].Construction = Conversions.ToString(MyProject.Forms.SAPForm.Walls[3, rowIndex1].Value);
label_10:
        num3 = 10;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Walls[4, rowIndex1].Value));
label_11:
        num3 = 11;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].U_Value = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Walls[5, rowIndex1].Value));
label_12:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].Ru = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Walls[6, rowIndex1].Value));
label_13:
        num3 = 13;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].Curtain = Conversions.ToBoolean(MyProject.Forms.SAPForm.Walls[8, rowIndex1].Value);
label_14:
        num3 = 14;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Walls[rowIndex1].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Walls[9, rowIndex1].Value));
label_15:
        num3 = 15;
        checked { ++rowIndex1; }
label_16:
        if (rowIndex1 <= num4)
          goto label_7;
label_17:
        num3 = 16;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls = checked (MyProject.Forms.SAPForm.PartyWalls.RowCount - 1);
label_18:
        num3 = 17;
        // ISSUE: variable of a reference type
        SAP_Module.PartyWall[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.PartyWall[] partyWallArray = (SAP_Module.PartyWall[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls), (Array) new SAP_Module.PartyWall[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPWalls - 1 + 1)]);
        local2 = partyWallArray;
label_19:
        num3 = 18;
        int num5 = checked (MyProject.Forms.SAPForm.PartyWalls.RowCount - 1);
        int rowIndex2 = 0;
        goto label_27;
label_20:
        num3 = 19;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex2].Name = Conversions.ToString(MyProject.Forms.SAPForm.PartyWalls[1, rowIndex2].Value);
label_21:
        num3 = 20;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex2].Type = Conversions.ToString(MyProject.Forms.SAPForm.PartyWalls[2, rowIndex2].Value);
label_22:
        num3 = 21;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex2].Construction = Conversions.ToString(MyProject.Forms.SAPForm.PartyWalls[3, rowIndex2].Value);
label_23:
        num3 = 22;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex2].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyWalls[4, rowIndex2].Value));
label_24:
        num3 = 23;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex2].U_Value = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyWalls[5, rowIndex2].Value));
label_25:
        num3 = 24;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PWalls[rowIndex2].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyWalls[6, rowIndex2].Value));
label_26:
        num3 = 25;
        checked { ++rowIndex2; }
label_27:
        if (rowIndex2 <= num5)
          goto label_20;
label_28:
        num3 = 26;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls = checked (MyProject.Forms.SAPForm.InternalWall.RowCount - 1);
label_29:
        num3 = 27;
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local3;
        // ISSUE: explicit reference operation
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local3 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls), (Array) new SAP_Module.PartyElements[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofIWalls - 1 + 1)]);
        local3 = partyElementsArray;
label_30:
        num3 = 28;
        int num6 = checked (MyProject.Forms.SAPForm.InternalWall.RowCount - 1);
        int rowIndex3 = 0;
        goto label_36;
label_31:
        num3 = 29;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex3].Name = Conversions.ToString(MyProject.Forms.SAPForm.InternalWall[1, rowIndex3].Value);
label_32:
        num3 = 30;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex3].Construction = Conversions.ToString(MyProject.Forms.SAPForm.InternalWall[2, rowIndex3].Value);
label_33:
        num3 = 31;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex3].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.InternalWall[3, rowIndex3].Value));
label_34:
        num3 = 32;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IWalls[rowIndex3].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.InternalWall[4, rowIndex3].Value));
label_35:
        num3 = 33;
        checked { ++rowIndex3; }
label_36:
        if (rowIndex3 <= num6)
          goto label_31;
        else
          goto label_43;
label_38:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num7 = num2 + 1;
            num2 = 0;
            switch (num7)
            {
              case 1:
                goto label_2;
              case 2:
              case 34:
                goto label_43;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
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
                goto label_28;
              case 27:
                goto label_29;
              case 28:
                goto label_30;
              case 29:
                goto label_31;
              case 30:
                goto label_32;
              case 31:
                goto label_33;
              case 32:
                goto label_34;
              case 33:
                goto label_35;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_38;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_43:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteRoofs()
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_40;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs = checked (MyProject.Forms.SAPForm.Roofs.RowCount - 1);
label_5:
        num3 = 5;
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local1;
        // ISSUE: explicit reference operation
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local1 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs), (Array) new SAP_Module.Opaques[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofs - 1 + 1)]);
        local1 = opaquesArray;
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.Roofs.RowCount - 1);
        int rowIndex1 = 0;
        goto label_15;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].Name = Conversions.ToString(MyProject.Forms.SAPForm.Roofs[1, rowIndex1].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].Type = Conversions.ToString(MyProject.Forms.SAPForm.Roofs[2, rowIndex1].Value);
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].Construction = Conversions.ToString(MyProject.Forms.SAPForm.Roofs[3, rowIndex1].Value);
label_10:
        num3 = 10;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Roofs[4, rowIndex1].Value));
label_11:
        num3 = 11;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].U_Value = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Roofs[5, rowIndex1].Value));
label_12:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].Ru = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Roofs[6, rowIndex1].Value));
label_13:
        num3 = 13;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Roofs[rowIndex1].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.Roofs[8, rowIndex1].Value));
label_14:
        num3 = 14;
        checked { ++rowIndex1; }
label_15:
        if (rowIndex1 <= num4)
          goto label_7;
label_16:
        num3 = 15;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings = checked (MyProject.Forms.SAPForm.PartyCeilings.RowCount - 1);
label_17:
        num3 = 16;
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local2;
        // ISSUE: explicit reference operation
        SAP_Module.PartyElements[] partyElementsArray1 = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local2 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings), (Array) new SAP_Module.PartyElements[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofPCeilings - 1 + 1)]);
        local2 = partyElementsArray1;
label_18:
        num3 = 17;
        int num5 = checked (MyProject.Forms.SAPForm.PartyCeilings.RowCount - 1);
        int rowIndex2 = 0;
        goto label_24;
label_19:
        num3 = 18;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex2].Name = Conversions.ToString(MyProject.Forms.SAPForm.PartyCeilings[1, rowIndex2].Value);
label_20:
        num3 = 19;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex2].Construction = Conversions.ToString(MyProject.Forms.SAPForm.PartyCeilings[2, rowIndex2].Value);
label_21:
        num3 = 20;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex2].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyCeilings[3, rowIndex2].Value));
label_22:
        num3 = 21;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].PCeilings[rowIndex2].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.PartyCeilings[4, rowIndex2].Value));
label_23:
        num3 = 22;
        checked { ++rowIndex2; }
label_24:
        if (rowIndex2 <= num5)
          goto label_19;
label_25:
        num3 = 23;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings = checked (MyProject.Forms.SAPForm.InternalCeiling.RowCount - 1);
label_26:
        num3 = 24;
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local3;
        // ISSUE: explicit reference operation
        SAP_Module.PartyElements[] partyElementsArray2 = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local3 = ref SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings), (Array) new SAP_Module.PartyElements[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofICeilings - 1 + 1)]);
        local3 = partyElementsArray2;
label_27:
        num3 = 25;
        int num6 = checked (MyProject.Forms.SAPForm.InternalCeiling.RowCount - 1);
        int rowIndex3 = 0;
        goto label_33;
label_28:
        num3 = 26;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex3].Name = Conversions.ToString(MyProject.Forms.SAPForm.InternalCeiling[1, rowIndex3].Value);
label_29:
        num3 = 27;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex3].Construction = Conversions.ToString(MyProject.Forms.SAPForm.InternalCeiling[2, rowIndex3].Value);
label_30:
        num3 = 28;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex3].Area = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.InternalCeiling[3, rowIndex3].Value));
label_31:
        num3 = 29;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].ICeilings[rowIndex3].K = (float) Conversion.Val(RuntimeHelpers.GetObjectValue(MyProject.Forms.SAPForm.InternalCeiling[4, rowIndex3].Value));
label_32:
        num3 = 30;
        checked { ++rowIndex3; }
label_33:
        if (rowIndex3 <= num6)
          goto label_28;
        else
          goto label_40;
label_35:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num7 = num2 + 1;
            num2 = 0;
            switch (num7)
            {
              case 1:
                goto label_2;
              case 2:
              case 31:
                goto label_40;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
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
                goto label_25;
              case 24:
                goto label_26;
              case 25:
                goto label_27;
              case 26:
                goto label_28;
              case 27:
                goto label_29;
              case 28:
                goto label_30;
              case 29:
                goto label_31;
              case 30:
                goto label_32;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_35;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_40:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteDoors()
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_32;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors = MyProject.Forms.SAPForm.DataDoors.RowCount;
label_5:
        num3 = 5;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors = new SAP_Module.Door[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors - 1 + 1)];
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.DataDoors.RowCount - 1);
        int rowIndex = 0;
        goto label_25;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Name = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[0, rowIndex].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Location = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[1, rowIndex].Value);
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].UValueSource = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[2, rowIndex].Value);
label_10:
        num3 = 10;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].DoorType = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[3, rowIndex].Value);
label_11:
        num3 = 11;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Orientation = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[4, rowIndex].Value);
label_12:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Overshading = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[5, rowIndex].Value);
label_13:
        num3 = 13;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].GlazingType = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[6, rowIndex].Value);
label_14:
        num3 = 14;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].AirGap = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[7, rowIndex].Value);
label_15:
        num3 = 15;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].FrameType = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[8, rowIndex].Value);
label_16:
        num3 = 16;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].ThermalBreak = Conversions.ToString(MyProject.Forms.SAPForm.DataDoors[9, rowIndex].Value);
label_17:
        num3 = 17;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Area = Conversions.ToSingle(MyProject.Forms.SAPForm.DataDoors[10, rowIndex].Value);
label_18:
        num3 = 18;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Width = Conversions.ToSingle(MyProject.Forms.SAPForm.DataDoors[11, rowIndex].Value);
label_19:
        num3 = 19;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Height = Conversions.ToSingle(MyProject.Forms.SAPForm.DataDoors[12, rowIndex].Value);
label_20:
        num3 = 20;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].Count = Conversions.ToInteger(MyProject.Forms.SAPForm.DataDoors[13, rowIndex].Value);
label_21:
        num3 = 21;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].g = Conversions.ToSingle(MyProject.Forms.SAPForm.DataDoors[14, rowIndex].Value);
label_22:
        num3 = 22;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].FF = Conversions.ToSingle(MyProject.Forms.SAPForm.DataDoors[15, rowIndex].Value);
label_23:
        num3 = 23;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[rowIndex].U = Conversions.ToSingle(MyProject.Forms.SAPForm.DataDoors[16, rowIndex].Value);
label_24:
        num3 = 24;
        checked { ++rowIndex; }
label_25:
        if (rowIndex <= num4)
          goto label_7;
        else
          goto label_32;
label_27:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
            {
              case 1:
                goto label_2;
              case 2:
              case 25:
                goto label_32;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_27;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_32:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteWindows()
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_35;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows = MyProject.Forms.SAPForm.DataWindows.RowCount;
label_5:
        num3 = 5;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows = new SAP_Module.Window[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows - 1 + 1)];
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.DataWindows.RowCount - 1);
        int rowIndex = 0;
        goto label_28;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Name = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[0, rowIndex].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Location = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[1, rowIndex].Value);
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].UValueSource = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[2, rowIndex].Value);
label_10:
        num3 = 10;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Orientation = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[3, rowIndex].Value);
label_11:
        num3 = 11;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Overshading = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[4, rowIndex].Value);
label_12:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].GlazingType = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[5, rowIndex].Value);
label_13:
        num3 = 13;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].AirGap = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[6, rowIndex].Value);
label_14:
        num3 = 14;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].FrameType = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[7, rowIndex].Value);
label_15:
        num3 = 15;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].ThermalBreak = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[8, rowIndex].Value);
label_16:
        num3 = 16;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Area = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[9, rowIndex].Value);
label_17:
        num3 = 17;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Width = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[10, rowIndex].Value);
label_18:
        num3 = 18;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Height = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[11, rowIndex].Value);
label_19:
        num3 = 19;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].Count = Conversions.ToInteger(MyProject.Forms.SAPForm.DataWindows[12, rowIndex].Value);
label_20:
        num3 = 20;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].OverhangWidth = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[13, rowIndex].Value);
label_21:
        num3 = 21;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].OverhangDepth = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[14, rowIndex].Value);
label_22:
        num3 = 22;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].CurtainType = Conversions.ToString(MyProject.Forms.SAPForm.DataWindows[15, rowIndex].Value);
label_23:
        num3 = 23;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].FractionClosed = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[16, rowIndex].Value);
label_24:
        num3 = 24;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].g = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[17, rowIndex].Value);
label_25:
        num3 = 25;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].FF = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[18, rowIndex].Value);
label_26:
        num3 = 26;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[rowIndex].U = Conversions.ToSingle(MyProject.Forms.SAPForm.DataWindows[19, rowIndex].Value);
label_27:
        num3 = 27;
        checked { ++rowIndex; }
label_28:
        if (rowIndex <= num4)
          goto label_7;
        else
          goto label_35;
label_30:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
            {
              case 1:
                goto label_2;
              case 2:
              case 28:
                goto label_35;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_25;
              case 26:
                goto label_26;
              case 27:
                goto label_27;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_30;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_35:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteRoofLights()
    {
      int num1;
      int num2;
      try
      {
label_2:
        int num3 = 1;
        if (SAP_Module.CurrDwelling == -1)
          goto label_36;
label_3:
        ProjectData.ClearProjectError();
        num1 = -2;
label_4:
        num3 = 4;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights = MyProject.Forms.SAPForm.DataRoofLights.RowCount;
label_5:
        num3 = 5;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights = new SAP_Module.RoofLight[checked (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights - 1 + 1)];
label_6:
        num3 = 6;
        int num4 = checked (MyProject.Forms.SAPForm.DataRoofLights.RowCount - 1);
        int rowIndex = 0;
        goto label_29;
label_7:
        num3 = 7;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Name = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[0, rowIndex].Value);
label_8:
        num3 = 8;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Location = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[1, rowIndex].Value);
label_9:
        num3 = 9;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].UValueSource = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[2, rowIndex].Value);
label_10:
        num3 = 10;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Pitch = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[3, rowIndex].Value);
label_11:
        num3 = 11;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Orientation = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[4, rowIndex].Value);
label_12:
        num3 = 12;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Overshading = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[5, rowIndex].Value);
label_13:
        num3 = 13;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].GlazingType = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[6, rowIndex].Value);
label_14:
        num3 = 14;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].AirGap = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[7, rowIndex].Value);
label_15:
        num3 = 15;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].FrameType = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[8, rowIndex].Value);
label_16:
        num3 = 16;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].ThermalBreak = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[9, rowIndex].Value);
label_17:
        num3 = 17;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Area = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[10, rowIndex].Value);
label_18:
        num3 = 18;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Width = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[11, rowIndex].Value);
label_19:
        num3 = 19;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Height = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[12, rowIndex].Value);
label_20:
        num3 = 20;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].Count = Conversions.ToInteger(MyProject.Forms.SAPForm.DataRoofLights[13, rowIndex].Value);
label_21:
        num3 = 21;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].OverhangWidth = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[14, rowIndex].Value);
label_22:
        num3 = 22;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].OverhangDepth = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[15, rowIndex].Value);
label_23:
        num3 = 23;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].CurtainType = Conversions.ToString(MyProject.Forms.SAPForm.DataRoofLights[16, rowIndex].Value);
label_24:
        num3 = 24;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].FractionClosed = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[17, rowIndex].Value);
label_25:
        num3 = 25;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].g = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[18, rowIndex].Value);
label_26:
        num3 = 26;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].FF = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[19, rowIndex].Value);
label_27:
        num3 = 27;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[rowIndex].U = Conversions.ToSingle(MyProject.Forms.SAPForm.DataRoofLights[20, rowIndex].Value);
label_28:
        num3 = 28;
        checked { ++rowIndex; }
label_29:
        if (rowIndex <= num4)
          goto label_7;
        else
          goto label_36;
label_31:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
            {
              case 1:
                goto label_2;
              case 2:
              case 29:
                goto label_36;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_25;
              case 26:
                goto label_26;
              case 27:
                goto label_27;
              case 28:
                goto label_28;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_31;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_36:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void WriteVentilation()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Chimneys = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofChmneys.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ChimneysMain = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofChmneysMain.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ChimneysSec = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofChmneysSec.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ChimneysOther = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofChmneysOther.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Flues = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofOpenFlues.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.FluesMain = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofOpenFluesMain.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.FluesSec = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofOpenFluesSec.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.FluesOther = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofOpenFluesOther.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Fans = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofFans.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Vents = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofPassiveVents.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Fires = Convert.ToInt32(MyProject.Forms.SAPForm.txtNoofFlueGasFires.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Shelter = (float) Conversion.Val(MyProject.Forms.SAPForm.txtNoofShelteredSides.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MechVent = MyProject.Forms.SAPForm.txtMechVentilation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Parameters = MyProject.Forms.SAPForm.txtParamters.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.WetRooms = Convert.ToInt32(MyProject.Forms.SAPForm.txtWetRooms.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DuctType = MyProject.Forms.SAPForm.txtDuctInsulation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.ProductName = MyProject.Forms.SAPForm.txtMechProductName.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.DuctingType = MyProject.Forms.SAPForm.txtMechDucting.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.SFP = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechFan.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MVDetails.HEE = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechHeat.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.ApprovedScheme = MyProject.Forms.SAPForm.chkApprovedScheme.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF1 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecKSPF1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF2 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecKSPF2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KSPF3 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecKSPF3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF1 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecOSPF1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF2 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecOSPF2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OSPF3 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecOSPF3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP1 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecKTF1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP2 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecKTF2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.KTP3 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecKTF3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP1 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecOTF1.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP2 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecOTF2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Decentralised.OTP3 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMechDecOTF3.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Pressure = MyProject.Forms.SAPForm.txtAirTest.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DesignAir = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDesignAir.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MeasuredAir = (float) Conversion.Val(MyProject.Forms.SAPForm.txtMeasuredAir.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.DateAir = Conversions.ToDate(MyProject.Forms.SAPForm.txtPressureDate.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AssumedAir = (float) Conversion.Val(MyProject.Forms.SAPForm.txtAssumedAir.Text);
      if (Operators.CompareString(MyProject.Forms.SAPForm.txtDCountry.Text, "Scotland", false) == 0)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AveragePerm = false;
        MyProject.Forms.SAPForm.chkAverageValue.Checked = false;
      }
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.AveragePerm = MyProject.Forms.SAPForm.chkAverageValue.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Construction = MyProject.Forms.SAPForm.txtDetConstruction.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Lobby = MyProject.Forms.SAPForm.txtDetLobby.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.Floor = MyProject.Forms.SAPForm.txtDetFloor.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Infiltration.DraguthP = Conversions.ToSingle(MyProject.Forms.SAPForm.txtDetPercentDraught.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.MultiSystem = MyProject.Forms.SAPForm.ChkMulSystem.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Ventilation.Draught = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDraught.Text);
    }

    public static void WriteMainHeating()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.NoCalc = true;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup = MyProject.Forms.SAPForm.txtPrimary.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SGroup = MyProject.Forms.SAPForm.txtSubGroup.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource = MyProject.Forms.SAPForm.txtHeatingSource.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.BSubGroup = MyProject.Forms.SAPForm.txtBoilerSub.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MHType = MyProject.Forms.SAPForm.txtMainHeatingType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Emitter = MyProject.Forms.SAPForm.txtHeatingEmitter.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Controls = MyProject.Forms.SAPForm.txtHeatingControls.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.DelayedStart = MyProject.Forms.SAPForm.chkDelayedStart.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = MyProject.Forms.SAPForm.txtMainFuel.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.OilPump = MyProject.Forms.SAPForm.chkOilPump.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MainEff = (float) Conversion.Val(MyProject.Forms.SAPForm.txtEfficiency.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpHP = MyProject.Forms.SAPForm.txtPumpHP.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.PumpType = MyProject.Forms.SAPForm.txtPumpType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.BILock = MyProject.Forms.SAPForm.txtBILock.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.Description = MyProject.Forms.SAPForm.txtDescription.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.FuelBurningType = MyProject.Forms.SAPForm.txtBFuelBurningType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlueType = MyProject.Forms.SAPForm.txtBFlueType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FanFlued = MyProject.Forms.SAPForm.txtFanFlued.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.LoadWeather = MyProject.Forms.SAPForm.chkMainHLoadWeather.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.LoadWeatherType = MyProject.Forms.SAPForm.txtLoadWeather.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.ElectricityTariff = MyProject.Forms.SAPForm.txtElectricityTariff.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HETAS = MyProject.Forms.SAPForm.txtHETASMain.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.IncludeKeepHot = MyProject.Forms.SAPForm.chkKeepHot.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotFuel = MyProject.Forms.SAPForm.txtKeepHotFuel.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.KeepHotTimed = MyProject.Forms.SAPForm.chkKeepHotTimed.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Range.CasekW = (float) Conversion.Val(MyProject.Forms.SAPForm.txtRangeCase.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Range.WaterkW = (float) Conversion.Val(MyProject.Forms.SAPForm.txtRangeWater.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Compensator = MyProject.Forms.SAPForm.txtCompensator.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK2005 = MyProject.Forms.SAPForm.chkSEDBUK2005.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Boiler.FlowTemp = MyProject.Forms.SAPForm.cboBoilerFlowTemp.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.MCSCert = MyProject.Forms.SAPForm.chkMCS.Checked;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup.Equals("Community heating schemes") & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource.Equals("Boiler Database"))
      {
        SAP_Write.WriteCommunityDatabase();
      }
      else
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHB1Efficiency.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHB1HFraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.KnownLoss = MyProject.Forms.SAPForm.ChkKnown.Checked;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.KnownLossValue = (float) Conversion.Val(MyProject.Forms.SAPForm.txtLossKnown.Text);
        if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.KnownLoss)
          MyProject.Forms.SAPForm.txtLossKnown.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.KnownLossValue);
        else
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatDSystem = MyProject.Forms.SAPForm.txtCommHDS.Text;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatToPowerRatio = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHB1HeatToPower.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatToPowerRatio = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHB1HeatToPower.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources = Convert.ToInt32(MyProject.Forms.SAPForm.txtCommHNoOfAdditional.Value);
        List<PCDF.Table4a_B> table4aBs1 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate1;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I10\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate1 = SAP_Write._Closure\u0024__.\u0024I10\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I10\u002D0 = predicate1 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtCommHAdd1Type.Text));
        }
        PCDF.Table4a_B table4aB1 = table4aBs1.Where<PCDF.Table4a_B>(predicate1).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB1 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Type = checked ((int) Math.Round(Conversion.Val(table4aB1.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel = MyProject.Forms.SAPForm.txtCommHAdd1Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd1Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd1Efficiency.Text);
        }
        List<PCDF.Table4a_B> table4aBs2 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I10\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Write._Closure\u0024__.\u0024I10\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I10\u002D1 = predicate2 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtCommHAdd2Type.Text));
        }
        PCDF.Table4a_B table4aB2 = table4aBs2.Where<PCDF.Table4a_B>(predicate2).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB2 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Type = checked ((int) Math.Round(Conversion.Val(table4aB2.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel = MyProject.Forms.SAPForm.txtCommHAdd2Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd2Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd2Efficiency.Text);
        }
        List<PCDF.Table4a_B> table4aBs3 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I10\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = SAP_Write._Closure\u0024__.\u0024I10\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I10\u002D2 = predicate3 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtCommHAdd3Type.Text));
        }
        PCDF.Table4a_B table4aB3 = table4aBs3.Where<PCDF.Table4a_B>(predicate3).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB3 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Type = checked ((int) Math.Round(Conversion.Val(table4aB3.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel = MyProject.Forms.SAPForm.txtCommHAdd3Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd3Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd3Efficiency.Text);
        }
        List<PCDF.Table4a_B> table4aBs4 = SAP_Module.PCDFData.Table4a_bs;
        Func<PCDF.Table4a_B, bool> predicate4;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I10\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate4 = SAP_Write._Closure\u0024__.\u0024I10\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I10\u002D3 = predicate4 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtCommHAdd4Type.Text));
        }
        PCDF.Table4a_B table4aB4 = table4aBs4.Where<PCDF.Table4a_B>(predicate4).SingleOrDefault<PCDF.Table4a_B>();
        if (table4aB4 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Type = checked ((int) Math.Round(Conversion.Val(table4aB4.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel = MyProject.Forms.SAPForm.txtCommHAdd4Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd4Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCommHAdd4Efficiency.Text);
        }
      }
      SAP_Write.WriteCoolingSystem();
      SAP_Module.NoCalc = false;
    }

    public static void WriteMainHeating2()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.NoCalc = true;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].IncludeMainHeating2 = MyProject.Forms.SAPForm.ChkIncSecMain.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HGroup = MyProject.Forms.SAPForm.txtSECPrimary.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SGroup = MyProject.Forms.SAPForm.txtSecSubGroup.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.InforSource = MyProject.Forms.SAPForm.txtSecHeatingSource.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.BSubGroup = MyProject.Forms.SAPForm.txtSecBoilerSub.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MHType = MyProject.Forms.SAPForm.txtSecMainHeatingType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Emitter = MyProject.Forms.SAPForm.txtSecHeatingEmitter.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Controls = MyProject.Forms.SAPForm.txtSecHeatingControls.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.DelayedStart = MyProject.Forms.SAPForm.chkSecDelayedStart.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Fuel = MyProject.Forms.SAPForm.txtSecMainFuel.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.OilPump = MyProject.Forms.SAPForm.chkSecOilPump.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MainEff = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecEfficiency.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpHP = MyProject.Forms.SAPForm.txtSecPumpHP.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.BILock = MyProject.Forms.SAPForm.txtSecBILock.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.Description = MyProject.Forms.SAPForm.txtSecDescription.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.FuelBurningType = MyProject.Forms.SAPForm.txtSecBFuelBurningType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlueType = MyProject.Forms.SAPForm.txtSecBFlueType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FanFlued = MyProject.Forms.SAPForm.txtSecFanFlued.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.LoadWeather = MyProject.Forms.SAPForm.chkSecMainHLoadWeather.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.LoadWeatherType = MyProject.Forms.SAPForm.txtSecLoadWeather.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.PumpType = MyProject.Forms.SAPForm.txtSecPumpType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.FlowTemp = MyProject.Forms.SAPForm.cboSecBoilerFlowTemp.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.MCSCert = MyProject.Forms.SAPForm.chkSecMCS.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.HETAS = MyProject.Forms.SAPForm.txtSecHETASMain.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.IncludeKeepHot = MyProject.Forms.SAPForm.chkSecKeepHot.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotFuel = MyProject.Forms.SAPForm.txtSecKeepHotFuel.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Boiler.KeepHotTimed = MyProject.Forms.SAPForm.chkSecKeepHotTimed.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Range.CasekW = (float) Conversion.Val(MyProject.Forms.SAPForm.txtRangeCase.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Range.WaterkW = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecRangeWater.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.Compensator = MyProject.Forms.SAPForm.txtSecCompensator.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.SEDBUK2005 = MyProject.Forms.SAPForm.chkSecSEDBUK2005.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.Boiler1Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHB1Efficiency.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.Boiler1HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHB1HFraction.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatDSystem = MyProject.Forms.SAPForm.txtSecCommHDS.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatToPowerRatio = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHB1HeatToPower.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.NoOfAdditionalHeatSources = Convert.ToInt32(MyProject.Forms.SAPForm.txtSecCommHNoOfAdditional.Value);
      List<PCDF.Table4a_B> table4aBs1 = SAP_Module.PCDFData.Table4a_bs;
      Func<PCDF.Table4a_B, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Write._Closure\u0024__.\u0024I11\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = SAP_Write._Closure\u0024__.\u0024I11\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Write._Closure\u0024__.\u0024I11\u002D0 = predicate1 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtSecCommHAdd1Type.Text));
      }
      PCDF.Table4a_B table4aB1 = table4aBs1.Where<PCDF.Table4a_B>(predicate1).SingleOrDefault<PCDF.Table4a_B>();
      if (table4aB1 != null)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.Type = checked ((int) Math.Round(Conversion.Val(table4aB1.Code)));
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.Fuel = MyProject.Forms.SAPForm.txtSecCommHAdd1Fuel.Text;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd1Fraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource1.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd1Efficiency.Text);
      }
      List<PCDF.Table4a_B> table4aBs2 = SAP_Module.PCDFData.Table4a_bs;
      Func<PCDF.Table4a_B, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Write._Closure\u0024__.\u0024I11\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = SAP_Write._Closure\u0024__.\u0024I11\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Write._Closure\u0024__.\u0024I11\u002D1 = predicate2 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtSecCommHAdd2Type.Text));
      }
      PCDF.Table4a_B table4aB2 = table4aBs2.Where<PCDF.Table4a_B>(predicate2).SingleOrDefault<PCDF.Table4a_B>();
      if (table4aB2 != null)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.Type = checked ((int) Math.Round(Conversion.Val(table4aB2.Code)));
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.Fuel = MyProject.Forms.SAPForm.txtSecCommHAdd2Fuel.Text;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd2Fraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource2.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd2Efficiency.Text);
      }
      List<PCDF.Table4a_B> table4aBs3 = SAP_Module.PCDFData.Table4a_bs;
      Func<PCDF.Table4a_B, bool> predicate3;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Write._Closure\u0024__.\u0024I11\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate3 = SAP_Write._Closure\u0024__.\u0024I11\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Write._Closure\u0024__.\u0024I11\u002D2 = predicate3 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtSecCommHAdd3Type.Text));
      }
      PCDF.Table4a_B table4aB3 = table4aBs3.Where<PCDF.Table4a_B>(predicate3).SingleOrDefault<PCDF.Table4a_B>();
      if (table4aB3 != null)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.Type = checked ((int) Math.Round(Conversion.Val(table4aB3.Code)));
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.Fuel = MyProject.Forms.SAPForm.txtSecCommHAdd3Fuel.Text;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd3Fraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource3.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd3Efficiency.Text);
      }
      List<PCDF.Table4a_B> table4aBs4 = SAP_Module.PCDFData.Table4a_bs;
      Func<PCDF.Table4a_B, bool> predicate4;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Write._Closure\u0024__.\u0024I11\u002D3 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate4 = SAP_Write._Closure\u0024__.\u0024I11\u002D3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Write._Closure\u0024__.\u0024I11\u002D3 = predicate4 = (Func<PCDF.Table4a_B, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtSecCommHAdd4Type.Text));
      }
      PCDF.Table4a_B table4aB4 = table4aBs4.Where<PCDF.Table4a_B>(predicate4).SingleOrDefault<PCDF.Table4a_B>();
      if (table4aB4 != null)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.Type = checked ((int) Math.Round(Conversion.Val(table4aB4.Code)));
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.Fuel = MyProject.Forms.SAPForm.txtSecCommHAdd4Fuel.Text;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd4Fraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating2.CommunityH.HeatSource4.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSecCommHAdd4Efficiency.Text);
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Include_SecMain_Heat_Whole = MyProject.Forms.SAPForm.ChkWholep.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Include_SecMain_Heat_Separat_Part = MyProject.Forms.SAPForm.ChkSeparateP.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].HeatFractionSec = (float) Conversion.Val(MyProject.Forms.SAPForm.TxtHeatFraction.Text);
      SAP_Write.WriteCoolingSystem();
      SAP_Module.NoCalc = false;
    }

    public static void WriteThermal()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualHtb = MyProject.Forms.SAPForm.chkHtb.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ManualY = MyProject.Forms.SAPForm.chky.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ConstDetails = MyProject.Forms.SAPForm.txtConstDetails.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.HtbValue = (float) Conversion.Val(MyProject.Forms.SAPForm.txtHtb.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.YValue = (float) Conversion.Val(MyProject.Forms.SAPForm.txty.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.Reference = MyProject.Forms.SAPForm.txtThermalReference.Text;
    }

    public static void WriteSecHeating()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.NoCalc = true;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HGroup = MyProject.Forms.SAPForm.txtSPrimary.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SGroup = MyProject.Forms.SAPForm.txtSSubGroup.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.InforSource = MyProject.Forms.SAPForm.txtSHeatingSource.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MHType = MyProject.Forms.SAPForm.txtSMainHeatingType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.Fuel = MyProject.Forms.SAPForm.txtSMainFuel.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.HETAS = MyProject.Forms.SAPForm.txtHETAS.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.SecEff = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSEfficiency.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.MDescription = MyProject.Forms.SAPForm.txtSDescription.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.TestMethod = MyProject.Forms.SAPForm.txtSTested.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].SecHeating.FlueType = MyProject.Forms.SAPForm.txtSFlueType.Text;
      SAP_Module.NoCalc = false;
    }

    public static void WriteSolar()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Inlcude = MyProject.Forms.SAPForm.chkSolar.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarType = MyProject.Forms.SAPForm.txtSolarType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Overide = MyProject.Forms.SAPForm.chkSolarOveride.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarZero = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSolarZero.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarHLoss = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSolarHLoss.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarHLoss2 = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSolarHLoss2.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarArea = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSolarArea.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Gross = MyProject.Forms.SAPForm.chkSolarGross.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarTilt = MyProject.Forms.SAPForm.txtSolarTilt.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOrientation = MyProject.Forms.SAPForm.txtSolarOrientation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarOvershading = MyProject.Forms.SAPForm.txtSolarOvershading.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarVolume = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSolarVolume.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.SolarSeperate = MyProject.Forms.SAPForm.chkSolarSeperate.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.Pumped = MyProject.Forms.SAPForm.chkSolarPump.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Solar.ShowerType = MyProject.Forms.SAPForm.cboSolarShower.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include = MyProject.Forms.SAPForm.optWWHRS.Checked;
      if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Include)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].DedicatedStorage = (float) Conversion.Val(MyProject.Forms.SAPForm.txtWWHRSStore1.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].DedicatedStorage = (float) Conversion.Val(MyProject.Forms.SAPForm.txtWWHRSStore2.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.TotalRooms = Convert.ToSingle(MyProject.Forms.SAPForm.txtWWHRSTotalRooms.Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].WithBath = Convert.ToInt32(MyProject.Forms.SAPForm.txtWWHRS1WithBath.Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].WithBath = Convert.ToInt32(MyProject.Forms.SAPForm.txtWWHRS2WithBath.Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[0].WithNoBath = Convert.ToInt32(MyProject.Forms.SAPForm.txtWWHRS1WithNoBath.Value);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.WWHRS.Systems[1].WithNoBath = Convert.ToInt32(MyProject.Forms.SAPForm.txtWWHRS2WithNoBath.Value);
      }
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.Include = MyProject.Forms.SAPForm.ChkFGHRS.Checked;
    }

    public static void WriteWater()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.System = MyProject.Forms.SAPForm.txtWater.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel = MyProject.Forms.SAPForm.txtWaterFuel.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Volume = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyVolume.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.ManuSpecified = MyProject.Forms.SAPForm.optCyManuLoss.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.DeclaredLoss = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyDLoss.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Insulation = MyProject.Forms.SAPForm.txtCyInsulation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InsThick = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCyInsThick.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.InHeatedSpace = MyProject.Forms.SAPForm.optCyHSpace.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Thermostat = MyProject.Forms.SAPForm.optCyThermostat.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulated = MyProject.Forms.SAPForm.optCyPipeWork.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.PipeWorkInsulationType = MyProject.Forms.SAPForm.cboPipeWorkInsulated.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Timed = MyProject.Forms.SAPForm.optCyTimed.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.SummerImmersion = MyProject.Forms.SAPForm.optCySummer.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.Immersion = MyProject.Forms.SAPForm.txtImmersion.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CombiType = MyProject.Forms.SAPForm.txtWCombiType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.CPSUTemp = (float) Conversion.Val(MyProject.Forms.SAPForm.txtCPSUTemp.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase = MyProject.Forms.SAPForm.grdCommunityWater.Visible;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase = MyProject.Forms.SAPForm.grdCommunityWaterSources.Visible;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CylinderInDwelling = MyProject.Forms.SAPForm.chkDHWCommCylinder.Checked;
      if (!SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CHPPowerEff = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommCHP.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HDS = MyProject.Forms.SAPForm.txtDHWCommHDS.Text;
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommEff.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Boiler1Fraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommFraction.Text);
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources = Convert.ToInt32(MyProject.Forms.SAPForm.txtDHWCommHNoOfAdditional.Value);
        List<PCDF.Table4aWater> table4aWaters1 = SAP_Module.PCDFData.Table4aWaters;
        Func<PCDF.Table4aWater, bool> predicate1;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I15\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate1 = SAP_Write._Closure\u0024__.\u0024I15\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I15\u002D0 = predicate1 = (Func<PCDF.Table4aWater, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtDHWCommHAdd1Type.Text));
        }
        PCDF.Table4aWater table4aWater1 = table4aWaters1.Where<PCDF.Table4aWater>(predicate1).SingleOrDefault<PCDF.Table4aWater>();
        if (table4aWater1 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type = checked ((int) Math.Round(Conversion.Val(table4aWater1.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd1Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd1Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd1Efficiency.Text);
        }
        else
        {
          MyProject.Forms.SAPForm.txtDHWCommHAdd1Fuel.Text = SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel;
          MyProject.Forms.SAPForm.txtDHWCommHAdd1Fraction.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.HeatFraction);
          string text = MyProject.Forms.SAPForm.txtDHWCommHAdd1Type.Text;
          if (Operators.CompareString(text, "From hot-water only community scheme - boilers", false) != 0)
          {
            if (Operators.CompareString(text, "From hot-water only community scheme - CHP", false) != 0)
            {
              if (Operators.CompareString(text, "From hot-water only community scheme - heat pump", false) == 0)
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type = 952;
            }
            else
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type = 951;
          }
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type = 950;
          MyProject.Forms.SAPForm.txtDHWCommHAdd1Efficiency.Text = Conversions.ToString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Efficiency);
        }
        List<PCDF.Table4aWater> table4aWaters2 = SAP_Module.PCDFData.Table4aWaters;
        Func<PCDF.Table4aWater, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I15\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Write._Closure\u0024__.\u0024I15\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I15\u002D1 = predicate2 = (Func<PCDF.Table4aWater, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtDHWCommHAdd2Type.Text));
        }
        PCDF.Table4aWater table4aWater2 = table4aWaters2.Where<PCDF.Table4aWater>(predicate2).SingleOrDefault<PCDF.Table4aWater>();
        if (table4aWater2 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type = checked ((int) Math.Round(Conversion.Val(table4aWater2.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd2Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd2Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd2Efficiency.Text);
        }
        else
        {
          string text = MyProject.Forms.SAPForm.txtDHWCommHAdd2Type.Text;
          if (Operators.CompareString(text, "From hot-water only community scheme - boilers", false) != 0)
          {
            if (Operators.CompareString(text, "From hot-water only community scheme - CHP", false) != 0)
            {
              if (Operators.CompareString(text, "From hot-water only community scheme - heat pump", false) == 0)
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type = 952;
            }
            else
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type = 951;
          }
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type = 950;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd2Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.HeatFraction = Conversions.ToSingle(MyProject.Forms.SAPForm.txtDHWCommHAdd2Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Efficiency = Conversions.ToSingle(MyProject.Forms.SAPForm.txtDHWCommHAdd2Efficiency.Text);
        }
        List<PCDF.Table4aWater> table4aWaters3 = SAP_Module.PCDFData.Table4aWaters;
        Func<PCDF.Table4aWater, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I15\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = SAP_Write._Closure\u0024__.\u0024I15\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I15\u002D2 = predicate3 = (Func<PCDF.Table4aWater, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtDHWCommHAdd3Type.Text));
        }
        PCDF.Table4aWater table4aWater3 = table4aWaters3.Where<PCDF.Table4aWater>(predicate3).SingleOrDefault<PCDF.Table4aWater>();
        if (table4aWater3 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type = checked ((int) Math.Round(Conversion.Val(table4aWater3.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd3Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd3Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd3Efficiency.Text);
        }
        else
        {
          string text = MyProject.Forms.SAPForm.txtDHWCommHAdd3Type.Text;
          if (Operators.CompareString(text, "From hot-water only community scheme - boilers", false) != 0)
          {
            if (Operators.CompareString(text, "From hot-water only community scheme - CHP", false) != 0)
            {
              if (Operators.CompareString(text, "From hot-water only community scheme - heat pump", false) == 0)
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type = 952;
            }
            else
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type = 951;
          }
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type = 950;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd3Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.HeatFraction = Conversions.ToSingle(MyProject.Forms.SAPForm.txtDHWCommHAdd3Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Efficiency = Conversions.ToSingle(MyProject.Forms.SAPForm.txtDHWCommHAdd3Efficiency.Text);
        }
        List<PCDF.Table4aWater> table4aWaters4 = SAP_Module.PCDFData.Table4aWaters;
        Func<PCDF.Table4aWater, bool> predicate4;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I15\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate4 = SAP_Write._Closure\u0024__.\u0024I15\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I15\u002D3 = predicate4 = (Func<PCDF.Table4aWater, bool>) (b => b.Description.Equals(MyProject.Forms.SAPForm.txtDHWCommHAdd4Type.Text));
        }
        PCDF.Table4aWater table4aWater4 = table4aWaters4.Where<PCDF.Table4aWater>(predicate4).SingleOrDefault<PCDF.Table4aWater>();
        if (table4aWater4 != null)
        {
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type = checked ((int) Math.Round(Conversion.Val(table4aWater4.Code)));
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd4Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd4Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd4Efficiency.Text);
        }
        else
        {
          string text = MyProject.Forms.SAPForm.txtDHWCommHAdd4Type.Text;
          if (Operators.CompareString(text, "From hot-water only community scheme - boilers", false) != 0)
          {
            if (Operators.CompareString(text, "From hot-water only community scheme - CHP", false) != 0)
            {
              if (Operators.CompareString(text, "From hot-water only community scheme - heat pump", false) == 0)
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type = 952;
            }
            else
              SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type = 951;
          }
          else
            SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type = 950;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel = MyProject.Forms.SAPForm.txtDHWCommHAdd4Fuel.Text;
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.HeatFraction = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd4Fraction.Text);
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Efficiency = (float) Conversion.Val(MyProject.Forms.SAPForm.txtDHWCommHAdd4Efficiency.Text);
        }
      }
      else
        SAP_Write.WriteCommunityWaterDatabase();
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Charging = MyProject.Forms.SAPForm.txtDHWCommCharging.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.LossFactor = Conversions.ToSingle(MyProject.Forms.SAPForm.txtKnownLoss.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Include = MyProject.Forms.SAPForm.chkThermal.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Type = MyProject.Forms.SAPForm.txtThermalType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Location = MyProject.Forms.SAPForm.txtThermalLocation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Thermal.Connection = MyProject.Forms.SAPForm.txtThermalConnection.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPImmersion = MyProject.Forms.SAPForm.txtHeatPumpImmersion.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Cylinder.HPExchanger = (float) Conversion.Val(MyProject.Forms.SAPForm.txtHeatPumpExchanger.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.DHWVessel = MyProject.Forms.SAPForm.CboDHWVessel.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PPower = (float) Conversion.Val(MyProject.Forms.SAPForm.txtFGHRS_PV_PP.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PCOrientation = MyProject.Forms.SAPForm.txtFGHRS_PV_Orientation.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.POvershading = MyProject.Forms.SAPForm.txtFGHRS_PV_OverShading.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.FGHRS.PV.PTilt = MyProject.Forms.SAPForm.txtFGHRS_PV_Tilt.Text;
    }

    private static int GetCommunity(string source)
    {
      string Left = source;
      int community;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "5", false) == 0)
                community = 310;
            }
            else
              community = 309;
          }
          else
            community = 308;
        }
        else
          community = 306;
      }
      else
        community = 307;
      return community;
    }

    private static int GetCommunityWater(string source)
    {
      string Left = source;
      int communityWater;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) == 0)
            communityWater = 952;
        }
        else
          communityWater = 950;
      }
      else
        communityWater = 951;
      return communityWater;
    }

    public static void WriteCommunityDatabase()
    {
      if (!(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.HGroup.Equals("Community heating schemes") & SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.InforSource.Equals("Boiler Database")))
        return;
      List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
      Func<PCDF.CommunityScheme, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Write._Closure\u0024__.\u0024I18\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = SAP_Write._Closure\u0024__.\u0024I18\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Write._Closure\u0024__.\u0024I18\u002D0 = predicate1 = (Func<PCDF.CommunityScheme, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
      }
      if (communitySchemes.Where<PCDF.CommunityScheme>(predicate1).SingleOrDefault<PCDF.CommunityScheme>() != null)
      {
        List<PCDF.CommunityScheme_Sub> communitySchemesSub = SAP_Module.PCDFData.CommunitySchemes_Sub;
        Func<PCDF.CommunityScheme_Sub, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I18\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Write._Closure\u0024__.\u0024I18\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I18\u002D1 = predicate2 = (Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SEDBUK));
        }
        List<PCDF.CommunityScheme_Sub> list = communitySchemesSub.Where<PCDF.CommunityScheme_Sub>(predicate2).ToList<PCDF.CommunityScheme_Sub>();
        if (list != null)
        {
          int num = checked (list.Count - 1);
          int index = 0;
          while (index <= num)
          {
            if (!string.IsNullOrEmpty(list[index].HeatEfficiency))
            {
              switch (index)
              {
                case 0:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatToPowerRatio = (float) Conversion.Val(list[index].PowerEfficiency);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1Efficiency = Conversions.ToSingle(list[index].HeatEfficiency);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.Boiler1HeatFraction = Conversions.ToSingle(list[index].HeatFraction);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.NoOfAdditionalHeatSources = checked ((int) Math.Round(unchecked (Conversions.ToDouble(list[index].NumbHeatSources) - 1.0)));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.SAPTableCode = SAP_Write.GetCommunity(list[index].HeatSourceType);
                  break;
                case 1:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Efficiency = Conversions.ToSingle(list[index].HeatEfficiency);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.HeatFraction = Conversions.ToSingle(list[index].HeatFraction);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Type = SAP_Write.GetCommunity(list[index].HeatSourceType);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource1.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                  break;
                case 2:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Efficiency = Conversions.ToSingle(list[index].HeatEfficiency);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.HeatFraction = Conversions.ToSingle(list[index].HeatFraction);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Type = SAP_Write.GetCommunity(list[index].HeatSourceType);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource2.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                  break;
                case 3:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Efficiency = Conversions.ToSingle(list[index].HeatEfficiency);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.HeatFraction = Conversions.ToSingle(list[index].HeatFraction);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Type = SAP_Write.GetCommunity(list[index].HeatSourceType);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource3.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                  break;
                case 4:
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Efficiency = Conversions.ToSingle(list[index].HeatEfficiency);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.HeatFraction = Conversions.ToSingle(list[index].HeatFraction);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Type = SAP_Write.GetCommunity(list[index].HeatSourceType);
                  SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].MainHeating.CommunityH.HeatSource4.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                  break;
              }
            }
            checked { ++index; }
          }
        }
      }
    }

    public static void WriteCommunityWaterDatabase()
    {
      if (!(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.FromDatabase & !string.IsNullOrEmpty(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef)))
        return;
      List<PCDF.CommunityScheme> communitySchemes = SAP_Module.PCDFData.CommunitySchemes;
      Func<PCDF.CommunityScheme, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (SAP_Write._Closure\u0024__.\u0024I19\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = SAP_Write._Closure\u0024__.\u0024I19\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        SAP_Write._Closure\u0024__.\u0024I19\u002D0 = predicate1 = (Func<PCDF.CommunityScheme, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef));
      }
      if (communitySchemes.Where<PCDF.CommunityScheme>(predicate1).SingleOrDefault<PCDF.CommunityScheme>() != null)
      {
        List<PCDF.CommunityScheme_Sub> communitySchemesSub = SAP_Module.PCDFData.CommunitySchemes_Sub;
        Func<PCDF.CommunityScheme_Sub, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (SAP_Write._Closure\u0024__.\u0024I19\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = SAP_Write._Closure\u0024__.\u0024I19\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          SAP_Write._Closure\u0024__.\u0024I19\u002D1 = predicate2 = (Func<PCDF.CommunityScheme_Sub, bool>) (b => b.ID.Equals(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.SystemRef));
        }
        List<PCDF.CommunityScheme_Sub> list = communitySchemesSub.Where<PCDF.CommunityScheme_Sub>(predicate2).ToList<PCDF.CommunityScheme_Sub>();
        if (list != null)
        {
          int num = checked (list.Count - 1);
          int index = 0;
          while (index <= num)
          {
            switch (index)
            {
              case 0:
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.CHPRatio = (float) Conversion.Val(list[index].PowerEfficiency);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Efficiency = (float) Conversion.Val(list[index].HeatEfficiency);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.Boiler1Fraction = (float) Conversion.Val(list[index].HeatFraction);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.NoOfAdditionalHeatSources = checked ((int) Math.Round(unchecked (Conversions.ToDouble(list[index].NumbHeatSources) - 1.0)));
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.SystemRef = SAP_Write.GetCommunityWater(list[index].HeatSourceType);
                break;
              case 1:
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Efficiency = (float) Conversion.Val(list[index].HeatEfficiency);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.HeatFraction = (float) Conversion.Val(list[index].HeatFraction);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Type = SAP_Write.GetCommunityWater(list[index].HeatSourceType);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource1.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                break;
              case 2:
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Efficiency = (float) Conversion.Val(list[index].HeatEfficiency);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.HeatFraction = (float) Conversion.Val(list[index].HeatFraction);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Type = SAP_Write.GetCommunityWater(list[index].HeatSourceType);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource2.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                break;
              case 3:
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Efficiency = (float) Conversion.Val(list[index].HeatEfficiency);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.HeatFraction = (float) Conversion.Val(list[index].HeatFraction);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Type = SAP_Write.GetCommunityWater(list[index].HeatSourceType);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource3.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                break;
              case 4:
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Efficiency = (float) Conversion.Val(list[index].HeatEfficiency);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.HeatFraction = (float) Conversion.Val(list[index].HeatFraction);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Type = SAP_Write.GetCommunityWater(list[index].HeatSourceType);
                SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Water.HWSComm.HeatSource4.Fuel = SAP_Module.FuelCheck(checked ((int) Math.Round(Conversion.Val(list[index].CommunityFuel))));
                break;
            }
            checked { ++index; }
          }
        }
      }
    }

    public static void WriteCoolingSystem()
    {
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Include = MyProject.Forms.SAPForm.ChkCoolingSystem.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.SystemType = MyProject.Forms.SAPForm.txtCoolingSystemType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Energylabel = MyProject.Forms.SAPForm.txtEnergyLabelClass.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Compressorcontrol = MyProject.Forms.SAPForm.CompressControl.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Cooled_Area = MyProject.Forms.SAPForm.txtCooledArea.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.ERR = (float) Conversion.Val(MyProject.Forms.SAPForm.txtEER.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.ERRMeasuredInclude = MyProject.Forms.SAPForm.ChkEER.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Cooling.Description = MyProject.Forms.SAPForm.txterrDesc.Text;
    }

    public static void WriteRenewable()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Photovoltaic.Inlcude = MyProject.Forms.SAPForm.chkPInclude.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.Inlcude = MyProject.Forms.SAPForm.chkWInclude.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WNumber = Convert.ToInt32(MyProject.Forms.SAPForm.txtWNumber.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WRDiameter = Conversions.ToString(Conversion.Val(MyProject.Forms.SAPForm.txtWRDiameter.Text));
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.WindTurbine.WHeight = Conversions.ToString(Conversion.Val(MyProject.Forms.SAPForm.txtWHeight.Text));
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Include = MyProject.Forms.SAPForm.chkSpecial.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.Description = MyProject.Forms.SAPForm.txtSpDescription.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.EnergySaved = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSpESaved.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.FuelSaved = MyProject.Forms.SAPForm.txtSpFSaved.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.EnergyUsed = (float) Conversion.Val(MyProject.Forms.SAPForm.txtSpEUsed.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.Special.FuelUsed = MyProject.Forms.SAPForm.txtSpFUsed.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.Inlcude = MyProject.Forms.SAPForm.chkAAEGInclude.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.EGenerated = (float) Conversion.Val(MyProject.Forms.SAPForm.txtAAEGGenerated.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.AAEGeneration.TotalArea = Conversions.ToString(Conversion.Val(MyProject.Forms.SAPForm.txtAAEGArea.Text));
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.Inlcude = MyProject.Forms.SAPForm.chkHydroInclude.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.HydroGenerated = (float) Conversion.Val(MyProject.Forms.SAPForm.txtHydroGenerated.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Renewable.HydroGeneration.TotalArea = Conversions.ToString(Conversion.Val(MyProject.Forms.SAPForm.txtHydroArea.Text));
    }

    public static void WriteOverHeating()
    {
      if (SAP_Module.CurrDwelling == -1)
        return;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACBuildType = MyProject.Forms.SAPForm.txtOverAirType.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACWindow = MyProject.Forms.SAPForm.txtOverAirWindow.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACOveride = MyProject.Forms.SAPForm.chkOverOveride.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.EACAirChange = (float) Conversion.Val(MyProject.Forms.SAPForm.txtOverAirach.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.Night = MyProject.Forms.SAPForm.chkNightVentilation.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMOveride = MyProject.Forms.SAPForm.chkOverThermalOveride.Checked;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].OverHeating.TMTMP = (float) Conversion.Val(MyProject.Forms.SAPForm.txtOverThermalTMP.Text);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].AirCon = MyProject.Forms.SAPForm.txtFixedAirCon.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Conservatory = MyProject.Forms.SAPForm.txtConservatory.Text;
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELLights = Convert.ToInt32(MyProject.Forms.SAPForm.txtLELLights.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LELOutlets = Convert.ToInt32(MyProject.Forms.SAPForm.txtLELOutlets.Value);
      SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].LowEnergyLight = (float) Conversion.Val(MyProject.Forms.SAPForm.txtLowEnergyLight.Text);
    }

    public static void SaveDetails()
    {
      if (SAP_Module.CurrDwelling == -1 & (uint) Operators.CompareString(SAP_Module.View, "Project Details", false) > 0U)
        return;
      string view = SAP_Module.View;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(view))
      {
        case 503962622:
          if (Operators.CompareString(view, "Water Heating", false) == 0)
          {
            SAP_Write.WriteSolar();
            SAP_Write.WriteWater();
            break;
          }
          break;
        case 947845416:
          if (Operators.CompareString(view, "Project Details", false) == 0)
          {
            SAP_Write.WriteProjectDetails(false);
            break;
          }
          break;
        case 1536675280:
          if (Operators.CompareString(view, "Dimensions", false) == 0)
          {
            SAP_Write.WriteDimensions(true);
            break;
          }
          break;
        case 2151487536:
          if (Operators.CompareString(view, "Ventilation", false) == 0)
          {
            SAP_Write.WriteVentilation();
            break;
          }
          break;
        case 2287435123:
          if (Operators.CompareString(view, "Opaque Elements", false) == 0)
          {
            SAP_Write.WriteThermal();
            break;
          }
          break;
        case 2305031739:
          if (Operators.CompareString(view, "OverHeating", false) == 0)
          {
            SAP_Write.WriteOverHeating();
            break;
          }
          break;
        case 2898664677:
          if (Operators.CompareString(view, "Heating", false) == 0)
          {
            SAP_Write.WriteMainHeating();
            SAP_Write.WriteMainHeating2();
            SAP_Write.WriteSecHeating();
            break;
          }
          break;
        case 3327943417:
          if (Operators.CompareString(view, "House Details", false) == 0)
          {
            SAP_Write.WriteDwellingDetails(true);
            break;
          }
          break;
        case 3365835362:
          if (Operators.CompareString(view, "Renewable", false) == 0)
          {
            SAP_Write.WriteRenewable();
            break;
          }
          break;
        case 3787682700:
          if (Operators.CompareString(view, "Openings", false) == 0)
            break;
          break;
      }
      Validation.Checkerrors_All(SAP_Module.CurrDwelling);
      SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
    }

    public static void SaveDetails_Validation(int House)
    {
      try
      {
        string view = SAP_Module.View;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(view))
        {
          case 503962622:
            if (Operators.CompareString(view, "Water Heating", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.WaterHeating_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 947845416:
            if (Operators.CompareString(view, "Project Details", false) == 0)
              break;
            break;
          case 1536675280:
            if (Operators.CompareString(view, "Dimensions", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.Dims_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 2151487536:
            if (Operators.CompareString(view, "Ventilation", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.Ventilation_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 2287435123:
            if (Operators.CompareString(view, "Opaque Elements", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.Opaque_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 2305031739:
            if (Operators.CompareString(view, "OverHeating", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.OverHeating_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 2898664677:
            if (Operators.CompareString(view, "Heating", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.Heating_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 3327943417:
            if (Operators.CompareString(view, "House Details", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.Property_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].ImageIndex = 8;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].ImageIndex = 2;
            break;
          case 3365835362:
            if (Operators.CompareString(view, "Renewable", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.RenewablesTech_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
          case 3787682700:
            if (Operators.CompareString(view, "Openings", false) != 0)
              break;
            if (SAP_Module.Proj.Dwellings[House].Validation.Openings_Check)
            {
              MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 6;
              break;
            }
            MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[House].Nodes[checked (PDFFunctions.Current_View - 1)].ImageIndex = 7;
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
