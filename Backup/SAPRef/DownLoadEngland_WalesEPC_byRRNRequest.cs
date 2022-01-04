
// Type: SAP2012.SAPRef.DownLoadEngland_WalesEPC_byRRNRequest




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
  public class DownLoadEngland_WalesEPC_byRRNRequest
  {
    [MessageBodyMember(Name = "DownLoadEngland_WalesEPC_byRRN", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadEngland_WalesEPC_byRRNRequestBody Body;

    public DownLoadEngland_WalesEPC_byRRNRequest()
    {
    }

    public DownLoadEngland_WalesEPC_byRRNRequest(DownLoadEngland_WalesEPC_byRRNRequestBody Body) => this.Body = Body;
  }
}
