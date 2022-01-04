
// Type: SAP2012.SAPRef.ChecksapimportpermissionRequest




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class ChecksapimportpermissionRequest
  {
    [MessageBodyMember(Name = "Checksapimportpermission", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public ChecksapimportpermissionRequestBody Body;

    public ChecksapimportpermissionRequest()
    {
    }

    public ChecksapimportpermissionRequest(ChecksapimportpermissionRequestBody Body) => this.Body = Body;
  }
}
