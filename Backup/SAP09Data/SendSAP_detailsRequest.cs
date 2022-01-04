
// Type: SAP2012.SAP09Data.SendSAP_detailsRequest




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
  public class SendSAP_detailsRequest
  {
    [MessageBodyMember(Name = "SendSAP_details", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx", Order = 0)]
    public SendSAP_detailsRequestBody Body;

    public SendSAP_detailsRequest()
    {
    }

    public SendSAP_detailsRequest(SendSAP_detailsRequestBody Body) => this.Body = Body;
  }
}
