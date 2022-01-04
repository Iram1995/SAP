
// Type: SAP2012.NISAP.RequestUPRNbyTempIDNIResponse




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
  public class RequestUPRNbyTempIDNIResponse
  {
    [MessageBodyMember(Name = "RequestUPRNbyTempIDNIResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public RequestUPRNbyTempIDNIResponseBody Body;

    public RequestUPRNbyTempIDNIResponse()
    {
    }

    public RequestUPRNbyTempIDNIResponse(RequestUPRNbyTempIDNIResponseBody Body) => this.Body = Body;
  }
}
