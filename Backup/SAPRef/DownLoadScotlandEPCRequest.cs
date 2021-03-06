
// Type: SAP2012.SAPRef.DownLoadScotlandEPCRequest




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
  public class DownLoadScotlandEPCRequest
  {
    [MessageBodyMember(Name = "DownLoadScotlandEPC", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadScotlandEPCRequestBody Body;

    public DownLoadScotlandEPCRequest()
    {
    }

    public DownLoadScotlandEPCRequest(DownLoadScotlandEPCRequestBody Body) => this.Body = Body;
  }
}
