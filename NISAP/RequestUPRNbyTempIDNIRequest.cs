
// Type: SAP2012.NISAP.RequestUPRNbyTempIDNIRequest




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
  public class RequestUPRNbyTempIDNIRequest
  {
    [MessageBodyMember(Name = "RequestUPRNbyTempIDNI", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public RequestUPRNbyTempIDNIRequestBody Body;

    public RequestUPRNbyTempIDNIRequest()
    {
    }

    public RequestUPRNbyTempIDNIRequest(RequestUPRNbyTempIDNIRequestBody Body) => this.Body = Body;
  }
}
