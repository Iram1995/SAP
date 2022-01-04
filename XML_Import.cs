
// Type: SAP2012.XML_Import




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace SAP2012
{
  public class XML_Import
  {
    private SAP_Module.Dwelling newDwelling;
    private XNamespace XMLNS;

    public XML_Import()
    {
      this.newDwelling = new SAP_Module.Dwelling();
      this.XMLNS = (XNamespace) "http://www.epcregister.com/xsd/sap";
    }

    private void BuildingParts(XElement data)
    {
      if (data == null)
        return;
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Building-Part");
      try
      {
        foreach (XElement DataValue in elementList)
        {
          // ISSUE: variable of a reference type
          int& local1;
          // ISSUE: explicit reference operation
          object ClassObject1 = (object) ^(local1 = ref this.newDwelling.YearBuilt);
          this.PopulateValue(ref ClassObject1, DataValue, "Construction-Year");
          local1 = Conversions.ToInteger(ClassObject1);
          // ISSUE: variable of a reference type
          string& local2;
          // ISSUE: explicit reference operation
          object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Overshading);
          this.PopulateValue(ref ClassObject2, DataValue, "Overshading");
          local2 = Conversions.ToString(ClassObject2);
          this.newDwelling.Overshading = this.Overshading(this.newDwelling.Overshading);
          this.Openings(this.Get_Descendants(data, "SAP-Openings"));
          this.Roofs(this.Get_Descendants(data, "SAP-Roofs"));
          this.FloorDims(this.Get_Descendants(data, "SAP-Floor-Dimensions"));
          this.ThermalBridges(this.Get_Descendants(data, "SAP-Thermal-Bridges"));
          this.Walls(this.Get_Descendants(data, "SAP-Walls"));
          // ISSUE: variable of a reference type
          float& local3;
          // ISSUE: explicit reference operation
          object ClassObject3 = (object) ^(local3 = ref this.newDwelling.TMP.UserDefined);
          this.PopulateValue(ref ClassObject3, DataValue, "Thermal-Mass-Parameter");
          local3 = Conversions.ToSingle(ClassObject3);
          this.newDwelling.TMP.Type = (double) this.newDwelling.TMP.UserDefined == 0.0 ? "Calculated" : "User Value";
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void Openings(XElement data)
    {
      if (data == null)
        return;
      List<SAP_Module.Window> windowList = new List<SAP_Module.Window>();
      List<SAP_Module.RoofLight> roofLightList = new List<SAP_Module.RoofLight>();
      List<SAP_Module.Door> doorList = new List<SAP_Module.Door>();
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Opening");
      try
      {
        foreach (XElement DataValue in elementList)
        {
          object ClassObject = (object) "";
          this.PopulateValue(ref ClassObject, DataValue, "Type");
          string str = Conversions.ToString(ClassObject);
          if (str.ToUpper().Contains("DOOR"))
          {
            SAP_Module.Door door = new SAP_Module.Door();
            // ISSUE: variable of a reference type
            string& local1;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local1 = ref door.Name);
            this.PopulateValue(ref ClassObject, DataValue, "Name");
            local1 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local2;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local2 = ref door.OpeningType);
            this.PopulateValue(ref ClassObject, DataValue, "Type");
            local2 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local3;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local3 = ref door.Location);
            this.PopulateValue(ref ClassObject, DataValue, "Location");
            local3 = Conversions.ToString(ClassObject);
            ClassObject = (object) "";
            this.PopulateValue(ref ClassObject, DataValue, "Orientation");
            string OrientationCode = Conversions.ToString(ClassObject);
            door.Orientation = this.GetOrientation(OrientationCode);
            // ISSUE: variable of a reference type
            float& local4;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local4 = ref door.Width);
            this.PopulateValue(ref ClassObject, DataValue, "Width");
            local4 = Conversions.ToSingle(ClassObject);
            // ISSUE: variable of a reference type
            float& local5;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local5 = ref door.Height);
            this.PopulateValue(ref ClassObject, DataValue, "Height");
            local5 = Conversions.ToSingle(ClassObject);
            door.Area = (float) Math.Round((double) door.Width * (double) door.Height, 2);
            // ISSUE: variable of a reference type
            float& local6;
            // ISSUE: explicit reference operation
            double num1 = (double) ^(local6 = ref door.Width) * 1000.0;
            local6 = (float) num1;
            // ISSUE: variable of a reference type
            float& local7;
            // ISSUE: explicit reference operation
            double num2 = (double) ^(local7 = ref door.Height) * 1000.0;
            local7 = (float) num2;
            doorList.Add(door);
          }
          else if (str.ToUpper().Contains("ROOF"))
          {
            SAP_Module.RoofLight roofLight = new SAP_Module.RoofLight();
            // ISSUE: variable of a reference type
            string& local8;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local8 = ref roofLight.Name);
            this.PopulateValue(ref ClassObject, DataValue, "Name");
            local8 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local9;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local9 = ref roofLight.OpeningType);
            this.PopulateValue(ref ClassObject, DataValue, "Type");
            local9 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local10;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local10 = ref roofLight.Location);
            this.PopulateValue(ref ClassObject, DataValue, "Location");
            local10 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            float& local11;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local11 = ref roofLight.Pitch);
            this.PopulateValue(ref ClassObject, DataValue, "Pitch");
            local11 = Conversions.ToSingle(ClassObject);
            ClassObject = (object) "";
            this.PopulateValue(ref ClassObject, DataValue, "Orientation");
            string OrientationCode = Conversions.ToString(ClassObject);
            roofLight.Orientation = this.GetOrientation(OrientationCode);
            // ISSUE: variable of a reference type
            float& local12;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local12 = ref roofLight.Width);
            this.PopulateValue(ref ClassObject, DataValue, "Width");
            local12 = Conversions.ToSingle(ClassObject);
            // ISSUE: variable of a reference type
            float& local13;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local13 = ref roofLight.Height);
            this.PopulateValue(ref ClassObject, DataValue, "Height");
            local13 = Conversions.ToSingle(ClassObject);
            roofLight.Area = (float) Math.Round((double) roofLight.Width * (double) roofLight.Height, 2);
            // ISSUE: variable of a reference type
            float& local14;
            // ISSUE: explicit reference operation
            double num3 = (double) ^(local14 = ref roofLight.Width) * 1000.0;
            local14 = (float) num3;
            // ISSUE: variable of a reference type
            float& local15;
            // ISSUE: explicit reference operation
            double num4 = (double) ^(local15 = ref roofLight.Height) * 1000.0;
            local15 = (float) num4;
            roofLightList.Add(roofLight);
          }
          else
          {
            SAP_Module.Window window = new SAP_Module.Window();
            // ISSUE: variable of a reference type
            string& local16;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local16 = ref window.Name);
            this.PopulateValue(ref ClassObject, DataValue, "Name");
            local16 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local17;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local17 = ref window.OpeningType);
            this.PopulateValue(ref ClassObject, DataValue, "Type");
            local17 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local18;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local18 = ref window.Location);
            this.PopulateValue(ref ClassObject, DataValue, "Location");
            local18 = Conversions.ToString(ClassObject);
            ClassObject = (object) "";
            this.PopulateValue(ref ClassObject, DataValue, "Orientation");
            string OrientationCode = Conversions.ToString(ClassObject);
            window.Orientation = this.GetOrientation(OrientationCode);
            // ISSUE: variable of a reference type
            float& local19;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local19 = ref window.Width);
            this.PopulateValue(ref ClassObject, DataValue, "Width");
            local19 = Conversions.ToSingle(ClassObject);
            // ISSUE: variable of a reference type
            float& local20;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local20 = ref window.Height);
            this.PopulateValue(ref ClassObject, DataValue, "Height");
            local20 = Conversions.ToSingle(ClassObject);
            window.Area = (float) Math.Round((double) window.Width * (double) window.Height + 1E-07, 2);
            // ISSUE: variable of a reference type
            float& local21;
            // ISSUE: explicit reference operation
            double num5 = (double) ^(local21 = ref window.Width) * 1000.0;
            local21 = (float) num5;
            // ISSUE: variable of a reference type
            float& local22;
            // ISSUE: explicit reference operation
            double num6 = (double) ^(local22 = ref window.Height) * 1000.0;
            local22 = (float) num6;
            windowList.Add(window);
          }
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.newDwelling.RoofLights = roofLightList.ToArray();
      this.newDwelling.Windows = windowList.ToArray();
      this.newDwelling.Doors = doorList.ToArray();
    }

    private void Roofs(XElement data)
    {
      if (data == null)
        return;
      List<SAP_Module.Opaques> opaquesList = new List<SAP_Module.Opaques>();
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Roof");
      try
      {
        foreach (XElement DataValue in elementList)
        {
          SAP_Module.Opaques opaques = new SAP_Module.Opaques();
          // ISSUE: variable of a reference type
          string& local1;
          // ISSUE: explicit reference operation
          object ClassObject1 = (object) ^(local1 = ref opaques.Name);
          this.PopulateValue(ref ClassObject1, DataValue, "Name");
          local1 = Conversions.ToString(ClassObject1);
          // ISSUE: variable of a reference type
          string& local2;
          // ISSUE: explicit reference operation
          object ClassObject2 = (object) ^(local2 = ref opaques.EPCDesc);
          this.PopulateValue(ref ClassObject2, DataValue, "Description");
          local2 = Conversions.ToString(ClassObject2);
          // ISSUE: variable of a reference type
          string& local3;
          // ISSUE: explicit reference operation
          object ClassObject3 = (object) ^(local3 = ref opaques.Type);
          this.PopulateValue(ref ClassObject3, DataValue, "Roof-Type");
          local3 = Conversions.ToString(ClassObject3);
          // ISSUE: variable of a reference type
          float& local4;
          // ISSUE: explicit reference operation
          object ClassObject4 = (object) ^(local4 = ref opaques.Area);
          this.PopulateValue(ref ClassObject4, DataValue, "Total-Roof-Area");
          local4 = Conversions.ToSingle(ClassObject4);
          // ISSUE: variable of a reference type
          float& local5;
          // ISSUE: explicit reference operation
          object ClassObject5 = (object) ^(local5 = ref opaques.U_Value);
          this.PopulateValue(ref ClassObject5, DataValue, "U-Value");
          local5 = Conversions.ToSingle(ClassObject5);
          // ISSUE: variable of a reference type
          float& local6;
          // ISSUE: explicit reference operation
          object ClassObject6 = (object) ^(local6 = ref opaques.K);
          this.PopulateValue(ref ClassObject6, DataValue, "Kappa-Value");
          local6 = Conversions.ToSingle(ClassObject6);
          opaquesList.Add(opaques);
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.newDwelling.Roofs = opaquesList.ToArray();
    }

    private void FloorDims(XElement data)
    {
      if (data == null)
        return;
      List<SAP_Module.Opaques> opaquesList = new List<SAP_Module.Opaques>();
      List<SAP_Module.PartyElements> partyElementsList1 = new List<SAP_Module.PartyElements>();
      List<SAP_Module.PartyElements> partyElementsList2 = new List<SAP_Module.PartyElements>();
      List<SAP_Module.Dimensions> dimensionsList = new List<SAP_Module.Dimensions>();
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Floor-Dimension");
      try
      {
        foreach (XElement DataValue in elementList)
        {
          SAP_Module.Opaques opaques = new SAP_Module.Opaques();
          SAP_Module.PartyElements partyElements1 = new SAP_Module.PartyElements();
          SAP_Module.Dimensions dimensions = new SAP_Module.Dimensions();
          // ISSUE: variable of a reference type
          float& local1;
          // ISSUE: explicit reference operation
          object ClassObject = (object) ^(local1 = ref dimensions.Area);
          this.PopulateValue(ref ClassObject, DataValue, "Total-Floor-Area");
          local1 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          float& local2;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local2 = ref dimensions.Height);
          this.PopulateValue(ref ClassObject, DataValue, "Storey-Height");
          local2 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          string& local3;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local3 = ref opaques.Name);
          this.PopulateValue(ref ClassObject, DataValue, "Storey");
          local3 = Conversions.ToString(ClassObject);
          // ISSUE: variable of a reference type
          string& local4;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local4 = ref opaques.EPCDesc);
          this.PopulateValue(ref ClassObject, DataValue, "Description");
          local4 = Conversions.ToString(ClassObject);
          ClassObject = (object) "";
          this.PopulateValue(ref ClassObject, DataValue, "Floor-Type");
          string TypeCode = Conversions.ToString(ClassObject);
          opaques.Type = this.GetFloorType(TypeCode);
          // ISSUE: variable of a reference type
          float& local5;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local5 = ref opaques.Area);
          this.PopulateValue(ref ClassObject, DataValue, "Heat-Loss-Area");
          local5 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          float& local6;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local6 = ref opaques.K);
          this.PopulateValue(ref ClassObject, DataValue, "Kappa-Value");
          local6 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          float& local7;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local7 = ref opaques.U_Value);
          this.PopulateValue(ref ClassObject, DataValue, "U-Value");
          local7 = Conversions.ToSingle(ClassObject);
          ClassObject = (object) "";
          this.PopulateValue(ref ClassObject, DataValue, "Kappa-Value-From-Below");
          string str = Conversions.ToString(ClassObject);
          if (!string.IsNullOrEmpty(str))
          {
            partyElements1.Name = opaques.Name;
            partyElements1.Construction = opaques.Type;
            // ISSUE: variable of a reference type
            float& local8;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local8 = ref partyElements1.Area);
            this.PopulateValue(ref ClassObject, DataValue, "Total-Floor-Area");
            local8 = Conversions.ToSingle(ClassObject);
            // ISSUE: variable of a reference type
            float& local9;
            // ISSUE: explicit reference operation
            double num = (double) ^(local9 = ref partyElements1.Area) - (double) opaques.Area;
            local9 = (float) num;
            partyElements1.K = Conversions.ToSingle(str);
            SAP_Module.PartyElements partyElements2 = new SAP_Module.PartyElements();
            partyElements2.Name = opaques.Name;
            partyElements2.Construction = opaques.Type;
            // ISSUE: variable of a reference type
            float& local10;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local10 = ref partyElements2.Area);
            this.PopulateValue(ref ClassObject, DataValue, "Total-Floor-Area");
            local10 = Conversions.ToSingle(ClassObject);
            partyElements2.K = opaques.K;
            opaques.K = 0.0f;
            partyElementsList1.Add(partyElements2);
            partyElementsList2.Add(partyElements1);
          }
          if ((double) opaques.U_Value > 0.0)
            opaquesList.Add(opaques);
          dimensionsList.Add(dimensions);
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.newDwelling.Floors = opaquesList.ToArray();
      this.newDwelling.IFloors = partyElementsList1.ToArray();
      this.newDwelling.ICeilings = partyElementsList2.ToArray();
      this.newDwelling.Floors = opaquesList.ToArray();
      this.newDwelling.Dims = dimensionsList.ToArray();
      this.newDwelling.Storeys = dimensionsList.Count;
    }

    private void ThermalBridges(XElement data)
    {
      if (data == null)
        return;
      this.PopulateValue(ref this.newDwelling.ReplaceMe, data, "Thermal-Bridge-Code");
      if (this.newDwelling.ReplaceMe.Equals((object) "4") | this.newDwelling.ReplaceMe.Equals((object) "5"))
        this.newDwelling.Thermal.ManualHtb = true;
      // ISSUE: variable of a reference type
      float& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Thermal.YValue);
      this.PopulateValue(ref ClassObject1, data, "User-Defined-Y-Value");
      local1 = Conversions.ToSingle(ClassObject1);
      if (this.newDwelling.ReplaceMe.Equals((object) "1"))
        this.newDwelling.Thermal.YValue = 0.015f;
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Thermal.Reference);
      this.PopulateValue(ref ClassObject2, data, "Calculation-Reference");
      local2 = Conversions.ToString(ClassObject2);
      this.newDwelling.Thermal.ExternalJunctions = new List<SAP_Module.Junction>();
      this.newDwelling.Thermal.PartyJunctions = new List<SAP_Module.Junction>();
      this.newDwelling.Thermal.RoofJunctions = new List<SAP_Module.Junction>();
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Thermal-Bridge");
      double num = 0.0;
      if (elementList != null)
      {
        try
        {
          foreach (XElement DataValue in elementList)
          {
            SAP_Module.Junction junction = new SAP_Module.Junction();
            // ISSUE: variable of a reference type
            string& local3;
            // ISSUE: explicit reference operation
            object ClassObject3 = (object) ^(local3 = ref junction.Ref);
            this.PopulateValue(ref ClassObject3, DataValue, "Thermal-Bridge-Type");
            local3 = Conversions.ToString(ClassObject3);
            // ISSUE: variable of a reference type
            float& local4;
            // ISSUE: explicit reference operation
            object ClassObject4 = (object) ^(local4 = ref junction.Length);
            this.PopulateValue(ref ClassObject4, DataValue, "Length");
            local4 = Conversions.ToSingle(ClassObject4);
            // ISSUE: variable of a reference type
            float& local5;
            // ISSUE: explicit reference operation
            object ClassObject5 = (object) ^(local5 = ref junction.ThermalTransmittance);
            this.PopulateValue(ref ClassObject5, DataValue, "Psi-Value");
            local5 = Conversions.ToSingle(ClassObject5);
            // ISSUE: variable of a reference type
            bool& local6;
            // ISSUE: explicit reference operation
            object ClassObject6 = (object) ^(local6 = ref junction.IsAccredited);
            this.PopulateValue(ref ClassObject6, DataValue, "Psi-Value-Source");
            local6 = Conversions.ToBoolean(ClassObject6);
            num += (double) junction.Length * (double) junction.ThermalTransmittance;
            if (junction.Ref.Contains("R"))
              this.newDwelling.Thermal.RoofJunctions.Add(junction);
            else if (junction.Ref.Contains("P"))
              this.newDwelling.Thermal.PartyJunctions.Add(junction);
            else
              this.newDwelling.Thermal.ExternalJunctions.Add(junction);
          }
        }
        finally
        {
          List<XElement>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      this.newDwelling.Thermal.HtbValue = (float) num;
    }

    private void Walls(XElement data)
    {
      if (data == null)
        return;
      List<SAP_Module.Opaques> opaquesList = new List<SAP_Module.Opaques>();
      List<SAP_Module.PartyWall> partyWallList = new List<SAP_Module.PartyWall>();
      List<SAP_Module.PartyElements> partyElementsList = new List<SAP_Module.PartyElements>();
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Wall");
      try
      {
        foreach (XElement DataValue in elementList)
        {
          object ClassObject = (object) "";
          this.PopulateValue(ref ClassObject, DataValue, "Wall-Type");
          string str = Conversions.ToString(ClassObject);
          if (Operators.CompareString(str, "1", false) != 0 && Operators.CompareString(str, "2", false) != 0 && Operators.CompareString(str, "3", false) != 0)
          {
            if (Operators.CompareString(str, "4", false) != 0)
            {
              if (Operators.CompareString(str, "5", false) == 0)
              {
                SAP_Module.PartyElements partyElements = new SAP_Module.PartyElements();
                // ISSUE: variable of a reference type
                string& local1;
                // ISSUE: explicit reference operation
                ClassObject = (object) ^(local1 = ref partyElements.Name);
                this.PopulateValue(ref ClassObject, DataValue, "Name");
                local1 = Conversions.ToString(ClassObject);
                // ISSUE: variable of a reference type
                float& local2;
                // ISSUE: explicit reference operation
                ClassObject = (object) ^(local2 = ref partyElements.Area);
                this.PopulateValue(ref ClassObject, DataValue, "Total-Wall-Area");
                local2 = Conversions.ToSingle(ClassObject);
                // ISSUE: variable of a reference type
                float& local3;
                // ISSUE: explicit reference operation
                ClassObject = (object) ^(local3 = ref partyElements.K);
                this.PopulateValue(ref ClassObject, DataValue, "Kappa-Value");
                local3 = Conversions.ToSingle(ClassObject);
                partyElementsList.Add(partyElements);
              }
            }
            else
            {
              SAP_Module.PartyWall partyWall = new SAP_Module.PartyWall();
              // ISSUE: variable of a reference type
              string& local4;
              // ISSUE: explicit reference operation
              ClassObject = (object) ^(local4 = ref partyWall.Name);
              this.PopulateValue(ref ClassObject, DataValue, "Name");
              local4 = Conversions.ToString(ClassObject);
              partyWall.Type = this.GetWallType(str);
              // ISSUE: variable of a reference type
              float& local5;
              // ISSUE: explicit reference operation
              ClassObject = (object) ^(local5 = ref partyWall.Area);
              this.PopulateValue(ref ClassObject, DataValue, "Total-Wall-Area");
              local5 = Conversions.ToSingle(ClassObject);
              // ISSUE: variable of a reference type
              float& local6;
              // ISSUE: explicit reference operation
              ClassObject = (object) ^(local6 = ref partyWall.U_Value);
              this.PopulateValue(ref ClassObject, DataValue, "U-Value");
              local6 = Conversions.ToSingle(ClassObject);
              // ISSUE: variable of a reference type
              float& local7;
              // ISSUE: explicit reference operation
              ClassObject = (object) ^(local7 = ref partyWall.K);
              this.PopulateValue(ref ClassObject, DataValue, "Kappa-Value");
              local7 = Conversions.ToSingle(ClassObject);
              partyWallList.Add(partyWall);
            }
          }
          else
          {
            SAP_Module.Opaques opaques = new SAP_Module.Opaques();
            // ISSUE: variable of a reference type
            string& local8;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local8 = ref opaques.Name);
            this.PopulateValue(ref ClassObject, DataValue, "Name");
            local8 = Conversions.ToString(ClassObject);
            // ISSUE: variable of a reference type
            string& local9;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local9 = ref opaques.EPCDesc);
            this.PopulateValue(ref ClassObject, DataValue, "Description");
            local9 = Conversions.ToString(ClassObject);
            opaques.Type = this.GetWallType(str);
            // ISSUE: variable of a reference type
            float& local10;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local10 = ref opaques.Area);
            this.PopulateValue(ref ClassObject, DataValue, "Total-Wall-Area");
            local10 = Conversions.ToSingle(ClassObject);
            // ISSUE: variable of a reference type
            float& local11;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local11 = ref opaques.U_Value);
            this.PopulateValue(ref ClassObject, DataValue, "U-Value");
            local11 = Conversions.ToSingle(ClassObject);
            // ISSUE: variable of a reference type
            bool& local12;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local12 = ref opaques.Curtain);
            this.PopulateValue(ref ClassObject, DataValue, "Is-Curtain-Walling");
            local12 = Conversions.ToBoolean(ClassObject);
            // ISSUE: variable of a reference type
            float& local13;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local13 = ref opaques.K);
            this.PopulateValue(ref ClassObject, DataValue, "Kappa-Value");
            local13 = Conversions.ToSingle(ClassObject);
            opaquesList.Add(opaques);
          }
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.newDwelling.Walls = opaquesList.ToArray();
      this.newDwelling.PWalls = partyWallList.ToArray();
      this.newDwelling.IWalls = partyElementsList.ToArray();
    }

    private string CommDistribution(string source)
    {
      string Left = source;
      string str;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "5", false) != 0)
              {
                if (Operators.CompareString(Left, "6", false) == 0)
                  str = "Unknown";
              }
              else
                str = "Calculated";
            }
            else
              str = "Piping>=1991, pre-insulated, low temp, variable flow";
          }
          else
            str = "Piping>=1991, pre-insulated, medium temp, variable flow";
        }
        else
          str = "Piping<=1990, pre-insulated, low temp, full flow";
      }
      else
        str = "Piping<=1990, not pre-insulated, medium/high temp, full flow";
      return str;
    }

    private string HGroup(string source)
    {
      string Left = source;
      string str;
      if (Operators.CompareString(Left, "Gas boilers and oil boilers", false) != 0 && Operators.CompareString(Left, "Solid fuel boilers", false) != 0 && Operators.CompareString(Left, "Electric boilers", false) != 0)
      {
        if (Operators.CompareString(Left, "Micro-cogeneration (micro-CHP)", false) != 0)
        {
          if (Operators.CompareString(Left, "Electric heat pumps", false) == 0 || Operators.CompareString(Left, "Gas-fired heat pumps", false) == 0)
            str = "Heat pumps with radiators or underfloor heating";
        }
        else
          str = "Micro-Congeneration (Micro-CHP)";
      }
      else
        str = "Boiler systems with radiators or underfloor heating";
      return str;
    }

    private string PropertyType(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "0", false) != 0)
      {
        if (Operators.CompareString(Left, "1", false) != 0)
        {
          if (Operators.CompareString(Left, "2", false) != 0)
          {
            if (Operators.CompareString(Left, "3", false) == 0)
              str = "Maisonette";
          }
          else
            str = "Flat";
        }
        else
          str = "Bungalow";
      }
      else
        str = "House";
      return str;
    }

    private string Conservatory(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) == 0)
              str = "Not separated";
          }
          else
            str = "Separated heated conservatory";
        }
        else
          str = "Separated unheated conservatory";
      }
      else
        str = "No conservatory";
      return str;
    }

    private string BuildForm(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "5", false) != 0)
              {
                if (Operators.CompareString(Left, "6", false) == 0)
                  str = "Enclosed mid";
              }
              else
                str = "Enclosed end";
            }
            else
              str = "Mid-terrace";
          }
          else
            str = "End-terrace";
        }
        else
          str = "Semi-detached";
      }
      else
        str = "Detached";
      return str;
    }

    private string Transaction(string source)
    {
      string str1 = "";
      string str2 = source;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
          {
            str1 = "Not sale or rental";
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
          {
            str1 = "Rental (private)";
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str2, "7", false) == 0)
          {
            str1 = "not recored";
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str2, "6", false) == 0)
          {
            str1 = "New dwelling";
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            str1 = "Marketed sale";
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
          {
            str1 = "Rental (social)";
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
          {
            str1 = "Non marketed sale";
            break;
          }
          break;
      }
      return str1;
    }

    private string PVOrientation(string source)
    {
      string str1 = "";
      string str2 = source;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 652632377:
          if (Operators.CompareString(str2, "NR", false) == 0)
          {
            str1 = "";
            break;
          }
          break;
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
          {
            str1 = "South";
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
          {
            str1 = "South East";
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str2, "7", false) == 0)
          {
            str1 = "West";
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str2, "6", false) == 0)
          {
            str1 = "South West";
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            str1 = "North";
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
          {
            str1 = "East";
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
          {
            str1 = "North East";
            break;
          }
          break;
        case 954629519:
          if (Operators.CompareString(str2, "ND", false) == 0)
          {
            str1 = "South";
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str2, "8", false) == 0)
          {
            str1 = "North West";
            break;
          }
          break;
      }
      return str1;
    }

    private string PVPitch(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "5", false) == 0)
                str = "Vertical";
            }
            else
              str = "60°";
          }
          else
            str = "45°";
        }
        else
          str = "30°";
      }
      else
        str = "Horizontal";
      return str;
    }

    private string Overshading(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "ND", false) == 0)
                str = "";
            }
            else
              str = "Heavy";
          }
          else
            str = "More than average";
        }
        else
          str = "Average or unknown";
      }
      else
        str = "Very Little";
      return str;
    }

    private string PVOvershading(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "ND", false) == 0)
                str = "";
            }
            else
              str = "Heavy";
          }
          else
            str = "Significant";
        }
        else
          str = "Modest";
      }
      else
        str = "None or very little";
      return str;
    }

    private string ShowerType(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "0", false) != 0)
      {
        if (Operators.CompareString(Left, "1", false) != 0)
        {
          if (Operators.CompareString(Left, "2", false) != 0)
          {
            if (Operators.CompareString(Left, "3", false) != 0)
            {
              if (Operators.CompareString(Left, "4", false) == 0)
                str = "No shower (bath only)";
            }
            else
              str = "Both electric and non-electric showers";
          }
          else
            str = "Electric shower(s) only";
        }
        else
          str = "Non-electric shower(s) only";
      }
      else
        str = "";
      return str;
    }

    private string SolarOvershading(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "ND", false) == 0)
                str = "";
            }
            else
              str = "Heavy (>80%)";
          }
          else
            str = "Significant (>60% - 80%)";
        }
        else
          str = "Modest (20% - 60%)";
      }
      else
        str = "None or Very Little (<20%)";
      return str;
    }

    private string PVConnection(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "0", false) != 0)
      {
        if (Operators.CompareString(Left, "1", false) != 0)
        {
          if (Operators.CompareString(Left, "2", false) == 0)
            str = "PV output goes to particular individual flats";
        }
        else
          str = "PV output goes to all flats in propertion to floor area";
      }
      else
        str = "";
      return str;
    }

    private string Terrain(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) == 0)
            str = "Rural";
        }
        else
          str = "Low rise urban / suburban";
      }
      else
        str = "Dense urban";
      return str;
    }

    private string SolarOrientation(string source)
    {
      string str1 = "";
      string str2 = source;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
          {
            str1 = "South";
            goto default;
          }
          else
            goto default;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
            goto label_12;
          else
            goto default;
        case 839689206:
          if (Operators.CompareString(str2, "7", false) == 0)
            goto label_11;
          else
            goto default;
        case 856466825:
          if (Operators.CompareString(str2, "6", false) == 0)
            goto label_12;
          else
            goto default;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            str1 = "North";
            goto default;
          }
          else
            goto default;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
            goto label_11;
          else
            goto default;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
            break;
          goto default;
        case 1024243015:
          if (Operators.CompareString(str2, "8", false) == 0)
            break;
          goto default;
        default:
