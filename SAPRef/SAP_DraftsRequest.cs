
// Type: SAP2012.SAPRef.SAP_DraftsRequest




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
  public class SAP_DraftsRequest
  {
    [MessageBodyMember(Name = "SAP_Drafts", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public SAP_DraftsRequestBody Body;

    public SAP_DraftsRequest()
    {
    }

    public SAP_DraftsRequest(SAP_DraftsRequestBody Body) => this.Body = Body;
  }
}
