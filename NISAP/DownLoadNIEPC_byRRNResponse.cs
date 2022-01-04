
// Type: SAP2012.NISAP.DownLoadNIEPC_byRRNResponse




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
  public class DownLoadNIEPC_byRRNResponse
  {
    [MessageBodyMember(Name = "DownLoadNIEPC_byRRNResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public DownLoadNIEPC_byRRNResponseBody Body;

    public DownLoadNIEPC_byRRNResponse()
    {
    }

    public DownLoadNIEPC_byRRNResponse(DownLoadNIEPC_byRRNResponseBody Body) => this.Body = Body;
  }
}
