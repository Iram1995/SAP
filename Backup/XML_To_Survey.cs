
// Type: SAP2012.XML_To_Survey




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.RdSAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SAP2012
{
  public class XML_To_Survey
  {
    private Survey_Class Survey;
    private XNamespace HIP;
    private XNamespace SAP;
    private XNamespace XMLNS;

    public XML_To_Survey()
    {
      this.HIP = (XNamespace) "DCLG-HIP";
      this.SAP = (XNamespace) "DCLG-SAP";
      this.XMLNS = (XNamespace) "http://www.est.org.uk/epc/estcrV1/DCLG-HIP";
    }

    public Survey_Class New_SurveyClass()
    {
      Survey_Class surveyClass = new Survey_Class();
      if (surveyClass.Addendums == null)
        surveyClass.Addendums = new Survey_Class.Addendums_Class();
      if (surveyClass.Addendums.AddendumList == null)
        surveyClass.Addendums.AddendumList = new int[0];
      if (surveyClass.Extensions == null)
      {
        surveyClass.Extensions = new Extension_Class[5];
        int index = 0;
        do
        {
          surveyClass.Extensions[index] = new Extension_Class();
          surveyClass.Extensions[index].RoofRoom_FlatCeiling = new Extension_Class.Roof_Area[3];
          surveyClass.Extensions[index].RoofRoom_FlatCeiling[0] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_FlatCeiling[1] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_GableWall = new Extension_Class.Roof_Area[3];
          surveyClass.Extensions[index].RoofRoom_GableWall[0] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_GableWall[1] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_Slope = new Extension_Class.Roof_Area[3];
          surveyClass.Extensions[index].RoofRoom_Slope[0] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_Slope[1] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_StudWall = new Extension_Class.Roof_Area[3];
          surveyClass.Extensions[index].RoofRoom_StudWall[0] = new Extension_Class.Roof_Area();
          surveyClass.Extensions[index].RoofRoom_StudWall[1] = new Extension_Class.Roof_Area();
          checked { ++index; }
        }
        while (index <= 4);
      }
      if (surveyClass.Extensions[0].Storey == null)
      {
        int index1 = 0;
        do
        {
          surveyClass.Extensions[index1].Storey = new Extension_Class.Storey_Details[7];
          int index2 = 0;
          do
          {
            surveyClass.Extensions[index1].Storey[index2] = new Extension_Class.Storey_Details();
            checked { ++index2; }
          }
          while (index2 <= 6);
          checked { ++index1; }
        }
        while (index1 <= 4);
      }
      if (surveyClass.General == null)
        surveyClass.General = new Survey_Class.General_Class();
      if (surveyClass.Age == null)
        surveyClass.Age = new Survey_Class.Age_Class();
      if (surveyClass.WaterHeating == null)
        surveyClass.WaterHeating = new Survey_Class.WaterHeating_Class();
      if (surveyClass.WaterHeating.WWHRS == null)
        surveyClass.WaterHeating.WWHRS = new Survey_Class.WaterHeating_Class.WWHRS_Class();
      if (surveyClass.Conservatory == null)
        surveyClass.Conservatory = new Survey_Class.Conservatory_Class();
      if (surveyClass.Openings == null)
      {
        surveyClass.Openings = new Survey_Class.Windows_Class();
        surveyClass.Openings.ExtendedWindows = new Survey_Class.ExtendedWindows[0];
      }
      if (surveyClass.Flat_Maisonette == null)
        surveyClass.Flat_Maisonette = new Survey_Class.Flat_Class();
      if (surveyClass.OtherDetails == null)
        surveyClass.OtherDetails = new Survey_Class.OtherDetails_Class();
      if (surveyClass.MainHeating == null)
      {
        surveyClass.MainHeating = new Heating_Class[2];
        surveyClass.MainHeating[0] = new Heating_Class();
        surveyClass.MainHeating[0].MainHeating = true;
        surveyClass.MainHeating[1] = new Heating_Class();
      }
      if (surveyClass.SecondaryHeating == null)
        surveyClass.SecondaryHeating = new Survey_Class.SecondaryHeating_Class();
      if (surveyClass.Info == null)
        surveyClass.Info = new Survey_Class.Info_Class();
      if (surveyClass.Info.Assessor == null)
        surveyClass.Info.Assessor = new Survey_Class.AssessorDetails();
      if (surveyClass.Renewable == null)
      {
        surveyClass.Renewable = new Survey_Class.Renewable_Class();
        surveyClass.Renewable.PVArray = new Survey_Class.Renewable_Class.PVArray_Class[3];
        surveyClass.Renewable.PVArray[0] = new Survey_Class.Renewable_Class.PVArray_Class();
        surveyClass.Renewable.PVArray[1] = new Survey_Class.Renewable_Class.PVArray_Class();
        surveyClass.Renewable.PVArray[2] = new Survey_Class.Renewable_Class.PVArray_Class();
      }
      if (surveyClass.WaterHeating.WWHRS.System == null)
      {
        surveyClass.WaterHeating.WWHRS.System = new Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class[2];
        surveyClass.WaterHeating.WWHRS.System[0] = new Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class();
        surveyClass.WaterHeating.WWHRS.System[1] = new Survey_Class.WaterHeating_Class.WWHRS_Class.System_Class();
      }
      if (surveyClass.WaterHeating.SolarWater == null)
        surveyClass.WaterHeating.SolarWater = new Survey_Class.WaterHeating_Class.SolarWater_Class();
      return surveyClass;
    }

    public Survey_Class Convert(string XML)
    {
      this.Survey = this.New_SurveyClass();
      XDocument xdocument1 = new XDocument();
      XDocument xdocument2 = XDocument.Parse(XML);
      if (xdocument2.Root.GetNamespaceOfPrefix("SAP") != null)
        this.SAP = xdocument2.Root.GetNamespaceOfPrefix("SAP");
      if (xdocument2.Root.GetNamespaceOfPrefix("HIP") != null)
        this.HIP = xdocument2.Root.GetNamespaceOfPrefix("HIP");
      IEnumerable<XElement> source1 = xdocument2.Descendants(this.SAP + "Report-Header");
      Func<XElement, XElement> selector1;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector1 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D0 = selector1 = (Func<XElement, XElement>) (b => b);
      }
      this.Add_Other(source1.Select<XElement, XElement>(selector1).FirstOrDefault<XElement>());
      IEnumerable<XElement> source2 = xdocument2.Descendants(this.HIP + "SAP-Property-Details");
      Func<XElement, XElement> selector2;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector2 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D1 = selector2 = (Func<XElement, XElement>) (b => b);
      }
      this.Add_General(source2.Select<XElement, XElement>(selector2).FirstOrDefault<XElement>());
      IEnumerable<XElement> source3 = xdocument2.Descendants(this.HIP + "UPRN");
      Func<XElement, XElement> selector3;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector3 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D2 = selector3 = (Func<XElement, XElement>) (b => b);
      }
      XElement xelement = source3.Select<XElement, XElement>(selector3).FirstOrDefault<XElement>();
      if (xelement == null)
      {
        IEnumerable<XElement> source4 = xdocument2.Descendants(this.XMLNS + "UPRN");
        Func<XElement, XElement> selector4;
        // ISSUE: reference to a compiler-generated field
        if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector4 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_To_Survey._Closure\u0024__.\u0024I6\u002D3 = selector4 = (Func<XElement, XElement>) (b => b);
        }
        xelement = source4.Select<XElement, XElement>(selector4).FirstOrDefault<XElement>();
      }
      this.Survey.General.UPRN = xelement.Value;
      IEnumerable<XElement> source5 = xdocument2.Descendants(this.HIP + "SAP-Building-Part");
      Func<XElement, XElement> selector5;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D4 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector5 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D4;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D4 = selector5 = (Func<XElement, XElement>) (b => b);
      }
      List<XElement> list1 = source5.Select<XElement, XElement>(selector5).ToList<XElement>();
      try
      {
        foreach (XElement Details in list1)
          this.Add_Extension(Details);
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      IEnumerable<XElement> source6 = xdocument2.Descendants(this.HIP + "SAP-Integral-Conservatory");
      Func<XElement, XElement> selector6;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D5 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector6 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D5;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D5 = selector6 = (Func<XElement, XElement>) (b => b);
      }
      XElement Details1 = source6.Select<XElement, XElement>(selector6).FirstOrDefault<XElement>();
      if (Details1 != null)
        this.Add_Conservatory(Details1);
      IEnumerable<XElement> source7 = xdocument2.Descendants(this.HIP + "SAP-Flat-Details");
      Func<XElement, XElement> selector7;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D6 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector7 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D6;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D6 = selector7 = (Func<XElement, XElement>) (b => b);
      }
      XElement Details2 = source7.Select<XElement, XElement>(selector7).FirstOrDefault<XElement>();
      if (Details2 != null)
        this.Add_Flat(Details2);
      IEnumerable<XElement> source8 = xdocument2.Descendants(this.HIP + "Addendum");
      Func<XElement, XElement> selector8;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D7 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector8 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D7;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D7 = selector8 = (Func<XElement, XElement>) (b => b);
      }
      XElement Details3 = source8.Select<XElement, XElement>(selector8).FirstOrDefault<XElement>();
      if (Details3 != null)
        this.Add_Addendums(Details3);
      IEnumerable<XElement> source9 = xdocument2.Descendants(this.HIP + "Main-Heating-Details");
      Func<XElement, XElement> selector9;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D8 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector9 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D8;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D8 = selector9 = (Func<XElement, XElement>) (b => b);
      }
      IEnumerable<XElement> source10 = source9.Select<XElement, XElement>(selector9).FirstOrDefault<XElement>().Descendants(this.HIP + "Main-Heating");
      Func<XElement, XElement> selector10;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D9 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector10 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D9;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D9 = selector10 = (Func<XElement, XElement>) (b => b);
      }
      List<XElement> list2 = source10.Select<XElement, XElement>(selector10).ToList<XElement>();
      try
      {
        foreach (XElement Details4 in list2)
          this.Add_MainHeating(Details4);
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      IEnumerable<XElement> source11 = xdocument2.Descendants(this.HIP + "SAP-Heating");
      Func<XElement, XElement> selector11;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D10 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector11 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D10;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D10 = selector11 = (Func<XElement, XElement>) (b => b);
      }
      this.Add_Water(source11.Select<XElement, XElement>(selector11).FirstOrDefault<XElement>());
      IEnumerable<XElement> source12 = xdocument2.Descendants(this.HIP + "WWHRS");
      Func<XElement, XElement> selector12;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D11 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector12 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D11;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D11 = selector12 = (Func<XElement, XElement>) (b => b);
      }
      this.Add_WWHRS(source12.Select<XElement, XElement>(selector12).FirstOrDefault<XElement>());
      IEnumerable<XElement> source13 = xdocument2.Descendants(this.HIP + "Solar-Water-Heating-Details");
      Func<XElement, XElement> selector13;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D12 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector13 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D12;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D12 = selector13 = (Func<XElement, XElement>) (b => b);
      }
      XElement Details5 = source13.Select<XElement, XElement>(selector13).FirstOrDefault<XElement>();
      if (Details5 != null)
        this.Add_SolarWater(Details5);
      IEnumerable<XElement> source14 = xdocument2.Descendants(this.HIP + "Photovoltaic-Supply");
      Func<XElement, XElement> selector14;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D13 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector14 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D13;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D13 = selector14 = (Func<XElement, XElement>) (b => b);
      }
      XElement Details6 = source14.Select<XElement, XElement>(selector14).FirstOrDefault<XElement>();
      if (Details6 != null)
        this.Add_PV(Details6);
      IEnumerable<XElement> source15 = xdocument2.Descendants(this.HIP + "SAP-Energy-Source");
      Func<XElement, XElement> selector15;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D14 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector15 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D14;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D14 = selector15 = (Func<XElement, XElement>) (b => b);
      }
      this.Add_Turbines(source15.Select<XElement, XElement>(selector15).FirstOrDefault<XElement>());
      IEnumerable<XElement> source16 = xdocument2.Descendants(this.HIP + "SAP-Window");
      Func<XElement, XElement> selector16;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I6\u002D15 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector16 = XML_To_Survey._Closure\u0024__.\u0024I6\u002D15;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I6\u002D15 = selector16 = (Func<XElement, XElement>) (b => b);
      }
      this.Add_Windows(source16.Select<XElement, XElement>(selector16).ToList<XElement>());
      return this.Survey;
    }

    private void Add_Other(XElement Details)
    {
      if (Details == null)
        return;
      IEnumerable<XElement> source = Details.Descendants(this.SAP + "Related-Party-Disclosure");
      Func<XElement, XElement> selector;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I7\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = XML_To_Survey._Closure\u0024__.\u0024I7\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I7\u002D0 = selector = (Func<XElement, XElement>) (b => b);
      }
      source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>();
      XNamespace xnamespace = this.SAP;
      if (Details.Element(this.SAP + "Region-Code") == null)
        xnamespace = this.HIP;
      if (Details.Element(xnamespace + "Region-Code") == null)
      {
        this.HIP = this.XMLNS;
        xnamespace = this.HIP;
      }
      string str = Details.Element(xnamespace + "Region-Code").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 334175660:
          if (Operators.CompareString(str, "18", false) == 0)
          {
            this.Survey.General.Region = "Wales";
            break;
          }
          break;
        case 350953279:
          if (Operators.CompareString(str, "19", false) == 0)
          {
            this.Survey.General.Region = "West Pennines";
            break;
          }
          break;
        case 401286136:
          if (Operators.CompareString(str, "14", false) == 0)
          {
            this.Survey.General.Region = "South East England";
            break;
          }
          break;
        case 418063755:
          if (Operators.CompareString(str, "15", false) == 0)
          {
            this.Survey.General.Region = "South West England";
            break;
          }
          break;
        case 434841374:
          if (Operators.CompareString(str, "16", false) == 0)
          {
            this.Survey.General.Region = "South England";
            break;
          }
          break;
        case 451618993:
          if (Operators.CompareString(str, "17", false) == 0)
          {
            this.Survey.General.Region = "Thames valley";
            break;
          }
          break;
        case 468396612:
          if (Operators.CompareString(str, "10", false) == 0)
          {
            this.Survey.General.Region = "Northern Ireland";
            break;
          }
          break;
        case 485174231:
          if (Operators.CompareString(str, "11", false) == 0)
          {
            this.Survey.General.Region = "Orkney";
            break;
          }
          break;
        case 501951850:
          if (Operators.CompareString(str, "12", false) == 0)
          {
            this.Survey.General.Region = "Severn valley";
            break;
          }
          break;
        case 518729469:
          if (Operators.CompareString(str, "13", false) == 0)
          {
            this.Survey.General.Region = "Shetland";
            break;
          }
          break;
        case 806133968:
          if (Operators.CompareString(str, "5", false) == 0)
          {
            this.Survey.General.Region = "Highland";
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str, "4", false) == 0)
          {
            this.Survey.General.Region = "East Scotland";
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str, "7", false) == 0)
          {
            this.Survey.General.Region = "North East England";
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str, "6", false) == 0)
          {
            this.Survey.General.Region = "Midlands";
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str, "1", false) == 0)
          {
            this.Survey.General.Region = "Borders";
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str, "3", false) == 0)
          {
            this.Survey.General.Region = "East Pennines";
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str, "2", false) == 0)
          {
            this.Survey.General.Region = "East Anglia";
            break;
          }
          break;
        case 1007465396:
          if (Operators.CompareString(str, "9", false) == 0)
          {
            this.Survey.General.Region = "North West England";
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str, "8", false) == 0)
          {
            this.Survey.General.Region = "North East Scotland";
            break;
          }
          break;
        case 2314375987:
          if (Operators.CompareString(str, "24", false) == 0)
          {
            this.Survey.General.Region = "Isle of Man";
            break;
          }
          break;
        case 2364708844:
          if (Operators.CompareString(str, "21", false) == 0)
          {
            this.Survey.General.Region = "Western Isles";
            break;
          }
          break;
        case 2381486463:
          if (Operators.CompareString(str, "20", false) == 0)
          {
            this.Survey.General.Region = "West Scotland";
            break;
          }
          break;
        case 2398264082:
          if (Operators.CompareString(str, "23", false) == 0)
          {
            this.Survey.General.Region = "Guernsey";
            break;
          }
          break;
        case 2415041701:
          if (Operators.CompareString(str, "22", false) == 0)
          {
            this.Survey.General.Region = "Jersey";
            break;
          }
          break;
      }
      string Left = Details.Element(xnamespace + "Country-Code").Value;
      if (Operators.CompareString(Left, "NIR", false) != 0)
      {
        if (Operators.CompareString(Left, "SCT", false) != 0)
        {
          if (Operators.CompareString(Left, "EAW", false) == 0)
          {
            this.Survey.General.Country = 1;
            this.Survey.Info.CountryCode = 1;
          }
        }
        else
        {
          this.Survey.General.Country = 3;
          this.Survey.Info.CountryCode = 3;
        }
      }
      else
      {
        this.Survey.General.Country = 4;
        this.Survey.Info.CountryCode = 4;
      }
      this.Survey.General.RRN = Details.Element(xnamespace + "RRN").Value;
      this.Survey.General.EPCLanguage = Conversions.ToInteger(Details.Element(xnamespace + "Language-Code").Value);
    }

    private void Add_General(XElement Details)
    {
      if (Details == null)
        return;
      string Left1 = Details.Element(this.HIP + "Property-Type").Value;
      if (Operators.CompareString(Left1, "0", false) != 0)
      {
        if (Operators.CompareString(Left1, "1", false) != 0)
        {
          if (Operators.CompareString(Left1, "2", false) != 0)
          {
            if (Operators.CompareString(Left1, "3", false) == 0)
              this.Survey.General.PropertyType1 = 4;
          }
          else
            this.Survey.General.PropertyType1 = 3;
        }
        else
          this.Survey.General.PropertyType1 = 2;
      }
      else
        this.Survey.General.PropertyType1 = 1;
      this.Survey.General.PropertyType2 = Conversions.ToInteger(Details.Element(this.HIP + "Built-Form").Value);
      this.Survey.Age.NumberOfExtension = Conversions.ToInteger(Details.Element(this.HIP + "Extensions-Count").Value);
      if (Details.Element(this.HIP + "Multiple-Glazed-Proportion") != null)
        this.Survey.Openings.MultipleGlazedProportion = Conversions.ToDouble(Details.Element(this.HIP + "Multiple-Glazed-Proportion").Value);
      if (Operators.CompareString(Details.Element(this.HIP + "Multiple-Glazing-Type").Value, "ND", false) == 0)
        this.Survey.Openings.WindowMultipleGlazedType = 5;
      else
        this.Survey.Openings.WindowMultipleGlazedType = Conversions.ToInteger(Details.Element(this.HIP + "Multiple-Glazing-Type").Value);
      this.Survey.Openings.GlazedArea = Conversions.ToInteger(Details.Element(this.HIP + "Glazed-Area").Value);
      if (Details.Element(this.HIP + "Door-Count") != null)
        this.Survey.Openings.DoorCount = Conversions.ToInteger(Details.Element(this.HIP + "Door-Count").Value);
      if (Details.Element(this.HIP + "Insulated-Door-Count") != null)
        this.Survey.Openings.InsulatedDoorCount = Conversions.ToInteger(Details.Element(this.HIP + "Insulated-Door-Count").Value);
      if (Details.Element(this.HIP + "Insulated-Door-U-Value") != null)
        this.Survey.Openings.InsulatedUValue = Conversions.ToDouble(Details.Element(this.HIP + "Insulated-Door-U-Value").Value);
      if (Details.Element(this.HIP + "Windows-U-Value") != null)
        this.Survey.Openings.WindowsUValue = Conversions.ToDouble(Details.Element(this.HIP + "Windows-U-Value").Value);
      if (Details.Element(this.HIP + "Solar-Transmittance") != null)
        this.Survey.Openings.WindowSolarTransmittance = Conversions.ToDouble(Details.Element(this.HIP + "Solar-Transmittance").Value);
      if (Details.Element(this.HIP + "Windows-Data-Source") != null)
      {
        if (Operators.CompareString(Details.Element(this.HIP + "Windows-Data-Source").Value, "4", false) == 0)
          this.Survey.Openings.WindowDataSource = 2;
        else
          this.Survey.Openings.WindowDataSource = 1;
      }
      this.Survey.Openings.PercentDraughtProofed = Conversions.ToDouble(Details.Element(this.HIP + "Percent-Draughtproofed").Value);
      this.Survey.Age.MHabRooms = Conversions.ToInteger(Details.Element(this.HIP + "Habitable-Room-Count").Value);
      this.Survey.Age.MHeatHabRooms = Conversions.ToInteger(Details.Element(this.HIP + "Heated-Room-Count").Value);
      this.Survey.Renewable.FixedLightingOutletsCount = Conversions.ToDouble(Details.Element(this.HIP + "Fixed-Lighting-Outlets-Count").Value);
      this.Survey.Renewable.LowEnergyFixedLightingOutlets = Conversions.ToDouble(Details.Element(this.HIP + "Low-Energy-Fixed-Lighting-Outlets-Count").Value);
      this.Survey.Renewable.LowEnergylightsPercent = Conversions.ToDouble(Details.Element(this.HIP + "Low-Energy-Lighting").Value);
      this.Survey.Age.DimType = Operators.CompareString(Details.Element(this.HIP + "Measurement-Type").Value, "2", false) == 0 ? 1 : 2;
      string Left2 = Details.Element(this.HIP + "Mechanical-Ventilation").Value;
      if (Operators.CompareString(Left2, "1", false) != 0)
      {
        if (Operators.CompareString(Left2, "2", false) == 0)
        {
          this.Survey.OtherDetails.VentType = 1;
          this.Survey.OtherDetails.MechanicalVentilation = true;
        }
      }
      else
      {
        this.Survey.OtherDetails.VentType = 2;
        this.Survey.OtherDetails.MechanicalVentilation = true;
      }
      this.Survey.General.FirePlacesCount = Conversions.ToInteger(Details.Element(this.HIP + "Open-Fireplaces-Count").Value);
      if (Operators.CompareString(Details.Element(this.HIP + "Solar-Water-Heating").Value, "Y", false) == 0)
        this.Survey.WaterHeating.SolarWater.Present = true;
      this.Survey.Conservatory.ConservatoryType = Conversions.ToInteger(Details.Element(this.HIP + "Conservatory-Type").Value);
    }

    private void Add_Extension(XElement Details)
    {
      int Ext_No = checked ((int) Math.Round(unchecked (Conversions.ToDouble(Details.Element(this.HIP + "Building-Part-Number").Value) - 1.0)));
      string str1 = Details.Element(this.HIP + "Construction-Age-Band").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 3222007936:
          if (Operators.CompareString(str1, "E", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 5;
            break;
          }
          break;
        case 3238785555:
          if (Operators.CompareString(str1, "D", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 4;
            break;
          }
          break;
        case 3255563174:
          if (Operators.CompareString(str1, "G", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 7;
            break;
          }
          break;
        case 3272340793:
          if (Operators.CompareString(str1, "F", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 6;
            break;
          }
          break;
        case 3289118412:
          if (Operators.CompareString(str1, "A", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 1;
            break;
          }
          break;
        case 3322673650:
          if (Operators.CompareString(str1, "C", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 3;
            break;
          }
          break;
        case 3339451269:
          if (Operators.CompareString(str1, "B", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 2;
            break;
          }
          break;
        case 3423339364:
          if (Operators.CompareString(str1, "I", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 9;
            break;
          }
          break;
        case 3440116983:
          if (Operators.CompareString(str1, "H", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 8;
            break;
          }
          break;
        case 3456894602:
          if (Operators.CompareString(str1, "K", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 11;
            break;
          }
          break;
        case 3473672221:
          if (Operators.CompareString(str1, "J", false) == 0)
          {
            this.Survey.Extensions[Ext_No].PropAge = 10;
            break;
          }
          break;
      }
      this.Survey.Extensions[Ext_No].WallThicknessMeasured = Operators.CompareString(Details.Element(this.HIP + "Wall-Thickness-Measured").Value, "Y", false) == 0;
      if (Details.Element(this.HIP + "Wall-Thickness") != null)
        this.Survey.Extensions[Ext_No].WallThickness = Conversions.ToDouble(Details.Element(this.HIP + "Wall-Thickness").Value);
      this.Survey.Extensions[Ext_No].DryLining = Operators.CompareString(Details.Element(this.HIP + "Wall-Dry-Lined").Value, "Y", false) == 0;
      string str2 = Details.Element(this.HIP + "Wall-Construction").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 5;
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 4;
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 1;
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 3;
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 2;
            break;
          }
          break;
        case 1007465396:
          if (Operators.CompareString(str2, "9", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 7;
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str2, "8", false) == 0)
          {
            this.Survey.Extensions[Ext_No].WallConstruction = 6;
            break;
          }
          break;
      }
      this.Survey.Extensions[Ext_No].WallInsulation = Conversions.ToInteger(Details.Element(this.HIP + "Wall-Insulation-Type").Value);
      if (Details.Element(this.HIP + "Wall-Insulation-Thickness") != null)
      {
        string Left = Details.Element(this.HIP + "Wall-Insulation-Thickness").Value;
        if (Operators.CompareString(Left, "100mm", false) != 0)
        {
          if (Operators.CompareString(Left, "150mm", false) != 0)
          {
            if (Operators.CompareString(Left, "50mm", false) != 0)
            {
              if (Operators.CompareString(Left, "NI", false) == 0)
                this.Survey.Extensions[Ext_No].WallInsulationThickness = 1;
            }
            else
              this.Survey.Extensions[Ext_No].WallInsulationThickness = 2;
          }
          else
            this.Survey.Extensions[Ext_No].WallInsulationThickness = 4;
        }
        else
          this.Survey.Extensions[Ext_No].WallInsulationThickness = 3;
      }
      if (Details.Element(this.HIP + "Wall-U-Value") != null)
      {
        this.Survey.Extensions[Ext_No].WallUValue = Conversions.ToDouble(Details.Element(this.HIP + "Wall-U-Value").Value);
        this.Survey.Extensions[Ext_No].WallUValueKnown = true;
      }
      string str3 = Details.Element(this.HIP + "Roof-Construction").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str3))
      {
        case 806133968:
          if (Operators.CompareString(str3, "5", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 5;
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str3, "4", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 4;
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str3, "7", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 7;
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str3, "6", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 6;
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str3, "1", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 2;
            break;
          }
          break;
        case 890022063:
          if (Operators.CompareString(str3, "0", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 1;
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str3, "3", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofConstruction = 3;
            break;
          }
          break;
      }
      string Left1 = Details.Element(this.HIP + "Roof-Insulation-Location").Value;
      if (Operators.CompareString(Left1, "ND", false) != 0)
      {
        if (Operators.CompareString(Left1, "1", false) != 0)
        {
          if (Operators.CompareString(Left1, "2", false) != 0)
          {
            if (Operators.CompareString(Left1, "4", false) != 0)
            {
              if (Operators.CompareString(Left1, "5", false) != 0)
              {
                if (Operators.CompareString(Left1, "6", false) == 0)
                  this.Survey.Extensions[Ext_No].RoofInsulation = 5;
              }
              else
                this.Survey.Extensions[Ext_No].RoofInsulation = 1;
            }
            else
              this.Survey.Extensions[Ext_No].RoofInsulation = 2;
          }
          else
            this.Survey.Extensions[Ext_No].RoofInsulation = 4;
        }
        else
          this.Survey.Extensions[Ext_No].RoofInsulation = 3;
      }
      else
        this.Survey.Extensions[Ext_No].RoofInsulation = 1;
      string str4 = Details.Element(this.HIP + "Roof-Insulation-Thickness").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str4))
      {
        case 536439224:
          if (Operators.CompareString(str4, "12mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 3;
            break;
          }
          goto default;
        case 580823818:
          if (Operators.CompareString(str4, "100mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 7;
            break;
          }
          goto default;
        case 890022063:
          if (Operators.CompareString(str4, "0", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 1;
            break;
          }
          goto default;
        case 1004962376:
          if (Operators.CompareString(str4, "NI", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 2;
            break;
          }
          goto default;
        case 1331213009:
          if (Operators.CompareString(str4, "300mm+", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 11;
            break;
          }
          goto default;
        case 1902927683:
          if (Operators.CompareString(str4, "75mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 6;
            break;
          }
          goto default;
        case 2039723566:
          if (Operators.CompareString(str4, "25mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 4;
            break;
          }
          goto default;
        case 2195684654:
          if (Operators.CompareString(str4, "50mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 5;
            break;
          }
          goto default;
        case 3014084414:
          if (Operators.CompareString(str4, "250mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 10;
            break;
          }
          goto default;
        case 3570421319:
          if (Operators.CompareString(str4, "200mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 9;
            break;
          }
          goto default;
        case 4000619179:
          if (Operators.CompareString(str4, "150mm", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 8;
            break;
          }
          goto default;
        default:
          this.Survey.Extensions[Ext_No].RoofInsulationThickness = 12;
          break;
      }
      if (Details.Element(this.HIP + "Flat-Roof-Insulation-Thickness") != null)
      {
        string Left2 = Details.Element(this.HIP + "Flat-Roof-Insulation-Thickness").Value;
        if (Operators.CompareString(Left2, "100mm", false) != 0)
        {
          if (Operators.CompareString(Left2, "150mm", false) != 0)
          {
            if (Operators.CompareString(Left2, "50mm", false) == 0)
              this.Survey.Extensions[Ext_No].RoofInsulationThickness = 5;
          }
          else
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 8;
        }
        else
          this.Survey.Extensions[Ext_No].RoofInsulationThickness = 7;
      }
      if (Details.Element(this.HIP + "Roof-U-Value") != null)
      {
        this.Survey.Extensions[Ext_No].RoofUValue = Conversions.ToDouble(Details.Element(this.HIP + "Roof-U-Value").Value);
        this.Survey.Extensions[Ext_No].RoofUValueKnown = true;
      }
      if (Details.Element(this.HIP + "Rafter-Insulation-Thickness") != null)
      {
        string Left3 = Details.Element(this.HIP + "Rafter-Insulation-Thickness").Value;
        if (Operators.CompareString(Left3, "100mm", false) != 0)
        {
          if (Operators.CompareString(Left3, "150mm", false) != 0)
          {
            if (Operators.CompareString(Left3, "50mm", false) != 0)
            {
              if (Operators.CompareString(Left3, "NI", false) == 0)
                this.Survey.Extensions[Ext_No].RoofInsulationThickness = 2;
            }
            else
              this.Survey.Extensions[Ext_No].RoofInsulationThickness = 5;
          }
          else
            this.Survey.Extensions[Ext_No].RoofInsulationThickness = 8;
        }
        else
          this.Survey.Extensions[Ext_No].RoofInsulationThickness = 7;
      }
      string str5 = Details.Element(this.HIP + "Floor-Heat-Loss").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str5))
      {
        case 839689206:
          if (Operators.CompareString(str5, "7", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 5;
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str5, "6", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 4;
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str5, "1", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 1;
            break;
          }
          break;
        case 890022063:
          if (Operators.CompareString(str5, "0", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 4;
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str5, "3", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 3;
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str5, "2", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 2;
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str5, "8", false) == 0)
          {
            this.Survey.Extensions[Ext_No].LowestFloor = 6;
            break;
          }
          break;
      }
      if (Details.Element(this.HIP + "Floor-U-Value") != null)
      {
        this.Survey.Extensions[Ext_No].FloorUValueKnown = true;
        this.Survey.Extensions[Ext_No].FloorUValue = Conversions.ToDouble(Details.Element(this.HIP + "Floor-U-Value").Value);
      }
      if (Details.Element(this.HIP + "Floor-Insulation-Thickness") != null)
      {
        string Left4 = Details.Element(this.HIP + "Floor-Insulation-Thickness").Value;
        if (Operators.CompareString(Left4, "100mm", false) != 0)
        {
          if (Operators.CompareString(Left4, "150mm", false) != 0)
          {
            if (Operators.CompareString(Left4, "50mm", false) != 0)
            {
              if (Operators.CompareString(Left4, "NI", false) == 0)
                this.Survey.Extensions[Ext_No].FloorInsulationThickness = 1;
            }
            else
              this.Survey.Extensions[Ext_No].FloorInsulationThickness = 2;
          }
          else
            this.Survey.Extensions[Ext_No].FloorInsulationThickness = 4;
        }
        else
          this.Survey.Extensions[Ext_No].FloorInsulationThickness = 3;
      }
      if (Details.Element(this.HIP + "SAP-Room-In-Roof") != null)
      {
        IEnumerable<XElement> source = Details.Descendants(this.HIP + "SAP-Room-In-Roof");
        Func<XElement, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (XML_To_Survey._Closure\u0024__.\u0024I9\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = XML_To_Survey._Closure\u0024__.\u0024I9\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_To_Survey._Closure\u0024__.\u0024I9\u002D0 = selector = (Func<XElement, XElement>) (b => b);
        }
        this.Add_RoofRoom(source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>(), Ext_No);
      }
      if (Details.Element(this.HIP + "SAP-Alternative-Wall") != null)
      {
        IEnumerable<XElement> source = Details.Descendants(this.HIP + "SAP-Alternative-Wall");
        Func<XElement, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (XML_To_Survey._Closure\u0024__.\u0024I9\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = XML_To_Survey._Closure\u0024__.\u0024I9\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_To_Survey._Closure\u0024__.\u0024I9\u002D1 = selector = (Func<XElement, XElement>) (b => b);
        }
        this.Add_AltWall(source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>(), Ext_No);
      }
      IEnumerable<XElement> source1 = Details.Descendants(this.HIP + "SAP-Floor-Dimension");
      Func<XElement, XElement> selector1;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I9\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector1 = XML_To_Survey._Closure\u0024__.\u0024I9\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I9\u002D2 = selector1 = (Func<XElement, XElement>) (b => b);
      }
      List<XElement> list = source1.Select<XElement, XElement>(selector1).ToList<XElement>();
      try
      {
        foreach (XElement Details1 in list)
          this.Add_Floor(Details1, Ext_No);
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    private void Add_Floor(XElement Details, int Ext_No)
    {
      if (Details.Element(this.HIP + "Floor-Construction") != null)
      {
        string Left = Details.Element(this.HIP + "Floor-Construction").Value;
        if (Operators.CompareString(Left, "0", false) != 0)
        {
          if (Operators.CompareString(Left, "1", false) != 0)
          {
            if (Operators.CompareString(Left, "2", false) != 0)
            {
              if (Operators.CompareString(Left, "3", false) == 0)
                this.Survey.Extensions[Ext_No].FloorConstruction = 4;
            }
            else
              this.Survey.Extensions[Ext_No].FloorConstruction = 3;
          }
          else
            this.Survey.Extensions[Ext_No].FloorConstruction = 2;
        }
        else
          this.Survey.Extensions[Ext_No].FloorConstruction = 1;
      }
      if (Details.Element(this.HIP + "Floor-Insulation") != null)
      {
        string Left = Details.Element(this.HIP + "Floor-Insulation").Value;
        if (Operators.CompareString(Left, "0", false) != 0)
        {
          if (Operators.CompareString(Left, "1", false) != 0)
          {
            if (Operators.CompareString(Left, "2", false) == 0)
              this.Survey.Extensions[Ext_No].FloorInsulation = 3;
          }
          else
            this.Survey.Extensions[Ext_No].FloorInsulation = 2;
        }
        else
          this.Survey.Extensions[Ext_No].FloorInsulation = 1;
      }
      int integer = Conversions.ToInteger(Details.Element(this.HIP + "Floor").Value);
      Extension_Class extension;
      int num = checked ((extension = this.Survey.Extensions[Ext_No]).Storeys + 1);
      extension.Storeys = num;
      this.Survey.Extensions[Ext_No].Storey[integer].Name = Conversions.ToString(integer);
      this.Survey.Extensions[Ext_No].Storey[integer].Perimeter = Conversions.ToDouble(Details.Element(this.HIP + "Heat-Loss-Perimeter").Value);
      this.Survey.Extensions[Ext_No].Storey[integer].Area = Conversions.ToDouble(Details.Element(this.HIP + "Total-Floor-Area").Value);
      this.Survey.Extensions[Ext_No].Storey[integer].Height = Conversions.ToDouble(Details.Element(this.HIP + "Room-Height").Value);
    }

    private void Add_RoofRoom(XElement Details, int Ext_No)
    {
      this.Survey.Extensions[Ext_No].RoofRoom = true;
      this.Survey.Extensions[Ext_No].RoofRoomFloor_Area = Conversions.ToDouble(Details.Element(this.HIP + "Floor-Area").Value);
      string str1 = Details.Element(this.HIP + "Construction-Age-Band").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 3222007936:
          if (Operators.CompareString(str1, "E", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 5;
            break;
          }
          break;
        case 3238785555:
          if (Operators.CompareString(str1, "D", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 4;
            break;
          }
          break;
        case 3255563174:
          if (Operators.CompareString(str1, "G", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 7;
            break;
          }
          break;
        case 3272340793:
          if (Operators.CompareString(str1, "F", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 6;
            break;
          }
          break;
        case 3289118412:
          if (Operators.CompareString(str1, "A", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 1;
            break;
          }
          break;
        case 3322673650:
          if (Operators.CompareString(str1, "C", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 3;
            break;
          }
          break;
        case 3339451269:
          if (Operators.CompareString(str1, "B", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 2;
            break;
          }
          break;
        case 3423339364:
          if (Operators.CompareString(str1, "I", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 9;
            break;
          }
          break;
        case 3440116983:
          if (Operators.CompareString(str1, "H", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 8;
            break;
          }
          break;
        case 3456894602:
          if (Operators.CompareString(str1, "K", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 11;
            break;
          }
          break;
        case 3473672221:
          if (Operators.CompareString(str1, "J", false) == 0)
          {
            this.Survey.Extensions[Ext_No].RoofAge = 10;
            break;
          }
          break;
      }
      if (Operators.CompareString(Details.Element(this.HIP + "Roof-Room-Connected").Value, "Y", false) == 0)
        this.Survey.Extensions[Ext_No].RoomRoofConnected = true;
      if (Details.Element(this.HIP + "Insulation") != null)
      {
        this.Survey.Extensions[Ext_No].RoomRoofInsulationAtSlope = 1;
        string str2 = Details.Element(this.HIP + "Insulation").Value;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
        {
          case 806133968:
            if (Operators.CompareString(str2, "5", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoomRoofInsulationAtSlope = 4;
              break;
            }
            break;
          case 822911587:
            if (Operators.CompareString(str2, "4", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoomRoofInsulationAtSlope = 3;
              break;
            }
            break;
          case 873244444:
            if (Operators.CompareString(str2, "1", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Insulation = 1;
              break;
            }
            break;
          case 890022063:
            if (Operators.CompareString(str2, "0", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Insulation = 0;
              break;
            }
            break;
          case 906799682:
            if (Operators.CompareString(str2, "3", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoomRoofInsulationAtSlope = 2;
              break;
            }
            break;
          case 923577301:
            if (Operators.CompareString(str2, "2", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Insulation = 2;
              break;
            }
            break;
          case 1004962376:
            if (Operators.CompareString(str2, "NI", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Insulation = 0;
              break;
            }
            break;
        }
      }
      if (Details.Element(this.HIP + "Roof-Insulation-Thickness") != null)
      {
        if (this.Survey.Extensions[Ext_No].RoofRoom_Insulation != 2)
          this.Survey.Extensions[Ext_No].RoofRoom_Insulation = 3;
        string str3 = Details.Element(this.HIP + "Roof-Insulation-Thickness").Value;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str3))
        {
          case 536439224:
            if (Operators.CompareString(str3, "12mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 3;
              break;
            }
            break;
          case 580823818:
            if (Operators.CompareString(str3, "100mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 7;
              break;
            }
            break;
          case 890022063:
            if (Operators.CompareString(str3, "0", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 1;
              break;
            }
            break;
          case 954629519:
            if (Operators.CompareString(str3, "ND", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 12;
              break;
            }
            break;
          case 1004962376:
            if (Operators.CompareString(str3, "NI", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 2;
              break;
            }
            break;
          case 1331213009:
            if (Operators.CompareString(str3, "300mm+", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 11;
              break;
            }
            break;
          case 1902927683:
            if (Operators.CompareString(str3, "75mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 6;
              break;
            }
            break;
          case 2039723566:
            if (Operators.CompareString(str3, "25mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 4;
              break;
            }
            break;
          case 2195684654:
            if (Operators.CompareString(str3, "50mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 5;
              break;
            }
            break;
          case 3014084414:
            if (Operators.CompareString(str3, "250mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 10;
              break;
            }
            break;
          case 3570421319:
            if (Operators.CompareString(str3, "200mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 9;
              break;
            }
            break;
          case 4000619179:
            if (Operators.CompareString(str3, "150mm", false) == 0)
            {
              this.Survey.Extensions[Ext_No].RoofRoom_Tickness = 8;
              break;
            }
            break;
        }
      }
      if (Details.Element(this.HIP + "Room-In-Roof-Details") != null)
      {
        IEnumerable<XElement> source = Details.Descendants(this.HIP + "Room-In-Roof-Details");
        Func<XElement, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (XML_To_Survey._Closure\u0024__.\u0024I11\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = XML_To_Survey._Closure\u0024__.\u0024I11\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_To_Survey._Closure\u0024__.\u0024I11\u002D0 = selector = (Func<XElement, XElement>) (b => b);
        }
        XElement xelement = source.Select<XElement, XElement>(selector).FirstOrDefault<XElement>();
        this.Survey.Extensions[Ext_No].RoofRoom_Edit = true;
        if (xelement.Element(this.HIP + "Flat-Ceiling-Area-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_FlatCeiling[0].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Flat-Ceiling-Area-1").Value);
        if (xelement.Element(this.HIP + "Flat-Ceiling-U-Value-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_FlatCeiling[0].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Flat-Ceiling-U-Value-1").Value);
        if (xelement.Element(this.HIP + "Stud-Wall-Area-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_StudWall[0].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Stud-Wall-Area-1").Value);
        if (xelement.Element(this.HIP + "Stud-Wall-U-Value-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_StudWall[0].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Stud-Wall-U-Value-1").Value);
        if (xelement.Element(this.HIP + "Slope-Area-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_Slope[0].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Slope-Area-1").Value);
        if (xelement.Element(this.HIP + "Slope-U-Value-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_Slope[0].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Slope-U-Value-1").Value);
        if (xelement.Element(this.HIP + "Gable-Wall-Area-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_GableWall[0].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Gable-Wall-Area-1").Value);
        if (xelement.Element(this.HIP + "Gable-Wall-U-Value-1") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_GableWall[0].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Gable-Wall-U-Value-1").Value);
        if (xelement.Element(this.HIP + "Flat-Ceiling-Area-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_FlatCeiling[1].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Flat-Ceiling-Area-2").Value);
        if (xelement.Element(this.HIP + "Flat-Ceiling-U-Value-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_FlatCeiling[1].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Flat-Ceiling-U-Value-2").Value);
        if (xelement.Element(this.HIP + "Stud-Wall-Area-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_StudWall[1].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Stud-Wall-Area-2").Value);
        if (xelement.Element(this.HIP + "Stud-Wall-U-Value-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_StudWall[1].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Stud-Wall-U-Value-2").Value);
        if (xelement.Element(this.HIP + "Slope-Area-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_Slope[1].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Slope-Area-2").Value);
        if (xelement.Element(this.HIP + "Slope-U-Value-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_Slope[1].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Slope-U-Value-2").Value);
        if (xelement.Element(this.HIP + "Gable-Wall-Area-2") != null)
          this.Survey.Extensions[Ext_No].RoofRoom_GableWall[1].Area = Conversions.ToDouble(xelement.Element(this.HIP + "Gable-Wall-Area-2").Value);
        if (xelement.Element(this.HIP + "Gable-Wall-U-Value-2") == null)
          return;
        this.Survey.Extensions[Ext_No].RoofRoom_GableWall[1].U_Value = Conversions.ToDouble(xelement.Element(this.HIP + "Gable-Wall-U-Value-2").Value);
      }
      else
        this.Survey.Extensions[Ext_No].RoofRoom_Edit = false;
    }

    private void Add_AltWall(XElement Details, int Ext_No)
    {
      this.Survey.Extensions[Ext_No].AltPresent = true;
      string str1 = Details.Element(this.HIP + "Wall-Construction").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
      {
        case 806133968:
          if (Operators.CompareString(str1, "5", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 5;
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str1, "4", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 4;
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str1, "1", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 1;
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str1, "3", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 3;
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str1, "2", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 2;
            break;
          }
          break;
        case 1007465396:
          if (Operators.CompareString(str1, "9", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 7;
            break;
          }
          break;
        case 1024243015:
          if (Operators.CompareString(str1, "8", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallConstruction = 6;
            break;
          }
          break;
      }
      string str2 = Details.Element(this.HIP + "Wall-Insulation-Type").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 806133968:
          if (Operators.CompareString(str2, "5", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 5;
            break;
          }
          break;
        case 822911587:
          if (Operators.CompareString(str2, "4", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 4;
            break;
          }
          break;
        case 839689206:
          if (Operators.CompareString(str2, "7", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 7;
            break;
          }
          break;
        case 856466825:
          if (Operators.CompareString(str2, "6", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 6;
            break;
          }
          break;
        case 873244444:
          if (Operators.CompareString(str2, "1", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 1;
            break;
          }
          break;
        case 906799682:
          if (Operators.CompareString(str2, "3", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 3;
            break;
          }
          break;
        case 923577301:
          if (Operators.CompareString(str2, "2", false) == 0)
          {
            this.Survey.Extensions[Ext_No].AltWallInsulationType = 2;
            break;
          }
          break;
      }
      this.Survey.Extensions[Ext_No].AltWallArea = Conversions.ToDouble(Details.Element(this.HIP + "Wall-Area").Value);
      if (Details.Element(this.HIP + "Wall-Insulation-Thickness") != null)
      {
        string Left = Details.Element(this.HIP + "Wall-Insulation-Thickness").Value;
        if (Operators.CompareString(Left, "100mm", false) != 0)
        {
          if (Operators.CompareString(Left, "150mm", false) != 0)
          {
            if (Operators.CompareString(Left, "50mm", false) != 0)
            {
              if (Operators.CompareString(Left, "NI", false) != 0)
              {
                if (Operators.CompareString(Left, "N", false) == 0)
                  this.Survey.Extensions[Ext_No].AltWallInsulationThickness = 1;
              }
              else
                this.Survey.Extensions[Ext_No].AltWallInsulationThickness = 1;
            }
            else
              this.Survey.Extensions[Ext_No].AltWallInsulationThickness = 2;
          }
          else
            this.Survey.Extensions[Ext_No].AltWallInsulationThickness = 4;
        }
        else
          this.Survey.Extensions[Ext_No].AltWallInsulationThickness = 3;
      }
      if (Details.Element(this.HIP + "Wall-Thickness-Measured") != null && Operators.CompareString(Details.Element(this.HIP + "Wall-Thickness-Measured").Value, "Y", false) == 0)
        this.Survey.Extensions[Ext_No].AltWallThicknessMeasured = true;
      if (Details.Element(this.HIP + "Wall-Thickness") != null)
        this.Survey.Extensions[Ext_No].AltWallThickness = Conversions.ToDouble(Details.Element(this.HIP + "Wall-Thickness").Value);
      if (Details.Element(this.HIP + "Wall-U-Value") != null)
      {
        this.Survey.Extensions[Ext_No].AltWallUValueKnown = true;
        this.Survey.Extensions[Ext_No].AltWallUValue = Conversions.ToDouble(Details.Element(this.HIP + "Wall-U-Value").Value);
      }
      if (Details.Element(this.HIP + "Wall-Dry-Lined") != null && Operators.CompareString(Details.Element(this.HIP + "Wall-Dry-Lined").Value, "Y", false) == 0)
        this.Survey.Extensions[Ext_No].AltWallDryLined = 1;
      if (Details.Element(this.HIP + "Sheltered-Wall") == null || Operators.CompareString(Details.Element(this.HIP + "Sheltered-Wall").Value, "Y", false) != 0)
        return;
      this.Survey.Extensions[Ext_No].AltShelteredWall = 1;
    }

    private void Add_Conservatory(XElement Details)
    {
      if (Operators.CompareString(Details.Element(this.HIP + "Double-Glazed").Value, "Y", false) == 0)
        this.Survey.Conservatory.DoubleGlazed = true;
      this.Survey.Conservatory.FloorArea = Conversions.ToDouble(Details.Element(this.HIP + "Floor-Area").Value);
      this.Survey.Conservatory.GlazedPerimeter = Conversions.ToDouble(Details.Element(this.HIP + "Glazed-Perimeter").Value);
      string Left = Details.Element(this.HIP + "Room-Height").Value;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "1.5", false) != 0)
        {
          if (Operators.CompareString(Left, "2", false) != 0)
          {
            if (Operators.CompareString(Left, "2.5", false) != 0)
            {
              if (Operators.CompareString(Left, "3", false) != 0)
                return;
              this.Survey.Conservatory.RoomHeight = 5;
            }
            else
              this.Survey.Conservatory.RoomHeight = 4;
          }
          else
            this.Survey.Conservatory.RoomHeight = 3;
        }
        else
          this.Survey.Conservatory.RoomHeight = 2;
      }
      else
        this.Survey.Conservatory.RoomHeight = 1;
    }

    private void Add_Flat(XElement Details)
    {
      if (Details.Element(this.HIP + "Top-Storey") != null)
        this.Survey.Flat_Maisonette.TopStorey = Conversions.ToString(Operators.CompareString(Details.Element(this.HIP + "Top-Storey").Value, "Y", false) == 0);
      string Left1 = Details.Element(this.HIP + "Level").Value;
      if (Operators.CompareString(Left1, "0", false) != 0)
      {
        if (Operators.CompareString(Left1, "1", false) != 0)
        {
          if (Operators.CompareString(Left1, "2", false) != 0)
          {
            if (Operators.CompareString(Left1, "3", false) == 0)
              this.Survey.Flat_Maisonette.Level = 4;
          }
          else
            this.Survey.Flat_Maisonette.Level = 3;
        }
        else
          this.Survey.Flat_Maisonette.Level = 2;
      }
      else
        this.Survey.Flat_Maisonette.Level = 1;
      string str = Details.Element(this.HIP + "Flat-Location").Value;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 334175660:
          if (Operators.CompareString(str, "18", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 20;
            goto default;
          }
          else
            goto default;
        case 348981803:
          if (Operators.CompareString(str, "-1", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 1;
            goto default;
          }
          else
            goto default;
        case 350953279:
          if (Operators.CompareString(str, "19", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 21;
            goto default;
          }
          else
            goto default;
        case 401286136:
          if (Operators.CompareString(str, "14", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 16;
            goto default;
          }
          else
            goto default;
        case 418063755:
          if (Operators.CompareString(str, "15", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 17;
            goto default;
          }
          else
            goto default;
        case 418210850:
          if (Operators.CompareString(str, "09", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 11;
            goto default;
          }
          else
            goto default;
        case 434841374:
          if (Operators.CompareString(str, "16", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 18;
            goto default;
          }
          else
            goto default;
        case 434988469:
          if (Operators.CompareString(str, "08", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 10;
            goto default;
          }
          else
            goto default;
        case 451618993:
          if (Operators.CompareString(str, "17", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 19;
            goto default;
          }
          else
            goto default;
        case 451766088:
          if (Operators.CompareString(str, "07", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 9;
            goto default;
          }
          else
            goto default;
        case 468396612:
          if (Operators.CompareString(str, "10", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 12;
            goto default;
          }
          else
            goto default;
        case 468543707:
          if (Operators.CompareString(str, "06", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 8;
            goto default;
          }
          else
            goto default;
        case 485174231:
          if (Operators.CompareString(str, "11", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 13;
            goto default;
          }
          else
            goto default;
        case 485321326:
          if (Operators.CompareString(str, "05", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 7;
            goto default;
          }
          else
            goto default;
        case 501951850:
          if (Operators.CompareString(str, "12", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 14;
            goto default;
          }
          else
            goto default;
        case 502098945:
          if (Operators.CompareString(str, "04", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 6;
            goto default;
          }
          else
            goto default;
        case 518729469:
          if (Operators.CompareString(str, "13", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 15;
            goto default;
          }
          else
            goto default;
        case 518876564:
          if (Operators.CompareString(str, "03", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 5;
            goto default;
          }
          else
            goto default;
        case 535654183:
          if (Operators.CompareString(str, "02", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 4;
            goto default;
          }
          else
            goto default;
        case 552431802:
          if (Operators.CompareString(str, "01", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 3;
            goto default;
          }
          else
            goto default;
        case 569209421:
          if (Operators.CompareString(str, "00", false) == 0)
            break;
          goto default;
        case 890022063:
          if (Operators.CompareString(str, "0", false) == 0)
            break;
          goto default;
        case 2381486463:
          if (Operators.CompareString(str, "20", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 22;
            goto default;
          }
          else
            goto default;
        case 3370606396:
          if (Operators.CompareString(str, "20+", false) == 0)
          {
            this.Survey.Flat_Maisonette.FlatLocation = 23;
            goto default;
          }
          else
            goto default;
        default:
label_58:
          string Left2 = Details.Element(this.HIP + "Heat-Loss-Corridor").Value;
          if (Operators.CompareString(Left2, "0", false) != 0)
          {
            if (Operators.CompareString(Left2, "1", false) != 0)
            {
              if (Operators.CompareString(Left2, "2", false) == 0)
                this.Survey.Flat_Maisonette.HeatLossCorridor = 3;
            }
            else
              this.Survey.Flat_Maisonette.HeatLossCorridor = 2;
          }
          else
            this.Survey.Flat_Maisonette.HeatLossCorridor = 1;
          if (Details.Element(this.HIP + "Unheated-Corridor-Length") == null)
            return;
          this.Survey.Flat_Maisonette.UnHeatedCorridorLength = Conversions.ToDouble(Details.Element(this.HIP + "Unheated-Corridor-Length").Value);
          return;
      }
      this.Survey.Flat_Maisonette.FlatLocation = 2;
      goto label_58;
    }

    private void Add_Addendums(XElement Details)
    {
      this.Survey.Addendums.Addendum = true;
      IEnumerable<XElement> source = Details.Descendants(this.HIP + "Addendum-Number");
      Func<XElement, XElement> selector;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I15\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = XML_To_Survey._Closure\u0024__.\u0024I15\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I15\u002D0 = selector = (Func<XElement, XElement>) (test => test);
      }
      List<XElement> list = source.Select<XElement, XElement>(selector).ToList<XElement>();
      List<int> intList = new List<int>();
      try
      {
        foreach (XElement xelement in list)
          intList.Add(Conversions.ToInteger(xelement.Value));
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.Survey.Addendums.AddendumList = intList.ToArray();
      if (Details.Element(this.HIP + "Cavity-Fill-Recommended") != null)
        this.Survey.Addendums.AddendumCavityFilled = true;
      if (Details.Element(this.HIP + "Stone-Walls") != null)
        this.Survey.Addendums.AddendumStoneWall = true;
      if (Details.Element(this.HIP + "System-Build") != null)
        this.Survey.Addendums.AddendumSystemBuild = true;
      if (Details.Element(this.HIP + "Access-Issues") != null)
        this.Survey.Addendums.AddendumIssueAcess = true;
      if (Details.Element(this.HIP + "High-Exposure") != null)
        this.Survey.Addendums.AddendumHighExp = true;
      if (Details.Element(this.HIP + "Narrow-Cavities") == null)
        return;
      this.Survey.Addendums.AddendumNarrowCavity = true;
    }

    private void Add_Assessor(XElement Details)
    {
      XNamespace xnamespace;
      string str;
      if (this.SAP == (XNamespace) "DCLG-SAP")
      {
        xnamespace = this.SAP;
        str = "Certificate-Number";
      }
      else
      {
        xnamespace = this.HIP;
        str = "Membership-Number";
      }
      IEnumerable<XElement> source1 = Details.Descendants(xnamespace + "Identification-Number");
      Func<XElement, XElement> selector1;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I16\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector1 = XML_To_Survey._Closure\u0024__.\u0024I16\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I16\u002D0 = selector1 = (Func<XElement, XElement>) (b => b);
      }
      this.Survey.Info.Assessor.AssessorNO = source1.Select<XElement, XElement>(selector1).FirstOrDefault<XElement>().Element(xnamespace + str).Value;
      this.Survey.Info.Assessor.EA_Web = Details.Element(xnamespace + "Web-Site").Value;
      this.Survey.Info.Assessor.EA_Email = Details.Element(xnamespace + "E-Mail").Value;
      this.Survey.Info.Assessor.AssessorFax = Details.Element(xnamespace + "Fax").Value;
      this.Survey.Info.Assessor.AssessorPhone = Details.Element(xnamespace + "Telephone").Value;
      this.Survey.Info.Assessor.AssessorCompany = Details.Element(xnamespace + "Company-Name").Value;
      if (Details.Element(xnamespace + "Name") != null)
      {
        if (Details.Element(xnamespace + "Name").Element(xnamespace + "Surname") != null)
        {
          this.Survey.Info.Assessor.AssessorFN = Details.Element(xnamespace + "Name").Element(xnamespace + "First-Name").Value;
          this.Survey.Info.Assessor.AssessorLN = Details.Element(xnamespace + "Name").Element(xnamespace + "Surname").Value;
        }
        else if (Details.Element(xnamespace + "Name").Value.Contains(" "))
        {
          string[] strArray = Details.Element(xnamespace + "Name").Value.Split(' ');
          this.Survey.Info.Assessor.AssessorFN = strArray[0];
          this.Survey.Info.Assessor.AssessorLN = strArray[1];
        }
        else
          this.Survey.Info.Assessor.AssessorFN = Details.Element(xnamespace + "Name").Value;
      }
      IEnumerable<XElement> source2 = Details.Descendants(xnamespace + "Contact-Address");
      Func<XElement, XElement> selector2;
      // ISSUE: reference to a compiler-generated field
      if (XML_To_Survey._Closure\u0024__.\u0024I16\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector2 = XML_To_Survey._Closure\u0024__.\u0024I16\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        XML_To_Survey._Closure\u0024__.\u0024I16\u002D1 = selector2 = (Func<XElement, XElement>) (b => b);
      }
      XElement xelement = source2.Select<XElement, XElement>(selector2).FirstOrDefault<XElement>();
      this.Survey.Info.Assessor.EA_Address1 = xelement.Element(this.HIP + "Address-Line-1").Value;
      if (xelement.Element(this.HIP + "Address-Line-2") != null)
        this.Survey.Info.Assessor.EA_Address2 = xelement.Element(this.HIP + "Address-Line-2").Value;
      this.Survey.Info.Assessor.EA_Town = xelement.Element(this.HIP + "Post-Town").Value;
      this.Survey.Info.Assessor.EA_Postcode = xelement.Element(this.HIP + "Postcode").Value;
    }

    private void Add_Address(XElement Details)
    {
      this.Survey.General.AddressLine1 = Details.Element(this.HIP + "Address-Line-1").Value;
      if (Details.Element(this.HIP + "Address-Line-2") != null)
        this.Survey.General.AddressLine2 = Details.Element(this.HIP + "Address-Line-2").Value;
      this.Survey.General.City = Details.Element(this.HIP + "Post-Town").Value;
      this.Survey.General.PostCode = Details.Element(this.HIP + "Postcode").Value;
    }

    private void Add_MainHeating(XElement Details)
    {
      int index = checked ((int) Math.Round(unchecked (Conversions.ToDouble(Details.Element(this.HIP + "Main-Heating-Number").Value) - 1.0)));
      this.Survey.MainHeating[0].MainHeating = true;
      this.Survey.MainHeating[index].Present = true;
      this.Survey.MainHeating[index].Fraction = Conversions.ToDouble(Details.Element(this.HIP + "Main-Heating-Fraction").Value) * 100.0;
      string Left1 = Details.Element(this.HIP + "Main-Heating-Data-Source").Value;
      if (Operators.CompareString(Left1, "1", false) != 0)
      {
        if (Operators.CompareString(Left1, "2", false) == 0)
          this.Survey.MainHeating[index].DataSource = 2;
      }
      else
        this.Survey.MainHeating[index].DataSource = 1;
      if (Details.Element(this.HIP + "Boiler-Index-Number") != null)
        this.Survey.MainHeating[index].BoilerCode = Conversions.ToInteger(Details.Element(this.HIP + "Boiler-Index-Number").Value);
      if (Details.Element(this.HIP + "Main-Heating-Category") != null)
      {
        string Left2 = Details.Element(this.HIP + "Main-Heating-Category").Value;
        this.Survey.MainHeating[index].SecondaryType = Operators.CompareString(Left2, "2", false) == 0 ? 0 : (Operators.CompareString(Left2, "3", false) == 0 ? 1 : (Operators.CompareString(Left2, "4", false) == 0 || Operators.CompareString(Left2, "5", false) == 0 ? 4 : 2));
      }
      if (Details.Element(this.HIP + "SAP-Main-Heating-Code") != null)
      {
        string Left3 = Details.Element(this.HIP + "SAP-Main-Heating-Code").Value;
        if (Operators.CompareString(Left3, "306", false) != 0)
        {
          if (Operators.CompareString(Left3, "307", false) != 0)
          {
            if (Operators.CompareString(Left3, "309", false) != 0)
            {
              if (Operators.CompareString(Left3, "699", false) == 0)
              {
                this.Survey.MainHeating[index].Present = false;
                this.Survey.MainHeating[index].MainHeating = false;
                this.Survey.MainHeating[index].SAPCode = 699;
              }
              else
                this.Survey.MainHeating[index].SAPCode = Conversions.ToInteger(Details.Element(this.HIP + "SAP-Main-Heating-Code").Value);
            }
            else
              this.Survey.MainHeating[index].SAPCode = 304;
          }
          else
            this.Survey.MainHeating[index].SAPCode = 302;
        }
        else
          this.Survey.MainHeating[index].SAPCode = 301;
      }
      if (this.Survey.MainHeating[index].SAPCode == 699)
      {
        this.Survey.General.NoHeating = true;
        this.Survey.MainHeating[index].Present = false;
      }
      this.Survey.MainHeating[index].ControlsCode = Conversions.ToInteger(Details.Element(this.HIP + "Main-Heating-Control").Value);
      DataSAP dataSap = new DataSAP();
      this.Survey.MainHeating[index].Fuel = (int) dataSap.CheckFuel(Details.Element(this.HIP + "Main-Fuel-Type").Value);
      if (Details.Element(this.HIP + "Boiler-Flue-Type") != null)
      {
        string Left4 = Details.Element(this.HIP + "Boiler-Flue-Type").Value;
        if (Operators.CompareString(Left4, "1", false) != 0)
        {
          if (Operators.CompareString(Left4, "2", false) == 0)
            this.Survey.MainHeating[index].BoilerFlueType = 2;
        }
        else
          this.Survey.MainHeating[index].BoilerFlueType = 1;
      }
      if (Details.Element(this.HIP + "Fan-Flue-Present") != null && Operators.CompareString(Details.Element(this.HIP + "Fan-Flue-Present").Value, "Y", false) == 0)
        this.Survey.MainHeating[index].FanFluePresent = true;
      string Left5 = Details.Element(this.HIP + "Heat-Emitter-Type").Value;
      if (Operators.CompareString(Left5, "1", false) != 0)
      {
        if (Operators.CompareString(Left5, "2", false) != 0)
        {
          if (Operators.CompareString(Left5, "3", false) == 0)
            this.Survey.MainHeating[index].EmitterType = 3;
        }
        else
          this.Survey.MainHeating[index].EmitterType = 2;
      }
      else
        this.Survey.MainHeating[index].EmitterType = 1;
      if (Operators.CompareString(Details.Element(this.HIP + "Has-FGHRS").Value, "Y", false) == 0)
        this.Survey.MainHeating[index].HasFGHRS = true;
      if (Details.Element(this.HIP + "FGHRS-Index-Number") == null)
        return;
      this.Survey.MainHeating[index].FGHRSIndexNum = Conversions.ToInteger(Details.Element(this.HIP + "FGHRS-Index-Number").Value);
    }

    private void Add_Water(XElement Details)
    {
      this.Survey.WaterHeating.Code = Conversions.ToInteger(Details.Element(this.HIP + "Water-Heating-Code").Value);
      if (this.Survey.WaterHeating.Code == 999)
        this.Survey.WaterHeating.Code = 903;
      DataSAP dataSap = new DataSAP();
      this.Survey.WaterHeating.Fuel = (int) dataSap.CheckFuel(Details.Element(this.HIP + "Water-Heating-Fuel").Value);
      if (Details.Element(this.HIP + "Secondary-Heating-Type") != null)
      {
        this.Survey.SecondaryHeating.Present = true;
        this.Survey.SecondaryHeating.Code = Conversions.ToInteger(Details.Element(this.HIP + "Secondary-Heating-Type").Value);
      }
      string Left1 = Details.Element(this.HIP + "Cylinder-Size").Value;
      if (Operators.CompareString(Left1, "0", false) != 0)
      {
        if (Operators.CompareString(Left1, "1", false) != 0)
        {
          if (Operators.CompareString(Left1, "2", false) != 0)
          {
            if (Operators.CompareString(Left1, "3", false) != 0)
            {
              if (Operators.CompareString(Left1, "4", false) == 0)
                this.Survey.WaterHeating.CylinderSize = 5;
            }
            else
              this.Survey.WaterHeating.CylinderSize = 4;
          }
          else
            this.Survey.WaterHeating.CylinderSize = 3;
        }
        else
          this.Survey.WaterHeating.CylinderSize = 1;
      }
      else
        this.Survey.WaterHeating.CylinderSize = 2;
      if (Details.Element(this.HIP + "Cylinder-Insulation-Type") != null)
      {
        string Left2 = Details.Element(this.HIP + "Cylinder-Insulation-Type").Value;
        if (Operators.CompareString(Left2, "0", false) != 0)
        {
          if (Operators.CompareString(Left2, "1", false) != 0)
          {
            if (Operators.CompareString(Left2, "2", false) == 0)
              this.Survey.WaterHeating.CylinderInsulationType = 3;
          }
          else
            this.Survey.WaterHeating.CylinderInsulationType = 2;
        }
        else
          this.Survey.WaterHeating.CylinderInsulationType = 1;
      }
      if (Details.Element(this.HIP + "Cylinder-Insulation-Thickness") != null)
      {
        string str = Details.Element(this.HIP + "Cylinder-Insulation-Thickness").Value;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 501951850:
            if (Operators.CompareString(str, "12", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 1;
              break;
            }
            break;
          case 1933075630:
            if (Operators.CompareString(str, "120", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 6;
              break;
            }
            break;
          case 2212577440:
            if (Operators.CompareString(str, "50", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 4;
              break;
            }
            break;
          case 2297598368:
            if (Operators.CompareString(str, "25", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 2;
              break;
            }
            break;
          case 2414894606:
            if (Operators.CompareString(str, "38", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 3;
              break;
            }
            break;
          case 2449582677:
            if (Operators.CompareString(str, "80", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 5;
              break;
            }
            break;
          case 4214140266:
            if (Operators.CompareString(str, "160", false) == 0)
            {
              this.Survey.WaterHeating.CylinderInsulationThickness = 7;
              break;
            }
            break;
        }
      }
      if (Details.Element(this.HIP + "Cylinder-Thermostat") != null && Operators.CompareString(Details.Element(this.HIP + "Cylinder-Thermostat").Value, "Y", false) == 0)
        this.Survey.WaterHeating.CylinderThermostat = true;
      if (Details.Element(this.HIP + "Secondary-Fuel-Type") != null)
        this.Survey.SecondaryHeating.Fuel = (int) dataSap.CheckFuel(Details.Element(this.HIP + "Secondary-Fuel-Type").Value);
      if (Details.Element(this.HIP + "Immersion-Heating-Type") != null)
        this.Survey.WaterHeating.ImmersionHeatingType = Conversions.ToInteger(Details.Element(this.HIP + "Immersion-Heating-Type").Value);
      this.Survey.OtherDetails.SpaceCooling = Conversions.ToBoolean(Details.Element(this.HIP + "Has-Fixed-Air-Conditioning").Value);
    }

    private void Add_WWHRS(XElement Details)
    {
      this.Survey.WaterHeating.WWHRS.RoomsWithBathAndOrShower = Conversions.ToInteger(Details.Element(this.HIP + "Rooms-With-Bath-And-Or-Shower").Value);
      this.Survey.WaterHeating.WWHRS.RoomsWithMixedShowerNoBath = Conversions.ToInteger(Details.Element(this.HIP + "Rooms-With-Mixer-Shower-No-Bath").Value);
      this.Survey.WaterHeating.WWHRS.RoomsWithBathAndShower = Conversions.ToInteger(Details.Element(this.HIP + "Rooms-With-Bath-And-Mixer-Shower").Value);
      if (Details.Element(this.HIP + "WWHRS-Index-Number1") != null)
      {
        this.Survey.WaterHeating.WWHRS.System[0].IndexNum = Conversions.ToInteger(Details.Element(this.HIP + "WWHRS-Index-Number1").Value);
        this.Survey.WaterHeating.WWHRS.Present = 1;
        this.Survey.WaterHeating.WWHRS.WWHRSTotal = 1;
      }
      if (Details.Element(this.HIP + "WWHRS-Index-Number2") != null)
      {
        this.Survey.WaterHeating.WWHRS.System[1].IndexNum = Conversions.ToInteger(Details.Element(this.HIP + "WWHRS-Index-Number2").Value);
        this.Survey.WaterHeating.WWHRS.WWHRSTotal = 2;
      }
      if (Details.Element(this.HIP + "Mixer-Showers-With-System1-With-Bath") != null)
        this.Survey.WaterHeating.WWHRS.System[0].MixedShowerWithSystemWithBath = Conversions.ToInteger(Details.Element(this.HIP + "Mixer-Showers-With-System1-With-Bath").Value);
      if (Details.Element(this.HIP + "Mixer-Showers-With-System1-Without-Bath") != null)
        this.Survey.WaterHeating.WWHRS.System[0].MixedShowerWithSystemWithoutBath = Conversions.ToInteger(Details.Element(this.HIP + "Mixer-Showers-With-System1-Without-Bath").Value);
      if (Details.Element(this.HIP + "Mixer-Showers-With-System2-With-Bath") != null)
        this.Survey.WaterHeating.WWHRS.System[1].MixedShowerWithSystemWithBath = Conversions.ToInteger(Details.Element(this.HIP + "Mixer-Showers-With-System2-With-Bath").Value);
      if (Details.Element(this.HIP + "Mixer-Showers-With-System2-Without-Bath") == null)
        return;
      this.Survey.WaterHeating.WWHRS.System[1].MixedShowerWithSystemWithoutBath = Conversions.ToInteger(Details.Element(this.HIP + "Mixer-Showers-With-System2-Without-Bath").Value);
    }

    private void Add_SolarWater(XElement Details)
    {
      this.Survey.WaterHeating.SolarWater.ApertureArea = Conversions.ToDouble(Details.Element(this.HIP + "Solar-Panel-Aperture-Area").Value);
      this.Survey.WaterHeating.SolarWater.Present = true;
      this.Survey.WaterHeating.SolarWater.Details = true;
      this.Survey.WaterHeating.SolarWater.CollectorType = Conversions.ToInteger(Details.Element(this.HIP + "Solar-Panel-Collector-Type").Value);
      this.Survey.WaterHeating.SolarWater.DataSource = Operators.CompareString(Details.Element(this.HIP + "Solar-Panel-Collector-Data-Source").Value, "2", false) == 0 ? 1 : 2;
      this.Survey.WaterHeating.SolarWater.Efficiency = Conversions.ToDouble(Details.Element(this.HIP + "Solar-Panel-Collector-Zero-Loss-Efficiency").Value) / 100.0;
      this.Survey.WaterHeating.SolarWater.HeatLoss = Conversions.ToDouble(Details.Element(this.HIP + "Solar-Panel-Collector-Heat-Loss-Rate").Value);
      this.Survey.WaterHeating.SolarWater.Orientation = Conversions.ToInteger(Details.Element(this.HIP + "Solar-Panel-Collector-Orientation").Value);
      this.Survey.WaterHeating.SolarWater.Pitch = Conversions.ToInteger(Details.Element(this.HIP + "Solar-Panel-Collector-Pitch").Value);
      this.Survey.WaterHeating.SolarWater.Overshading = Conversions.ToInteger(Details.Element(this.HIP + "Solar-Panel-Collector-Overshading").Value);
      string Left = Details.Element(this.HIP + "Solar-Water-Pump").Value;
      if (Operators.CompareString(Left, "1", false) != 0)
      {
        if (Operators.CompareString(Left, "2", false) != 0)
        {
          if (Operators.CompareString(Left, "0", false) == 0)
            this.Survey.WaterHeating.SolarWater.WaterPump = 1;
        }
        else
          this.Survey.WaterHeating.SolarWater.WaterPump = 3;
      }
      else
        this.Survey.WaterHeating.SolarWater.WaterPump = 2;
      if (Operators.CompareString(Details.Element(this.HIP + "Store-Volume-Details-Known").Value, "Y", false) == 0)
        this.Survey.WaterHeating.SolarWater.StoreDetailsKnown = true;
      if (Details.Element(this.HIP + "Dedicated-Solar-Volume") != null)
        this.Survey.WaterHeating.SolarWater.StoreVolume = Conversions.ToDouble(Details.Element(this.HIP + "Dedicated-Solar-Volume").Value);
      if (Details.Element(this.HIP + "Total-Store-Volume") != null)
        this.Survey.WaterHeating.SolarWater.TotalStorevalue = Conversions.ToInteger(Details.Element(this.HIP + "Total-Store-Volume").Value);
      if (Details.Element(this.HIP + "Combined-Cylinder") == null)
        return;
      this.Survey.WaterHeating.SolarWater.Combined = Operators.CompareString(Details.Element(this.HIP + "Combined-Cylinder").Value, "Y", false) == 0;
    }

    private void Add_PV(XElement Details)
    {
      if (Details.Element(this.HIP + "Percent-Roof-Area") != null)
      {
        this.Survey.Renewable.PVPercentRoofArea = Conversions.ToDouble(Details.Element(this.HIP + "Percent-Roof-Area").Value);
        if (this.Survey.Renewable.PVPercentRoofArea <= 0.0)
          return;
        this.Survey.Renewable.PhotovoltaicSupplyPresent = true;
      }
      else
      {
        this.Survey.Renewable.PhotovoltaicSupplyPresent = true;
        IEnumerable<XElement> source = Details.Descendants(this.HIP + "PV-Array");
        Func<XElement, XElement> selector;
        // ISSUE: reference to a compiler-generated field
        if (XML_To_Survey._Closure\u0024__.\u0024I22\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = XML_To_Survey._Closure\u0024__.\u0024I22\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          XML_To_Survey._Closure\u0024__.\u0024I22\u002D0 = selector = (Func<XElement, XElement>) (b => b);
        }
        List<XElement> list = source.Select<XElement, XElement>(selector).ToList<XElement>();
        int index = 0;
        try
        {
          foreach (XElement xelement in list)
          {
            this.Survey.Renewable.PVDetails = true;
            this.Survey.Renewable.NoofPvs = checked (index + 1);
            this.Survey.Renewable.PVArray[index].Present = true;
            this.Survey.Renewable.PVArray[index].PeakPower = Conversions.ToDouble(xelement.Element(this.HIP + "Peak-Power").Value);
            this.Survey.Renewable.PVArray[index].Pitch = Conversions.ToInteger(xelement.Element(this.HIP + "Pitch").Value);
            this.Survey.Renewable.PVArray[index].Overshading = Conversions.ToInteger(xelement.Element(this.HIP + "Overshading").Value);
            string str = xelement.Element(this.HIP + "Orientation").Value;
            // ISSUE: reference to a compiler-generated method
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
            {
              case 806133968:
                if (Operators.CompareString(str, "5", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 5;
                  break;
                }
                break;
              case 822911587:
                if (Operators.CompareString(str, "4", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 4;
                  break;
                }
                break;
              case 839689206:
                if (Operators.CompareString(str, "7", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 7;
                  break;
                }
                break;
              case 856466825:
                if (Operators.CompareString(str, "6", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 6;
                  break;
                }
                break;
              case 873244444:
                if (Operators.CompareString(str, "1", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 1;
                  break;
                }
                break;
              case 906799682:
                if (Operators.CompareString(str, "3", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 3;
                  break;
                }
                break;
              case 923577301:
                if (Operators.CompareString(str, "2", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 2;
                  break;
                }
                break;
              case 954629519:
                if (Operators.CompareString(str, "ND", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 9;
                  break;
                }
                break;
              case 1024243015:
                if (Operators.CompareString(str, "8", false) == 0)
                {
                  this.Survey.Renewable.PVArray[index].Orientation = 8;
                  break;
                }
                break;
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
    }

    private void Add_Turbines(XElement Details)
    {
      this.Survey.OtherDetails.MeterType = Conversions.ToInteger(Details.Element(this.HIP + "Meter-Type").Value);
      this.Survey.OtherDetails.MainGas = Operators.CompareString(Details.Element(this.HIP + "Main-Gas").Value, "Y", false) == 0;
      this.Survey.Renewable.WindTurbinesCount = Conversions.ToInteger(Details.Element(this.HIP + "Wind-Turbines-Count").Value);
      if (this.Survey.Renewable.WindTurbinesCount > 0)
        this.Survey.Renewable.WindTurbinePresent = true;
      this.Survey.Renewable.WindTurbinesTerrainType = Conversions.ToInteger(Details.Element(this.HIP + "Wind-Turbines-Terrain-Type").Value);
      if (Details.Element(this.HIP + "Wind-Turbine-Details") == null)
        return;
      if (Details.Element(this.HIP + "Wind-Turbine-Details").Element(this.HIP + "Rotor-Diameter") != null)
      {
        this.Survey.Renewable.WindTurbineRotoDiameter = Conversions.ToDouble(Details.Element(this.HIP + "Wind-Turbine-Details").Element(this.HIP + "Rotor-Diameter").Value);
        this.Survey.Renewable.WindTurbineDetails = true;
      }
      if (Details.Element(this.HIP + "Wind-Turbine-Details").Element(this.HIP + "Hub-Height") != null)
        this.Survey.Renewable.WindTurbineHubHeight = Conversions.ToDouble(Details.Element(this.HIP + "Wind-Turbine-Details").Element(this.HIP + "Hub-Height").Value);
    }

    private void Add_Windows(List<XElement> Details)
    {
      List<Survey_Class.ExtendedWindows> extendedWindowsList = new List<Survey_Class.ExtendedWindows>();
      try
      {
        foreach (XElement detail in Details)
        {
          Survey_Class.ExtendedWindows extendedWindows = new Survey_Class.ExtendedWindows();
          string Left = detail.Element(this.HIP + "Window-Location").Value;
          if (Operators.CompareString(Left, "0", false) != 0)
          {
            if (Operators.CompareString(Left, "1", false) != 0)
            {
              if (Operators.CompareString(Left, "2", false) != 0)
              {
                if (Operators.CompareString(Left, "3", false) != 0)
                {
                  if (Operators.CompareString(Left, "4", false) == 0)
                    extendedWindows.WindowsLoc = 4;
                }
                else
                  extendedWindows.WindowsLoc = 3;
              }
              else
                extendedWindows.WindowsLoc = 2;
            }
            else
              extendedWindows.WindowsLoc = 1;
          }
          else
            extendedWindows.WindowsLoc = 0;
          extendedWindows.WindowArea = Conversions.ToDouble(detail.Element(this.HIP + "Window-Area").Value);
          string str1 = detail.Element(this.HIP + "Glazing-Type").Value;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1))
          {
            case 806133968:
              if (Operators.CompareString(str1, "5", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 5;
                break;
              }
              break;
            case 822911587:
              if (Operators.CompareString(str1, "4", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 4;
                break;
              }
              break;
            case 839689206:
              if (Operators.CompareString(str1, "7", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 7;
                break;
              }
              break;
            case 856466825:
              if (Operators.CompareString(str1, "6", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 6;
                break;
              }
              break;
            case 873244444:
              if (Operators.CompareString(str1, "1", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 1;
                break;
              }
              break;
            case 906799682:
              if (Operators.CompareString(str1, "3", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 3;
                break;
              }
              break;
            case 923577301:
              if (Operators.CompareString(str1, "2", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 2;
                break;
              }
              break;
            case 1024243015:
              if (Operators.CompareString(str1, "8", false) == 0)
              {
                extendedWindows.WindowMultipleGlazedType = 8;
                break;
              }
              break;
          }
          string str2 = detail.Element(this.HIP + "Orientation").Value;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
          {
            case 806133968:
              if (Operators.CompareString(str2, "5", false) == 0)
              {
                extendedWindows.WindowsOrientation = 5;
                break;
              }
              break;
            case 822911587:
              if (Operators.CompareString(str2, "4", false) == 0)
              {
                extendedWindows.WindowsOrientation = 4;
                break;
              }
              break;
            case 839689206:
              if (Operators.CompareString(str2, "7", false) == 0)
              {
                extendedWindows.WindowsOrientation = 7;
                break;
              }
              break;
            case 856466825:
              if (Operators.CompareString(str2, "6", false) == 0)
              {
                extendedWindows.WindowsOrientation = 6;
                break;
              }
              break;
            case 873244444:
              if (Operators.CompareString(str2, "1", false) == 0)
              {
                extendedWindows.WindowsOrientation = 1;
                break;
              }
              break;
            case 890022063:
              if (Operators.CompareString(str2, "0", false) == 0)
              {
                extendedWindows.WindowsOrientation = 9;
                break;
              }
              break;
            case 906799682:
              if (Operators.CompareString(str2, "3", false) == 0)
              {
                extendedWindows.WindowsOrientation = 3;
                break;
              }
              break;
            case 923577301:
              if (Operators.CompareString(str2, "2", false) == 0)
              {
                extendedWindows.WindowsOrientation = 2;
                break;
              }
              break;
            case 1007465396:
              if (Operators.CompareString(str2, "9", false) == 0)
              {
                extendedWindows.WindowsOrientation = 9;
                break;
              }
              break;
            case 1024243015:
              if (Operators.CompareString(str2, "8", false) == 0)
              {
                extendedWindows.WindowsOrientation = 8;
                break;
              }
              break;
          }
          extendedWindows.WindowType = Operators.CompareString(detail.Element(this.HIP + "Window-Type").Value, "2", false) == 0 ? 1 : 0;
          if (detail.Element(this.HIP + "U-Value") != null)
            extendedWindows.WindowsUValue = Conversions.ToDouble(detail.Element(this.HIP + "U-Value").Value);
          if (detail.Element(this.HIP + "Data-Source") != null)
            extendedWindows.WindowDataSource = Conversions.ToInteger(detail.Element(this.HIP + "Data-Source").Value);
          if (detail.Element(this.HIP + "Solar-Transmittance") != null)
            extendedWindows.WindowSolarTransmittance = Conversions.ToDouble(detail.Element(this.HIP + "Solar-Transmittance").Value);
          extendedWindowsList.Add(extendedWindows);
        }
      }
      finally
      {
        List<XElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.Survey.Openings.ExtendedWindows = extendedWindowsList.ToArray();
    }
  }
}