label_14:
          return str1;
      }
      str1 = "NE/NW";
      goto label_14;
label_11:
      str1 = "E/W";
      goto label_14;
label_12:
      str1 = "SE/SW";
      goto label_14;
    }

    private string SolarCollector(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) == 0)
            str = "Evacuated tube";
        }
        else
          str = "Flat plate, glazed";
      }
      else
        str = "Unglazed";
      return str;
    }

    private string Tariff(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) != 0)
          {
            if (Operators.CompareString(Left, "4", false) != 0)
            {
              if (Operators.CompareString(Left, "5", false) != 0)
              {
                if (Operators.CompareString(Left, "ND", false) == 0)
                  str = "";
              }
              else
                str = "18-hour tariff";
            }
            else
              str = "24-hour tariff";
          }
          else
            str = "10-hour tariff";
        }
        else
          str = "7-hour tariff";
      }
      else
        str = "standard tariff";
      return str;
    }

    private string WindowSource(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "2", false) != 0)
      {
        if (Operators.CompareString(Left, "3", false) != 0)
        {
          if (Operators.CompareString(Left, "4", false) == 0)
            str = "BFRC";
        }
        else
          str = "SAP 2012";
      }
      else
        str = "Manufacturer";
      return str;
    }

    private string GlazingGap(string source)
    {
      string str = "";
      string Left = source;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "3", false) == 0)
            str = "16mm or more";
        }
        else
          str = "12mm";
      }
      else
        str = "6mm";
      return str;
    }

    private string FrameType(string source)
    {
      string str1 = "";
      string str2 = source;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
            break;
          goto default;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
            break;
          goto default;
        case 839689206:
          if (Operators.CompareString(str2, "7", false) == 0)
            break;
          goto default;
        case 856466825:
          if (Operators.CompareString(str2, "6", false) == 0)
            break;
          goto default;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            str1 = "Wood";
            goto default;
          }
          else
            goto default;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
            break;
          goto default;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
          {
            str1 = "PVC-U";
            goto default;
          }
          else
            goto default;
        case 1024243015:
          if (Operators.CompareString(str2, "8", false) == 0)
            break;
          goto default;
        default:
