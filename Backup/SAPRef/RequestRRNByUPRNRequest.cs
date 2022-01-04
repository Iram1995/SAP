
// Type: SAP2012.SAPRef.RequestRRNByUPRNRequest




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
  public class RequestRRNByUPRNRequest
  {
    [MessageBodyMember(Name = "RequestRRNByUPRN", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public RequestRRNByUPRNRequestBody Body;

    public RequestRRNByUPRNRequest()
    {
    }

    public RequestRRNByUPRNRequest(RequestRRNByUPRNRequestBody Body) => this.Body = Body;
  }
}
