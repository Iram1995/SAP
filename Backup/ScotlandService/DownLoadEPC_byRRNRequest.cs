
// Type: SAP2012.ScotlandService.DownLoadEPC_byRRNRequest




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
  public class DownLoadEPC_byRRNRequest
  {
    [MessageBodyMember(Name = "DownLoadEPC_byRRN", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DownLoadEPC_byRRNRequestBody Body;

    public DownLoadEPC_byRRNRequest()
    {
    }

    public DownLoadEPC_byRRNRequest(DownLoadEPC_byRRNRequestBody Body) => this.Body = Body;
  }
}
