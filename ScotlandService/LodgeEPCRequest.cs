
// Type: SAP2012.ScotlandService.LodgeEPCRequest




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
  public class LodgeEPCRequest
  {
    [MessageBodyMember(Name = "LodgeEPC", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public LodgeEPCRequestBody Body;

    public LodgeEPCRequest()
    {
    }

    public LodgeEPCRequest(LodgeEPCRequestBody Body) => this.Body = Body;
  }
}
