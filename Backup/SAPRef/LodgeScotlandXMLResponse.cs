
// Type: SAP2012.SAPRef.LodgeScotlandXMLResponse




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
  public class LodgeScotlandXMLResponse
  {
    [MessageBodyMember(Name = "LodgeScotlandXMLResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public LodgeScotlandXMLResponseBody Body;

    public LodgeScotlandXMLResponse()
    {
    }

    public LodgeScotlandXMLResponse(LodgeScotlandXMLResponseBody Body) => this.Body = Body;
  }
}
