
// Type: SAP2012.NISAP.Request_NI_UPRNbyTempIDRequest




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class Request_NI_UPRNbyTempIDRequest
  {
    [MessageBodyMember(Name = "Request_NI_UPRNbyTempID", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Request_NI_UPRNbyTempIDRequestBody Body;

    public Request_NI_UPRNbyTempIDRequest()
    {
    }

    public Request_NI_UPRNbyTempIDRequest(Request_NI_UPRNbyTempIDRequestBody Body) => this.Body = Body;
  }
}
