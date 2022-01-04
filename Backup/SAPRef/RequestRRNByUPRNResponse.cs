
// Type: SAP2012.SAPRef.RequestRRNByUPRNResponse




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
  public class RequestRRNByUPRNResponse
  {
    [MessageBodyMember(Name = "RequestRRNByUPRNResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public RequestRRNByUPRNResponseBody Body;

    public RequestRRNByUPRNResponse()
    {
    }

    public RequestRRNByUPRNResponse(RequestRRNByUPRNResponseBody Body) => this.Body = Body;
  }
}
