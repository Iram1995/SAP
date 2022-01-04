
// Type: SAP2012.NISAP.Request_NI_UPRNByStreetNumberAndPostCodeRequest




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
  public class Request_NI_UPRNByStreetNumberAndPostCodeRequest
  {
    [MessageBodyMember(Name = "Request_NI_UPRNByStreetNumberAndPostCode", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Request_NI_UPRNByStreetNumberAndPostCodeRequestBody Body;

    public Request_NI_UPRNByStreetNumberAndPostCodeRequest()
    {
    }

    public Request_NI_UPRNByStreetNumberAndPostCodeRequest(
      Request_NI_UPRNByStreetNumberAndPostCodeRequestBody Body)
    {
      this.Body = Body;
    }
  }
}
