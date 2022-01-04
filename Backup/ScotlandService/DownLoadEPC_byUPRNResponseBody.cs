
// Type: SAP2012.ScotlandService.DownLoadEPC_byUPRNResponseBody




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
  public class DownLoadEPC_byUPRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string DownLoadEPC_byUPRNResult;

    public DownLoadEPC_byUPRNResponseBody()
    {
    }

    public DownLoadEPC_byUPRNResponseBody(string DownLoadEPC_byUPRNResult) => this.DownLoadEPC_byUPRNResult = DownLoadEPC_byUPRNResult;
  }
}
