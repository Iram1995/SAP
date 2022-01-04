
// Type: SAP2012.NISAP.Request_NI_UPRNByStreetNumberAndPostCodeResponse




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
  public class Request_NI_UPRNByStreetNumberAndPostCodeResponse
  {
    [MessageBodyMember(Name = "Request_NI_UPRNByStreetNumberAndPostCodeResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Request_NI_UPRNByStreetNumberAndPostCodeResponseBody Body;

    public Request_NI_UPRNByStreetNumberAndPostCodeResponse()
    {
    }

    public Request_NI_UPRNByStreetNumberAndPostCodeResponse(
      Request_NI_UPRNByStreetNumberAndPostCodeResponseBody Body)
    {
      this.Body = Body;
    }
  }
}
