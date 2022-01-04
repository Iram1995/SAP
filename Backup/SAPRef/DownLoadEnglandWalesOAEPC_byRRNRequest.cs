
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRNRequest




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
  public class DownLoadEnglandWalesOAEPC_byRRNRequest
  {
    [MessageBodyMember(Name = "DownLoadEnglandWalesOAEPC_byRRN", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadEnglandWalesOAEPC_byRRNRequestBody Body;

    public DownLoadEnglandWalesOAEPC_byRRNRequest()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRNRequest(DownLoadEnglandWalesOAEPC_byRRNRequestBody Body) => this.Body = Body;
  }
}
