
// Type: SAP2012.My.MySettings




using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SAP2012.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          Monitor.Enter(handlerLockObject);
          try
          {
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            Monitor.Exit(handlerLockObject);
          }
        }
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string AccreditationNo
    {
      get => Conversions.ToString(this[nameof (AccreditationNo)]);
      set => this[nameof (AccreditationNo)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string UserName
    {
      get => Conversions.ToString(this[nameof (UserName)]);
      set => this[nameof (UserName)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string PassWord
    {
      get => Conversions.ToString(this[nameof (PassWord)]);
      set => this[nameof (PassWord)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Company
    {
      get => Conversions.ToString(this[nameof (Company)]);
      set => this[nameof (Company)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Address1
    {
      get => Conversions.ToString(this[nameof (Address1)]);
      set => this[nameof (Address1)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Address2
    {
      get => Conversions.ToString(this[nameof (Address2)]);
      set => this[nameof (Address2)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Address3
    {
      get => Conversions.ToString(this[nameof (Address3)]);
      set => this[nameof (Address3)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Town
    {
      get => Conversions.ToString(this[nameof (Town)]);
      set => this[nameof (Town)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string PostCode
    {
      get => Conversions.ToString(this[nameof (PostCode)]);
      set => this[nameof (PostCode)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Phone
    {
      get => Conversions.ToString(this[nameof (Phone)]);
      set => this[nameof (Phone)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Fax
    {
      get => Conversions.ToString(this[nameof (Fax)]);
      set => this[nameof (Fax)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Email
    {
      get => Conversions.ToString(this[nameof (Email)]);
      set => this[nameof (Email)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string WebAddress
    {
      get => Conversions.ToString(this[nameof (WebAddress)]);
      set => this[nameof (WebAddress)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Prefix
    {
      get => Conversions.ToString(this[nameof (Prefix)]);
      set => this[nameof (Prefix)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Suffix
    {
      get => Conversions.ToString(this[nameof (Suffix)]);
      set => this[nameof (Suffix)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string FirstName
    {
      get => Conversions.ToString(this[nameof (FirstName)]);
      set => this[nameof (FirstName)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string LastName
    {
      get => Conversions.ToString(this[nameof (LastName)]);
      set => this[nameof (LastName)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool DisplayNotes
    {
      get => Conversions.ToBoolean(this[nameof (DisplayNotes)]);
      set => this[nameof (DisplayNotes)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool SetDisplayNotes
    {
      get => Conversions.ToBoolean(this[nameof (SetDisplayNotes)]);
      set => this[nameof (SetDisplayNotes)] = (object) value;
    }
  }
}
