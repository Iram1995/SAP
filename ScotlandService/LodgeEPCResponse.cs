
// Type: SAP2012.ScotlandService.LodgeEPCResponse




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.ScotlandService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class LodgeEPCResponse
  {
    [MessageBodyMember(Name = "LodgeEPCResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public LodgeEPCResponseBody Body;

    public LodgeEPCResponse()
    {
    }

    public LodgeEPCResponse(LodgeEPCResponseBody Body) => this.Body = Body;
  }
}
