
// Type: SAP2012.SAP09Data.SendCompliance_DetailsResponse




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
  public class SendCompliance_DetailsResponse
  {
    [MessageBodyMember(Name = "SendCompliance_DetailsResponse", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx", Order = 0)]
    public SendCompliance_DetailsResponseBody Body;

    public SendCompliance_DetailsResponse()
    {
    }

    public SendCompliance_DetailsResponse(SendCompliance_DetailsResponseBody Body) => this.Body = Body;
  }
}
