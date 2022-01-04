
// Type: SAP2012.NISAP.SAP_StatusResult_BYRRN_NIResponse




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
  public class SAP_StatusResult_BYRRN_NIResponse
  {
    [MessageBodyMember(Name = "SAP_StatusResult_BYRRN_NIResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public SAP_StatusResult_BYRRN_NIResponseBody Body;

    public SAP_StatusResult_BYRRN_NIResponse()
    {
    }

    public SAP_StatusResult_BYRRN_NIResponse(SAP_StatusResult_BYRRN_NIResponseBody Body) => this.Body = Body;
  }
}