label_12:
          return str1;
      }
      str1 = "Metal";
      goto label_12;
    }

    private string ThermalBreak(string source)
    {
      string str1 = "";
      string str2 = source;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
          {
            str1 = "8mm";
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
          {
            str1 = "4mm";
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str2, "7", false) == 0)
          {
            str1 = "20mm";
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str2, "6", false) == 0)
          {
            str1 = "12mm";
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            str1 = "";
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
          {
            str1 = "No thermal break";
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
          {
            str1 = "";
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str2, "8", false) == 0)
          {
            str1 = "32mm";
            break;
          }
          break;
      }
      return str1;
    }

    private string WindowType(string source, bool argon)
    {
      string str1 = "";
      string str2 = !argon ? "air" : nameof (argon);
      string str3 = source;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str3))
      {
        case 468396612:
          if (Operators.CompareString(str3, "10", false) == 0)
          {
            str1 = "triple-glazed, " + str2 + " filled (low-E, En = 0.15, hard coat)";
            break;
          }
          break;
        case 485174231:
          if (Operators.CompareString(str3, "11", false) == 0)
          {
            str1 = "triple-glazed, " + str2 + " filled (low-E, En = 0.1, soft coat)";
            break;
          }
          break;
        case 501951850:
          if (Operators.CompareString(str3, "12", false) == 0)
          {
            str1 = "triple-glazed, " + str2 + " filled (low-E, En = 0.05, soft coat)";
            break;
          }
          break;
        case 518729469:
          if (Operators.CompareString(str3, "13", false) == 0)
          {
            str1 = "Secondary glazing";
            break;
          }
          break;
        case 806133968:
          if (Operators.CompareString(str3, "5", false) == 0)
          {
            str1 = "double-glazed, " + str2 + " filled (low-E, En = 0.15, hard coat)";
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str3, "4", false) == 0)
          {
            str1 = "double-glazed, " + str2 + " filled (low-E, En = 0.2, hard coat)";
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str3, "7", false) == 0)
          {
            str1 = "double-glazed, " + str2 + " filled (low-E, En = 0.05, soft coat)";
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str3, "6", false) == 0)
          {
            str1 = "double-glazed, " + str2 + " filled (low-E, En = 0.1, soft coat)";
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str3, "1", false) == 0)
          {
            str1 = "";
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str3, "3", false) == 0)
          {
            str1 = "double-glazed, " + str2 + " filled";
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str3, "2", false) == 0)
          {
            str1 = "Single-glazed";
            break;
          }
          break;
        case 1007465396:
          if (Operators.CompareString(str3, "9", false) == 0)
          {
            str1 = "triple-glazed, " + str2 + " filled (low-E, En = 0.2, hard coat)";
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str3, "8", false) == 0)
          {
            str1 = "triple-glazed, " + str2 + " filled";
            break;
          }
          break;
      }
      return str1;
    }

    private string RegionToLocation(string Region)
    {
      string str = Region;
      string location;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 334175660:
          if (Operators.CompareString(str, "18", false) == 0)
          {
            location = "Wales";
            break;
          }
          goto default;
        case 350953279:
          if (Operators.CompareString(str, "19", false) == 0)
          {
            location = "West Pennines";
            break;
          }
          goto default;
        case 401286136:
          if (Operators.CompareString(str, "14", false) == 0)
          {
            location = "South East England";
            break;
          }
          goto default;
        case 418063755:
          if (Operators.CompareString(str, "15", false) == 0)
          {
            location = "South West England";
            break;
          }
          goto default;
        case 434841374:
          if (Operators.CompareString(str, "16", false) == 0)
          {
            location = "South England";
            break;
          }
          goto default;
        case 451618993:
          if (Operators.CompareString(str, "17", false) == 0)
          {
            location = "Thames valley";
            break;
          }
          goto default;
        case 468396612:
          if (Operators.CompareString(str, "10", false) == 0)
          {
            location = "Northern Ireland";
            break;
          }
          goto default;
        case 485174231:
          if (Operators.CompareString(str, "11", false) == 0)
          {
            location = "Orkney";
            break;
          }
          goto default;
        case 501951850:
          if (Operators.CompareString(str, "12", false) == 0)
          {
            location = "Severn valley";
            break;
          }
          goto default;
        case 518729469:
          if (Operators.CompareString(str, "13", false) == 0)
          {
            location = "Shetland";
            break;
          }
          goto default;
        case 806133968:
          if (Operators.CompareString(str, "5", false) == 0)
          {
            location = "Highland";
            break;
          }
          goto default;
        case 822911587:
          if (Operators.CompareString(str, "4", false) == 0)
          {
            location = "East Scotland";
            break;
          }
          goto default;
        case 839689206:
          if (Operators.CompareString(str, "7", false) == 0)
          {
            location = "North East England";
            break;
          }
          goto default;
        case 856466825:
          if (Operators.CompareString(str, "6", false) == 0)
          {
            location = "Midlands";
            break;
          }
          goto default;
        case 873244444:
          if (Operators.CompareString(str, "1", false) == 0)
          {
            location = "Borders";
            break;
          }
          goto default;
        case 906799682:
          if (Operators.CompareString(str, "3", false) == 0)
          {
            location = "East Pennines";
            break;
          }
          goto default;
        case 923577301:
          if (Operators.CompareString(str, "2", false) == 0)
          {
            location = "East Anglia";
            break;
          }
          goto default;
        case 1007465396:
          if (Operators.CompareString(str, "9", false) == 0)
          {
            location = "North West England";
            break;
          }
          goto default;
        case 1024243015:
          if (Operators.CompareString(str, "8", false) == 0)
          {
            location = "North East Scotland";
            break;
          }
          goto default;
        case 2314375987:
          if (Operators.CompareString(str, "24", false) == 0)
          {
            location = "Isle of Man";
            break;
          }
          goto default;
        case 2364708844:
          if (Operators.CompareString(str, "21", false) == 0)
          {
            location = "Western Isles";
            break;
          }
          goto default;
        case 2381486463:
          if (Operators.CompareString(str, "20", false) == 0)
          {
            location = "West Scotland";
            break;
          }
          goto default;
        case 2398264082:
          if (Operators.CompareString(str, "23", false) == 0)
          {
            location = "Guernsey";
            break;
          }
          goto default;
        case 2415041701:
          if (Operators.CompareString(str, "22", false) == 0)
          {
            location = "Jersey";
            break;
          }
          goto default;
        default:
          location = "Somewhere Else";
          break;
      }
      return location;
    }

    private int GetCommunity(string source)
    {
      string Left = source;
      int community;
      if (Operators.CompareString(Left, Conversions.ToString(1), false) == 0)
        community = 307;
      else if (Operators.CompareString(Left, Conversions.ToString(2), false) == 0)
        community = 306;
      else if (Operators.CompareString(Left, Conversions.ToString(3), false) == 0)
        community = 308;
      else if (Operators.CompareString(Left, Conversions.ToString(4), false) == 0)
        community = 309;
      else if (Operators.CompareString(Left, Conversions.ToString(5), false) == 0)
        community = 310;
      return community;
    }

    private string GetDataSource(string DataSource) => Operators.CompareString(DataSource, "1", false) != 0 ? (Operators.CompareString(DataSource, "2", false) != 0 ? "SAP Tables" : "Manufacturer Declaration") : "Boiler Database";

    private string FuelCheck(int Fuel)
    {
      string str;
      switch (Fuel)
      {
        case 1:
          str = "mains gas";
          break;
        case 2:
          str = "bulk LPG";
          break;
        case 3:
          str = "bottled LPG";
          break;
        case 4:
          str = "heating oil";
          break;
        case 8:
          str = "LNG";
          break;
        case 9:
          str = "LPG subject to Special Condition 18";
          break;
        case 10:
          str = "dual fuel (mineral and wood)";
          break;
        case 11:
          str = "house coal";
          break;
        case 12:
          str = "manufactured smokeless fuel";
          break;
        case 15:
          str = "anthracite";
          break;
        case 20:
          str = "wood logs";
          break;
        case 21:
          str = "wood chips";
          break;
        case 22:
          str = "wood pellets (in bags, for secondary heating)";
          break;
        case 23:
          str = "wood pellets (bulk supply in bags, for main heating)";
          break;
        case 39:
          str = "Electricity";
          break;
        case 41:
          str = "heat from electric heat pump";
          break;
        case 42:
          str = "heat from boilers - waste combustion";
          break;
        case 43:
          str = "heat from boilers – biomass";
          break;
        case 44:
          str = "heat from boilers – biogas";
          break;
        case 45:
          str = "waste heat from power stations";
          break;
        case 46:
          str = "geothermal heat source";
          break;
        case 51:
          str = "heat from boilers – mains gas";
          break;
        case 52:
          str = "heat from boilers – LPG";
          break;
        case 53:
          str = "heat from boilers – oil";
          break;
        case 54:
          str = "heat from boilers – coal";
          break;
        case 55:
          str = "heat from boilers – B30D";
          break;
        case 71:
          str = "biodiesel from any biomass source";
          break;
        case 72:
          str = "biodiesel from used cooking oil only";
          break;
        case 73:
          str = "rapeseed oil";
          break;
        case 74:
          str = "appliances able to use mineral oil or liquid biofuel";
          break;
        case 75:
          str = "B30K";
          break;
        case 76:
          str = "bioethanol from any biomass source";
          break;
        default:
          str = "";
          break;
      }
      return str;
    }

    private string GetMainCat(string CatCode)
    {
      string mainCat = "";
      string str = CatCode;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 468396612:
          if (Operators.CompareString(str, "10", false) == 0)
            return "Room heaters";
          break;
        case 485174231:
          if (Operators.CompareString(str, "11", false) == 0)
            return "Other space heating systems";
          break;
        case 806133968:
          if (Operators.CompareString(str, "5", false) == 0)
            return "Heat pumps with warm air distribution";
          break;
        case 822911587:
          if (Operators.CompareString(str, "4", false) == 0)
            return "Heat pumps with radiators or underfloor heating";
          break;
        case 839689206:
          if (Operators.CompareString(str, "7", false) == 0)
            return "Electric storage systems";
          break;
        case 856466825:
          if (Operators.CompareString(str, "6", false) == 0)
            return "Community heating schemes";
          break;
        case 873244444:
          if (Operators.CompareString(str, "1", false) == 0)
            return "No heating system present";
          break;
        case 906799682:
          if (Operators.CompareString(str, "3", false) == 0)
            return "Micro -Congeneration(Micro - CHP)";
          break;
        case 923577301:
          if (Operators.CompareString(str, "2", false) == 0)
            return "Boiler systems with radiators or underfloor heating";
          break;
        case 1007465396:
          if (Operators.CompareString(str, "9", false) == 0)
            return "Warm air systems (Not heat pump)";
          break;
        case 1024243015:
          if (Operators.CompareString(str, "8", false) == 0)
            return "Electric underfloor heating";
          break;
      }
      return mainCat;
    }

    private string GetCategory(string CatCode) => Operators.CompareString(CatCode, "1", false) != 0 ? (Operators.CompareString(CatCode, "2", false) != 0 ? (Operators.CompareString(CatCode, "3", false) != 0 ? (Operators.CompareString(CatCode, "4", false) != 0 ? (Operators.CompareString(CatCode, "5", false) != 0 ? (Operators.CompareString(CatCode, "6", false) != 0 ? (Operators.CompareString(CatCode, "7", false) != 0 ? (Operators.CompareString(CatCode, "8", false) != 0 ? (Operators.CompareString(CatCode, "9", false) != 0 ? (Operators.CompareString(CatCode, "10", false) != 0 ? (Operators.CompareString(CatCode, "11", false) != 0 ? "None" : "Heat pumps with warm air distribution") : "Heat pumps with warm air distribution") : "Heat pumps with warm air distribution") : "Heat pumps with warm air distribution") : "Heat pumps with warm air distribution") : "Heat pumps with warm air distribution") : "Heat pumps with warm air distribution") : "Heat pumps with radiators or underfloor heating") : "Micro-cogeneration (micro-CHP)") : "Gas boilers and oil boilers") : "";

    private string GetCombiType(string CombiCode)
    {
      string combiType = "";
      if (Operators.CompareString(CombiCode, "1", false) == 0 | Operators.CompareString(CombiCode, "5", false) == 0 | Operators.CompareString(CombiCode, "6", false) == 0 | Operators.CompareString(CombiCode, "7", false) == 0 | Operators.CompareString(CombiCode, "8", false) == 0)
        combiType = "Instantaneous Combi";
      else if (Operators.CompareString(CombiCode, "", false) == 0 || Operators.CompareString(CombiCode, "", false) != 0)
        ;
      return combiType;
    }

    private string GetOrientation(string OrientationCode) => Operators.CompareString(OrientationCode, "1", false) != 0 ? (Operators.CompareString(OrientationCode, "2", false) != 0 ? (Operators.CompareString(OrientationCode, "3", false) != 0 ? (Operators.CompareString(OrientationCode, "4", false) != 0 ? (Operators.CompareString(OrientationCode, "5", false) != 0 ? (Operators.CompareString(OrientationCode, "6", false) != 0 ? (Operators.CompareString(OrientationCode, "7", false) != 0 ? (Operators.CompareString(OrientationCode, "8", false) != 0 ? "Horizontal" : "North West") : "West") : "South West") : "South") : "South East") : "East") : "North East") : "North";

    private string GetFloorType(string TypeCode) => Operators.CompareString(TypeCode, "1", false) != 0 ? (Operators.CompareString(TypeCode, "2", false) != 0 ? (Operators.CompareString(TypeCode, "3", false) != 0 ? "Unknown Floor" : "Exposed floor") : "Ground floor") : "Basement floor";

    private string GetWallType(string TypeCode) => Operators.CompareString(TypeCode, "1", false) != 0 ? (Operators.CompareString(TypeCode, "2", false) != 0 ? (Operators.CompareString(TypeCode, "3", false) != 0 ? (Operators.CompareString(TypeCode, "4", false) != 0 ? (Operators.CompareString(TypeCode, "5", false) != 0 ? "Unknown wall" : "Internal wall") : "Party wall") : "Sheltered wall") : "Exposed wall") : "Basement wall";

    private string GetPressureType(string PressureCode) => Operators.CompareString(PressureCode, "1", false) != 0 ? (Operators.CompareString(PressureCode, "2", false) != 0 ? (Operators.CompareString(PressureCode, "3", false) != 0 ? (Operators.CompareString(PressureCode, "4", false) != 0 ? "Unknown" : "Calculated") : "Assumed") : "As designed") : "As built";

    private string GetFloorType2(string FloorTypeCode) => Operators.CompareString(FloorTypeCode, "1", false) != 0 ? (Operators.CompareString(FloorTypeCode, "2", false) != 0 ? (Operators.CompareString(FloorTypeCode, "3", false) != 0 ? "Unknown Floor" : "Suspended timber floor - Unsealed") : "Suspended timber floor - Sealed") : "Non timber floor";

    private string GetDraughtLobby(string DraughtLobbyCode) => Operators.CompareString(DraughtLobbyCode.ToLower(), "true", false) != 0 ? "No Draught Lobby" : "Draught Lobby";

    private string GetVentType(string VentCode) => !(Operators.CompareString(VentCode, "1", false) == 0 | Operators.CompareString(VentCode, "10", false) == 0) ? (Operators.CompareString(VentCode, "2", false) != 0 ? (Operators.CompareString(VentCode, "3", false) != 0 ? (Operators.CompareString(VentCode, "4", false) != 0 ? (Operators.CompareString(VentCode, "5", false) != 0 ? (Operators.CompareString(VentCode, "6", false) != 0 ? (Operators.CompareString(VentCode, "7", false) != 0 ? (Operators.CompareString(VentCode, "8", false) != 0 ? (Operators.CompareString(VentCode, "9", false) != 0 ? (Operators.CompareString(VentCode, "10", false) != 0 ? "" : "natural with intermittent extract fans and passive vents") : "natural with intermittent extract fans") : "Balanced with heat recovery") : "Balanced without heat recovery") : "Decentralised whole house extract") : "Centralised whole house extract") : "Positive input from outside") : "Positive input from loft") : "natural with passive vents") : "Natural ventilation";

    private string GetMechVentDataSource(string DataSourceCode) => Operators.CompareString(DataSourceCode, "1", false) != 0 ? (Operators.CompareString(DataSourceCode, "2", false) != 0 ? (Operators.CompareString(DataSourceCode, "3", false) != 0 ? "Unknown" : "SAP 2012") : "User defined") : "Database";

    private string GetVentDuctType(string DuctTypeCode) => Operators.CompareString(DuctTypeCode, "1", false) != 0 ? (Operators.CompareString(DuctTypeCode, "2", false) != 0 ? (Operators.CompareString(DuctTypeCode, "3", false) != 0 ? "Unknown" : "Semi-rigid") : "Rigid") : "Flexible";

    private object GetDuctInsulation(string DuctInsulationCode) => Operators.CompareString(DuctInsulationCode, "1", false) != 0 ? (Operators.CompareString(DuctInsulationCode, "2", false) != 0 ? (object) "Unknown" : (object) "Insulation") : (object) "Un-Insulated";

    private string GetCoolingType(string CoolingCode)
    {
      string coolingType = "";
      if (Operators.CompareString(CoolingCode, "1", false) == 0)
        coolingType = "Split/multiple systems";
      else if (Operators.CompareString(CoolingCode, "2", false) == 0)
        coolingType = "Packaged systems";
      return coolingType;
    }

    private string GetControlType(string ControlCode)
    {
      string controlType = "";
      if (Operators.CompareString(ControlCode, "1", false) == 0)
        controlType = "Systems with On/Off control";
      else if (Operators.CompareString(ControlCode, "2", false) == 0)
        controlType = "Systems with variable speed compressors";
      return controlType;
    }

    private string GetFlatType(string FlatCode)
    {
      string flatType = "";
      if (Operators.CompareString(FlatCode, "0", false) == 0)
        flatType = "";
      else if (Operators.CompareString(FlatCode, "1", false) == 0)
        flatType = "Ground floor";
      else if (Operators.CompareString(FlatCode, "2", false) == 0)
        flatType = "Mid floor";
      else if (Operators.CompareString(FlatCode, "3", false) == 0)
        flatType = "Top floor";
      return flatType;
    }

    private void Cooling(XElement data)
    {
      if (data == null)
        return;
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Cooling.Cooled_Area);
      this.PopulateValue(ref ClassObject1, data, "Cooled-Area");
      local1 = Conversions.ToString(ClassObject1);
      object ClassObject2 = (object) "";
      this.PopulateValue(ref ClassObject2, data, "Cooling-System-Type");
      this.newDwelling.Cooling.SystemType = this.GetCoolingType(Conversions.ToString(ClassObject2));
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local2 = ref this.newDwelling.Cooling.Energylabel);
      this.PopulateValue(ref ClassObject3, data, "Cooling-System-Class");
      local2 = Conversions.ToString(ClassObject3);
      // ISSUE: variable of a reference type
      float& local3;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local3 = ref this.newDwelling.Cooling.ERR);
      this.PopulateValue(ref ClassObject4, data, "Cooling-System-EER");
      local3 = Conversions.ToSingle(ClassObject4);
      object ClassObject5 = (object) "";
      this.PopulateValue(ref ClassObject5, data, "Cooling-System-Control");
      this.newDwelling.Cooling.Compressorcontrol = this.GetControlType(Conversions.ToString(ClassObject5));
      this.newDwelling.Cooling.Include = Conversions.ToDouble(this.newDwelling.Cooling.Cooled_Area) > 0.0;
    }

    private void DeselectedImprovements(XElement data)
    {
      if (data == null)
        return;
      List<XElement> elementList = this.Get_ElementList(data, "Deselected-Improvement-Measure");
      try
      {
        foreach (XElement xelement in elementList)
          ;
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void EnergySource(XElement data)
    {
      if (data == null)
        return;
      List<XElement> elementList = this.Get_ElementList(this.Get_Descendants(data, "PV-Arrays"), "PV-Array");
      this.newDwelling.Renewable.Photovoltaic.Photovoltaics = new SAP_Module.PhotoVoltaics[checked (elementList.Count - 1 + 1)];
      int index = 0;
      try
      {
        foreach (XElement DataValue in elementList)
        {
          SAP_Module.PhotoVoltaics photoVoltaics = new SAP_Module.PhotoVoltaics();
          // ISSUE: variable of a reference type
          float& local1;
          // ISSUE: explicit reference operation
          object ClassObject = (object) ^(local1 = ref photoVoltaics.PPower);
          this.PopulateValue(ref ClassObject, DataValue, "Peak-Power");
          local1 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          string& local2;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local2 = ref photoVoltaics.PCOrientation);
          this.PopulateValue(ref ClassObject, DataValue, "Orientation");
          local2 = Conversions.ToString(ClassObject);
          photoVoltaics.PCOrientation = this.PVOrientation(photoVoltaics.PCOrientation);
          // ISSUE: variable of a reference type
          string& local3;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local3 = ref photoVoltaics.PTilt);
          this.PopulateValue(ref ClassObject, DataValue, "Pitch");
          local3 = Conversions.ToString(ClassObject);
          photoVoltaics.PTilt = this.PVPitch(photoVoltaics.PTilt);
          // ISSUE: variable of a reference type
          string& local4;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local4 = ref photoVoltaics.POvershading);
          this.PopulateValue(ref ClassObject, DataValue, "Overshading");
          local4 = Conversions.ToString(ClassObject);
          photoVoltaics.POvershading = this.PVOvershading(photoVoltaics.POvershading);
          // ISSUE: variable of a reference type
          string& local5;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local5 = ref photoVoltaics.FlatConnection);
          this.PopulateValue(ref ClassObject, DataValue, "PV-Connection");
          local5 = Conversions.ToString(ClassObject);
          if (photoVoltaics.FlatConnection.Equals("0"))
            photoVoltaics.DirectlyConnected = true;
          photoVoltaics.FlatConnection = this.PVConnection(photoVoltaics.FlatConnection);
          this.newDwelling.Renewable.Photovoltaic.Photovoltaics[index] = photoVoltaics;
          this.newDwelling.Renewable.Photovoltaic.Inlcude = true;
          checked { ++index; }
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      // ISSUE: variable of a reference type
      int& local6;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local6 = ref this.newDwelling.Renewable.WindTurbine.WNumber);
      this.PopulateValue(ref ClassObject1, data, "Wind-Turbines-Count");
      local6 = Conversions.ToInteger(ClassObject1);
      if (this.newDwelling.Renewable.WindTurbine.WNumber > 0)
        this.newDwelling.Renewable.WindTurbine.Inlcude = true;
      // ISSUE: variable of a reference type
      string& local7;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local7 = ref this.newDwelling.Renewable.WindTurbine.WRDiameter);
      this.PopulateValue(ref ClassObject1, data, "Wind-Turbine-Rotor-Diameter");
      local7 = Conversions.ToString(ClassObject1);
      // ISSUE: variable of a reference type
      string& local8;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local8 = ref this.newDwelling.Renewable.WindTurbine.WHeight);
      this.PopulateValue(ref ClassObject1, data, "Wind-Turbine-Hub-Height");
      local8 = Conversions.ToString(ClassObject1);
      // ISSUE: variable of a reference type
      string& local9;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local9 = ref this.newDwelling.Terrain);
      this.PopulateValue(ref ClassObject1, data, "Wind-Turbine-Terrain-Type");
      local9 = Conversions.ToString(ClassObject1);
      this.newDwelling.Terrain = this.Terrain(this.newDwelling.Terrain);
      // ISSUE: variable of a reference type
      int& local10;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local10 = ref this.newDwelling.LELOutlets);
      this.PopulateValue(ref ClassObject1, data, "Fixed-Lighting-Outlets-Count");
      local10 = Conversions.ToInteger(ClassObject1);
      // ISSUE: variable of a reference type
      int& local11;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local11 = ref this.newDwelling.LELLights);
      this.PopulateValue(ref ClassObject1, data, "Low-Energy-Fixed-Lighting-Outlets-Count");
      local11 = Conversions.ToInteger(ClassObject1);
      this.newDwelling.LowEnergyLight = (float) checked (100 * this.newDwelling.LELLights) / (float) this.newDwelling.LELOutlets;
      // ISSUE: variable of a reference type
      string& local12;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local12 = ref this.newDwelling.MainHeating.ElectricityTariff);
      this.PopulateValue(ref ClassObject1, data, "Electricity-Tariff");
      local12 = Conversions.ToString(ClassObject1);
      this.newDwelling.MainHeating.ElectricityTariff = this.Tariff(this.newDwelling.MainHeating.ElectricityTariff);
      // ISSUE: variable of a reference type
      float& local13;
      // ISSUE: explicit reference operation
      ClassObject1 = (object) ^(local13 = ref this.newDwelling.Renewable.AAEGeneration.EGenerated);
      this.PopulateValue(ref ClassObject1, data, "Hydro-Electric-Generation");
      local13 = Conversions.ToSingle(ClassObject1);
      if ((double) this.newDwelling.Renewable.AAEGeneration.EGenerated > 0.0)
        this.newDwelling.Renewable.AAEGeneration.Inlcude = true;
      if ((double) this.newDwelling.Renewable.HydroGeneration.HydroGenerated > 0.0)
        this.newDwelling.Renewable.HydroGeneration.Inlcude = true;
    }

    private void FlatDetails(XElement data)
    {
      if (data == null)
        return;
      object ClassObject = (object) "";
      this.PopulateValue(ref ClassObject, data, "Level");
      this.newDwelling.FlatType = this.GetFlatType(Conversions.ToString(ClassObject));
    }

    private XElement Get_Descendants(XDocument DataValue, string ElementName)
    {
      XElement descendants;
      if (DataValue.Descendants(this.XMLNS + ElementName) != null)
      {
        IEnumerable<XElement> source = DataValue.Descendants(this.XMLNS + ElementName);
        Func<XElement, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (XML_Import._Closure\u0024__.\u0024I53\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = XML_Import._Closure\u0024__.\u0024I53\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_Import._Closure\u0024__.\u0024I53\u002D0 = selector = (Func<XElement, XElement>) (b => b);
        }
        descendants = source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>();
      }
      else if (DataValue.Descendants((XName) ElementName) != null)
      {
        IEnumerable<XElement> source = DataValue.Descendants((XName) ElementName);
        Func<XElement, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (XML_Import._Closure\u0024__.\u0024I53\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = XML_Import._Closure\u0024__.\u0024I53\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_Import._Closure\u0024__.\u0024I53\u002D1 = selector = (Func<XElement, XElement>) (b => b);
        }
        descendants = source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>();
      }
      else
        descendants = (XElement) null;
      return descendants;
    }

    private XElement Get_Descendants(XElement DataValue, string ElementName)
    {
      XElement descendants;
      if (DataValue != null)
      {
        XElement xelement;
        if (DataValue.Descendants(this.XMLNS + ElementName) != null)
        {
          IEnumerable<XElement> source = DataValue.Descendants(this.XMLNS + ElementName);
          Func<XElement, XElement> selector;
          // ISSUE: reference to a compiler-generated field
          if (XML_Import._Closure\u0024__.\u0024I54\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector = XML_Import._Closure\u0024__.\u0024I54\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            XML_Import._Closure\u0024__.\u0024I54\u002D0 = selector = (Func<XElement, XElement>) (b => b);
          }
          xelement = source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>();
        }
        else if (DataValue.Descendants((XName) ElementName) != null)
        {
          IEnumerable<XElement> source = DataValue.Descendants((XName) ElementName);
          Func<XElement, XElement> selector;
          // ISSUE: reference to a compiler-generated field
          if (XML_Import._Closure\u0024__.\u0024I54\u002D1 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector = XML_Import._Closure\u0024__.\u0024I54\u002D1;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            XML_Import._Closure\u0024__.\u0024I54\u002D1 = selector = (Func<XElement, XElement>) (b => b);
          }
          xelement = source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>();
        }
        else
          xelement = (XElement) null;
        descendants = xelement;
      }
      return descendants;
    }

    private List<XElement> Get_ElementList(XElement DataValue, string ElementName)
    {
      List<XElement> elementList = new List<XElement>();
      try
      {
        IEnumerable<XElement> source1 = DataValue.Descendants(this.XMLNS + ElementName);
        Func<XElement, XElement> selector1;
        // ISSUE: reference to a compiler-generated field
        if (XML_Import._Closure\u0024__.\u0024I55\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector1 = XML_Import._Closure\u0024__.\u0024I55\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_Import._Closure\u0024__.\u0024I55\u002D0 = selector1 = (Func<XElement, XElement>) (b => b);
        }
        elementList = source1.Select<XElement, XElement>(selector1).ToList<XElement>();
        if ((uint) elementList.Count <= 0U)
        {
          IEnumerable<XElement> source2 = DataValue.Descendants((XName) ElementName);
          Func<XElement, XElement> selector2;
          // ISSUE: reference to a compiler-generated field
          if (XML_Import._Closure\u0024__.\u0024I55\u002D1 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector2 = XML_Import._Closure\u0024__.\u0024I55\u002D1;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            XML_Import._Closure\u0024__.\u0024I55\u002D1 = selector2 = (Func<XElement, XElement>) (b => b);
          }
          elementList = source2.Select<XElement, XElement>(selector2).ToList<XElement>();
          if ((uint) elementList.Count <= 0U)
            elementList = (List<XElement>) null;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return elementList;
    }

    private void PopulateValue(ref object ClassObject, XElement DataValue, string ElementName)
    {
      try
      {
        if (DataValue.Element(this.XMLNS + ElementName) != null)
          this.PopulateObject(ref ClassObject, (object) DataValue.Element(this.XMLNS + ElementName).Value);
        else if (DataValue.Element((XName) ElementName) != null)
          this.PopulateObject(ref ClassObject, (object) DataValue.Element((XName) ElementName).Value);
        else
          this.PopulateObject(ref ClassObject, (object) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void PopulateObject(ref object Class_Value, object Database_Value)
    {
      if (Class_Value == null)
        Class_Value = (object) "";
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(Database_Value)))
      {
        if (Class_Value.GetType().Equals(typeof (int)) | Class_Value.GetType().Equals(typeof (double)) | Class_Value.GetType().Equals(typeof (float)))
          Class_Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(Database_Value));
        else if (Class_Value.GetType().Equals(typeof (string)) | Class_Value.GetType().Equals(typeof (XElement)))
          Class_Value = RuntimeHelpers.GetObjectValue(Database_Value);
        else if (Class_Value.GetType().Equals(typeof (DateTime)))
        {
          if (Information.IsDate(RuntimeHelpers.GetObjectValue(Database_Value)))
            Class_Value = RuntimeHelpers.GetObjectValue(Database_Value);
          else
            Class_Value = (object) DateAndTime.Now;
        }
        else if (Class_Value.GetType().Equals(typeof (bool)))
          Class_Value = RuntimeHelpers.GetObjectValue(Class_Value);
        else
          Class_Value = (object) null;
      }
      else
        Class_Value = !(Class_Value.GetType().Equals(typeof (int)) | Class_Value.GetType().Equals(typeof (double)) | Class_Value.GetType().Equals(typeof (float))) ? (!Class_Value.GetType().Equals(typeof (string)) ? (!Class_Value.GetType().Equals(typeof (DateTime)) ? (!Class_Value.GetType().Equals(typeof (bool)) ? (object) "" : (object) false) : (object) DateAndTime.Now) : (object) "") : (object) 0;
    }

    private void Heating(XElement data)
    {
      this.WaterHeating(data);
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.SecHeating.HGroup);
      this.PopulateValue(ref ClassObject1, data, "Secondary-Heating-Category");
      local1 = Conversions.ToString(ClassObject1);
      object ClassObject2;
      if (!string.IsNullOrEmpty(this.newDwelling.SecHeating.HGroup) && this.newDwelling.SecHeating.HGroup.Equals("10"))
      {
        // ISSUE: variable of a reference type
        int& local2;
        // ISSUE: explicit reference operation
        object ClassObject3 = (object) ^(local2 = ref this.newDwelling.SecHeating.SAPTableCode);
        this.PopulateValue(ref ClassObject3, data, "Secondary-Heating-Code");
        local2 = Conversions.ToInteger(ClassObject3);
        this.newDwelling.SecHeating.HGroup = "Room heaters";
        // ISSUE: variable of a reference type
        string& local3;
        // ISSUE: explicit reference operation
        object ClassObject4 = (object) ^(local3 = ref this.newDwelling.SecHeating.InforSource);
        this.PopulateValue(ref ClassObject4, data, "Secondary-Heating-Data-Source");
        local3 = Conversions.ToString(ClassObject4);
        if (!string.IsNullOrEmpty(this.newDwelling.SecHeating.InforSource))
        {
          if (this.newDwelling.SecHeating.InforSource.Equals("2"))
            this.newDwelling.SecHeating.InforSource = "Manufacturer Declaration";
          if (this.newDwelling.SecHeating.InforSource.Equals("3"))
            this.newDwelling.SecHeating.InforSource = "SAP Tables";
        }
        // ISSUE: variable of a reference type
        string& local4;
        // ISSUE: explicit reference operation
        object ClassObject5 = (object) ^(local4 = ref this.newDwelling.SecHeating.Fuel);
        this.PopulateValue(ref ClassObject5, data, "Secondary-Fuel-Type");
        local4 = Conversions.ToString(ClassObject5);
        this.newDwelling.SecHeating.Fuel = this.FuelCheck(Conversions.ToInteger(this.newDwelling.SecHeating.Fuel));
        // ISSUE: variable of a reference type
        string& local5;
        // ISSUE: explicit reference operation
        ClassObject2 = (object) ^(local5 = ref this.newDwelling.SecHeating.FlueType);
        this.PopulateValue(ref ClassObject2, data, "Secondary-Heating-Flue-Type");
        local5 = Conversions.ToString(ClassObject2);
        if (!string.IsNullOrEmpty(this.newDwelling.SecHeating.FlueType))
        {
          string flueType = this.newDwelling.SecHeating.FlueType;
          if (Operators.CompareString(flueType, "1", false) != 0)
          {
            if (Operators.CompareString(flueType, "2", false) != 0)
            {
              if (Operators.CompareString(flueType, "3", false) != 0)
              {
                if (Operators.CompareString(flueType, "4", false) != 0)
                {
                  if (Operators.CompareString(flueType, "5", false) == 0)
                    this.newDwelling.SecHeating.FlueType = "Unknown";
                }
                else
                  this.newDwelling.SecHeating.FlueType = "";
              }
              else
                this.newDwelling.SecHeating.FlueType = "Chimney";
            }
            else
              this.newDwelling.SecHeating.FlueType = "Room-sealed";
          }
          else
            this.newDwelling.SecHeating.FlueType = "Open";
        }
        // ISSUE: variable of a reference type
        string& local6;
        // ISSUE: explicit reference operation
        ClassObject2 = (object) ^(local6 = ref this.newDwelling.SecHeating.HETAS);
        this.PopulateValue(ref ClassObject2, data, "Is-Secondary-Heating-HETAS-Approved");
        local6 = Conversions.ToString(ClassObject2);
        this.newDwelling.SecHeating.HETAS = Operators.CompareString(this.newDwelling.SecHeating.HETAS, "true", false) == 0 ? "Yes" : "No";
        Calc2012 calc2012 = new Calc2012();
        calc2012.SETPCDF(SAP_Module.PCDFData);
        PCDF.Table4a_B table4aB = calc2012.Table4a_b(Conversions.ToString(this.newDwelling.SecHeating.SAPTableCode));
        if (Operators.CompareString(this.newDwelling.SecHeating.InforSource, "SAP Tables", false) == 0)
        {
          int sapTableCode = this.newDwelling.SecHeating.SAPTableCode;
          this.newDwelling.SecHeating.SecEff = sapTableCode < 601 || sapTableCode > 613 ? (sapTableCode < 631 || sapTableCode > 636 ? Conversions.ToSingle(table4aB.EffB) : (Operators.CompareString(this.newDwelling.SecHeating.HETAS, "Yes", false) == 0 ? Conversions.ToSingle(table4aB.EffA) : Conversions.ToSingle(table4aB.EffB))) : (Operators.CompareString(this.newDwelling.SecHeating.Fuel, "mains gas", false) == 0 ? Conversions.ToSingle(table4aB.EffA) : Conversions.ToSingle(table4aB.EffB));
        }
        else
          this.newDwelling.SecHeating.SAPTableCode = 1;
      }
      this.HeatingDetails(this.Get_Descendants(data, "Main-Heating-Details"));
      this.CommunityHeating(this.Get_Descendants(data, "SAP-Community-Heating-Systems"));
      XElement descendants = this.Get_Descendants(data, "Secondary-Heating-Declared-Values");
      // ISSUE: variable of a reference type
      float& local7;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local7 = ref this.newDwelling.SecHeating.SecEff);
      this.PopulateValue(ref ClassObject2, descendants, "Efficiency");
      local7 = Conversions.ToSingle(ClassObject2);
      // ISSUE: variable of a reference type
      string& local8;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local8 = ref this.newDwelling.SecHeating.MDescription);
      this.PopulateValue(ref ClassObject2, descendants, "Make-Model");
      local8 = Conversions.ToString(ClassObject2);
      // ISSUE: variable of a reference type
      string& local9;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local9 = ref this.newDwelling.SecHeating.TestMethod);
      this.PopulateValue(ref ClassObject2, descendants, "Test-Method");
      local9 = Conversions.ToString(ClassObject2);
      // ISSUE: variable of a reference type
      bool& local10;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local10 = ref this.newDwelling.Water.Cylinder.PipeWorkInsulated);
      this.PopulateValue(ref ClassObject2, data, "Primary-Pipework-Insulation");
      local10 = Conversions.ToBoolean(ClassObject2);
      this.SolarHeatingDetails(this.Get_Descendants(data, "Solar-Heating-Details"));
      this.InstantWWHRS(this.Get_Descendants(data, "Instantaneous-WWHRS"));
      this.StorageWWHRS(this.Get_Descendants(data, "Storage-WWHRS"));
      this.GetHeatingEfficiency();
      if (!(this.newDwelling.Water.SystemRef == 901 & this.newDwelling.MainHeating.SAPTableCode == 192))
        return;
      this.newDwelling.Water.Cylinder.InHeatedSpace = true;
    }

    private void GetHeatingEfficiency()
    {
      if (!this.newDwelling.MainHeating.InforSource.Equals("SAP Tables"))
        return;
      new Calc2012().SETPCDF(SAP_Module.PCDFData);
      PCDF.Table4a_B table4aB = SAP_Module.PCDFData.Table4a_bs.Where<PCDF.Table4a_B>((Func<PCDF.Table4a_B, bool>) (b => b.Code.Equals(this.newDwelling.MainHeating.SAPTableCode.ToString()))).SingleOrDefault<PCDF.Table4a_B>();
      int sapTableCode = this.newDwelling.MainHeating.SAPTableCode;
      if (sapTableCode >= 191 && sapTableCode <= 196 || sapTableCode >= 401 && sapTableCode <= 515 || sapTableCode >= 691 && sapTableCode <= 701 || sapTableCode >= 621 && sapTableCode <= 625)
        this.newDwelling.MainHeating.MainEff = (float) Conversion.Val(table4aB.EffB);
      else if (sapTableCode >= 601 && sapTableCode <= 613)
        this.newDwelling.MainHeating.MainEff = !this.newDwelling.MainHeating.Fuel.Equals("mains gas") ? (float) Conversion.Val(table4aB.EffB) : (float) Conversion.Val(table4aB.EffA);
      else if (sapTableCode >= 631 && sapTableCode <= 636)
        this.newDwelling.MainHeating.MainEff = Operators.CompareString(this.newDwelling.MainHeating.HETAS, "Yes", false) != 0 ? (float) Conversion.Val(table4aB.EffB) : (float) Conversion.Val(table4aB.EffA);
    }

    private void CommunityHeating(XElement data)
    {
      if (data == null)
        return;
      List<XElement> elementList1 = this.Get_ElementList(data, "SAP-Community-Heating-System");
      try
      {
        foreach (XElement DataValue1 in elementList1)
        {
          object ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Community-Heating-Use");
          string str = Conversions.ToString(ClassObject1);
          if (str.Equals("1") | str.Equals("3"))
          {
            // ISSUE: variable of a reference type
            string& local1;
            // ISSUE: explicit reference operation
            object ClassObject2 = (object) ^(local1 = ref this.newDwelling.MainHeating.CommunityH.HeatDSystem);
            this.PopulateValue(ref ClassObject2, DataValue1, "Community-Heating-Distribution-Type");
            local1 = Conversions.ToString(ClassObject2);
            this.newDwelling.MainHeating.CommunityH.HeatDSystem = this.CommDistribution(this.newDwelling.MainHeating.CommunityH.HeatDSystem);
            this.Get_Descendants(data, "Community-Heat-Sources");
            List<XElement> elementList2 = this.Get_ElementList(DataValue1, "Community-Heat-Source");
            int num = 0;
            try
            {
              foreach (XElement DataValue2 in elementList2)
              {
                SAP_Module.HeatSources heatSources;
                object ClassObject3;
                if (num == 0)
                {
                  // ISSUE: variable of a reference type
                  int& local2;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local2 = ref heatSources.Type);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Heat-Source-Type");
                  local2 = Conversions.ToInteger(ClassObject3);
                  this.newDwelling.MainHeating.SAPTableCode = this.GetCommunity(Conversions.ToString(heatSources.Type));
                  // ISSUE: variable of a reference type
                  string& local3;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local3 = ref this.newDwelling.MainHeating.Fuel);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Fuel-Type");
                  local3 = Conversions.ToString(ClassObject3);
                  this.newDwelling.MainHeating.Fuel = this.FuelCheck(Conversions.ToInteger(this.newDwelling.MainHeating.Fuel));
                  // ISSUE: variable of a reference type
                  float& local4;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local4 = ref this.newDwelling.MainHeating.CommunityH.Boiler1HeatFraction);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Heat-Fraction");
                  local4 = Conversions.ToSingle(ClassObject3);
                  // ISSUE: variable of a reference type
                  float& local5;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local5 = ref this.newDwelling.MainHeating.CommunityH.Boiler1Efficiency);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Heat-Efficiency");
                  local5 = Conversions.ToSingle(ClassObject3);
                  // ISSUE: variable of a reference type
                  float& local6;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local6 = ref this.newDwelling.MainHeating.CommunityH.HeatToPowerRatio);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Power-Efficiency");
                  local6 = Conversions.ToSingle(ClassObject3);
                }
                else
                {
                  this.newDwelling.MainHeating.CommunityH.NoOfAdditionalHeatSources = num;
                  // ISSUE: variable of a reference type
                  int& local7;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local7 = ref heatSources.Type);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Heat-Source-Type");
                  local7 = Conversions.ToInteger(ClassObject3);
                  heatSources.Type = this.GetCommunity(Conversions.ToString(heatSources.Type));
                  // ISSUE: variable of a reference type
                  float& local8;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local8 = ref heatSources.HeatFraction);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Heat-Fraction");
                  local8 = Conversions.ToSingle(ClassObject3);
                  // ISSUE: variable of a reference type
                  string& local9;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local9 = ref heatSources.Fuel);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Fuel-Type");
                  local9 = Conversions.ToString(ClassObject3);
                  heatSources.Fuel = this.FuelCheck(Conversions.ToInteger(heatSources.Fuel));
                  // ISSUE: variable of a reference type
                  float& local10;
                  // ISSUE: explicit reference operation
                  ClassObject3 = (object) ^(local10 = ref heatSources.Efficiency);
                  this.PopulateValue(ref ClassObject3, DataValue2, "Heat-Efficiency");
                  local10 = Conversions.ToSingle(ClassObject3);
                  switch (num - 1)
                  {
                    case 0:
                      this.newDwelling.MainHeating.CommunityH.HeatSource1 = heatSources;
                      break;
                    case 1:
                      this.newDwelling.MainHeating.CommunityH.HeatSource2 = heatSources;
                      break;
                    case 2:
                      this.newDwelling.MainHeating.CommunityH.HeatSource3 = heatSources;
                      break;
                    case 3:
                      this.newDwelling.MainHeating.CommunityH.HeatSource4 = heatSources;
                      break;
                  }
                }
                checked { ++num; }
              }
            }
            finally
            {
              List<XElement>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
          if (str.Equals("2"))
          {
            // ISSUE: variable of a reference type
            string& local11;
            // ISSUE: explicit reference operation
            object ClassObject4 = (object) ^(local11 = ref this.newDwelling.Water.HWSComm.HDS);
            this.PopulateValue(ref ClassObject4, DataValue1, "Community-Heating-Distribution-Type");
            local11 = Conversions.ToString(ClassObject4);
            this.newDwelling.Water.HWSComm.HDS = this.CommDistribution(this.newDwelling.Water.HWSComm.HDS);
            this.Get_Descendants(data, "Community-Heat-Sources");
            List<XElement> elementList3 = this.Get_ElementList(DataValue1, "Community-Heat-Source");
            int num = 0;
            try
            {
              foreach (XElement DataValue3 in elementList3)
              {
                SAP_Module.HeatSources heatSources;
                object ClassObject5;
                if (num == 0)
                {
                  // ISSUE: variable of a reference type
                  int& local12;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local12 = ref heatSources.Type);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Heat-Source-Type");
                  local12 = Conversions.ToInteger(ClassObject5);
                  switch (heatSources.Type)
                  {
                    case 1:
                      this.newDwelling.Water.SystemRef = 951;
                      break;
                    case 2:
                      this.newDwelling.Water.SystemRef = 950;
                      break;
                    case 3:
                      this.newDwelling.Water.SystemRef = 952;
                      break;
                  }
                  // ISSUE: variable of a reference type
                  string& local13;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local13 = ref this.newDwelling.Water.Fuel);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Fuel-Type");
                  local13 = Conversions.ToString(ClassObject5);
                  this.newDwelling.Water.Fuel = this.FuelCheck(Conversions.ToInteger(this.newDwelling.Water.Fuel));
                  // ISSUE: variable of a reference type
                  float& local14;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local14 = ref this.newDwelling.Water.HWSComm.Boiler1Fraction);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Heat-Fraction");
                  local14 = Conversions.ToSingle(ClassObject5);
                  // ISSUE: variable of a reference type
                  float& local15;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local15 = ref this.newDwelling.Water.HWSComm.Efficiency);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Heat-Efficiency");
                  local15 = Conversions.ToSingle(ClassObject5);
                  // ISSUE: variable of a reference type
                  float& local16;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local16 = ref this.newDwelling.Water.HWSComm.CHPPowerEff);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Power-Efficiency");
                  local16 = Conversions.ToSingle(ClassObject5);
                }
                else
                {
                  this.newDwelling.Water.HWSComm.NoOfAdditionalHeatSources = num;
                  // ISSUE: variable of a reference type
                  int& local17;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local17 = ref heatSources.Type);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Heat-Source-Type");
                  local17 = Conversions.ToInteger(ClassObject5);
                  switch (heatSources.Type)
                  {
                    case 1:
                      heatSources.Type = 951;
                      break;
                    case 2:
                      heatSources.Type = 950;
                      break;
                    case 3:
                      heatSources.Type = 952;
                      break;
                  }
                  // ISSUE: variable of a reference type
                  float& local18;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local18 = ref heatSources.HeatFraction);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Heat-Fraction");
                  local18 = Conversions.ToSingle(ClassObject5);
                  // ISSUE: variable of a reference type
                  string& local19;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local19 = ref heatSources.Fuel);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Fuel-Type");
                  local19 = Conversions.ToString(ClassObject5);
                  heatSources.Fuel = this.FuelCheck(Conversions.ToInteger(heatSources.Fuel));
                  // ISSUE: variable of a reference type
                  float& local20;
                  // ISSUE: explicit reference operation
                  ClassObject5 = (object) ^(local20 = ref heatSources.Efficiency);
                  this.PopulateValue(ref ClassObject5, DataValue3, "Heat-Efficiency");
                  local20 = Conversions.ToSingle(ClassObject5);
                  switch (num)
                  {
                    case 1:
                      this.newDwelling.Water.HWSComm.HeatSource1 = heatSources;
                      break;
                    case 2:
                      this.newDwelling.Water.HWSComm.HeatSource1 = heatSources;
                      break;
                    case 3:
                      this.newDwelling.Water.HWSComm.HeatSource1 = heatSources;
                      break;
                    case 4:
                      this.newDwelling.Water.HWSComm.HeatSource1 = heatSources;
                      break;
                  }
                }
                checked { ++num; }
              }
            }
            finally
            {
              List<XElement>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void HeatingDetails(XElement data)
    {
      if (data == null)
        return;
      List<XElement> elementList1 = this.Get_ElementList(data, "Main-Heating");
      try
      {
        foreach (XElement DataValue1 in elementList1)
        {
          SAP_Module.MainHeating mainHeating = new SAP_Module.MainHeating();
          object ClassObject1 = (object) 0;
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Number");
          int integer = Conversions.ToInteger(ClassObject1);
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Category");
          string CatCode = Conversions.ToString(ClassObject1);
          mainHeating.HGroup = this.GetMainCat(CatCode);
          mainHeating.SGroup = this.GetCategory(CatCode);
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Data-Source");
          string str1 = Conversions.ToString(ClassObject1);
          mainHeating.InforSource = this.GetDataSource(str1);
          if (Operators.CompareString(str1, "1", false) == 0)
          {
            // ISSUE: variable of a reference type
            string& local;
            // ISSUE: explicit reference operation
            ClassObject1 = (object) ^(local = ref mainHeating.SEDBUK);
            this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Index-Number");
            local = Conversions.ToString(ClassObject1);
          }
          else if (Operators.CompareString(str1, "2", false) == 0 | Operators.CompareString(str1, "3", false) == 0)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            ClassObject1 = (object) ^(local = ref mainHeating.SAPTableCode);
            this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Code");
            local = Conversions.ToInteger(ClassObject1);
          }
          // ISSUE: variable of a reference type
          float& local1;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local1 = ref mainHeating.Range.CasekW);
          this.PopulateValue(ref ClassObject1, DataValue1, "Case-Heat-Emission");
          local1 = Conversions.ToSingle(ClassObject1);
          // ISSUE: variable of a reference type
          float& local2;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local2 = ref mainHeating.Range.WaterkW);
          this.PopulateValue(ref ClassObject1, DataValue1, "Heat-Transfer-To-Water");
          local2 = Conversions.ToSingle(ClassObject1);
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Combi-Boiler-Type");
          string str2 = Conversions.ToString(ClassObject1);
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
          {
            case 468396612:
              if (Operators.CompareString(str2, "10", false) == 0)
                break;
              break;
            case 806133968:
              if (Operators.CompareString(str2, "5", false) == 0)
                break;
              break;
            case 822911587:
              if (Operators.CompareString(str2, "4", false) == 0)
                break;
              break;
            case 839689206:
              if (Operators.CompareString(str2, "7", false) == 0)
                break;
              break;
            case 856466825:
              if (Operators.CompareString(str2, "6", false) == 0)
                break;
              break;
            case 873244444:
              if (Operators.CompareString(str2, "1", false) == 0)
              {
                this.newDwelling.Water.CombiType = "Instantaneous Combi";
                break;
              }
              break;
            case 906799682:
              if (Operators.CompareString(str2, "3", false) == 0)
              {
                this.newDwelling.Water.CombiType = "Storage combi boiler, secondary store";
                this.newDwelling.Water.Cylinder.InHeatedSpace = true;
                break;
              }
              break;
            case 923577301:
              if (Operators.CompareString(str2, "2", false) == 0)
              {
                this.newDwelling.Water.CombiType = "Storage combi boiler, primary store";
                this.newDwelling.Water.Cylinder.InHeatedSpace = true;
                break;
              }
              break;
            case 1007465396:
              if (Operators.CompareString(str2, "9", false) == 0)
                break;
              break;
            case 1024243015:
              if (Operators.CompareString(str2, "8", false) == 0)
                break;
              break;
          }
          // ISSUE: variable of a reference type
          string& local3;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local3 = ref mainHeating.Fuel);
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Fuel-Type");
          local3 = Conversions.ToString(ClassObject1);
          mainHeating.Fuel = this.FuelCheck(Conversions.ToInteger(mainHeating.Fuel));
          // ISSUE: variable of a reference type
          int& local4;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local4 = ref mainHeating.ControlCode);
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Control");
          local4 = Conversions.ToInteger(ClassObject1);
          XElement descendants = this.Get_Descendants(DataValue1, "Main-Heating-Declared-Values");
          // ISSUE: variable of a reference type
          float& local5;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local5 = ref mainHeating.MainEff);
          this.PopulateValue(ref ClassObject1, descendants, "Efficiency");
          local5 = Conversions.ToSingle(ClassObject1);
          // ISSUE: variable of a reference type
          string& local6;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local6 = ref mainHeating.Boiler.Description);
          this.PopulateValue(ref ClassObject1, descendants, "Make-Model");
          local6 = Conversions.ToString(ClassObject1);
          // ISSUE: variable of a reference type
          string& local7;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local7 = ref mainHeating.Emitter);
          this.PopulateValue(ref ClassObject1, DataValue1, "Heat-Emitter-Type");
          local7 = Conversions.ToString(ClassObject1);
          string emitter1 = mainHeating.Emitter;
          if (Operators.CompareString(emitter1, Conversions.ToString(1), false) == 0)
            mainHeating.Emitter = "Systems with radiators";
          else if (Operators.CompareString(emitter1, Conversions.ToString(2), false) == 0)
          {
            // ISSUE: variable of a reference type
            string& local8;
            // ISSUE: explicit reference operation
            ClassObject1 = (object) ^(local8 = ref mainHeating.Emitter);
            this.PopulateValue(ref ClassObject1, DataValue1, "Underfloor-Heat-Emitter-Type");
            local8 = Conversions.ToString(ClassObject1);
            string emitter2 = mainHeating.Emitter;
            if (Operators.CompareString(emitter2, Conversions.ToString(1), false) == 0)
              mainHeating.Emitter = "Underfloor heating, pipes in concrete slab";
            else if (Operators.CompareString(emitter2, Conversions.ToString(2), false) == 0)
              mainHeating.Emitter = "Underfloor heating, pipes in screed above insulation";
            else if (Operators.CompareString(emitter2, Conversions.ToString(3), false) == 0)
              mainHeating.Emitter = "Underfloor heating, pipes in insulated timber floor";
          }
          else if (Operators.CompareString(emitter1, Conversions.ToString(3), false) == 0)
          {
            // ISSUE: variable of a reference type
            string& local9;
            // ISSUE: explicit reference operation
            ClassObject1 = (object) ^(local9 = ref mainHeating.Emitter);
            this.PopulateValue(ref ClassObject1, DataValue1, "Underfloor-Heat-Emitter-Type");
            local9 = Conversions.ToString(ClassObject1);
            string emitter3 = mainHeating.Emitter;
            if (Operators.CompareString(emitter3, Conversions.ToString(1), false) == 0)
              mainHeating.Emitter = "Underfloor heating and radiators, pipes in concrete slab";
            else if (Operators.CompareString(emitter3, Conversions.ToString(2), false) == 0)
              mainHeating.Emitter = "Underfloor heating and radiators, pipes in screed above insulation";
            else if (Operators.CompareString(emitter3, Conversions.ToString(3), false) == 0)
              mainHeating.Emitter = "Underfloor heating and radiators, pipes in insulated timber floor";
          }
          else if (Operators.CompareString(emitter1, Conversions.ToString(4), false) == 0)
            mainHeating.Emitter = "Fan coil units";
          // ISSUE: variable of a reference type
          string& local10;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local10 = ref mainHeating.Boiler.FlueType);
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Flue-Type");
          local10 = Conversions.ToString(ClassObject1);
          string flueType = mainHeating.Boiler.FlueType;
          if (Operators.CompareString(flueType, Conversions.ToString(1), false) == 0)
            mainHeating.Boiler.FlueType = "Open";
          else if (Operators.CompareString(flueType, Conversions.ToString(2), false) == 0)
            mainHeating.Boiler.FlueType = "balanced flue";
          else if (Operators.CompareString(flueType, Conversions.ToString(3), false) == 0)
            mainHeating.Boiler.FlueType = "Chimney";
          else if (Operators.CompareString(flueType, Conversions.ToString(4), false) == 0)
            mainHeating.Boiler.FlueType = "omitted";
          else if (Operators.CompareString(flueType, Conversions.ToString(5), false) == 0)
            mainHeating.Boiler.FlueType = "Unknown";
          // ISSUE: variable of a reference type
          string& local11;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local11 = ref mainHeating.Boiler.FanFlued);
          this.PopulateValue(ref ClassObject1, DataValue1, "Is-Flue-Fan-Present");
          local11 = Conversions.ToString(ClassObject1);
          mainHeating.Boiler.FanFlued = Operators.CompareString(mainHeating.Boiler.FanFlued, "true", false) == 0 ? "Yes" : "No";
          // ISSUE: variable of a reference type
          string& local12;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local12 = ref mainHeating.Boiler.PumpHP);
          this.PopulateValue(ref ClassObject1, DataValue1, "Is-Central-Heating-Pump-In-Heated-Space");
          local12 = Conversions.ToString(ClassObject1);
          mainHeating.Boiler.PumpHP = Operators.CompareString(mainHeating.Boiler.PumpHP, "true", false) == 0 ? "Yes" : "No";
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Is-Oil-Pump-In-Heated-Space");
          string Left1 = Conversions.ToString(ClassObject1);
          if (!string.IsNullOrEmpty(Left1))
            mainHeating.OilPump = Operators.CompareString(Left1, "true", false) == 0;
          // ISSUE: variable of a reference type
          string& local13;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local13 = ref mainHeating.Boiler.BILock);
          this.PopulateValue(ref ClassObject1, DataValue1, "Is-Interlocked-System");
          local13 = Conversions.ToString(ClassObject1);
          mainHeating.Boiler.BILock = Operators.CompareString(mainHeating.Boiler.BILock, "true", false) == 0 ? "Yes" : "No";
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Has-Separate-Delayed-Start");
          string str3 = Conversions.ToString(ClassObject1);
          if (!string.IsNullOrEmpty(str3))
            mainHeating.DelayedStart = str3.Equals("true");
          // ISSUE: variable of a reference type
          string& local14;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local14 = ref mainHeating.HETAS);
          this.PopulateValue(ref ClassObject1, DataValue1, "Is-Main-Heating-HETAS-Approved");
          local14 = Conversions.ToString(ClassObject1);
          mainHeating.HETAS = Operators.CompareString(mainHeating.HETAS, "true", false) == 0 ? "Yes" : "No";
          // ISSUE: variable of a reference type
          float& local15;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local15 = ref this.newDwelling.Water.CPSUTemp);
          this.PopulateValue(ref ClassObject1, DataValue1, "Electric-CPSU-Operating-Temperature");
          local15 = Conversions.ToSingle(ClassObject1);
          // ISSUE: variable of a reference type
          float& local16;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local16 = ref this.newDwelling.HeatFractionSec);
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Fraction");
          local16 = Conversions.ToSingle(ClassObject1);
          this.newDwelling.HeatFractionSec = 1f - this.newDwelling.HeatFractionSec;
          // ISSUE: variable of a reference type
          string& local17;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local17 = ref mainHeating.FuelBurningType);
          this.PopulateValue(ref ClassObject1, DataValue1, "Burner-Control");
          local17 = Conversions.ToString(ClassObject1);
          string fuelBurningType = mainHeating.FuelBurningType;
          if (Operators.CompareString(fuelBurningType, Conversions.ToString(1), false) == 0)
            mainHeating.FuelBurningType = "Unknown";
          else if (Operators.CompareString(fuelBurningType, Conversions.ToString(2), false) == 0)
            mainHeating.FuelBurningType = "On/off";
          else if (Operators.CompareString(fuelBurningType, Conversions.ToString(3), false) == 0)
            mainHeating.FuelBurningType = "Modulation";
          else if (Operators.CompareString(fuelBurningType, Conversions.ToString(4), false) == 0)
            mainHeating.FuelBurningType = "electrical";
          else if (Operators.CompareString(fuelBurningType, Conversions.ToString(5), false) == 0)
            mainHeating.FuelBurningType = "manual";
          string str4;
          ClassObject1 = (object) str4;
          this.PopulateValue(ref ClassObject1, DataValue1, "Efficiency-Type");
          str4 = Conversions.ToString(ClassObject1);
          string Left2 = str4;
          if (Operators.CompareString(Left2, Conversions.ToString(2), false) == 0)
            mainHeating.SEDBUK2005 = true;
          else if (Operators.CompareString(Left2, Conversions.ToString(3), false) == 0)
            mainHeating.SEDBUK2009 = true;
          else if (Operators.CompareString(Left2, Conversions.ToString(4), false) == 0 || Operators.CompareString(Left2, Conversions.ToString(1), false) != 0)
            ;
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Has-FGHRS");
          string str5 = Conversions.ToString(ClassObject1);
          if (str5 != null)
            this.newDwelling.Water.FGHRS.Include = str5.Equals("true");
          // ISSUE: variable of a reference type
          string& local18;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local18 = ref this.newDwelling.Water.FGHRS.IndexNo);
          this.PopulateValue(ref ClassObject1, DataValue1, "FGHRS-Index-Number");
          local18 = Conversions.ToString(ClassObject1);
          List<XElement> elementList2 = this.Get_ElementList(this.Get_Descendants(this.Get_Descendants(DataValue1, "FGHRS-Energy-Source"), "PV-Arrays"), "PV-Array");
          this.newDwelling.Water.FGHRS.PV.Photovoltaics = new SAP_Module.PhotoVoltaics[checked (elementList2.Count - 1 + 1)];
          int index = 0;
          try
          {
            foreach (XElement DataValue2 in elementList2)
            {
              // ISSUE: variable of a reference type
              float& local19;
              // ISSUE: explicit reference operation
              ClassObject1 = (object) ^(local19 = ref this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PPower);
              this.PopulateValue(ref ClassObject1, DataValue2, "Peak-Power");
              local19 = Conversions.ToSingle(ClassObject1);
              // ISSUE: variable of a reference type
              string& local20;
              // ISSUE: explicit reference operation
              ClassObject1 = (object) ^(local20 = ref this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PCOrientation);
              this.PopulateValue(ref ClassObject1, DataValue2, "Orientation");
              local20 = Conversions.ToString(ClassObject1);
              this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PCOrientation = this.PVOrientation(this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PCOrientation);
              // ISSUE: variable of a reference type
              string& local21;
              // ISSUE: explicit reference operation
              ClassObject1 = (object) ^(local21 = ref this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PTilt);
              this.PopulateValue(ref ClassObject1, DataValue2, "Pitch");
              local21 = Conversions.ToString(ClassObject1);
              this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PTilt = this.PVPitch(this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].PTilt);
              // ISSUE: variable of a reference type
              string& local22;
              // ISSUE: explicit reference operation
              ClassObject1 = (object) ^(local22 = ref this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].POvershading);
              this.PopulateValue(ref ClassObject1, DataValue2, "Overshading");
              local22 = Conversions.ToString(ClassObject1);
              this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].POvershading = this.PVOvershading(this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].POvershading);
              // ISSUE: variable of a reference type
              string& local23;
              // ISSUE: explicit reference operation
              ClassObject1 = (object) ^(local23 = ref this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].FlatConnection);
              this.PopulateValue(ref ClassObject1, DataValue2, "PV-Connection");
              local23 = Conversions.ToString(ClassObject1);
              this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].FlatConnection = this.PVConnection(this.newDwelling.Water.FGHRS.PV.Photovoltaics[index].FlatConnection);
              checked { ++index; }
            }
          }
          finally
          {
            List<XElement>.Enumerator enumerator;
            enumerator.Dispose();
          }
          // ISSUE: variable of a reference type
          int& local24;
          // ISSUE: explicit reference operation
          object ClassObject2 = (object) ^(local24 = ref this.newDwelling.Renewable.WindTurbine.WNumber);
          this.PopulateValue(ref ClassObject2, DataValue1, "Wind-Turbines-Count");
          local24 = Conversions.ToInteger(ClassObject2);
          // ISSUE: variable of a reference type
          string& local25;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local25 = ref this.newDwelling.Renewable.WindTurbine.WRDiameter);
          this.PopulateValue(ref ClassObject2, DataValue1, "Wind-Turbine-Rotor-Diameter");
          local25 = Conversions.ToString(ClassObject2);
          // ISSUE: variable of a reference type
          string& local26;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local26 = ref this.newDwelling.Renewable.WindTurbine.WHeight);
          this.PopulateValue(ref ClassObject2, DataValue1, "Wind-Turbine-Hub-Height");
          local26 = Conversions.ToString(ClassObject2);
          // ISSUE: variable of a reference type
          string& local27;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local27 = ref this.newDwelling.Terrain);
          this.PopulateValue(ref ClassObject2, DataValue1, "Wind-Turbine-Terrain-Type");
          local27 = Conversions.ToString(ClassObject2);
          string terrain = this.newDwelling.Terrain;
          this.newDwelling.Terrain = Operators.CompareString(terrain, Conversions.ToString(1), false) != 0 ? (Operators.CompareString(terrain, Conversions.ToString(2), false) != 0 ? (Operators.CompareString(terrain, Conversions.ToString(3), false) != 0 ? (Operators.CompareString(terrain, Conversions.ToString(4), false) != 0 ? "not recorded" : "not recorded") : "Rural") : "Low rise urban / suburban") : "Dense urban";
          // ISSUE: variable of a reference type
          float& local28;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local28 = ref this.newDwelling.Renewable.AAEGeneration.EGenerated);
          this.PopulateValue(ref ClassObject2, DataValue1, "Hydro-Electric-Generation");
          local28 = Conversions.ToSingle(ClassObject2);
          // ISSUE: variable of a reference type
          int& local29;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local29 = ref this.newDwelling.LELOutlets);
          this.PopulateValue(ref ClassObject2, DataValue1, "Fixed-Lighting-Outlets-Count");
          local29 = Conversions.ToInteger(ClassObject2);
          // ISSUE: variable of a reference type
          int& local30;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local30 = ref this.newDwelling.LELLights);
          this.PopulateValue(ref ClassObject2, DataValue1, "Low-Energy-Fixed-Lighting-Outlets-Count");
          local30 = Conversions.ToInteger(ClassObject2);
          // ISSUE: variable of a reference type
          float& local31;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local31 = ref this.newDwelling.LowEnergyLight);
          this.PopulateValue(ref ClassObject2, DataValue1, "Low-Energy-Fixed-Lighting-Outlets-Percentage");
          local31 = Conversions.ToSingle(ClassObject2);
          // ISSUE: variable of a reference type
          string& local32;
          // ISSUE: explicit reference operation
          ClassObject2 = (object) ^(local32 = ref mainHeating.ElectricityTariff);
          this.PopulateValue(ref ClassObject2, DataValue1, "Electricity-Tariff");
          local32 = Conversions.ToString(ClassObject2);
          mainHeating.ElectricityTariff = this.Tariff(mainHeating.ElectricityTariff);
          List<XElement> elementList3 = this.Get_ElementList(this.Get_Descendants(DataValue1, "Storage-Heaters"), "Storage-Heater");
          try
          {
            foreach (XElement DataValue3 in elementList3)
            {
              this.PopulateValue(ref this.newDwelling.ReplaceMe, DataValue3, "Number-Of-Heaters");
              this.PopulateValue(ref this.newDwelling.ReplaceMe, DataValue3, "Index-Number");
              this.PopulateValue(ref this.newDwelling.ReplaceMe, DataValue3, "High-Heat-Retention");
            }
          }
          finally
          {
            List<XElement>.Enumerator enumerator;
            enumerator.Dispose();
          }
          // ISSUE: variable of a reference type
          string& local33;
          // ISSUE: explicit reference operation
          object ClassObject3 = (object) ^(local33 = ref mainHeating.Boiler.FlowTemp);
          this.PopulateValue(ref ClassObject3, DataValue1, "Emitter-Temperature");
          local33 = Conversions.ToString(ClassObject3);
          string flowTemp = mainHeating.Boiler.FlowTemp;
          mainHeating.Boiler.FlowTemp = Operators.CompareString(flowTemp, Conversions.ToString(0), false) != 0 ? (Operators.CompareString(flowTemp, Conversions.ToString(1), false) != 0 ? (Operators.CompareString(flowTemp, Conversions.ToString(3), false) != 0 ? (Operators.CompareString(flowTemp, Conversions.ToString(4), false) != 0 ? "NA" : "Design flow temperature<=35°C") : "Design flow temperature<=45°C") : "Design flow temperature >45°C") : "Unknown";
          // ISSUE: variable of a reference type
          string& local34;
          // ISSUE: explicit reference operation
          object ClassObject4 = (object) ^(local34 = ref mainHeating.Boiler.PumpType);
          this.PopulateValue(ref ClassObject4, DataValue1, "Central-Heating-Pump-Age");
          local34 = Conversions.ToString(ClassObject4);
          string pumpType = mainHeating.Boiler.PumpType;
          if (Operators.CompareString(pumpType, Conversions.ToString(1), false) == 0)
            mainHeating.Boiler.PumpType = "2012 or earlier";
          else if (Operators.CompareString(pumpType, Conversions.ToString(2), false) == 0)
            mainHeating.Boiler.PumpType = "2013 or later";
          else if (Operators.CompareString(pumpType, Conversions.ToString(0), false) == 0)
            mainHeating.Boiler.PumpType = "unknown";
          ClassObject1 = (object) "";
          this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Systems-Interaction");
          string Left3 = Conversions.ToString(ClassObject1);
          if (Operators.CompareString(Left3, Conversions.ToString(2), false) == 0)
            this.newDwelling.Include_SecMain_Heat_Separat_Part = true;
          else if (Operators.CompareString(Left3, Conversions.ToString(1), false) == 0)
            this.newDwelling.Include_SecMain_Heat_Whole = true;
          this.PopulateValue(ref this.newDwelling.ReplaceMe, DataValue1, "MCS-Installed-Heat-Pump");
          this.PopulateValue(ref this.newDwelling.ReplaceMe, DataValue1, "Compensating-Controller-Index-Number");
          this.PopulateValue(ref this.newDwelling.ReplaceMe, DataValue1, "TTZC-Index-Number");
          // ISSUE: variable of a reference type
          float& local35;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local35 = ref mainHeating.Range.CasekW);
          this.PopulateValue(ref ClassObject1, DataValue1, "Case-Heat-Emission");
          local35 = Conversions.ToSingle(ClassObject1);
          // ISSUE: variable of a reference type
          float& local36;
          // ISSUE: explicit reference operation
          ClassObject1 = (object) ^(local36 = ref mainHeating.Range.WaterkW);
          this.PopulateValue(ref ClassObject1, DataValue1, "Heat-Transfer-To-Water");
          local36 = Conversions.ToSingle(ClassObject1);
          if (mainHeating.InforSource.Equals("Manufacturer Declaration"))
          {
            ClassObject1 = (object) "";
            this.PopulateValue(ref ClassObject1, DataValue1, "Main-Heating-Category");
            string str6 = Conversions.ToString(ClassObject1);
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str6))
            {
              case 468396612:
                if (Operators.CompareString(str6, "10", false) == 0)
                  break;
                break;
              case 485174231:
                if (Operators.CompareString(str6, "11", false) == 0)
                  break;
                break;
              case 806133968:
                if (Operators.CompareString(str6, "5", false) == 0)
                  break;
                break;
              case 822911587:
                if (Operators.CompareString(str6, "4", false) == 0)
                  break;
                break;
              case 839689206:
                if (Operators.CompareString(str6, "7", false) == 0)
                  break;
                break;
              case 856466825:
                if (Operators.CompareString(str6, "6", false) == 0)
                  break;
                break;
              case 873244444:
                if (Operators.CompareString(str6, "1", false) == 0)
                  break;
                break;
              case 906799682:
                if (Operators.CompareString(str6, "3", false) == 0)
                  break;
                break;
              case 923577301:
                if (Operators.CompareString(str6, "2", false) == 0)
                {
                  ClassObject1 = (object) str6;
                  this.PopulateValue(ref ClassObject1, DataValue1, "Gas-Or-Oil-Boiler-Type");
                  string Left4 = Conversions.ToString(ClassObject1);
                  ClassObject1 = (object) "";
                  this.PopulateValue(ref ClassObject1, DataValue1, "Is-Condensing-Boiler");
                  string str7 = Conversions.ToString(ClassObject1);
                  if (string.IsNullOrEmpty(str7))
                    str7 = "";
                  if (Operators.CompareString(Left4, "1", false) != 0)
                  {
                    if (Operators.CompareString(Left4, "2", false) != 0)
                    {
                      if (Operators.CompareString(Left4, "3", false) != 0)
                      {
                        if (Operators.CompareString(Left4, "4", false) == 0)
                        {
                          mainHeating.SAPTableCode = !str7.Equals("true") ? 133 : 133;
                          break;
                        }
                        break;
                      }
                      mainHeating.SAPTableCode = !str7.Equals("true") ? 120 : 121;
                      break;
                    }
                    mainHeating.SAPTableCode = !str7.Equals("true") ? 103 : 104;
                    if (mainHeating.Fuel.Equals("heating oil"))
                    {
                      mainHeating.SAPTableCode = !str7.Equals("true") ? 129 : 130;
                      break;
                    }
                    break;
                  }
                  mainHeating.SAPTableCode = !str7.Equals("true") ? 101 : 102;
                  if (mainHeating.Fuel.Equals("heating oil"))
                  {
                    mainHeating.SAPTableCode = !str7.Equals("true") ? 126 : (int) sbyte.MaxValue;
                    break;
                  }
                  break;
                }
                break;
              case 1007465396:
                if (Operators.CompareString(str6, "9", false) == 0)
                  break;
                break;
              case 1024243015:
                if (Operators.CompareString(str6, "8", false) == 0)
                  break;
                break;
            }
          }
          switch (integer)
          {
            case 1:
              this.newDwelling.MainHeating = mainHeating;
              break;
            case 2:
              this.newDwelling.MainHeating2 = mainHeating;
              break;
            default:
              this.newDwelling.MainHeating = mainHeating;
              break;
          }
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void OpeningTypes(XElement data)
    {
      if (data != null)
      {
        List<XElement> elementList = this.Get_ElementList(data, "SAP-Opening-Type");
        try
        {
          foreach (XElement DataValue in elementList)
          {
            object ClassObject1 = (object) "";
            this.PopulateValue(ref ClassObject1, DataValue, "Name");
            string str = Conversions.ToString(ClassObject1);
            if (this.newDwelling.Doors != null)
            {
              int num1 = checked (this.newDwelling.Doors.Length - 1);
              int index1 = 0;
              while (index1 <= num1)
              {
                if (this.newDwelling.Doors[index1].OpeningType.Equals(str))
                {
                  // ISSUE: variable of a reference type
                  string& local1;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local1 = ref this.newDwelling.Doors[index1].UValueSource);
                  this.PopulateValue(ref ClassObject1, DataValue, "Data-Source");
                  local1 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Doors[index1].UValueSource = this.WindowSource(this.newDwelling.Doors[index1].UValueSource);
                  ClassObject1 = (object) false;
                  this.PopulateValue(ref ClassObject1, DataValue, "IsArgonFilled");
                  bool boolean = Conversions.ToBoolean(ClassObject1);
                  // ISSUE: variable of a reference type
                  string& local2;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local2 = ref this.newDwelling.Doors[index1].GlazingType);
                  this.PopulateValue(ref ClassObject1, DataValue, "Glazing-Type");
                  local2 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Doors[index1].GlazingType = this.WindowType(this.newDwelling.Doors[index1].GlazingType, boolean);
                  this.newDwelling.Doors[index1].DoorType = Operators.CompareString(this.newDwelling.Doors[index1].GlazingType, "", false) != 0 ? "Half glazed" : "Solid";
                  // ISSUE: variable of a reference type
                  string& local3;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local3 = ref this.newDwelling.Doors[index1].AirGap);
                  this.PopulateValue(ref ClassObject1, DataValue, "Glazing-Gap");
                  local3 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Doors[index1].AirGap = this.GlazingGap(this.newDwelling.Doors[index1].AirGap);
                  // ISSUE: variable of a reference type
                  string& local4;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local4 = ref this.newDwelling.Doors[index1].FrameType);
                  this.PopulateValue(ref ClassObject1, DataValue, "Frame-Type");
                  local4 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Doors[index1].ThermalBreak = this.ThermalBreak(this.newDwelling.Doors[index1].FrameType);
                  this.newDwelling.Doors[index1].FrameType = this.FrameType(this.newDwelling.Doors[index1].FrameType);
                  this.newDwelling.Doors[index1].Overshading = this.newDwelling.Overshading;
                  // ISSUE: variable of a reference type
                  float& local5;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local5 = ref this.newDwelling.Doors[index1].g);
                  this.PopulateValue(ref ClassObject1, DataValue, "Solar-Transmittance");
                  local5 = Conversions.ToSingle(ClassObject1);
                  // ISSUE: variable of a reference type
                  float& local6;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local6 = ref this.newDwelling.Doors[index1].FF);
                  this.PopulateValue(ref ClassObject1, DataValue, "Frame-Factor");
                  local6 = Conversions.ToSingle(ClassObject1);
                  // ISSUE: variable of a reference type
                  float& local7;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local7 = ref this.newDwelling.Doors[index1].U);
                  this.PopulateValue(ref ClassObject1, DataValue, "U-Value");
                  local7 = Conversions.ToSingle(ClassObject1);
                }
                checked { ++index1; }
              }
              int num2 = checked (this.newDwelling.Doors.Length - 1);
              int index2 = 0;
              while (index2 <= num2)
              {
                this.newDwelling.Doors[index2].Count = 1;
                checked { ++index2; }
              }
            }
            if (this.newDwelling.Windows != null)
            {
              int num3 = checked (this.newDwelling.Windows.Length - 1);
              int index3 = 0;
              while (index3 <= num3)
              {
                if (this.newDwelling.Windows[index3].OpeningType.Equals(str))
                {
                  // ISSUE: variable of a reference type
                  string& local8;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local8 = ref this.newDwelling.Windows[index3].UValueSource);
                  this.PopulateValue(ref ClassObject1, DataValue, "Data-Source");
                  local8 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Windows[index3].UValueSource = this.WindowSource(this.newDwelling.Windows[index3].UValueSource);
                  ClassObject1 = (object) false;
                  this.PopulateValue(ref ClassObject1, DataValue, "IsArgonFilled");
                  bool boolean = Conversions.ToBoolean(ClassObject1);
                  // ISSUE: variable of a reference type
                  string& local9;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local9 = ref this.newDwelling.Windows[index3].GlazingType);
                  this.PopulateValue(ref ClassObject1, DataValue, "Glazing-Type");
                  local9 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Windows[index3].GlazingType = this.WindowType(this.newDwelling.Windows[index3].GlazingType, boolean);
                  // ISSUE: variable of a reference type
                  string& local10;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local10 = ref this.newDwelling.Windows[index3].AirGap);
                  this.PopulateValue(ref ClassObject1, DataValue, "Glazing-Gap");
                  local10 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Windows[index3].AirGap = this.GlazingGap(this.newDwelling.Windows[index3].AirGap);
                  // ISSUE: variable of a reference type
                  string& local11;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local11 = ref this.newDwelling.Windows[index3].FrameType);
                  this.PopulateValue(ref ClassObject1, DataValue, "Frame-Type");
                  local11 = Conversions.ToString(ClassObject1);
                  this.newDwelling.Windows[index3].ThermalBreak = this.ThermalBreak(this.newDwelling.Windows[index3].FrameType);
                  this.newDwelling.Windows[index3].FrameType = this.FrameType(this.newDwelling.Windows[index3].FrameType);
                  this.newDwelling.Windows[index3].Overshading = this.newDwelling.Overshading;
                  // ISSUE: variable of a reference type
                  float& local12;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local12 = ref this.newDwelling.Windows[index3].g);
                  this.PopulateValue(ref ClassObject1, DataValue, "Solar-Transmittance");
                  local12 = Conversions.ToSingle(ClassObject1);
                  // ISSUE: variable of a reference type
                  float& local13;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local13 = ref this.newDwelling.Windows[index3].FF);
                  this.PopulateValue(ref ClassObject1, DataValue, "Frame-Factor");
                  local13 = Conversions.ToSingle(ClassObject1);
                  // ISSUE: variable of a reference type
                  float& local14;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local14 = ref this.newDwelling.Windows[index3].U);
                  this.PopulateValue(ref ClassObject1, DataValue, "U-Value");
                  local14 = Conversions.ToSingle(ClassObject1);
                }
                checked { ++index3; }
              }
              int num4 = checked (this.newDwelling.Windows.Length - 1);
              int index4 = 0;
              while (index4 <= num4)
              {
                this.newDwelling.Windows[index4].Count = 1;
                checked { ++index4; }
              }
            }
            if (this.newDwelling.RoofLights != null)
            {
              int num5 = checked (this.newDwelling.RoofLights.Length - 1);
              int index5 = 0;
              while (index5 <= num5)
              {
                if (this.newDwelling.RoofLights[index5].OpeningType.Equals(str))
                {
                  // ISSUE: variable of a reference type
                  string& local15;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local15 = ref this.newDwelling.RoofLights[index5].UValueSource);
                  this.PopulateValue(ref ClassObject1, DataValue, "Data-Source");
                  local15 = Conversions.ToString(ClassObject1);
                  this.newDwelling.RoofLights[index5].UValueSource = this.WindowSource(this.newDwelling.RoofLights[index5].UValueSource);
                  ClassObject1 = (object) false;
                  this.PopulateValue(ref ClassObject1, DataValue, "IsArgonFilled");
                  bool boolean = Conversions.ToBoolean(ClassObject1);
                  // ISSUE: variable of a reference type
                  string& local16;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local16 = ref this.newDwelling.RoofLights[index5].GlazingType);
                  this.PopulateValue(ref ClassObject1, DataValue, "Glazing-Type");
                  local16 = Conversions.ToString(ClassObject1);
                  this.newDwelling.RoofLights[index5].GlazingType = this.WindowType(this.newDwelling.RoofLights[index5].GlazingType, boolean);
                  // ISSUE: variable of a reference type
                  string& local17;
                  // ISSUE: explicit reference operation
                  ClassObject1 = (object) ^(local17 = ref this.newDwelling.RoofLights[index5].AirGap);
                  this.PopulateValue(ref ClassObject1, DataValue, "Glazing-Gap");
                  local17 = Conversions.ToString(ClassObject1);
                  this.newDwelling.RoofLights[index5].AirGap = this.GlazingGap(this.newDwelling.RoofLights[index5].AirGap);
                  try
                  {
                    // ISSUE: variable of a reference type
                    string& local18;
                    // ISSUE: explicit reference operation
                    ClassObject1 = (object) ^(local18 = ref this.newDwelling.Windows[index5].FrameType);
                    this.PopulateValue(ref ClassObject1, DataValue, "Frame-Type");
                    local18 = Conversions.ToString(ClassObject1);
                    this.newDwelling.RoofLights[index5].ThermalBreak = this.ThermalBreak(this.newDwelling.RoofLights[index5].ThermalBreak);
                    this.newDwelling.RoofLights[index5].FrameType = this.FrameType(this.newDwelling.RoofLights[index5].FrameType);
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                  }
                  this.newDwelling.RoofLights[index5].Overshading = this.newDwelling.Overshading;
                  // ISSUE: variable of a reference type
                  float& local19;
                  // ISSUE: explicit reference operation
                  object ClassObject2 = (object) ^(local19 = ref this.newDwelling.RoofLights[index5].g);
                  this.PopulateValue(ref ClassObject2, DataValue, "Solar-Transmittance");
                  local19 = Conversions.ToSingle(ClassObject2);
                  // ISSUE: variable of a reference type
                  float& local20;
                  // ISSUE: explicit reference operation
                  object ClassObject3 = (object) ^(local20 = ref this.newDwelling.RoofLights[index5].FF);
                  this.PopulateValue(ref ClassObject3, DataValue, "Frame-Factor");
                  local20 = Conversions.ToSingle(ClassObject3);
                  // ISSUE: variable of a reference type
                  float& local21;
                  // ISSUE: explicit reference operation
                  object ClassObject4 = (object) ^(local21 = ref this.newDwelling.RoofLights[index5].U);
                  this.PopulateValue(ref ClassObject4, DataValue, "U-Value");
                  local21 = Conversions.ToSingle(ClassObject4);
                }
                checked { ++index5; }
              }
              int num6 = checked (this.newDwelling.RoofLights.Length - 1);
              int index6 = 0;
              while (index6 <= num6)
              {
                this.newDwelling.RoofLights[index6].Count = 1;
                checked { ++index6; }
              }
            }
          }
        }
        finally
        {
          List<XElement>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      this.newDwelling.GrossAreas = true;
    }

    private void SecondaryHeating(XElement data)
    {
      if (data == null)
        return;
      List<XElement> elementList = this.Get_ElementList(data, "SAP-Heating");
      try
      {
        foreach (XElement DataValue in elementList)
        {
          // ISSUE: variable of a reference type
          string& local1;
          // ISSUE: explicit reference operation
          object ClassObject = (object) ^(local1 = ref this.newDwelling.SecHeating.HGroup);
          this.PopulateValue(ref ClassObject, DataValue, "Secondary-Heating-Category");
          local1 = Conversions.ToString(ClassObject);
          this.newDwelling.SecHeating.HGroup = "Room heaters";
          // ISSUE: variable of a reference type
          string& local2;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local2 = ref this.newDwelling.SecHeating.InforSource);
          this.PopulateValue(ref ClassObject, DataValue, "Secondary-Heating-Data-Source");
          local2 = Conversions.ToString(ClassObject);
          if (!string.IsNullOrEmpty(this.newDwelling.SecHeating.InforSource))
          {
            if (this.newDwelling.SecHeating.InforSource.Equals("2"))
              this.newDwelling.SecHeating.InforSource = "Manufacturer Declaration";
            if (this.newDwelling.SecHeating.InforSource.Equals("3"))
              this.newDwelling.SecHeating.InforSource = "SAP Tables";
          }
          // ISSUE: variable of a reference type
          int& local3;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local3 = ref this.newDwelling.SecHeating.SAPTableCode);
          this.PopulateValue(ref ClassObject, DataValue, "Secondary-Heating-Code");
          local3 = Conversions.ToInteger(ClassObject);
          // ISSUE: variable of a reference type
          string& local4;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local4 = ref this.newDwelling.SecHeating.Fuel);
          this.PopulateValue(ref ClassObject, DataValue, "Secondary-Fuel-Type");
          local4 = Conversions.ToString(ClassObject);
          this.newDwelling.SecHeating.Fuel = this.FuelCheck(Conversions.ToInteger(this.newDwelling.SecHeating.Fuel));
          // ISSUE: variable of a reference type
          string& local5;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local5 = ref this.newDwelling.SecHeating.FlueType);
          this.PopulateValue(ref ClassObject, DataValue, "Secondary-Heating-Flue-Type");
          local5 = Conversions.ToString(ClassObject);
          if (!string.IsNullOrEmpty(this.newDwelling.SecHeating.FlueType))
          {
            string flueType = this.newDwelling.SecHeating.FlueType;
            if (Operators.CompareString(flueType, "1", false) != 0)
            {
              if (Operators.CompareString(flueType, "2", false) != 0)
              {
                if (Operators.CompareString(flueType, "3", false) != 0)
                {
                  if (Operators.CompareString(flueType, "4", false) != 0)
                  {
                    if (Operators.CompareString(flueType, "5", false) == 0)
                      this.newDwelling.SecHeating.FlueType = "Unknown";
                  }
                  else
                    this.newDwelling.SecHeating.FlueType = "";
                }
                else
                  this.newDwelling.SecHeating.FlueType = "Chimney";
              }
              else
                this.newDwelling.SecHeating.FlueType = "Room-sealed";
            }
            else
              this.newDwelling.SecHeating.FlueType = "Open";
          }
          // ISSUE: variable of a reference type
          string& local6;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local6 = ref this.newDwelling.SecHeating.HETAS);
          this.PopulateValue(ref ClassObject, DataValue, "Is-Secondary-Heating-HETAS-Approved");
          local6 = Conversions.ToString(ClassObject);
          this.newDwelling.SecHeating.HETAS = Operators.CompareString(this.newDwelling.SecHeating.HETAS, "true", false) == 0 ? "Yes" : "No";
          this.Get_Descendants(DataValue, "Secondary-Heating-Declared-Values");
          // ISSUE: variable of a reference type
          float& local7;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local7 = ref this.newDwelling.SecHeating.SecEff);
          this.PopulateValue(ref ClassObject, DataValue, "Efficiency");
          local7 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          string& local8;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local8 = ref this.newDwelling.SecHeating.MDescription);
          this.PopulateValue(ref ClassObject, DataValue, "Make-Model");
          local8 = Conversions.ToString(ClassObject);
          // ISSUE: variable of a reference type
          string& local9;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local9 = ref this.newDwelling.SecHeating.TestMethod);
          this.PopulateValue(ref ClassObject, DataValue, "Test-Method");
          local9 = Conversions.ToString(ClassObject);
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void SpecialFeatures(XElement data)
    {
      if (data == null)
        return;
      this.newDwelling.Renewable.Special.Include = true;
      int index = 0;
      List<XElement> elementList1 = this.Get_ElementList(data, "SAP-Special-Feature");
      this.newDwelling.Renewable.Special.Special = new SAP_Module.SpecialFeatures[checked (elementList1.Count - 1 + 1)];
      try
      {
        foreach (XElement DataValue1 in elementList1)
        {
          this.newDwelling.Renewable.Special.Special[index].Include = true;
          this.newDwelling.Renewable.Special.Special[index].ID = index;
          // ISSUE: variable of a reference type
          string& local1;
          // ISSUE: explicit reference operation
          object ClassObject = (object) ^(local1 = ref this.newDwelling.Renewable.Special.Special[index].Description);
          this.PopulateValue(ref ClassObject, DataValue1, "Description");
          local1 = Conversions.ToString(ClassObject);
          XElement descendants = this.Get_Descendants(DataValue1, "Energy-Feature");
          // ISSUE: variable of a reference type
          float& local2;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local2 = ref this.newDwelling.Renewable.Special.Special[index].EnergySaved);
          this.PopulateValue(ref ClassObject, descendants, "Energy-Saved-Or-Generated");
          local2 = Conversions.ToSingle(ClassObject);
          // ISSUE: variable of a reference type
          string& local3;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local3 = ref this.newDwelling.Renewable.Special.Special[index].FuelSaved);
          this.PopulateValue(ref ClassObject, descendants, "Saved-Or-Generated-Fuel");
          local3 = Conversions.ToString(ClassObject);
          this.newDwelling.Renewable.Special.Special[index].FuelSaved = this.FuelCheck(Conversions.ToInteger(this.newDwelling.Renewable.Special.Special[index].FuelSaved));
          // ISSUE: variable of a reference type
          float& local4;
          // ISSUE: explicit reference operation
          ClassObject = (object) ^(local4 = ref this.newDwelling.Renewable.Special.Special[index].EnergyUsed);
          this.PopulateValue(ref ClassObject, descendants, "Energy-Used");
          local4 = Conversions.ToSingle(ClassObject);
          if ((double) this.newDwelling.Renewable.Special.Special[index].EnergyUsed != 0.0)
          {
            // ISSUE: variable of a reference type
            string& local5;
            // ISSUE: explicit reference operation
            ClassObject = (object) ^(local5 = ref this.newDwelling.Renewable.Special.Special[index].FuelUsed);
            this.PopulateValue(ref ClassObject, descendants, "Energy-Used-Fuel");
            local5 = Conversions.ToString(ClassObject);
            this.newDwelling.Renewable.Special.Special[index].FuelUsed = this.FuelCheck(Conversions.ToInteger(this.newDwelling.Renewable.Special.Special[index].FuelUsed));
          }
          List<XElement> elementList2 = this.Get_ElementList(this.Get_Descendants(descendants, "Air-Change-Rates"), "Air-Change-Rate");
          if (elementList2 != null)
            this.newDwelling.Renewable.Special.Special[index].IncludeMonthly = true;
          try
          {
            foreach (XElement DataValue2 in elementList2)
            {
              ClassObject = (object) "";
              this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Month");
              string str = Conversions.ToString(ClassObject);
              // ISSUE: reference to a compiler-generated method
              switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
              {
                case 298972137:
                  if (Operators.CompareString(str, "Oct", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local6;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local6 = ref this.newDwelling.Renewable.Special.Special[index].M10);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local6 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 660503155:
                  if (Operators.CompareString(str, "Dec", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local7;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local7 = ref this.newDwelling.Renewable.Special.Special[index].M12);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local7 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 663571330:
                  if (Operators.CompareString(str, "Feb", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local8;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local8 = ref this.newDwelling.Renewable.Special.Special[index].M2);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local8 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 749839599:
                  if (Operators.CompareString(str, "Sep", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local9;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local9 = ref this.newDwelling.Renewable.Special.Special[index].M9);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local9 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 1000858150:
                  if (Operators.CompareString(str, "May", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local10;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local10 = ref this.newDwelling.Renewable.Special.Special[index].M5);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local10 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 1118301483:
                  if (Operators.CompareString(str, "Mar", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local11;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local11 = ref this.newDwelling.Renewable.Special.Special[index].M3);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local11 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 1153511100:
                  if (Operators.CompareString(str, "Jul", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local12;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local12 = ref this.newDwelling.Renewable.Special.Special[index].M7);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local12 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 1187066338:
                  if (Operators.CompareString(str, "Jun", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local13;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local13 = ref this.newDwelling.Renewable.Special.Special[index].M6);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local13 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 1190317742:
                  if (Operators.CompareString(str, "Jan", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local14;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local14 = ref this.newDwelling.Renewable.Special.Special[index].M1);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local14 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 2213879282:
                  if (Operators.CompareString(str, "Apr", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local15;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local15 = ref this.newDwelling.Renewable.Special.Special[index].M4);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local15 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 2319303684:
                  if (Operators.CompareString(str, "Nov", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local16;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local16 = ref this.newDwelling.Renewable.Special.Special[index].M11);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local16 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
                case 2699988948:
                  if (Operators.CompareString(str, "Aug", false) == 0)
                  {
                    // ISSUE: variable of a reference type
                    float& local17;
                    // ISSUE: explicit reference operation
                    ClassObject = (object) ^(local17 = ref this.newDwelling.Renewable.Special.Special[index].M8);
                    this.PopulateValue(ref ClassObject, DataValue2, "Air-Change-Rate-Value");
                    local17 = Conversions.ToSingle(ClassObject);
                    break;
                  }
                  break;
              }
            }
          }
          finally
          {
            List<XElement>.Enumerator enumerator;
            enumerator.Dispose();
          }
          checked { ++index; }
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void Ventilation(XElement data)
    {
      if (data == null)
        return;
      // ISSUE: variable of a reference type
      int& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Ventilation.Chimneys);
      this.PopulateValue(ref ClassObject1, data, "Open-Fireplaces-Count");
      local1 = Conversions.ToInteger(ClassObject1);
      // ISSUE: variable of a reference type
      int& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Ventilation.Flues);
      this.PopulateValue(ref ClassObject2, data, "Open-Flues-Count");
      local2 = Conversions.ToInteger(ClassObject2);
      // ISSUE: variable of a reference type
      int& local3;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local3 = ref this.newDwelling.Ventilation.Fans);
      this.PopulateValue(ref ClassObject3, data, "Fans-Vents-Count");
      local3 = Conversions.ToInteger(ClassObject3);
      // ISSUE: variable of a reference type
      int& local4;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local4 = ref this.newDwelling.Ventilation.Fires);
      this.PopulateValue(ref ClassObject4, data, "Flueless-Gas-Fires-Count");
      local4 = Conversions.ToInteger(ClassObject4);
      object ClassObject5 = (object) "";
      this.PopulateValue(ref ClassObject5, data, "Pressure-Test");
      this.newDwelling.Ventilation.Pressure = this.GetPressureType(Conversions.ToString(ClassObject5));
      string pressure = this.newDwelling.Ventilation.Pressure;
      if (Operators.CompareString(pressure, "Calculated", false) != 0)
      {
        if (Operators.CompareString(pressure, "Assumed", false) != 0)
        {
          if (Operators.CompareString(pressure, "As built", false) != 0)
          {
            if (Operators.CompareString(pressure, "As designed", false) == 0)
            {
              // ISSUE: variable of a reference type
              float& local5;
              // ISSUE: explicit reference operation
              object ClassObject6 = (object) ^(local5 = ref this.newDwelling.Ventilation.DesignAir);
              this.PopulateValue(ref ClassObject6, data, "Air-Permeability");
              local5 = Conversions.ToSingle(ClassObject6);
            }
          }
          else
          {
            // ISSUE: variable of a reference type
            float& local6;
            // ISSUE: explicit reference operation
            object ClassObject7 = (object) ^(local6 = ref this.newDwelling.Ventilation.MeasuredAir);
            this.PopulateValue(ref ClassObject7, data, "Air-Permeability");
            local6 = Conversions.ToSingle(ClassObject7);
          }
        }
        else
        {
          // ISSUE: variable of a reference type
          float& local7;
          // ISSUE: explicit reference operation
          object ClassObject8 = (object) ^(local7 = ref this.newDwelling.Ventilation.AssumedAir);
          this.PopulateValue(ref ClassObject8, data, "Air-Permeability");
          local7 = Conversions.ToSingle(ClassObject8);
        }
      }
      object ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Ground-Floor-Type");
      this.newDwelling.Ventilation.Infiltration.Floor = this.GetFloorType(Conversions.ToString(ClassObject9));
      ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Has-Draught-Lobby");
      string DraughtLobbyCode = Conversions.ToString(ClassObject9);
      if (DraughtLobbyCode != null)
        this.newDwelling.Ventilation.Infiltration.Lobby = this.GetDraughtLobby(DraughtLobbyCode);
      // ISSUE: variable of a reference type
      float& local8;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local8 = ref this.newDwelling.Ventilation.Infiltration.DraguthP);
      this.PopulateValue(ref ClassObject9, data, "DraughtStripping");
      local8 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local9;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local9 = ref this.newDwelling.Ventilation.Shelter);
      this.PopulateValue(ref ClassObject9, data, "Sheltered-Sides-Count");
      local9 = Conversions.ToSingle(ClassObject9);
      ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Ventilation-Type");
      this.newDwelling.Ventilation.MechVent = this.GetVentType(Conversions.ToString(ClassObject9));
      ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Ventilation-Data-Source");
      this.newDwelling.Ventilation.Parameters = this.GetMechVentDataSource(Conversions.ToString(ClassObject9));
      // ISSUE: variable of a reference type
      int& local10;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local10 = ref this.newDwelling.Ventilation.ProductID);
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-System-Index-Number");
      local10 = Conversions.ToInteger(ClassObject9);
      // ISSUE: variable of a reference type
      string& local11;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local11 = ref this.newDwelling.Ventilation.MVDetails.ProductName);
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-System-Make-Model");
      local11 = Conversions.ToString(ClassObject9);
      // ISSUE: variable of a reference type
      int& local12;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local12 = ref this.newDwelling.Ventilation.WetRooms);
      this.PopulateValue(ref ClassObject9, data, "Wet-Rooms-Count");
      local12 = Conversions.ToInteger(ClassObject9);
      if ((uint) this.newDwelling.Ventilation.WetRooms > 0U)
      {
        // ISSUE: variable of a reference type
        int& local13;
        // ISSUE: explicit reference operation
        int num = checked (^(local13 = ref this.newDwelling.Ventilation.WetRooms) - 1);
        local13 = num;
      }
      // ISSUE: variable of a reference type
      float& local14;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local14 = ref this.newDwelling.Ventilation.MVDetails.SFP);
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-Specific-Fan-Power");
      local14 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local15;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local15 = ref this.newDwelling.Ventilation.MVDetails.HEE);
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-Heat-Recovery-Efficiency");
      local15 = Conversions.ToSingle(ClassObject9);
      ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-Duct-Type");
      this.newDwelling.Ventilation.MVDetails.DuctingType = this.GetVentDuctType(Conversions.ToString(ClassObject9));
      ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-Duct-Insulation");
      this.newDwelling.Ventilation.DuctType = Conversions.ToString(this.GetDuctInsulation(Conversions.ToString(ClassObject9)));
      // ISSUE: variable of a reference type
      float& local16;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local16 = ref this.newDwelling.Ventilation.Decentralised.KTP1);
      this.PopulateValue(ref ClassObject9, data, "Kitchen-Room-Fans-Count");
      local16 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local17;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local17 = ref this.newDwelling.Ventilation.Decentralised.KSPF1);
      this.PopulateValue(ref ClassObject9, data, "Kitchen-Room-Fans-Specific-Power");
      local17 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local18;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local18 = ref this.newDwelling.Ventilation.Decentralised.OTP1);
      this.PopulateValue(ref ClassObject9, data, "Non-Kitchen-Room-Fans-Count");
      local18 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local19;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local19 = ref this.newDwelling.Ventilation.Decentralised.OSPF1);
      this.PopulateValue(ref ClassObject9, data, "Non-Kitchen-Room-Fans-Specific-Power");
      local19 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local20;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local20 = ref this.newDwelling.Ventilation.Decentralised.KTP2);
      this.PopulateValue(ref ClassObject9, data, "Kitchen-Duct-Fans-Count");
      local20 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local21;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local21 = ref this.newDwelling.Ventilation.Decentralised.KSPF2);
      this.PopulateValue(ref ClassObject9, data, "Kitchen-Duct-Fans-Specific-Power");
      local21 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local22;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local22 = ref this.newDwelling.Ventilation.Decentralised.OTP2);
      this.PopulateValue(ref ClassObject9, data, "Non-Kitchen-Duct-Fans-Count");
      local22 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local23;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local23 = ref this.newDwelling.Ventilation.Decentralised.OSPF2);
      this.PopulateValue(ref ClassObject9, data, "Non-Kitchen-Duct-Fans-Specific-Power");
      local23 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local24;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local24 = ref this.newDwelling.Ventilation.Decentralised.KTP3);
      this.PopulateValue(ref ClassObject9, data, "Kitchen-Wall-Fans-Count");
      local24 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local25;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local25 = ref this.newDwelling.Ventilation.Decentralised.KSPF3);
      this.PopulateValue(ref ClassObject9, data, "Kitchen-Wall-Fans-Specific-Power");
      local25 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local26;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local26 = ref this.newDwelling.Ventilation.Decentralised.OTP3);
      this.PopulateValue(ref ClassObject9, data, "Non-Kitchen-Wall-Fans-Count");
      local26 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      float& local27;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local27 = ref this.newDwelling.Ventilation.Decentralised.OSPF3);
      this.PopulateValue(ref ClassObject9, data, "Non-Kitchen-Wall-Fans-Specific-Power");
      local27 = Conversions.ToSingle(ClassObject9);
      if (this.newDwelling.Ventilation.MechVent.Equals("Decentralised whole house extract") & this.newDwelling.Ventilation.Parameters.Equals("Database") & !string.IsNullOrEmpty(Conversions.ToString(this.newDwelling.Ventilation.ProductID)))
      {
        new Calc2012().SETPCDF(SAP_Module.PCDFData);
        List<PCDF.Products322_Sub> list = SAP_Module.PCDFData.Products322s_Sub.Where<PCDF.Products322_Sub>((Func<PCDF.Products322_Sub, bool>) (b => b.Ref.Equals(this.newDwelling.Ventilation.ProductID.ToString()))).ToList<PCDF.Products322_Sub>();
        try
        {
          foreach (PCDF.Products322_Sub products322Sub in list)
          {
            if (products322Sub.Configuration.Equals("1"))
              this.newDwelling.Ventilation.Decentralised.KSPF1 = (float) Conversion.Val(products322Sub.SFP);
            if (products322Sub.Configuration.Equals("3"))
              this.newDwelling.Ventilation.Decentralised.KSPF2 = (float) Conversion.Val(products322Sub.SFP);
            if (products322Sub.Configuration.Equals("5"))
              this.newDwelling.Ventilation.Decentralised.KSPF3 = (float) Conversion.Val(products322Sub.SFP);
            if (products322Sub.Configuration.Equals("2"))
              this.newDwelling.Ventilation.Decentralised.OSPF1 = (float) Conversion.Val(products322Sub.SFP);
            if (products322Sub.Configuration.Equals("4"))
              this.newDwelling.Ventilation.Decentralised.OSPF2 = (float) Conversion.Val(products322Sub.SFP);
            if (products322Sub.Configuration.Equals("6"))
              this.newDwelling.Ventilation.Decentralised.OSPF3 = (float) Conversion.Val(products322Sub.SFP);
          }
        }
        finally
        {
          List<PCDF.Products322_Sub>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      // ISSUE: variable of a reference type
      int& local28;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local28 = ref this.newDwelling.Ventilation.Fans);
      this.PopulateValue(ref ClassObject9, data, "Extract-Fans-Count");
      local28 = Conversions.ToInteger(ClassObject9);
      // ISSUE: variable of a reference type
      int& local29;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local29 = ref this.newDwelling.Ventilation.Vents);
      this.PopulateValue(ref ClassObject9, data, "PSV-Count");
      local29 = Conversions.ToInteger(ClassObject9);
      ClassObject9 = (object) "";
      this.PopulateValue(ref ClassObject9, data, "Is-Mechanical-Vent-Approved-Installer-Scheme");
      string str = Conversions.ToString(ClassObject9);
      if (!string.IsNullOrEmpty(str) && str.Equals("true"))
        this.newDwelling.Ventilation.ApprovedScheme = true;
      // ISSUE: variable of a reference type
      string& local30;
      // ISSUE: explicit reference operation
      ClassObject9 = (object) ^(local30 = ref this.newDwelling.Ventilation.MVDetails.DuctProductID);
      this.PopulateValue(ref ClassObject9, data, "Mechanical-Vent-Ducts-Index-Number");
      local30 = Conversions.ToString(ClassObject9);
    }

    private void WaterHeating(XElement data)
    {
      if (data == null)
        return;
      // ISSUE: variable of a reference type
      float& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Water.Cylinder.Volume);
      this.PopulateValue(ref ClassObject1, data, "Hot-Water-Store-Size");
      local1 = Conversions.ToSingle(ClassObject1);
      // ISSUE: variable of a reference type
      int& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Water.SystemRef);
      this.PopulateValue(ref ClassObject2, data, "Water-Heating-Code");
      local2 = Conversions.ToInteger(ClassObject2);
      // ISSUE: variable of a reference type
      string& local3;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local3 = ref this.newDwelling.Water.Fuel);
      this.PopulateValue(ref ClassObject3, data, "Water-Fuel-Type");
      local3 = Conversions.ToString(ClassObject3);
      this.newDwelling.Water.Fuel = this.FuelCheck(Conversions.ToInteger(this.newDwelling.Water.Fuel));
      // ISSUE: variable of a reference type
      string& local4;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local4 = ref this.newDwelling.Water.Thermal.Type);
      this.PopulateValue(ref ClassObject4, data, "Thermal-Store");
      local4 = Conversions.ToString(ClassObject4);
      if (!string.IsNullOrEmpty(this.newDwelling.Water.Thermal.Type))
      {
        string type = this.newDwelling.Water.Thermal.Type;
        if (Operators.CompareString(type, "1", false) != 0)
        {
          if (Operators.CompareString(type, "2", false) != 0)
          {
            if (Operators.CompareString(type, "3", false) == 0)
            {
              this.newDwelling.Water.Thermal.Type = "Integrated";
              this.newDwelling.Water.Thermal.Include = true;
            }
          }
          else
          {
            this.newDwelling.Water.Thermal.Type = "Hot Water Only";
            this.newDwelling.Water.Thermal.Include = true;
          }
        }
        else
        {
          this.newDwelling.Water.Thermal.Type = "";
          this.newDwelling.Water.Thermal.Include = false;
        }
      }
      string str1 = "";
      // ISSUE: variable of a reference type
      bool& local5;
      // ISSUE: explicit reference operation
      object ClassObject5 = (object) ^(local5 = ref this.newDwelling.Water.Cylinder.SummerImmersion);
      this.PopulateValue(ref ClassObject5, data, "Is-Immersion-For-Summer-Use");
      local5 = Conversions.ToBoolean(ClassObject5);
      // ISSUE: variable of a reference type
      float& local6;
      // ISSUE: explicit reference operation
      object ClassObject6 = (object) ^(local6 = ref this.newDwelling.Water.Cylinder.HPExchanger);
      this.PopulateValue(ref ClassObject6, data, "Hot-Water-Store-Heat-Transfer-Area");
      local6 = Conversions.ToSingle(ClassObject6);
      // ISSUE: variable of a reference type
      float& local7;
      // ISSUE: explicit reference operation
      object ClassObject7 = (object) ^(local7 = ref this.newDwelling.Water.Cylinder.DeclaredLoss);
      this.PopulateValue(ref ClassObject7, data, "Hot-Water-Store-Heat-Loss");
      local7 = Conversions.ToSingle(ClassObject7);
      // ISSUE: variable of a reference type
      string& local8;
      // ISSUE: explicit reference operation
      object ClassObject8 = (object) ^(local8 = ref this.newDwelling.Water.Cylinder.Insulation);
      this.PopulateValue(ref ClassObject8, data, "Hot-Water-Store-Insulation-Type");
      local8 = Conversions.ToString(ClassObject8);
      string insulation = this.newDwelling.Water.Cylinder.Insulation;
      if (Operators.CompareString(insulation, Conversions.ToString(1), false) == 0)
        this.newDwelling.Water.Cylinder.Insulation = "Factory";
      else if (Operators.CompareString(insulation, Conversions.ToString(2), false) == 0)
        this.newDwelling.Water.Cylinder.Insulation = "Jacket";
      // ISSUE: variable of a reference type
      float& local9;
      // ISSUE: explicit reference operation
      object ClassObject9 = (object) ^(local9 = ref this.newDwelling.Water.Cylinder.InsThick);
      this.PopulateValue(ref ClassObject9, data, "Hot-Water-Store-Insulation-Thickness");
      local9 = Conversions.ToSingle(ClassObject9);
      // ISSUE: variable of a reference type
      string& local10;
      // ISSUE: explicit reference operation
      object ClassObject10 = (object) ^(local10 = ref this.newDwelling.Water.Thermal.Connection);
      this.PopulateValue(ref ClassObject10, data, "Is-Thermal-Store-Near-Boiler");
      local10 = Conversions.ToString(ClassObject10);
      this.newDwelling.Water.Thermal.Connection = Operators.CompareString(this.newDwelling.Water.Thermal.Connection, "false", false) == 0 ? "> 1.5 m of primary pipework" : "";
      this.PopulateValue(ref this.newDwelling.ReplaceMe, data, "Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard");
      if (!string.IsNullOrEmpty(Conversions.ToString(this.newDwelling.ReplaceMe)) && Conversions.ToString(this.newDwelling.ReplaceMe).Equals("true"))
      {
        this.newDwelling.Water.Thermal.Location = "In an airing cupboard";
        this.newDwelling.Water.Cylinder.InHeatedSpace = true;
      }
      // ISSUE: variable of a reference type
      string& local11;
      // ISSUE: explicit reference operation
      object ClassObject11 = (object) ^(local11 = ref this.newDwelling.AirCon);
      this.PopulateValue(ref ClassObject11, data, "Has-Fixed-Air-Conditioning");
      local11 = Conversions.ToString(ClassObject11);
      object ClassObject12 = (object) str1;
      this.PopulateValue(ref ClassObject12, data, "Immersion-Heating-Type");
      string str2 = Conversions.ToString(ClassObject12);
      if (!string.IsNullOrEmpty(str2))
      {
        if (str2.Equals("1"))
          this.newDwelling.Water.Cylinder.Immersion = "Dual";
        if (str2.Equals("2"))
          this.newDwelling.Water.Cylinder.Immersion = "Single";
      }
      // ISSUE: variable of a reference type
      string& local12;
      // ISSUE: explicit reference operation
      ClassObject12 = (object) ^(local12 = ref this.newDwelling.SecHeating.HETAS);
      this.PopulateValue(ref ClassObject12, data, "Is-Secondary-Heating-HETAS-Approved");
      local12 = Conversions.ToString(ClassObject12);
      ClassObject12 = (object) "";
      this.PopulateValue(ref ClassObject12, data, "Hot-Water-Store-Heat-Loss-Source");
      string str3 = Conversions.ToString(ClassObject12);
      if (!string.IsNullOrEmpty(str3) && str3.Equals("2"))
        this.newDwelling.Water.Cylinder.ManuSpecified = true;
      ClassObject12 = (object) "";
      this.PopulateValue(ref ClassObject12, data, "Has-Cylinder-Thermostat");
      string str4 = Conversions.ToString(ClassObject12);
      if (!string.IsNullOrEmpty(str4) && str4.Equals("true"))
        this.newDwelling.Water.Cylinder.Thermostat = true;
      ClassObject12 = (object) "";
      this.PopulateValue(ref ClassObject12, data, "Is-Cylinder-In-Heated-Space");
      string str5 = Conversions.ToString(ClassObject12);
      if (!string.IsNullOrEmpty(str5) && str5.Equals("true"))
        this.newDwelling.Water.Cylinder.InHeatedSpace = true;
      ClassObject12 = (object) "";
      this.PopulateValue(ref ClassObject12, data, "Is-Hot-Water-Separately-Timed");
      string str6 = Conversions.ToString(ClassObject12);
      if (!string.IsNullOrEmpty(str6) && str6.Equals("true"))
        this.newDwelling.Water.Cylinder.Timed = true;
      // ISSUE: variable of a reference type
      string& local13;
      // ISSUE: explicit reference operation
      ClassObject12 = (object) ^(local13 = ref this.newDwelling.Water.Cylinder.PipeWorkInsulationType);
      this.PopulateValue(ref ClassObject12, data, "Primary-Pipework-Insulation");
      local13 = Conversions.ToString(ClassObject12);
      string workInsulationType = this.newDwelling.Water.Cylinder.PipeWorkInsulationType;
      if (Operators.CompareString(workInsulationType, Conversions.ToString(1), false) == 0)
        this.newDwelling.Water.Cylinder.PipeWorkInsulationType = "not insulated";
      else if (Operators.CompareString(workInsulationType, Conversions.ToString(2), false) == 0)
      {
        this.newDwelling.Water.Cylinder.PipeWorkInsulationType = "First 1m from cylinder insulated";
        this.newDwelling.Water.Cylinder.PipeWorkInsulated = true;
      }
      else if (Operators.CompareString(workInsulationType, Conversions.ToString(3), false) == 0)
      {
        this.newDwelling.Water.Cylinder.PipeWorkInsulationType = "All accessible pipework insulated";
        this.newDwelling.Water.Cylinder.PipeWorkInsulated = true;
      }
      else if (Operators.CompareString(workInsulationType, Conversions.ToString(4), false) == 0)
      {
        this.newDwelling.Water.Cylinder.PipeWorkInsulationType = "Fully insulated primary pipework";
        this.newDwelling.Water.Cylinder.PipeWorkInsulated = true;
      }
      // ISSUE: variable of a reference type
      bool& local14;
      // ISSUE: explicit reference operation
      ClassObject12 = (object) ^(local14 = ref this.newDwelling.LessThan125Litre);
      this.PopulateValue(ref ClassObject12, data, "SAP-Heating-Design-Water-Use");
      local14 = Conversions.ToBoolean(ClassObject12);
    }

    private void InstantWWHRS(XElement data)
    {
      if (data == null)
        return;
      this.newDwelling.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Water.WWHRS.Systems[0].SystemsRef);
      this.PopulateValue(ref ClassObject1, data, "WWHRS-Index-Number1");
      local1 = Conversions.ToString(ClassObject1);
      if (!string.IsNullOrEmpty(this.newDwelling.Water.WWHRS.Systems[0].SystemsRef))
        this.newDwelling.Water.WWHRS.Include = true;
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Water.WWHRS.Systems[1].SystemsRef);
      this.PopulateValue(ref ClassObject2, data, "WWHRS-Index-Number2");
      local2 = Conversions.ToString(ClassObject2);
      // ISSUE: variable of a reference type
      float& local3;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local3 = ref this.newDwelling.Water.WWHRS.TotalRooms);
      this.PopulateValue(ref ClassObject2, data, "Rooms-With-Bath-And-Or-Shower");
      local3 = Conversions.ToSingle(ClassObject2);
      // ISSUE: variable of a reference type
      int& local4;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local4 = ref this.newDwelling.Water.WWHRS.Systems[0].WithBath);
      this.PopulateValue(ref ClassObject2, data, "Mixer-Showers-With-System1-With-Bath");
      local4 = Conversions.ToInteger(ClassObject2);
      // ISSUE: variable of a reference type
      int& local5;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local5 = ref this.newDwelling.Water.WWHRS.Systems[0].WithNoBath);
      this.PopulateValue(ref ClassObject2, data, "Mixer-Showers-With-System1-Without-Bath");
      local5 = Conversions.ToInteger(ClassObject2);
      // ISSUE: variable of a reference type
      int& local6;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local6 = ref this.newDwelling.Water.WWHRS.Systems[1].WithBath);
      this.PopulateValue(ref ClassObject2, data, "Mixer-Showers-With-System2-With-Bath");
      local6 = Conversions.ToInteger(ClassObject2);
      // ISSUE: variable of a reference type
      int& local7;
      // ISSUE: explicit reference operation
      ClassObject2 = (object) ^(local7 = ref this.newDwelling.Water.WWHRS.Systems[1].WithNoBath);
      this.PopulateValue(ref ClassObject2, data, "Mixer-Showers-With-System2-Without-Bath");
      local7 = Conversions.ToInteger(ClassObject2);
    }

    private void StorageWWHRS(XElement data)
    {
      if (data == null)
        return;
      this.newDwelling.Water.WWHRS.Systems = new SAP_Module.WWHRS_Systems[2];
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Water.WWHRS.Systems[0].SystemsRef);
      this.PopulateValue(ref ClassObject1, data, "WWHRS-Index-Number");
      local1 = Conversions.ToString(ClassObject1);
      // ISSUE: variable of a reference type
      float& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Water.WWHRS.TotalRooms);
      this.PopulateValue(ref ClassObject2, data, "Total-Showers-And-Baths");
      local2 = Conversions.ToSingle(ClassObject2);
      // ISSUE: variable of a reference type
      int& local3;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local3 = ref this.newDwelling.Water.WWHRS.Systems[0].WithBath);
      this.PopulateValue(ref ClassObject3, data, "Baths-And-Showers-To-WWHRS");
      local3 = Conversions.ToInteger(ClassObject3);
      if (!string.IsNullOrEmpty(this.newDwelling.Water.WWHRS.Systems[0].SystemsRef))
        this.newDwelling.Water.WWHRS.Include = true;
    }

    private void SolarHeatingDetails(XElement data)
    {
      if (data == null)
        return;
      this.newDwelling.Water.Solar.Inlcude = true;
      // ISSUE: variable of a reference type
      float& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Water.Solar.SolarArea);
      this.PopulateValue(ref ClassObject1, data, "Solar-Panel-Aperture-Area");
      local1 = Conversions.ToSingle(ClassObject1);
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Water.Solar.SolarType);
      this.PopulateValue(ref ClassObject2, data, "Solar-Panel-Collector-Type");
      local2 = Conversions.ToString(ClassObject2);
      this.newDwelling.Water.Solar.SolarType = this.SolarCollector(this.newDwelling.Water.Solar.SolarType);
      object ClassObject3 = (object) "";
      this.PopulateValue(ref ClassObject3, data, "Solar-Panel-Collector-Data-Source");
      this.newDwelling.Water.Solar.Overide = Conversions.ToString(ClassObject3).Equals("2");
      // ISSUE: variable of a reference type
      float& local3;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local3 = ref this.newDwelling.Water.Solar.SolarZero);
      this.PopulateValue(ref ClassObject4, data, "Solar-Panel-Collector-Zero-Loss-Efficiency");
      local3 = Conversions.ToSingle(ClassObject4);
      // ISSUE: variable of a reference type
      float& local4;
      // ISSUE: explicit reference operation
      double num = (double) ^(local4 = ref this.newDwelling.Water.Solar.SolarZero) / 100.0;
      local4 = (float) num;
      // ISSUE: variable of a reference type
      float& local5;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local5 = ref this.newDwelling.Water.Solar.SolarHLoss);
      this.PopulateValue(ref ClassObject4, data, "Solar-Panel-Collector-Linear-Heat-Loss-Coefficient");
      local5 = Conversions.ToSingle(ClassObject4);
      // ISSUE: variable of a reference type
      float& local6;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local6 = ref this.newDwelling.Water.Solar.SolarHLoss2);
      this.PopulateValue(ref ClassObject4, data, "Solar-Panel-Collector-Second-Order-Heat-Loss-Coefficient");
      local6 = Conversions.ToSingle(ClassObject4);
      if (!this.newDwelling.Water.Solar.Overide)
      {
        string solarType = this.newDwelling.Water.Solar.SolarType;
        if (Operators.CompareString(solarType, "Evacuated tube", false) != 0)
        {
          if (Operators.CompareString(solarType, "Flat plate, glazed", false) != 0)
          {
            if (Operators.CompareString(solarType, "Unglazed", false) == 0)
            {
              this.newDwelling.Water.Solar.SolarZero = 0.9f;
              this.newDwelling.Water.Solar.SolarHLoss = 20f;
            }
          }
          else
          {
            this.newDwelling.Water.Solar.SolarZero = 0.75f;
            this.newDwelling.Water.Solar.SolarHLoss = 6f;
          }
        }
        else
        {
          this.newDwelling.Water.Solar.SolarZero = 0.6f;
          this.newDwelling.Water.Solar.SolarHLoss = 3f;
        }
      }
      // ISSUE: variable of a reference type
      string& local7;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local7 = ref this.newDwelling.Water.Solar.SolarOrientation);
      this.PopulateValue(ref ClassObject4, data, "Solar-Panel-Collector-Orientation");
      local7 = Conversions.ToString(ClassObject4);
      this.newDwelling.Water.Solar.SolarOrientation = this.SolarOrientation(this.newDwelling.Water.Solar.SolarOrientation);
      // ISSUE: variable of a reference type
      string& local8;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local8 = ref this.newDwelling.Water.Solar.SolarTilt);
      this.PopulateValue(ref ClassObject4, data, "Solar-Panel-Collector-Pitch");
      local8 = Conversions.ToString(ClassObject4);
      this.newDwelling.Water.Solar.SolarTilt = this.PVPitch(this.newDwelling.Water.Solar.SolarTilt);
      // ISSUE: variable of a reference type
      string& local9;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local9 = ref this.newDwelling.Water.Solar.SolarOvershading);
      this.PopulateValue(ref ClassObject4, data, "Solar-Panel-Collector-Overshading");
      local9 = Conversions.ToString(ClassObject4);
      this.newDwelling.Water.Solar.SolarOvershading = this.SolarOvershading(this.newDwelling.Water.Solar.SolarOvershading);
      ClassObject4 = (object) "";
      this.PopulateValue(ref ClassObject4, data, "Has-Solar-Powered-Pump");
      string str = Conversions.ToString(ClassObject4);
      this.newDwelling.Water.Solar.Pumped = str.Equals("true");
      ClassObject4 = (object) str;
      this.PopulateValue(ref ClassObject4, data, "Is-Solar-Store-Combined-Cylinder");
      this.newDwelling.Water.Solar.SolarSeperate = !Conversions.ToString(ClassObject4).Equals("true");
      // ISSUE: variable of a reference type
      float& local10;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local10 = ref this.newDwelling.Water.Solar.SolarVolume);
      this.PopulateValue(ref ClassObject4, data, "Solar-Store-Volume");
      local10 = Conversions.ToSingle(ClassObject4);
      // ISSUE: variable of a reference type
      string& local11;
      // ISSUE: explicit reference operation
      ClassObject4 = (object) ^(local11 = ref this.newDwelling.Water.Solar.ShowerType);
      this.PopulateValue(ref ClassObject4, data, "Shower-Types");
      local11 = Conversions.ToString(ClassObject4);
      this.newDwelling.Water.Solar.ShowerType = this.ShowerType(this.newDwelling.Water.Solar.ShowerType);
    }

    public SAP_Module.Dwelling Convert(string XML)
    {
      this.newDwelling = new SAP_Module.Dwelling();
      XML = this.SortCountry(XML);
      XDocument xdocument = new XDocument();
      XDocument DataValue = XDocument.Parse(XML);
      this.ReportHeader(this.Get_Descendants(DataValue, "Report-Header"));
      this.PropertyDetails(this.Get_Descendants(DataValue, "SAP-Property-Details"));
      return this.newDwelling;
    }

    private string SortCountry(string xml)
    {
      string str1 = xml;
      string str2;
      if (str1 != null)
      {
        if (str1.Contains("<Energy-Performance-Certificate"))
          str1 = str1.Replace("<Energy-Performance-Certificate", "<RdSAP-Report ");
        if (str1.Contains("xmlns=\"http://www.est.org.uk/epc/estcrV1/DCLG-SAP\""))
          str1 = str1.Replace("xmlns=\"http://www.est.org.uk/epc/estcrV1/DCLG-SAP\"", "xmlns=\"http://www.epcregister.com/xsd/sap\"");
        string str3 = str1.Replace("xsi:schemaLocation=\"http://www.epcregister.com/xsd/sap https://epbr.digital.communities.gov.uk/xsd/SAP/Templates/SAP-Report.xsd\"", "xsi:schemaLocation=\"http://www.epcregister.com/xsd/sap http://www.epcregister.com/xsd/RdSAP/Templates/RdSAP-Report.xsd\"").Replace("xmlns=\"https://epbr.digital.communities.gov.uk/xsd/sap\"", "xmlns=\"http://www.epcregister.com/xsd/sap\"");
        if (str3.Contains("xsi:schemaLocation=\"http://www.est.org.uk/epc/estcrV1/DCLG-SAP http://shared.scottishepcregister-uat.org.uk/Schemas/Domestic/V16.1/Templates/SAP-Reports.xsd\""))
          str3 = str3.Replace("xsi:schemaLocation=\"http://www.est.org.uk/epc/estcrV1/DCLG-SAP http://shared.scottishepcregister-uat.org.uk/Schemas/Domestic/V16.1/Templates/SAP-Reports.xsd\"", "xsi:schemaLocation=\"http://www.epcregister.com/xsd/sap http://www.epcregister.com/xsd/RdSAP/Templates/RdSAP-Report.xsd\"");
        if (str3.Contains("xmlns:SAP=\"http://www.est.org.uk/epc/estcrV1/DCLG-SAP\""))
          str3 = str3.Replace("xmlns:SAP=\"http://www.est.org.uk/epc/estcrV1/DCLG-SAP\"", "");
        if (str3.Contains("xmlns:HIP=\"http://www.est.org.uk/epc/estcrV1/DCLG-HIP\""))
          str3 = str3.Replace("xmlns:HIP=\"http://www.est.org.uk/epc/estcrV1/DCLG-HIP\"", "");
        if (str3.Contains("xmlns=\"http://www.epbniregister.com/xsd/rdsap\""))
          str3 = str3.Replace("xmlns=\"http://www.epbniregister.com/xsd/rdsap\"", "xmlns=\"http://www.epcregister.com/xsd/sap\"");
        if (str3.Contains("xsi:schemaLocation=\"http://www.epbniregister.com/xsd/sap http://www.epbniregister.com/xsd/SAP/Templates/SAP-Report.xsd\""))
          str3 = str3.Replace("xsi:schemaLocation=\"http://www.epbniregister.com/xsd/sap http://www.epbniregister.com/xsd/SAP/Templates/SAP-Report.xsd\"", "xsi:schemaLocation=\"http://www.epcregister.com/xsd/sap http://www.epcregister.com/xsd/RdSAP/Templates/RdSAP-Report.xsd\"");
        if (str3.Contains("</Energy-Performance-Certificate>"))
          str3 = str3.Replace("</Energy-Performance-Certificate>", "</RdSAP-Report>");
        str2 = str3.Replace("xmlns=\"http://www.est.org.uk/epc/estcrV1/DCLG-HIP\"", "xmlns=\"http://www.epcregister.com/xsd/rdsap\"");
      }
      return str2;
    }

    private void ReportHeader(XElement data)
    {
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Reference);
      this.PopulateValue(ref ClassObject1, data, "RRN");
      local1 = Conversions.ToString(ClassObject1);
      // ISSUE: variable of a reference type
      DateTime& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.DateAssessment);
      this.PopulateValue(ref ClassObject2, data, "Inspection-Date");
      local2 = Conversions.ToDate(ClassObject2);
      // ISSUE: variable of a reference type
      string& local3;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local3 = ref this.newDwelling.Tenure);
      this.PopulateValue(ref ClassObject3, data, "Tenure");
      local3 = Conversions.ToString(ClassObject3);
      // ISSUE: variable of a reference type
      string& local4;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local4 = ref this.newDwelling.Transaction);
      this.PopulateValue(ref ClassObject4, data, "Transaction-Type");
      local4 = Conversions.ToString(ClassObject4);
      this.newDwelling.Transaction = this.Transaction(this.newDwelling.Transaction);
      // ISSUE: variable of a reference type
      string& local5;
      // ISSUE: explicit reference operation
      object ClassObject5 = (object) ^(local5 = ref this.newDwelling.PropertyType);
      this.PopulateValue(ref ClassObject5, data, "Property-Type");
      local5 = Conversions.ToString(ClassObject5);
      this.PropertyAddress(this.Get_Descendants(data, "Property"));
      object ClassObject6 = (object) "";
      this.PopulateValue(ref ClassObject6, data, "Region-Code");
      this.newDwelling.Location = this.RegionToLocation(Conversions.ToString(ClassObject6));
      object ClassObject7 = (object) "ENG";
      this.PopulateValue(ref ClassObject7, data, "Country-Code");
      string Left = Conversions.ToString(ClassObject7);
      if (Operators.CompareString(Left, "NIR", false) != 0)
      {
        if (Operators.CompareString(Left, "SCT", false) != 0)
        {
          if (Operators.CompareString(Left, "ENG", false) == 0)
            this.newDwelling.Address.Country = "England";
        }
        else
          this.newDwelling.Address.Country = "Scotland";
      }
      else
        this.newDwelling.Address.Country = "Northern Ireland";
      XElement descendants = this.Get_Descendants(data, "Related-Party-Disclosure");
      // ISSUE: variable of a reference type
      string& local6;
      // ISSUE: explicit reference operation
      object ClassObject8 = (object) ^(local6 = ref this.newDwelling.RPD);
      this.PopulateValue(ref ClassObject8, descendants, "Related-Party-Disclosure-Text");
      local6 = Conversions.ToString(ClassObject8);
    }

    private void PropertyAddress(XElement data)
    {
      XElement descendants = this.Get_Descendants(data, "Address");
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.Address.Line1);
      this.PopulateValue(ref ClassObject1, descendants, "Address-Line-1");
      local1 = Conversions.ToString(ClassObject1);
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.Address.Line2);
      this.PopulateValue(ref ClassObject2, descendants, "Address-Line-2");
      local2 = Conversions.ToString(ClassObject2);
      // ISSUE: variable of a reference type
      string& local3;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local3 = ref this.newDwelling.Address.Line3);
      this.PopulateValue(ref ClassObject3, descendants, "Address-Line-3");
      local3 = Conversions.ToString(ClassObject3);
      // ISSUE: variable of a reference type
      string& local4;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local4 = ref this.newDwelling.Address.City);
      this.PopulateValue(ref ClassObject4, descendants, "Post-Town");
      local4 = Conversions.ToString(ClassObject4);
      // ISSUE: variable of a reference type
      string& local5;
      // ISSUE: explicit reference operation
      object ClassObject5 = (object) ^(local5 = ref this.newDwelling.Address.PostCost);
      this.PopulateValue(ref ClassObject5, descendants, "Postcode");
      local5 = Conversions.ToString(ClassObject5);
      // ISSUE: variable of a reference type
      string& local6;
      // ISSUE: explicit reference operation
      object ClassObject6 = (object) ^(local6 = ref this.newDwelling.UPRN);
      this.PopulateValue(ref ClassObject6, data, "UPRN");
      local6 = Conversions.ToString(ClassObject6);
    }

    private void PropertyDetails(XElement data)
    {
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      object ClassObject1 = (object) ^(local1 = ref this.newDwelling.PropertyType);
      this.PopulateValue(ref ClassObject1, data, "Property-Type");
      local1 = Conversions.ToString(ClassObject1);
      this.newDwelling.PropertyType = this.PropertyType(this.newDwelling.PropertyType);
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      object ClassObject2 = (object) ^(local2 = ref this.newDwelling.BuildForm);
      this.PopulateValue(ref ClassObject2, data, "Built-Form");
      local2 = Conversions.ToString(ClassObject2);
      this.newDwelling.BuildForm = this.BuildForm(this.newDwelling.BuildForm);
      // ISSUE: variable of a reference type
      float& local3;
      // ISSUE: explicit reference operation
      object ClassObject3 = (object) ^(local3 = ref this.newDwelling.LivingArea);
      this.PopulateValue(ref ClassObject3, data, "Living-Area");
      local3 = Conversions.ToSingle(ClassObject3);
      // ISSUE: variable of a reference type
      string& local4;
      // ISSUE: explicit reference operation
      object ClassObject4 = (object) ^(local4 = ref this.newDwelling.Orientation);
      this.PopulateValue(ref ClassObject4, data, "Orientation");
      local4 = Conversions.ToString(ClassObject4);
      this.newDwelling.Orientation = this.PVOrientation(this.newDwelling.Orientation);
      // ISSUE: variable of a reference type
      string& local5;
      // ISSUE: explicit reference operation
      object ClassObject5 = (object) ^(local5 = ref this.newDwelling.Conservatory);
      this.PopulateValue(ref ClassObject5, data, "Conservatory-Type");
      local5 = Conversions.ToString(ClassObject5);
      this.newDwelling.Conservatory = this.Conservatory(this.newDwelling.Conservatory);
      // ISSUE: variable of a reference type
      string& local6;
      // ISSUE: explicit reference operation
      object ClassObject6 = (object) ^(local6 = ref this.newDwelling.SmokeArea);
      this.PopulateValue(ref ClassObject6, data, "Is-In-Smoke-Control-Area");
      local6 = Conversions.ToString(ClassObject6);
      try
      {
        this.Heating(this.Get_Descendants(data, "SAP-Heating"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.EnergySource(this.Get_Descendants(data, "SAP-Energy-Source"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.BuildingParts(this.Get_Descendants(data, "SAP-Building-Parts"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.OpeningTypes(this.Get_Descendants(data, "SAP-Opening-Types"));
      this.Ventilation(this.Get_Descendants(data, "SAP-Ventilation"));
      this.DeselectedImprovements(this.Get_Descendants(data, "SAP-Deselected-Improvements"));
      try
      {
        this.FlatDetails(this.Get_Descendants(data, "SAP-Flat-Details"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.SpecialFeatures(this.Get_Descendants(data, "SAP-Special-Features"));
      object ClassObject7 = (object) "";
      this.PopulateValue(ref ClassObject7, data, "Design-Water-Use");
      string str = Conversions.ToString(ClassObject7);
      if (!string.IsNullOrEmpty(str) && str.Equals("1"))
        this.newDwelling.LessThan125Litre = true;
      this.Cooling(this.Get_Descendants(data, "SAP-Cooling"));
      if (this.newDwelling.Doors != null)
        this.newDwelling.NoofDoors = this.newDwelling.Doors.Length;
      if (this.newDwelling.Windows != null)
        this.newDwelling.NoofWindows = this.newDwelling.Windows.Length;
      if (this.newDwelling.Floors != null)
        this.newDwelling.NoofFloors = this.newDwelling.Floors.Length;
      if (this.newDwelling.ICeilings != null)
        this.newDwelling.NoofICeilings = this.newDwelling.ICeilings.Length;
      if (this.newDwelling.IFloors != null)
        this.newDwelling.NoofIFloors = this.newDwelling.IFloors.Length;
      if (this.newDwelling.IWalls != null)
        this.newDwelling.NoofIWalls = this.newDwelling.IWalls.Length;
      if (this.newDwelling.PCeilings != null)
        this.newDwelling.NoofPCeilings = this.newDwelling.PCeilings.Length;
      if (this.newDwelling.PFloors != null)
        this.newDwelling.NoofpFloors = this.newDwelling.PFloors.Length;
      if (this.newDwelling.PWalls != null)
        this.newDwelling.NoofPWalls = this.newDwelling.PWalls.Length;
      if (this.newDwelling.RoofLights != null)
        this.newDwelling.NoofRoofLights = this.newDwelling.RoofLights.Length;
      if (this.newDwelling.Roofs != null)
        this.newDwelling.NoofRoofs = this.newDwelling.Roofs.Length;
      if (this.newDwelling.Walls == null)
        return;
      this.newDwelling.NoofWalls = this.newDwelling.Walls.Length;
    }
  }
}
