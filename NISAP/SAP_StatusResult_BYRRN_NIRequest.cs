
// Type: SAP2012.NISAP.SAP_StatusResult_BYRRN_NIRequest




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
  public class SAP_StatusResult_BYRRN_NIRequest
  {
    [MessageBodyMember(Name = "SAP_StatusResult_BYRRN_NI", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public SAP_StatusResult_BYRRN_NIRequestBody Body;

    public SAP_StatusResult_BYRRN_NIRequest()
    {
    }

    public SAP_StatusResult_BYRRN_NIRequest(SAP_StatusResult_BYRRN_NIRequestBody Body) => this.Body = Body;
  }
}
