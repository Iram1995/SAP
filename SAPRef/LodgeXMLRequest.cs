
// Type: SAP2012.SAPRef.LodgeXMLRequest




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
  public class LodgeXMLRequest
  {
    [MessageBodyMember(Name = "LodgeXML", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public LodgeXMLRequestBody Body;

    public LodgeXMLRequest()
    {
    }

    public LodgeXMLRequest(LodgeXMLRequestBody Body) => this.Body = Body;
  }
}
