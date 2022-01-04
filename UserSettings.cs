
// Type: SAP2012.UserSettings




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SAP2012
{
  [StandardModule]
  internal sealed class UserSettings
  {
    public static UserSettings.UsSettings USettings = new UserSettings.UsSettings();

    public static bool SaveSettings(UserSettings.UsSettings UData, string FullPath)
    {
      FileStream serializationStream = File.Open(FullPath, FileMode.OpenOrCreate);
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      bool flag;
      try
      {
        binaryFormatter.Serialize((Stream) serializationStream, (object) UData);
        serializationStream.Close();
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static UserSettings.UsSettings GetSettings(string FullPath)
    {
      UserSettings.UsSettings settings = new UserSettings.UsSettings();
      try
      {
        FileStream serializationStream = File.Open(FullPath, FileMode.Open);
        settings = (UserSettings.UsSettings) new BinaryFormatter().Deserialize((Stream) serializationStream);
        serializationStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) Information.Err().Description);
        ProjectData.ClearProjectError();
      }
      return settings;
    }

    [Serializable]
    public struct UsSettings
    {
      public string[] Files;
      public string UserName;
      public string Password;
      public string Version;
      public UserSettings.UserPrintSettings PrintUserSettings;
    }

    [Serializable]
    public struct UserPrintSettings
    {
      public bool Print;
      public string CompanyName;
      public string ContactName;
      public string PhoneNo;
      public string ContactEmail;
    }
  }
}
