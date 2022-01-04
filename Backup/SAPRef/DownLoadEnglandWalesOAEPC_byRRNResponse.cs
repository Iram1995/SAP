
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRNResponse




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
  public class DownLoadEnglandWalesOAEPC_byRRNResponse
  {
    [MessageBodyMember(Name = "DownLoadEnglandWalesOAEPC_byRRNResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadEnglandWalesOAEPC_byRRNResponseBody Body;

    public DownLoadEnglandWalesOAEPC_byRRNResponse()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRNResponse(DownLoadEnglandWalesOAEPC_byRRNResponseBody Body) => this.Body = Body;
  }
}
