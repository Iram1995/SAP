
// Type: SAP2012.NISAP.DownLoadNIEPC_byRRNRequest




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
  public class DownLoadNIEPC_byRRNRequest
  {
    [MessageBodyMember(Name = "DownLoadNIEPC_byRRN", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public DownLoadNIEPC_byRRNRequestBody Body;

    public DownLoadNIEPC_byRRNRequest()
    {
    }

    public DownLoadNIEPC_byRRNRequest(DownLoadNIEPC_byRRNRequestBody Body) => this.Body = Body;
  }
}
