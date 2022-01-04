
// Type: SAP2012.SAPRef.HomeInspectorDetailsRequest




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
  public class HomeInspectorDetailsRequest
  {
    [MessageBodyMember(Name = "HomeInspectorDetails", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public HomeInspectorDetailsRequestBody Body;

    public HomeInspectorDetailsRequest()
    {
    }

    public HomeInspectorDetailsRequest(HomeInspectorDetailsRequestBody Body) => this.Body = Body;
  }
}
