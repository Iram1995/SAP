
// Type: SAP2012.ScotlandService.GenerateRRNByUPRNRequest




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
  public class GenerateRRNByUPRNRequest
  {
    [MessageBodyMember(Name = "GenerateRRNByUPRN", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public GenerateRRNByUPRNRequestBody Body;

    public GenerateRRNByUPRNRequest()
    {
    }

    public GenerateRRNByUPRNRequest(GenerateRRNByUPRNRequestBody Body) => this.Body = Body;
  }
}
