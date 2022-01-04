
// Type: SAP2012.NISAP.Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse




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
  public class Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse
  {
    [MessageBodyMember(Name = "Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponseBody Body;

    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse()
    {
    }

    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse(
      Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponseBody Body)
    {
      this.Body = Body;
    }
  }
}
