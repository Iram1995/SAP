
// Type: SAP2012.My.MyApplication




using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SAP2012.My
{
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [STAThread]
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.Splash;
  }
}
