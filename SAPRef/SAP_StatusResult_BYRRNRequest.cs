
// Type: SAP2012.SAPRef.SAP_StatusResult_BYRRNRequest




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
  public class SAP_StatusResult_BYRRNRequest
  {
    [MessageBodyMember(Name = "SAP_StatusResult_BYRRN", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public SAP_StatusResult_BYRRNRequestBody Body;

    public SAP_StatusResult_BYRRNRequest()
    {
    }

    public SAP_StatusResult_BYRRNRequest(SAP_StatusResult_BYRRNRequestBody Body) => this.Body = Body;
  }
}
