
// Type: SAP2012.NISAP.Request_NI_UPRNbyLongAddressRequest




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
  public class Request_NI_UPRNbyLongAddressRequest
  {
    [MessageBodyMember(Name = "Request_NI_UPRNbyLongAddress", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Request_NI_UPRNbyLongAddressRequestBody Body;

    public Request_NI_UPRNbyLongAddressRequest()
    {
    }

    public Request_NI_UPRNbyLongAddressRequest(Request_NI_UPRNbyLongAddressRequestBody Body) => this.Body = Body;
  }
}
