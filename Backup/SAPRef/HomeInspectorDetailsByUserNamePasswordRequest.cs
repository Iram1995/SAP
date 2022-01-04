
// Type: SAP2012.SAPRef.HomeInspectorDetailsByUserNamePasswordRequest




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
  public class HomeInspectorDetailsByUserNamePasswordRequest
  {
    [MessageBodyMember(Name = "HomeInspectorDetailsByUserNamePassword", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public HomeInspectorDetailsByUserNamePasswordRequestBody Body;

    public HomeInspectorDetailsByUserNamePasswordRequest()
    {
    }

    public HomeInspectorDetailsByUserNamePasswordRequest(
      HomeInspectorDetailsByUserNamePasswordRequestBody Body)
    {
      this.Body = Body;
    }
  }
}
