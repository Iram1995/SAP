
// Type: SAP2012.SAPRef.SAP_DraftsResponse




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
  public class SAP_DraftsResponse
  {
    [MessageBodyMember(Name = "SAP_DraftsResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public SAP_DraftsResponseBody Body;

    public SAP_DraftsResponse()
    {
    }

    public SAP_DraftsResponse(SAP_DraftsResponseBody Body) => this.Body = Body;
  }
}
