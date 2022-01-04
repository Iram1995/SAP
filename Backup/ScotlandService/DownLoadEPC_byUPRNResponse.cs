
// Type: SAP2012.ScotlandService.DownLoadEPC_byUPRNResponse




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
  public class DownLoadEPC_byUPRNResponse
  {
    [MessageBodyMember(Name = "DownLoadEPC_byUPRNResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DownLoadEPC_byUPRNResponseBody Body;

    public DownLoadEPC_byUPRNResponse()
    {
    }

    public DownLoadEPC_byUPRNResponse(DownLoadEPC_byUPRNResponseBody Body) => this.Body = Body;
  }
}
