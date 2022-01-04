
// Type: SAP2012.NISAP.LodgeXML_NIResponse




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
  public class LodgeXML_NIResponse
  {
    [MessageBodyMember(Name = "LodgeXML_NIResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public LodgeXML_NIResponseBody Body;

    public LodgeXML_NIResponse()
    {
    }

    public LodgeXML_NIResponse(LodgeXML_NIResponseBody Body) => this.Body = Body;
  }
}
