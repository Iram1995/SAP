
// Type: SAP2012.SAPRef.LodgeScotlandXMLRequest




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
  public class LodgeScotlandXMLRequest
  {
    [MessageBodyMember(Name = "LodgeScotlandXML", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public LodgeScotlandXMLRequestBody Body;

    public LodgeScotlandXMLRequest()
    {
    }

    public LodgeScotlandXMLRequest(LodgeScotlandXMLRequestBody Body) => this.Body = Body;
  }
}
