
// Type: SAP2012.NISAP.LodgeXML_NIRequest




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
  public class LodgeXML_NIRequest
  {
    [MessageBodyMember(Name = "LodgeXML_NI", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public LodgeXML_NIRequestBody Body;

    public LodgeXML_NIRequest()
    {
    }

    public LodgeXML_NIRequest(LodgeXML_NIRequestBody Body) => this.Body = Body;
  }
}
