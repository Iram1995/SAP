
// Type: SAP2012.ScotlandService.DownLoadXML_byRRNResponse




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
  public class DownLoadXML_byRRNResponse
  {
    [MessageBodyMember(Name = "DownLoadXML_byRRNResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DownLoadXML_byRRNResponseBody Body;

    public DownLoadXML_byRRNResponse()
    {
    }

    public DownLoadXML_byRRNResponse(DownLoadXML_byRRNResponseBody Body) => this.Body = Body;
  }
}
