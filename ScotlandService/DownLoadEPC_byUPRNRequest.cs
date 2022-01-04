
// Type: SAP2012.ScotlandService.DownLoadEPC_byUPRNRequest




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
  public class DownLoadEPC_byUPRNRequest
  {
    [MessageBodyMember(Name = "DownLoadEPC_byUPRN", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DownLoadEPC_byUPRNRequestBody Body;

    public DownLoadEPC_byUPRNRequest()
    {
    }

    public DownLoadEPC_byUPRNRequest(DownLoadEPC_byUPRNRequestBody Body) => this.Body = Body;
  }
}
