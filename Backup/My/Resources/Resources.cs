
// Type: SAP2012.My.Resources.Resources




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SAP2012.My.Resources
{
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) SAP2012.My.Resources.Resources.resourceMan, (object) null))
          SAP2012.My.Resources.Resources.resourceMan = new ResourceManager("SAP2012.Resources", typeof (SAP2012.My.Resources.Resources).Assembly);
        return SAP2012.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => SAP2012.My.Resources.Resources.resourceCulture;
      set => SAP2012.My.Resources.Resources.resourceCulture = value;
    }

    internal static Bitmap _1 => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject("1", SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap close111 => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject(nameof (close111), SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap Cross12 => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject(nameof (Cross12), SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap info_icon => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject("info-icon", SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap LOGO_accreditation => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject(nameof (LOGO_accreditation), SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap RoomInRoof => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject(nameof (RoomInRoof), SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap xls => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject(nameof (xls), SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap xls__1_ => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject("xls (1)", SAP2012.My.Resources.Resources.resourceCulture));

    internal static Bitmap xls_open_file_format => (Bitmap) RuntimeHelpers.GetObjectValue(SAP2012.My.Resources.Resources.ResourceManager.GetObject("xls-open-file-format", SAP2012.My.Resources.Resources.resourceCulture));
  }
}
