
// Type: SAP2012.NISAP.RequestRRNByUPRN_NIRequest




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
  public class RequestRRNByUPRN_NIRequest
  {
    [MessageBodyMember(Name = "RequestRRNByUPRN_NI", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public RequestRRNByUPRN_NIRequestBody Body;

    public RequestRRNByUPRN_NIRequest()
    {
    }

    public RequestRRNByUPRN_NIRequest(RequestRRNByUPRN_NIRequestBody Body) => this.Body = Body;
  }
}
