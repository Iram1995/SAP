
// Type: SAP2012.SAPRef.LodgeXMLResponse




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
  public class LodgeXMLResponse
  {
    [MessageBodyMember(Name = "LodgeXMLResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public LodgeXMLResponseBody Body;

    public LodgeXMLResponse()
    {
    }

    public LodgeXMLResponse(LodgeXMLResponseBody Body) => this.Body = Body;
  }
}
