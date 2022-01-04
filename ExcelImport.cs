
// Type: SAP2012.ExcelImport




using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SAP2012
{
  public class ExcelImport
  {
    public SAP_Module.Dwelling ConvertToDwelling(string File)
    {
      // ISSUE: variable of a compiler-generated type
      ExcelImport._Closure\u0024__1\u002D0 closure10_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ExcelImport._Closure\u0024__1\u002D0 closure10_2 = new ExcelImport._Closure\u0024__1\u002D0(closure10_1);
      SAP_Module.Dwelling dwelling = new SAP_Module.Dwelling();
      SAP_Module.CurrDwelling = -1;
      int RowIndex1 = 3;
      Application application = (Application) new ApplicationClass();
      Workbook workbook = application.Workbooks.Open(File, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
      Worksheet worksheet = (Worksheet) workbook.Worksheets[(object) "Import Sheet"];
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex1, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Dwelling Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex1, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex1, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex2 = checked (RowIndex1 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex2, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Dwelling Reference", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex2, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Reference = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex2, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex3 = checked (RowIndex2 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex3, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Summer overheating", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex3, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Overheat = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex3, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex4 = checked (RowIndex3 + 1);
      int RowIndex5;
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex4, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Date Assessment", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex4, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.DateAssessment = Conversions.ToDate(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex4, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
        RowIndex5 = checked (RowIndex4 + 1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        RowIndex5 = checked (RowIndex4 + 1);
        ProjectData.ClearProjectError();
      }
      int RowIndex6;
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex5, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Date Cert", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex5, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.DateCertificate = Conversions.ToDate(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex5, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
        RowIndex6 = checked (RowIndex5 + 1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        RowIndex6 = checked (RowIndex5 + 1);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex6, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Assessment Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex6, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Status = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex6, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex7 = checked (RowIndex6 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex7, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Transaction Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex7, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Transaction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex7, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex8 = checked (RowIndex7 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex8, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Tenure Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex8, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Tenure = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex8, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex9 = checked (RowIndex8 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex9, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Disclosure", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex9, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RPD = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex9, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex10 = checked (RowIndex9 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex10, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Thermal Mass", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex10, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.TMP.Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex10, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex11 = checked (RowIndex10 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex11, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Indicative", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex11, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.TMP.Indicative = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex11, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex12 = checked (RowIndex11 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex12, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Address 1", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex12, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Address.Line1 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex12, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex13 = checked (RowIndex12 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex13, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Address 2", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex13, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Address.Line2 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex13, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex14 = checked (RowIndex13 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex14, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Address 3", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex14, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Address.Line3 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex14, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex15 = checked (RowIndex14 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex15, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "City", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex15, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Address.City = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex15, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex16 = checked (RowIndex15 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex16, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Post Code", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex16, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Address.PostCost = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex16, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex17 = checked (RowIndex16 + 1);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex17, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Country", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex17, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Address.Country = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex17, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      int RowIndex18 = checked (RowIndex17 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex18, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Property Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex18, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PropertyType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex18, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex19 = checked (RowIndex18 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex19, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Built Form", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex19, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.BuildForm = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex19, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex20 = checked (RowIndex19 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex20, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Flat Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex20, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.FlatType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex20, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex21 = checked (RowIndex20 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex21, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Year Complete", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex21, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.YearBuilt = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex21, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex22 = checked (RowIndex21 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex22, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Location", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex22, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex22, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex23 = checked (RowIndex22 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex23, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Terrain", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex23, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Terrain = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex23, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex24 = checked (RowIndex23 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex24, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Orientation", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex24, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Orientation = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex24, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex25 = checked (RowIndex24 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex25, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Smoke Control", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex25, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.SmokeArea = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex25, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex26 = checked (RowIndex25 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex26, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Overshading", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex26, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Overshading = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex26, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex27 = checked (RowIndex26 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex27, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "125l/p/p/d", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex27, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex27, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Yes", false))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LessThan125Litre = true;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex28 = checked (RowIndex27 + 1);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.EPCLanguage = "English";
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.UPRN = "000000";
      int RowIndex29;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex28, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys = 0;
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys; }
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims), (Array) new SAP_Module.Dimensions[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1 + 1)]);
        local = dimensionsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex28, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Basement", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex28, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Basement = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex28, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex30 = checked (RowIndex28 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex30, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Ground Floor Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex30, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex30, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex31 = checked (RowIndex30 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex31, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Ground Floor Height", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex31, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Height = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex31, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex29 = checked (RowIndex31 + 1);
      }
      else
        RowIndex29 = checked (RowIndex28 + 3);
      int RowIndex32;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex29, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys; }
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims), (Array) new SAP_Module.Dimensions[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1 + 1)]);
        local = dimensionsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex29, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "1st Floor Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex29, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex29, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex33 = checked (RowIndex29 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex33, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "1st Floor Height", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex33, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Height = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex33, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex32 = checked (RowIndex33 + 1);
      }
      else
        RowIndex32 = checked (RowIndex29 + 2);
      int RowIndex34;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex32, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys; }
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims), (Array) new SAP_Module.Dimensions[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1 + 1)]);
        local = dimensionsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex32, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "2nd Floor Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex32, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex32, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex35 = checked (RowIndex32 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex35, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "2nd Floor Height", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex35, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Height = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex35, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex34 = checked (RowIndex35 + 1);
      }
      else
        RowIndex34 = checked (RowIndex32 + 2);
      int RowIndex36;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex34, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys; }
        // ISSUE: variable of a reference type
        SAP_Module.Dimensions[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Dimensions[] dimensionsArray = (SAP_Module.Dimensions[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims), (Array) new SAP_Module.Dimensions[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1 + 1)]);
        local = dimensionsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Storeys - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex34, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "3rd Floor Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex34, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex34, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex37 = checked (RowIndex34 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex37, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "3rd Floor Height", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex37, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Dims[index].Height = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex37, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex36 = checked (RowIndex37 + 1);
      }
      else
        RowIndex36 = checked (RowIndex34 + 2);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex36, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Living", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex36, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LivingArea = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex36, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex38 = checked (RowIndex36 + 1);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors = 0;
      int RowIndex39;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex38 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex38, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex38, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex38, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex40 = checked (RowIndex38 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex40, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 1 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex40, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex40, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex41 = checked (RowIndex40 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex41, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex41, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex41, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex42 = checked (RowIndex41 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex42, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex42, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex42, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex43 = checked (RowIndex42 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex43, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 1 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex43, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex43, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex39 = checked (RowIndex43 + 1);
      }
      else
        RowIndex39 = checked (RowIndex38 + 5);
      int RowIndex44;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex39 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex39, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex39, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex39, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex45 = checked (RowIndex39 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex45, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 2 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex45, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex45, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex46 = checked (RowIndex45 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex46, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex46, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex46, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex47 = checked (RowIndex46 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex47, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex47, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex47, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex48 = checked (RowIndex47 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex48, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 2 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex48, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex48, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex44 = checked (RowIndex48 + 1);
      }
      else
        RowIndex44 = checked (RowIndex39 + 5);
      int RowIndex49;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex44 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex44, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 3 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex44, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex44, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex50 = checked (RowIndex44 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex50, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 3 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex50, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex50, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex51 = checked (RowIndex50 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex51, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 3 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex51, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex51, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex52 = checked (RowIndex51 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex52, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 3 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex52, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex52, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex53 = checked (RowIndex52 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex53, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 3 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex53, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex53, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex49 = checked (RowIndex53 + 1);
      }
      else
        RowIndex49 = checked (RowIndex44 + 5);
      int RowIndex54;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex49 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex49, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 4 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex49, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex49, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex55 = checked (RowIndex49 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex55, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 4 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex55, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex55, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex56 = checked (RowIndex55 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex56, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 4 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex56, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex56, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex57 = checked (RowIndex56 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex57, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 4 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex57, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex57, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex58 = checked (RowIndex57 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex58, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Floor 4 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex58, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Floors[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex58, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex54 = checked (RowIndex58 + 1);
      }
      else
        RowIndex54 = checked (RowIndex49 + 5);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls = 0;
      int RowIndex59;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex54 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex54, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex54, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex54, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex60 = checked (RowIndex54 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex60, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 1 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex60, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex60, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex61 = checked (RowIndex60 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex61, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex61, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex61, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex62 = checked (RowIndex61 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex62, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex62, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex62, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex63 = checked (RowIndex62 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex63, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 1 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex63, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex63, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex64 = checked (RowIndex63 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex64, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 1 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex64, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex64, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex59 = checked (RowIndex64 + 1);
      }
      else
        RowIndex59 = checked (RowIndex54 + 6);
      int RowIndex65;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex59 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex59, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex59, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex59, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex66 = checked (RowIndex59 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex66, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 2 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex66, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex66, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex67 = checked (RowIndex66 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex67, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex67, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex67, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex68 = checked (RowIndex67 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex68, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex68, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex68, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex69 = checked (RowIndex68 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex69, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 2 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex69, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex69, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex70 = checked (RowIndex69 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex70, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 2 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex70, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex70, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex65 = checked (RowIndex70 + 1);
      }
      else
        RowIndex65 = checked (RowIndex59 + 6);
      int RowIndex71;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex65 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex65, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 3 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex65, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex65, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex72 = checked (RowIndex65 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex72, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 3 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex72, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex72, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex73 = checked (RowIndex72 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex73, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 3 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex73, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex73, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex74 = checked (RowIndex73 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex74, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 3 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex74, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex74, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex75 = checked (RowIndex74 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex75, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 3 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex75, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex75, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex76 = checked (RowIndex75 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex76, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 3 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex76, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex76, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex71 = checked (RowIndex76 + 1);
      }
      else
        RowIndex71 = checked (RowIndex65 + 6);
      int RowIndex77;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex71 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex71, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 4 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex71, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex71, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex78 = checked (RowIndex71 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex78, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 4 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex78, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex78, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex79 = checked (RowIndex78 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex79, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 4 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex79, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex79, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex80 = checked (RowIndex79 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex80, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 4 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex80, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex80, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex81 = checked (RowIndex80 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex81, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 4 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex81, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex81, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex82 = checked (RowIndex81 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex82, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 4 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex82, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex82, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex77 = checked (RowIndex82 + 1);
      }
      else
        RowIndex77 = checked (RowIndex71 + 6);
      int RowIndex83;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex77 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex77, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 5 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex77, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex77, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex84 = checked (RowIndex77 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex84, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 5 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex84, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex84, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex85 = checked (RowIndex84 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex85, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 5 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex85, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex85, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex86 = checked (RowIndex85 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex86, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 5 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex86, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex86, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex87 = checked (RowIndex86 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex87, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 5 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex87, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex87, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex88 = checked (RowIndex87 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex88, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 5 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex88, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex88, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex83 = checked (RowIndex88 + 1);
      }
      else
        RowIndex83 = checked (RowIndex77 + 6);
      int RowIndex89;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex83 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex83, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 6 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex83, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex83, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex90 = checked (RowIndex83 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex90, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 6 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex90, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex90, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex91 = checked (RowIndex90 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex91, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 6 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex91, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex91, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex92 = checked (RowIndex91 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex92, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 6 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex92, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex92, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex93 = checked (RowIndex92 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex93, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 6 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex93, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex93, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex94 = checked (RowIndex93 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex94, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Wall 6 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex94, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Walls[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex94, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex89 = checked (RowIndex94 + 1);
      }
      else
        RowIndex89 = checked (RowIndex83 + 6);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs = 0;
      int RowIndex95;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex89 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex89, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex89, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex89, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex96 = checked (RowIndex89 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex96, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 1 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex96, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex96, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex97 = checked (RowIndex96 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex97, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex97, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex97, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex98 = checked (RowIndex97 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex98, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex98, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex98, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex99 = checked (RowIndex98 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex99, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 1 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex99, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex99, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex100 = checked (RowIndex99 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex100, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 1 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex100, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex100, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex95 = checked (RowIndex100 + 1);
      }
      else
        RowIndex95 = checked (RowIndex89 + 6);
      int RowIndex101;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex95 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex95, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex95, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex95, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex102 = checked (RowIndex95 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex102, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 2 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex102, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex102, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex103 = checked (RowIndex102 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex103, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex103, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex103, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex104 = checked (RowIndex103 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex104, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex104, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex104, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex105 = checked (RowIndex104 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex105, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 2 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex105, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex105, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex106 = checked (RowIndex105 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex106, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 2 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex106, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex106, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex101 = checked (RowIndex106 + 1);
      }
      else
        RowIndex101 = checked (RowIndex95 + 6);
      int RowIndex107;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex101 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex101, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 3 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex101, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex101, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex108 = checked (RowIndex101 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex108, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 3 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex108, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex108, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex109 = checked (RowIndex108 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex109, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 3 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex109, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex109, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex110 = checked (RowIndex109 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex110, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 3 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex110, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex110, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex111 = checked (RowIndex110 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex111, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 3 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex111, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex111, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex112 = checked (RowIndex111 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex112, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 3 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex112, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex112, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex107 = checked (RowIndex112 + 1);
      }
      else
        RowIndex107 = checked (RowIndex101 + 6);
      int RowIndex113;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex107 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex107, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 4 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex107, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex107, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex114 = checked (RowIndex107 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex114, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 4 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex114, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex114, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex115 = checked (RowIndex114 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex115, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 4 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex115, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex115, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex116 = checked (RowIndex115 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex116, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 4 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex116, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex116, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex117 = checked (RowIndex116 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex117, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 4 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex117, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex117, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex118 = checked (RowIndex117 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex118, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 4 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex118, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex118, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex113 = checked (RowIndex118 + 1);
      }
      else
        RowIndex113 = checked (RowIndex107 + 6);
      int RowIndex119;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex113 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex113, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 5 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex113, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex113, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex120 = checked (RowIndex113 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex120, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 5 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex120, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex120, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex121 = checked (RowIndex120 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex121, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 5 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex121, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex121, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex122 = checked (RowIndex121 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex122, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 5 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex122, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex122, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex123 = checked (RowIndex122 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex123, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 5 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex123, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex123, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex124 = checked (RowIndex123 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex124, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 5 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex124, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex124, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex119 = checked (RowIndex124 + 1);
      }
      else
        RowIndex119 = checked (RowIndex113 + 6);
      int RowIndex125;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex119 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs; }
        // ISSUE: variable of a reference type
        SAP_Module.Opaques[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.Opaques[] opaquesArray = (SAP_Module.Opaques[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs), (Array) new SAP_Module.Opaques[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1 + 1)]);
        local = opaquesArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofs - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex119, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 6 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex119, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex119, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex126 = checked (RowIndex119 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex126, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 6 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex126, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex126, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex127 = checked (RowIndex126 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex127, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 6 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex127, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex127, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex128 = checked (RowIndex127 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex128, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 6 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex128, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex128, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex129 = checked (RowIndex128 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex129, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 6 U-Value", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex129, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].U_Value = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex129, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex130 = checked (RowIndex129 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex130, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "External Roof 6 Adjacent", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex130, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Roofs[index].Ru = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex130, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex125 = checked (RowIndex130 + 1);
      }
      else
        RowIndex125 = checked (RowIndex119 + 6);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors = 0;
      int RowIndex131;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex125 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex125, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Floor 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex125, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex125, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex132 = checked (RowIndex125 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex132, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Floor 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex132, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex132, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex133 = checked (RowIndex132 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex133, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Floor 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex133, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex133, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex131 = checked (RowIndex133 + 1);
      }
      else
        RowIndex131 = checked (RowIndex125 + 3);
      int RowIndex134;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex131 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofpFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex131, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Floor 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex131, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex131, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex135 = checked (RowIndex131 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex135, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Floor 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex135, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex135, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex136 = checked (RowIndex135 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex136, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Floor 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex136, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PFloors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex136, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex134 = checked (RowIndex136 + 1);
      }
      else
        RowIndex134 = checked (RowIndex131 + 3);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls = 0;
      int RowIndex137;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex134 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyWall[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyWall[] partyWallArray = (SAP_Module.PartyWall[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls), (Array) new SAP_Module.PartyWall[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls - 1 + 1)]);
        local = partyWallArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex134, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex134, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex134, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex138 = checked (RowIndex134 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex138, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 1 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex138, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex138, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex139 = checked (RowIndex138 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex139, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex139, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex139, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex140 = checked (RowIndex139 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex140, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex140, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex140, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex137 = checked (RowIndex140 + 1);
      }
      else
        RowIndex137 = checked (RowIndex134 + 4);
      int RowIndex141;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex137 + 3), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyWall[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyWall[] partyWallArray = (SAP_Module.PartyWall[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls), (Array) new SAP_Module.PartyWall[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls - 1 + 1)]);
        local = partyWallArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex137, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex137, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex137, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex142 = checked (RowIndex137 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex142, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 2 Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex142, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Type = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex142, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex143 = checked (RowIndex142 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex143, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex143, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex143, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex144 = checked (RowIndex143 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex144, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Wall 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex144, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex144, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex141 = checked (RowIndex144 + 1);
      }
      else
        RowIndex141 = checked (RowIndex137 + 4);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings = 0;
      int RowIndex145;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex141 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex141, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Ceiling 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex141, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex141, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex146 = checked (RowIndex141 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex146, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Ceiling 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex146, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex146, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex147 = checked (RowIndex146 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex147, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Ceiling 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex147, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex147, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex145 = checked (RowIndex147 + 1);
      }
      else
        RowIndex145 = checked (RowIndex141 + 3);
      int RowIndex148;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex145 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofPCeilings - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex145, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Ceiling 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex145, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex145, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex149 = checked (RowIndex145 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex149, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Ceiling 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex149, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex149, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex150 = checked (RowIndex149 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex150, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Party Ceiling 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex150, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.PCeilings[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex150, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex148 = checked (RowIndex150 + 1);
      }
      else
        RowIndex148 = checked (RowIndex145 + 3);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors = 0;
      int RowIndex151;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex148 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex148, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex148, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex148, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex152 = checked (RowIndex148 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex152, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex152, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex152, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex153 = checked (RowIndex152 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex153, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex153, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex153, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex151 = checked (RowIndex153 + 1);
      }
      else
        RowIndex151 = checked (RowIndex148 + 3);
      int RowIndex154;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex151 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex151, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex151, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex151, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex155 = checked (RowIndex151 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex155, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex155, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex155, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex156 = checked (RowIndex155 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex156, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex156, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex156, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex154 = checked (RowIndex156 + 1);
      }
      else
        RowIndex154 = checked (RowIndex151 + 3);
      int RowIndex157;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex154 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIFloors - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex154, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 3 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex154, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex154, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex158 = checked (RowIndex154 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex158, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 3 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex158, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex158, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex159 = checked (RowIndex158 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex159, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Floor 3 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex159, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IFloors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex159, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex157 = checked (RowIndex159 + 1);
      }
      else
        RowIndex157 = checked (RowIndex154 + 3);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls = 0;
      int RowIndex160;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex157 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex157, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex157, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex157, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex161 = checked (RowIndex157 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex161, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex161, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex161, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex162 = checked (RowIndex161 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex162, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex162, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex162, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex160 = checked (RowIndex162 + 1);
      }
      else
        RowIndex160 = checked (RowIndex157 + 3);
      int RowIndex163;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex160 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex160, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex160, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex160, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex164 = checked (RowIndex160 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex164, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex164, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex164, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex165 = checked (RowIndex164 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex165, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex165, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex165, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex163 = checked (RowIndex165 + 1);
      }
      else
        RowIndex163 = checked (RowIndex160 + 3);
      int RowIndex166;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex163 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex163, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 3 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex163, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex163, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex167 = checked (RowIndex163 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex167, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 3 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex167, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex167, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex168 = checked (RowIndex167 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex168, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 3 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex168, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex168, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex166 = checked (RowIndex168 + 1);
      }
      else
        RowIndex166 = checked (RowIndex163 + 3);
      int RowIndex169;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex166 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex166, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 4 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex166, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex166, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex170 = checked (RowIndex166 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex170, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 4 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex170, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex170, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex171 = checked (RowIndex170 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex171, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 4 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex171, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex171, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex169 = checked (RowIndex171 + 1);
      }
      else
        RowIndex169 = checked (RowIndex166 + 3);
      int RowIndex172;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex169 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofIWalls - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex169, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 5 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex169, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex169, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex173 = checked (RowIndex169 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex173, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 5 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex173, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex173, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Construction, 1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex174 = checked (RowIndex173 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex174, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Wall 5 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex174, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.IWalls[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex174, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex172 = checked (RowIndex174 + 1);
      }
      else
        RowIndex172 = checked (RowIndex169 + 3);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings = 0;
      int RowIndex175;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex172 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex172, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 1 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex172, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex172, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex176 = checked (RowIndex172 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex176, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 1 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex176, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex176, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex177 = checked (RowIndex176 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex177, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 1 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex177, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex177, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex175 = checked (RowIndex177 + 1);
      }
      else
        RowIndex175 = checked (RowIndex172 + 3);
      int RowIndex178;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex175 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings - 1 + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex175, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 2 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex175, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex175, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex179 = checked (RowIndex175 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex179, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 2 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex179, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex179, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex180 = checked (RowIndex179 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex180, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 2 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex180, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex180, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex178 = checked (RowIndex180 + 1);
      }
      else
        RowIndex178 = checked (RowIndex175 + 3);
      int RowIndex181;
      if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex178 + 2), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
      {
        // ISSUE: reference to a compiler-generated field
        checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings; }
        // ISSUE: variable of a reference type
        SAP_Module.PartyElements[]& local;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        SAP_Module.PartyElements[] partyElementsArray = (SAP_Module.PartyElements[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings), (Array) new SAP_Module.PartyElements[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings + 1)]);
        local = partyElementsArray;
        // ISSUE: reference to a compiler-generated field
        int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofICeilings - 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex178, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 3 Name", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex178, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex178, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex182 = checked (RowIndex178 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex182, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 3 Construction", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex182, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Construction = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex182, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].K = MyProject.Forms.SAPForm.ShowMeK(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Construction, 0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        int RowIndex183 = checked (RowIndex182 + 1);
        try
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex183, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Internal Ceiling 3 Area", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex183, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
          {
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.ICeilings[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex183, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        RowIndex181 = checked (RowIndex183 + 1);
      }
      else
        RowIndex181 = checked (RowIndex178 + 3);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal = new SAP_Module.Thermal();
      SAP_Module.Junction junction1 = new SAP_Module.Junction();
      SAP_Module.Junction junction2 = new SAP_Module.Junction();
      SAP_Module.Junction junction3 = new SAP_Module.Junction();
      // ISSUE: reference to a compiler-generated field
      if (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions == null)
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
      }
      // ISSUE: reference to a compiler-generated field
      if (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions == null)
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions = new List<SAP_Module.Junction>();
      }
      // ISSUE: reference to a compiler-generated field
      if (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions == null)
      {
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions = new List<SAP_Module.Junction>();
      }
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ManualHtb = true;
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex181, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E1 Steel lintel with perforated steel base plate", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex181, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Steel lintel with perforated steel base plate";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex181, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex181, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex181, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E1";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex184 = checked (RowIndex181 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex184, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E2 Other lintels (including other steel lintels)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex184, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Other lintels (including other steel lintels)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex184, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex184, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex184, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E2";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex185 = checked (RowIndex184 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex185, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E3 Sill", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex185, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Sill";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex185, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex185, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex185, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E3";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex186 = checked (RowIndex185 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex186, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E4 Jamb", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex186, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Jamb";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex186, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex186, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex186, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E4";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex187 = checked (RowIndex186 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex187, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E5 Ground floor (normal)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex187, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Ground floor (normal)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex187, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex187, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex187, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E5";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex188 = checked (RowIndex187 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex188, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E6 Intermediate floor within a dwelling", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex188, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Intermediate floor within a dwelling";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex188, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex188, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex188, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E6";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex189 = checked (RowIndex188 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex189, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E7 Party floor between dwellings (in blocks of flats)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex189, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Party floor between dwellings (in blocks of flats)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex189, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex189, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex189, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E7";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex190 = checked (RowIndex189 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex190, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E8 Balcony within a dwelling, wall insulation continuous", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex190, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Balcony within a dwelling, wall insulation continuous";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex190, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex190, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex190, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E8";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex191 = checked (RowIndex190 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex191, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E9 Balcony between dwellings, wall insulation continuous", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex191, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Balcony between dwellings, wall insulation continuous";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex191, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex191, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex191, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E9";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex192 = checked (RowIndex191 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex192, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E10 Eaves (insulation at ceiling level)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex192, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Eaves (insulation at ceiling level)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex192, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex192, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex192, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E10";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex193 = checked (RowIndex192 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex193, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E11 Eaves (insulation at rafter level)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex193, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Eaves (insulation at rafter level)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex193, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex193, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex193, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E11";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex194 = checked (RowIndex193 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex194, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E12 Gable (insulation at ceiling level)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex194, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Gable (insulation at ceiling level)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex194, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex194, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex194, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E12";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex195 = checked (RowIndex194 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex195, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E13 Gable (insulation at rafter level)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex195, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Gable (insulation at rafter level)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex195, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex195, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex195, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E13";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex196 = checked (RowIndex195 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex196, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E14 Flat roof", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex196, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Flat roof";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex196, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex196, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex196, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E14";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex197 = checked (RowIndex196 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex197, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E15 Flat roof with parapet", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex197, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Flat roof with parapet";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex197, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex197, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex197, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E15";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex198 = checked (RowIndex197 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex198, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E16 Corner (normal)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex198, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Corner (normal)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex198, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex198, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex198, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E16";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex199 = checked (RowIndex198 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex199, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E17 Corner (inverted – internal area greater than external area)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex199, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Corner (inverted – internal area greater than external area)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex199, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex199, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex199, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E17";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex200 = checked (RowIndex199 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex200, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E18 Party wall between dwellings", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex200, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Party wall between dwellings";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex200, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex200, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex200, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E18";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex201 = checked (RowIndex200 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex201, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E19 Ground floor (inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex201, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Ground floor (inverted)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex201, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex201, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex201, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E19";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex202 = checked (RowIndex201 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex202, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E20 Exposed floor (normal)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex202, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Exposed floor (normal)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex202, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex202, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex202, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E20";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex203 = checked (RowIndex202 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex203, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E21 Exposed floor (inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex203, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Exposed floor (inverted)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex203, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex203, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex203, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E21";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex204 = checked (RowIndex203 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex204, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E22 Basement floor", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex204, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Basement floor";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex204, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex204, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex204, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E22";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex205 = checked (RowIndex204 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex205, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E23 Balcony within or between dwellings, balcony support", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex205, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Balcony within or between dwellings, balcony support";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex205, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex205, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex205, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E23";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex206 = checked (RowIndex205 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex206, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E24 Eaves (insulation at ceiling level - inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex206, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Eaves (insulation at ceiling level - inverted)";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex206, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex206, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex206, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E24";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex207 = checked (RowIndex206 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex207, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "E25 Staggered party wall between dwellings", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex207, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction1.JunctionDetail = "Staggered party wall between dwellings";
          junction1.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex207, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex207, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction1.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex207, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction1.Ref = "E25";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.ExternalJunctions.Add(junction1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex208 = checked (RowIndex207 + 1);
      try
      {
        if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex208, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("P1 Ground floor") & this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex208, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          junction2.JunctionDetail = "Ground floor";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex208, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex208, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex208, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P1";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex209 = checked (RowIndex208 + 1);
      try
      {
        if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex209, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("P2 Intermediate floor within a dwelling") & this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex209, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          junction2.JunctionDetail = "Intermediate floor within a dwelling";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex209, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex209, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex209, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P2";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex210 = checked (RowIndex209 + 1);
      try
      {
        if (NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex210, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Contains("P3 Intermediate floor between dwellings (in blocks of flats)") & this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex210, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          junction2.JunctionDetail = "Intermediate floor between dwellings (in blocks of flats)";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex210, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex210, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex210, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P3";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex211 = checked (RowIndex210 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex211, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "P4 Roof (insulation at ceiling level)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex211, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction2.JunctionDetail = "Roof (insulation at ceiling level)";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex211, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex211, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex211, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P4";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex212 = checked (RowIndex211 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex212, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "P5 Roof (insulation at rafter level)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex212, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction2.JunctionDetail = "Roof (insulation at rafter level)";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex212, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex212, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex212, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P5";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex213 = checked (RowIndex212 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex213, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "P6 Ground floor (inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex213, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction2.JunctionDetail = "Ground floor (inverted)";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex213, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex213, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex213, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P6";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex214 = checked (RowIndex213 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex214, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "P7 Exposed floor (normal)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex214, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction2.JunctionDetail = "Exposed floor (normal)";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex214, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex214, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex214, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P7";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex215 = checked (RowIndex214 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex215, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "P8 Exposed floor (inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex215, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction2.JunctionDetail = "Exposed floor (inverted)";
          junction2.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex215, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex215, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction2.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex215, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction2.Ref = "P8";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.PartyJunctions.Add(junction2);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex216 = checked (RowIndex215 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex216, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R1 Head", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex216, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Head";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex216, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex216, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex216, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R1";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex217 = checked (RowIndex216 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex217, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R2 Sill", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex217, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Sill";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex217, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex217, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex217, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R2";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex218 = checked (RowIndex217 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex218, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R3 Jamb", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex218, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Jamb";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex218, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex218, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex218, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R3";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex219 = checked (RowIndex218 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex219, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R4 Ridge (vaulted ceiling)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex219, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Ridge (vaulted ceiling)";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex219, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex219, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex219, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R4";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex220 = checked (RowIndex219 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex220, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R5 Ridge (inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex220, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Ridge (inverted)";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex220, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex220, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex220, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R5";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex221 = checked (RowIndex220 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex221, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R6 Flat ceiling", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex221, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Flat ceiling";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex221, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex221, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex221, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R6";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex222 = checked (RowIndex221 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex222, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R7 Flat ceiling (inverted)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex222, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Flat ceiling (inverted)";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex222, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex222, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex222, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R7";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex223 = checked (RowIndex222 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex223, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R8 Roof wall (rafter)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex223, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Roof wall (rafter)";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex223, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex223, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex223, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R8";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex224 = checked (RowIndex223 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex224, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "R9 Roof wall (flat ceiling)", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex224, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          junction3.JunctionDetail = "Roof wall (flat ceiling)";
          junction3.Length = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex224, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex224, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
            junction3.ThermalTransmittance = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex224, (object) 3], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
          junction3.Ref = "R9";
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Thermal.RoofJunctions.Add(junction3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex225 = checked (RowIndex224 + 1);
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofDoors = 0;
      int num1 = 0;
      do
      {
        if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex225 + 8), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          // ISSUE: reference to a compiler-generated field
          checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofDoors; }
          // ISSUE: variable of a reference type
          SAP_Module.Door[]& local;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: explicit reference operation
          // ISSUE: reference to a compiler-generated field
          SAP_Module.Door[] doorArray = (SAP_Module.Door[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors), (Array) new SAP_Module.Door[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofDoors - 1 + 1)]);
          local = doorArray;
          // ISSUE: reference to a compiler-generated field
          int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofDoors - 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Name"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex226 = checked (RowIndex225 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex226, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Location"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex226, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex226, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex227 = checked (RowIndex226 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex227, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Source"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex227, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].UValueSource = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex227, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex228 = checked (RowIndex227 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex228, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Type"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex228, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].DoorType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex228, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex229 = checked (RowIndex228 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex229, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Orientation"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex229, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].Orientation = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex229, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex230 = checked (RowIndex229 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex230, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Overshading"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex230, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].Overshading = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex230, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex231 = checked (RowIndex230 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex231, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Glazing Type"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex231, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].GlazingType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex231, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex232 = checked (RowIndex231 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex232, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Frame"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex232, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FrameType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex232, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex233 = checked (RowIndex232 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex233, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " Area"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex233, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex233, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex234 = checked (RowIndex233 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex234, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " G Fractor"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex234, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].g = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex234, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex235 = checked (RowIndex234 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex235, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " FF"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex235, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FF = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex235, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex236 = checked (RowIndex235 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex236, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Door " + Conversions.ToString(checked (num1 + 1)) + " U-Value"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex236, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].U = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex236, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].UValueSource, "SAP 2012", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            string doorType = closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].DoorType;
            if (Operators.CompareString(doorType, "Solid", false) != 0)
            {
              if (Operators.CompareString(doorType, "Half glazed", false) != 0)
              {
                if (Operators.CompareString(doorType, "Fully glazed", false) == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].U = Functions.Get_Table6e_UValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].GlazingType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FrameType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].AirGap, "Window", closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].ThermalBreak);
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].g = Functions.Check_GValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].GlazingType);
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].U = (float) (((double) Functions.Get_Table6e_UValue("Solid wooden door to outside", "Wood", "6mm, 12mm, 16mm or more", "Door", closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].ThermalBreak) + (double) Functions.Get_Table6e_UValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].GlazingType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FrameType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].AirGap, "Window", closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].ThermalBreak)) / 2.0);
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].U = Functions.Get_Table6e_UValue("Solid wooden door to outside", "Wood", "6mm, 12mm, 16mm or more", "Door", closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].ThermalBreak);
            }
            // ISSUE: reference to a compiler-generated field
            if (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FrameType != null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FF = closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].FrameType.Contains("Metal") ? 0.8f : 0.7f;
            }
          }
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Doors[index].Count = 1;
          RowIndex225 = checked (RowIndex236 + 1);
        }
        else
          checked { RowIndex225 += 12; }
        checked { ++num1; }
      }
      while (num1 <= 5);
      int num2 = 0;
      do
      {
        if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex225 + 9), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          // ISSUE: reference to a compiler-generated field
          checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWindows; }
          // ISSUE: variable of a reference type
          SAP_Module.Window[]& local;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: explicit reference operation
          // ISSUE: reference to a compiler-generated field
          SAP_Module.Window[] windowArray = (SAP_Module.Window[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows), (Array) new SAP_Module.Window[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWindows - 1 + 1)]);
          local = windowArray;
          // ISSUE: reference to a compiler-generated field
          int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofWindows - 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Name"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex237 = checked (RowIndex225 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex237, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Location"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex237, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex237, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex238 = checked (RowIndex237 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex238, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Source"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex238, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].UValueSource = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex238, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex239 = checked (RowIndex238 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex239, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Orientation"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex239, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].Orientation = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex239, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex240 = checked (RowIndex239 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex240, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Overshading"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex240, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].Overshading = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex240, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex241 = checked (RowIndex240 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex241, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Glazing Type"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex241, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].GlazingType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex241, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex242 = checked (RowIndex241 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex242, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Air Gap"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex242, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].AirGap = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex242, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex243 = checked (RowIndex242 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex243, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Frame"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex243, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].FrameType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex243, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex244 = checked (RowIndex243 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex244, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " ThermalBreak"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex244, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].ThermalBreak = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex244, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex245 = checked (RowIndex244 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex245, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " Area"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex245, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex245, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex246 = checked (RowIndex245 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex246, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " G Fractor"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex246, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].g = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex246, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex247 = checked (RowIndex246 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex247, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " FF"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex247, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].FF = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex247, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex248 = checked (RowIndex247 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex248, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("Win " + Conversions.ToString(checked (num2 + 1)) + " U-Value"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex248, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].U = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex248, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          RowIndex225 = checked (RowIndex248 + 1);
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].Count = 1;
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].UValueSource, "SAP 2012", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].U = Functions.Get_Table6e_UValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].GlazingType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].FrameType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].AirGap, "Window", closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].ThermalBreak);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].g = Functions.Check_GValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].GlazingType);
            // ISSUE: reference to a compiler-generated field
            if (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].FrameType != null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].FF = closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Windows[index].FrameType.Contains("Metal") ? 0.8f : 0.7f;
            }
          }
        }
        else
          checked { RowIndex225 += 13; }
        checked { ++num2; }
      }
      while (num2 <= 9);
      int num3 = 0;
      do
      {
        if (this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) checked (RowIndex225 + 10), (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))
        {
          // ISSUE: reference to a compiler-generated field
          checked { ++closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofLights; }
          // ISSUE: variable of a reference type
          SAP_Module.RoofLight[]& local;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: explicit reference operation
          // ISSUE: reference to a compiler-generated field
          SAP_Module.RoofLight[] roofLightArray = (SAP_Module.RoofLight[]) Utils.CopyArray((Array) ^(local = ref closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights), (Array) new SAP_Module.RoofLight[checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofLights - 1 + 1)]);
          local = roofLightArray;
          // ISSUE: reference to a compiler-generated field
          int index = checked (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.NoofRoofLights - 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Name"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Name = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex249 = checked (RowIndex225 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex249, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Location"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex249, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Location = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex249, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex250 = checked (RowIndex249 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex250, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Source"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex250, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].UValueSource = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex250, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex251 = checked (RowIndex250 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex251, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Pitch"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex251, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Pitch = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex251, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex252 = checked (RowIndex251 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex252, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Orientation"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex252, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Orientation = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex252, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex253 = checked (RowIndex252 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex253, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Overshading"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex253, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Overshading = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex253, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex254 = checked (RowIndex253 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex254, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Glazing Type"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex254, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].GlazingType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex254, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex255 = checked (RowIndex254 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex255, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Air Gap"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex255, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].AirGap = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex255, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex256 = checked (RowIndex255 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex256, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Frame"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex256, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].FrameType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex256, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex257 = checked (RowIndex256 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex257, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " ThermalBreak"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex257, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].ThermalBreak = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex257, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex258 = checked (RowIndex257 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex258, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " Area"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex258, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Area = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex258, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex259 = checked (RowIndex258 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex259, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " G Fractor"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex259, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].g = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex259, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex260 = checked (RowIndex259 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex260, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " FF"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex260, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].FF = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex260, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          int RowIndex261 = checked (RowIndex260 + 1);
          try
          {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex261, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) ("RoofLight " + Conversions.ToString(checked (num3 + 1)) + " U-Value"), false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex261, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
            {
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].U = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex261, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          // ISSUE: reference to a compiler-generated field
          if (Operators.CompareString(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].UValueSource, "SAP 2012", false) == 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].U = Functions.Get_Table6e_UValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].GlazingType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].FrameType, closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].AirGap, "Roof Window", closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].ThermalBreak);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].g = Functions.Check_GValue(closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].GlazingType);
            // ISSUE: reference to a compiler-generated field
            if (closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].FrameType != null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].FF = closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].FrameType.Contains("Metal") ? 0.8f : 0.7f;
            }
          }
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.RoofLights[index].Count = 1;
          RowIndex225 = checked (RowIndex261 + 1);
        }
        else
          checked { RowIndex225 += 14; }
        checked { ++num3; }
      }
      while (num3 <= 4);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Chimneys Main Heating", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.ChimneysMain = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex225, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex262 = checked (RowIndex225 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex262, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Chimneys Sec Heating", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex262, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.ChimneysSec = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex262, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex263 = checked (RowIndex262 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex263, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Chimneys Other", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex263, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.ChimneysOther = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex263, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex264 = checked (RowIndex263 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex264, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. open flues Main Heating", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex264, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.FluesMain = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex264, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex265 = checked (RowIndex264 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex265, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. open flues Sec Heating", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex265, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.FluesSec = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex265, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex266 = checked (RowIndex265 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex266, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. open flues Other", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex266, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.FluesOther = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex266, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex267 = checked (RowIndex266 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex267, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Fans", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex267, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.Fans = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex267, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex268 = checked (RowIndex267 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex268, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Passive Vents", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex268, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.Vents = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex268, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex269 = checked (RowIndex268 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex269, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Flue-Less Gas Fire", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex269, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.Fires = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex269, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex270 = checked (RowIndex269 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex270, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "No. Shelt Sides", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex270, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Ventilation.Shelter = Conversions.ToSingle(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex270, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex271 = checked (RowIndex270 + 17);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex271, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Total Light", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex271, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LELOutlets = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex271, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex272 = checked (RowIndex271 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex272, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Total Low Energy Light", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex272, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LELLights = Conversions.ToInteger(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex272, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LowEnergyLight = (float) Math.Round((double) checked (100 * closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LELLights) / (double) closure10_2.\u0024VB\u0024Local_ConvertToDwelling.LELOutlets);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex273 = checked (RowIndex272 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex273, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Buidling Type", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex273, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.OverHeating.EACBuildType = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex273, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex274 = checked (RowIndex273 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex274, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Window Opening", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex274, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.OverHeating.EACWindow = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex274, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
        // ISSUE: reference to a compiler-generated method
        PCDF.Table_P1 tableP1 = SAP_Module.PCDFData.Table_P1s.Where<PCDF.Table_P1>(new Func<PCDF.Table_P1, bool>(closure10_2._Lambda\u0024__0)).SingleOrDefault<PCDF.Table_P1>();
        if (tableP1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.OverHeating.EACAirChange = Conversions.ToSingle(tableP1.ach);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int RowIndex275 = checked (RowIndex274 + 1);
      try
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex275, (object) 1], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "Separated Heated Conservatory", false), (object) this.NotNull(Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex275, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))))))
        {
          // ISSUE: reference to a compiler-generated field
          closure10_2.\u0024VB\u0024Local_ConvertToDwelling.Conservatory = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[(object) RowIndex275, (object) 2], (System.Type) null, "value", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int num4 = checked (RowIndex275 + 1);
      workbook.Close((object) true, RuntimeHelpers.GetObjectValue((object) Missing.Value), RuntimeHelpers.GetObjectValue((object) Missing.Value));
      application.Quit();
      this.releaseObject((object) application);
      this.releaseObject((object) workbook);
      this.releaseObject((object) worksheet);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure10_2.\u0024VB\u0024Local_ConvertToDwelling = closure10_2.\u0024VB\u0024Local_ConvertToDwelling;
      // ISSUE: reference to a compiler-generated field
      return closure10_2.\u0024VB\u0024Local_ConvertToDwelling;
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
  }
}
