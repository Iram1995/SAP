
// Type: SAP2012.NISAP.Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest




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
  public class Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest
  {
    [MessageBodyMember(Name = "Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody Body;

    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest()
    {
    }

    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest(
      Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody Body)
    {
      this.Body = Body;
    }
  }
}
