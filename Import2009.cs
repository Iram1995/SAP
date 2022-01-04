
// Type: SAP2012.Import2009




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using uValueCalc;

namespace SAP2012
{
  public class Import2009
  {
    public void Import_2009_Dwellings(string[] Files)
    {
      try
      {
        int num1 = checked (Files.Length - 1);
        int index = 0;
        while (index <= num1)
        {
          string file = Files[index];
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
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].Name = "House " + Conversions.ToString(SAP_Module.Proj.NoOfDwells);
          SAP_Module.Proj.Dwellings[checked (SAP_Module.Proj.NoOfDwells - 1)].YearBuilt = DateAndTime.Now.Year;
          SAP_Module.CurrDwelling = checked (SAP_Module.Proj.NoOfDwells - 1);
          object objectValue;
          try
          {
            FileStream serializationStream = File.Open(file, FileMode.Open);
            objectValue = RuntimeHelpers.GetObjectValue(new BinaryFormatter().Deserialize((Stream) serializationStream));
            serializationStream.Close();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num3 = (int) Interaction.MsgBox((object) Information.Err().Description);
            ProjectData.ClearProjectError();
          }
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling] = this.ConvertSAP2009(RuntimeHelpers.GetObjectValue(objectValue));
          Validation.Checkerrors_All(SAP_Module.CurrDwelling);
          Functions.MakeTree();
          MyProject.Forms.SAPForm.TreeSAP.SelectedNode = MyProject.Forms.SAPForm.TreeSAP.Nodes[0].Nodes[SAP_Module.CurrDwelling];
          SAP_Write.SaveDetails_Validation(SAP_Module.CurrDwelling);
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

    public void Import_2009_Method(object ProjectImport, int[] Dwellings)
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
          SAP_Module.Dwelling dwelling = this.ConvertSAP2009(RuntimeHelpers.GetObjectValue(obj1));
          dwellings[currDwelling] = dwelling;
          try
          {
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[index].Name, "Plot 006 - Rev A", false) == 0)
              Console.Write("");
            ref SAP_Module.Project local8 = ref SAP_Module.Proj;
            object obj2 = NewLateBinding.LateGet(ProjectImport, (System.Type) null, "SAPUValues", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
            Output.UProj uproj = obj2 != null ? (Output.UProj) obj2 : new Output.UProj();
            local8.SAPUValues = uproj;
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

    private SAP_Module.Dwelling ConvertSAP2009(object SAP2009)
    {
      SAP_Module.Dwelling dwelling;
      dwelling.Imported09 = true;
      dwelling.Name = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (Operators.CompareString(dwelling.Name, "Plot 006 - Rev A", false) == 0)
        Console.Write("");
      dwelling.ID = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "ID", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Reference = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Reference", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SAPOnly = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SAPOnly", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Overheat = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Overheat", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Status = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Status", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.DateAssessment = Conversions.ToDate(NewLateBinding.LateGet(SAP2009, (System.Type) null, "DateAssessment", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.DateCertificate = Conversions.ToDate(NewLateBinding.LateGet(SAP2009, (System.Type) null, "DateCertificate", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Transaction = "New dwelling";
      dwelling.RPD = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "RPD", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Line1 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Line1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Line2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Line2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Line3 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Line3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.City = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "City", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.Country = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Country", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Address.PostCost = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Address", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PostCost", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.UPRN = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "UPRN", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.PropertyType = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "PropertyType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.BuildForm = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "BuildForm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.FlatType = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "FlatType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.YearBuilt = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "YearBuilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Tenure = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Tenure", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Location = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.ShelteredSides = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "ShelteredSides", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Terrain = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Terrain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Orientation = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.AirCon = !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(SAP2009, (System.Type) null, "AirCon", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Yes", false) ? "No" : "Yes";
      dwelling.Conservatory = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Conservatory", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LELLights = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LELLights", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LELOutlets = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LELOutlets", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LowEnergyLight = Conversions.ToSingle(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LowEnergyLight", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.EPCLanguage = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "EPCLanguage", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SmokeArea = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SmokeArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Overshading = Conversions.ToString(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Storeys = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Storeys", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.TrueRoof = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "TrueRoof", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LivingArea = Conversions.ToSingle(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LivingArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LivingFraction = Conversions.ToSingle(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LivingFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LivingFractionSpecified = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LivingFractionSpecified", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Dims = new SAP_Module.Dimensions[checked (dwelling.Storeys - 1 + 1)];
      int num1 = checked (dwelling.Storeys - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        ref SAP_Module.Dimensions local1 = ref dwelling.Dims[index1];
        object[] objArray1;
        bool[] flagArray1;
        object Instance1 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray1 = new object[1]
        {
          (object) index1
        }, (string[]) null, (System.Type[]) null, flagArray1 = new bool[1]
        {
          true
        });
        if (flagArray1[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (int));
        string str = Conversions.ToString(NewLateBinding.LateGet(Instance1, (System.Type) null, "Basement", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local1.Basement = str;
        ref SAP_Module.Dimensions local2 = ref dwelling.Dims[index1];
        object[] objArray2;
        bool[] flagArray2;
        object Instance2 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray2 = new object[1]
        {
          (object) index1
        }, (string[]) null, (System.Type[]) null, flagArray2 = new bool[1]
        {
          true
        });
        if (flagArray2[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (int));
        double single1 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance2, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local2.Area = (float) single1;
        ref SAP_Module.Dimensions local3 = ref dwelling.Dims[index1];
        object[] objArray3;
        bool[] flagArray3;
        object Instance3 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray3 = new object[1]
        {
          (object) index1
        }, (string[]) null, (System.Type[]) null, flagArray3 = new bool[1]
        {
          true
        });
        if (flagArray3[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (int));
        double single2 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance3, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local3.Height = (float) single2;
        try
        {
          ref SAP_Module.Dims local4 = ref dwelling.Dims[index1].Dims;
          object[] objArray4;
          bool[] flagArray4;
          object Instance4 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray4 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray4 = new bool[1]
          {
            true
          });
          if (flagArray4[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray4[0]), typeof (int));
          double single3 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance4, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local4.L1 = (float) single3;
          ref SAP_Module.Dims local5 = ref dwelling.Dims[index1].Dims;
          object[] objArray5;
          bool[] flagArray5;
          object Instance5 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray5 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray5 = new bool[1]
          {
            true
          });
          if (flagArray5[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray5[0]), typeof (int));
          double single4 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance5, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local5.W1 = (float) single4;
          ref SAP_Module.Dims local6 = ref dwelling.Dims[index1].Dims;
          object[] objArray6;
          bool[] flagArray6;
          object Instance6 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray6 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray6 = new bool[1]
          {
            true
          });
          if (flagArray6[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray6[0]), typeof (int));
          double single5 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance6, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local6.L2 = (float) single5;
          ref SAP_Module.Dims local7 = ref dwelling.Dims[index1].Dims;
          object[] objArray7;
          bool[] flagArray7;
          object Instance7 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray7 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray7 = new bool[1]
          {
            true
          });
          if (flagArray7[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray7[0]), typeof (int));
          double single6 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance7, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local7.W2 = (float) single6;
          ref SAP_Module.Dims local8 = ref dwelling.Dims[index1].Dims;
          object[] objArray8;
          bool[] flagArray8;
          object Instance8 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray8 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray8 = new bool[1]
          {
            true
          });
          if (flagArray8[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray8[0]), typeof (int));
          double single7 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance8, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local8.L3 = (float) single7;
          ref SAP_Module.Dims local9 = ref dwelling.Dims[index1].Dims;
          object[] objArray9;
          bool[] flagArray9;
          object Instance9 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray9 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray9 = new bool[1]
          {
            true
          });
          if (flagArray9[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray9[0]), typeof (int));
          double single8 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance9, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local9.W3 = (float) single8;
          ref SAP_Module.Dims local10 = ref dwelling.Dims[index1].Dims;
          object[] objArray10;
          bool[] flagArray10;
          object Instance10 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray10 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray10 = new bool[1]
          {
            true
          });
          if (flagArray10[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray10[0]), typeof (int));
          double single9 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance10, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local10.L4 = (float) single9;
          ref SAP_Module.Dims local11 = ref dwelling.Dims[index1].Dims;
          object[] objArray11;
          bool[] flagArray11;
          object Instance11 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray11 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray11 = new bool[1]
          {
            true
          });
          if (flagArray11[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray11[0]), typeof (int));
          double single10 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance11, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local11.W4 = (float) single10;
          ref SAP_Module.Dims local12 = ref dwelling.Dims[index1].Dims;
          object[] objArray12;
          bool[] flagArray12;
          object Instance12 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray12 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray12 = new bool[1]
          {
            true
          });
          if (flagArray12[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray12[0]), typeof (int));
          double single11 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance12, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local12.L5 = (float) single11;
          ref SAP_Module.Dims local13 = ref dwelling.Dims[index1].Dims;
          object[] objArray13;
          bool[] flagArray13;
          object Instance13 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray13 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray13 = new bool[1]
          {
            true
          });
          if (flagArray13[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray13[0]), typeof (int));
          double single12 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance13, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local13.W5 = (float) single12;
          ref SAP_Module.Dims local14 = ref dwelling.Dims[index1].Dims;
          object[] objArray14;
          bool[] flagArray14;
          object Instance14 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray14 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray14 = new bool[1]
          {
            true
          });
          if (flagArray14[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray14[0]), typeof (int));
          double single13 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance14, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local14.L6 = (float) single13;
          ref SAP_Module.Dims local15 = ref dwelling.Dims[index1].Dims;
          object[] objArray15;
          bool[] flagArray15;
          object Instance15 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Dims", objArray15 = new object[1]
          {
            (object) index1
          }, (string[]) null, (System.Type[]) null, flagArray15 = new bool[1]
          {
            true
          });
          if (flagArray15[0])
            index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray15[0]), typeof (int));
          double single14 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance15, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local15.W6 = (float) single14;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      dwelling.GrossAreas = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "GrossAreas", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.ManualHtb = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ManualHtb", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.ManualY = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ManualY", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.ConstDetails = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ConstDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.HtbValue = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HtbValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.YValue = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "YValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.ImportedYvalue = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "YValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Thermal.Reference = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Reference", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (!dwelling.Thermal.ManualHtb)
        dwelling.Thermal.YValue = 0.15f;
      if (dwelling.Thermal.ManualHtb)
      {
        dwelling.Thermal = new SAP_Module.Thermal();
        SAP_Module.Junction junction1 = new SAP_Module.Junction();
        SAP_Module.Junction junction2 = new SAP_Module.Junction();
        try
        {
          int index2 = 0;
          do
          {
            junction1.IsAccredited = false;
            junction1.IsDefault = false;
            junction2.IsDefault = false;
            junction2.IsAccredited = false;
            int num2 = index2;
            if (num2 >= 0 && num2 <= 17)
            {
              if (NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Custom", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != null)
              {
                ref SAP_Module.Junction local16 = ref junction1;
                object[] objArray16;
                bool[] flagArray16;
                object obj1 = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Custom", objArray16 = new object[2]
                {
                  (object) index2,
                  (object) 0
                }, (string[]) null, (System.Type[]) null, flagArray16 = new bool[2]
                {
                  true,
                  false
                });
                if (flagArray16[0])
                  index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray16[0]), typeof (int));
                double single15 = (double) Conversions.ToSingle(obj1);
                local16.ThermalTransmittance = (float) single15;
                string[] approvedValue = this.GetApprovedValue();
                string[] defaultValue = this.GetDefaultValue();
                if ((double) junction1.ThermalTransmittance != 0.0)
                {
                  if ((double) junction1.ThermalTransmittance == Conversion.Val(approvedValue[index2]))
                    junction1.IsAccredited = true;
                  else if ((double) junction1.ThermalTransmittance == Conversion.Val(defaultValue[index2]))
                    junction1.IsDefault = true;
                }
                ref SAP_Module.Junction local17 = ref junction1;
                object[] objArray17;
                bool[] flagArray17;
                object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Custom", objArray17 = new object[2]
                {
                  (object) index2,
                  (object) 1
                }, (string[]) null, (System.Type[]) null, flagArray17 = new bool[2]
                {
                  true,
                  false
                });
                if (flagArray17[0])
                  index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray17[0]), typeof (int));
                double single16 = (double) Conversions.ToSingle(obj2);
                local17.Length = (float) single16;
                switch (index2)
                {
                  case 0:
                    junction1.Ref = "E1";
                    junction1.JunctionDetail = "Steel lintel with perforated steel base plate ";
                    break;
                  case 1:
                    junction1.Ref = "E2";
                    junction1.JunctionDetail = "Other lintels (including other steel lintels)";
                    break;
                  case 2:
                    junction1.Ref = "E3";
                    junction1.JunctionDetail = "Still";
                    break;
                  case 3:
                    junction1.Ref = "E4";
                    junction1.JunctionDetail = "Jamb";
                    break;
                  case 4:
                    junction1.Ref = "E5";
                    junction1.JunctionDetail = "Ground floor (normal)";
                    break;
                  case 5:
                    junction1.Ref = "E6";
                    junction1.JunctionDetail = "Intermediate floor within a dwelling";
                    break;
                  case 6:
                    junction1.Ref = "E7";
                    junction1.JunctionDetail = "Party floor between dwellings (in blocks of flats)";
                    break;
                  case 7:
                    junction1.Ref = "E8";
                    junction1.JunctionDetail = "Balcony within a dwelling, wall insulation continuous";
                    break;
                  case 8:
                    junction1.Ref = "E9";
                    junction1.JunctionDetail = "Balcony between dwellings, wall insulation continuous";
                    break;
                  case 9:
                    junction1.Ref = "E10";
                    junction1.JunctionDetail = "Eaves (insulation at ceiling level)";
                    break;
                  case 10:
                    junction1.Ref = "E11";
                    junction1.JunctionDetail = "Eaves (insulation at rafter level) ";
                    break;
                  case 11:
                    junction1.Ref = "E12";
                    junction1.JunctionDetail = "Gable (insulation at ceiling level)";
                    break;
                  case 12:
                    junction1.Ref = "E13";
                    junction1.JunctionDetail = "Gable (insulation at rafter level)";
                    break;
                  case 13:
                    junction1.Ref = "E14";
                    junction1.JunctionDetail = "Flat roof";
                    break;
                  case 14:
                    junction1.Ref = "E15";
                    junction1.JunctionDetail = "Flat roof with parapet";
                    break;
                  case 15:
                    junction1.Ref = "E16";
                    junction1.JunctionDetail = "Corner (normal)";
                    break;
                  case 16:
                    junction1.Ref = "E17";
                    junction1.JunctionDetail = "Corner (inverted – internal area greater than external area)";
                    break;
                  case 17:
                    junction1.Ref = "E18";
                    junction1.JunctionDetail = "Party wall between dwellings";
                    break;
                }
              }
              if (dwelling.Thermal.ExternalJunctions == null)
                dwelling.Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
              dwelling.Thermal.ExternalJunctions.Add(junction1);
            }
            else if (num2 >= 18 && num2 <= 22)
            {
              if (NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Custom", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != null)
              {
                ref SAP_Module.Junction local = ref junction2;
                object[] objArray;
                bool[] flagArray;
                object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Custom", objArray = new object[2]
                {
                  (object) index2,
                  (object) 0
                }, (string[]) null, (System.Type[]) null, flagArray = new bool[2]
                {
                  true,
                  false
                });
                if (flagArray[0])
                  index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
                double single = (double) Conversions.ToSingle(obj);
                local.ThermalTransmittance = (float) single;
                string[] approvedValue = this.GetApprovedValue();
                string[] defaultValue = this.GetDefaultValue();
                if (Conversion.Val(approvedValue[index2]) != 0.0)
                {
                  if ((double) junction2.ThermalTransmittance == Conversion.Val(approvedValue[index2]))
                    junction2.IsAccredited = true;
                  else if ((double) junction2.ThermalTransmittance == Conversion.Val(defaultValue[index2]))
                    junction2.IsDefault = true;
                }
                switch (index2)
                {
                  case 18:
                    junction2.Ref = "P1";
                    junction2.JunctionDetail = "Ground floor";
                    break;
                  case 19:
                    junction2.Ref = "P2";
                    junction2.JunctionDetail = "Intermediate floor within a dwelling";
                    break;
                  case 20:
                    junction2.Ref = "P3";
                    junction2.JunctionDetail = "Intermediate floor between dwellings (in blocks of flats) ";
                    break;
                  case 21:
                    junction2.Ref = "P4";
                    junction2.JunctionDetail = "Roof (insulation at ceiling level)";
                    break;
                  case 22:
                    junction2.Ref = "P5";
                    junction2.JunctionDetail = "Roof (insulation at rafter level) ";
                    break;
                }
              }
              if (dwelling.Thermal.PartyJunctions == null)
                dwelling.Thermal.PartyJunctions = new List<SAP_Module.Junction>();
              ref SAP_Module.Junction local18 = ref junction2;
              object[] objArray18;
              bool[] flagArray18;
              object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Custom", objArray18 = new object[2]
              {
                (object) index2,
                (object) 1
              }, (string[]) null, (System.Type[]) null, flagArray18 = new bool[2]
              {
                true,
                false
              });
              if (flagArray18[0])
                index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray18[0]), typeof (int));
              double single17 = (double) Conversions.ToSingle(obj3);
              local18.Length = (float) single17;
              dwelling.Thermal.PartyJunctions.Add(junction2);
            }
            checked { ++index2; }
          }
          while (index2 <= 22);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        dwelling.Thermal.ManualHtb = true;
        dwelling.Thermal.HtbValue = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HtbValue", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      dwelling.NoofFloors = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofFloors", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Floors = new SAP_Module.Opaques[checked (dwelling.NoofFloors - 1 + 1)];
      int num3 = checked (dwelling.NoofFloors - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        ref SAP_Module.Opaques local19 = ref dwelling.Floors[index3];
        object[] objArray19;
        bool[] flagArray19;
        object Instance16 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray19 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray19 = new bool[1]
        {
          true
        });
        if (flagArray19[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray19[0]), typeof (int));
        string str1 = Conversions.ToString(NewLateBinding.LateGet(Instance16, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local19.Name = str1;
        ref SAP_Module.Opaques local20 = ref dwelling.Floors[index3];
        object[] objArray20;
        bool[] flagArray20;
        object Instance17 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray20 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray20 = new bool[1]
        {
          true
        });
        if (flagArray20[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray20[0]), typeof (int));
        string str2 = Conversions.ToString(NewLateBinding.LateGet(Instance17, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local20.Type = str2;
        ref SAP_Module.Opaques local21 = ref dwelling.Floors[index3];
        object[] objArray21;
        bool[] flagArray21;
        object Instance18 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray21 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray21 = new bool[1]
        {
          true
        });
        if (flagArray21[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray21[0]), typeof (int));
        double single18 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance18, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local21.Area = (float) single18;
        ref SAP_Module.Opaques local22 = ref dwelling.Floors[index3];
        object[] objArray22;
        bool[] flagArray22;
        object Instance19 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray22 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray22 = new bool[1]
        {
          true
        });
        if (flagArray22[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray22[0]), typeof (int));
        double single19 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance19, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local22.U_Value = (float) single19;
        ref SAP_Module.Opaques local23 = ref dwelling.Floors[index3];
        object[] objArray23;
        bool[] flagArray23;
        object Instance20 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray23 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray23 = new bool[1]
        {
          true
        });
        if (flagArray23[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray23[0]), typeof (int));
        double single20 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance20, (System.Type) null, "Ru", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local23.Ru = (float) single20;
        ref SAP_Module.Opaques local24 = ref dwelling.Floors[index3];
        object[] objArray24;
        bool[] flagArray24;
        object Instance21 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray24 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray24 = new bool[1]
        {
          true
        });
        if (flagArray24[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray24[0]), typeof (int));
        int num4 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance21, (System.Type) null, "Curtain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
        local24.Curtain = num4 != 0;
        ref SAP_Module.Opaques local25 = ref dwelling.Floors[index3];
        object[] objArray25;
        bool[] flagArray25;
        object Instance22 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray25 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray25 = new bool[1]
        {
          true
        });
        if (flagArray25[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray25[0]), typeof (int));
        string str3 = Conversions.ToString(NewLateBinding.LateGet(Instance22, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local25.Name = str3;
        ref SAP_Module.Opaques local26 = ref dwelling.Floors[index3];
        object[] objArray26;
        bool[] flagArray26;
        object Instance23 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray26 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray26 = new bool[1]
        {
          true
        });
        if (flagArray26[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray26[0]), typeof (int));
        string str4 = Conversions.ToString(NewLateBinding.LateGet(Instance23, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local26.Construction = str4;
        ref SAP_Module.Opaques local27 = ref dwelling.Floors[index3];
        object[] objArray27;
        bool[] flagArray27;
        object Instance24 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray27 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray27 = new bool[1]
        {
          true
        });
        if (flagArray27[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray27[0]), typeof (int));
        int num5 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance24, (System.Type) null, "UValueSelected", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
        local27.UValueSelected = num5 != 0;
        ref SAP_Module.Opaques local28 = ref dwelling.Floors[index3];
        object[] objArray28;
        bool[] flagArray28;
        object Instance25 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray28 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray28 = new bool[1]
        {
          true
        });
        if (flagArray28[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray28[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance25, (System.Type) null, "UValueSelection", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local28.UValueSelection = integer;
        ref SAP_Module.Opaques local29 = ref dwelling.Floors[index3];
        object[] objArray29;
        bool[] flagArray29;
        object Instance26 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Floors", objArray29 = new object[1]
        {
          (object) index3
        }, (string[]) null, (System.Type[]) null, flagArray29 = new bool[1]
        {
          true
        });
        if (flagArray29[0])
          index3 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray29[0]), typeof (int));
        double single21 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance26, (System.Type) null, "K", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local29.K = (float) single21;
        checked { ++index3; }
      }
      dwelling.NoofIFloors = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofiFloors", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.IFloors = new SAP_Module.PartyElements[checked (dwelling.NoofIFloors - 1 + 1)];
      int num6 = checked (dwelling.NoofIFloors - 1);
      int index4 = 0;
      while (index4 <= num6)
      {
        try
        {
          ref SAP_Module.PartyElements local30 = ref dwelling.IFloors[index4];
          object[] objArray30;
          bool[] flagArray30;
          object Instance27 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "iFloors", objArray30 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray30 = new bool[1]
          {
            true
          });
          if (flagArray30[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray30[0]), typeof (int));
          string str5 = Conversions.ToString(NewLateBinding.LateGet(Instance27, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local30.Name = str5;
          ref SAP_Module.PartyElements local31 = ref dwelling.IFloors[index4];
          object[] objArray31;
          bool[] flagArray31;
          object Instance28 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "iFloors", objArray31 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray31 = new bool[1]
          {
            true
          });
          if (flagArray31[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray31[0]), typeof (int));
          string str6 = Conversions.ToString(NewLateBinding.LateGet(Instance28, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local31.Construction = str6;
          ref SAP_Module.PartyElements local32 = ref dwelling.IFloors[index4];
          object[] objArray32;
          bool[] flagArray32;
          object Instance29 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "iFloors", objArray32 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray32 = new bool[1]
          {
            true
          });
          if (flagArray32[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray32[0]), typeof (int));
          double single22 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance29, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local32.Area = (float) single22;
          ref SAP_Module.PartyElements local33 = ref dwelling.IFloors[index4];
          object[] objArray33;
          bool[] flagArray33;
          object Instance30 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "iFloors", objArray33 = new object[1]
          {
            (object) index4
          }, (string[]) null, (System.Type[]) null, flagArray33 = new bool[1]
          {
            true
          });
          if (flagArray33[0])
            index4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray33[0]), typeof (int));
          double single23 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance30, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local33.K = (float) single23;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index4; }
      }
      dwelling.NoofpFloors = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofPFloors", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.PFloors = new SAP_Module.PartyElements[checked (dwelling.NoofpFloors - 1 + 1)];
      int num7 = checked (dwelling.NoofpFloors - 1);
      int index5 = 0;
      while (index5 <= num7)
      {
        try
        {
          ref SAP_Module.PartyElements local34 = ref dwelling.PFloors[index5];
          object[] objArray34;
          bool[] flagArray34;
          object Instance31 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "pFloors", objArray34 = new object[1]
          {
            (object) index5
          }, (string[]) null, (System.Type[]) null, flagArray34 = new bool[1]
          {
            true
          });
          if (flagArray34[0])
            index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray34[0]), typeof (int));
          string str7 = Conversions.ToString(NewLateBinding.LateGet(Instance31, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local34.Name = str7;
          ref SAP_Module.PartyElements local35 = ref dwelling.PFloors[index5];
          object[] objArray35;
          bool[] flagArray35;
          object Instance32 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "pFloors", objArray35 = new object[1]
          {
            (object) index5
          }, (string[]) null, (System.Type[]) null, flagArray35 = new bool[1]
          {
            true
          });
          if (flagArray35[0])
            index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray35[0]), typeof (int));
          string str8 = Conversions.ToString(NewLateBinding.LateGet(Instance32, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local35.Construction = str8;
          ref SAP_Module.PartyElements local36 = ref dwelling.PFloors[index5];
          object[] objArray36;
          bool[] flagArray36;
          object Instance33 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "pFloors", objArray36 = new object[1]
          {
            (object) index5
          }, (string[]) null, (System.Type[]) null, flagArray36 = new bool[1]
          {
            true
          });
          if (flagArray36[0])
            index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray36[0]), typeof (int));
          double single24 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance33, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local36.Area = (float) single24;
          ref SAP_Module.PartyElements local37 = ref dwelling.PFloors[index5];
          object[] objArray37;
          bool[] flagArray37;
          object Instance34 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "pFloors", objArray37 = new object[1]
          {
            (object) index5
          }, (string[]) null, (System.Type[]) null, flagArray37 = new bool[1]
          {
            true
          });
          if (flagArray37[0])
            index5 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray37[0]), typeof (int));
          double single25 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance34, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local37.K = (float) single25;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index5; }
      }
      dwelling.NoofWalls = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofWalls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Walls = new SAP_Module.Opaques[checked (dwelling.NoofWalls - 1 + 1)];
      int num8 = checked (dwelling.NoofWalls - 1);
      int index6 = 0;
      while (index6 <= num8)
      {
        try
        {
          ref SAP_Module.Opaques local38 = ref dwelling.Walls[index6];
          object[] objArray38;
          bool[] flagArray38;
          object Instance35 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray38 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray38 = new bool[1]
          {
            true
          });
          if (flagArray38[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray38[0]), typeof (int));
          string str9 = Conversions.ToString(NewLateBinding.LateGet(Instance35, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local38.Name = str9;
          ref SAP_Module.Opaques local39 = ref dwelling.Walls[index6];
          object[] objArray39;
          bool[] flagArray39;
          object Instance36 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray39 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray39 = new bool[1]
          {
            true
          });
          if (flagArray39[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray39[0]), typeof (int));
          string str10 = Conversions.ToString(NewLateBinding.LateGet(Instance36, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local39.Type = str10;
          ref SAP_Module.Opaques local40 = ref dwelling.Walls[index6];
          object[] objArray40;
          bool[] flagArray40;
          object Instance37 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray40 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray40 = new bool[1]
          {
            true
          });
          if (flagArray40[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray40[0]), typeof (int));
          double single26 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance37, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local40.Area = (float) single26;
          ref SAP_Module.Opaques local41 = ref dwelling.Walls[index6];
          object[] objArray41;
          bool[] flagArray41;
          object Instance38 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray41 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray41 = new bool[1]
          {
            true
          });
          if (flagArray41[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray41[0]), typeof (int));
          double single27 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance38, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local41.U_Value = (float) single27;
          ref SAP_Module.Opaques local42 = ref dwelling.Walls[index6];
          object[] objArray42;
          bool[] flagArray42;
          object Instance39 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray42 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray42 = new bool[1]
          {
            true
          });
          if (flagArray42[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray42[0]), typeof (int));
          double single28 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance39, (System.Type) null, "Ru", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local42.Ru = (float) single28;
          ref SAP_Module.Opaques local43 = ref dwelling.Walls[index6];
          object[] objArray43;
          bool[] flagArray43;
          object Instance40 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray43 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray43 = new bool[1]
          {
            true
          });
          if (flagArray43[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray43[0]), typeof (int));
          int num9 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance40, (System.Type) null, "Curtain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
          local43.Curtain = num9 != 0;
          ref SAP_Module.Opaques local44 = ref dwelling.Walls[index6];
          object[] objArray44;
          bool[] flagArray44;
          object Instance41 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray44 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray44 = new bool[1]
          {
            true
          });
          if (flagArray44[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray44[0]), typeof (int));
          string str11 = Conversions.ToString(NewLateBinding.LateGet(Instance41, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local44.Construction = str11;
          ref SAP_Module.Opaques local45 = ref dwelling.Walls[index6];
          object[] objArray45;
          bool[] flagArray45;
          object Instance42 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray45 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray45 = new bool[1]
          {
            true
          });
          if (flagArray45[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray45[0]), typeof (int));
          int num10 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance42, (System.Type) null, "UValueSelected", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
          local45.UValueSelected = num10 != 0;
          ref SAP_Module.Opaques local46 = ref dwelling.Walls[index6];
          object[] objArray46;
          bool[] flagArray46;
          object Instance43 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray46 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray46 = new bool[1]
          {
            true
          });
          if (flagArray46[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray46[0]), typeof (int));
          int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance43, (System.Type) null, "UValueSelection", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local46.UValueSelection = integer;
          ref SAP_Module.Opaques local47 = ref dwelling.Walls[index6];
          object[] objArray47;
          bool[] flagArray47;
          object Instance44 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray47 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray47 = new bool[1]
          {
            true
          });
          if (flagArray47[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray47[0]), typeof (int));
          double single29 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance44, (System.Type) null, "K", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local47.K = (float) single29;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          ref SAP_Module.Dims local48 = ref dwelling.Walls[index6].Dims;
          object[] objArray48;
          bool[] flagArray48;
          object Instance45 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray48 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray48 = new bool[1]
          {
            true
          });
          if (flagArray48[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray48[0]), typeof (int));
          double single30 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance45, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local48.L1 = (float) single30;
          ref SAP_Module.Dims local49 = ref dwelling.Walls[index6].Dims;
          object[] objArray49;
          bool[] flagArray49;
          object Instance46 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray49 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray49 = new bool[1]
          {
            true
          });
          if (flagArray49[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray49[0]), typeof (int));
          double single31 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance46, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local49.W1 = (float) single31;
          ref SAP_Module.Dims local50 = ref dwelling.Walls[index6].Dims;
          object[] objArray50;
          bool[] flagArray50;
          object Instance47 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray50 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray50 = new bool[1]
          {
            true
          });
          if (flagArray50[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray50[0]), typeof (int));
          double single32 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance47, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local50.L2 = (float) single32;
          ref SAP_Module.Dims local51 = ref dwelling.Walls[index6].Dims;
          object[] objArray51;
          bool[] flagArray51;
          object Instance48 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray51 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray51 = new bool[1]
          {
            true
          });
          if (flagArray51[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray51[0]), typeof (int));
          double single33 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance48, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local51.W2 = (float) single33;
          ref SAP_Module.Dims local52 = ref dwelling.Walls[index6].Dims;
          object[] objArray52;
          bool[] flagArray52;
          object Instance49 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray52 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray52 = new bool[1]
          {
            true
          });
          if (flagArray52[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray52[0]), typeof (int));
          double single34 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance49, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local52.L3 = (float) single34;
          ref SAP_Module.Dims local53 = ref dwelling.Walls[index6].Dims;
          object[] objArray53;
          bool[] flagArray53;
          object Instance50 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray53 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray53 = new bool[1]
          {
            true
          });
          if (flagArray53[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray53[0]), typeof (int));
          double single35 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance50, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local53.W3 = (float) single35;
          ref SAP_Module.Dims local54 = ref dwelling.Walls[index6].Dims;
          object[] objArray54;
          bool[] flagArray54;
          object Instance51 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray54 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray54 = new bool[1]
          {
            true
          });
          if (flagArray54[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray54[0]), typeof (int));
          double single36 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance51, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local54.L4 = (float) single36;
          ref SAP_Module.Dims local55 = ref dwelling.Walls[index6].Dims;
          object[] objArray55;
          bool[] flagArray55;
          object Instance52 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray55 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray55 = new bool[1]
          {
            true
          });
          if (flagArray55[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray55[0]), typeof (int));
          double single37 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance52, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local55.W4 = (float) single37;
          ref SAP_Module.Dims local56 = ref dwelling.Walls[index6].Dims;
          object[] objArray56;
          bool[] flagArray56;
          object Instance53 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray56 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray56 = new bool[1]
          {
            true
          });
          if (flagArray56[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray56[0]), typeof (int));
          double single38 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance53, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local56.L5 = (float) single38;
          ref SAP_Module.Dims local57 = ref dwelling.Walls[index6].Dims;
          object[] objArray57;
          bool[] flagArray57;
          object Instance54 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray57 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray57 = new bool[1]
          {
            true
          });
          if (flagArray57[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray57[0]), typeof (int));
          double single39 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance54, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local57.W5 = (float) single39;
          ref SAP_Module.Dims local58 = ref dwelling.Walls[index6].Dims;
          object[] objArray58;
          bool[] flagArray58;
          object Instance55 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray58 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray58 = new bool[1]
          {
            true
          });
          if (flagArray58[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray58[0]), typeof (int));
          double single40 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance55, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local58.L6 = (float) single40;
          ref SAP_Module.Dims local59 = ref dwelling.Walls[index6].Dims;
          object[] objArray59;
          bool[] flagArray59;
          object Instance56 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Walls", objArray59 = new object[1]
          {
            (object) index6
          }, (string[]) null, (System.Type[]) null, flagArray59 = new bool[1]
          {
            true
          });
          if (flagArray59[0])
            index6 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray59[0]), typeof (int));
          double single41 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance56, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local59.W6 = (float) single41;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index6; }
      }
      dwelling.NoofIWalls = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofIWalls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.IWalls = new SAP_Module.PartyElements[checked (dwelling.NoofIWalls - 1 + 1)];
      int num11 = checked (dwelling.NoofIWalls - 1);
      int index7 = 0;
      while (index7 <= num11)
      {
        try
        {
          ref SAP_Module.PartyElements local60 = ref dwelling.IWalls[index7];
          object[] objArray60;
          bool[] flagArray60;
          object Instance57 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "IWalls", objArray60 = new object[1]
          {
            (object) index7
          }, (string[]) null, (System.Type[]) null, flagArray60 = new bool[1]
          {
            true
          });
          if (flagArray60[0])
            index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray60[0]), typeof (int));
          string str12 = Conversions.ToString(NewLateBinding.LateGet(Instance57, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local60.Name = str12;
          ref SAP_Module.PartyElements local61 = ref dwelling.IWalls[index7];
          object[] objArray61;
          bool[] flagArray61;
          object Instance58 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "IWalls", objArray61 = new object[1]
          {
            (object) index7
          }, (string[]) null, (System.Type[]) null, flagArray61 = new bool[1]
          {
            true
          });
          if (flagArray61[0])
            index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray61[0]), typeof (int));
          string str13 = Conversions.ToString(NewLateBinding.LateGet(Instance58, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local61.Construction = str13;
          ref SAP_Module.PartyElements local62 = ref dwelling.IWalls[index7];
          object[] objArray62;
          bool[] flagArray62;
          object Instance59 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "IWalls", objArray62 = new object[1]
          {
            (object) index7
          }, (string[]) null, (System.Type[]) null, flagArray62 = new bool[1]
          {
            true
          });
          if (flagArray62[0])
            index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray62[0]), typeof (int));
          double single42 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance59, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local62.Area = (float) single42;
          ref SAP_Module.PartyElements local63 = ref dwelling.IWalls[index7];
          object[] objArray63;
          bool[] flagArray63;
          object Instance60 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "IWalls", objArray63 = new object[1]
          {
            (object) index7
          }, (string[]) null, (System.Type[]) null, flagArray63 = new bool[1]
          {
            true
          });
          if (flagArray63[0])
            index7 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray63[0]), typeof (int));
          double single43 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance60, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local63.K = (float) single43;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index7; }
      }
      dwelling.NoofPWalls = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofPWalls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.PWalls = new SAP_Module.PartyWall[checked (dwelling.NoofPWalls - 1 + 1)];
      int num12 = checked (dwelling.NoofPWalls - 1);
      int index8 = 0;
      while (index8 <= num12)
      {
        try
        {
          ref SAP_Module.PartyWall local64 = ref dwelling.PWalls[index8];
          object[] objArray64;
          bool[] flagArray64;
          object Instance61 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray64 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray64 = new bool[1]
          {
            true
          });
          if (flagArray64[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray64[0]), typeof (int));
          string str14 = Conversions.ToString(NewLateBinding.LateGet(Instance61, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local64.Name = str14;
          ref SAP_Module.PartyWall local65 = ref dwelling.PWalls[index8];
          object[] objArray65;
          bool[] flagArray65;
          object Instance62 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray65 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray65 = new bool[1]
          {
            true
          });
          if (flagArray65[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray65[0]), typeof (int));
          string str15 = Conversions.ToString(NewLateBinding.LateGet(Instance62, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local65.Construction = str15;
          ref SAP_Module.PartyWall local66 = ref dwelling.PWalls[index8];
          object[] objArray66;
          bool[] flagArray66;
          object Instance63 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray66 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray66 = new bool[1]
          {
            true
          });
          if (flagArray66[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray66[0]), typeof (int));
          double single44 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance63, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local66.Area = (float) single44;
          ref SAP_Module.PartyWall local67 = ref dwelling.PWalls[index8];
          object[] objArray67;
          bool[] flagArray67;
          object Instance64 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray67 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray67 = new bool[1]
          {
            true
          });
          if (flagArray67[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray67[0]), typeof (int));
          double single45 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance64, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local67.K = (float) single45;
          ref SAP_Module.PartyWall local68 = ref dwelling.PWalls[index8];
          object[] objArray68;
          bool[] flagArray68;
          object Instance65 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray68 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray68 = new bool[1]
          {
            true
          });
          if (flagArray68[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray68[0]), typeof (int));
          double single46 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance65, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local68.U_Value = (float) single46;
          ref SAP_Module.PartyWall local69 = ref dwelling.PWalls[index8];
          object[] objArray69;
          bool[] flagArray69;
          object Instance66 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray69 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray69 = new bool[1]
          {
            true
          });
          if (flagArray69[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray69[0]), typeof (int));
          string str16 = Conversions.ToString(NewLateBinding.LateGet(Instance66, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local69.Type = str16;
          ref SAP_Module.PartyWall local70 = ref dwelling.PWalls[index8];
          object[] objArray70;
          bool[] flagArray70;
          object Instance67 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PWalls", objArray70 = new object[1]
          {
            (object) index8
          }, (string[]) null, (System.Type[]) null, flagArray70 = new bool[1]
          {
            true
          });
          if (flagArray70[0])
            index8 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray70[0]), typeof (int));
          string str17 = Conversions.ToString(NewLateBinding.LateGet(Instance67, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local70.Type = str17;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index8; }
      }
      dwelling.NoofRoofs = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofRoofs", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Roofs = new SAP_Module.Opaques[checked (dwelling.NoofRoofs - 1 + 1)];
      int num13 = checked (dwelling.NoofRoofs - 1);
      int index9 = 0;
      while (index9 <= num13)
      {
        ref SAP_Module.Opaques local71 = ref dwelling.Roofs[index9];
        object[] objArray71;
        bool[] flagArray71;
        object Instance68 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray71 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray71 = new bool[1]
        {
          true
        });
        if (flagArray71[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray71[0]), typeof (int));
        string str18 = Conversions.ToString(NewLateBinding.LateGet(Instance68, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local71.Name = str18;
        ref SAP_Module.Opaques local72 = ref dwelling.Roofs[index9];
        object[] objArray72;
        bool[] flagArray72;
        object Instance69 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray72 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray72 = new bool[1]
        {
          true
        });
        if (flagArray72[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray72[0]), typeof (int));
        string str19 = Conversions.ToString(NewLateBinding.LateGet(Instance69, (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local72.Type = str19;
        ref SAP_Module.Opaques local73 = ref dwelling.Roofs[index9];
        object[] objArray73;
        bool[] flagArray73;
        object Instance70 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray73 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray73 = new bool[1]
        {
          true
        });
        if (flagArray73[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray73[0]), typeof (int));
        double single47 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance70, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local73.Area = (float) single47;
        ref SAP_Module.Opaques local74 = ref dwelling.Roofs[index9];
        object[] objArray74;
        bool[] flagArray74;
        object Instance71 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray74 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray74 = new bool[1]
        {
          true
        });
        if (flagArray74[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray74[0]), typeof (int));
        double single48 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance71, (System.Type) null, "U_Value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local74.U_Value = (float) single48;
        ref SAP_Module.Opaques local75 = ref dwelling.Roofs[index9];
        object[] objArray75;
        bool[] flagArray75;
        object Instance72 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray75 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray75 = new bool[1]
        {
          true
        });
        if (flagArray75[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray75[0]), typeof (int));
        double single49 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance72, (System.Type) null, "Ru", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local75.Ru = (float) single49;
        ref SAP_Module.Opaques local76 = ref dwelling.Roofs[index9];
        object[] objArray76;
        bool[] flagArray76;
        object Instance73 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray76 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray76 = new bool[1]
        {
          true
        });
        if (flagArray76[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray76[0]), typeof (int));
        double single50 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance73, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local76.K = (float) single50;
        ref SAP_Module.Opaques local77 = ref dwelling.Roofs[index9];
        object[] objArray77;
        bool[] flagArray77;
        object Instance74 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray77 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray77 = new bool[1]
        {
          true
        });
        if (flagArray77[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray77[0]), typeof (int));
        string str20 = Conversions.ToString(NewLateBinding.LateGet(Instance74, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local77.Name = str20;
        ref SAP_Module.Opaques local78 = ref dwelling.Roofs[index9];
        object[] objArray78;
        bool[] flagArray78;
        object Instance75 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray78 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray78 = new bool[1]
        {
          true
        });
        if (flagArray78[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray78[0]), typeof (int));
        string str21 = Conversions.ToString(NewLateBinding.LateGet(Instance75, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local78.Construction = str21;
        ref SAP_Module.Opaques local79 = ref dwelling.Roofs[index9];
        object[] objArray79;
        bool[] flagArray79;
        object Instance76 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray79 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray79 = new bool[1]
        {
          true
        });
        if (flagArray79[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray79[0]), typeof (int));
        int num14 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance76, (System.Type) null, "UValueSelected", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
        local79.UValueSelected = num14 != 0;
        ref SAP_Module.Opaques local80 = ref dwelling.Roofs[index9];
        object[] objArray80;
        bool[] flagArray80;
        object Instance77 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray80 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray80 = new bool[1]
        {
          true
        });
        if (flagArray80[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray80[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance77, (System.Type) null, "UValueSelection", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local80.UValueSelection = integer;
        ref SAP_Module.Opaques local81 = ref dwelling.Roofs[index9];
        object[] objArray81;
        bool[] flagArray81;
        object Instance78 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray81 = new object[1]
        {
          (object) index9
        }, (string[]) null, (System.Type[]) null, flagArray81 = new bool[1]
        {
          true
        });
        if (flagArray81[0])
          index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray81[0]), typeof (int));
        double single51 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance78, (System.Type) null, "K", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local81.K = (float) single51;
        try
        {
          ref SAP_Module.Dims local82 = ref dwelling.Roofs[index9].Dims;
          object[] objArray82;
          bool[] flagArray82;
          object Instance79 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray82 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray82 = new bool[1]
          {
            true
          });
          if (flagArray82[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray82[0]), typeof (int));
          double single52 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance79, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local82.L1 = (float) single52;
          ref SAP_Module.Dims local83 = ref dwelling.Roofs[index9].Dims;
          object[] objArray83;
          bool[] flagArray83;
          object Instance80 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray83 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray83 = new bool[1]
          {
            true
          });
          if (flagArray83[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray83[0]), typeof (int));
          double single53 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance80, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local83.W1 = (float) single53;
          ref SAP_Module.Dims local84 = ref dwelling.Roofs[index9].Dims;
          object[] objArray84;
          bool[] flagArray84;
          object Instance81 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray84 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray84 = new bool[1]
          {
            true
          });
          if (flagArray84[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray84[0]), typeof (int));
          double single54 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance81, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local84.L2 = (float) single54;
          ref SAP_Module.Dims local85 = ref dwelling.Roofs[index9].Dims;
          object[] objArray85;
          bool[] flagArray85;
          object Instance82 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray85 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray85 = new bool[1]
          {
            true
          });
          if (flagArray85[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray85[0]), typeof (int));
          double single55 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance82, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local85.W2 = (float) single55;
          ref SAP_Module.Dims local86 = ref dwelling.Roofs[index9].Dims;
          object[] objArray86;
          bool[] flagArray86;
          object Instance83 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray86 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray86 = new bool[1]
          {
            true
          });
          if (flagArray86[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray86[0]), typeof (int));
          double single56 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance83, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local86.L3 = (float) single56;
          ref SAP_Module.Dims local87 = ref dwelling.Roofs[index9].Dims;
          object[] objArray87;
          bool[] flagArray87;
          object Instance84 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray87 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray87 = new bool[1]
          {
            true
          });
          if (flagArray87[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray87[0]), typeof (int));
          double single57 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance84, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local87.W3 = (float) single57;
          ref SAP_Module.Dims local88 = ref dwelling.Roofs[index9].Dims;
          object[] objArray88;
          bool[] flagArray88;
          object Instance85 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray88 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray88 = new bool[1]
          {
            true
          });
          if (flagArray88[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray88[0]), typeof (int));
          double single58 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance85, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local88.L4 = (float) single58;
          ref SAP_Module.Dims local89 = ref dwelling.Roofs[index9].Dims;
          object[] objArray89;
          bool[] flagArray89;
          object Instance86 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray89 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray89 = new bool[1]
          {
            true
          });
          if (flagArray89[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray89[0]), typeof (int));
          double single59 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance86, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local89.W4 = (float) single59;
          ref SAP_Module.Dims local90 = ref dwelling.Roofs[index9].Dims;
          object[] objArray90;
          bool[] flagArray90;
          object Instance87 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray90 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray90 = new bool[1]
          {
            true
          });
          if (flagArray90[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray90[0]), typeof (int));
          double single60 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance87, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local90.L5 = (float) single60;
          ref SAP_Module.Dims local91 = ref dwelling.Roofs[index9].Dims;
          object[] objArray91;
          bool[] flagArray91;
          object Instance88 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray91 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray91 = new bool[1]
          {
            true
          });
          if (flagArray91[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray91[0]), typeof (int));
          double single61 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance88, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local91.W5 = (float) single61;
          ref SAP_Module.Dims local92 = ref dwelling.Roofs[index9].Dims;
          object[] objArray92;
          bool[] flagArray92;
          object Instance89 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray92 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray92 = new bool[1]
          {
            true
          });
          if (flagArray92[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray92[0]), typeof (int));
          double single62 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance89, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local92.L6 = (float) single62;
          ref SAP_Module.Dims local93 = ref dwelling.Roofs[index9].Dims;
          object[] objArray93;
          bool[] flagArray93;
          object Instance90 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Roofs", objArray93 = new object[1]
          {
            (object) index9
          }, (string[]) null, (System.Type[]) null, flagArray93 = new bool[1]
          {
            true
          });
          if (flagArray93[0])
            index9 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray93[0]), typeof (int));
          double single63 = (double) Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(Instance90, (System.Type) null, "Dims", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "L1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local93.W6 = (float) single63;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index9; }
      }
      dwelling.NoofICeilings = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofICeilings", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.ICeilings = new SAP_Module.PartyElements[checked (dwelling.NoofICeilings - 1 + 1)];
      int num15 = checked (dwelling.NoofICeilings - 1);
      int index10 = 0;
      while (index10 <= num15)
      {
        try
        {
          ref SAP_Module.PartyElements local94 = ref dwelling.ICeilings[index10];
          object[] objArray94;
          bool[] flagArray94;
          object Instance91 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "ICeilings", objArray94 = new object[1]
          {
            (object) index10
          }, (string[]) null, (System.Type[]) null, flagArray94 = new bool[1]
          {
            true
          });
          if (flagArray94[0])
            index10 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray94[0]), typeof (int));
          string str22 = Conversions.ToString(NewLateBinding.LateGet(Instance91, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local94.Name = str22;
          ref SAP_Module.PartyElements local95 = ref dwelling.ICeilings[index10];
          object[] objArray95;
          bool[] flagArray95;
          object Instance92 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "ICeilings", objArray95 = new object[1]
          {
            (object) index10
          }, (string[]) null, (System.Type[]) null, flagArray95 = new bool[1]
          {
            true
          });
          if (flagArray95[0])
            index10 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray95[0]), typeof (int));
          string str23 = Conversions.ToString(NewLateBinding.LateGet(Instance92, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local95.Construction = str23;
          ref SAP_Module.PartyElements local96 = ref dwelling.ICeilings[index10];
          object[] objArray96;
          bool[] flagArray96;
          object Instance93 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "ICeilings", objArray96 = new object[1]
          {
            (object) index10
          }, (string[]) null, (System.Type[]) null, flagArray96 = new bool[1]
          {
            true
          });
          if (flagArray96[0])
            index10 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray96[0]), typeof (int));
          double single64 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance93, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local96.Area = (float) single64;
          ref SAP_Module.PartyElements local97 = ref dwelling.ICeilings[index10];
          object[] objArray97;
          bool[] flagArray97;
          object Instance94 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "ICeilings", objArray97 = new object[1]
          {
            (object) index10
          }, (string[]) null, (System.Type[]) null, flagArray97 = new bool[1]
          {
            true
          });
          if (flagArray97[0])
            index10 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray97[0]), typeof (int));
          double single65 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance94, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local97.K = (float) single65;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index10; }
      }
      dwelling.NoofPCeilings = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofPCeilings", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.PCeilings = new SAP_Module.PartyElements[checked (dwelling.NoofPCeilings - 1 + 1)];
      int num16 = checked (dwelling.NoofPCeilings - 1);
      int index11 = 0;
      while (index11 <= num16)
      {
        try
        {
          ref SAP_Module.PartyElements local98 = ref dwelling.PCeilings[index11];
          object[] objArray98;
          bool[] flagArray98;
          object Instance95 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PCeilings", objArray98 = new object[1]
          {
            (object) index11
          }, (string[]) null, (System.Type[]) null, flagArray98 = new bool[1]
          {
            true
          });
          if (flagArray98[0])
            index11 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray98[0]), typeof (int));
          string str24 = Conversions.ToString(NewLateBinding.LateGet(Instance95, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local98.Name = str24;
          ref SAP_Module.PartyElements local99 = ref dwelling.PCeilings[index11];
          object[] objArray99;
          bool[] flagArray99;
          object Instance96 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PCeilings", objArray99 = new object[1]
          {
            (object) index11
          }, (string[]) null, (System.Type[]) null, flagArray99 = new bool[1]
          {
            true
          });
          if (flagArray99[0])
            index11 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray99[0]), typeof (int));
          string str25 = Conversions.ToString(NewLateBinding.LateGet(Instance96, (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local99.Construction = str25;
          ref SAP_Module.PartyElements local100 = ref dwelling.PCeilings[index11];
          object[] objArray100;
          bool[] flagArray100;
          object Instance97 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PCeilings", objArray100 = new object[1]
          {
            (object) index11
          }, (string[]) null, (System.Type[]) null, flagArray100 = new bool[1]
          {
            true
          });
          if (flagArray100[0])
            index11 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray100[0]), typeof (int));
          double single66 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance97, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local100.Area = (float) single66;
          ref SAP_Module.PartyElements local101 = ref dwelling.PCeilings[index11];
          object[] objArray101;
          bool[] flagArray101;
          object Instance98 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "PCeilings", objArray101 = new object[1]
          {
            (object) index11
          }, (string[]) null, (System.Type[]) null, flagArray101 = new bool[1]
          {
            true
          });
          if (flagArray101[0])
            index11 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray101[0]), typeof (int));
          double single67 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance98, (System.Type) null, "k", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local101.K = (float) single67;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index11; }
      }
      dwelling.NoofDoors = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofDoors", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Doors = new SAP_Module.Door[checked (dwelling.NoofDoors - 1 + 1)];
      int num17 = checked (dwelling.NoofDoors - 1);
      int index12 = 0;
      while (index12 <= num17)
      {
        ref SAP_Module.Door local102 = ref dwelling.Doors[index12];
        object[] objArray102;
        bool[] flagArray102;
        object Instance99 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray102 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray102 = new bool[1]
        {
          true
        });
        if (flagArray102[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray102[0]), typeof (int));
        string str26 = Conversions.ToString(NewLateBinding.LateGet(Instance99, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local102.Name = str26;
        ref SAP_Module.Door local103 = ref dwelling.Doors[index12];
        object[] objArray103;
        bool[] flagArray103;
        object Instance100 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray103 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray103 = new bool[1]
        {
          true
        });
        if (flagArray103[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray103[0]), typeof (int));
        string str27 = Conversions.ToString(NewLateBinding.LateGet(Instance100, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local103.Location = str27;
        object[] objArray104;
        bool[] flagArray104;
        object Instance101 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray104 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray104 = new bool[1]
        {
          true
        });
        if (flagArray104[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray104[0]), typeof (int));
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance101, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "SAP 2009", false))
        {
          dwelling.Doors[index12].UValueSource = "SAP 2012";
        }
        else
        {
          ref SAP_Module.Door local104 = ref dwelling.Doors[index12];
          object[] objArray105;
          bool[] flagArray105;
          object Instance102 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray105 = new object[1]
          {
            (object) index12
          }, (string[]) null, (System.Type[]) null, flagArray105 = new bool[1]
          {
            true
          });
          if (flagArray105[0])
            index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray105[0]), typeof (int));
          string str28 = Conversions.ToString(NewLateBinding.LateGet(Instance102, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local104.UValueSource = str28;
        }
        ref SAP_Module.Door local105 = ref dwelling.Doors[index12];
        object[] objArray106;
        bool[] flagArray106;
        object Instance103 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray106 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray106 = new bool[1]
        {
          true
        });
        if (flagArray106[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray106[0]), typeof (int));
        string str29 = Conversions.ToString(NewLateBinding.LateGet(Instance103, (System.Type) null, "DoorType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local105.DoorType = str29;
        ref SAP_Module.Door local106 = ref dwelling.Doors[index12];
        object[] objArray107;
        bool[] flagArray107;
        object Instance104 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray107 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray107 = new bool[1]
        {
          true
        });
        if (flagArray107[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray107[0]), typeof (int));
        string str30 = Conversions.ToString(NewLateBinding.LateGet(Instance104, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local106.Orientation = str30;
        ref SAP_Module.Door local107 = ref dwelling.Doors[index12];
        object[] objArray108;
        bool[] flagArray108;
        object Instance105 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray108 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray108 = new bool[1]
        {
          true
        });
        if (flagArray108[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray108[0]), typeof (int));
        string str31 = Conversions.ToString(NewLateBinding.LateGet(Instance105, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local107.Overshading = str31;
        ref SAP_Module.Door local108 = ref dwelling.Doors[index12];
        object[] objArray109;
        bool[] flagArray109;
        object Instance106 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray109 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray109 = new bool[1]
        {
          true
        });
        if (flagArray109[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray109[0]), typeof (int));
        string str32 = Conversions.ToString(NewLateBinding.LateGet(Instance106, (System.Type) null, "GlazingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local108.GlazingType = str32;
        ref SAP_Module.Door local109 = ref dwelling.Doors[index12];
        object[] objArray110;
        bool[] flagArray110;
        object Instance107 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray110 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray110 = new bool[1]
        {
          true
        });
        if (flagArray110[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray110[0]), typeof (int));
        string str33 = Conversions.ToString(NewLateBinding.LateGet(Instance107, (System.Type) null, "AirGap", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local109.AirGap = str33;
        ref SAP_Module.Door local110 = ref dwelling.Doors[index12];
        object[] objArray111;
        bool[] flagArray111;
        object Instance108 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray111 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray111 = new bool[1]
        {
          true
        });
        if (flagArray111[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray111[0]), typeof (int));
        string str34 = Conversions.ToString(NewLateBinding.LateGet(Instance108, (System.Type) null, "FrameType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local110.FrameType = str34;
        ref SAP_Module.Door local111 = ref dwelling.Doors[index12];
        object[] objArray112;
        bool[] flagArray112;
        object Instance109 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray112 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray112 = new bool[1]
        {
          true
        });
        if (flagArray112[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray112[0]), typeof (int));
        string str35 = Conversions.ToString(NewLateBinding.LateGet(Instance109, (System.Type) null, "ThermalBreak", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local111.ThermalBreak = str35;
        ref SAP_Module.Door local112 = ref dwelling.Doors[index12];
        object[] objArray113;
        bool[] flagArray113;
        object Instance110 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray113 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray113 = new bool[1]
        {
          true
        });
        if (flagArray113[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray113[0]), typeof (int));
        double single68 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance110, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local112.Area = (float) single68;
        ref SAP_Module.Door local113 = ref dwelling.Doors[index12];
        object[] objArray114;
        bool[] flagArray114;
        object Instance111 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray114 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray114 = new bool[1]
        {
          true
        });
        if (flagArray114[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray114[0]), typeof (int));
        double single69 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance111, (System.Type) null, "Width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local113.Width = (float) single69;
        ref SAP_Module.Door local114 = ref dwelling.Doors[index12];
        object[] objArray115;
        bool[] flagArray115;
        object Instance112 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray115 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray115 = new bool[1]
        {
          true
        });
        if (flagArray115[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray115[0]), typeof (int));
        double single70 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance112, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local114.Height = (float) single70;
        ref SAP_Module.Door local115 = ref dwelling.Doors[index12];
        object[] objArray116;
        bool[] flagArray116;
        object Instance113 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray116 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray116 = new bool[1]
        {
          true
        });
        if (flagArray116[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray116[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance113, (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local115.Count = integer;
        ref SAP_Module.Door local116 = ref dwelling.Doors[index12];
        object[] objArray117;
        bool[] flagArray117;
        object Instance114 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray117 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray117 = new bool[1]
        {
          true
        });
        if (flagArray117[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray117[0]), typeof (int));
        double single71 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance114, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local116.g = (float) single71;
        ref SAP_Module.Door local117 = ref dwelling.Doors[index12];
        object[] objArray118;
        bool[] flagArray118;
        object Instance115 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray118 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray118 = new bool[1]
        {
          true
        });
        if (flagArray118[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray118[0]), typeof (int));
        double single72 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance115, (System.Type) null, "FF", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local117.FF = (float) single72;
        ref SAP_Module.Door local118 = ref dwelling.Doors[index12];
        object[] objArray119;
        bool[] flagArray119;
        object Instance116 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray119 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray119 = new bool[1]
        {
          true
        });
        if (flagArray119[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray119[0]), typeof (int));
        double single73 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance116, (System.Type) null, "U", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local118.U = (float) single73;
        ref SAP_Module.Door local119 = ref dwelling.Doors[index12];
        object[] objArray120;
        bool[] flagArray120;
        object Instance117 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray120 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray120 = new bool[1]
        {
          true
        });
        if (flagArray120[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray120[0]), typeof (int));
        double single74 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance117, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local119.g = (float) single74;
        ref SAP_Module.Door local120 = ref dwelling.Doors[index12];
        object[] objArray121;
        bool[] flagArray121;
        object Instance118 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Doors", objArray121 = new object[1]
        {
          (object) index12
        }, (string[]) null, (System.Type[]) null, flagArray121 = new bool[1]
        {
          true
        });
        if (flagArray121[0])
          index12 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray121[0]), typeof (int));
        string str36 = Conversions.ToString(NewLateBinding.LateGet(Instance118, (System.Type) null, "OpeningType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local120.OpeningType = str36;
        checked { ++index12; }
      }
      dwelling.NoofWindows = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofWindows", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Windows = new SAP_Module.Window[checked (dwelling.NoofWindows - 1 + 1)];
      int num18 = checked (dwelling.NoofWindows - 1);
      int index13 = 0;
      while (index13 <= num18)
      {
        ref SAP_Module.Window local121 = ref dwelling.Windows[index13];
        object[] objArray122;
        bool[] flagArray122;
        object Instance119 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray122 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray122 = new bool[1]
        {
          true
        });
        if (flagArray122[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray122[0]), typeof (int));
        string str37 = Conversions.ToString(NewLateBinding.LateGet(Instance119, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local121.Name = str37;
        ref SAP_Module.Window local122 = ref dwelling.Windows[index13];
        object[] objArray123;
        bool[] flagArray123;
        object Instance120 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray123 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray123 = new bool[1]
        {
          true
        });
        if (flagArray123[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray123[0]), typeof (int));
        string str38 = Conversions.ToString(NewLateBinding.LateGet(Instance120, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local122.Location = str38;
        object[] objArray124;
        bool[] flagArray124;
        object Instance121 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray124 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray124 = new bool[1]
        {
          true
        });
        if (flagArray124[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray124[0]), typeof (int));
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance121, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "SAP 2009", false))
        {
          dwelling.Windows[index13].UValueSource = "SAP 2012";
        }
        else
        {
          ref SAP_Module.Window local123 = ref dwelling.Windows[index13];
          object[] objArray125;
          bool[] flagArray125;
          object Instance122 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray125 = new object[1]
          {
            (object) index13
          }, (string[]) null, (System.Type[]) null, flagArray125 = new bool[1]
          {
            true
          });
          if (flagArray125[0])
            index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray125[0]), typeof (int));
          string str39 = Conversions.ToString(NewLateBinding.LateGet(Instance122, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local123.UValueSource = str39;
        }
        ref SAP_Module.Window local124 = ref dwelling.Windows[index13];
        object[] objArray126;
        bool[] flagArray126;
        object Instance123 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray126 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray126 = new bool[1]
        {
          true
        });
        if (flagArray126[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray126[0]), typeof (int));
        string str40 = Conversions.ToString(NewLateBinding.LateGet(Instance123, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local124.Orientation = str40;
        ref SAP_Module.Window local125 = ref dwelling.Windows[index13];
        object[] objArray127;
        bool[] flagArray127;
        object Instance124 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray127 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray127 = new bool[1]
        {
          true
        });
        if (flagArray127[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray127[0]), typeof (int));
        string str41 = Conversions.ToString(NewLateBinding.LateGet(Instance124, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local125.Overshading = str41;
        ref SAP_Module.Window local126 = ref dwelling.Windows[index13];
        object[] objArray128;
        bool[] flagArray128;
        object Instance125 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray128 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray128 = new bool[1]
        {
          true
        });
        if (flagArray128[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray128[0]), typeof (int));
        string str42 = Conversions.ToString(NewLateBinding.LateGet(Instance125, (System.Type) null, "GlazingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local126.GlazingType = str42;
        ref SAP_Module.Window local127 = ref dwelling.Windows[index13];
        object[] objArray129;
        bool[] flagArray129;
        object Instance126 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray129 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray129 = new bool[1]
        {
          true
        });
        if (flagArray129[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray129[0]), typeof (int));
        string str43 = Conversions.ToString(NewLateBinding.LateGet(Instance126, (System.Type) null, "AirGap", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local127.AirGap = str43;
        ref SAP_Module.Window local128 = ref dwelling.Windows[index13];
        object[] objArray130;
        bool[] flagArray130;
        object Instance127 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray130 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray130 = new bool[1]
        {
          true
        });
        if (flagArray130[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray130[0]), typeof (int));
        string str44 = Conversions.ToString(NewLateBinding.LateGet(Instance127, (System.Type) null, "FrameType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local128.FrameType = str44;
        ref SAP_Module.Window local129 = ref dwelling.Windows[index13];
        object[] objArray131;
        bool[] flagArray131;
        object Instance128 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray131 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray131 = new bool[1]
        {
          true
        });
        if (flagArray131[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray131[0]), typeof (int));
        string str45 = Conversions.ToString(NewLateBinding.LateGet(Instance128, (System.Type) null, "ThermalBreak", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local129.ThermalBreak = str45;
        ref SAP_Module.Window local130 = ref dwelling.Windows[index13];
        object[] objArray132;
        bool[] flagArray132;
        object Instance129 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray132 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray132 = new bool[1]
        {
          true
        });
        if (flagArray132[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray132[0]), typeof (int));
        double single75 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance129, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local130.Area = (float) single75;
        ref SAP_Module.Window local131 = ref dwelling.Windows[index13];
        object[] objArray133;
        bool[] flagArray133;
        object Instance130 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray133 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray133 = new bool[1]
        {
          true
        });
        if (flagArray133[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray133[0]), typeof (int));
        double single76 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance130, (System.Type) null, "Width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local131.Width = (float) single76;
        ref SAP_Module.Window local132 = ref dwelling.Windows[index13];
        object[] objArray134;
        bool[] flagArray134;
        object Instance131 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray134 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray134 = new bool[1]
        {
          true
        });
        if (flagArray134[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray134[0]), typeof (int));
        double single77 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance131, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local132.Height = (float) single77;
        ref SAP_Module.Window local133 = ref dwelling.Windows[index13];
        object[] objArray135;
        bool[] flagArray135;
        object Instance132 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray135 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray135 = new bool[1]
        {
          true
        });
        if (flagArray135[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray135[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance132, (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local133.Count = integer;
        ref SAP_Module.Window local134 = ref dwelling.Windows[index13];
        object[] objArray136;
        bool[] flagArray136;
        object Instance133 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray136 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray136 = new bool[1]
        {
          true
        });
        if (flagArray136[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray136[0]), typeof (int));
        double single78 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance133, (System.Type) null, "OverhangWidth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local134.OverhangWidth = (float) single78;
        ref SAP_Module.Window local135 = ref dwelling.Windows[index13];
        object[] objArray137;
        bool[] flagArray137;
        object Instance134 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray137 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray137 = new bool[1]
        {
          true
        });
        if (flagArray137[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray137[0]), typeof (int));
        double single79 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance134, (System.Type) null, "OverhangDepth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local135.OverhangDepth = (float) single79;
        ref SAP_Module.Window local136 = ref dwelling.Windows[index13];
        object[] objArray138;
        bool[] flagArray138;
        object Instance135 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray138 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray138 = new bool[1]
        {
          true
        });
        if (flagArray138[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray138[0]), typeof (int));
        string str46 = Conversions.ToString(NewLateBinding.LateGet(Instance135, (System.Type) null, "CurtainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local136.CurtainType = str46;
        ref SAP_Module.Window local137 = ref dwelling.Windows[index13];
        object[] objArray139;
        bool[] flagArray139;
        object Instance136 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray139 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray139 = new bool[1]
        {
          true
        });
        if (flagArray139[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray139[0]), typeof (int));
        double single80 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance136, (System.Type) null, "FractionClosed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local137.FractionClosed = (float) single80;
        ref SAP_Module.Window local138 = ref dwelling.Windows[index13];
        object[] objArray140;
        bool[] flagArray140;
        object Instance137 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray140 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray140 = new bool[1]
        {
          true
        });
        if (flagArray140[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray140[0]), typeof (int));
        double single81 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance137, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local138.g = (float) single81;
        ref SAP_Module.Window local139 = ref dwelling.Windows[index13];
        object[] objArray141;
        bool[] flagArray141;
        object Instance138 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray141 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray141 = new bool[1]
        {
          true
        });
        if (flagArray141[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray141[0]), typeof (int));
        double single82 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance138, (System.Type) null, "FF", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local139.FF = (float) single82;
        ref SAP_Module.Window local140 = ref dwelling.Windows[index13];
        object[] objArray142;
        bool[] flagArray142;
        object Instance139 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray142 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray142 = new bool[1]
        {
          true
        });
        if (flagArray142[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray142[0]), typeof (int));
        double single83 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance139, (System.Type) null, "U", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local140.U = (float) single83;
        ref SAP_Module.Window local141 = ref dwelling.Windows[index13];
        object[] objArray143;
        bool[] flagArray143;
        object Instance140 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "Windows", objArray143 = new object[1]
        {
          (object) index13
        }, (string[]) null, (System.Type[]) null, flagArray143 = new bool[1]
        {
          true
        });
        if (flagArray143[0])
          index13 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray143[0]), typeof (int));
        string str47 = Conversions.ToString(NewLateBinding.LateGet(Instance140, (System.Type) null, "OpeningType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local141.OpeningType = str47;
        checked { ++index13; }
      }
      dwelling.NoofRoofLights = Conversions.ToInteger(NewLateBinding.LateGet(SAP2009, (System.Type) null, "NoofRoofLights", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.RoofLights = new SAP_Module.RoofLight[checked (dwelling.NoofRoofLights - 1 + 1)];
      int num19 = checked (dwelling.NoofRoofLights - 1);
      int index14 = 0;
      while (index14 <= num19)
      {
        ref SAP_Module.RoofLight local142 = ref dwelling.RoofLights[index14];
        object[] objArray144;
        bool[] flagArray144;
        object Instance141 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray144 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray144 = new bool[1]
        {
          true
        });
        if (flagArray144[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray144[0]), typeof (int));
        string str48 = Conversions.ToString(NewLateBinding.LateGet(Instance141, (System.Type) null, "Name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local142.Name = str48;
        ref SAP_Module.RoofLight local143 = ref dwelling.RoofLights[index14];
        object[] objArray145;
        bool[] flagArray145;
        object Instance142 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray145 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray145 = new bool[1]
        {
          true
        });
        if (flagArray145[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray145[0]), typeof (int));
        string str49 = Conversions.ToString(NewLateBinding.LateGet(Instance142, (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local143.Location = str49;
        object[] objArray146;
        bool[] flagArray146;
        object Instance143 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray146 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray146 = new bool[1]
        {
          true
        });
        if (flagArray146[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray146[0]), typeof (int));
        if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Instance143, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "SAP 2009", false))
        {
          dwelling.RoofLights[index14].UValueSource = "SAP 2012";
        }
        else
        {
          ref SAP_Module.RoofLight local144 = ref dwelling.RoofLights[index14];
          object[] objArray147;
          bool[] flagArray147;
          object Instance144 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray147 = new object[1]
          {
            (object) index14
          }, (string[]) null, (System.Type[]) null, flagArray147 = new bool[1]
          {
            true
          });
          if (flagArray147[0])
            index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray147[0]), typeof (int));
          string str50 = Conversions.ToString(NewLateBinding.LateGet(Instance144, (System.Type) null, "UValueSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          local144.UValueSource = str50;
        }
        dwelling.RoofLights[index14].Pitch = 35f;
        ref SAP_Module.RoofLight local145 = ref dwelling.RoofLights[index14];
        object[] objArray148;
        bool[] flagArray148;
        object Instance145 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray148 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray148 = new bool[1]
        {
          true
        });
        if (flagArray148[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray148[0]), typeof (int));
        string str51 = Conversions.ToString(NewLateBinding.LateGet(Instance145, (System.Type) null, "Orientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local145.Orientation = str51;
        ref SAP_Module.RoofLight local146 = ref dwelling.RoofLights[index14];
        object[] objArray149;
        bool[] flagArray149;
        object Instance146 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray149 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray149 = new bool[1]
        {
          true
        });
        if (flagArray149[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray149[0]), typeof (int));
        string str52 = Conversions.ToString(NewLateBinding.LateGet(Instance146, (System.Type) null, "Overshading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local146.Overshading = str52;
        ref SAP_Module.RoofLight local147 = ref dwelling.RoofLights[index14];
        object[] objArray150;
        bool[] flagArray150;
        object Instance147 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray150 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray150 = new bool[1]
        {
          true
        });
        if (flagArray150[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray150[0]), typeof (int));
        string str53 = Conversions.ToString(NewLateBinding.LateGet(Instance147, (System.Type) null, "GlazingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local147.GlazingType = str53;
        ref SAP_Module.RoofLight local148 = ref dwelling.RoofLights[index14];
        object[] objArray151;
        bool[] flagArray151;
        object Instance148 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray151 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray151 = new bool[1]
        {
          true
        });
        if (flagArray151[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray151[0]), typeof (int));
        string str54 = Conversions.ToString(NewLateBinding.LateGet(Instance148, (System.Type) null, "AirGap", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local148.AirGap = str54;
        ref SAP_Module.RoofLight local149 = ref dwelling.RoofLights[index14];
        object[] objArray152;
        bool[] flagArray152;
        object Instance149 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray152 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray152 = new bool[1]
        {
          true
        });
        if (flagArray152[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray152[0]), typeof (int));
        string str55 = Conversions.ToString(NewLateBinding.LateGet(Instance149, (System.Type) null, "FrameType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local149.FrameType = str55;
        ref SAP_Module.RoofLight local150 = ref dwelling.RoofLights[index14];
        object[] objArray153;
        bool[] flagArray153;
        object Instance150 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray153 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray153 = new bool[1]
        {
          true
        });
        if (flagArray153[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray153[0]), typeof (int));
        string str56 = Conversions.ToString(NewLateBinding.LateGet(Instance150, (System.Type) null, "ThermalBreak", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local150.ThermalBreak = str56;
        ref SAP_Module.RoofLight local151 = ref dwelling.RoofLights[index14];
        object[] objArray154;
        bool[] flagArray154;
        object Instance151 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray154 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray154 = new bool[1]
        {
          true
        });
        if (flagArray154[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray154[0]), typeof (int));
        double single84 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance151, (System.Type) null, "Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local151.Area = (float) single84;
        ref SAP_Module.RoofLight local152 = ref dwelling.RoofLights[index14];
        object[] objArray155;
        bool[] flagArray155;
        object Instance152 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray155 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray155 = new bool[1]
        {
          true
        });
        if (flagArray155[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray155[0]), typeof (int));
        double single85 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance152, (System.Type) null, "Width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local152.Width = (float) single85;
        ref SAP_Module.RoofLight local153 = ref dwelling.RoofLights[index14];
        object[] objArray156;
        bool[] flagArray156;
        object Instance153 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray156 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray156 = new bool[1]
        {
          true
        });
        if (flagArray156[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray156[0]), typeof (int));
        double single86 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance153, (System.Type) null, "Height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local153.Height = (float) single86;
        ref SAP_Module.RoofLight local154 = ref dwelling.RoofLights[index14];
        object[] objArray157;
        bool[] flagArray157;
        object Instance154 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray157 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray157 = new bool[1]
        {
          true
        });
        if (flagArray157[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray157[0]), typeof (int));
        int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance154, (System.Type) null, "Count", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local154.Count = integer;
        ref SAP_Module.RoofLight local155 = ref dwelling.RoofLights[index14];
        object[] objArray158;
        bool[] flagArray158;
        object Instance155 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray158 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray158 = new bool[1]
        {
          true
        });
        if (flagArray158[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray158[0]), typeof (int));
        double single87 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance155, (System.Type) null, "OverhangWidth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local155.OverhangWidth = (float) single87;
        ref SAP_Module.RoofLight local156 = ref dwelling.RoofLights[index14];
        object[] objArray159;
        bool[] flagArray159;
        object Instance156 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray159 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray159 = new bool[1]
        {
          true
        });
        if (flagArray159[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray159[0]), typeof (int));
        double single88 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance156, (System.Type) null, "OverhangDepth", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local156.OverhangDepth = (float) single88;
        ref SAP_Module.RoofLight local157 = ref dwelling.RoofLights[index14];
        object[] objArray160;
        bool[] flagArray160;
        object Instance157 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray160 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray160 = new bool[1]
        {
          true
        });
        if (flagArray160[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray160[0]), typeof (int));
        string str57 = Conversions.ToString(NewLateBinding.LateGet(Instance157, (System.Type) null, "CurtainType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local157.CurtainType = str57;
        ref SAP_Module.RoofLight local158 = ref dwelling.RoofLights[index14];
        object[] objArray161;
        bool[] flagArray161;
        object Instance158 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray161 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray161 = new bool[1]
        {
          true
        });
        if (flagArray161[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray161[0]), typeof (int));
        double single89 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance158, (System.Type) null, "FractionClosed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local158.FractionClosed = (float) single89;
        ref SAP_Module.RoofLight local159 = ref dwelling.RoofLights[index14];
        object[] objArray162;
        bool[] flagArray162;
        object Instance159 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray162 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray162 = new bool[1]
        {
          true
        });
        if (flagArray162[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray162[0]), typeof (int));
        double single90 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance159, (System.Type) null, "g", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local159.g = (float) single90;
        ref SAP_Module.RoofLight local160 = ref dwelling.RoofLights[index14];
        object[] objArray163;
        bool[] flagArray163;
        object Instance160 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray163 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray163 = new bool[1]
        {
          true
        });
        if (flagArray163[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray163[0]), typeof (int));
        double single91 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance160, (System.Type) null, "FF", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local160.FF = (float) single91;
        ref SAP_Module.RoofLight local161 = ref dwelling.RoofLights[index14];
        object[] objArray164;
        bool[] flagArray164;
        object Instance161 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray164 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray164 = new bool[1]
        {
          true
        });
        if (flagArray164[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray164[0]), typeof (int));
        double single92 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance161, (System.Type) null, "U", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local161.U = (float) single92;
        ref SAP_Module.RoofLight local162 = ref dwelling.RoofLights[index14];
        object[] objArray165;
        bool[] flagArray165;
        object Instance162 = NewLateBinding.LateGet(SAP2009, (System.Type) null, "RoofLights", objArray165 = new object[1]
        {
          (object) index14
        }, (string[]) null, (System.Type[]) null, flagArray165 = new bool[1]
        {
          true
        });
        if (flagArray165[0])
          index14 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray165[0]), typeof (int));
        string str58 = Conversions.ToString(NewLateBinding.LateGet(Instance162, (System.Type) null, "OpeningType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        local162.OpeningType = str58;
        checked { ++index14; }
      }
      dwelling.Ventilation.Chimneys = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Chimneys", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ChimneysMain = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ChimneysMain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ChimneysSec = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ChimneysSec", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ChimneysOther = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ChimneysOther", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Flues = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Flues", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.FluesMain = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FluesMain", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.FluesSec = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FluesSec", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.FluesOther = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FluesOther", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Fans = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fans", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Vents = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Vents", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Fires = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fires", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Shelter = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Shelter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MechVent = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MechVent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Parameters = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Parameters", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.WetRooms = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WetRooms", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.DuctType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DuctType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ProductID = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ProductID", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ProductName = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ProductName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.ApprovedScheme = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ApprovedScheme", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KSPF1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KSPF1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KSPF2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KSPF2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KSPF3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KSPF3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OSPF1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OSPF1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OSPF2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OSPF2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OSPF3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OSPF3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KTP1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KTP1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KTP2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KTP2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.KTP3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KTP3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OTP1 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OTP1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OTP2 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OTP2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Decentralised.OTP3 = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Decentralised", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OTP3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.ProductName = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ProductName", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.DuctingType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DuctingType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.SFP = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SFP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MVDetails.HEE = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MVDetails", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HEE", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Pressure = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Pressure", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.DesignAir = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DesignAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.MeasuredAir = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MeasuredAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.DateAir = Conversions.ToDate(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DateAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.AssumedAir = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AssumedAir", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.AveragePerm = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AveragePerm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.Construction = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Construction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.Lobby = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Lobby", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.Floor = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Floor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Infiltration.DraguthP = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Infiltration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DraguthP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Ventilation.Draught = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Ventilation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Draught", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating = new SAP_Module.MainHeating();
      dwelling.MainHeating.HGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.SGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.InforSource = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InforSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.BSubGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "BSubGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.MHType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MHType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Sgroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Heat pumps", false))
      {
        dwelling.MainHeating.HGroup = "Heat pumps with radiators or underfloor heating";
        dwelling.MainHeating.SGroup = "Electric heat pumps";
      }
      else
      {
        object Left = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if (Operators.ConditionalCompareObjectEqual(Left, (object) "Central heating systems with radiators or underfloor heating", false))
          dwelling.MainHeating.HGroup = "Boiler systems with radiators or underfloor heating";
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "Micro-Congeneration (Micro-CHP)", false))
        {
          dwelling.MainHeating.HGroup = "Central heating systems with radiators or underfloor heating";
          dwelling.MainHeating.SGroup = "Micro-cogeneration (micro-CHP)";
        }
        else if (Operators.ConditionalCompareObjectEqual(Left, (object) "Warm air systems", false) && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Heat pumps", false))
        {
          dwelling.MainHeating.HGroup = "";
          dwelling.MainHeating.InforSource = "";
          dwelling.MainHeating.MHType = "";
          dwelling.MainHeating.BSubGroup = "";
        }
      }
      dwelling.MainHeating.Emitter = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Emitter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Controls = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Controls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.DelayedStart = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DelayedStart", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.SEDBUK = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SEDBUK", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.PumpHP = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PumpHP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.BILock = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "BILock", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.Description = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Description", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.FlueType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FlueType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.FanFlued = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FanFlued", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.IncludeKeepHot = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "IncludeKeepHot", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.KeepHotFuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KeepHotFuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.KeepHotTimed = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KeepHotTimed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.LoadWeather = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeather", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Boiler.LoadWeatherType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeatherType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.MainEff = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MainEff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.SAPTableCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SAPTableCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.ControlCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ControlCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.TableGroup = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TableGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.HETAS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HETAS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Compensator = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Compensator", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Range.CasekW = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Range", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CasekW", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.Range.WaterkW = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Range", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WaterkW", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.OilPump = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OilPump", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.Boiler1Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.Boiler1HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatDSystem = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatDSystem", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatToPowerRatio = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatToPowerRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.NoOfAdditionalHeatSources = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "NoOfAdditionalHeatSources", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource1.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource1.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource1.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource1.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource1.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource2.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource2.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource2.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource2.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource3.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource3.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource3.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource3.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource4.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource4.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource4.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.CommunityH.HeatSource4.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.SEDBUK2005 = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SEDBUK2005", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      int sapTableCode1 = dwelling.MainHeating.SAPTableCode;
      if (sapTableCode1 >= 305 && sapTableCode1 <= 311)
      {
        double Right = Conversions.ToDouble(Operators.DivideObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), Operators.AddObject((object) 1, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatToPowerRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))));
        dwelling.MainHeating.CommunityH.HeatToPowerRatio = (float) Right;
        dwelling.MainHeating.CommunityH.Boiler1Efficiency = Conversions.ToSingle(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Right));
      }
      dwelling.MainHeating.Boiler.LoadWeatherType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeatherType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.MainHeating.ElectricityTariff = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ElectricityTariff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      try
      {
        dwelling.MainHeating.Boiler.FlowTemp = !dwelling.MainHeating.Emitter.Contains("radiators") ? "Design flow temperature<=35°C" : "Design flow temperature >45°C";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      string country1 = dwelling.Address.Country;
      if (Operators.CompareString(country1, "Wales", false) == 0 || Operators.CompareString(country1, "England", false) == 0)
      {
        string loadWeatherType = dwelling.MainHeating.Boiler.LoadWeatherType;
        if (Operators.CompareString(loadWeatherType, "Weather Compensation", false) != 0 && Operators.CompareString(loadWeatherType, "Weather Compensator", false) != 0)
        {
          if (Operators.CompareString(loadWeatherType, "Enhanced Load Compensator", false) == 0)
            dwelling.MainHeating.ControlCodePCDFWeather = "696322";
        }
        else
          dwelling.MainHeating.ControlCodePCDFWeather = "696321";
      }
      else
        dwelling.MainHeating.Compensator = "";
      dwelling.MainHeating.Boiler.PumpType = "2012 or earlier";
      if (Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "IncludeMainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
      {
        dwelling.MainHeating2 = new SAP_Module.MainHeating();
        dwelling.MainHeating2.HGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.SGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        object Left1 = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if (Operators.ConditionalCompareObjectEqual(Left1, (object) "Central heating systems with radiators or underfloor heating", false))
          dwelling.MainHeating2.HGroup = "Boiler systems with radiators or underfloor heating";
        else if (Operators.ConditionalCompareObjectEqual(Left1, (object) "Micro-Congeneration (Micro-CHP)", false))
        {
          dwelling.MainHeating2.HGroup = "Central heating systems with radiators or underfloor heating";
          dwelling.MainHeating2.SGroup = "Micro-cogeneration (micro-CHP)";
        }
        else if (Operators.ConditionalCompareObjectEqual(Left1, (object) "Warm air systems", false))
        {
          if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Heat pumps", false))
          {
            dwelling.MainHeating2.HGroup = "Heat pumps with warm air distribution";
            object Instance = NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
            object[] Arguments = new object[1]
            {
              (object) "lectirc"
            };
            dwelling.MainHeating2.SGroup = !Conversions.ToBoolean(NewLateBinding.LateGet(Instance, (System.Type) null, "contains", Arguments, (string[]) null, (System.Type[]) null, (bool[]) null)) ? "Gas-fired heat pumps" : "Electric heat pumps";
          }
          else
            dwelling.MainHeating2.SGroup = "Warm air systems (Not heat pump)";
        }
        dwelling.IncludeMainHeating2 = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "IncludeMainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.InforSource = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InforSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.BSubGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "BSubGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.MHType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MHType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Emitter = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Emitter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Controls = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Controls", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.DelayedStart = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DelayedStart", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.SEDBUK = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SEDBUK", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.PumpHP = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PumpHP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.BILock = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "BILock", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.Description = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Description", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.FlueType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FlueType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.FanFlued = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FanFlued", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.IncludeKeepHot = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "IncludeKeepHot", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.KeepHotFuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KeepHotFuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.KeepHotTimed = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "KeepHotTimed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.LoadWeather = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeather", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.LoadWeatherType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeatherType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.MainEff = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MainEff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.SAPTableCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SAPTableCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.ControlCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ControlCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.TableGroup = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TableGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.HETAS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HETAS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Compensator = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Compensator", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Range.CasekW = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Range", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CasekW", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Range.WaterkW = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Range", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WaterkW", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.OilPump = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "OilPump", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.Boiler1Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "mainheating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.Boiler1HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "mainheating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatDSystem = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "mainheating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatDSystem", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatToPowerRatio = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "mainheating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatToPowerRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatToPowerRatio = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatToPowerRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.NoOfAdditionalHeatSources = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "NoOfAdditionalHeatSources", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource1.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource1.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource1.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource1.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource1.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource2.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource2.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource2.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource2.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource3.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource3.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource3.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource3.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource4.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource4.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource4.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.CommunityH.HeatSource4.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.SEDBUK2005 = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "mainheating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SEDBUK2005", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Include_SecMain_Heat_Whole = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Include_SecMain_Heat_Whole", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Include_SecMain_Heat_Separat_Part = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Include_SecMain_Heat_Separat_Part", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.HeatFractionSec = Conversions.ToSingle(NewLateBinding.LateGet(SAP2009, (System.Type) null, "HeatFractionSec", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        int sapTableCode2 = dwelling.MainHeating.SAPTableCode;
        if (sapTableCode2 >= 305 && sapTableCode2 <= 311)
        {
          double Right = Conversions.ToDouble(Operators.DivideObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), Operators.AddObject((object) 1, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatToPowerRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))));
          dwelling.MainHeating.CommunityH.HeatToPowerRatio = (float) Right;
          dwelling.MainHeating.CommunityH.Boiler1Efficiency = Conversions.ToSingle(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CommunityH", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Right));
        }
        dwelling.MainHeating2.ElectricityTariff = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ElectricityTariff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.MainHeating2.Boiler.FlowTemp = !dwelling.MainHeating2.Emitter.Contains("radiators") ? "Design flow temperature<=35°C" : "Design flow temperature >45°C";
        dwelling.MainHeating2.Boiler.LoadWeatherType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeatherType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        string country2 = dwelling.Address.Country;
        if (Operators.CompareString(country2, "Wales", false) == 0 || Operators.CompareString(country2, "England", false) == 0)
        {
          object Left2 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "MainHeating2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "LoadWeatherType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (Conversions.ToBoolean((object) (bool) (Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object) "Weather Compensation", false)) ? 1 : (Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object) "Weather Compensator", false)) ? 1 : 0))))
            dwelling.MainHeating2.ControlCodePCDFWeather = "696321";
          else if (Operators.ConditionalCompareObjectEqual(Left2, (object) "Enhanced Load Compensator", false))
            dwelling.MainHeating2.ControlCodePCDFWeather = "696322";
        }
        else
          dwelling.MainHeating2.Compensator = "";
      }
      dwelling.MainHeating2.Boiler.PumpType = "2012 or earlier";
      dwelling.TMP.Indicative = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "TMP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Indicative", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.TMP.UserDefined = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "TMP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "UserDefined", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.TMP.Type = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "TMP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.LessThan125Litre = Conversions.ToBoolean(NewLateBinding.LateGet(SAP2009, (System.Type) null, "LessThan125Litre", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.HGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.SGroup = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SGroup", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.InforSource = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InforSource", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.MHType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MHType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.TestMethod = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TestMethod", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.HETAS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HETAS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.SecEff = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SecEff", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.SAPTableCode = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SAPTableCode", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.MDescription = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "MDescription", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.SecHeating.FlueType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "SecHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FlueType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Volume = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Volume", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.ManuSpecified = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ManuSpecified", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.DeclaredLoss = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DeclaredLoss", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Insulation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Insulation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.InsThick = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InsThick", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.InHeatedSpace = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "InHeatedSpace", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Thermostat = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermostat", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.PipeWorkInsulated = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PipeWorkInsulated", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PipeWorkInsulated", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        dwelling.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
      dwelling.Water.Cylinder.Timed = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Timed", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.SummerImmersion = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SummerImmersion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.Immersion = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Immersion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.HPImmersion = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HPImmersion", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.DHWVessel = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "DHWVessel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Cylinder.HPExchanger = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cylinder", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HPExchanger", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.CPSUTemp = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CPSUTemp", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.CylinderInDwelling = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CylinderInDwelling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.CHPRatio = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CHPRatio", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HDS = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HDS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.Boiler1Fraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Boiler1Fraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Include = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Type = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Location = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Location", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Thermal.Connection = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Thermal", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Connection", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.CombiType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "CombiType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.NoOfAdditionalHeatSources = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "NoOfAdditionalHeatSources", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource1.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource1.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource1.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource1.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource1", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource2.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource2.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource2.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource2.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource2", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource3.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource3.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource3.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource3.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource3", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource4.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource4.HeatFraction = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatFraction", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource4.Efficiency = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Efficiency", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.HeatSource4.Type = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HeatSource4", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Type", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.HWSComm.Charging = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "HWSComm", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Charging", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Overide = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Overide", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarZero = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarZero", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarHLoss = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarHLoss", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarArea = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Gross = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Gross", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarTilt = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarTilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarOrientation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarOrientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarOvershading = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarOvershading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarVolume = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarVolume", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.SolarSeperate = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SolarSeperate", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.Pumped = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Solar", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Pumped", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Solar.ShowerType = "Both electric and non-electric showers";
      dwelling.Water.Solar.SolarHLoss2 = 0.005f;
      dwelling.Water.System = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "System", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.SystemRef = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemRef", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Water.Fuel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Fuel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.WNumber = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WNumber", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.WRDiameter = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WRDiameter", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.WindTurbine.WHeight = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WindTurbine", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WHeight", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      try
      {
        dwelling.Renewable.Photovoltaic.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        if (dwelling.Renewable.Photovoltaic.Inlcude)
        {
          dwelling.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
          dwelling.Renewable.Photovoltaic.Photovoltaics[0].ID = 0;
          dwelling.Renewable.Photovoltaic.Photovoltaics[0].PPower = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PPower", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          dwelling.Renewable.Photovoltaic.Photovoltaics[0].PTilt = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PTilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          dwelling.Renewable.Photovoltaic.Photovoltaics[0].PCOrientation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PCOrientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          dwelling.Renewable.Photovoltaic.Photovoltaics[0].POvershading = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "POvershading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        dwelling.Renewable.Special.Include = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        if (dwelling.Renewable.Special.Include)
        {
          dwelling.Renewable.Special.Special = new SAP_Module.SpecialFeatures[checked (Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Length", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1)) + 1)];
          object Counter;
          object LoopForResult;
          object objectValue;
          if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Length", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1), (object) 1, ref LoopForResult, ref objectValue))
          {
            do
            {
              ref SAP_Module.SpecialFeatures local163 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray166;
              bool[] flagArray166;
              object Instance163 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray166 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray166 = new bool[1]
              {
                true
              });
              if (flagArray166[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray166[0]);
              object[] Arguments1 = new object[0];
              int integer = Conversions.ToInteger(NewLateBinding.LateGet(Instance163, (System.Type) null, "ID", Arguments1, (string[]) null, (System.Type[]) null, (bool[]) null));
              local163.ID = integer;
              ref SAP_Module.SpecialFeatures local164 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray167;
              bool[] flagArray167;
              object Instance164 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray167 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray167 = new bool[1]
              {
                true
              });
              if (flagArray167[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray167[0]);
              object[] Arguments2 = new object[0];
              string str59 = Conversions.ToString(NewLateBinding.LateGet(Instance164, (System.Type) null, "Description", Arguments2, (string[]) null, (System.Type[]) null, (bool[]) null));
              local164.Description = str59;
              ref SAP_Module.SpecialFeatures local165 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray168;
              bool[] flagArray168;
              object Instance165 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray168 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray168 = new bool[1]
              {
                true
              });
              if (flagArray168[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray168[0]);
              object[] Arguments3 = new object[0];
              double single93 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance165, (System.Type) null, "EnergySaved", Arguments3, (string[]) null, (System.Type[]) null, (bool[]) null));
              local165.EnergySaved = (float) single93;
              ref SAP_Module.SpecialFeatures local166 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray169;
              bool[] flagArray169;
              object Instance166 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray169 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray169 = new bool[1]
              {
                true
              });
              if (flagArray169[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray169[0]);
              object[] Arguments4 = new object[0];
              string str60 = Conversions.ToString(NewLateBinding.LateGet(Instance166, (System.Type) null, "FuelSaved", Arguments4, (string[]) null, (System.Type[]) null, (bool[]) null));
              local166.FuelSaved = str60;
              ref SAP_Module.SpecialFeatures local167 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray170;
              bool[] flagArray170;
              object Instance167 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray170 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray170 = new bool[1]
              {
                true
              });
              if (flagArray170[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray170[0]);
              object[] Arguments5 = new object[0];
              double single94 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance167, (System.Type) null, "EnergyUsed", Arguments5, (string[]) null, (System.Type[]) null, (bool[]) null));
              local167.EnergyUsed = (float) single94;
              ref SAP_Module.SpecialFeatures local168 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray171;
              bool[] flagArray171;
              object Instance168 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray171 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray171 = new bool[1]
              {
                true
              });
              if (flagArray171[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray171[0]);
              object[] Arguments6 = new object[0];
              string str61 = Conversions.ToString(NewLateBinding.LateGet(Instance168, (System.Type) null, "FuelUsed", Arguments6, (string[]) null, (System.Type[]) null, (bool[]) null));
              local168.FuelUsed = str61;
              ref SAP_Module.SpecialFeatures local169 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
              object[] objArray172;
              bool[] flagArray172;
              object Instance169 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray172 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray172 = new bool[1]
              {
                true
              });
              if (flagArray172[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray172[0]);
              object[] Arguments7 = new object[0];
              int num20 = Conversions.ToBoolean(NewLateBinding.LateGet(Instance169, (System.Type) null, "IncludeMonthly", Arguments7, (string[]) null, (System.Type[]) null, (bool[]) null)) ? 1 : 0;
              local169.IncludeMonthly = num20 != 0;
              if (dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)].IncludeMonthly)
              {
                ref SAP_Module.SpecialFeatures local170 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray173;
                bool[] flagArray173;
                object Instance170 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray173 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray173 = new bool[1]
                {
                  true
                });
                if (flagArray173[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray173[0]);
                object[] Arguments8 = new object[0];
                double single95 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance170, (System.Type) null, "M1", Arguments8, (string[]) null, (System.Type[]) null, (bool[]) null));
                local170.M1 = (float) single95;
                ref SAP_Module.SpecialFeatures local171 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray174;
                bool[] flagArray174;
                object Instance171 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray174 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray174 = new bool[1]
                {
                  true
                });
                if (flagArray174[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray174[0]);
                object[] Arguments9 = new object[0];
                double single96 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance171, (System.Type) null, "M2", Arguments9, (string[]) null, (System.Type[]) null, (bool[]) null));
                local171.M2 = (float) single96;
                ref SAP_Module.SpecialFeatures local172 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray175;
                bool[] flagArray175;
                object Instance172 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray175 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray175 = new bool[1]
                {
                  true
                });
                if (flagArray175[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray175[0]);
                object[] Arguments10 = new object[0];
                double single97 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance172, (System.Type) null, "M3", Arguments10, (string[]) null, (System.Type[]) null, (bool[]) null));
                local172.M3 = (float) single97;
                ref SAP_Module.SpecialFeatures local173 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray176;
                bool[] flagArray176;
                object Instance173 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray176 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray176 = new bool[1]
                {
                  true
                });
                if (flagArray176[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray176[0]);
                object[] Arguments11 = new object[0];
                double single98 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance173, (System.Type) null, "M4", Arguments11, (string[]) null, (System.Type[]) null, (bool[]) null));
                local173.M4 = (float) single98;
                ref SAP_Module.SpecialFeatures local174 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray177;
                bool[] flagArray177;
                object Instance174 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray177 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray177 = new bool[1]
                {
                  true
                });
                if (flagArray177[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray177[0]);
                object[] Arguments12 = new object[0];
                double single99 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance174, (System.Type) null, "M5", Arguments12, (string[]) null, (System.Type[]) null, (bool[]) null));
                local174.M5 = (float) single99;
                ref SAP_Module.SpecialFeatures local175 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray178;
                bool[] flagArray178;
                object Instance175 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray178 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray178 = new bool[1]
                {
                  true
                });
                if (flagArray178[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray178[0]);
                object[] Arguments13 = new object[0];
                double single100 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance175, (System.Type) null, "M6", Arguments13, (string[]) null, (System.Type[]) null, (bool[]) null));
                local175.M6 = (float) single100;
                ref SAP_Module.SpecialFeatures local176 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray179;
                bool[] flagArray179;
                object Instance176 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray179 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray179 = new bool[1]
                {
                  true
                });
                if (flagArray179[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray179[0]);
                object[] Arguments14 = new object[0];
                double single101 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance176, (System.Type) null, "M7", Arguments14, (string[]) null, (System.Type[]) null, (bool[]) null));
                local176.M7 = (float) single101;
                ref SAP_Module.SpecialFeatures local177 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray180;
                bool[] flagArray180;
                object Instance177 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray180 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray180 = new bool[1]
                {
                  true
                });
                if (flagArray180[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray180[0]);
                object[] Arguments15 = new object[0];
                double single102 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance177, (System.Type) null, "M8", Arguments15, (string[]) null, (System.Type[]) null, (bool[]) null));
                local177.M8 = (float) single102;
                ref SAP_Module.SpecialFeatures local178 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray181;
                bool[] flagArray181;
                object Instance178 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray181 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray181 = new bool[1]
                {
                  true
                });
                if (flagArray181[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray181[0]);
                object[] Arguments16 = new object[0];
                double single103 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance178, (System.Type) null, "M9", Arguments16, (string[]) null, (System.Type[]) null, (bool[]) null));
                local178.M9 = (float) single103;
                ref SAP_Module.SpecialFeatures local179 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray182;
                bool[] flagArray182;
                object Instance179 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray182 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray182 = new bool[1]
                {
                  true
                });
                if (flagArray182[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray182[0]);
                object[] Arguments17 = new object[0];
                double single104 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance179, (System.Type) null, "M10", Arguments17, (string[]) null, (System.Type[]) null, (bool[]) null));
                local179.M10 = (float) single104;
                ref SAP_Module.SpecialFeatures local180 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray183;
                bool[] flagArray183;
                object Instance180 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray183 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray183 = new bool[1]
                {
                  true
                });
                if (flagArray183[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray183[0]);
                object[] Arguments18 = new object[0];
                double single105 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance180, (System.Type) null, "M11", Arguments18, (string[]) null, (System.Type[]) null, (bool[]) null));
                local180.M11 = (float) single105;
                ref SAP_Module.SpecialFeatures local181 = ref dwelling.Renewable.Special.Special[Conversions.ToInteger(objectValue)];
                object[] objArray184;
                bool[] flagArray184;
                object Instance181 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Special", objArray184 = new object[1]
                {
                  objectValue
                }, (string[]) null, (System.Type[]) null, flagArray184 = new bool[1]
                {
                  true
                });
                if (flagArray184[0])
                  objectValue = RuntimeHelpers.GetObjectValue(objArray184[0]);
                object[] Arguments19 = new object[0];
                double single106 = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance181, (System.Type) null, "M12", Arguments19, (string[]) null, (System.Type[]) null, (bool[]) null));
                local181.M12 = (float) single106;
              }
            }
            while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(objectValue, LoopForResult, ref objectValue));
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      dwelling.Renewable.AAEGeneration.Inlcude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AAEGeneration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.AAEGeneration.EGenerated = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AAEGeneration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EGenerated", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.Renewable.AAEGeneration.TotalArea = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "AAEGeneration", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TotalArea", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACBuildType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACBuildType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACWindow = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACWindow", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACOveride = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACOveride", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.EACAirChange = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "EACAirChange", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.TMIllustrative = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TMIllustrative", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.TMOveride = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TMOveride", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      dwelling.OverHeating.TMTMP = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "OverHeating", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "TMTMP", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      try
      {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        {
          object Counter;
          object LoopForResult;
          object objectValue;
          if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaics", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Length", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1), (object) 1, ref LoopForResult, ref objectValue))
          {
            do
            {
              dwelling.Renewable.Photovoltaic = new SAP_Module.Photovoltaic();
              dwelling.Renewable.Photovoltaic.Inlcude = true;
              dwelling.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[1];
              ref SAP_Module.PhotoVoltaics local182 = ref dwelling.Renewable.Photovoltaic.Photovoltaics[Conversions.ToInteger(objectValue)];
              object[] objArray185;
              bool[] flagArray185;
              object Instance182 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaics", objArray185 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray185 = new bool[1]
              {
                true
              });
              if (flagArray185[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray185[0]);
              object[] Arguments20 = new object[0];
              double single = (double) Conversions.ToSingle(NewLateBinding.LateGet(Instance182, (System.Type) null, "PPower", Arguments20, (string[]) null, (System.Type[]) null, (bool[]) null));
              local182.PPower = (float) single;
              ref SAP_Module.PhotoVoltaics local183 = ref dwelling.Renewable.Photovoltaic.Photovoltaics[Conversions.ToInteger(objectValue)];
              object[] objArray186;
              bool[] flagArray186;
              object Instance183 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaics", objArray186 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray186 = new bool[1]
              {
                true
              });
              if (flagArray186[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray186[0]);
              object[] Arguments21 = new object[0];
              string str62 = Conversions.ToString(NewLateBinding.LateGet(Instance183, (System.Type) null, "PTilt", Arguments21, (string[]) null, (System.Type[]) null, (bool[]) null));
              local183.PTilt = str62;
              ref SAP_Module.PhotoVoltaics local184 = ref dwelling.Renewable.Photovoltaic.Photovoltaics[Conversions.ToInteger(objectValue)];
              object[] objArray187;
              bool[] flagArray187;
              object Instance184 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaics", objArray187 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray187 = new bool[1]
              {
                true
              });
              if (flagArray187[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray187[0]);
              object[] Arguments22 = new object[0];
              string str63 = Conversions.ToString(NewLateBinding.LateGet(Instance184, (System.Type) null, "POvershading", Arguments22, (string[]) null, (System.Type[]) null, (bool[]) null));
              local184.POvershading = str63;
              ref SAP_Module.PhotoVoltaics local185 = ref dwelling.Renewable.Photovoltaic.Photovoltaics[Conversions.ToInteger(objectValue)];
              object[] objArray188;
              bool[] flagArray188;
              object Instance185 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Renewable", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaic", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Photovoltaics", objArray188 = new object[1]
              {
                objectValue
              }, (string[]) null, (System.Type[]) null, flagArray188 = new bool[1]
              {
                true
              });
              if (flagArray188[0])
                objectValue = RuntimeHelpers.GetObjectValue(objArray188[0]);
              object[] Arguments23 = new object[0];
              string str64 = Conversions.ToString(NewLateBinding.LateGet(Instance185, (System.Type) null, "PCOrientation", Arguments23, (string[]) null, (System.Type[]) null, (bool[]) null));
              local185.PCOrientation = str64;
              string propertyType = dwelling.PropertyType;
              if (Operators.CompareString(propertyType, "House", false) == 0 || Operators.CompareString(propertyType, "Bungalow", false) == 0)
                dwelling.Renewable.Photovoltaic.Photovoltaics[0].DirectlyConnected = true;
            }
            while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(objectValue, LoopForResult, ref objectValue));
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
      {
        dwelling.Cooling.Cooled_Area = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cooled_Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.SystemType = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemType", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.Compressorcontrol = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Compressorcontrol", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.Description = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Description", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.Energylabel = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Energylabel", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.ERR = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ERR", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.ERRMeasuredInclude = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "ERRMeasuredInclude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.Include = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        dwelling.Cooling.Cooled_Area = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Cooling", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Cooled_Area", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      try
      {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        {
          dwelling.Water.FGHRS.Include = true;
          dwelling.Water.FGHRS.IndexNo = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "IndexNo", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (dwelling.Water.FGHRS.IndexNo.Length == 5)
            dwelling.Water.FGHRS.IndexNo = "0" + dwelling.Water.FGHRS.IndexNo;
          if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PV", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Inlcude", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
          {
            dwelling.Water.FGHRS.PV.Inlcude = true;
            dwelling.Water.FGHRS.PV.Photovoltaics[0] = new SAP_Module.PhotoVoltaics();
            dwelling.Water.FGHRS.PV.Photovoltaics[0].PCOrientation = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PV", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PCOrientation", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling.Water.FGHRS.PV.Photovoltaics[0].POvershading = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PV", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "POvershading", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling.Water.FGHRS.PV.Photovoltaics[0].PPower = Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PV", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PPower", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling.Water.FGHRS.PV.Photovoltaics[0].PTilt = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FGHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PV", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "PTilt", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling.Water.FGHRS.PV.Photovoltaics[0].FlatConnection = "PV output goes to all flats in proportion to floor area";
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Include", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
        {
          dwelling.Water.WWHRS = new SAP_Module.WWHRSSystem();
          dwelling.Water.WWHRS.Include = true;
          dwelling.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
          dwelling.Water.WWHRS.Systems[0] = new SAP_Module.WWHRS_Systems();
          dwelling.Water.WWHRS.Systems[1] = new SAP_Module.WWHRS_Systems();
          if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
          {
            (object) 0
          }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemsRef", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
          {
            dwelling.Water.WWHRS.Systems[0].SystemsRef = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
            {
              (object) 0
            }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemsRef", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            if (dwelling.Water.WWHRS.Systems[0].SystemsRef.Length == 5)
              dwelling.Water.WWHRS.Systems[0].SystemsRef = "0" + dwelling.Water.WWHRS.Systems[0].SystemsRef;
            dwelling.Water.WWHRS.Systems[0].WithBath = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
            {
              (object) 0
            }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WithBath", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling.Water.WWHRS.Systems[0].WithNoBath = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
            {
              (object) 0
            }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WithNoBath", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
          {
            (object) 1
          }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemsRef", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
          {
            dwelling.Water.WWHRS.Systems[1].SystemsRef = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
            {
              (object) 1
            }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "SystemsRef", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            if (dwelling.Water.WWHRS.Systems[1].SystemsRef.Length == 5)
              dwelling.Water.WWHRS.Systems[1].SystemsRef = "0" + dwelling.Water.WWHRS.Systems[1].SystemsRef;
            dwelling.Water.WWHRS.Systems[1].WithBath = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
            {
              (object) 1
            }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WithBath", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling.Water.WWHRS.Systems[1].WithNoBath = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
            {
              (object) 1
            }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WithNoBath", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(SAP2009, (System.Type) null, "Water", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WWHRS", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Systems", new object[1]
          {
            (object) 1
          }, (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "WithNoBath", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 1, false))
            dwelling.Water.WWHRS.Systems[1] = new SAP_Module.WWHRS_Systems();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return dwelling;
    }

    public string[] GetApprovedValue() => new string[23]
    {
      Conversions.ToString(0.5),
      Conversions.ToString(0.3),
      Conversions.ToString(0.04),
      Conversions.ToString(0.05),
      Conversions.ToString(0.16),
      Conversions.ToString(0.07),
      Conversions.ToString(0.07),
      Conversions.ToString(0.0),
      Conversions.ToString(0.02),
      Conversions.ToString(0.06),
      Conversions.ToString(0.04),
      Conversions.ToString(0.24),
      Conversions.ToString(0.04),
      Conversions.ToString(0.04),
      Conversions.ToString(0.28),
      Conversions.ToString(0.09),
      Conversions.ToString(-0.09),
      Conversions.ToString(0.06),
      Conversions.ToString(0.08),
      Conversions.ToString(0.0),
      Conversions.ToString(0.0),
      Conversions.ToString(0.12),
      Conversions.ToString(0.02)
    };

    public string[] GetDefaultValue() => new string[23]
    {
      "1.0",
      "1.0",
      "0.08",
      "0.10",
      "0.32",
      "0.14",
      "0.14",
      "0.00",
      "0.04",
      "0.12",
      "0.08",
      "0.48",
      "0.08",
      "0.08",
      "0.56",
      "0.18",
      "-0.00",
      "0.12",
      "0.16",
      "0.04",
      "0.04",
      "0.24",
      "0.04"
    };
  }
}
