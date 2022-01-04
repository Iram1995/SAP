
// Type: SAP2012.ScotlandService.DownLoadEPC_byRRNResponse




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
  public class DownLoadEPC_byRRNResponse
  {
    [MessageBodyMember(Name = "DownLoadEPC_byRRNResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DownLoadEPC_byRRNResponseBody Body;

    public DownLoadEPC_byRRNResponse()
    {
    }

    public DownLoadEPC_byRRNResponse(DownLoadEPC_byRRNResponseBody Body) => this.Body = Body;
  }
}
