
// Type: SAP2012.NISAP.RequestRRNByUPRN_NIResponse




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
  public class RequestRRNByUPRN_NIResponse
  {
    [MessageBodyMember(Name = "RequestRRNByUPRN_NIResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public RequestRRNByUPRN_NIResponseBody Body;

    public RequestRRNByUPRN_NIResponse()
    {
    }

    public RequestRRNByUPRN_NIResponse(RequestRRNByUPRN_NIResponseBody Body) => this.Body = Body;
  }
}
