
// Type: SAP2012.PCDF




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace SAP2012
{
  public class PCDF
  {
    public bool Populated { get; set; }

    public List<PCDF.SEDBUK> Boilers { get; set; }

    public List<PCDF.SEDBUK> Boilers_Illustrative { get; set; }

    public List<PCDF.SEDBUK_Solid> Solid_Boilers { get; set; }

    public List<PCDF.SEDBUK_Solid> Solid_Boilers_Illustrative { get; set; }

    public List<PCDF.HeatPump> HeatPumps { get; set; }

    public List<PCDF.HeatPump> HeatPumps_Illustrative { get; set; }

    public List<PCDF.WarmAir> WarmAirs { get; set; }

    public List<PCDF.WarmAir> WarmAirs_Illustrative { get; set; }

    public List<PCDF.HeatPump_Sub> HeatPumps_Sub_Illustrative { get; set; }

    public List<PCDF.HeatPump_Sub> HeatPumps_Sub { get; set; }

    public List<PCDF.CHP> CHPs { get; set; }

    public List<PCDF.CHP> CHPs_Illustrative { get; set; }

    public List<PCDF.CHP_Sub> CHPs_Sub { get; set; }

    public List<PCDF.CHP_Sub> CHPs_Sub_Illustrative { get; set; }

    public List<PCDF.FGHRS> FGHRSs { get; set; }

    public List<PCDF.FGHRS> FGHRSs_Illustrative { get; set; }

    public List<PCDF.FGHRS_Sub> FGHRSs_Sub { get; set; }

    public List<PCDF.FGHRS_Sub> FGHRSs_Sub_Illustrative { get; set; }

    public List<PCDF.WWHRS> WWHRSs { get; set; }

    public List<PCDF.WWHRS> WWHRSs_Illustrative { get; set; }

    public List<PCDF.InUseMech> InUseMechs { get; set; }

    public List<PCDF.Products321> Products321s { get; set; }

    public List<PCDF.Products321_Sub> Products321s_Sub { get; set; }

    public List<PCDF.Products322> Products322s { get; set; }

    public List<PCDF.Products322_Sub> Products322s_Sub { get; set; }

    public List<PCDF.HistoricTable12SEDBUK> HistoricPrices { get; set; }

    public List<PCDF.EcoTable> EcoMeasures { get; set; }

    public List<PCDF.RegionalData> PostCodeTable { get; set; }

    public List<PCDF.HeatingControl> HeatingControls { get; set; }

    public List<PCDF.HeatingControl> HeatingControls_Illistrative { get; set; }

    public List<PCDF.HeatingControlFeature> HeatingControlFeatures { get; set; }

    public List<PCDF.Storage_Heater> Storage_Heaters { get; set; }

    public List<PCDF.Storage_Heater> Storage_Heaters_Illustrative { get; set; }

    public List<PCDF.CommunityScheme> CommunitySchemes { get; set; }

    public List<PCDF.CommunityScheme_Sub> CommunitySchemes_Sub { get; set; }

    public List<PCDF.Table4a_B> Table4a_bs { get; set; }

    public List<PCDF.Table4e> Table4es { get; set; }

    public List<PCDF.Table6e> Table6es { get; set; }

    public List<PCDF.Table4aWater> Table4aWaters { get; set; }

    public List<PCDF.Table_P7> Table_P7s { get; set; }

    public List<PCDF.Table12a> Table12as { get; set; }

    public List<PCDF.Table12SEDBUK> Table12aSEDBUKs { get; set; }

    public List<PCDF.Table131> Table131s { get; set; }

    public List<PCDF.Table131> Table181s { get; set; }

    public List<PCDF.Table_P1> Table_P1s { get; set; }

    public List<PCDF.RegionalData> AppendixU { get; set; }

    public List<PCDF.TableU5Constants> TableU5 { get; set; }

    public string Version { get; set; }

    public DateTime VersionDate { get; set; }

    public string PCDFFuelVersion { get; set; }

    public PCDF(string File)
    {
      this.Boilers = new List<PCDF.SEDBUK>();
      this.Boilers_Illustrative = new List<PCDF.SEDBUK>();
      this.Solid_Boilers = new List<PCDF.SEDBUK_Solid>();
      this.Solid_Boilers_Illustrative = new List<PCDF.SEDBUK_Solid>();
      this.HeatPumps = new List<PCDF.HeatPump>();
      this.HeatPumps_Illustrative = new List<PCDF.HeatPump>();
      this.WarmAirs = new List<PCDF.WarmAir>();
      this.WarmAirs_Illustrative = new List<PCDF.WarmAir>();
      this.HeatPumps_Sub_Illustrative = new List<PCDF.HeatPump_Sub>();
      this.HeatPumps_Sub = new List<PCDF.HeatPump_Sub>();
      this.CHPs = new List<PCDF.CHP>();
      this.CHPs_Illustrative = new List<PCDF.CHP>();
      this.CHPs_Sub = new List<PCDF.CHP_Sub>();
      this.CHPs_Sub_Illustrative = new List<PCDF.CHP_Sub>();
      this.FGHRSs = new List<PCDF.FGHRS>();
      this.FGHRSs_Illustrative = new List<PCDF.FGHRS>();
      this.FGHRSs_Sub = new List<PCDF.FGHRS_Sub>();
      this.FGHRSs_Sub_Illustrative = new List<PCDF.FGHRS_Sub>();
      this.WWHRSs = new List<PCDF.WWHRS>();
      this.WWHRSs_Illustrative = new List<PCDF.WWHRS>();
      this.InUseMechs = new List<PCDF.InUseMech>();
      this.Products321s = new List<PCDF.Products321>();
      this.Products321s_Sub = new List<PCDF.Products321_Sub>();
      this.Products322s = new List<PCDF.Products322>();
      this.Products322s_Sub = new List<PCDF.Products322_Sub>();
      this.HistoricPrices = new List<PCDF.HistoricTable12SEDBUK>();
      this.EcoMeasures = new List<PCDF.EcoTable>();
      this.PostCodeTable = new List<PCDF.RegionalData>();
      this.HeatingControls = new List<PCDF.HeatingControl>();
      this.HeatingControls_Illistrative = new List<PCDF.HeatingControl>();
      this.HeatingControlFeatures = new List<PCDF.HeatingControlFeature>();
      this.Storage_Heaters = new List<PCDF.Storage_Heater>();
      this.Storage_Heaters_Illustrative = new List<PCDF.Storage_Heater>();
      this.CommunitySchemes = new List<PCDF.CommunityScheme>();
      this.CommunitySchemes_Sub = new List<PCDF.CommunityScheme_Sub>();
      this.Table4a_bs = new List<PCDF.Table4a_B>();
      this.Table4es = new List<PCDF.Table4e>();
      this.Table6es = new List<PCDF.Table6e>();
      this.Table4aWaters = new List<PCDF.Table4aWater>();
      this.Table_P7s = new List<PCDF.Table_P7>();
      this.Table12as = new List<PCDF.Table12a>();
      this.Table12aSEDBUKs = new List<PCDF.Table12SEDBUK>();
      this.Table131s = new List<PCDF.Table131>();
      this.Table181s = new List<PCDF.Table131>();
      this.Table_P1s = new List<PCDF.Table_P1>();
      this.AppendixU = new List<PCDF.RegionalData>();
      this.TableU5 = new List<PCDF.TableU5Constants>();
      string path = File;
      DateTime now = DateAndTime.Now;
      using (StreamReader reader = new StreamReader(path))
      {
        this.Version = this.Get_Version_Number(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Boilers(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Boilers_SomeMore(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Solid_Boilers(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Heat_Pumps(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        try
        {
          this.Populate_WarmAirs(reader);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_CHP(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_FGHRS(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_WWHRS(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_InUseMech(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Products321(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Products322(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Table181(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Create_Table12a(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Create_Historic_Table12a(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_EcoMeasures(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_PostCodes(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Controls(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_ControlFeatures(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_StorageHeaters(reader);
        reader.Close();
      }
      using (StreamReader reader = new StreamReader(path))
      {
        this.Populate_Community(reader);
        reader.Close();
      }
      this.Populate_Table_P1();
      this.Populate_Table_P7();
      this.Populate_Table4aWater();
      this.Populate_Table4e();
      this.Populate_Table6e();
      this.FillTable12aSAP();
      this.Pop_Table4a_B();
      this.Populate_Regions();
      this.Populate_TableU5();
      Console.WriteLine(Conversions.ToString(DateAndTime.Now) + ":" + Conversions.ToString(now));
      this.Populated = true;
    }

    private void Populate_TableU5()
    {
      this.TableU5.Add(new PCDF.TableU5Constants()
      {
        k1 = 26.3f,
        k2 = -38.5f,
        k3 = 14.8f,
        k4 = -16.5f,
        k5 = 27.3f,
        k6 = -11.9f,
        k7 = -1.06f,
        k8 = 0.0872f,
        k9 = -0.191f,
        Orientation = "North"
      });
      this.TableU5.Add(new PCDF.TableU5Constants()
      {
        k1 = 0.165f,
        k2 = -3.68f,
        k3 = 3f,
        k4 = 6.38f,
        k5 = -4.53f,
        k6 = -0.405f,
        k7 = -4.38f,
        k8 = 4.89f,
        k9 = -1.99f,
        Orientation = "NE/NW"
      });
      this.TableU5.Add(new PCDF.TableU5Constants()
      {
        k1 = 1.44f,
        k2 = -2.36f,
        k3 = 1.07f,
        k4 = -0.514f,
        k5 = 1.89f,
        k6 = -1.64f,
        k7 = -0.542f,
        k8 = -0.757f,
        k9 = 0.604f,
        Orientation = "East/West"
      });
      this.TableU5.Add(new PCDF.TableU5Constants()
      {
        k1 = -2.95f,
        k2 = 2.89f,
        k3 = 1.17f,
        k4 = 5.67f,
        k5 = -3.54f,
        k6 = -4.28f,
        k7 = -2.72f,
        k8 = -0.25f,
        k9 = 3.07f,
        Orientation = "SE/SW"
      });
      this.TableU5.Add(new PCDF.TableU5Constants()
      {
        k1 = -0.66f,
        k2 = -0.106f,
        k3 = 2.93f,
        k4 = 3.63f,
        k5 = -0.374f,
        k6 = -7.4f,
        k7 = -2.71f,
        k8 = -0.991f,
        k9 = 4.59f,
        Orientation = "South"
      });
    }

    private void Populate_PostCodes(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "172", false) == 0 & Operators.CompareString(str.Substring(5, 3), "272", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.PostCodeTable.Add(new PCDF.RegionalData()
                {
                  Area = strArray[0],
                  District = strArray[1],
                  _Date = strArray[2],
                  ClimateRegion = checked ((int) Math.Round(Conversion.Val(strArray[3]))),
                  Country = strArray[4],
                  DistrictOrArea = strArray[5],
                  HeightAboveSeaLevel = Conversions.ToDouble(strArray[6]),
                  Latitude = Conversions.ToDouble(strArray[7]),
                  Longitude = Conversions.ToDouble(strArray[8]),
                  TableU1 = {
                    M1 = Conversions.ToDouble(strArray[9]),
                    M2 = Conversions.ToDouble(strArray[10]),
                    M3 = Conversions.ToDouble(strArray[11]),
                    M4 = Conversions.ToDouble(strArray[12]),
                    M5 = Conversions.ToDouble(strArray[13]),
                    M6 = Conversions.ToDouble(strArray[14]),
                    M7 = Conversions.ToDouble(strArray[15]),
                    M8 = Conversions.ToDouble(strArray[16]),
                    M9 = Conversions.ToDouble(strArray[17]),
                    M10 = Conversions.ToDouble(strArray[18]),
                    M11 = Conversions.ToDouble(strArray[19]),
                    M12 = Conversions.ToDouble(strArray[20])
                  },
                  TableU2 = {
                    M1 = Conversions.ToDouble(strArray[21]),
                    M2 = Conversions.ToDouble(strArray[22]),
                    M3 = Conversions.ToDouble(strArray[23]),
                    M4 = Conversions.ToDouble(strArray[24]),
                    M5 = Conversions.ToDouble(strArray[25]),
                    M6 = Conversions.ToDouble(strArray[26]),
                    M7 = Conversions.ToDouble(strArray[27]),
                    M8 = Conversions.ToDouble(strArray[28]),
                    M9 = Conversions.ToDouble(strArray[29]),
                    M10 = Conversions.ToDouble(strArray[30]),
                    M11 = Conversions.ToDouble(strArray[31]),
                    M12 = Conversions.ToDouble(strArray[32])
                  },
                  TableU3 = {
                    M1 = Conversions.ToDouble(strArray[33]),
                    M2 = Conversions.ToDouble(strArray[34]),
                    M3 = Conversions.ToDouble(strArray[35]),
                    M4 = Conversions.ToDouble(strArray[36]),
                    M5 = Conversions.ToDouble(strArray[37]),
                    M6 = Conversions.ToDouble(strArray[38]),
                    M7 = Conversions.ToDouble(strArray[39]),
                    M8 = Conversions.ToDouble(strArray[40]),
                    M9 = Conversions.ToDouble(strArray[41]),
                    M10 = Conversions.ToDouble(strArray[42]),
                    M11 = Conversions.ToDouble(strArray[43]),
                    M12 = Conversions.ToDouble(strArray[44])
                  }
                });
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_EcoMeasures(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "161", false) == 0 & Operators.CompareString(str.Substring(5, 3), "261", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.EcoMeasures.Add(new PCDF.EcoTable()
                {
                  ImprovementType = strArray[0],
                  LifeTime = Conversions.ToInteger(strArray[1]),
                  EligibleCero = (PCDF.EcoTable.Eligibility) checked ((int) Math.Round(Conversion.Val(strArray[2]))),
                  EligibleCsco = (PCDF.EcoTable.Eligibility) checked ((int) Math.Round(Conversion.Val(strArray[3]))),
                  EligibleHhcro = (PCDF.EcoTable.Eligibility) checked ((int) Math.Round(Conversion.Val(strArray[4]))),
                  InUseFactor = Conversion.Val(strArray[5]),
                  EntryDate = strArray[6]
                });
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_StorageHeaters(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "391", false) == 0 & Operators.CompareString(str.Substring(5, 3), "491", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.Storage_Heater storageHeater = new PCDF.Storage_Heater();
                storageHeater.ID = strArray[0];
                storageHeater.ManuRef = strArray[1];
                storageHeater.Status = strArray[2];
                storageHeater.DBEntry = strArray[3];
                storageHeater.ManuName = strArray[4];
                storageHeater.BrandName = strArray[5];
                storageHeater.ModelName = strArray[6];
                storageHeater.ModelQualifier = strArray[7];
                storageHeater.FirstYear = strArray[8];
                storageHeater.FinalYear = strArray[9];
                storageHeater.StorageCapacity = strArray[10];
                storageHeater.OutputPower = strArray[11];
                storageHeater.BoostOutput = strArray[12];
                storageHeater.HeatRetention = strArray[13];
                storageHeater.HighHeatRetention = strArray[14];
                if (storageHeater.Status.Equals("1"))
                  this.Storage_Heaters_Illustrative.Add(storageHeater);
                else
                  this.Storage_Heaters.Add(storageHeater);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Controls(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "371", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.HeatingControl heatingControl = new PCDF.HeatingControl();
                heatingControl.Index = strArray[0];
                heatingControl.ManuRef = strArray[1];
                heatingControl.ProductType = strArray[2];
                heatingControl._Date = strArray[3];
                heatingControl.ManuName = strArray[4];
                heatingControl.Brand = strArray[5];
                heatingControl.Model = strArray[6];
                heatingControl.Qualifier = strArray[7];
                heatingControl.FirstYear = strArray[8];
                heatingControl.FinalYear = strArray[9];
                heatingControl.ControlType = strArray[10];
                heatingControl.HeatingCategory = strArray[11];
                heatingControl.Fuel = strArray[12];
                heatingControl.HeatGeneratorControl = strArray[13];
                heatingControl.EfficiencyAdjustment = strArray[14];
                heatingControl.HoursHeating = strArray[15];
                heatingControl.DelayedStart = strArray[16];
                if (heatingControl.ProductType.Equals("1"))
                {
                  this.HeatingControls_Illistrative.Add(heatingControl);
                  this.HeatingControls.Add(heatingControl);
                }
                else
                  this.HeatingControls.Add(heatingControl);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_ControlFeatures(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "372", false) == 0 & Operators.CompareString(str.Substring(5, 3), "472", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.HeatingControlFeature heatingControlFeature = new PCDF.HeatingControlFeature();
                heatingControlFeature.BitNumber = strArray[0];
                heatingControlFeature.Description = strArray[1];
                if (strArray.Length > 2)
                  heatingControlFeature._Date = strArray[2];
                this.HeatingControlFeatures.Add(heatingControlFeature);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Table181(StreamReader reader)
    {
      string Right = "283";
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 3)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "181", false) == 0 & Operators.CompareString(str.Substring(5, 3), Right, false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.Table131 table131 = new PCDF.Table131();
                table131.Ref = strArray[0];
                table131.Rec1 = strArray[1];
                table131.Range1 = strArray[2];
                table131.Cost_Type = strArray[3];
                table131.A_low = strArray[4];
                table131.B_low = strArray[5];
                table131.A_High = strArray[6];
                table131.B_High = strArray[7];
                table131.Lifetime = strArray[8];
                table131.GD_cost = strArray[9];
                table131.in_GD = strArray[10];
                table131.In_use = strArray[11];
                table131.In_Use_OA = strArray[12];
                table131.min_SAP = strArray[13];
                table131.DBEntryUpdated = strArray[14];
                this.Table131s.Add(table131);
                this.Table181s.Add(table131);
              }
              else
                break;
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Products322(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "322", false) == 0 & (Operators.CompareString(str.Substring(5, 3), "424", false) == 0 | Operators.CompareString(str.Substring(5, 3), "427", false) == 0))
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.Products322s.Add(new PCDF.Products322()
                {
                  ID = strArray[0],
                  RefNo = strArray[1],
                  ProductType = strArray[2],
                  Date1 = strArray[3],
                  Manufacturer = strArray[4],
                  Brand = strArray[5],
                  Model = strArray[6],
                  ModelQualifier = strArray[7],
                  FirstManu = strArray[8],
                  FinManu = strArray[9],
                  MainType = strArray[10],
                  DuctingType = strArray[11],
                  NumbConfigs = strArray[12]
                });
                int num = checked (strArray.Length - 1);
                int index = 13;
                while (index <= num)
                {
                  PCDF.Products322_Sub products322Sub = new PCDF.Products322_Sub();
                  try
                  {
                    products322Sub.Ref = strArray[0];
                    products322Sub.Configuration = strArray[index];
                    products322Sub.TestFlowRate = strArray[checked (index + 1)];
                    products322Sub.FanSpeed = strArray[checked (index + 2)];
                    products322Sub.SFP = strArray[checked (index + 3)];
                    this.Products322s_Sub.Add(products322Sub);
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                  }
                  checked { index += 4; }
                }
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Products321(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "323", false) == 0 & Operators.CompareString(str.Substring(5, 3), "426", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.Products321s.Add(new PCDF.Products321()
                {
                  ID = strArray[0],
                  RefNo = strArray[1],
                  ProductType = strArray[2],
                  Date1 = strArray[3],
                  Manufacturer = strArray[4],
                  Brand = strArray[5],
                  Model = strArray[6],
                  ModelQualifier = strArray[7],
                  FirstManu = strArray[8],
                  FinManu = strArray[9],
                  MainType = strArray[10],
                  IntegralOnly = strArray[11],
                  DuctingType = strArray[12],
                  TestDuctSize = strArray[13],
                  SummerByPass = strArray[14],
                  NoofExhausts = strArray[15],
                  TestFlowRates = strArray[16]
                });
                int num = checked (strArray.Length - 1);
                int index = 17;
                while (index <= num)
                {
                  PCDF.Products321_Sub products321Sub = new PCDF.Products321_Sub();
                  try
                  {
                    products321Sub.Ref = strArray[0];
                    products321Sub.AdditionalWetRoom = strArray[index];
                    products321Sub.TestFlowRate = strArray[checked (index + 1)];
                    products321Sub.FanSpeed = strArray[checked (index + 2)];
                    products321Sub.ApplicableFlowRate = strArray[checked (index + 3)];
                    products321Sub.SFP = strArray[checked (index + 4)];
                    products321Sub.HeatExchangerEfficiency = strArray[checked (index + 5)];
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                  }
                  this.Products321s_Sub.Add(products321Sub);
                  checked { index += 6; }
                }
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Community(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "501", false) == 0 & Operators.CompareString(str.Substring(5, 3), "601", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.CommunitySchemes.Add(new PCDF.CommunityScheme()
                {
                  ID = strArray[0],
                  HeatNetworkVersion = strArray[1],
                  DBEntry = strArray[2],
                  DescriptionofNetwork = strArray[3],
                  ValidityEndDate = strArray[4],
                  CommunityHeatNetwork = strArray[5],
                  PostcodeEnergyCentre = strArray[6],
                  Locality = strArray[7],
                  TownName = strArray[8],
                  AdministrativeArea = strArray[9],
                  DateInitialOperation = strArray[10],
                  TotNumbDwellings = strArray[11],
                  NumberFlats = strArray[12],
                  NonDomFloorArea = strArray[13],
                  TotNumbExistDwellings = strArray[14],
                  ServiceProvision = strArray[15],
                  DataType = strArray[16],
                  Year = strArray[17],
                  HeatMetering = strArray[18],
                  TotalMWhHeatNetwork = strArray[19],
                  TotalMWhHeatDelivered = strArray[20],
                  IndividualDwellingHeatMetering = strArray[21],
                  TotalMWhHeatperAnnum = strArray[22],
                  RouteLength = strArray[23],
                  LinearLoss = strArray[24],
                  DistributionLossFactor = strArray[25],
                  PumpElecEnergy = strArray[26],
                  PumpElecEnergyPerDwelling = strArray[27],
                  CarbonDioxIntensity = strArray[28],
                  PrimaryEnergyFactor = strArray[29]
                });
                int num = checked (strArray.Length - 1);
                int index = 31;
                while (index <= num)
                {
                  PCDF.CommunityScheme_Sub communitySchemeSub = new PCDF.CommunityScheme_Sub();
                  communitySchemeSub.ID = strArray[0];
                  communitySchemeSub.NumbHeatSources = strArray[30];
                  communitySchemeSub.HeatSourceType = strArray[index];
                  communitySchemeSub.CommunityFuel = strArray[checked (index + 1)];
                  communitySchemeSub.FuelDescription = strArray[checked (index + 2)];
                  communitySchemeSub.HeatEfficiency = strArray[checked (index + 3)];
                  communitySchemeSub.PowerEfficiency = strArray[checked (index + 4)];
                  communitySchemeSub.HeatFraction = strArray[checked (index + 5)];
                  if (Conversions.ToDouble(communitySchemeSub.CommunityFuel) == 99.0)
                  {
                    communitySchemeSub.CO2Factor = strArray[checked (index + 6)];
                    communitySchemeSub.EnergyFactor = strArray[checked (index + 7)];
                  }
                  this.CommunitySchemes_Sub.Add(communitySchemeSub);
                  checked { index += 8; }
                }
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_InUseMech(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "329", false) == 0 & Operators.CompareString(str.Substring(5, 3), "430", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.InUseMechs.Add(new PCDF.InUseMech()
                {
                  SystemType = strArray[0],
                  FlexibleDuctsAdj1 = strArray[1],
                  RigidDuctsAdj1 = strArray[2],
                  NoDuctsAdj1 = strArray[3],
                  UninsulatedDuctsAdj1 = strArray[4],
                  InsulatedDuctsAdj1 = strArray[5],
                  FlexibleDuctsAdj2 = strArray[6],
                  RigidDuctsAdj2 = strArray[7],
                  NoDuctsAdj2 = strArray[8],
                  UninsulatedDuctsAdj2 = strArray[9],
                  InsulatedDuctsAdj2 = strArray[10],
                  Date1 = strArray[11]
                });
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private string Get_Version_Number(StreamReader reader)
    {
      string versionNumber;
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        if (str.Length > 3 && Operators.CompareString(str.Substring(1, 3), "001", false) == 0)
        {
          string[] strArray = str.Split(',');
          this.VersionDate = new DateTime(checked ((int) Math.Round(Conversion.Val(strArray[2]))), checked ((int) Math.Round(Conversion.Val(strArray[3]))), checked ((int) Math.Round(Conversion.Val(strArray[4]))));
          versionNumber = str.Substring(5, 3);
          break;
        }
      }
      return versionNumber;
    }

    private void Populate_Boilers(StreamReader reader)
    {
      bool flag1 = false;
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag2;
        if (str.Length > 4)
        {
          string Left = str.Substring(0, 8);
          if (!flag2 && Operators.CompareString(Left, "$105,210", false) == 0)
            flag2 = true;
        }
        if (flag2)
        {
          bool flag3;
          if (flag3)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.SEDBUK sedbuk = new PCDF.SEDBUK();
                sedbuk.ID = strArray[0];
                sedbuk.RefNo = strArray[1];
                sedbuk.ProductType = strArray[2];
                sedbuk.EntryUpdate = strArray[3];
                sedbuk.CurrManu = strArray[5];
                sedbuk.BrandName = strArray[5];
                sedbuk.ModelName = strArray[6];
                sedbuk.ModelQualifier = strArray[7];
                sedbuk.BoilerID = strArray[8];
                sedbuk.FirstManu = strArray[9];
                sedbuk.FinManu = strArray[10];
                sedbuk.Fuel = strArray[11];
                sedbuk.MountPosition = strArray[12];
                sedbuk.ExposureRating = strArray[13];
                sedbuk.MainType = strArray[14];
                sedbuk.SubType = strArray[15];
                sedbuk.SubTypeTable = strArray[16];
                sedbuk.SubTypeIndex = strArray[17];
                sedbuk.Condensing = strArray[18];
                sedbuk.FlueType = strArray[19];
                sedbuk.FanAssist = strArray[20];
                if (Operators.CompareString(strArray[19], "0", false) == 0)
                  flag1 = true;
                if (flag1)
                {
                  sedbuk.FanAssist = "2";
                  sedbuk.FlueType = "2";
                  flag1 = false;
                }
                sedbuk.BoilPowBot = strArray[21];
                sedbuk.BoilPowTop = strArray[22];
                sedbuk.EngEffClss = strArray[23];
                sedbuk.AnnualEff = strArray[24];
                sedbuk.WinterEff = strArray[25];
                sedbuk.SummerEff = strArray[26];
                sedbuk.HotWaterEff = strArray[27];
                sedbuk.HotWaterEff2 = strArray[28];
                sedbuk.SAPEff = strArray[29];
                sedbuk.EffCat = strArray[30];
                sedbuk.LPGTstGas = strArray[31];
                sedbuk.LPGTstCorrection = strArray[32];
                sedbuk.SAPEqUsed = strArray[33];
                sedbuk.Ignition = strArray[34];
                sedbuk.BurnCont = strArray[35];
                sedbuk.ElPowFire = strArray[36];
                sedbuk.ElPowNtFire = strArray[37];
                sedbuk.StrType = strArray[38];
                sedbuk.StrLoss = strArray[39];
                sedbuk.StrSep = strArray[40];
                sedbuk.StrVol = strArray[41];
                sedbuk.StrSolarVol = strArray[42];
                sedbuk.StrInsThk = strArray[43];
                sedbuk.StrInsType = strArray[44];
                sedbuk.StrTemp = strArray[45];
                sedbuk.StrHtLoss = strArray[46];
                sedbuk.SeperateDHWTests = strArray[47];
                sedbuk.FuelEnergyT1 = strArray[48];
                sedbuk.ElecEnergyT1 = strArray[49];
                sedbuk.RejEnergy_r1T1 = strArray[50];
                sedbuk.StoLossF1 = strArray[51];
                sedbuk.FuelEnergyT2 = strArray[52];
                sedbuk.ElecEnergyT2 = strArray[53];
                sedbuk.RejEnergy_r2T2 = strArray[54];
                sedbuk.StoLossF2 = strArray[55];
                sedbuk.StoLossF3 = strArray[56];
                sedbuk.KpHtFac = strArray[57];
                sedbuk.KpHtTmr = strArray[58];
                sedbuk.KpHtElcHtr = strArray[59];
                sedbuk.ControlCapabilities = strArray[60];
                sedbuk.CaseLoss = "";
                sedbuk.FullOutPower = "";
                sedbuk.Type = "0";
                if (sedbuk.ProductType.Equals("1"))
                  this.Boilers_Illustrative.Add(sedbuk);
                else
                  this.Boilers.Add(sedbuk);
              }
              else
              {
                flag2 = false;
                flag3 = false;
              }
            }
          }
          else
            flag3 = true;
        }
      }
    }

    private void Populate_Boilers_SomeMore(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string Left1 = streamReader.ReadLine();
        bool flag1;
        if (Left1.Length > 4)
        {
          string Left2 = Left1.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left2, "131", false) == 0 & Operators.CompareString(Left1.Substring(5, 3), "233", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!Left1.StartsWith("#"))
            {
              if (!Left1.StartsWith("$") & (uint) Operators.CompareString(Left1, "", false) > 0U)
              {
                string[] strArray = Left1.Split(',');
                PCDF.SEDBUK sedbuk = new PCDF.SEDBUK();
                sedbuk.ID = strArray[0];
                sedbuk.RefNo = strArray[1];
                sedbuk.ProductType = strArray[2];
                sedbuk.EntryUpdate = strArray[3];
                sedbuk.CurrManu = strArray[4];
                sedbuk.BrandName = strArray[5];
                sedbuk.ModelName = strArray[6];
                sedbuk.ModelQualifier = strArray[7];
                sedbuk.BoilerID = strArray[8];
                sedbuk.FirstManu = strArray[9];
                sedbuk.FinManu = strArray[10];
                sedbuk.Fuel = strArray[11];
                sedbuk.MainType = strArray[12];
                sedbuk.Condensing = strArray[13];
                sedbuk.FlueType = strArray[14];
                sedbuk.FanAssist = strArray[15];
                sedbuk.BoilPowBot = strArray[16];
                sedbuk.BoilPowTop = strArray[17];
                sedbuk.CaseLoss = strArray[18];
                sedbuk.FullOutPower = strArray[19];
                sedbuk.EngEffClss = strArray[20];
                sedbuk.AnnualEff = strArray[21];
                sedbuk.WinterEff = strArray[22];
                sedbuk.SummerEff = strArray[23];
                sedbuk.HotWaterEff = strArray[24];
                sedbuk.SAPEff = strArray[25];
                sedbuk.EffCat = strArray[26];
                sedbuk.LPGTstGas = strArray[27];
                sedbuk.SAPEqUsed = strArray[28];
                sedbuk.Ignition = strArray[29];
                sedbuk.BurnCont = strArray[30];
                sedbuk.ElPowFire = strArray[31];
                sedbuk.ElPowNtFire = strArray[32];
                sedbuk.Type = Conversions.ToString(1);
                if (sedbuk.ProductType.Equals("1"))
                  this.Boilers_Illustrative.Add(sedbuk);
                else
                  this.Boilers.Add(sedbuk);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Solid_Boilers(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "122", false) == 0 & Operators.CompareString(str.Substring(5, 3), "224", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.SEDBUK_Solid sedbukSolid = new PCDF.SEDBUK_Solid();
                try
                {
                  sedbukSolid.ID = strArray[0];
                  sedbukSolid.RefNo = strArray[1];
                  sedbukSolid.ProductType = strArray[2];
                  sedbukSolid.EntryUpdate = strArray[3];
                  sedbukSolid.Manu = strArray[4];
                  sedbukSolid.BrandName = strArray[5];
                  sedbukSolid.ModelName = strArray[6];
                  sedbukSolid.ModelQualifier = strArray[7];
                  sedbukSolid.ProductID = strArray[8];
                  sedbukSolid.FirstManu = strArray[9];
                  sedbukSolid.FinManu = strArray[10];
                  sedbukSolid.Fuel = strArray[11];
                  sedbukSolid.MainType = strArray[12];
                  sedbukSolid.Flue = strArray[13];
                  sedbukSolid.FanAssist = strArray[14];
                  sedbukSolid.FuelFeed = strArray[15];
                  sedbukSolid.BoilPowBot = strArray[16];
                  sedbukSolid.BoilPowTop = strArray[17];
                  sedbukSolid.BoilPowMinBurn = strArray[18];
                  sedbukSolid.EngEffClss = strArray[19];
                  sedbukSolid.SAPEff = strArray[20];
                  sedbukSolid.EffCat = strArray[21];
                  sedbukSolid.input_full = strArray[22];
                  sedbukSolid.water_full = strArray[23];
                  sedbukSolid.room_full = strArray[24];
                  sedbukSolid.input_part = strArray[25];
                  sedbukSolid.water_part = strArray[26];
                  sedbukSolid.room_part = strArray[27];
                  sedbukSolid.ple_test = strArray[28];
                  sedbukSolid.Burner = strArray[29];
                  sedbukSolid.Elect_1 = strArray[30];
                  sedbukSolid.Elect_2 = strArray[31];
                  sedbukSolid.Add_Vent = strArray[32];
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
                if (sedbukSolid.ProductType.Equals("1"))
                  this.Solid_Boilers_Illustrative.Add(sedbukSolid);
                else
                  this.Solid_Boilers.Add(sedbukSolid);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_Heat_Pumps(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "362", false) == 0 & Operators.CompareString(str.Substring(5, 3), "464", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                if (strArray.Length > 25 | Operators.CompareString(strArray[0], "135000", false) == 0)
                {
                  PCDF.HeatPump heatPump = new PCDF.HeatPump();
                  heatPump.ID = strArray[0];
                  if (Operators.CompareString(heatPump.ID, "135000", false) == 0)
                    Console.Write("");
                  heatPump.ManuRef = strArray[1];
                  heatPump.PropertyType = strArray[2];
                  heatPump.EntryUpdate = strArray[3];
                  heatPump.APM = strArray[4];
                  heatPump.Manu = strArray[5];
                  heatPump.Brand = strArray[6];
                  heatPump.Model = strArray[7];
                  heatPump.Qualifier = strArray[8];
                  heatPump._1st_year = strArray[9];
                  heatPump.Last_Year = strArray[10];
                  heatPump.DataQty = strArray[11];
                  heatPump.Fuel = strArray[12];
                  heatPump.Emitter_Type = strArray[13];
                  string emitterType = heatPump.Emitter_Type;
                  if (Operators.CompareString(emitterType, "1", false) != 0)
                  {
                    if (Operators.CompareString(emitterType, "2", false) != 0)
                    {
                      if (Operators.CompareString(emitterType, "3", false) != 0)
                      {
                        if (Operators.CompareString(emitterType, "4", false) == 0)
                          heatPump.Qualifier = Operators.CompareString(heatPump.Qualifier, "", false) == 0 ? "Warm Air System" : heatPump.Qualifier + " - Warm Air System";
                      }
                      else
                        heatPump.Qualifier = Operators.CompareString(heatPump.Qualifier, "", false) == 0 ? "Underfloor" : heatPump.Qualifier + " - Underfloor";
                    }
                    else
                      heatPump.Qualifier = Operators.CompareString(heatPump.Qualifier, "", false) == 0 ? "Fan Coils Units" : heatPump.Qualifier + " - Fan Coils Units";
                  }
                  else
                    heatPump.Qualifier = Operators.CompareString(heatPump.Qualifier, "", false) == 0 ? "Radiators" : heatPump.Qualifier + " - Radiators";
                  heatPump.Flue_Type = strArray[14];
                  heatPump.Heat_Source = strArray[15];
                  heatPump.ServiceProvision = strArray[16];
                  heatPump.HWvessel = strArray[17];
                  heatPump.VesselVol = strArray[18];
                  heatPump.VesselHeat_Loss = strArray[19];
                  heatPump.VesselHeat_Exchanger = strArray[20];
                  heatPump.Energy_eff_Class = strArray[21];
                  heatPump.WHEffSch2 = strArray[22];
                  heatPump.NetElecConsumedSch2 = strArray[23];
                  heatPump.WHEffSch3 = strArray[24];
                  heatPump.NetElecConsumedSch3 = strArray[25];
                  heatPump.ControlCapabilities = strArray[26];
                  if (strArray.Length > 27)
                  {
                    heatPump.Reversible = strArray[27];
                    heatPump.ERR = strArray[28];
                    heatPump.Max_Output = strArray[29];
                    heatPump.Heating_Duration = strArray[30];
                    heatPump.MEV_MVHR = strArray[31];
                    heatPump.Compen_Effect = strArray[32];
                    heatPump.SepCirculator = strArray[33];
                    heatPump.No_AirFlowrates = strArray[34];
                    heatPump.AirFlow1 = strArray[35];
                    heatPump.AirFlow2 = strArray[36];
                    heatPump.AirFlow3 = strArray[37];
                    heatPump.No_PlantSize = strArray[38];
                  }
                  if (heatPump.PropertyType.Equals("1"))
                    this.HeatPumps_Illustrative.Add(heatPump);
                  else
                    this.HeatPumps.Add(heatPump);
                  int num = checked (strArray.Length - 1);
                  int index = 39;
                  while (index <= num)
                  {
                    PCDF.HeatPump_Sub heatPumpSub = new PCDF.HeatPump_Sub();
                    heatPumpSub.ID = strArray[0];
                    heatPumpSub.PlantSize_Ratio = strArray[index];
                    heatPumpSub.SpaceHeating = strArray[checked (index + 1)];
                    heatPumpSub.Specific_Elec_Consumed = strArray[checked (index + 2)];
                    try
                    {
                      heatPumpSub.Run_hours = strArray[checked (index + 3)];
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                    }
                    if (heatPump.PropertyType.Equals("1"))
                      this.HeatPumps_Sub_Illustrative.Add(heatPumpSub);
                    else
                      this.HeatPumps_Sub.Add(heatPumpSub);
                    checked { index += 4; }
                  }
                }
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_WarmAirs(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "381", false) == 0 & Operators.CompareString(str.Substring(5, 3), "481", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.WarmAir warmAir = new PCDF.WarmAir();
                warmAir.ID = strArray[0];
                warmAir.ManuRef = strArray[1];
                warmAir.Status = strArray[2];
                warmAir.DBentry = strArray[3];
                warmAir.Manuname = strArray[4];
                warmAir.Brand_name = strArray[5];
                warmAir.Model_name = strArray[6];
                warmAir.Model_qualifier = strArray[7];
                warmAir.First_year_of_manufacture = strArray[8];
                warmAir.Final_year_of_manufacture = strArray[9];
                warmAir.Fuel = strArray[10];
                warmAir.Mounting_position = strArray[11];
                warmAir.Heat_exchanger_type = strArray[12];
                warmAir.Condensing = strArray[13];
                warmAir.Flue_type = strArray[14];
                warmAir.Fan_assistance = strArray[15];
                warmAir.Fan_position = strArray[16];
                warmAir.Flow_direction = strArray[17];
                warmAir.Output_power_bottom = strArray[18];
                warmAir.Output_power_top = strArray[19];
                warmAir.Energy_efficiency_class = strArray[20];
                warmAir.Integral_warm_air_distribution_fan = strArray[21];
                warmAir.Specific_fan_power = strArray[22];
                warmAir.Water_pump = strArray[23];
                warmAir.Pump_electricity = strArray[24];
                warmAir.Ignition = strArray[25];
                warmAir.Burner_control = strArray[26];
                warmAir.Maximum_firing_rate = strArray[27];
                warmAir.Minimum_firing_rate = strArray[28];
                warmAir.Measured_efficiency_at_full_load = strArray[29];
                warmAir.Measured_efficiency_at_minimum_load = strArray[30];
                warmAir.Seasonal_heating_efficiency = strArray[31];
                warmAir.Electrical_power_while_firing = strArray[32];
                warmAir.Electrical_power_while_not_firing = strArray[33];
                warmAir.Hot_water_service = strArray[34];
                if (strArray.Length > 37 && warmAir.Hot_water_service.Equals("1"))
                {
                  warmAir.Hot_water_service_type = strArray[35];
                  warmAir.Store_volume = strArray[37];
                  warmAir.Store_insulation_thickness = strArray[38];
                  warmAir.Store_loss_factor = strArray[39];
                  warmAir.Water_heating_efficiency = strArray[40];
                  warmAir.Separate_DHW_tests = strArray[41];
                  try
                  {
                    warmAir.Fuel_energy_for_HW_test_1 = strArray[42];
                    warmAir.Electrical_energy_for_HW_test_1 = strArray[43];
                    warmAir.Rejected_energy_r1_in_HW_test_1 = strArray[44];
                    warmAir.Storage_loss_factor_F1 = strArray[45];
                    warmAir.Fuel_energy_for_HW_test_2 = strArray[46];
                    warmAir.Electrical_energy_for_HW_test_2 = strArray[47];
                    warmAir.Rejected_energy_r2_in_HW_test_2 = strArray[48];
                    warmAir.Storage_loss_factor_F2 = strArray[49];
                    warmAir.Rejected_factor_F3 = strArray[50];
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                  }
                }
                if (warmAir.Status.Equals("1"))
                  this.WarmAirs_Illustrative.Add(warmAir);
                else
                  this.WarmAirs.Add(warmAir);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_CHP(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "143", false) == 0 & Operators.CompareString(str.Substring(5, 3), "243", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                if (strArray.Length > 25)
                {
                  PCDF.CHP chp = new PCDF.CHP();
                  chp.ID = strArray[0];
                  chp.ManuRef = strArray[1];
                  chp.ProductType = strArray[2];
                  chp.EntryUpdate = strArray[3];
                  chp.APM = strArray[4];
                  chp.Manu = strArray[5];
                  chp.Brand = strArray[6];
                  chp.Model = strArray[7];
                  chp.Qualifier = strArray[8];
                  chp._1st_year = strArray[9];
                  chp.Last_Year = strArray[10];
                  chp.Fuel = strArray[11];
                  chp.Condensing = strArray[12];
                  chp.Flue_Type = strArray[13];
                  chp.ServiceProvision = strArray[14];
                  chp.HWVessel = strArray[15];
                  chp._Class = strArray[16];
                  chp.WHEffSch2 = strArray[17];
                  chp.NetElecConsumedSch2 = strArray[18];
                  chp.WHEffSch3 = strArray[19];
                  chp.NetElecConsumedSch3 = strArray[20];
                  chp.CogenPPowerBottom = strArray[21];
                  chp.CogenPPowerTop = strArray[22];
                  chp.HeatingDuration = strArray[23];
                  chp.SepCirculator = strArray[24];
                  chp.PSR_Numb = strArray[25];
                  if (chp.ProductType.Equals("1"))
                    this.CHPs_Illustrative.Add(chp);
                  else
                    this.CHPs.Add(chp);
                  int num = checked (strArray.Length - 1);
                  int index = 26;
                  while (index <= num)
                  {
                    PCDF.CHP_Sub chpSub = new PCDF.CHP_Sub();
                    chpSub.ID = strArray[0];
                    chpSub.PSR = strArray[index];
                    chpSub.Efficiency = strArray[checked (index + 1)];
                    chpSub.ElecConsumed = strArray[checked (index + 2)];
                    if (chp.ProductType.Equals("1"))
                      this.CHPs_Sub_Illustrative.Add(chpSub);
                    else
                      this.CHPs_Sub.Add(chpSub);
                    checked { index += 3; }
                  }
                }
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_CHP_Illustrative(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        bool flag2;
        if (str.Length > 3)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 & !flag2 && Operators.CompareString(Left, "143", false) == 0 & Operators.CompareString(str.Substring(5, 3), "243", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag3;
          if (flag3)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                if (strArray.Length > 25)
                {
                  this.CHPs_Illustrative.Add(new PCDF.CHP()
                  {
                    ID = strArray[0],
                    ManuRef = strArray[1],
                    EntryUpdate = strArray[3],
                    APM = strArray[4],
                    Manu = strArray[5],
                    Brand = strArray[6],
                    Model = strArray[7],
                    Qualifier = strArray[8],
                    _1st_year = strArray[9],
                    Last_Year = strArray[10],
                    Fuel = strArray[11],
                    Condensing = strArray[12],
                    Flue_Type = strArray[13],
                    ServiceProvision = strArray[14],
                    HWVessel = strArray[15],
                    _Class = strArray[16],
                    WHEffSch2 = strArray[17],
                    NetElecConsumedSch2 = strArray[18],
                    WHEffSch3 = strArray[19],
                    NetElecConsumedSch3 = strArray[20],
                    CogenPPowerBottom = strArray[21],
                    CogenPPowerTop = strArray[22],
                    HeatingDuration = strArray[23],
                    SepCirculator = strArray[24],
                    PSR_Numb = strArray[25]
                  });
                  int num = checked (strArray.Length - 1);
                  int index = 26;
                  while (index <= num)
                  {
                    PCDF.CHP_Sub chpSub = new PCDF.CHP_Sub();
                    try
                    {
                      chpSub.ID = strArray[0];
                      chpSub.PSR = strArray[index];
                      chpSub.Efficiency = strArray[checked (index + 1)];
                      chpSub.ElecConsumed = strArray[checked (index + 2)];
                      this.CHPs_Sub_Illustrative.Add(chpSub);
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                    }
                    checked { index += 3; }
                  }
                }
              }
              else
              {
                flag2 = true;
                break;
              }
            }
          }
          else
            flag3 = true;
        }
      }
    }

    private void Populate_FGHRS(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "313", false) == 0 & Operators.CompareString(str.Substring(5, 3), "413", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                try
                {
                  PCDF.FGHRS fghrs = new PCDF.FGHRS();
                  fghrs.ID = strArray[0];
                  fghrs.RefNo = strArray[1];
                  fghrs.ProductType = strArray[2];
                  fghrs._Date = strArray[3];
                  fghrs.Manufacturer = strArray[4];
                  fghrs.Brand = strArray[5];
                  fghrs.Model = strArray[6];
                  fghrs.Model_Qualifier = strArray[7];
                  fghrs.FirstManu = strArray[8];
                  fghrs.FinManu = strArray[9];
                  fghrs.ApplicableFuel = strArray[10];
                  fghrs.TestFuel = strArray[11];
                  fghrs.ApplicableBoilerTypes = strArray[12];
                  fghrs.IntegralOnly = strArray[13];
                  fghrs.HeatStore = strArray[14];
                  fghrs.HeatStoreTV = strArray[15];
                  fghrs.HeatStoreRV = strArray[16];
                  fghrs.HeatStoreLR = strArray[17];
                  fghrs.DirectTHR = strArray[18];
                  fghrs.DirectUHR = strArray[19];
                  fghrs.PowerCon = strArray[20];
                  fghrs.PhotovoltaicModule = strArray[21];
                  fghrs.CableLoss = strArray[22];
                  fghrs.NoofEquations = strArray[23];
                  if (fghrs.ProductType.Equals("1"))
                    this.FGHRSs_Illustrative.Add(fghrs);
                  else
                    this.FGHRSs.Add(fghrs);
                  int num = checked (strArray.Length - 1);
                  int index = 24;
                  while (index <= num)
                  {
                    PCDF.FGHRS_Sub fghrsSub = new PCDF.FGHRS_Sub();
                    fghrsSub.ID = strArray[0];
                    fghrsSub.SpaceHR = strArray[index];
                    fghrsSub.CoefficientA1 = strArray[checked (index + 1)];
                    fghrsSub.CoefficientB1 = strArray[checked (index + 2)];
                    fghrsSub.CoefficientC1 = strArray[checked (index + 3)];
                    fghrsSub.CoefficientA2 = strArray[checked (index + 4)];
                    fghrsSub.CoefficientB2 = strArray[checked (index + 5)];
                    fghrsSub.CoefficientC2 = strArray[checked (index + 6)];
                    if (fghrs.ProductType.Equals("1"))
                      this.FGHRSs_Sub_Illustrative.Add(fghrsSub);
                    else
                      this.FGHRSs_Sub.Add(fghrsSub);
                    checked { index += 7; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  Exception exception = ex;
                  if (!SAP_Module.dev_mode)
                    throw new Exception(exception.Message, exception.InnerException);
                  ProjectData.ClearProjectError();
                }
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Populate_WWHRS(StreamReader reader)
    {
      StreamReader streamReader = reader;
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        bool flag1;
        if (str.Length > 4)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "353", false) == 0 & Operators.CompareString(str.Substring(5, 3), "453", false) == 0)
            flag1 = true;
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                PCDF.WWHRS wwhrs = new PCDF.WWHRS();
                wwhrs.ID = strArray[0];
                wwhrs.RefNo = strArray[1];
                wwhrs.ProductType = strArray[2];
                wwhrs._Date = strArray[3];
                wwhrs.Manufacturer = strArray[4];
                wwhrs.Brand = strArray[5];
                wwhrs.Model = strArray[6];
                wwhrs.Model_Qualifier = strArray[7];
                wwhrs.FirstManu = strArray[8];
                wwhrs.FinManu = strArray[9];
                wwhrs.InstantaneousStorage = strArray[10];
                wwhrs.SystemType = strArray[11];
                wwhrs.StorageType = strArray[12];
                wwhrs.Efficiency = strArray[13];
                wwhrs.Utilisation_Factor = strArray[14];
                wwhrs.WasteWaterFraction = strArray[15];
                wwhrs.TestDedicatedVolume = strArray[16];
                wwhrs.LowDedicatedVolume = strArray[17];
                wwhrs.HighDedicatedVolume = strArray[18];
                wwhrs.ElectricyConsumption = strArray[19];
                if (wwhrs.ProductType.Equals("1"))
                  this.WWHRSs_Illustrative.Add(wwhrs);
                else
                  this.WWHRSs.Add(wwhrs);
              }
              else
              {
                flag1 = false;
                flag2 = false;
              }
            }
          }
          else
            flag2 = true;
        }
      }
    }

    private void Pop_Table4a_B()
    {
      this.AddRow("699", "No heating system present", "", "Electric heater (assumed)", "", "", "100", "1", "1.0", "0", "Electricity");
      this.AddRow("101", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Regular non-condensing with automatic ignition", "", "74", "64", "", "", "1", "Gas");
      this.AddRow("102", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Regular condensing with automatic ignition", "", "84", "74", "", "", "1", "Gas");
      this.AddRow("103", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Non-condensing combi with automatic ignition", "", "74", "65", "", "", "1", "Gas");
      this.AddRow("104", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Condensing combi with automatic ignition", "", "84", "75", "", "", "1", "Gas");
      this.AddRow("105", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Regular non-condensing with permanent pilot light", "", "70", "60", "", "", "1", "Gas");
      this.AddRow("106", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Regular condensing with permanent pilot light", "", "80", "70", "", "", "1", "Gas");
      this.AddRow("107", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Non-condensing combi with permanent pilot light", "", "70", "61", "", "", "1", "Gas");
      this.AddRow("108", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Condensing combi with permanent pilot light", "", "80", "71", "", "", "1", "Gas");
      this.AddRow("109", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) 1998 or later", "Back boiler to radiators", "", "66", "56", "", "", "1", "Gas");
      this.AddRow("110", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with fan-assisted flue", "Low thermal capacity", "", "73", "63", "", "", "1", "Gas");
      this.AddRow("111", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with fan-assisted flue", "High or unknown thermal capacity", "", "69", "59", "", "", "1", "Gas");
      this.AddRow("112", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with fan-assisted flue", "Combi", "", "71", "62", "", "", "1", "Gas");
      this.AddRow("113", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with fan-assisted flue", "Condensing combi", "", "84", "75", "", "", "1", "Gas");
      this.AddRow("114", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with fan-assisted flue", "Condensing", "", "84", "74", "", "", "1", "Gas");
      this.AddRow("115", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with balanced or open flue", "Wall mounted", "", "66", "56", "", "", "1", "Gas");
      this.AddRow("116", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with balanced or open flue", "Floor mounted, pre 1979", "", "56", "46", "", "", "1", "Gas");
      this.AddRow("117", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with balanced or open flue", "Floor mounted, 1979 to 1997", "", "66", "56", "", "", "1", "Gas");
      this.AddRow("118", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with balanced or open flue", "Combi", "", "66", "57", "", "", "1", "Gas");
      this.AddRow("119", "Boiler systems with radiators or underfloor heating", "Gas boilers (including LPG) pre-1998, with balanced or open flue", "Back boiler to radiators", "", "66", "56", "", "", "1", "Gas");
      this.AddRow("120", "Boiler systems with radiators or underfloor heating", "Combined Primary Storage Units (CPSU) (mains gas and LPG)", "With automatic ignition (non-condensing)", "", "74", "72", "", "", "1", "Gas");
      this.AddRow("121", "Boiler systems with radiators or underfloor heating", "Combined Primary Storage Units (CPSU) (mains gas and LPG)", "With automatic ignition (condensing)", "", "83", "81", "", "", "1", "Gas");
      this.AddRow("122", "Boiler systems with radiators or underfloor heating", "Combined Primary Storage Units (CPSU) (mains gas and LPG)", "With permanent pilot (non-condensing)", "", "70", "68", "", "", "1", "Gas");
      this.AddRow("123", "Boiler systems with radiators or underfloor heating", "Combined Primary Storage Units (CPSU) (mains gas and LPG)", "With permanent pilot (condensing)", "", "79", "77", "", "", "1", "Gas");
      this.AddRow("124", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Standard oil boiler pre-1985", "", "66", "54", "", "", "1", "Oil");
      this.AddRow("125", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Standard oil boiler 1985 to 1997", "", "71", "59", "", "", "1", "Oil");
      this.AddRow("126", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Standard oil boiler, 1998 or later", "", "80", "68", "", "", "1", "Oil");
      this.AddRow("127", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Condensing", "", "84", "72", "", "", "1", "Oil");
      this.AddRow("128", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Combi, pre-1998", "", "71", "62", "", "", "1", "Oil");
      this.AddRow("129", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Combi, 1998 or later", "", "77", "68", "", "", "1", "Oil");
      this.AddRow("130", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Condensing combi", "", "82", "73", "", "", "1", "Oil");
      this.AddRow("131", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Oil room heater with boiler to radiators, pre 2000", "", "66", "54", "", "", "1", "Oil");
      this.AddRow("132", "Boiler systems with radiators or underfloor heating", "Oil boilers", "Oil room heater with boiler to radiators, 2000 or later", "", "71", "59", "", "", "1", "Oil");
      this.AddRow("133", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (mains gas and LPG)", "Single burner with permanent pilot", "", "47", "37", "", "", "1", "Gas");
      this.AddRow("134", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (mains gas and LPG)", "Single burner with automatic ignition", "", "51", "41", "", "", "1", "Gas");
      this.AddRow("135", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (mains gas and LPG)", "Twin burner with permanent pilot (non-condensing) pre 1998", "", "61", "51", "", "", "1", "Gas");
      this.AddRow("136", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (mains gas and LPG)", "Twin burner with automatic ignition (non-condensing) pre 1998", "", "66", "56", "", "", "1", "Gas");
      this.AddRow("137", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (mains gas and LPG)", "Twin burner with permanent pilot (non-condensing) 1998 or later", "", "66", "56", "", "", "1", "Gas");
      this.AddRow("138", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (mains gas and LPG)", "Twin burner with automatic ignition (non-condensing) 1998 or later", "", "71", "61", "", "", "1", "Gas");
      this.AddRow("139", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (oil)", "Single burner", "", "61", "49", "", "", "1", "Oil");
      this.AddRow("140", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (oil)", "Twin burner (non-condensing) pre 1998", "", "71", "59", "", "", "1", "Oil");
      this.AddRow("141", "Boiler systems with radiators or underfloor heating", "Range cooker boilers (oil)", "Twin burner (non-condensing) 1998 or later", "", "76", "64", "", "", "1", "Oil");
      this.AddRow("151", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Manual feed independent boiler in heated space", "", "65", "60", "2", "0.75", "1", "Solid");
      this.AddRow("152", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Manual feed independent boiler in unheated space", "", "60", "55", "2", "0.75", "1", "Solid");
      this.AddRow("153", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Auto (gravity) feed independent boiler in heated space", "", "70", "65", "2", "0.75", "1", "Solid");
      this.AddRow("154", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Auto (gravity) feed independent boiler in unheated space", "", "65", "60", "2", "0.75", "1", "Solid");
      this.AddRow("155", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Wood chip/pellet independent boiler", "", "65", "63", "2", "0.75", "1", "Solid");
      this.AddRow("156", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Open fire with back boiler to radiators", "", "63", "55", "3", "0.50", "1", "Solid");
      this.AddRow("158", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Closed roomheater with boiler to radiators", "", "67", "65", "3", "0.50", "1", "Solid");
      this.AddRow("159", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Stove (pellet-fired) with boiler to radiators", "", "65", "63", "2", "0.75", "1", "Solid");
      this.AddRow("160", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Range cooker boiler (integral oven and boiler)", "", "50", "45", "3", "0.50", "1", "Solid");
      this.AddRow("161", "Boiler systems with radiators or underfloor heating", "Solid fuel boilers", "Range cooker boiler (independent oven and boiler)", "", "60", "55", "3", "0.50", "1", "Solid");
      this.AddRow("191", "Boiler systems with radiators or underfloor heating", "Electric boilers", "Direct acting electric boiler", "", "", "100", "1", "1.0", "1", "Electricity");
      this.AddRow("192", "Boiler systems with radiators or underfloor heating", "Electric boilers", "Electric CPSU in heated space", "", "", "100", "1", "1", "1", "Electricity");
      this.AddRow("193", "Boiler systems with radiators or underfloor heating", "Electric boilers", "Electric dry core storage boiler in heated space", "", "", "100", "2", "0.75", "1", "Electricity");
      this.AddRow("194", "Boiler systems with radiators or underfloor heating", "Electric boilers", "Electric dry core storage boiler in unheated space", "", "", "85", "2", "0.75", "1", "Electricity");
      this.AddRow("195", "Boiler systems with radiators or underfloor heating", "Electric boilers", "Electric water storage boiler in heated space", "", "", "100", "2", "0.75", "1", "Electricity");
      this.AddRow("196", "Boiler systems with radiators or underfloor heating", "Electric boilers", "Electric water storage boiler in unheated space", "", "", "85", "2", "0.75", "1", "Electricity");
      this.AddRow("211", "Heat pumps with radiators or underfloor heating", "Electric heat pumps", "Ground source heat pump with flow temperature <= 35°C", "No", "230", "170", "", "", "2", "Electricity");
      this.AddRow("213", "Heat pumps with radiators or underfloor heating", "Electric heat pumps", "Water source heat pump with flow temperature <= 35°C", "No", "230", "170", "", "", "2", "Electricity");
      this.AddRow("214", "Heat pumps with radiators or underfloor heating", "Electric heat pumps", "Air source heat pump with flow temperature <= 35°C ", "No", "170", "170", "", "", "2", "Electricity");
      this.AddRow("221", "Heat pumps with radiators or underfloor heating", "Electric heat pumps", "Ground source heat pump in other cases", "No", "170", "170", "", "", "2", "Electricity");
      this.AddRow("223", "Heat pumps with radiators or underfloor heating", "Electric heat pumps", "Water source heat pump, in other cases", "No", "170", "170", "", "", "2", "Electricity");
      this.AddRow("224", "Heat pumps with radiators or underfloor heating", "Electric heat pumps", "Air source heat pump in other cases", "No", "170", "170", "", "", "2", "Electricity");
      this.AddRow("215", "Heat pumps with radiators or underfloor heating", "Gas-fired heat pumps", "Ground source heat pump with flow temperature <= 35°C", "No", "120", "84", "", "", "2", "Gas");
      this.AddRow("216", "Heat pumps with radiators or underfloor heating", "Gas-fired heat pumps", "Water source heat pump with flow temperature <= 35°C", "No", "120", "84", "", "", "2", "Gas");
      this.AddRow("217", "Heat pumps with radiators or underfloor heating", "Gas-fired heat pumps", "Air source heat pump with flow temperature <= 35°C", "No", "110", "77", "", "", "2", "Gas");
      this.AddRow("225", "Heat pumps with radiators or underfloor heating", "Gas-fired heat pumps", "Ground source heat pump in other cases", "No", "84", "84", "", "", "2", "Gas");
      this.AddRow("226", "Heat pumps with radiators or underfloor heating", "Gas-fired heat pumps", "Water source heat pump in other cases", "No", "84", "84", "", "", "2", "Gas");
      this.AddRow("227", "Heat pumps with radiators or underfloor heating", "Gas-fired heat pumps", "Air source heat pump in other cases", "No", "77", "77", "", "", "2", "Gas");
      this.AddRow("521", "Heat pumps with warm air distribution", "Electric heat pumps", "Ground source heat pump", "No", "230", "170", "1", "1", "5", "Electricity");
      this.AddRow("523", "Heat pumps with warm air distribution", "Electric heat pumps", "Water source heat pump", "No", "230", "170", "1", "1", "5", "Electricity");
      this.AddRow("524", "Heat pumps with warm air distribution", "Electric heat pumps", "Air source heat pump", "No", "170", "170", "1", "1", "5", "Electricity");
      this.AddRow("525", "Heat pumps with warm air distribution", "Gas-fired heat pumps", "Ground source heat pump", "No", "120", "84", "1", "1", "5", "Gas");
      this.AddRow("526", "Heat pumps with warm air distribution", "Gas-fired heat pumps", "Water source heat pump", "No", "120", "84", "1", "1", "5", "Gas");
      this.AddRow("527", "Heat pumps with warm air distribution", "Gas-fired heat pumps", "Air source heat pump", "No", "110", "77", "1", "1", "5", "Gas");
      this.AddRow("306", "Community heating schemes", "", "Community boilers", "", "", "80", "1", "1.0", "3", "Community");
      this.AddRow("307", "Community heating schemes", "", "Community CHP", "", "", "75", "1", "1.0", "3", "Community");
      this.AddRow("308", "Community heating schemes", "", "Community waste heat from power station", "", "", "100", "1", "1.0", "3", "Community");
      this.AddRow("309", "Community heating schemes", "", "Community heat pump", "", "", "300", "1", "1.0", "3", "Community");
      this.AddRow("310", "Community heating schemes", "", "Community geothermal heat source", "", "", "100", "1", "1.0", "3", "Community");
      this.AddRow("401", "Electric storage systems", "Off-peak tariffs", "Old (large volume) storage heaters", "", "", "100", "6", "0.0", "4", "Electricity");
      this.AddRow("402", "Electric storage systems", "Off-peak tariffs", "Modern (slimline) storage heaters", "", "", "100", "5", "0.2", "4", "Electricity");
      this.AddRow("403", "Electric storage systems", "Off-peak tariffs", "Convector storage heaters", "", "", "100", "5", "0.2", "4", "Electricity");
      this.AddRow("404", "Electric storage systems", "Off-peak tariffs", "Fan storage heaters", "", "", "100", "4", "0.4", "4", "Electricity");
      this.AddRow("405", "Electric storage systems", "Off-peak tariffs", "Modern (slimline) storage heaters with Celect-type control", "", "", "100", "4", "0.4", "4", "Electricity");
      this.AddRow("406", "Electric storage systems", "Off-peak tariffs", "Convector storage heaters with Celect-type control", "", "", "100", "4", "0.4", "4", "Electricity");
      this.AddRow("407", "Electric storage systems", "Off-peak tariffs", "Fan storage heaters with Celect-type control", "", "", "100", "3", "0.6", "4", "Electricity");
      this.AddRow("408", "Electric storage systems", "Off-peak tariffs", "Integrated storage+direct-acting heater", "", "", "100", "3", "0.6", "4", "Electricity");
      this.AddRow("409", "Electric storage systems", "Off-peak tariffs", "High heat retention storage heaters", "", "", "100", "2", "0.8", "4", "Electricity");
      this.AddRow("402", "Electric storage systems", "24-hour heating tariff", "Modern (slimline) storage heaters", "", "", "100", "4", "0.4", "4", "Electricity");
      this.AddRow("403", "Electric storage systems", "24-hour heating tariff", "Convector storage heaters", "", "", "100", "4", "0.4", "4", "Electricity");
      this.AddRow("404", "Electric storage systems", "24-hour heating tariff", "Fan storage heaters", "", "", "100", "4", "0.4", "4", "Electricity");
      this.AddRow("405", "Electric storage systems", "24-hour heating tariff", "Modern (slimline) storage heaters with Celect-type control", "", "", "100", "3", "0.6", "4", "Electricity");
      this.AddRow("406", "Electric storage systems", "24-hour heating tariff", "Convector storage heaters with Celect-type control", "", "", "100", "3", "0.6", "4", "Electricity");
      this.AddRow("407", "Electric storage systems", "24-hour heating tariff", "Fan storage heaters with Celect-type control", "", "", "100", "3", "0.6", "4", "Electricity");
      this.AddRow("421", "Electric underfloor heating", "Off-peak tariffs", "In concrete slab (off-peak only)", "", "", "100", "5", "0.0", "7", "Electricity");
      this.AddRow("422", "Electric underfloor heating", "Off-peak tariffs", "Integrated (storage+direct-acting)", "", "", "100", "4", "0.25", "7", "Electricity");
      this.AddRow("423", "Electric underfloor heating", "Off-peak tariffs", "Integrated (storage+direct-acting) with low (off-peak) tariff control", "", "", "100", "3", "0.5", "7", "Electricity");
      this.AddRow("424", "Electric underfloor heating", "Standard tariff", "In screed above insulation", "", "", "100", "2", "0.75", "7", "Electricity");
      this.AddRow("425", "Electric underfloor heating", "Standard tariff", "In timber floor, or immediately below floor covering", "", "", "100", "1", "1", "7", "Electricity");
      this.AddRow("501", "Warm air systems (Not heat pump)", "Gas-fired warm air with fan-assisted flue", "Ducted, on-off control, pre 1998", "", "", "70", "1", "1.0", "5", "Gas");
      this.AddRow("502", "Warm air systems (Not heat pump)", "Gas-fired warm air with fan-assisted flue", "Ducted, on-off control, 1998 or later", "", "", "76", "1", "1.0", "5", "Gas");
      this.AddRow("503", "Warm air systems (Not heat pump)", "Gas-fired warm air with fan-assisted flue", "Ducted, modulating control, pre 1998", "", "", "72", "1", "1.0", "5", "Gas");
      this.AddRow("504", "Warm air systems (Not heat pump)", "Gas-fired warm air with fan-assisted flue", "Ducted, modulating control, 1998 or later", "", "", "78", "1", "1.0", "5", "Gas");
      this.AddRow("505", "Warm air systems (Not heat pump)", "Gas-fired warm air with fan-assisted flue", "Roomheater with in-floor ducts", "", "", "69", "1", "1.0", "5", "Gas");
      this.AddRow("520", "Warm air systems (Not heat pump)", "Gas-fired warm air with fan-assisted flue", "Condensing", "", "", "81", "1", "1.0", "5", "Gas");
      this.AddRow("506", "Warm air systems (Not heat pump)", "Gas fired warm air with balanced or open flue", "Ducted or stub-ducted, on-off control, pre 1998", "", "", "70", "1", "1.0", "5", "Gas");
      this.AddRow("507", "Warm air systems (Not heat pump)", "Gas fired warm air with balanced or open flue", "Ducted or stub-ducted, on-off control, 1998 or later", "", "", "76", "1", "1.0", "5", "Gas");
      this.AddRow("508", "Warm air systems (Not heat pump)", "Gas fired warm air with balanced or open flue", "Ducted or stub-ducted, modulating control, pre 1998", "", "", "72", "1", "1.0", "5", "Gas");
      this.AddRow("509", "Warm air systems (Not heat pump)", "Gas fired warm air with balanced or open flue", "Ducted or stub-ducted, modulating control, 1998 or later", "", "", "78", "1", "1.0", "5", "Gas");
      this.AddRow("510", "Warm air systems (Not heat pump)", "Gas fired warm air with balanced or open flue", "Ducted or stub-ducted with flue heat recovery", "", "", "85", "1", "1.0", "5", "Gas");
      this.AddRow("511", "Warm air systems (Not heat pump)", "Gas fired warm air with balanced or open flue", "Condensing", "", "", "81", "1", "1.0", "5", "Gas");
      this.AddRow("512", "Warm air systems (Not heat pump)", "Oil-fired warm air", "Ducted output (on/off control)", "", "", "70", "1", "1.0", "5", "Oil");
      this.AddRow("513", "Warm air systems (Not heat pump)", "Oil-fired warm air", "Ducted output (modulating control)", "", "", "72", "1", "1.0", "5", "Oil");
      this.AddRow("514", "Warm air systems (Not heat pump)", "Oil-fired warm air", "Stub duct system", "", "", "70", "1", "1.0", "5", "Oil");
      this.AddRow("515", "Warm air systems (Not heat pump)", "Electric warm air", "Electricaire system", "", "", "100", "2", "0.75", "5", "Electricity");
      this.AddRow("601", "Room heaters", "Gas (including LPG) room heaters", "Gas fire, open flue, pre-1980 (open fronted)", "OF", "50", "50", "1", "1.0", "6", "Gas");
      this.AddRow("602", "Room heaters", "Gas (including LPG) room heaters", "Gas fire, open flue, pre-1980 (open fronted), with back boiler unit", "OF", "50", "50", "1", "1.0", "6", "Gas");
      this.AddRow("603", "Room heaters", "Gas (including LPG) room heaters", "Gas fire, open flue, 1980 or later (open fronted),sitting proud of, and sealed to, fireplace opening", "OF", "63", "64", "1", "1.0", "6", "Gas");
      this.AddRow("604", "Room heaters", "Gas (including LPG) room heaters", "Gas fire, open flue, 1980 or later (open fronted), sitting proud of, and sealed to, fireplace opening, with back boiler unit", "OF", "63", "64", "1", "1.0", "6", "Gas");
      this.AddRow("605", "Room heaters", "Gas (including LPG) room heaters", "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening", "OF", "40", "41", "1", "1.0", "6", "Gas");
      this.AddRow("606", "Room heaters", "Gas (including LPG) room heaters", "Flush fitting Live Fuel Effect gas fire (open fronted), sealed to fireplace opening, with back boiler unit", "OF", "40", "41", "1", "1.0", "6", "Gas");
      this.AddRow("607", "Room heaters", "Gas (including LPG) room heaters", "Flush fitting Live Fuel Effect gas fire (open fronted), fan assisted, sealed to fireplace opening", "OF", "45", "46", "1", "1.0", "6", "Gas");
      this.AddRow("609", "Room heaters", "Gas (including LPG) room heaters", "Gas fire or wall heater, balanced flue", "BF", "58", "68", "1", "1.0", "6", "Gas");
      this.AddRow("610", "Room heaters", "Gas (including LPG) room heaters", "Gas fire, closed fronted, fan assisted", "BF", "72", "73", "1", "1.0", "6", "Gas");
      this.AddRow("611", "Room heaters", "Gas (including LPG) room heaters", "Condensing gas fire", "BF", "85", "85", "1", "1.0", "6", "Gas");
      this.AddRow("612", "Room heaters", "Gas (including LPG) room heaters", "Decorative Fuel Effect gas fire, open to chimney", "C", "20", "20", "1", "1.0", "6", "Gas");
      this.AddRow("613", "Room heaters", "Gas (including LPG) room heaters", "Flueless gas fire, secondary heating only", "C", "90", "92", "1", "1.0", "6", "Gas");
      this.AddRow("621", "Room heaters", "Oil room heaters", "Room heater, pre 2000", "OF", "", "55", "1", "1.0", "6", "Oil");
      this.AddRow("622", "Room heaters", "Oil room heaters", "Room heater, pre 2000, with boiler (no radiators)", "OF", "", "65", "1", "1.0", "6", "Oil");
      this.AddRow("623", "Room heaters", "Oil room heaters", "Room heater, 2000 or later", "OF", "", "60", "1", "1.0", "6", "Oil");
      this.AddRow("624", "Room heaters", "Oil room heaters", "Room heater, 2000 or later with boiler (no radiators)", "OF", "", "70", "1", "1.0", "6", "Oil");
      this.AddRow("625", "Room heaters", "Oil room heaters", "Bioethanol heater, secondary heating only", "none", "", "94", "1", "1.0", "6", "Oil");
      this.AddRow("631", "Room heaters", "Solid fuel room heaters", "Open fire in grate", "C", "37", "32", "3", "0.5", "6", "Solid");
      this.AddRow("632", "Room heaters", "Solid fuel room heaters", "Open fire with back boiler (no radiators)", "C", "50", "50", "3", "0.5", "6", "Solid");
      this.AddRow("633", "Room heaters", "Solid fuel room heaters", "Closed room heater", "OF", "65", "60", "3", "0.5", "6", "Solid");
      this.AddRow("634", "Room heaters", "Solid fuel room heaters", "Closed room heater with boiler (no radiators)", "OF", "67", "65", "3", "0.5", "6", "Solid");
      this.AddRow("635", "Room heaters", "Solid fuel room heaters", "Stove (pellet fired)", "OF", "65", "63", "2", "0.75", "6", "Solid");
      this.AddRow("636", "Room heaters", "Solid fuel room heaters", "Stove (pellet fired) with boiler (no radiators)", "OF", "65", "63", "2", "0.75", "6", "Solid");
      this.AddRow("691", "Room heaters", "Electric (direct acting) room heaters", "Panel, convector or radiant heaters", "", "", "100", "1", "1.0", "6", "Electricity");
      this.AddRow("692", "Room heaters", "Electric (direct acting) room heaters", "Fan heaters", "", "", "100", "1", "1.0", "6", "Electricity");
      this.AddRow("693", "Room heaters", "Electric (direct acting) room heaters", "Portable Electric heaters", "", "", "100", "1", "1.0", "6", "Electricity");
      this.AddRow("694", "Room heaters", "Electric (direct acting) room heaters", "Water- or oil-filled radiators", "", "", "100", "1", "1.0", "6", "Electricity");
      this.AddRow("701", "Other space heating systems", "", "Electric ceiling heating", "", "", "100", "2", "0.75", "6", "Electricity");
    }

    private void AddRow(
      string Code,
      string Fristgroup,
      string Secondgroup,
      string Description,
      string Flue,
      string EffA,
      string EffB,
      string HeatingType,
      string Responsiveness,
      string Controls,
      string Fuel)
    {
      PCDF.Table4a_B table4aB1 = new PCDF.Table4a_B();
      PCDF.Table4a_B table4aB2 = table4aB1;
      table4aB2.Code = Code;
      table4aB2.FirstGroup = Fristgroup;
      table4aB2.SecondGroup = Secondgroup;
      table4aB2.Description = Description;
      table4aB2.Flue = Flue;
      table4aB2.EffA = EffA;
      table4aB2.EffB = EffB;
      table4aB2.HeatingType = HeatingType;
      table4aB2.Responsiveness = Responsiveness;
      table4aB2.Controls = Controls;
      table4aB2.Fuel = Fuel;
      this.Table4a_bs.Add(table4aB1);
    }

    private void Populate_Table6e()
    {
      this.Add_Table6e_Row(Conversions.ToString(1), "double-glazed, air filled", "6mm", "wood/PVC-U", "3.1");
      this.Add_Table6e_Row(Conversions.ToString(2), "double-glazed, air filled", "12mm", "wood/PVC-U", "2.8");
      this.Add_Table6e_Row(Conversions.ToString(3), "double-glazed, air filled", "16mm or more", "wood/PVC-U", "2.7");
      this.Add_Table6e_Row(Conversions.ToString(4), "double-glazed, air filled", "6mm", "Metal", "3.7");
      this.Add_Table6e_Row(Conversions.ToString(5), "double-glazed, air filled", "12mm", "Metal", "3.4");
      this.Add_Table6e_Row(Conversions.ToString(6), "double-glazed, air filled", "16mm or more", "Metal", "3.3");
      this.Add_Table6e_Row(Conversions.ToString(7), "double-glazed, air filled (low-E, En = 0.2, hard coat)", "6mm", "wood/PVC-U", "2.7");
      this.Add_Table6e_Row(Conversions.ToString(8), "double-glazed, air filled (low-E, En = 0.2, hard coat)", "12mm", "wood/PVC-U", "2.2");
      this.Add_Table6e_Row(Conversions.ToString(9), "double-glazed, air filled (low-E, En = 0.2, hard coat)", "16mm or more", "wood/PVC-U", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(10), "double-glazed, air filled (low-E, En = 0.2, hard coat)", "6mm", "Metal", "3.3");
      this.Add_Table6e_Row(Conversions.ToString(11), "double-glazed, air filled (low-E, En = 0.2, hard coat)", "12mm", "Metal", "2.8");
      this.Add_Table6e_Row(Conversions.ToString(12), "double-glazed, air filled (low-E, En = 0.2, hard coat)", "16mm or more", "Metal", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(13), "double-glazed, air filled (low-E, En = 0.15, hard coat)", "6mm", "wood/PVC-U", "2.7");
      this.Add_Table6e_Row(Conversions.ToString(14), "double-glazed, air filled (low-E, En = 0.15, hard coat)", "12mm", "wood/PVC-U", "2.2");
      this.Add_Table6e_Row(Conversions.ToString(15), "double-glazed, air filled (low-E, En = 0.15, hard coat)", "16mm or more", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(16), "double-glazed, air filled (low-E, En = 0.15, hard coat)", "6mm", "Metal", "3.3");
      this.Add_Table6e_Row(Conversions.ToString(17), "double-glazed, air filled (low-E, En = 0.15, hard coat)", "12mm", "Metal", "2.7");
      this.Add_Table6e_Row(Conversions.ToString(18), "double-glazed, air filled (low-E, En = 0.15, hard coat)", "16mm or more", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(19), "double-glazed, air filled (low-E, En = 0.1, soft coat)", "6mm", "wood/PVC-U", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(20), "double-glazed, air filled (low-E, En = 0.1, soft coat)", "12mm", "wood/PVC-U", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(21), "double-glazed, air filled (low-E, En = 0.1, soft coat)", "16mm or more", "wood/PVC-U", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(22), "double-glazed, air filled (low-E, En = 0.1, soft coat)", "6mm", "Metal", "3.2");
      this.Add_Table6e_Row(Conversions.ToString(23), "double-glazed, air filled (low-E, En = 0.1, soft coat)", "12mm", "Metal", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(24), "double-glazed, air filled (low-E, En = 0.1, soft coat)", "16mm or more", "Metal", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(25), "double-glazed, air filled (low-E, En = 0.05, soft coat)", "6mm", "wood/PVC-U", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(26), "double-glazed, air filled (low-E, En = 0.05, soft coat)", "12mm", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(27), "double-glazed, air filled (low-E, En = 0.05, soft coat)", "16mm or more", "wood/PVC-U", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(28), "double-glazed, air filled (low-E, En = 0.05, soft coat)", "6mm", "Metal", "3.2");
      this.Add_Table6e_Row(Conversions.ToString(29), "double-glazed, air filled (low-E, En = 0.05, soft coat)", "12mm", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(30), "double-glazed, air filled (low-E, En = 0.05, soft coat)", "16mm or more", "Metal", "2.3");
      this.Add_Table6e_Row(Conversions.ToString(31), "double-glazed, argon filled", "6mm", "wood/PVC-U", "2.9");
      this.Add_Table6e_Row(Conversions.ToString(32), "double-glazed, argon filled", "12mm", "wood/PVC-U", "2.7");
      this.Add_Table6e_Row(Conversions.ToString(33), "double-glazed, argon filled", "16mm or more", "wood/PVC-U", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(34), "double-glazed, argon filled", "6mm", "Metal", "3.5");
      this.Add_Table6e_Row(Conversions.ToString(35), "double-glazed, argon filled", "12mm", "Metal", "3.3");
      this.Add_Table6e_Row(Conversions.ToString(36), "double-glazed, argon filled", "16mm or more", "Metal", "3.2");
      this.Add_Table6e_Row(Conversions.ToString(37), "double-glazed, argon filled (low-E, En = 0.2, hard coat)", "6mm", "wood/PVC-U", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(38), "double-glazed, argon filled (low-E, En = 0.2, hard coat)", "12mm", "wood/PVC-U", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(39), "double-glazed, argon filled (low-E, En = 0.2, hard coat)", "16mm or more", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(40), "double-glazed, argon filled (low-E, En = 0.2, hard coat)", "6mm", "Metal", "3.0");
      this.Add_Table6e_Row(Conversions.ToString(41), "double-glazed, argon filled (low-E, En = 0.2, hard coat)", "12mm", "Metal", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(42), "double-glazed, argon filled (low-E, En = 0.2, hard coat)", "16mm or more", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(43), "double-glazed, argon filled (low-E, En = 0.15, hard coat)", "6mm", "wood/PVC-U", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(44), "double-glazed, argon filled (low-E, En = 0.15, hard coat)", "12mm", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(45), "double-glazed, argon filled (low-E, En = 0.15, hard coat)", "16mm or more", "wood/PVC-U", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(46), "double-glazed, argon filled (low-E, En = 0.15, hard coat)", "6mm", "Metal", "3.0");
      this.Add_Table6e_Row(Conversions.ToString(47), "double-glazed, argon filled (low-E, En = 0.15, hard coat)", "12mm", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(48), "double-glazed, argon filled (low-E, En = 0.15, hard coat)", "16mm or more", "Metal", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(49), "double-glazed, argon filled (low-E, En = 0.1, soft coat)", "6mm", "wood/PVC-U", "2.3");
      this.Add_Table6e_Row(Conversions.ToString(50), "double-glazed, argon filled (low-E, En = 0.1, soft coat)", "12mm", "wood/PVC-U", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(51), "double-glazed, argon filled (low-E, En = 0.1, soft coat)", "16mm or more", "wood/PVC-U", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(52), "double-glazed, argon filled (low-E, En = 0.1, soft coat)", "6mm", "Metal", "2.9");
      this.Add_Table6e_Row(Conversions.ToString(53), "double-glazed, argon filled (low-E, En = 0.1, soft coat)", "12mm", "Metal", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(54), "double-glazed, argon filled (low-E, En = 0.1, soft coat)", "16mm or more", "Metal", "2.3");
      this.Add_Table6e_Row(Conversions.ToString(55), "double-glazed, argon filled (low-E, En = 0.05, soft coat)", "6mm", "wood/PVC-U", "2.3");
      this.Add_Table6e_Row(Conversions.ToString(56), "double-glazed, argon filled (low-E, En = 0.05, soft coat)", "12mm", "wood/PVC-U", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(57), "double-glazed, argon filled (low-E, En = 0.05, soft coat)", "16mm or more", "wood/PVC-U", "1.7");
      this.Add_Table6e_Row(Conversions.ToString(58), "double-glazed, argon filled (low-E, En = 0.05, soft coat)", "6mm", "Metal", "2.8");
      this.Add_Table6e_Row(Conversions.ToString(59), "double-glazed, argon filled (low-E, En = 0.05, soft coat)", "12mm", "Metal", "2.2");
      this.Add_Table6e_Row(Conversions.ToString(60), "double-glazed, argon filled (low-E, En = 0.05, soft coat)", "16mm or more", "Metal", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(61), "triple-glazed, air filled", "6mm", "wood/PVC-U", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(62), "triple-glazed, air filled", "12mm", "wood/PVC-U", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(63), "triple-glazed, air filled", "16mm or more", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(64), "triple-glazed, air filled", "6mm", "Metal", "2.9");
      this.Add_Table6e_Row(Conversions.ToString(65), "triple-glazed, air filled", "12mm", "Metal", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(66), "triple-glazed, air filled", "16mm or more", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(67), "triple-glazed, air filled (low-E, En = 0.2, hard coat)", "6mm", "wood/PVC-U", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(68), "triple-glazed, air filled (low-E, En = 0.2, hard coat)", "12mm", "wood/PVC-U", "1.7");
      this.Add_Table6e_Row(Conversions.ToString(69), "triple-glazed, air filled (low-E, En = 0.2, hard coat)", "16mm or more", "wood/PVC-U", "1.6");
      this.Add_Table6e_Row(Conversions.ToString(70), "triple-glazed, air filled (low-E, En = 0.2, hard coat)", "6mm", "Metal", "2.6");
      this.Add_Table6e_Row(Conversions.ToString(71), "triple-glazed, air filled (low-E, En = 0.2, hard coat)", "12mm", "Metal", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(72), "triple-glazed, air filled (low-E, En = 0.2, hard coat)", "16mm or more", "Metal", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(73), "triple-glazed, air filled (low-E, En = 0.15, hard coat)", "6mm", "wood/PVC-U", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(74), "triple-glazed, air filled (low-E, En = 0.15, hard coat)", "12mm", "wood/PVC-U", "1.7");
      this.Add_Table6e_Row(Conversions.ToString(75), "triple-glazed, air filled (low-E, En = 0.15, hard coat)", "16mm or more", "wood/PVC-U", "1.6");
      this.Add_Table6e_Row(Conversions.ToString(76), "triple-glazed, air filled (low-E, En = 0.15, hard coat)", "6mm", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(77), "triple-glazed, air filled (low-E, En = 0.15, hard coat)", "12mm", "Metal", "2.1");
      this.Add_Table6e_Row(Conversions.ToString(78), "triple-glazed, air filled (low-E, En = 0.15, hard coat)", "16mm or more", "Metal", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(79), "triple-glazed, air filled (low-E, En = 0.1, soft coat)", "6mm", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(80), "triple-glazed, air filled (low-E, En = 0.1, soft coat)", "12mm", "wood/PVC-U", "1.6");
      this.Add_Table6e_Row(Conversions.ToString(81), "triple-glazed, air filled (low-E, En = 0.1, soft coat)", "16mm or more", "wood/PVC-U", "1.5");
      this.Add_Table6e_Row(Conversions.ToString(82), "triple-glazed, air filled (low-E, En = 0.1, soft coat)", "6mm", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(83), "triple-glazed, air filled (low-E, En = 0.1, soft coat)", "12mm", "Metal", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(84), "triple-glazed, air filled (low-E, En = 0.1, soft coat)", "16mm or more", "Metal", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(85), "triple-glazed, air filled (low-E, En = 0.05, soft coat)", "6mm", "wood/PVC-U", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(86), "triple-glazed, air filled (low-E, En = 0.05, soft coat)", "12mm", "wood/PVC-U", "1.5");
      this.Add_Table6e_Row(Conversions.ToString(87), "triple-glazed, air filled (low-E, En = 0.05, soft coat)", "16mm or more", "wood/PVC-U", "1.4");
      this.Add_Table6e_Row(Conversions.ToString(88), "triple-glazed, air filled (low-E, En = 0.05, soft coat)", "6mm", "Metal", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(89), "triple-glazed, air filled (low-E, En = 0.05, soft coat)", "12mm", "Metal", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(90), "triple-glazed, air filled (low-E, En = 0.05, soft coat)", "16mm or more", "Metal", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(91), "triple-glazed, argon filled", "6mm", "wood/PVC-U", "2.2");
      this.Add_Table6e_Row(Conversions.ToString(92), "triple-glazed, argon filled", "12mm", "wood/PVC-U", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(93), "triple-glazed, argon filled", "16mm or more", "wood/PVC-U", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(94), "triple-glazed, argon filled", "6mm", "Metal", "2.8");
      this.Add_Table6e_Row(Conversions.ToString(95), "triple-glazed, argon filled", "12mm", "Metal", "2.5");
      this.Add_Table6e_Row(Conversions.ToString(96), "triple-glazed, argon filled", "16mm or more", "Metal", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(97), "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", "6mm", "wood/PVC-U", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(98), "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", "12mm", "wood/PVC-U", "1.6");
      this.Add_Table6e_Row(Conversions.ToString(99), "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", "16mm or more", "wood/PVC-U", "1.5");
      this.Add_Table6e_Row(Conversions.ToString(100), "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", "6mm", "Metal", "2.3");
      this.Add_Table6e_Row(Conversions.ToString(101), "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", "12mm", "Metal", "2.0");
      this.Add_Table6e_Row(Conversions.ToString(102), "triple-glazed, argon filled (low-E, En = 0.2, hard coat)", "16mm or more", "Metal", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(103), "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", "6mm", "wood/PVC-U", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(104), "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", "12mm", "wood/PVC-U", "1.5");
      this.Add_Table6e_Row(Conversions.ToString(105), "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", "16mm or more", "wood/PVC-U", "1.4");
      this.Add_Table6e_Row(Conversions.ToString(106), "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", "6mm", "Metal", "2.3");
      this.Add_Table6e_Row(Conversions.ToString(107), "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", "12mm", "Metal", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(108), "triple-glazed, argon filled (low-E, En = 0.15, hard coat)", "16mm or more", "Metal", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(109), "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", "6mm", "wood/PVC-U", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(110), "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", "12mm", "wood/PVC-U", "1.5");
      this.Add_Table6e_Row(Conversions.ToString(111), "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", "16mm or more", "wood/PVC-U", "1.4");
      this.Add_Table6e_Row(Conversions.ToString(112), "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", "6mm", "Metal", "2.2");
      this.Add_Table6e_Row(Conversions.ToString(113), "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", "12mm", "Metal", "1.9");
      this.Add_Table6e_Row(Conversions.ToString(114), "triple-glazed, argon filled (low-E, En = 0.1, soft coat)", "16mm or more", "Metal", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(115), "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", "6mm", "wood/PVC-U", "1.7");
      this.Add_Table6e_Row(Conversions.ToString(116), "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", "12mm", "wood/PVC-U", "1.4");
      this.Add_Table6e_Row(Conversions.ToString(117), "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", "16mm or more", "wood/PVC-U", "1.3");
      this.Add_Table6e_Row(Conversions.ToString(118), "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", "6mm", "Metal", "2.2");
      this.Add_Table6e_Row(Conversions.ToString(119), "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", "12mm", "Metal", "1.8");
      this.Add_Table6e_Row(Conversions.ToString(120), "triple-glazed, argon filled (low-E, En = 0.05, soft coat)", "16mm or more", "Metal", "1.7");
      this.Add_Table6e_Row(Conversions.ToString(121), "Single-glazed", "6mm, 12mm, 16mm or more", "wood/PVC-U", "4.8");
      this.Add_Table6e_Row(Conversions.ToString(122), "Single-glazed", "6mm, 12mm, 16mm or more", "Metal", "5.7");
      this.Add_Table6e_Row(Conversions.ToString(123), "Secondary glazing", "6mm, 12mm, 16mm or more", "wood/PVC-U", "2.4");
      this.Add_Table6e_Row(Conversions.ToString(124), "Solid wooden door to outside", "6mm, 12mm, 16mm or more", "wood/PVC-U", "3.0");
      this.Add_Table6e_Row(Conversions.ToString(125), "Solid wooden door to unheated corridor", "6mm, 12mm, 16mm or more", "wood/PVC-U", "1.4");
    }

    private void Add_Table6e_Row(string id, string Type, string GAP, string Frame, string UValue) => this.Table6es.Add(new PCDF.Table6e()
    {
      ID = id,
      Type = Type,
      Frame = Frame,
      GAP = GAP,
      UValue = UValue
    });

    private void Populate_Table4aWater()
    {
      this.Add_Table4aRwater_Row(Conversions.ToString(999), "No hot water system present - electric immersion assumed", Conversions.ToString(100), "Electricity");
      this.Add_Table4aRwater_Row(Conversions.ToString(901), "From main heating system", "-", "-");
      this.Add_Table4aRwater_Row(Conversions.ToString(914), "From second main heating system", "-", "-");
      this.Add_Table4aRwater_Row(Conversions.ToString(902), "From secondary system", "-", "-");
      this.Add_Table4aRwater_Row(Conversions.ToString(903), "Electric immersion (on-peak or off-peak)", Conversions.ToString(100), "Electricity");
      this.Add_Table4aRwater_Row(Conversions.ToString(904), "Back boiler (hot water only), gas", Conversions.ToString(65), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(905), "From a circulator built into a gas warm air system, pre 1998", Conversions.ToString(65), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(906), "From a circulator built into a gas warm air system, 1998 or later", Conversions.ToString(73), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(907), "Single-point gas water heater (instantaneous at point of use)", Conversions.ToString(70), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(908), "Multi-point gas water heater (instantaneous serving several taps)", Conversions.ToString(65), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(909), "Electric instantaneous at point of use", Conversions.ToString(100), "Electricity");
      this.Add_Table4aRwater_Row(Conversions.ToString(911), "Gas boiler/circulator for water heating only", Conversions.ToString(65), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(912), "Oil boiler/circulator for water heating only", Conversions.ToString(70), "Oil");
      this.Add_Table4aRwater_Row(Conversions.ToString(913), "Solid fuel boiler/circulator for water heating only", Conversions.ToString(55), "Solid");
      this.Add_Table4aRwater_Row(Conversions.ToString(921), "Gas, single burner with permanent pilot", Conversions.ToString(46), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(922), "Gas, single burner with automatic ignition", Conversions.ToString(50), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(923), "Gas, twin burner with permanent pilot pre 1998", Conversions.ToString(60), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(924), "Gas, twin burner with automatic ignition pre 1998", Conversions.ToString(65), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(925), "Gas, twin burner with permanent pilot 1998 or later", Conversions.ToString(65), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(926), "Gas, twin burner with automatic ignition 1998 or later", Conversions.ToString(70), "Gas");
      this.Add_Table4aRwater_Row(Conversions.ToString(927), "Oil, single burner", Conversions.ToString(60), "Oil");
      this.Add_Table4aRwater_Row(Conversions.ToString(928), "Oil, twin burner pre 1998", Conversions.ToString(70), "Oil");
      this.Add_Table4aRwater_Row(Conversions.ToString(929), "Oil, twin burner 1998 or later", Conversions.ToString(75), "Oil");
      this.Add_Table4aRwater_Row(Conversions.ToString(930), "Solid fuel, integral oven and boiler", Conversions.ToString(45), "Solid");
      this.Add_Table4aRwater_Row(Conversions.ToString(931), "Solid fuel, independent oven and boiler", Conversions.ToString(55), "Solid");
      this.Add_Table4aRwater_Row(Conversions.ToString(941), "Electric heat pump for water heating only", Conversions.ToString(170), "Electricity");
      this.Add_Table4aRwater_Row(Conversions.ToString(950), "From hot-water only community scheme - boilers", Conversions.ToString(80), "-");
      this.Add_Table4aRwater_Row(Conversions.ToString(951), "From hot-water only community scheme - CHP", Conversions.ToString(75), "-");
      this.Add_Table4aRwater_Row(Conversions.ToString(952), "From hot-water only community scheme - heat pump", Conversions.ToString(300), "-");
    }

    private void Add_Table4aRwater_Row(
      string Code,
      string Description,
      string Efficiency,
      string Fuel)
    {
      this.Table4aWaters.Add(new PCDF.Table4aWater()
      {
        Code = Code,
        Description = Description,
        Efficiency = Efficiency,
        Fuel = Fuel
      });
    }

    private void Populate_Table_P7()
    {
      this.Add_Table_P7_Row(Conversions.ToString(1), "Suspended timber floor, timber/steel frame walls, plasterboard on timber/steel stud internal partitions", Conversions.ToString(5));
      this.Add_Table_P7_Row(Conversions.ToString(2), "Solid floor, timber/steel frame walls, plasterboard on timber/steel stud internal partitions", Conversions.ToString(6));
      this.Add_Table_P7_Row(Conversions.ToString(3), "Solid floor, masonry external walls (internal insulation), masonry separating walls with plasterboard on dabs, plasterboard on timber/steel stud internal partitions", Conversions.ToString(7));
      this.Add_Table_P7_Row(Conversions.ToString(4), "Solid floor, masonry external walls (cavity fill or external insulation) with plasterboard on dabs, masonry separating walls with plasterboard on dabs, plasterboard on timber/steel stud internal partitions", Conversions.ToString(8));
      this.Add_Table_P7_Row(Conversions.ToString(5), "Solid floor, masonry external walls (cavity fill or external insulation) with plasterboard on dabs, masonry separating walls dense plaster, plasterboard on timber/steel stud internal partitions", Conversions.ToString(9));
      this.Add_Table_P7_Row(Conversions.ToString(6), "Solid floor, masonry external walls (cavity fill or external insulation) with dense plaster, masonry separating walls with plasterboard on dabs, plasterboard on timber/steel stud internal partitions", Conversions.ToString(10));
      this.Add_Table_P7_Row(Conversions.ToString(7), "Solid floor, masonry external walls (internal insulation), masonry separating walls with plasterboard on dabs, masonry internal partitions with plasterboard on dabs", Conversions.ToString(11));
      this.Add_Table_P7_Row(Conversions.ToString(8), "Solid floor, masonry external walls (cavity fill or external insulation) with dense plaster, masonry separating walls with dense plaster, plasterboard on timber/steel stud internal partitions", Conversions.ToString(11));
      this.Add_Table_P7_Row(Conversions.ToString(9), "Solid floor, masonry external walls (cavity fill or external insulation) with plasterboard on dabs, masonry separating walls plasterboard on dabs, masonry internal partitions with plasterboard on dabs", Conversions.ToString(12));
      this.Add_Table_P7_Row(Conversions.ToString(10), "Solid floor, masonry external walls (cavity fill or external insulation) with plasterboard on dabs, masonry separating walls dense plaster, masonry internal walls with dense plaster", Conversions.ToString(17));
      this.Add_Table_P7_Row(Conversions.ToString(11), "Solid floor, masonry external walls (cavity fill or external insulation) with dense plaster, masonry separating walls with dense plaster, masonry internal walls with dense plaster", Conversions.ToString(19));
    }

    private void Add_Table_P7_Row(string Code, string Description, string TMP) => this.Table_P7s.Add(new PCDF.Table_P7()
    {
      ID = Code,
      Description = Description,
      TMP = TMP
    });

    public void Populate_Table_P1()
    {
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation possible", "Trickle vents only", Conversions.ToString(0.1));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation possible", "Windows slightly open (50 mm)", Conversions.ToString(0.8));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation possible", "Windows open half the time", Conversions.ToString(3));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation possible", "Windows fully open", Conversions.ToString(6));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation not possible", "Trickle vents only", Conversions.ToString(0.1));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation not possible", "Windows slightly open (50 mm)", Conversions.ToString(0.5));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation not possible", "Windows open half the time", Conversions.ToString(2));
      this.Add_Table_P1_Row("Single storey dwelling (bungalow, flat) Cross ventilation not possible", "Windows fully open", Conversions.ToString(4));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation possible", "Trickle vents only", Conversions.ToString(0.2));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation possible", "Windows slightly open (50 mm)", Conversions.ToString(1));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation possible", "Windows open half the time", Conversions.ToString(4));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation possible", "Windows fully open", Conversions.ToString(8));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation not possible", "Trickle vents only", Conversions.ToString(0.1));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation not possible", "Windows slightly open (50 mm)", Conversions.ToString(0.6));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation not possible", "Windows open half the time", Conversions.ToString(2.5));
      this.Add_Table_P1_Row("Dwelling of two or more storeys windows open upstairs and downstairs Cross ventilation not possible", "Windows fully open", Conversions.ToString(5));
    }

    private void Add_Table_P1_Row(string Build, string Window, string ach) => this.Table_P1s.Add(new PCDF.Table_P1()
    {
      Build = Build,
      Window = Window,
      ach = ach
    });

    public void Populate_Table4e()
    {
      this.Add_Table4e_Row("0", "None", "2", "0.3", "-", "2699", "Very poor");
      this.Add_Table4e_Row("1", "Not applicable (boiler provides DHW only)", "1", "0", "-", "2100", "-");
      this.Add_Table4e_Row("1", "No time or thermostatic control of room temperature", "1", "0.6", "-", "2101", "Very poor");
      this.Add_Table4e_Row("1", "Programmer, no room thermostat", "1", "0.6", "-", "2102", "Very poor");
      this.Add_Table4e_Row("1", "Room thermostat only", "1", "0", "-", "2103", "Poor");
      this.Add_Table4e_Row("1", "Programmer and room thermostat", "1", "0", "-", "2104", "Average");
      this.Add_Table4e_Row("1", "Programmer and at least two room thermostats", "2", "0", "-", "2105", "Good");
      this.Add_Table4e_Row("1", "Programmer, room thermostat and TRVs", "2", "0", "-", "2106", "Good");
      this.Add_Table4e_Row("1", "Programmer, TRVs and bypass", "2", "0", "-", "2107", "Average");
      this.Add_Table4e_Row("1", "Programmer, TRVs and flow switch", "2", "0", "-", "2108", "Average");
      this.Add_Table4e_Row("1", "Programmer, TRVs and boiler energy manager", "2", "0", "-", "2109", "Good");
      this.Add_Table4e_Row("1", "Time and temperature zone control by suitable arrangement of plumbing and electrical services", "3", "0", "-", "2110", "Very good");
      this.Add_Table4e_Row("1", "TRVs and bypass", "2", "0", "-", "2111", "Average");
      this.Add_Table4e_Row("1", "Time and temperature zone control by device in database", "3", "0", "-", "2112", "Very good");
      this.Add_Table4e_Row("2", "No time or thermostatic control of room temperature", "1", "0.3", "-", "2201", "Very poor");
      this.Add_Table4e_Row("2", "Programmer, no room thermostat", "1", "0.3", "-", "2202", "Very poor");
      this.Add_Table4e_Row("2", "Room thermostat only", "1", "0", "-", "2203", "Poor");
      this.Add_Table4e_Row("2", "Programmer and room thermostat", "1", "0", "-", "2204", "Average");
      this.Add_Table4e_Row("2", "Programmer and at least two room thermostats", "2", "0", "-", "2205", "Good");
      this.Add_Table4e_Row("2", "Programmer, TRVs and bypass", "2", "0", "-", "2206", "Average");
      this.Add_Table4e_Row("2", "Time and temperature zone control by suitable arrangement of plumbing and electrical services", "3", "0", "-", "2207", "Very good");
      this.Add_Table4e_Row("2", "Time and temperature zone control by device in database", "3", "0", "-", "2208", "Very good");
      this.Add_Table4e_Row("3", "Flat rate charging, no thermostatic control of room temperature", "1", "0.3", "-", "2301", "Very poor");
      this.Add_Table4e_Row("3", "Flat rate charging, programmer, no room thermostat", "1", "0.3", "-", "2302", "Very poor");
      this.Add_Table4e_Row("3", "Flat rate charging, room thermostat only", "1", "0", "-", "2303", "Poor");
      this.Add_Table4e_Row("3", "Flat rate charging, programmer and room thermostat", "1", "0", "-", "2304", "Poor");
      this.Add_Table4e_Row("3", "Flat rate charging, TRVs", "2", "0", "-", "2307", "Average");
      this.Add_Table4e_Row("3", "Flat rate charging, programmer and TRVs", "2", "0", "-", "2305", "Average");
      this.Add_Table4e_Row("3", "Flat rate charging, programmer and at least two room thermostats", "2", "0", "-", "2311", "Average");
      this.Add_Table4e_Row("3", "Charging system linked to use of community heating, room thermostat only", "2", "0", "-", "2308", "Poor");
      this.Add_Table4e_Row("3", "Charging system linked to use of community heating, programmer and room thermostat", "2", "0", "-", "2309", "Average");
      this.Add_Table4e_Row("3", "Charging system linked to use of community heating, TRVs", "3", "0", "-", "2310", "Good");
      this.Add_Table4e_Row("3", "Charging system linked to use of community heating, programmer and TRVs", "3", "0", "-", "2306", "Good");
      this.Add_Table4e_Row("3", "Charging system linked to use of community heating, programmer and at least two room thermostats", "3", "0", "-", "2312", "Good");
      this.Add_Table4e_Row("4", "Manual charge control", "3", "0.7", "-", "2401", "Poor");
      this.Add_Table4e_Row("4", "Automatic charge control", "3", "0.4", "-", "2402", "Average");
      this.Add_Table4e_Row("4", "Celect-type controls", "3", "0.4", "-", "2403", "Good");
      this.Add_Table4e_Row("4", "Controls for high heat retention storage heaters", "3", "0", "-", "2404", "Good");
      this.Add_Table4e_Row("5", "No thermostatic control of room temperature", "1", "0.3", "-", "2501", "Very poor");
      this.Add_Table4e_Row("5", "Programmer, no room thermostat", "1", "0.3", "-", "2502", "Very poor");
      this.Add_Table4e_Row("5", "Room thermostat only", "1", "0", "-", "2503", "Poor");
      this.Add_Table4e_Row("5", "Programmer and room thermostat", "1", "0", "-", "2504", "Average");
      this.Add_Table4e_Row("5", "Programmer and at least two room thermostats", "2", "0", "-", "2505", "Good");
      this.Add_Table4e_Row("5", "Time and temperature zone control", "3", "0", "-", "2506", "Very good");
      this.Add_Table4e_Row("6", "No thermostatic control of room temperature", "2", "0.3", "-", "2601", "Poor");
      this.Add_Table4e_Row("6", "Appliance thermostats", "3", "0", "-", "2602", "Good");
      this.Add_Table4e_Row("6", "Programmer and appliance thermostats", "3", "0", "-", "2603", "Good");
      this.Add_Table4e_Row("6", "Room thermostats only", "3", "0", "-", "2604", "Good");
      this.Add_Table4e_Row("6", "Programmer and room thermostats", "3", "0", "-", "2605", "Good");
      this.Add_Table4e_Row("7", "No thermostatic control of room temperature", "1", "0.3", "-", "2701", "Very poor");
      this.Add_Table4e_Row("7", "Programmer, no room thermostat", "1", "0.3", "-", "2702", "Very poor");
      this.Add_Table4e_Row("7", "Room thermostat only", "1", "0", "-", "2703", "Poor");
      this.Add_Table4e_Row("7", "Programmer and room thermostat", "1", "0", "-", "2704", "Average");
      this.Add_Table4e_Row("7", "Temperature zone control", "2", "0", "-", "2705", "Good");
      this.Add_Table4e_Row("7", "Time and temperature zone control", "3", "0", "-", "2706", "Very good");
    }

    private void Add_Table4e_Row(
      string Group,
      string Description,
      string Control,
      string TempAdd,
      string Reference,
      string Code,
      string Band)
    {
      this.Table4es.Add(new PCDF.Table4e()
      {
        Group = Group,
        Description = Description,
        Control = Control,
        TempAdd = TempAdd,
        Reference = Reference,
        Code = Code,
        Band = Band
      });
    }

    private void FillTable12aSAP()
    {
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 1,
        SCharge = 120.0,
        Price = 3.48,
        Emissions = 0.216,
        Energy = 1.22,
        Description = "mains gas"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 2,
        SCharge = 70.0,
        Price = 7.6,
        Emissions = 0.241,
        Energy = 1.09,
        Description = "bulk LPG"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 3,
        SCharge = 0.0,
        Price = 10.3,
        Emissions = 0.241,
        Energy = 1.09,
        Description = "bottled LPG"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 9,
        SCharge = 120.0,
        Price = 3.48,
        Emissions = 0.241,
        Energy = 1.09,
        Description = "LPG subject to Special Condition 18"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 7,
        SCharge = 70.0,
        Price = 7.6,
        Emissions = 0.098,
        Energy = 1.1,
        Description = "biogas (including anarobic digestion"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 4,
        SCharge = 0.0,
        Price = 5.44,
        Emissions = 0.298,
        Energy = 1.1,
        Description = "heating oil"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 71,
        SCharge = 0.0,
        Price = 7.64,
        Emissions = 0.123,
        Energy = 1.06,
        Description = "biodiesel from any biomass source"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 73,
        SCharge = 0.0,
        Price = 7.64,
        Emissions = 0.083,
        Energy = 1.01,
        Description = "biodiesel from vegetable oil only"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 74,
        SCharge = 0.0,
        Price = 5.44,
        Emissions = 0.298,
        Energy = 1.1,
        Description = "appliancees able to use mineral oil or biodiesel"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 75,
        SCharge = 0.0,
        Price = 6.1,
        Emissions = 0.245,
        Energy = 1.09,
        Description = "B30K"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 76,
        SCharge = 0.0,
        Price = 47.0,
        Emissions = 0.14,
        Energy = 1.08,
        Description = "bioethanol from any biomass source"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 11,
        SCharge = 0.0,
        Price = 3.67,
        Emissions = 0.394,
        Energy = 1.0,
        Description = "house coal"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 15,
        SCharge = 0.0,
        Price = 3.64,
        Emissions = 0.394,
        Energy = 1.06,
        Description = "anthracite"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 12,
        SCharge = 0.0,
        Price = 4.61,
        Emissions = 0.433,
        Energy = 1.21,
        Description = "manufactured smokeless fuel"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 20,
        SCharge = 0.0,
        Price = 4.23,
        Emissions = 0.019,
        Energy = 1.04,
        Description = "wood logs"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 22,
        SCharge = 0.0,
        Price = 5.81,
        Emissions = 0.039,
        Energy = 1.26,
        Description = "wood pellets (in bags for secondary heating"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 23,
        SCharge = 0.0,
        Price = 5.26,
        Emissions = 0.039,
        Energy = 1.26,
        Description = "wood pellets (bulk supply for main heating"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 21,
        SCharge = 0.0,
        Price = 3.07,
        Emissions = 0.016,
        Energy = 1.12,
        Description = "wood chips"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 10,
        SCharge = 0.0,
        Price = 3.99,
        Emissions = 0.226,
        Energy = 1.02,
        Description = "dual fuel appliciance"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 30,
        SCharge = 54.0,
        Price = 13.19,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "standard tariff"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 32,
        SCharge = 24.0,
        Price = 15.29,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "7-hour tariff (high rate)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 31,
        SCharge = 0.0,
        Price = 5.5,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "7-hour tariff (low rate)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 34,
        SCharge = 23.0,
        Price = 14.68,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "10-hour tariff (high rate)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 33,
        SCharge = 0.0,
        Price = 7.5,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "10-hour tariff (low rate)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 38,
        SCharge = 40.0,
        Price = 13.67,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "18-hour tariff (high rate)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 40,
        SCharge = 0.0,
        Price = 7.41,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "18-hour tariff (high rate)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 35,
        SCharge = 70.0,
        Price = 6.61,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "24-hour heating tariff"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 36,
        SCharge = 0.0,
        Price = 13.19,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "electricity sold to grid"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 37,
        SCharge = 0.0,
        Price = 0.0,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "electricity displaced from grid"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 51,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.216,
        Energy = 1.22,
        Description = "heat from boilers mains gas"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 52,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.241,
        Energy = 1.09,
        Description = "heat from boilers LPG"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 53,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.331,
        Energy = 1.1,
        Description = "heat from boilers oil"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 56,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.331,
        Energy = 1.1,
        Description = "heat from boilers that can use mineral oil or biodiesel"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 57,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.123,
        Energy = 1.06,
        Description = "heat from boilers using biodiesel from any biomass source"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 58,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.083,
        Energy = 1.01,
        Description = "heat from boilers using biodiesel from vegetable oil only"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 55,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.269,
        Energy = 1.09,
        Description = "heat from boilers B30D"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 54,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.38,
        Energy = 1.0,
        Description = "heat from boilers coal"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 41,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "heat from electric heat pump"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 42,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.047,
        Energy = 1.23,
        Description = "heat from boilers waste combustion"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 43,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.031,
        Energy = 1.01,
        Description = "heat from boilers biomass"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 44,
        SCharge = 120.0,
        Price = 4.24,
        Emissions = 0.098,
        Energy = 1.1,
        Description = "heat from boilers biogas (landfill or sewage gas)"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 45,
        SCharge = 120.0,
        Price = 2.97,
        Emissions = 0.058,
        Energy = 1.34,
        Description = "waste heat from power station"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 46,
        SCharge = 120.0,
        Price = 2.97,
        Emissions = 0.041,
        Energy = 1.24,
        Description = "geothermal heat source"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 48,
        SCharge = 120.0,
        Price = 2.97,
        Emissions = 0.216,
        Energy = 1.22,
        Description = "heat from CHP"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 49,
        SCharge = 120.0,
        Price = 0.0,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "electricity generated by CHP"
      });
      this.Table12as.Add(new PCDF.Table12a()
      {
        Fuel = 50,
        SCharge = 120.0,
        Price = 0.0,
        Emissions = 0.519,
        Energy = 3.07,
        Description = "electricity for pumping in distribution network"
      });
    }

    public List<PCDF.Table12SEDBUK> CopyTable12SEDBUK(List<PCDF.Table12SEDBUK> Prices)
    {
      try
      {
        DataContractSerializer contractSerializer = new DataContractSerializer(typeof (List<PCDF.Table12SEDBUK>));
        MemoryStream memoryStream = new MemoryStream();
        contractSerializer.WriteObject((Stream) memoryStream, (object) Prices);
        memoryStream.Position = 0L;
        return (List<PCDF.Table12SEDBUK>) contractSerializer.ReadObject((Stream) memoryStream);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return (List<PCDF.Table12SEDBUK>) null;
    }

    private void Create_Table12a(StreamReader reader)
    {
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 3)
        {
          string Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "191", false) == 0 & Operators.CompareString(str.Substring(5, 3), "292", false) == 0)
          {
            flag1 = true;
            string[] strArray = str.Split(',');
            this.HistoricPrices.Add(new PCDF.HistoricTable12SEDBUK()
            {
              SEDBUKDate = this.VersionDate,
              SEDBUKVersion = this.Version,
              PricingDate = new DateTime(checked ((int) Math.Round(Conversion.Val(strArray[3]))), checked ((int) Math.Round(Conversion.Val(strArray[4]))), checked ((int) Math.Round(Conversion.Val(strArray[5])))),
              PricingVersion = strArray[2]
            });
          }
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] strArray = str.Split(',');
                this.Table12aSEDBUKs.Add(new PCDF.Table12SEDBUK()
                {
                  Cat = Conversions.ToInteger(strArray[0]),
                  Fuel = Conversions.ToInteger(strArray[1]),
                  SCharge = Conversions.ToSingle(strArray[2]),
                  Price = Conversions.ToSingle(strArray[3]),
                  Date1 = strArray[4]
                });
              }
              else
                break;
            }
          }
          else
            flag2 = true;
        }
      }
      this.HistoricPrices.Last<PCDF.HistoricTable12SEDBUK>().Table12aSEDBUKs = this.CopyTable12SEDBUK(this.Table12aSEDBUKs);
      this.AddOns_Table12(this.Table12aSEDBUKs);
    }

    private void Create_Historic_Table12a(StreamReader reader)
    {
      string Left = "";
      while (reader.Peek() != -1)
      {
        string str = reader.ReadLine();
        bool flag1;
        if (str.Length > 3)
        {
          Left = str.Substring(1, 3);
          if (!flag1 && Operators.CompareString(Left, "199", false) == 0 & Operators.CompareString(str.Substring(5, 3), "293", false) == 0)
          {
            flag1 = true;
            this.HistoricPrices.Add(new PCDF.HistoricTable12SEDBUK());
          }
        }
        if (flag1)
        {
          bool flag2;
          if (flag2)
          {
            if (!str.StartsWith("#"))
            {
              if (!str.StartsWith("$"))
              {
                string[] source = str.Split(',');
                if (Operators.CompareString(((IEnumerable<string>) source).First<string>(), "C", false) == 0)
                {
                  this.HistoricPrices.Last<PCDF.HistoricTable12SEDBUK>().PricingVersion = source[1];
                  this.HistoricPrices.Last<PCDF.HistoricTable12SEDBUK>().PricingDate = new DateTime(checked ((int) Math.Round(Conversion.Val(source[2]))), checked ((int) Math.Round(Conversion.Val(source[3]))), checked ((int) Math.Round(Conversion.Val(source[4]))));
                }
                else if (Operators.CompareString(((IEnumerable<string>) source).First<string>(), "B", false) == 0)
                {
                  this.HistoricPrices.Last<PCDF.HistoricTable12SEDBUK>().SEDBUKVersion = source[1];
                  this.HistoricPrices.Last<PCDF.HistoricTable12SEDBUK>().SEDBUKDate = new DateTime(checked ((int) Math.Round(Conversion.Val(source[2]))), checked ((int) Math.Round(Conversion.Val(source[3]))), checked ((int) Math.Round(Conversion.Val(source[4]))));
                }
                else if (Operators.CompareString(((IEnumerable<string>) source).First<string>(), "A", false) == 0)
                  this.HistoricPrices.Last<PCDF.HistoricTable12SEDBUK>().Table12aSEDBUKs.Add(new PCDF.Table12SEDBUK()
                  {
                    Cat = Conversions.ToInteger(source[1]),
                    Fuel = Conversions.ToInteger(source[2]),
                    SCharge = Conversions.ToSingle(source[3]),
                    Price = Conversions.ToSingle(source[4]),
                    Date1 = source[5]
                  });
              }
              else if (Operators.CompareString(Left, "199", false) == 0 & Operators.CompareString(str.Substring(5, 3), "293", false) == 0)
              {
                flag1 = true;
                this.HistoricPrices.Add(new PCDF.HistoricTable12SEDBUK());
                flag2 = false;
              }
              else
                break;
            }
          }
          else
            flag2 = true;
        }
      }
      int num = checked (this.HistoricPrices.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.AddOns_Table12(this.HistoricPrices[index].Table12aSEDBUKs);
        checked { ++index; }
      }
    }

    private void AddOns_Table12(List<PCDF.Table12SEDBUK> Table12aSEDBUK)
    {
      List<PCDF.Table12SEDBUK> source1 = Table12aSEDBUK;
      Func<PCDF.Table12SEDBUK, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (PCDF._Closure\u0024__.\u0024I276\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = PCDF._Closure\u0024__.\u0024I276\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        PCDF._Closure\u0024__.\u0024I276\u002D0 = predicate1 = (Func<PCDF.Table12SEDBUK, bool>) (b => b.Cat == 5);
      }
      PCDF.Table12SEDBUK table12Sedbuk1 = source1.Where<PCDF.Table12SEDBUK>(predicate1).SingleOrDefault<PCDF.Table12SEDBUK>();
      List<PCDF.Table12SEDBUK> source2 = Table12aSEDBUK;
      Func<PCDF.Table12SEDBUK, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (PCDF._Closure\u0024__.\u0024I276\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = PCDF._Closure\u0024__.\u0024I276\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        PCDF._Closure\u0024__.\u0024I276\u002D1 = predicate2 = (Func<PCDF.Table12SEDBUK, bool>) (b => b.Cat == 6);
      }
      PCDF.Table12SEDBUK table12Sedbuk2 = source2.Where<PCDF.Table12SEDBUK>(predicate2).SingleOrDefault<PCDF.Table12SEDBUK>();
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 51
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 52
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 53
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 55
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 54
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 41
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 42
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 43
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk1.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 44
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk2.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 45
      });
      Table12aSEDBUK.Add(new PCDF.Table12SEDBUK()
      {
        Cat = table12Sedbuk1.Cat,
        SCharge = table12Sedbuk1.SCharge,
        Price = table12Sedbuk2.Price,
        Date1 = table12Sedbuk1.Date1,
        Fuel = 46
      });
    }

    private void Populate_Regions()
    {
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 0,
        Latitude = 53.5,
        HeightAboveSeaLevel = 79.0,
        TableU1 = new Months()
        {
          M1 = 4.3,
          M2 = 4.9,
          M3 = 6.5,
          M4 = 8.9,
          M5 = 11.7,
          M6 = 14.6,
          M7 = 16.6,
          M8 = 16.4,
          M9 = 14.1,
          M10 = 10.6,
          M11 = 7.1,
          M12 = 4.2
        },
        TableU2 = new Months()
        {
          M1 = 5.1,
          M2 = 5.0,
          M3 = 4.9,
          M4 = 4.4,
          M5 = 4.3,
          M6 = 3.8,
          M7 = 3.8,
          M8 = 3.7,
          M9 = 4.0,
          M10 = 4.3,
          M11 = 4.5,
          M12 = 4.7
        },
        TableU3 = new Months()
        {
          M1 = 26.0,
          M2 = 54.0,
          M3 = 96.0,
          M4 = 150.0,
          M5 = 192.0,
          M6 = 200.0,
          M7 = 189.0,
          M8 = 157.0,
          M9 = 115.0,
          M10 = 66.0,
          M11 = 33.0,
          M12 = 21.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 1,
        Latitude = 51.6,
        HeightAboveSeaLevel = 53.0,
        TableU1 = new Months()
        {
          M1 = 5.1,
          M2 = 5.6,
          M3 = 7.4,
          M4 = 9.9,
          M5 = 13.0,
          M6 = 16.0,
          M7 = 17.9,
          M8 = 17.8,
          M9 = 15.2,
          M10 = 11.6,
          M11 = 8.0,
          M12 = 5.1
        },
        TableU2 = new Months()
        {
          M1 = 4.2,
          M2 = 4.0,
          M3 = 4.0,
          M4 = 3.7,
          M5 = 3.7,
          M6 = 3.3,
          M7 = 3.4,
          M8 = 3.2,
          M9 = 3.3,
          M10 = 3.5,
          M11 = 3.5,
          M12 = 3.8
        },
        TableU3 = new Months()
        {
          M1 = 30.0,
          M2 = 56.0,
          M3 = 98.0,
          M4 = 157.0,
          M5 = 195.0,
          M6 = 217.0,
          M7 = 203.0,
          M8 = 173.0,
          M9 = (double) sbyte.MaxValue,
          M10 = 73.0,
          M11 = 39.0,
          M12 = 24.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 2,
        Latitude = 51.1,
        HeightAboveSeaLevel = 55.0,
        TableU1 = new Months()
        {
          M1 = 5.0,
          M2 = 5.4,
          M3 = 7.1,
          M4 = 9.5,
          M5 = 12.6,
          M6 = 15.4,
          M7 = 17.4,
          M8 = 17.5,
          M9 = 15.0,
          M10 = 11.7,
          M11 = 8.1,
          M12 = 5.2
        },
        TableU2 = new Months()
        {
          M1 = 4.8,
          M2 = 4.5,
          M3 = 4.4,
          M4 = 3.9,
          M5 = 3.9,
          M6 = 3.6,
          M7 = 3.7,
          M8 = 3.5,
          M9 = 3.7,
          M10 = 4.0,
          M11 = 4.1,
          M12 = 4.4
        },
        TableU3 = new Months()
        {
          M1 = 32.0,
          M2 = 59.0,
          M3 = 104.0,
          M4 = 170.0,
          M5 = 208.0,
          M6 = 231.0,
          M7 = 216.0,
          M8 = 182.0,
          M9 = 133.0,
          M10 = 77.0,
          M11 = 41.0,
          M12 = 25.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 3,
        Latitude = 50.9,
        HeightAboveSeaLevel = 50.0,
        TableU1 = new Months()
        {
          M1 = 5.4,
          M2 = 5.7,
          M3 = 7.3,
          M4 = 9.6,
          M5 = 12.6,
          M6 = 15.4,
          M7 = 17.3,
          M8 = 17.3,
          M9 = 15.0,
          M10 = 11.8,
          M11 = 8.4,
          M12 = 5.5
        },
        TableU2 = new Months()
        {
          M1 = 5.1,
          M2 = 4.7,
          M3 = 4.6,
          M4 = 4.3,
          M5 = 4.3,
          M6 = 4.0,
          M7 = 4.0,
          M8 = 3.9,
          M9 = 4.0,
          M10 = 4.5,
          M11 = 4.4,
          M12 = 4.7
        },
        TableU3 = new Months()
        {
          M1 = 35.0,
          M2 = 62.0,
          M3 = 109.0,
          M4 = 172.0,
          M5 = 209.0,
          M6 = 235.0,
          M7 = 217.0,
          M8 = 185.0,
          M9 = 138.0,
          M10 = 80.0,
          M11 = 44.0,
          M12 = 27.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 4,
        Latitude = 50.5,
        HeightAboveSeaLevel = 85.0,
        TableU1 = new Months()
        {
          M1 = 6.1,
          M2 = 6.4,
          M3 = 7.5,
          M4 = 9.3,
          M5 = 11.9,
          M6 = 14.5,
          M7 = 16.2,
          M8 = 16.3,
          M9 = 14.6,
          M10 = 11.8,
          M11 = 9.0,
          M12 = 6.4
        },
        TableU2 = new Months()
        {
          M1 = 6.0,
          M2 = 5.6,
          M3 = 5.6,
          M4 = 5.0,
          M5 = 5.0,
          M6 = 4.4,
          M7 = 4.4,
          M8 = 4.3,
          M9 = 4.7,
          M10 = 5.4,
          M11 = 5.5,
          M12 = 5.9
        },
        TableU3 = new Months()
        {
          M1 = 36.0,
          M2 = 63.0,
          M3 = 111.0,
          M4 = 174.0,
          M5 = 210.0,
          M6 = 233.0,
          M7 = 204.0,
          M8 = 182.0,
          M9 = 136.0,
          M10 = 78.0,
          M11 = 44.0,
          M12 = 28.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 5,
        Latitude = 51.5,
        HeightAboveSeaLevel = 99.0,
        TableU1 = new Months()
        {
          M1 = 4.9,
          M2 = 5.3,
          M3 = 7.0,
          M4 = 9.3,
          M5 = 12.2,
          M6 = 15.0,
          M7 = 16.7,
          M8 = 16.7,
          M9 = 14.4,
          M10 = 11.1,
          M11 = 7.8,
          M12 = 4.9
        },
        TableU2 = new Months()
        {
          M1 = 4.9,
          M2 = 4.6,
          M3 = 4.7,
          M4 = 4.3,
          M5 = 4.3,
          M6 = 3.8,
          M7 = 3.8,
          M8 = 3.7,
          M9 = 3.8,
          M10 = 4.3,
          M11 = 4.3,
          M12 = 4.6
        },
        TableU3 = new Months()
        {
          M1 = 32.0,
          M2 = 59.0,
          M3 = 105.0,
          M4 = 167.0,
          M5 = 201.0,
          M6 = 226.0,
          M7 = 206.0,
          M8 = 175.0,
          M9 = 130.0,
          M10 = 74.0,
          M11 = 40.0,
          M12 = 25.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 6,
        Latitude = 52.6,
        HeightAboveSeaLevel = 116.0,
        TableU1 = new Months()
        {
          M1 = 4.3,
          M2 = 4.8,
          M3 = 6.6,
          M4 = 9.0,
          M5 = 11.8,
          M6 = 14.8,
          M7 = 16.6,
          M8 = 16.5,
          M9 = 14.0,
          M10 = 10.5,
          M11 = 7.1,
          M12 = 4.2
        },
        TableU2 = new Months()
        {
          M1 = 4.5,
          M2 = 4.5,
          M3 = 4.4,
          M4 = 3.9,
          M5 = 3.8,
          M6 = 3.4,
          M7 = 3.3,
          M8 = 3.3,
          M9 = 3.5,
          M10 = 3.8,
          M11 = 3.9,
          M12 = 4.1
        },
        TableU3 = new Months()
        {
          M1 = 28.0,
          M2 = 55.0,
          M3 = 97.0,
          M4 = 153.0,
          M5 = 191.0,
          M6 = 208.0,
          M7 = 194.0,
          M8 = 163.0,
          M9 = 121.0,
          M10 = 69.0,
          M11 = 35.0,
          M12 = 23.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 7,
        Latitude = 53.5,
        HeightAboveSeaLevel = 71.0,
        TableU1 = new Months()
        {
          M1 = 4.7,
          M2 = 5.2,
          M3 = 6.7,
          M4 = 9.1,
          M5 = 12.0,
          M6 = 14.7,
          M7 = 16.4,
          M8 = 16.3,
          M9 = 14.1,
          M10 = 10.7,
          M11 = 7.5,
          M12 = 4.6
        },
        TableU2 = new Months()
        {
          M1 = 4.8,
          M2 = 4.7,
          M3 = 4.6,
          M4 = 4.2,
          M5 = 4.1,
          M6 = 3.7,
          M7 = 3.7,
          M8 = 3.7,
          M9 = 3.7,
          M10 = 4.2,
          M11 = 4.3,
          M12 = 4.5
        },
        TableU3 = new Months()
        {
          M1 = 24.0,
          M2 = 51.0,
          M3 = 95.0,
          M4 = 152.0,
          M5 = 191.0,
          M6 = 203.0,
          M7 = 186.0,
          M8 = 152.0,
          M9 = 115.0,
          M10 = 65.0,
          M11 = 31.0,
          M12 = 30.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 8,
        Latitude = 54.6,
        HeightAboveSeaLevel = 119.0,
        TableU1 = new Months()
        {
          M1 = 3.9,
          M2 = 4.3,
          M3 = 5.6,
          M4 = 7.9,
          M5 = 10.7,
          M6 = 13.2,
          M7 = 14.9,
          M8 = 14.8,
          M9 = 12.8,
          M10 = 9.7,
          M11 = 6.6,
          M12 = 3.7
        },
        TableU2 = new Months()
        {
          M1 = 5.2,
          M2 = 5.2,
          M3 = 5.0,
          M4 = 4.4,
          M5 = 4.3,
          M6 = 3.9,
          M7 = 3.7,
          M8 = 3.7,
          M9 = 4.1,
          M10 = 4.6,
          M11 = 4.8,
          M12 = 4.7
        },
        TableU3 = new Months()
        {
          M1 = 23.0,
          M2 = 51.0,
          M3 = 95.0,
          M4 = 157.0,
          M5 = 200.0,
          M6 = 203.0,
          M7 = 194.0,
          M8 = 156.0,
          M9 = 113.0,
          M10 = 62.0,
          M11 = 30.0,
          M12 = 19.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 9,
        Latitude = 55.2,
        HeightAboveSeaLevel = 101.0,
        TableU1 = new Months()
        {
          M1 = 4.0,
          M2 = 4.5,
          M3 = 5.8,
          M4 = 7.9,
          M5 = 10.4,
          M6 = 13.3,
          M7 = 15.2,
          M8 = 15.1,
          M9 = 13.1,
          M10 = 9.7,
          M11 = 6.6,
          M12 = 3.7
        },
        TableU2 = new Months()
        {
          M1 = 5.2,
          M2 = 5.2,
          M3 = 5.0,
          M4 = 4.4,
          M5 = 4.1,
          M6 = 3.8,
          M7 = 3.5,
          M8 = 3.5,
          M9 = 3.9,
          M10 = 4.2,
          M11 = 4.6,
          M12 = 4.7
        },
        TableU3 = new Months()
        {
          M1 = 23.0,
          M2 = 50.0,
          M3 = 92.0,
          M4 = 151.0,
          M5 = 200.0,
          M6 = 196.0,
          M7 = 187.0,
          M8 = 153.0,
          M9 = 111.0,
          M10 = 61.0,
          M11 = 30.0,
          M12 = 18.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 10,
        Latitude = 54.4,
        HeightAboveSeaLevel = 78.0,
        TableU1 = new Months()
        {
          M1 = 4.0,
          M2 = 4.6,
          M3 = 6.1,
          M4 = 8.3,
          M5 = 10.9,
          M6 = 13.8,
          M7 = 15.8,
          M8 = 15.6,
          M9 = 13.5,
          M10 = 10.1,
          M11 = 6.7,
          M12 = 3.8
        },
        TableU2 = new Months()
        {
          M1 = 5.3,
          M2 = 5.2,
          M3 = 5.0,
          M4 = 4.3,
          M5 = 4.2,
          M6 = 3.9,
          M7 = 3.6,
          M8 = 3.6,
          M9 = 4.1,
          M10 = 4.3,
          M11 = 4.6,
          M12 = 4.8
        },
        TableU3 = new Months()
        {
          M1 = 25.0,
          M2 = 51.0,
          M3 = 95.0,
          M4 = 152.0,
          M5 = 196.0,
          M6 = 198.0,
          M7 = 190.0,
          M8 = 156.0,
          M9 = 115.0,
          M10 = 64.0,
          M11 = 32.0,
          M12 = 30.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 11,
        Latitude = 53.5,
        HeightAboveSeaLevel = 79.0,
        TableU1 = new Months()
        {
          M1 = 4.3,
          M2 = 4.9,
          M3 = 6.5,
          M4 = 8.9,
          M5 = 11.7,
          M6 = 14.6,
          M7 = 16.6,
          M8 = 16.4,
          M9 = 14.1,
          M10 = 10.6,
          M11 = 7.1,
          M12 = 4.2
        },
        TableU2 = new Months()
        {
          M1 = 5.1,
          M2 = 5.0,
          M3 = 4.9,
          M4 = 4.4,
          M5 = 4.3,
          M6 = 3.8,
          M7 = 3.8,
          M8 = 3.7,
          M9 = 4.0,
          M10 = 4.3,
          M11 = 4.5,
          M12 = 4.7
        },
        TableU3 = new Months()
        {
          M1 = 26.0,
          M2 = 54.0,
          M3 = 96.0,
          M4 = 150.0,
          M5 = 192.0,
          M6 = 200.0,
          M7 = 189.0,
          M8 = 157.0,
          M9 = 115.0,
          M10 = 66.0,
          M11 = 33.0,
          M12 = 21.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 12,
        Latitude = 52.1,
        HeightAboveSeaLevel = 29.0,
        TableU1 = new Months()
        {
          M1 = 4.7,
          M2 = 5.2,
          M3 = 7.0,
          M4 = 9.5,
          M5 = 12.5,
          M6 = 15.4,
          M7 = 17.6,
          M8 = 17.6,
          M9 = 15.0,
          M10 = 11.4,
          M11 = 7.7,
          M12 = 4.7
        },
        TableU2 = new Months()
        {
          M1 = 4.9,
          M2 = 4.8,
          M3 = 4.7,
          M4 = 4.2,
          M5 = 4.2,
          M6 = 3.7,
          M7 = 3.8,
          M8 = 3.8,
          M9 = 4.0,
          M10 = 4.2,
          M11 = 4.3,
          M12 = 4.5
        },
        TableU3 = new Months()
        {
          M1 = 30.0,
          M2 = 58.0,
          M3 = 101.0,
          M4 = 165.0,
          M5 = 203.0,
          M6 = 220.0,
          M7 = 206.0,
          M8 = 173.0,
          M9 = 128.0,
          M10 = 74.0,
          M11 = 39.0,
          M12 = 24.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 13,
        Latitude = 52.6,
        HeightAboveSeaLevel = 138.0,
        TableU1 = new Months()
        {
          M1 = 5.0,
          M2 = 5.3,
          M3 = 6.5,
          M4 = 8.5,
          M5 = 11.2,
          M6 = 13.7,
          M7 = 15.3,
          M8 = 15.3,
          M9 = 13.5,
          M10 = 10.7,
          M11 = 7.8,
          M12 = 5.2
        },
        TableU2 = new Months()
        {
          M1 = 6.5,
          M2 = 6.2,
          M3 = 5.9,
          M4 = 5.2,
          M5 = 5.1,
          M6 = 4.7,
          M7 = 4.5,
          M8 = 4.5,
          M9 = 5.0,
          M10 = 5.7,
          M11 = 6.0,
          M12 = 6.0
        },
        TableU3 = new Months()
        {
          M1 = 29.0,
          M2 = 57.0,
          M3 = 104.0,
          M4 = 164.0,
          M5 = 205.0,
          M6 = 220.0,
          M7 = 199.0,
          M8 = 167.0,
          M9 = 120.0,
          M10 = 68.0,
          M11 = 35.0,
          M12 = 22.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 14,
        Latitude = 55.9,
        HeightAboveSeaLevel = 113.0,
        TableU1 = new Months()
        {
          M1 = 4.0,
          M2 = 4.4,
          M3 = 5.6,
          M4 = 7.9,
          M5 = 10.4,
          M6 = 13.0,
          M7 = 14.5,
          M8 = 14.4,
          M9 = 12.5,
          M10 = 9.3,
          M11 = 6.5,
          M12 = 3.8
        },
        TableU2 = new Months()
        {
          M1 = 6.2,
          M2 = 6.2,
          M3 = 5.9,
          M4 = 5.2,
          M5 = 4.9,
          M6 = 4.7,
          M7 = 4.3,
          M8 = 4.3,
          M9 = 4.9,
          M10 = 5.4,
          M11 = 5.7,
          M12 = 5.4
        },
        TableU3 = new Months()
        {
          M1 = 19.0,
          M2 = 46.0,
          M3 = 88.0,
          M4 = 148.0,
          M5 = 196.0,
          M6 = 193.0,
          M7 = 185.0,
          M8 = 150.0,
          M9 = 101.0,
          M10 = 55.0,
          M11 = 25.0,
          M12 = 15.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 15,
        Latitude = 56.2,
        HeightAboveSeaLevel = 117.0,
        TableU1 = new Months()
        {
          M1 = 3.6,
          M2 = 4.0,
          M3 = 5.4,
          M4 = 7.7,
          M5 = 10.1,
          M6 = 12.9,
          M7 = 14.6,
          M8 = 14.5,
          M9 = 12.5,
          M10 = 9.2,
          M11 = 6.1,
          M12 = 3.2
        },
        TableU2 = new Months()
        {
          M1 = 5.7,
          M2 = 5.8,
          M3 = 5.7,
          M4 = 5.0,
          M5 = 4.8,
          M6 = 4.6,
          M7 = 4.1,
          M8 = 4.1,
          M9 = 4.7,
          M10 = 5.0,
          M11 = 5.2,
          M12 = 5.0
        },
        TableU3 = new Months()
        {
          M1 = 21.0,
          M2 = 46.0,
          M3 = 89.0,
          M4 = 146.0,
          M5 = 198.0,
          M6 = 191.0,
          M7 = 183.0,
          M8 = 150.0,
          M9 = 106.0,
          M10 = 57.0,
          M11 = 27.0,
          M12 = 15.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 16,
        Latitude = 57.3,
        HeightAboveSeaLevel = 123.0,
        TableU1 = new Months()
        {
          M1 = 3.3,
          M2 = 3.6,
          M3 = 5.0,
          M4 = 7.1,
          M5 = 9.3,
          M6 = 12.2,
          M7 = 14.0,
          M8 = 13.9,
          M9 = 12.0,
          M10 = 8.8,
          M11 = 5.7,
          M12 = 2.9
        },
        TableU2 = new Months()
        {
          M1 = 5.7,
          M2 = 5.8,
          M3 = 5.7,
          M4 = 5.0,
          M5 = 4.6,
          M6 = 4.4,
          M7 = 4.0,
          M8 = 4.1,
          M9 = 4.6,
          M10 = 5.2,
          M11 = 5.3,
          M12 = 5.1
        },
        TableU3 = new Months()
        {
          M1 = 19.0,
          M2 = 45.0,
          M3 = 89.0,
          M4 = 143.0,
          M5 = 194.0,
          M6 = 188.0,
          M7 = 177.0,
          M8 = 144.0,
          M9 = 101.0,
          M10 = 54.0,
          M11 = 25.0,
          M12 = 14.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 17,
        Latitude = 57.5,
        HeightAboveSeaLevel = 218.0,
        TableU1 = new Months()
        {
          M1 = 3.1,
          M2 = 3.2,
          M3 = 4.4,
          M4 = 6.6,
          M5 = 8.9,
          M6 = 11.4,
          M7 = 13.2,
          M8 = 13.1,
          M9 = 11.3,
          M10 = 8.2,
          M11 = 5.4,
          M12 = 2.7
        },
        TableU2 = new Months()
        {
          M1 = 6.5,
          M2 = 6.8,
          M3 = 6.4,
          M4 = 5.7,
          M5 = 5.1,
          M6 = 5.1,
          M7 = 4.6,
          M8 = 4.5,
          M9 = 5.3,
          M10 = 5.8,
          M11 = 6.1,
          M12 = 5.7
        },
        TableU3 = new Months()
        {
          M1 = 17.0,
          M2 = 43.0,
          M3 = 85.0,
          M4 = 145.0,
          M5 = 189.0,
          M6 = 185.0,
          M7 = 170.0,
          M8 = 139.0,
          M9 = 98.0,
          M10 = 51.0,
          M11 = 22.0,
          M12 = 12.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 18,
        Latitude = 57.7,
        HeightAboveSeaLevel = 59.0,
        TableU1 = new Months()
        {
          M1 = 5.2,
          M2 = 5.0,
          M3 = 5.8,
          M4 = 7.6,
          M5 = 9.7,
          M6 = 11.8,
          M7 = 13.4,
          M8 = 13.6,
          M9 = 12.1,
          M10 = 9.6,
          M11 = 7.3,
          M12 = 5.2
        },
        TableU2 = new Months()
        {
          M1 = 8.3,
          M2 = 8.4,
          M3 = 7.9,
          M4 = 6.6,
          M5 = 6.1,
          M6 = 6.1,
          M7 = 5.6,
          M8 = 5.6,
          M9 = 6.3,
          M10 = 7.3,
          M11 = 7.7,
          M12 = 7.5
        },
        TableU3 = new Months()
        {
          M1 = 16.0,
          M2 = 41.0,
          M3 = 87.0,
          M4 = 155.0,
          M5 = 205.0,
          M6 = 206.0,
          M7 = 185.0,
          M8 = 148.0,
          M9 = 101.0,
          M10 = 51.0,
          M11 = 21.0,
          M12 = 11.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 19,
        Latitude = 59.0,
        HeightAboveSeaLevel = 53.0,
        TableU1 = new Months()
        {
          M1 = 4.4,
          M2 = 4.2,
          M3 = 5.0,
          M4 = 7.0,
          M5 = 8.9,
          M6 = 11.2,
          M7 = 13.1,
          M8 = 13.2,
          M9 = 11.7,
          M10 = 9.1,
          M11 = 6.6,
          M12 = 4.3
        },
        TableU2 = new Months()
        {
          M1 = 7.9,
          M2 = 8.3,
          M3 = 7.9,
          M4 = 7.1,
          M5 = 6.2,
          M6 = 6.1,
          M7 = 5.5,
          M8 = 5.6,
          M9 = 6.4,
          M10 = 7.3,
          M11 = 7.8,
          M12 = 7.3
        },
        TableU3 = new Months()
        {
          M1 = 14.0,
          M2 = 39.0,
          M3 = 84.0,
          M4 = 143.0,
          M5 = 205.0,
          M6 = 201.0,
          M7 = 178.0,
          M8 = 145.0,
          M9 = 100.0,
          M10 = 50.0,
          M11 = 19.0,
          M12 = 9.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 20,
        Latitude = 60.1,
        HeightAboveSeaLevel = 50.0,
        TableU1 = new Months()
        {
          M1 = 4.6,
          M2 = 4.1,
          M3 = 4.7,
          M4 = 6.5,
          M5 = 8.3,
          M6 = 10.5,
          M7 = 12.4,
          M8 = 12.8,
          M9 = 11.4,
          M10 = 8.8,
          M11 = 6.5,
          M12 = 4.6
        },
        TableU2 = new Months()
        {
          M1 = 9.5,
          M2 = 9.4,
          M3 = 8.7,
          M4 = 7.5,
          M5 = 6.6,
          M6 = 6.4,
          M7 = 5.7,
          M8 = 6.0,
          M9 = 7.2,
          M10 = 8.5,
          M11 = 8.9,
          M12 = 8.5
        },
        TableU3 = new Months()
        {
          M1 = 12.0,
          M2 = 34.0,
          M3 = 79.0,
          M4 = 135.0,
          M5 = 196.0,
          M6 = 190.0,
          M7 = 168.0,
          M8 = 144.0,
          M9 = 90.0,
          M10 = 46.0,
          M11 = 16.0,
          M12 = 7.0
        }
      });
      this.AppendixU.Add(new PCDF.RegionalData()
      {
        ClimateRegion = 21,
        Latitude = 54.6,
        HeightAboveSeaLevel = 72.0,
        TableU1 = new Months()
        {
          M1 = 4.8,
          M2 = 5.2,
          M3 = 6.4,
          M4 = 8.4,
          M5 = 10.9,
          M6 = 13.5,
          M7 = 15.0,
          M8 = 14.9,
          M9 = 13.1,
          M10 = 10.0,
          M11 = 7.2,
          M12 = 4.7
        },
        TableU2 = new Months()
        {
          M1 = 5.4,
          M2 = 5.3,
          M3 = 5.0,
          M4 = 4.7,
          M5 = 4.5,
          M6 = 4.1,
          M7 = 3.9,
          M8 = 3.7,
          M9 = 4.2,
          M10 = 4.6,
          M11 = 5.0,
          M12 = 5.0
        },
        TableU3 = new Months()
        {
          M1 = 24.0,
          M2 = 52.0,
          M3 = 96.0,
          M4 = 155.0,
          M5 = 201.0,
          M6 = 198.0,
          M7 = 183.0,
          M8 = 150.0,
          M9 = 107.0,
          M10 = 61.0,
          M11 = 30.0,
          M12 = 18.0
        }
      });
    }

    public class EcoTable
    {
      public string ImprovementType { get; set; }

      public int LifeTime { get; set; }

      public PCDF.EcoTable.Eligibility EligibleCero { get; set; }

      public PCDF.EcoTable.Eligibility EligibleCsco { get; set; }

      public PCDF.EcoTable.Eligibility EligibleHhcro { get; set; }

      public double InUseFactor { get; set; }

      public string EntryDate { get; set; }

      public string Eco_Name() => !string.IsNullOrEmpty(this.ImprovementType) && Operators.CompareString(this.ImprovementType, "A", false) == 0 ? "Neil is great" : "";

      public enum Eligibility
      {
        No,
        Yes,
        Secondary,
      }
    }

    [Serializable]
    public class HeatingControl
    {
      public string Index { get; set; }

      public string ManuRef { get; set; }

      public string ProductType { get; set; }

      public string _Date { get; set; }

      public string ManuName { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string Qualifier { get; set; }

      public string FirstYear { get; set; }

      public string FinalYear { get; set; }

      public string ControlType { get; set; }

      public string HeatingCategory { get; set; }

      public string Fuel { get; set; }

      public string HeatGeneratorControl { get; set; }

      public string EfficiencyAdjustment { get; set; }

      public string HoursHeating { get; set; }

      public string DelayedStart { get; set; }
    }

    public class HeatingControlFeature
    {
      public string BitNumber { get; set; }

      public string Description { get; set; }

      public string _Date { get; set; }
    }

    [Serializable]
    public class SEDBUK
    {
      public string ID { get; set; }

      public string RefNo { get; set; }

      public string ProductType { get; set; }

      public string EntryUpdate { get; set; }

      public string CurrManu { get; set; }

      public string BrandName { get; set; }

      public string ModelName { get; set; }

      public string ModelQualifier { get; set; }

      public string BoilerID { get; set; }

      public string FirstManu { get; set; }

      public string FinManu { get; set; }

      public string Fuel { get; set; }

      public string MountPosition { get; set; }

      public string ExposureRating { get; set; }

      public string MainType { get; set; }

      public string SubType { get; set; }

      public string SubTypeTable { get; set; }

      public string SubTypeIndex { get; set; }

      public string Condensing { get; set; }

      public string FlueType { get; set; }

      public string FanAssist { get; set; }

      public string BoilPowBot { get; set; }

      public string BoilPowTop { get; set; }

      public string EngEffClss { get; set; }

      public string AnnualEff { get; set; }

      public string WinterEff { get; set; }

      public string SummerEff { get; set; }

      public string HotWaterEff { get; set; }

      public string HotWaterEff2 { get; set; }

      public string SAPEff { get; set; }

      public string EffCat { get; set; }

      public string LPGTstGas { get; set; }

      public string LPGTstCorrection { get; set; }

      public string SAPEqUsed { get; set; }

      public string Ignition { get; set; }

      public string BurnCont { get; set; }

      public string ElPowFire { get; set; }

      public string ElPowNtFire { get; set; }

      public string StrType { get; set; }

      public string StrLoss { get; set; }

      public string StrSep { get; set; }

      public string StrVol { get; set; }

      public string StrSolarVol { get; set; }

      public string StrInsThk { get; set; }

      public string StrInsType { get; set; }

      public string StrTemp { get; set; }

      public string StrHtLoss { get; set; }

      public string SeperateDHWTests { get; set; }

      public string FuelEnergyT1 { get; set; }

      public string ElecEnergyT1 { get; set; }

      public string RejEnergy_r1T1 { get; set; }

      public string StoLossF1 { get; set; }

      public string FuelEnergyT2 { get; set; }

      public string ElecEnergyT2 { get; set; }

      public string RejEnergy_r2T2 { get; set; }

      public string StoLossF2 { get; set; }

      public string StoLossF3 { get; set; }

      public string KpHtFac { get; set; }

      public string KpHtTmr { get; set; }

      public string KpHtElcHtr { get; set; }

      public string CaseLoss { get; set; }

      public string FullOutPower { get; set; }

      public string Type { get; set; }

      public string ControlCapabilities { get; set; }

      public string FlueText
      {
        get
        {
          string flueText;
          try
          {
            string flueType = this.FlueType;
            flueText = Operators.CompareString(flueType, "0", false) == 0 ? "Unknown" : (Operators.CompareString(flueType, "1", false) == 0 ? "Open" : (Operators.CompareString(flueType, "2", false) == 0 ? "Room-sealed" : (Operators.CompareString(flueType, "3", false) == 0 ? "Open or Room-sealed" : "")));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flueText = "";
            ProjectData.ClearProjectError();
          }
          return flueText;
        }
      }

      public string FuelText
      {
        get
        {
          string fuelText;
          try
          {
            string fuel = this.Fuel;
            fuelText = Operators.CompareString(fuel, "1", false) == 0 ? "Mains Gas" : (Operators.CompareString(fuel, "2", false) == 0 ? "bulk LPG" : (Operators.CompareString(fuel, "4", false) == 0 ? "Heating Oil" : (Operators.CompareString(fuel, "39", false) == 0 ? "Electricity" : "")));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            fuelText = "";
            ProjectData.ClearProjectError();
          }
          return fuelText;
        }
      }
    }

    [Serializable]
    public class SEDBUK_Solid
    {
      public string ID { get; set; }

      public string RefNo { get; set; }

      public string ProductType { get; set; }

      public string EntryUpdate { get; set; }

      public string Manu { get; set; }

      public string BrandName { get; set; }

      public string ModelName { get; set; }

      public string ModelQualifier { get; set; }

      public string ProductID { get; set; }

      public string FirstManu { get; set; }

      public string FinManu { get; set; }

      public string Fuel { get; set; }

      public string MainType { get; set; }

      public string Flue { get; set; }

      public string FanAssist { get; set; }

      public string FuelFeed { get; set; }

      public string BoilPowBot { get; set; }

      public string BoilPowTop { get; set; }

      public string BoilPowMinBurn { get; set; }

      public string EngEffClss { get; set; }

      public string SAPEff { get; set; }

      public string EffCat { get; set; }

      public string input_full { get; set; }

      public string water_full { get; set; }

      public string room_full { get; set; }

      public string input_part { get; set; }

      public string water_part { get; set; }

      public string room_part { get; set; }

      public string ple_test { get; set; }

      public string Burner { get; set; }

      public string Elect_1 { get; set; }

      public string Elect_2 { get; set; }

      public string Add_Vent { get; set; }

      public string FlueText
      {
        get
        {
          string flueText;
          try
          {
            string flue = this.Flue;
            flueText = Operators.CompareString(flue, "0", false) == 0 ? "Unknown" : (Operators.CompareString(flue, "1", false) == 0 ? "Open" : (Operators.CompareString(flue, "2", false) == 0 ? "Room-sealed" : (Operators.CompareString(flue, "3", false) == 0 ? "Open or Room-sealed" : "")));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flueText = "";
            ProjectData.ClearProjectError();
          }
          return flueText;
        }
      }

      public string FuelText
      {
        get
        {
          string fuelText;
          try
          {
            string fuel = this.Fuel;
            switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(fuel))
            {
              case 418063755:
                if (Operators.CompareString(fuel, "15", false) == 0)
                {
                  fuelText = "Anthracite";
                  goto label_24;
                }
                else
                  break;
              case 485174231:
                if (Operators.CompareString(fuel, "11", false) == 0)
                {
                  fuelText = "House Coal";
                  goto label_24;
                }
                else
                  break;
              case 501951850:
                if (Operators.CompareString(fuel, "12", false) == 0)
                {
                  fuelText = "Manufactured smokeless fuel";
                  goto label_24;
                }
                else
                  break;
              case 822911587:
                if (Operators.CompareString(fuel, "4", false) == 0)
                {
                  fuelText = "Heating Oil";
                  goto label_24;
                }
                else
                  break;
              case 873244444:
                if (Operators.CompareString(fuel, "1", false) == 0)
                {
                  fuelText = "Mains Gas";
                  goto label_24;
                }
                else
                  break;
              case 923577301:
                if (Operators.CompareString(fuel, "2", false) == 0)
                {
                  fuelText = "bulk LPG";
                  goto label_24;
                }
                else
                  break;
              case 2364708844:
                if (Operators.CompareString(fuel, "21", false) == 0)
                {
                  fuelText = "Wood_Chips";
                  goto label_24;
                }
                else
                  break;
              case 2381486463:
                if (Operators.CompareString(fuel, "20", false) == 0)
                {
                  fuelText = "Wood Logs";
                  goto label_24;
                }
                else
                  break;
              case 2398264082:
                if (Operators.CompareString(fuel, "23", false) == 0)
                {
                  fuelText = "Bulk Wood Pellets";
                  goto label_24;
                }
                else
                  break;
              case 2431672225:
                if (Operators.CompareString(fuel, "39", false) == 0)
                {
                  fuelText = "Electricity";
                  goto label_24;
                }
                else
                  break;
            }
            fuelText = "";
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            fuelText = "";
            ProjectData.ClearProjectError();
          }
label_24:
          return fuelText;
        }
      }
    }

    public class Table4a_B
    {
      public string Code { get; set; }

      public string FirstGroup { get; set; }

      public string SecondGroup { get; set; }

      public string Description { get; set; }

      public string Flue { get; set; }

      public string EffA { get; set; }

      public string EffB { get; set; }

      public string HeatingType { get; set; }

      public string Responsiveness { get; set; }

      public string Controls { get; set; }

      public string Fuel { get; set; }
    }

    public class Table6e
    {
      public string ID { get; set; }

      public string Type { get; set; }

      public string Frame { get; set; }

      public string GAP { get; set; }

      public string UValue { get; set; }
    }

    public class Table4aWater
    {
      public string Code { get; set; }

      public string Description { get; set; }

      public string Efficiency { get; set; }

      public string Fuel { get; set; }
    }

    public class Table_P7
    {
      public string ID { get; set; }

      public string Description { get; set; }

      public string TMP { get; set; }
    }

    public class Table_P1
    {
      public string Build { get; set; }

      public string Window { get; set; }

      public string ach { get; set; }
    }

    public class Table4e
    {
      public string Group { get; set; }

      public string Description { get; set; }

      public string Control { get; set; }

      public string TempAdd { get; set; }

      public string Reference { get; set; }

      public string Code { get; set; }

      public string Band { get; set; }
    }

    public class Products321
    {
      public string ID { get; set; }

      public string RefNo { get; set; }

      public string ProductType { get; set; }

      public string Date1 { get; set; }

      public string Manufacturer { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string ModelQualifier { get; set; }

      public string FirstManu { get; set; }

      public string FinManu { get; set; }

      public string MainType { get; set; }

      public string IntegralOnly { get; set; }

      public string DuctingType { get; set; }

      public string TestDuctSize { get; set; }

      public string SummerByPass { get; set; }

      public string NoofExhausts { get; set; }

      public string TestFlowRates { get; set; }
    }

    public class Products322
    {
      public string ID { get; set; }

      public string RefNo { get; set; }

      public string ProductType { get; set; }

      public string Date1 { get; set; }

      public string Manufacturer { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string ModelQualifier { get; set; }

      public string FirstManu { get; set; }

      public string FinManu { get; set; }

      public string MainType { get; set; }

      public string IntegralOnly { get; set; }

      public string DuctingType { get; set; }

      public string NumbConfigs { get; set; }
    }

    public class Table131
    {
      public string Ref { get; set; }

      public string Rec1 { get; set; }

      public string Range1 { get; set; }

      public string Cost_Type { get; set; }

      public string A_low { get; set; }

      public string B_low { get; set; }

      public string A_High { get; set; }

      public string B_High { get; set; }

      public string Lifetime { get; set; }

      public string GD_cost { get; set; }

      public string in_GD { get; set; }

      public string In_use { get; set; }

      public string In_Use_OA { get; set; }

      public string min_SAP { get; set; }

      public string DBEntryUpdated { get; set; }
    }

    public class Products322_Sub
    {
      public string Ref { get; set; }

      public string Configuration { get; set; }

      public string TestFlowRate { get; set; }

      public string FanSpeed { get; set; }

      public string SFP { get; set; }
    }

    public class Products321_Sub
    {
      public string Ref { get; set; }

      public string AdditionalWetRoom { get; set; }

      public string TestFlowRate { get; set; }

      public string FanSpeed { get; set; }

      public string ApplicableFlowRate { get; set; }

      public string SFP { get; set; }

      public string HeatExchangerEfficiency { get; set; }
    }

    public class HeatPump_Sub
    {
      public string ID { get; set; }

      public string PlantSize_Ratio { get; set; }

      public string SpaceHeating { get; set; }

      public string Specific_Elec_Consumed { get; set; }

      public string Run_hours { get; set; }
    }

    [Serializable]
    public class HeatPump
    {
      public string ID { get; set; }

      public string ManuRef { get; set; }

      public string PropertyType { get; set; }

      public string EntryUpdate { get; set; }

      public string APM { get; set; }

      public string Manu { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string Qualifier { get; set; }

      public string _1st_year { get; set; }

      public string Last_Year { get; set; }

      public string DataQty { get; set; }

      public string Fuel { get; set; }

      public string Emitter_Type { get; set; }

      public string Flue_Type { get; set; }

      public string Heat_Source { get; set; }

      public string ServiceProvision { get; set; }

      public string HWvessel { get; set; }

      public string VesselVol { get; set; }

      public string VesselHeat_Loss { get; set; }

      public string VesselHeat_Exchanger { get; set; }

      public string Energy_eff_Class { get; set; }

      public string WHEffSch2 { get; set; }

      public string NetElecConsumedSch2 { get; set; }

      public string WHEffSch3 { get; set; }

      public string NetElecConsumedSch3 { get; set; }

      public string ControlCapabilities { get; set; }

      public string Reversible { get; set; }

      public string ERR { get; set; }

      public string Max_Output { get; set; }

      public string Heating_Duration { get; set; }

      public string MEV_MVHR { get; set; }

      public string Compen_Effect { get; set; }

      public string SepCirculator { get; set; }

      public string No_AirFlowrates { get; set; }

      public string AirFlow1 { get; set; }

      public string AirFlow2 { get; set; }

      public string AirFlow3 { get; set; }

      public string No_PlantSize { get; set; }

      public string FlueText
      {
        get
        {
          string flueText;
          try
          {
            string flueType = this.Flue_Type;
            flueText = Operators.CompareString(flueType, "0", false) == 0 ? "Unknown" : (Operators.CompareString(flueType, "1", false) == 0 ? "Open" : (Operators.CompareString(flueType, "2", false) == 0 ? "Room-sealed" : (Operators.CompareString(flueType, "3", false) == 0 ? "Open or Room-sealed" : (Operators.CompareString(flueType, "4", false) == 0 ? "None" : ""))));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flueText = "";
            ProjectData.ClearProjectError();
          }
          return flueText;
        }
      }

      public string FuelText
      {
        get
        {
          string fuelText;
          try
          {
            string fuel = this.Fuel;
            fuelText = Operators.CompareString(fuel, "1", false) == 0 ? "Mains Gas" : (Operators.CompareString(fuel, "2", false) == 0 ? "bulk LPG" : (Operators.CompareString(fuel, "4", false) == 0 ? "Heating Oil" : (Operators.CompareString(fuel, "39", false) == 0 ? "Electricity" : "")));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            fuelText = "";
            ProjectData.ClearProjectError();
          }
          return fuelText;
        }
      }
    }

    public class CHP_Sub
    {
      public string ID { get; set; }

      public string PSR { get; set; }

      public string Efficiency { get; set; }

      public string ElecConsumed { get; set; }
    }

    [Serializable]
    public class WarmAir
    {
      public string ID { get; set; }

      public string ManuRef { get; set; }

      public string Status { get; set; }

      public string DBentry { get; set; }

      public string Manuname { get; set; }

      public string Brand_name { get; set; }

      public string Model_name { get; set; }

      public string Model_qualifier { get; set; }

      public string First_year_of_manufacture { get; set; }

      public string Final_year_of_manufacture { get; set; }

      public string Fuel { get; set; }

      public string Mounting_position { get; set; }

      public string Heat_exchanger_type { get; set; }

      public string Condensing { get; set; }

      public string Flue_type { get; set; }

      public string Fan_assistance { get; set; }

      public string Fan_position { get; set; }

      public string Flow_direction { get; set; }

      public string Output_power_bottom { get; set; }

      public string Output_power_top { get; set; }

      public string Energy_efficiency_class { get; set; }

      public string Integral_warm_air_distribution_fan { get; set; }

      public string Specific_fan_power { get; set; }

      public string Water_pump { get; set; }

      public string Pump_electricity { get; set; }

      public string Ignition { get; set; }

      public string Burner_control { get; set; }

      public string Maximum_firing_rate { get; set; }

      public string Minimum_firing_rate { get; set; }

      public string Measured_efficiency_at_full_load { get; set; }

      public string Measured_efficiency_at_minimum_load { get; set; }

      public string Seasonal_heating_efficiency { get; set; }

      public string Electrical_power_while_firing { get; set; }

      public string Electrical_power_while_not_firing { get; set; }

      public string Hot_water_service { get; set; }

      public string Hot_water_service_type { get; set; }

      public string Store_volume { get; set; }

      public string Store_insulation_thickness { get; set; }

      public string Store_loss_factor { get; set; }

      public string Water_heating_efficiency { get; set; }

      public string Separate_DHW_tests { get; set; }

      public string Fuel_energy_for_HW_test_1 { get; set; }

      public string Electrical_energy_for_HW_test_1 { get; set; }

      public string Rejected_energy_r1_in_HW_test_1 { get; set; }

      public string Storage_loss_factor_F1 { get; set; }

      public string Fuel_energy_for_HW_test_2 { get; set; }

      public string Electrical_energy_for_HW_test_2 { get; set; }

      public string Rejected_energy_r2_in_HW_test_2 { get; set; }

      public string Storage_loss_factor_F2 { get; set; }

      public string Rejected_factor_F3 { get; set; }
    }

    [Serializable]
    public class CHP
    {
      public string ID { get; set; }

      public string ManuRef { get; set; }

      public string ProductType { get; set; }

      public string EntryUpdate { get; set; }

      public string APM { get; set; }

      public string Manu { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string Qualifier { get; set; }

      public string _1st_year { get; set; }

      public string Last_Year { get; set; }

      public string Fuel { get; set; }

      public string Condensing { get; set; }

      public string Flue_Type { get; set; }

      public string ServiceProvision { get; set; }

      public string HWVessel { get; set; }

      public string _Class { get; set; }

      public string WHEffSch2 { get; set; }

      public string NetElecConsumedSch2 { get; set; }

      public string WHEffSch3 { get; set; }

      public string NetElecConsumedSch3 { get; set; }

      public string CogenPPowerBottom { get; set; }

      public string CogenPPowerTop { get; set; }

      public string HeatingDuration { get; set; }

      public string SepCirculator { get; set; }

      public string PSR_Numb { get; set; }

      public string FlueText
      {
        get
        {
          string flueText;
          try
          {
            string flueType = this.Flue_Type;
            flueText = Operators.CompareString(flueType, "0", false) == 0 ? "Unknown" : (Operators.CompareString(flueType, "1", false) == 0 ? "Open" : (Operators.CompareString(flueType, "2", false) == 0 ? "Room-sealed" : (Operators.CompareString(flueType, "3", false) == 0 ? "Open or Room-sealed" : "")));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            flueText = "";
            ProjectData.ClearProjectError();
          }
          return flueText;
        }
      }

      public string FuelText
      {
        get
        {
          string fuelText;
          try
          {
            string fuel = this.Fuel;
            fuelText = Operators.CompareString(fuel, "1", false) == 0 ? "Mains Gas" : (Operators.CompareString(fuel, "2", false) == 0 ? "bulk LPG" : (Operators.CompareString(fuel, "4", false) == 0 ? "Heating Oil" : (Operators.CompareString(fuel, "39", false) == 0 ? "Electricity" : "")));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            fuelText = "";
            ProjectData.ClearProjectError();
          }
          return fuelText;
        }
      }
    }

    [Serializable]
    public class CommunityScheme
    {
      public string ID { get; set; }

      public string HeatNetworkVersion { get; set; }

      public string DBEntry { get; set; }

      public string DescriptionofNetwork { get; set; }

      public string ValidityEndDate { get; set; }

      public string CommunityHeatNetwork { get; set; }

      public string PostcodeEnergyCentre { get; set; }

      public string Locality { get; set; }

      public string TownName { get; set; }

      public string AdministrativeArea { get; set; }

      public string DateInitialOperation { get; set; }

      public string TotNumbDwellings { get; set; }

      public string NumberFlats { get; set; }

      public string NonDomFloorArea { get; set; }

      public string TotNumbExistDwellings { get; set; }

      public string ServiceProvision { get; set; }

      public string DataType { get; set; }

      public string Year { get; set; }

      public string HeatMetering { get; set; }

      public string TotalMWhHeatNetwork { get; set; }

      public string TotalMWhHeatDelivered { get; set; }

      public string IndividualDwellingHeatMetering { get; set; }

      public string TotalMWhHeatperAnnum { get; set; }

      public string RouteLength { get; set; }

      public string LinearLoss { get; set; }

      public string DistributionLossFactor { get; set; }

      public string PumpElecEnergy { get; set; }

      public string PumpElecEnergyPerDwelling { get; set; }

      public string CarbonDioxIntensity { get; set; }

      public string PrimaryEnergyFactor { get; set; }
    }

    [Serializable]
    public class CommunityScheme_Sub
    {
      public string ID { get; set; }

      public string NumbHeatSources { get; set; }

      public string HeatSourceType { get; set; }

      public string CommunityFuel { get; set; }

      public string FuelDescription { get; set; }

      public string HeatEfficiency { get; set; }

      public string PowerEfficiency { get; set; }

      public string HeatFraction { get; set; }

      public string CO2Factor { get; set; }

      public string EnergyFactor { get; set; }
    }

    [Serializable]
    public class Storage_Heater
    {
      public string ID { get; set; }

      public string ManuRef { get; set; }

      public string Status { get; set; }

      public string DBEntry { get; set; }

      public string ManuName { get; set; }

      public string BrandName { get; set; }

      public string ModelName { get; set; }

      public string ModelQualifier { get; set; }

      public string FirstYear { get; set; }

      public string FinalYear { get; set; }

      public string StorageCapacity { get; set; }

      public string OutputPower { get; set; }

      public string BoostOutput { get; set; }

      public string HeatRetention { get; set; }

      public string HighHeatRetention { get; set; }

      public string HighHeatRetentionValue => this.HighHeatRetention.Equals("1") ? "Yes" : "No";
    }

    public class InUseMech
    {
      public string SystemType { get; set; }

      public string FlexibleDuctsAdj1 { get; set; }

      public string RigidDuctsAdj1 { get; set; }

      public string NoDuctsAdj1 { get; set; }

      public string UninsulatedDuctsAdj1 { get; set; }

      public string InsulatedDuctsAdj1 { get; set; }

      public string FlexibleDuctsAdj2 { get; set; }

      public string RigidDuctsAdj2 { get; set; }

      public string NoDuctsAdj2 { get; set; }

      public string UninsulatedDuctsAdj2 { get; set; }

      public string InsulatedDuctsAdj2 { get; set; }

      public string Date1 { get; set; }
    }

    public class FGHRS_Sub
    {
      public string ID { get; set; }

      public string SpaceHR { get; set; }

      public string CoefficientA1 { get; set; }

      public string CoefficientB1 { get; set; }

      public string CoefficientC1 { get; set; }

      public string CoefficientA2 { get; set; }

      public string CoefficientB2 { get; set; }

      public string CoefficientC2 { get; set; }
    }

    [Serializable]
    public class FGHRS
    {
      public string ID { get; set; }

      public string RefNo { get; set; }

      public string ProductType { get; set; }

      public string _Date { get; set; }

      public string Manufacturer { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string Model_Qualifier { get; set; }

      public string FirstManu { get; set; }

      public string FinManu { get; set; }

      public string ApplicableFuel { get; set; }

      public string TestFuel { get; set; }

      public string ApplicableBoilerTypes { get; set; }

      public string IntegralOnly { get; set; }

      public string HeatStore { get; set; }

      public string HeatStoreTV { get; set; }

      public string HeatStoreRV { get; set; }

      public string HeatStoreLR { get; set; }

      public string DirectTHR { get; set; }

      public string DirectUHR { get; set; }

      public string PowerCon { get; set; }

      public string PhotovoltaicModule { get; set; }

      public string CableLoss { get; set; }

      public string NoofEquations { get; set; }
    }

    [Serializable]
    public class WWHRS
    {
      public string ID { get; set; }

      public string RefNo { get; set; }

      public string ProductType { get; set; }

      public string _Date { get; set; }

      public string Manufacturer { get; set; }

      public string Brand { get; set; }

      public string Model { get; set; }

      public string Model_Qualifier { get; set; }

      public string FirstManu { get; set; }

      public string FinManu { get; set; }

      public string InstantaneousStorage { get; set; }

      public string SystemType { get; set; }

      public string StorageType { get; set; }

      public string Efficiency { get; set; }

      public string Utilisation_Factor { get; set; }

      public string WasteWaterFraction { get; set; }

      public string TestDedicatedVolume { get; set; }

      public string LowDedicatedVolume { get; set; }

      public string HighDedicatedVolume { get; set; }

      public string ElectricyConsumption { get; set; }
    }

    public class Table10
    {
      public float Base { get; set; }

      public float Value { get; set; }
    }

    public class Table12a
    {
      public string Description { get; set; }

      public int Fuel { get; set; }

      public double SCharge { get; set; }

      public double Price { get; set; }

      public double Emissions { get; set; }

      public double Energy { get; set; }
    }

    public class HistoricTable12SEDBUK
    {
      public HistoricTable12SEDBUK() => this.Table12aSEDBUKs = new List<PCDF.Table12SEDBUK>();

      public string SEDBUKVersion { get; set; }

      public DateTime SEDBUKDate { get; set; }

      public string PricingVersion { get; set; }

      public DateTime PricingDate { get; set; }

      public List<PCDF.Table12SEDBUK> Table12aSEDBUKs { get; set; }
    }

    public class Table12SEDBUK
    {
      public int Cat { get; set; }

      public int Fuel { get; set; }

      public float SCharge { get; set; }

      public float Price { get; set; }

      public string Date1 { get; set; }
    }

    public class RegionalData
    {
      public string Area { get; set; }

      public string District { get; set; }

      public string _Date { get; set; }

      public int ClimateRegion { get; set; }

      public string Country { get; set; }

      public string DistrictOrArea { get; set; }

      public string Region
      {
        get
        {
          string region;
          switch (this.ClimateRegion)
          {
            case 0:
              region = "UK average";
              break;
            case 1:
              region = "Thames valley";
              break;
            case 2:
              region = "South East England";
              break;
            case 3:
              region = "South England";
              break;
            case 4:
              region = "South West England";
              break;
            case 5:
              region = "Severn valley";
              break;
            case 6:
              region = "Midlands";
              break;
            case 7:
              region = "West Pennines";
              break;
            case 8:
              try
              {
                region = Operators.CompareString(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Address.Country, "Scotland", false) != 0 ? "North West England" : "South West Scotland";
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                region = "North West England";
                ProjectData.ClearProjectError();
                break;
              }
            case 9:
              region = "Borders";
              break;
            case 10:
              region = "North East England";
              break;
            case 11:
              region = "East Pennines";
              break;
            case 12:
              region = "East Anglia";
              break;
            case 13:
              region = "Wales";
              break;
            case 14:
              region = "West Scotland";
              break;
            case 15:
              region = "East Scotland";
              break;
            case 16:
              region = "North East Scotland";
              break;
            case 17:
              region = "Highland";
              break;
            case 18:
              region = "Western Isles";
              break;
            case 19:
              region = "Orkney";
              break;
            case 20:
              region = "Shetland";
              break;
            case 21:
              region = "Northern Ireland";
              break;
            default:
              region = "";
              break;
          }
          return region;
        }
      }

      public Months TableU1 { get; set; }

      public Months TableU2 { get; set; }

      public Months TableU3 { get; set; }

      public Months SolarDeclination { get; set; }

      public double Latitude { get; set; }

      public double Longitude { get; set; }

      public double HeightAboveSeaLevel { get; set; }

      public RegionalData()
      {
        this.TableU1 = new Months();
        this.TableU2 = new Months();
        this.TableU3 = new Months();
        this.SolarDeclination = new Months();
        this.SolarDeclination = new Months()
        {
          M1 = -20.7,
          M2 = -12.8,
          M3 = -1.8,
          M4 = 9.8,
          M5 = 18.8,
          M6 = 23.1,
          M7 = 21.2,
          M8 = 13.7,
          M9 = 2.9,
          M10 = -8.7,
          M11 = -18.4,
          M12 = -23.0
        };
      }
    }

    public class TableU5Constants
    {
      public string Orientation { get; set; }

      public float k1 { get; set; }

      public float k2 { get; set; }

      public float k3 { get; set; }

      public float k4 { get; set; }

      public float k5 { get; set; }

      public float k6 { get; set; }

      public float k7 { get; set; }

      public float k8 { get; set; }

      public float k9 { get; set; }
    }
  }
}
