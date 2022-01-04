
// Type: SAP2012.ImportsArea.ExcelImportAreas




using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SAP2012.ImportsArea
{
  public class ExcelImportAreas
  {
    public SAP_Module.Dwelling ConvertTExcelToDwelling(string file)
    {
      SAP_Module.Dwelling dwelling1 = new SAP_Module.Dwelling();
      SAP_Module.CurrDwelling = 0;
      Application application = (Application) new ApplicationClass();
      Workbook workbook = application.Workbooks.Open(file, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
      Worksheet worksheet = (Worksheet) workbook.Worksheets[(object) "Areas"];
      SAP_Module.Proj = new SAP_Module.Project();
      List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
      Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;
      SAP_Module.NoCalc = true;
      int count = usedRange.Rows.Count;
      int RowIndex = 1;
      while (RowIndex <= count)
      {
        int noofFloors = dwelling1.NoofFloors;
        int noofDoors = dwelling1.NoofDoors;
        int noofRoofs = dwelling1.NoofRoofs;
        int noofWalls = dwelling1.NoofWalls;
        int noofRoofLights = dwelling1.NoofRoofLights;
        int noofPwalls = dwelling1.NoofPWalls;
        int noofWindows = dwelling1.NoofWindows;
        if (!this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))) & !this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex + 1), (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          workbook.Close((object) true, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
          application.Quit();
          this.releaseObject((object) application);
          this.releaseObject((object) workbook);
          this.releaseObject((object) worksheet);
          dwelling1.YearBuilt = 2019;
          dwellingList.Add(dwelling1);
          SAP_Module.Proj.Dwellings = dwellingList.ToArray();
          SAP_Module.Proj.NoOfDwells = dwellingList.Count;
          SAP_Module.NoCalc = false;
          goto label_100;
        }
        else
        {
          if (!this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))) & this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex + 1), (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
          {
            if (SAP_Module.CurrDwelling > 0)
              dwellingList.Add(dwelling1);
            checked { ++SAP_Module.CurrDwelling; }
            checked { ++RowIndex; }
            if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              dwelling1.Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            dwelling1.Reference = dwelling1.Name;
            dwelling1.Address.Line1 = dwelling1.Name;
            dwelling1.NoofFloors = 0;
            dwelling1.NoofRoofs = 0;
            dwelling1.NoofWalls = 0;
            dwelling1.NoofRoofLights = 0;
            dwelling1.NoofPWalls = 0;
            dwelling1.NoofWindows = 0;
            dwelling1.NoofDoors = 0;
            dwelling1.Storeys = 0;
          }
          else if (RowIndex > 1)
          {
            try
            {
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("front") | NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Door"))
                {
                  if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("front"))
                    dwelling1.Orientation = this.GetOrientation(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
                  checked { ++dwelling1.NoofDoors; }
                  // ISSUE: variable of a reference type
                  SAP_Module.Door[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.Door[] doorArray = (SAP_Module.Door[]) Utils.CopyArray((Array) ^(local = ref dwelling1.Doors), (Array) new SAP_Module.Door[checked (dwelling1.NoofDoors - 1 + 1)]);
                  local = doorArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Doors[noofDoors].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Doors[noofDoors].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Doors[noofDoors].Orientation = this.GetOrientation(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 6], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Doors[noofDoors].Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 6], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Floor"))
                {
                  checked { ++dwelling1.NoofFloors; }
                  // ISSUE: variable of a reference type
                  SAP_Module.Opaques[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref dwelling1.Floors), (Array) new SAP_Module.Opaques[checked (dwelling1.NoofFloors - 1 + 1)]);
                  local = opaquesArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Floors[noofFloors].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Floors[noofFloors].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Roof "))
                {
                  checked { ++dwelling1.NoofRoofs; }
                  // ISSUE: variable of a reference type
                  SAP_Module.Opaques[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref dwelling1.Roofs), (Array) new SAP_Module.Opaques[checked (dwelling1.NoofRoofs - 1 + 1)]);
                  local = opaquesArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Roofs[noofRoofs].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Roofs[noofRoofs].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Rooflight"))
                {
                  checked { ++dwelling1.NoofRoofLights; }
                  // ISSUE: variable of a reference type
                  SAP_Module.RoofLight[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.RoofLight[] roofLightArray = (SAP_Module.RoofLight[]) Utils.CopyArray((Array) ^(local = ref dwelling1.RoofLights), (Array) new SAP_Module.RoofLight[checked (dwelling1.NoofRoofLights - 1 + 1)]);
                  local = roofLightArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.RoofLights[noofRoofLights].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.RoofLights[noofRoofLights].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.RoofLights[noofRoofLights].Orientation = this.GetOrientation(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 6], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.RoofLights[noofRoofLights].Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 6], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 5], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.RoofLights[noofRoofLights].Pitch = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 5], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Wall") & !NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Wall party"))
                {
                  checked { ++dwelling1.NoofWalls; }
                  // ISSUE: variable of a reference type
                  SAP_Module.Opaques[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref dwelling1.Walls), (Array) new SAP_Module.Opaques[checked (dwelling1.NoofWalls - 1 + 1)]);
                  local = opaquesArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Walls[noofWalls].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Walls[noofWalls].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Wall party"))
                {
                  checked { ++dwelling1.NoofPWalls; }
                  // ISSUE: variable of a reference type
                  SAP_Module.PartyWall[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.PartyWall[] partyWallArray = (SAP_Module.PartyWall[]) Utils.CopyArray((Array) ^(local = ref dwelling1.PWalls), (Array) new SAP_Module.PartyWall[checked (dwelling1.NoofPWalls - 1 + 1)]);
                  local = partyWallArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.PWalls[noofPwalls].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.PWalls[noofPwalls].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
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
              if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
              {
                if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("Window"))
                {
                  checked { ++dwelling1.NoofWindows; }
                  // ISSUE: variable of a reference type
                  SAP_Module.Window[]& local;
                  // ISSUE: explicit reference operation
                  SAP_Module.Window[] windowArray = (SAP_Module.Window[]) Utils.CopyArray((Array) ^(local = ref dwelling1.Windows), (Array) new SAP_Module.Window[checked (dwelling1.NoofWindows - 1 + 1)]);
                  local = windowArray;
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Windows[noofWindows].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Windows[noofWindows].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Windows[noofWindows].Orientation = this.GetOrientation(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 4], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
                  if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 6], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
                    dwelling1.Windows[noofWindows].Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 6], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          checked { ++RowIndex; }
        }
      }
      workbook.Close((object) true, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
      application.Quit();
      this.releaseObject((object) application);
      this.releaseObject((object) workbook);
      this.releaseObject((object) worksheet);
      dwelling1.YearBuilt = 2018;
      dwellingList.Add(dwelling1);
      SAP_Module.Proj.Dwellings = dwellingList.ToArray();
      SAP_Module.Proj.NoOfDwells = dwellingList.Count;
      SAP_Module.Dwelling dwelling2 = dwelling1;
label_100:
      return dwelling2;
    }

    private ExcelImportAreas.CSVAlistair_DImProjects ReadAreaText(string file)
    {
      ExcelImportAreas.CSVAlistairArea csvAlistairArea = new ExcelImportAreas.CSVAlistairArea();
      ExcelImportAreas.CSVAlistair_DImProjects alistairDimProjects = new ExcelImportAreas.CSVAlistair_DImProjects();
      using (TextFieldParser textFieldParser = new TextFieldParser(file))
      {
        textFieldParser.TextFieldType = FieldType.Delimited;
        textFieldParser.SetDelimiters(",");
        bool flag = false;
        while (!textFieldParser.EndOfData)
        {
          try
          {
            string[] strArray = textFieldParser.ReadFields();
            if ((uint) Operators.CompareString(strArray[0], "", false) > 0U)
            {
              if (!flag)
              {
                alistairDimProjects.Name.Add(strArray[0]);
                csvAlistairArea = new ExcelImportAreas.CSVAlistairArea()
                {
                  Name = strArray[0]
                };
                flag = true;
              }
              else
              {
                csvAlistairArea.Element.Add(strArray[0]);
                if (strArray.Length > 1)
                  csvAlistairArea.Area.Add(strArray[1]);
                if (strArray.Length > 2)
                  csvAlistairArea.Height.Add(strArray[2]);
                if (strArray.Length > 3 && (uint) Operators.CompareString(csvAlistairArea.Room_in_roof, "Yes", false) > 0U)
                  csvAlistairArea.Room_in_roof = strArray[3];
                if (strArray.Length > 4 && Operators.CompareString(csvAlistairArea.LivingArea, "", false) == 0)
                  csvAlistairArea.LivingArea = strArray[4];
                if (strArray.Length > 5 && Conversion.Val(csvAlistairArea.Sheltered_sides) < 1.0)
                  csvAlistairArea.Sheltered_sides = strArray[5];
                if (strArray.Length > 6)
                {
                  if (Conversion.Val(csvAlistairArea.ThermalMass) < 1.0)
                    csvAlistairArea.ThermalMass = strArray[6];
                }
              }
            }
            else if (!alistairDimProjects.Details.Contains(csvAlistairArea) && !string.IsNullOrEmpty(csvAlistairArea.Name))
            {
              flag = false;
              alistairDimProjects.Details.Add(csvAlistairArea);
            }
          }
          catch (MalformedLineException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
        }
        if (!alistairDimProjects.Details.Contains(csvAlistairArea) && !string.IsNullOrEmpty(csvAlistairArea.Name))
          alistairDimProjects.Details.Add(csvAlistairArea);
      }
      return alistairDimProjects;
    }

    private ExcelImportAreas.CSVPSIProjects ReadPSIText(string file)
    {
      ExcelImportAreas.CSVAlistairPSI csvAlistairPsi = new ExcelImportAreas.CSVAlistairPSI();
      ExcelImportAreas.CSVPSIProjects csvpsiProjects = new ExcelImportAreas.CSVPSIProjects();
      using (TextFieldParser textFieldParser = new TextFieldParser(file))
      {
        textFieldParser.TextFieldType = FieldType.Delimited;
        textFieldParser.SetDelimiters(",");
        bool flag = false;
        int num = 0;
        while (!textFieldParser.EndOfData)
        {
          try
          {
            string[] strArray = textFieldParser.ReadFields();
            if (num > 0)
            {
              if ((uint) Operators.CompareString(strArray[0], "", false) > 0U)
              {
                if (!flag)
                {
                  csvpsiProjects.Name.Add(strArray[0]);
                  csvAlistairPsi = new ExcelImportAreas.CSVAlistairPSI()
                  {
                    Name = strArray[0]
                  };
                  flag = true;
                  continue;
                }
                csvAlistairPsi.Element.Add(strArray[0]);
                if (strArray.Length > 1)
                  csvAlistairPsi.Length.Add(strArray[1]);
                if (strArray.Length > 2)
                  csvAlistairPsi.Value.Add(strArray[2]);
              }
              else if (!csvpsiProjects.Details.Contains(csvAlistairPsi) && !string.IsNullOrEmpty(csvAlistairPsi.Name))
              {
                flag = false;
                csvpsiProjects.Details.Add(csvAlistairPsi);
              }
            }
          }
          catch (MalformedLineException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
          checked { ++num; }
        }
        if (!csvpsiProjects.Details.Contains(csvAlistairPsi) && !string.IsNullOrEmpty(csvAlistairPsi.Name))
          csvpsiProjects.Details.Add(csvAlistairPsi);
      }
      return csvpsiProjects;
    }

    private ExcelImportAreas.CSVProjects ReadAllText(string file)
    {
      ExcelImportAreas.CSVProjects csvProjects = new ExcelImportAreas.CSVProjects();
      using (TextFieldParser textFieldParser = new TextFieldParser(file))
      {
        textFieldParser.TextFieldType = FieldType.Delimited;
        textFieldParser.SetDelimiters(",");
        int num = 0;
        while (!textFieldParser.EndOfData)
        {
          checked { ++num; }
          try
          {
            string[] strArray = textFieldParser.ReadFields();
            ExcelImportAreas.CSVImportArea csvImportArea;
            if (strArray.Length == 1)
            {
              csvImportArea = new ExcelImportAreas.CSVImportArea();
              csvProjects.Name.Add(strArray[0]);
              csvProjects.Details.Add(csvImportArea);
              num = 1;
            }
            if (num > 1)
            {
              if (strArray.Length > 0)
                csvImportArea.Element.Add(strArray[0]);
              if (strArray.Length > 1)
                csvImportArea.Area.Add(strArray[1]);
              if (strArray.Length > 2)
                csvImportArea.Orientation.Add(strArray[2]);
              if (strArray.Length > 3)
                csvImportArea.CompassPoint.Add(strArray[3]);
              if (strArray.Length > 4)
                csvImportArea.Pitch.Add(strArray[4]);
              if (strArray.Length > 5)
                csvImportArea.AssignedSurface.Add(strArray[5]);
            }
          }
          catch (MalformedLineException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      return csvProjects;
    }

    public SAP_Module.Dwelling ConvertCSVToDwelling(string file)
    {
      SAP_Module.CurrDwelling = 0;
      ExcelImportAreas.CSVProjects csvProjects = this.ReadAllText(file);
      List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index1 = 0;
      SAP_Module.Dwelling dwelling;
      while (index1 <= num1)
      {
        int noofPwalls = dwelling.NoofPWalls;
        int noofIwalls = dwelling.NoofIWalls;
        int noofPceilings = dwelling.NoofPCeilings;
        int noofIceilings = dwelling.NoofICeilings;
        int noofIfloors = dwelling.NoofIFloors;
        int noofpFloors = dwelling.NoofpFloors;
        dwelling.NoofPWalls = 0;
        dwelling.NoofIWalls = 0;
        dwelling.NoofPCeilings = 0;
        dwelling.NoofICeilings = 0;
        dwelling.NoofIFloors = 0;
        dwelling.NoofpFloors = 0;
        int index2 = 0;
        int index3 = 0;
        int index4 = 0;
        int index5 = 0;
        int index6 = 0;
        int index7 = 0;
        checked { ++SAP_Module.CurrDwelling; }
        int num2 = checked (csvProjects.Details[index1].Element.Count - 1);
        int index8 = 0;
        while (index8 <= num2)
        {
          if (Operators.CompareString(SAP_Module.Proj.Dwellings[index1].Name, csvProjects.Details[index1].Element[index8].ToString(), false) == 0)
          {
            dwelling.Name = csvProjects.Name[index1];
            dwelling.Reference = csvProjects.Name[index1];
            dwelling.Address.Line1 = csvProjects.Name[index1];
            checked { ++index8; }
          }
          try
          {
            if (csvProjects.Details[index1].Element[index8].ToString().Contains("Ceiling party"))
            {
              // ISSUE: variable of a reference type
              SAP_Module.PartyElements[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref dwelling.PCeilings), (Array) new SAP_Module.PartyElements[checked (dwelling.NoofPCeilings + 1)]);
              local = partyElementsArray;
              checked { ++dwelling.NoofPCeilings; }
              dwelling.PCeilings[index2].Name = csvProjects.Details[index1].Element[index8].ToString();
              dwelling.PCeilings[index2].Area = Conversions.ToSingle(csvProjects.Details[index1].Area[index8].ToString());
              checked { ++index2; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (csvProjects.Details[index1].Element[index8].ToString().Contains("Ceiling internal"))
            {
              checked { ++dwelling.NoofICeilings; }
              // ISSUE: variable of a reference type
              SAP_Module.PartyElements[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref dwelling.ICeilings), (Array) new SAP_Module.PartyElements[checked (dwelling.NoofICeilings - 1 + 1)]);
              local = partyElementsArray;
              dwelling.ICeilings[index4].Name = csvProjects.Details[index1].Element[index8].ToString();
              dwelling.ICeilings[index4].Area = Conversions.ToSingle(csvProjects.Details[index1].Area[index8].ToString());
              checked { ++index4; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (csvProjects.Details[index1].Element[index8].ToString().Contains("Wall party"))
            {
              checked { ++dwelling.NoofPWalls; }
              // ISSUE: variable of a reference type
              SAP_Module.PartyWall[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PartyWall[] partyWallArray = (SAP_Module.PartyWall[]) Utils.CopyArray((Array) ^(local = ref dwelling.PWalls), (Array) new SAP_Module.PartyWall[checked (dwelling.NoofPWalls - 1 + 1)]);
              local = partyWallArray;
              dwelling.PWalls[index3].Name = csvProjects.Details[index1].Element[index8].ToString();
              dwelling.PWalls[index3].Area = Conversions.ToSingle(csvProjects.Details[index1].Area[index8].ToString());
              checked { ++index3; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (csvProjects.Details[index1].Element[index8].ToString().Contains("Wall internal"))
            {
              checked { ++dwelling.NoofIWalls; }
              // ISSUE: variable of a reference type
              SAP_Module.PartyElements[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref dwelling.IWalls), (Array) new SAP_Module.PartyElements[checked (dwelling.NoofIWalls - 1 + 1)]);
              local = partyElementsArray;
              dwelling.IWalls[index5].Name = csvProjects.Details[index1].Element[index8].ToString();
              dwelling.IWalls[index5].Area = Conversions.ToSingle(csvProjects.Details[index1].Area[index8].ToString());
              checked { ++index5; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Console.Write("");
            ProjectData.ClearProjectError();
          }
          try
          {
            if (csvProjects.Details[index1].Element[index8].ToString().Contains("Floor internal"))
            {
              checked { ++dwelling.NoofIFloors; }
              // ISSUE: variable of a reference type
              SAP_Module.PartyElements[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref dwelling.IFloors), (Array) new SAP_Module.PartyElements[checked (dwelling.NoofIFloors - 1 + 1)]);
              local = partyElementsArray;
              dwelling.IFloors[index6].Name = csvProjects.Details[index1].Element[index8].ToString();
              dwelling.IFloors[index6].Area = Conversions.ToSingle(csvProjects.Details[index1].Area[index8].ToString());
              checked { ++index6; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          try
          {
            if (csvProjects.Details[index1].Element[index8].ToString().Contains("Floor party"))
            {
              checked { ++dwelling.NoofpFloors; }
              // ISSUE: variable of a reference type
              SAP_Module.PartyElements[]& local;
              // ISSUE: explicit reference operation
              SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref dwelling.PFloors), (Array) new SAP_Module.PartyElements[checked (dwelling.NoofpFloors - 1 + 1)]);
              local = partyElementsArray;
              dwelling.PFloors[index7].Name = csvProjects.Details[index1].Element[index8].ToString();
              dwelling.PFloors[index7].Area = Conversions.ToSingle(csvProjects.Details[index1].Area[index8].ToString());
              checked { ++index7; }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index8; }
        }
        SAP_Module.Proj.Dwellings[index1].NoofPWalls = dwelling.NoofPWalls;
        SAP_Module.Proj.Dwellings[index1].NoofIWalls = dwelling.NoofIWalls;
        SAP_Module.Proj.Dwellings[index1].NoofPCeilings = dwelling.NoofPCeilings;
        SAP_Module.Proj.Dwellings[index1].NoofIFloors = dwelling.NoofIFloors;
        SAP_Module.Proj.Dwellings[index1].NoofICeilings = dwelling.NoofICeilings;
        SAP_Module.Proj.Dwellings[index1].NoofpFloors = dwelling.NoofpFloors;
        if (dwelling.PFloors != null)
          SAP_Module.Proj.Dwellings[index1].PFloors = dwelling.PFloors;
        if (dwelling.IFloors != null)
          SAP_Module.Proj.Dwellings[index1].IFloors = dwelling.IFloors;
        if (dwelling.IWalls != null)
          SAP_Module.Proj.Dwellings[index1].IWalls = dwelling.IWalls;
        if (dwelling.PWalls != null)
          SAP_Module.Proj.Dwellings[index1].PWalls = dwelling.PWalls;
        if (dwelling.PCeilings != null)
          SAP_Module.Proj.Dwellings[index1].PCeilings = dwelling.PCeilings;
        if (dwelling.ICeilings != null)
          SAP_Module.Proj.Dwellings[index1].ICeilings = dwelling.ICeilings;
        SAP_Module.Proj.Dwellings[index1].YearBuilt = 2019;
        checked { ++index1; }
      }
      return dwelling;
    }

    public SAP_Module.Dwelling ConvertTCSVToDImAreaDwelling(string file)
    {
      SAP_Module.CurrDwelling = 0;
      ExcelImportAreas.CSVAlistair_DImProjects alistairDimProjects = this.ReadAreaText(file);
      List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
      SAP_Module.Dwelling dimAreaDwelling;
      if (SAP_Module.Proj.NoOfDwells != 0)
      {
        SAP_Module.Dwelling dwelling;
        try
        {
          int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
          int index1 = 0;
          while (index1 <= num1)
          {
            int num2 = checked (alistairDimProjects.Details.Count - 1);
            int index2 = 0;
            while (index2 <= num2)
            {
              if (Operators.CompareString(SAP_Module.Proj.Dwellings[index1].Name, alistairDimProjects.Details[index2].Name.ToString(), false) == 0)
              {
                dwelling.Name = alistairDimProjects.Details[index2].Name;
                SAP_Module.Proj.Dwellings[index1].Storeys = 0;
                SAP_Module.Proj.Dwellings[index1].Storeys = alistairDimProjects.Details[index2].Area.Count;
                // ISSUE: variable of a reference type
                SAP_Module.Dimensions[]& local;
                // ISSUE: explicit reference operation
                SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref SAP_Module.Proj.Dwellings[index1].Dims), (Array) new SAP_Module.Dimensions[checked (SAP_Module.Proj.Dwellings[index1].Storeys - 1 + 1)]);
                local = dimensionsArray;
                int num3 = checked (alistairDimProjects.Details[index1].Element.Count - 1);
                int index3 = 0;
                while (index3 <= num3)
                {
                  if (!alistairDimProjects.Details[index2].Element[index3].Contains("Lowest floor"))
                    ;
                  SAP_Module.Proj.Dwellings[index1].Dims[index3].Floor = index2;
                  SAP_Module.Proj.Dwellings[index1].Dims[index3].Area = (float) Conversion.Val(alistairDimProjects.Details[index2].Area[index3]);
                  SAP_Module.Proj.Dwellings[index1].Dims[index3].Height = (float) Conversion.Val(alistairDimProjects.Details[index2].Height[index3]);
                  checked { ++index3; }
                }
                SAP_Module.Proj.Dwellings[index1].TMP.UserDefined = (float) Conversion.Val(alistairDimProjects.Details[index2].ThermalMass);
                if (Conversion.Val((object) SAP_Module.Proj.Dwellings[index1].TMP.UserDefined) > 0.0)
                  SAP_Module.Proj.Dwellings[index1].TMP.Type = "User Value";
                SAP_Module.Proj.Dwellings[index1].Ventilation.Shelter = (float) Conversion.Val(alistairDimProjects.Details[index2].Sheltered_sides);
                SAP_Module.Proj.Dwellings[index1].LivingArea = (float) Conversion.Val(alistairDimProjects.Details[index2].LivingArea);
                if (Operators.CompareString(alistairDimProjects.Details[index1].Room_in_roof, "Yes", false) == 0)
                  SAP_Module.Proj.Dwellings[index1].TrueRoof = true;
              }
              checked { ++index2; }
            }
            checked { ++index1; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.Write("");
          ProjectData.ClearProjectError();
        }
        dimAreaDwelling = dwelling;
      }
      return dimAreaDwelling;
    }

    public SAP_Module.Dwelling ConvertTCSVPSIToDwelling(string file)
    {
      ExcelImportAreas.CSVPSIProjects csvpsiProjects = this.ReadPSIText(file);
      if (SAP_Module.Proj.NoOfDwells < 1)
      {
        List<SAP_Module.Dwelling> dwellingList = new List<SAP_Module.Dwelling>();
      }
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        SAP_Module.Proj.Dwellings[index1].Thermal.ManualHtb = true;
        if (SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions == null)
          SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
        if (SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions == null)
          SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
        if (SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions == null)
          SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
        int num2 = checked (csvpsiProjects.Name.Count - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Operators.CompareString(csvpsiProjects.Name[index2], SAP_Module.Proj.Dwellings[index1].Name, false) == 0)
          {
            int num3 = checked (csvpsiProjects.Details[index2].Element.Count - 1);
            int index3 = 0;
            while (index3 <= num3)
            {
              SAP_Module.Junction junction4 = new SAP_Module.Junction();
              SAP_Module.Junction junction5 = new SAP_Module.Junction();
              SAP_Module.Junction junction6 = new SAP_Module.Junction();
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E01", false) == 0)
                {
                  junction4.JunctionDetail = "Steel lintel with perforated steel base plate";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E1";
                  junction4.Accredited = 0.5;
                  junction4.Defaul = 1.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E02", false) == 0)
                {
                  junction4.JunctionDetail = "Other lintels (including other steel lintels)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E2";
                  junction4.Accredited = 0.3;
                  junction4.Defaul = 1.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E03", false) == 0)
                {
                  junction4.JunctionDetail = "Sill";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E3";
                  junction4.Accredited = 0.04;
                  junction4.Defaul = 0.08;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E04", false) == 0)
                {
                  junction4.JunctionDetail = "Jamb";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E4";
                  junction4.Accredited = 0.05;
                  junction4.Defaul = 0.1;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E05", false) == 0)
                {
                  junction4.JunctionDetail = "Ground floor (normal)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E5";
                  junction4.Accredited = 0.16;
                  junction4.Defaul = 0.32;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E06", false) == 0)
                {
                  junction4.JunctionDetail = "Intermediate floor within a dwelling";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E6";
                  junction4.Accredited = 0.07;
                  junction4.Defaul = 0.14;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E07", false) == 0)
                {
                  junction4.JunctionDetail = "Party floor between dwellings (in blocks of flats)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E7";
                  junction4.Accredited = 0.07;
                  junction4.Defaul = 0.14;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E08", false) == 0)
                {
                  junction4.JunctionDetail = "Balcony within a dwelling, wall insulation continuous";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E8";
                  junction4.Defaul = 0.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E09", false) == 0)
                {
                  junction4.JunctionDetail = "Balcony between dwellings, wall insulation continuous";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E9";
                  junction4.Defaul = 0.04;
                  junction4.Accredited = 0.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E10", false) == 0)
                {
                  junction4.JunctionDetail = "Eaves (insulation at ceiling level)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E10";
                  junction4.Defaul = 0.12;
                  junction4.Accredited = 0.06;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E11", false) == 0)
                {
                  junction4.JunctionDetail = "Eaves (insulation at rafter level)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E11";
                  junction4.Defaul = 0.08;
                  junction4.Accredited = 0.04;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E12", false) == 0)
                {
                  junction4.JunctionDetail = "Gable (insulation at ceiling level)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E12";
                  junction4.Defaul = 0.48;
                  junction4.Accredited = 0.24;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E13", false) == 0)
                {
                  junction4.JunctionDetail = "Gable (insulation at rafter level)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E13";
                  junction4.Defaul = 0.08;
                  junction4.Accredited = 0.04;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E14", false) == 0)
                {
                  junction4.JunctionDetail = "Flat roof";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E14";
                  junction4.Defaul = 0.08;
                  junction4.Accredited = 0.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E15", false) == 0)
                {
                  junction4.JunctionDetail = "Flat roof with parapet";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E15";
                  junction4.Defaul = 0.56;
                  junction4.Accredited = 0.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E16", false) == 0)
                {
                  junction4.JunctionDetail = "Corner (normal)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E16";
                  junction4.Defaul = 0.18;
                  junction4.Accredited = 0.09;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E17", false) == 0)
                {
                  junction4.JunctionDetail = "Corner (inverted – internal area greater than external area)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E17";
                  junction4.Defaul = 0.0;
                  junction4.Accredited = -0.09;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E18", false) == 0)
                {
                  junction4.JunctionDetail = "Party wall between dwellings";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E18";
                  junction4.Defaul = 0.12;
                  junction4.Accredited = 0.06;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E19", false) == 0)
                {
                  junction4.JunctionDetail = "Ground floor (inverted)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E19";
                  junction4.Defaul = 0.07;
                  junction4.Accredited = 0.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E20", false) == 0)
                {
                  junction4.JunctionDetail = "Exposed floor (normal)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E20";
                  junction4.Defaul = 0.32;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E21", false) == 0)
                {
                  junction4.JunctionDetail = "Exposed floor (inverted)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E21";
                  junction4.Defaul = 0.32;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E22", false) == 0)
                {
                  junction4.JunctionDetail = "Basement floor";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E22";
                  junction4.Defaul = 0.07;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E23", false) == 0)
                {
                  junction4.JunctionDetail = "Balcony within or between dwellings, balcony support";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E23";
                  junction4.Defaul = 1.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E24", false) == 0)
                {
                  junction4.JunctionDetail = "Eaves (insulation at ceiling level - inverted)";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E24";
                  junction4.Defaul = 0.24;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "E25", false) == 0)
                {
                  junction4.JunctionDetail = "Staggered party wall between dwellings";
                  junction4.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction4.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction4.IsAccredited = true;
                  else
                    junction4.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction4.Ref = "E25";
                  junction4.Defaul = 0.12;
                  SAP_Module.Proj.Dwellings[index1].Thermal.ExternalJunctions.Add(junction4);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P01", false) == 0)
                {
                  junction5.JunctionDetail = "Ground floor";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P1";
                  junction5.Defaul = 0.16;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P02", false) == 0)
                {
                  junction5.JunctionDetail = "Intermediate floor within a dwelling";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P2";
                  junction5.Defaul = 0.0;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P03", false) == 0)
                {
                  junction5.JunctionDetail = "Intermediate floor between dwellings (in blocks of flats)";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                  {
                    junction5.IsDefault = true;
                    junction5.Defaul = 0.0;
                  }
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P3";
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P04", false) == 0)
                {
                  junction5.JunctionDetail = "Roof (insulation at ceiling level)";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P4";
                  junction5.Defaul = 0.24;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P05", false) == 0)
                {
                  junction5.JunctionDetail = "Roof (insulation at rafter level)";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P5";
                  junction5.Defaul = 0.08;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P06", false) == 0)
                {
                  junction5.JunctionDetail = "Ground floor (inverted)";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P6";
                  junction5.Defaul = 0.07;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P07", false) == 0)
                {
                  junction5.JunctionDetail = "Exposed floor (normal)";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P7";
                  junction5.Defaul = 0.16;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "P08", false) == 0)
                {
                  junction5.JunctionDetail = "Exposed floor (inverted)";
                  junction5.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction5.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction5.IsAccredited = true;
                  else
                    junction5.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction5.Ref = "P8";
                  junction5.Defaul = 0.24;
                  SAP_Module.Proj.Dwellings[index1].Thermal.PartyJunctions.Add(junction5);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R01", false) == 0)
                {
                  junction6.JunctionDetail = "Head";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R1";
                  junction6.Defaul = 0.08;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R02", false) == 0)
                {
                  junction6.JunctionDetail = "Sill";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R2";
                  junction6.Defaul = 0.06;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R03", false) == 0)
                {
                  junction6.JunctionDetail = "Jamb";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R3";
                  junction6.Defaul = 0.08;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R04", false) == 0)
                {
                  junction6.JunctionDetail = "Ridge (vaulted ceiling)";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R4";
                  junction6.Defaul = 0.08;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R05", false) == 0)
                {
                  junction6.JunctionDetail = "Ridge (inverted)";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R5";
                  junction6.Defaul = 0.04;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R06", false) == 0)
                {
                  junction6.JunctionDetail = "Flat ceiling";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R6";
                  junction6.Defaul = 0.06;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R07", false) == 0)
                {
                  junction6.JunctionDetail = "Flat ceiling (inverted)";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R7";
                  junction6.Defaul = 0.04;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R08", false) == 0)
                {
                  junction6.JunctionDetail = "Roof wall (rafter)";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R8";
                  junction6.Defaul = 0.06;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(csvpsiProjects.Details[index2].Element[index3], "R09", false) == 0)
                {
                  junction6.JunctionDetail = "Roof wall (flat ceiling)";
                  junction6.Length = Conversions.ToSingle(csvpsiProjects.Details[index2].Length[index3]);
                  if (string.IsNullOrEmpty(csvpsiProjects.Details[index2].Value[index3]))
                    junction6.IsDefault = true;
                  else if (csvpsiProjects.Details[index2].Value[index3].ToLower().Contains("acd"))
                    junction6.IsAccredited = true;
                  else
                    junction6.ThermalTransmittance = Conversions.ToSingle(csvpsiProjects.Details[index2].Value[index3]);
                  junction6.Ref = "R9";
                  junction6.Defaul = 0.04;
                  SAP_Module.Proj.Dwellings[index1].Thermal.RoofJunctions.Add(junction6);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              checked { ++index3; }
            }
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      this.TotalIt();
      SAP_Module.NoCalc = false;
      SAP_Module.Dwelling dwelling;
      return dwelling;
    }

    public void TotalIt()
    {
      try
      {
        int num1 = checked (SAP_Module.Proj.NoOfDwells - 1);
        int index = 0;
        while (index <= num1)
        {
          double num2 = 0.0;
          try
          {
            foreach (SAP_Module.Junction externalJunction in SAP_Module.Proj.Dwellings[index].Thermal.ExternalJunctions)
            {
              if (externalJunction.IsAccredited)
                num2 += externalJunction.Accredited * (double) externalJunction.Length;
              if (externalJunction.IsDefault)
                num2 += externalJunction.Defaul * (double) externalJunction.Length;
            }
          }
          finally
          {
            List<SAP_Module.Junction>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            foreach (SAP_Module.Junction partyJunction in SAP_Module.Proj.Dwellings[index].Thermal.PartyJunctions)
            {
              if (partyJunction.IsAccredited)
                num2 += partyJunction.Accredited * (double) partyJunction.Length;
              if (partyJunction.IsDefault)
                num2 += partyJunction.Defaul * (double) partyJunction.Length;
            }
          }
          finally
          {
            List<SAP_Module.Junction>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            foreach (SAP_Module.Junction roofJunction in SAP_Module.Proj.Dwellings[index].Thermal.RoofJunctions)
            {
              if (roofJunction.IsAccredited)
                num2 += roofJunction.Accredited * (double) roofJunction.Length;
              if (roofJunction.IsDefault)
                num2 += roofJunction.Defaul * (double) roofJunction.Length;
            }
          }
          finally
          {
            List<SAP_Module.Junction>.Enumerator enumerator;
            enumerator.Dispose();
          }
          SAP_Module.Proj.Dwellings[index].Thermal.HtbValue = (float) num2;
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public SAP_Module.Dwelling ConvertTExcelPSIToDwelling(string file)
    {
      Application application = (Application) new ApplicationClass();
      Workbook workbook = application.Workbooks.Open(file, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
      Worksheet worksheet = (Worksheet) workbook.Worksheets[(object) "PSI"];
      Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      PSI psi = new PSI();
      int count = usedRange.Rows.Count;
      int RowIndex = 1;
      while (RowIndex <= count)
      {
        psi.Length.Add(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
        psi.Elements.Add(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
        checked { ++RowIndex; }
      }
      workbook.Close((object) true, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
      application.Quit();
      this.releaseObject((object) application);
      this.releaseObject((object) workbook);
      this.releaseObject((object) worksheet);
      int num1 = checked (psi.Elements.Count - 1);
      int index1 = 1;
      while (index1 <= num1)
      {
        if (psi.Elements[index1] == null)
          psi.Elements[index1] = "";
        checked { ++index1; }
      }
      int num2 = checked (psi.Length.Count - 1);
      int index2 = 1;
      while (index2 <= num2)
      {
        if (psi.Length[index2] == null)
          psi.Length[index2] = "";
        checked { ++index2; }
      }
      int num3 = checked (SAP_Module.Proj.NoOfDwells - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        SAP_Module.Proj.Dwellings[index3].Thermal.ManualHtb = true;
        int num4;
        int num5 = num4;
        int num6 = checked (psi.Elements.Count - 1);
        int index4 = num5;
        while (index4 <= num6)
        {
          if (Operators.CompareString(psi.Elements[index4], "", false) == 0 & index4 > 1)
          {
            checked { ++index4; }
            break;
          }
          if (index4 > 1)
          {
            string name;
            if (Operators.CompareString(SAP_Module.Proj.Dwellings[index3].Name, psi.Elements[index4], false) == 0)
            {
              name = SAP_Module.Proj.Dwellings[index3].Name;
              checked { ++index4; }
            }
            if (SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions == null)
              SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
            if (SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions == null)
              SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions = new List<SAP_Module.Junction>();
            if (SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions == null)
              SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions = new List<SAP_Module.Junction>();
            if (Operators.CompareString(name, SAP_Module.Proj.Dwellings[index3].Name, false) == 0)
            {
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E01", false) == 0)
                {
                  junction1.JunctionDetail = "Steel lintel with perforated steel base plate";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E1";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E02", false) == 0)
                {
                  junction1.JunctionDetail = "Other lintels (including other steel lintels)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E2";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E03", false) == 0)
                {
                  junction1.JunctionDetail = "Sill";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E3";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E04", false) == 0)
                {
                  junction1.JunctionDetail = "Jamb";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E4";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E05", false) == 0)
                {
                  junction1.JunctionDetail = "Ground floor (normal)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E5";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E06", false) == 0)
                {
                  junction1.JunctionDetail = "Intermediate floor within a dwelling";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E6";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E07", false) == 0)
                {
                  junction1.JunctionDetail = "Party floor between dwellings (in blocks of flats)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E7";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E08", false) == 0)
                {
                  junction1.JunctionDetail = "Balcony within a dwelling, wall insulation continuous";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E8";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E09", false) == 0)
                {
                  junction1.JunctionDetail = "Balcony between dwellings, wall insulation continuous";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E9";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E10", false) == 0)
                {
                  junction1.JunctionDetail = "Eaves (insulation at ceiling level)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E10";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E11", false) == 0)
                {
                  junction1.JunctionDetail = "Eaves (insulation at rafter level)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E11";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E12", false) == 0)
                {
                  junction1.JunctionDetail = "Gable (insulation at ceiling level)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E12";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E13", false) == 0)
                {
                  junction1.JunctionDetail = "Gable (insulation at rafter level)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E13";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E14", false) == 0)
                {
                  junction1.JunctionDetail = "Flat roof";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E14";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E15", false) == 0)
                {
                  junction1.JunctionDetail = "Flat roof with parapet";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E15";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E16", false) == 0)
                {
                  junction1.JunctionDetail = "Corner (normal)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E16";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E17", false) == 0)
                {
                  junction1.JunctionDetail = "Corner (inverted – internal area greater than external area)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E17";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E18", false) == 0)
                {
                  junction1.JunctionDetail = "Party wall between dwellings";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E18";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E19", false) == 0)
                {
                  junction1.JunctionDetail = "Ground floor (inverted)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E19";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E20", false) == 0)
                {
                  junction1.JunctionDetail = "Exposed floor (normal)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E20";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E21", false) == 0)
                {
                  junction1.JunctionDetail = "Exposed floor (inverted)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E21";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E22", false) == 0)
                {
                  junction1.JunctionDetail = "Basement floor";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E22";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E23", false) == 0)
                {
                  junction1.JunctionDetail = "Balcony within or between dwellings, balcony support";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E23";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E24", false) == 0)
                {
                  junction1.JunctionDetail = "Eaves (insulation at ceiling level - inverted)";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E24";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "E25", false) == 0)
                {
                  junction1.JunctionDetail = "Staggered party wall between dwellings";
                  junction1.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction1.Ref = "E25";
                  SAP_Module.Proj.Dwellings[index3].Thermal.ExternalJunctions.Add(junction1);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P01", false) == 0)
                {
                  junction2.JunctionDetail = "Ground floor";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P1";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P02", false) == 0)
                {
                  junction2.JunctionDetail = "Intermediate floor within a dwelling";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P2";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P03", false) == 0)
                {
                  junction2.JunctionDetail = "Intermediate floor between dwellings (in blocks of flats)";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P3";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P04", false) == 0)
                {
                  junction2.JunctionDetail = "Roof (insulation at ceiling level)";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P4";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P05", false) == 0)
                {
                  junction2.JunctionDetail = "Roof (insulation at rafter level)";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P5";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P06", false) == 0)
                {
                  junction2.JunctionDetail = "Ground floor (inverted)";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P6";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P07", false) == 0)
                {
                  junction2.JunctionDetail = "Exposed floor (normal)";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P7";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "P08", false) == 0)
                {
                  junction2.JunctionDetail = "Exposed floor (inverted)";
                  junction2.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction2.Ref = "P8";
                  SAP_Module.Proj.Dwellings[index3].Thermal.PartyJunctions.Add(junction2);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R01", false) == 0)
                {
                  junction3.JunctionDetail = "Head";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R1";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R02", false) == 0)
                {
                  junction3.JunctionDetail = "Sill";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R2";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R03", false) == 0)
                {
                  junction3.JunctionDetail = "Jamb";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R3";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R04", false) == 0)
                {
                  junction3.JunctionDetail = "Ridge (vaulted ceiling)";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R4";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R05", false) == 0)
                {
                  junction3.JunctionDetail = "Ridge (inverted)";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R5";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R06", false) == 0)
                {
                  junction3.JunctionDetail = "Flat ceiling";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R6";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R07", false) == 0)
                {
                  junction3.JunctionDetail = "Flat ceiling (inverted)";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R7";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R08", false) == 0)
                {
                  junction3.JunctionDetail = "Roof wall (rafter)";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R8";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              try
              {
                if (Operators.CompareString(psi.Elements[index4], "R09", false) == 0)
                {
                  junction3.JunctionDetail = "Roof wall (flat ceiling)";
                  junction3.Length = Conversions.ToSingle(psi.Length[index4]);
                  junction3.Ref = "R9";
                  SAP_Module.Proj.Dwellings[index3].Thermal.RoofJunctions.Add(junction3);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
          }
          checked { ++index4; }
        }
        num4 = index4;
        checked { ++index3; }
      }
      SAP_Module.NoCalc = false;
      SAP_Module.Dwelling dwelling;
      return dwelling;
    }

    private bool NotNull(string Text) => !string.IsNullOrEmpty(Text);

    private void releaseObject(object obj)
    {
      try
      {
        Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
        obj = (object) null;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = (object) null;
        ProjectData.ClearProjectError();
      }
      finally
      {
        GC.Collect();
      }
    }

    private string GetOrientation(string Value)
    {
      string orientation = "";
      if (Value == null)
        Value = "";
      string str = Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 702965234:
          if (Operators.CompareString(str, "NW", false) == 0)
          {
            orientation = "North West";
            break;
          }
          break;
        case 937851900:
          if (Operators.CompareString(str, "NE", false) == 0)
          {
            orientation = "North East";
            break;
          }
          break;
        case 1543670565:
          if (Operators.CompareString(str, "SE", false) == 0)
          {
            orientation = "South East";
            break;
          }
          break;
        case 1778557231:
          if (Operators.CompareString(str, "SW", false) == 0)
          {
            orientation = "South West";
            break;
          }
          break;
        case 3222007936:
          if (Operators.CompareString(str, "E", false) == 0)
          {
            orientation = "East";
            break;
          }
          break;
        case 3406561745:
          if (Operators.CompareString(str, "N", false) == 0)
          {
            orientation = "North";
            break;
          }
          break;
        case 3524005078:
          if (Operators.CompareString(str, "W", false) == 0)
          {
            orientation = "West";
            break;
          }
          break;
        case 3591115554:
          if (Operators.CompareString(str, "S", false) == 0)
          {
            orientation = "South";
            break;
          }
          break;
      }
      return orientation;
    }

    public class CSVAlistair_DImProjects
    {
      public CSVAlistair_DImProjects()
      {
        this.Name = new List<string>();
        this.Details = new List<ExcelImportAreas.CSVAlistairArea>();
      }

      public List<string> Name { get; set; }

      public List<ExcelImportAreas.CSVAlistairArea> Details { get; set; }
    }

    public class CSVProjects
    {
      public CSVProjects()
      {
        this.Name = new List<string>();
        this.Details = new List<ExcelImportAreas.CSVImportArea>();
      }

      public List<string> Name { get; set; }

      public List<ExcelImportAreas.CSVImportArea> Details { get; set; }
    }

    public class CSVPSIProjects
    {
      public CSVPSIProjects()
      {
        this.Name = new List<string>();
        this.Details = new List<ExcelImportAreas.CSVAlistairPSI>();
      }

      public List<string> Name { get; set; }

      public List<ExcelImportAreas.CSVAlistairPSI> Details { get; set; }
    }

    public class CSVImportArea
    {
      public CSVImportArea()
      {
        this.Element = new List<string>();
        this.Area = new List<string>();
        this.Orientation = new List<string>();
        this.CompassPoint = new List<string>();
        this.Pitch = new List<string>();
        this.AssignedSurface = new List<string>();
      }

      public List<string> Element { get; set; }

      public List<string> Area { get; set; }

      public List<string> Orientation { get; set; }

      public List<string> CompassPoint { get; set; }

      public List<string> Pitch { get; set; }

      public List<string> AssignedSurface { get; set; }
    }

    public class CSVAlistairPSI
    {
      public CSVAlistairPSI()
      {
        this.Element = new List<string>();
        this.Length = new List<string>();
        this.Value = new List<string>();
      }

      public string Name { get; set; }

      public List<string> Element { get; set; }

      public List<string> Length { get; set; }

      public List<string> Value { get; set; }
    }

    public class CSVAlistairArea
    {
      public CSVAlistairArea()
      {
        this.Element = new List<string>();
        this.Area = new List<string>();
        this.Height = new List<string>();
      }

      public string Name { get; set; }

      public List<string> Element { get; set; }

      public List<string> Area { get; set; }

      public List<string> Height { get; set; }

      public string Room_in_roof { get; set; }

      public string LivingArea { get; set; }

      public string Sheltered_sides { get; set; }

      public string ThermalMass { get; set; }
    }
  }
}
