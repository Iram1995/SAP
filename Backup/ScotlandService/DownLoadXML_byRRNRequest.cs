
// Type: SAP2012.ScotlandService.DownLoadXML_byRRNRequest




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
  public class DownLoadXML_byRRNRequest
  {
    [MessageBodyMember(Name = "DownLoadXML_byRRN", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public DownLoadXML_byRRNRequestBody Body;

    public DownLoadXML_byRRNRequest()
    {
    }

    public DownLoadXML_byRRNRequest(DownLoadXML_byRRNRequestBody Body) => this.Body = Body;
  }
}
