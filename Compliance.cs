
// Type: SAP2012.Compliance




using Microsoft.VisualBasic.CompilerServices;
using SAP2012.My;
using System.Drawing;

namespace SAP2012
{
  [StandardModule]
  internal sealed class Compliance
  {
    public static Compliance.ComplianceList Compliance1;

    public static bool CheckCompliance(int House)
    {
      // ISSUE: unable to decompile the method.
    }

    public static void Inital()
    {
      Compliance.Compliance1.Main_Fuel = "";
      Compliance.Compliance1.BandNme = "";
      Compliance.Compliance1.Model = "";
      Compliance.Compliance1.ModelQual = "";
      Compliance.Compliance1.Com = "";
      Compliance.Compliance1.BoilerSystem = "";
      Compliance.Compliance1.TERCheck = 0.0;
      Compliance.Compliance1.DERCHeck = 0.0;
      Compliance.Compliance1.DataBase_eFf = 0.0;
      MyProject.Forms.GenResults.Button231.Enabled = false;
      Compliance.Compliance1.SecMinEf = 0.0;
      Compliance.Compliance1.Maxeff = 0.0;
      Compliance.Compliance1.MinEff = 0.0;
      Compliance.Compliance1.CylinderFound = false;
      MyProject.Forms.GenResults.Btn254.Text = "26.4 Independent timer for DHW";
      MyProject.Forms.GenResults.Btn231.Text = "4.1 Main Heating";
      MyProject.Forms.GenResults.Button231.Text = "4.2 Main Heating 2";
      MyProject.Forms.GenResults.Button2111.Text = "2.1.1 Party Wall";
      MyProject.Forms.GenResults.Btn2411.Text = "5.2 Primary Pipe work               N/A";
      MyProject.Forms.GenResults.Btn241.Text = "5.1 Hot water Storage               N/A";
      MyProject.Forms.GenResults.Btn242.Text = "5.3 Solar Storage Volume               N/A";
      MyProject.Forms.GenResults.Btn251.Text = "6.1  Space Heating Controls 1               N/A";
      MyProject.Forms.GenResults.Button251.Text = "6.2 Space Heating Controls 2               N/A";
      MyProject.Forms.GenResults.Btn252.Text = "Boiler interlock               N/A";
      MyProject.Forms.GenResults.Btn253.Text = "6.3 Cylinderstat               N/A";
      MyProject.Forms.GenResults.Btn254.Text = "6.4 Independent timer for DHW               N/A";
      MyProject.Forms.GenResults.btn260.Text = "7 Low energy lights";
      MyProject.Forms.GenResults.Button1.Text = "8 Mechanical ventilation";
      MyProject.Forms.GenResults.Btn31.Text = "9 Summertime Temperature";
      MyProject.Forms.GenResults.Button32Sec.Text = "4.3 Secondary Heating System      ";
      MyProject.Forms.GenResults.Btn2411.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn241.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn242.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn251.BackColor = Color.Green;
      MyProject.Forms.GenResults.Button32Sec.BackColor = Color.Green;
      MyProject.Forms.GenResults.Button251.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn252.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn253.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn254.BackColor = Color.Green;
      MyProject.Forms.GenResults.btn260.BackColor = Color.Green;
      MyProject.Forms.GenResults.Button1.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn31.BackColor = Color.Green;
      MyProject.Forms.GenResults.Button2111.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn231.BackColor = Color.Green;
      MyProject.Forms.GenResults.Button231.BackColor = Color.Green;
      MyProject.Forms.GenResults.Btn254.BackColor = Color.Green;
    }

    public struct ComplianceList
    {
      public int x;
      public string Main_Fuel;
      public string BandNme;
      public string Model;
      public string ModelQual;
      public string Com;
      public string BoilerSystem;
      public double TERCheck;
      public double DERCHeck;
      public double DataBase_eFf;
      public double MinEff;
      public double Maxeff;
      public double SecMinEf;
      public bool CylinderFound;
    }
  }
}
