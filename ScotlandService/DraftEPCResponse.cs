
// Type: SAP2012.ScotlandService.DraftEPCResponse




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
  public class DraftEPCResponse
  {
    [MessageBodyMember(Name = "DraftEPCResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DraftEPCResponseBody Body;

    public DraftEPCResponse()
    {
    }

    public DraftEPCResponse(DraftEPCResponseBody Body) => this.Body = Body;
  }
}
