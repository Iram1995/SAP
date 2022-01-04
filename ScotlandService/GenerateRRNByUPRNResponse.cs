
// Type: SAP2012.ScotlandService.GenerateRRNByUPRNResponse




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
  public class GenerateRRNByUPRNResponse
  {
    [MessageBodyMember(Name = "GenerateRRNByUPRNResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public GenerateRRNByUPRNResponseBody Body;

    public GenerateRRNByUPRNResponse()
    {
    }

    public GenerateRRNByUPRNResponse(GenerateRRNByUPRNResponseBody Body) => this.Body = Body;
  }
}
