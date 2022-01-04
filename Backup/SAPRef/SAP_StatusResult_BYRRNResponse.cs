
// Type: SAP2012.SAPRef.SAP_StatusResult_BYRRNResponse




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
  public class SAP_StatusResult_BYRRNResponse
  {
    [MessageBodyMember(Name = "SAP_StatusResult_BYRRNResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public SAP_StatusResult_BYRRNResponseBody Body;

    public SAP_StatusResult_BYRRNResponse()
    {
    }

    public SAP_StatusResult_BYRRNResponse(SAP_StatusResult_BYRRNResponseBody Body) => this.Body = Body;
  }
}
