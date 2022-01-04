
// Type: SAP2012.SAP09Data.SendCompliance_DetailsRequest




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
  public class SendCompliance_DetailsRequest
  {
    [MessageBodyMember(Name = "SendCompliance_Details", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx", Order = 0)]
    public SendCompliance_DetailsRequestBody Body;

    public SendCompliance_DetailsRequest()
    {
    }

    public SendCompliance_DetailsRequest(SendCompliance_DetailsRequestBody Body) => this.Body = Body;
  }
}
