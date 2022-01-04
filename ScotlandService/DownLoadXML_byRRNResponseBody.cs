
// Type: SAP2012.ScotlandService.DownLoadXML_byRRNResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.ScotlandService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx")]
  public class DownLoadXML_byRRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string DownLoadXML_byRRNResult;

    public DownLoadXML_byRRNResponseBody()
    {
    }

    public DownLoadXML_byRRNResponseBody(string DownLoadXML_byRRNResult) => this.DownLoadXML_byRRNResult = DownLoadXML_byRRNResult;
  }
}
