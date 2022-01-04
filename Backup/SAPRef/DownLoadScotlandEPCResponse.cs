
// Type: SAP2012.SAPRef.DownLoadScotlandEPCResponse




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class DownLoadScotlandEPCResponse
  {
    [MessageBodyMember(Name = "DownLoadScotlandEPCResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadScotlandEPCResponseBody Body;

    public DownLoadScotlandEPCResponse()
    {
    }

    public DownLoadScotlandEPCResponse(DownLoadScotlandEPCResponseBody Body) => this.Body = Body;
  }
}
