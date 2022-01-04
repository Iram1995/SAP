
// Type: SAP2012.SAPRef.StromaDetailsResponse




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
  public class StromaDetailsResponse
  {
    [MessageBodyMember(Name = "StromaDetailsResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public StromaDetailsResponseBody Body;

    public StromaDetailsResponse()
    {
    }

    public StromaDetailsResponse(StromaDetailsResponseBody Body) => this.Body = Body;
  }
}
