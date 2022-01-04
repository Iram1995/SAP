
// Type: SAP2012.SAP09Data.SendSAP_detailsResponse




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class SendSAP_detailsResponse
  {
    [MessageBodyMember(Name = "SendSAP_detailsResponse", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx", Order = 0)]
    public SendSAP_detailsResponseBody Body;

    public SendSAP_detailsResponse()
    {
    }

    public SendSAP_detailsResponse(SendSAP_detailsResponseBody Body) => this.Body = Body;
  }
}
