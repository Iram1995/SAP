
// Type: SAP2012.SAPRef.HomeInspectorDetailsResponse




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
  public class HomeInspectorDetailsResponse
  {
    [MessageBodyMember(Name = "HomeInspectorDetailsResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public HomeInspectorDetailsResponseBody Body;

    public HomeInspectorDetailsResponse()
    {
    }

    public HomeInspectorDetailsResponse(HomeInspectorDetailsResponseBody Body) => this.Body = Body;
  }
}
