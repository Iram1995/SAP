
// Type: SAP2012.NISAP.DownLoadNIEPC_byRRNResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  public class DownLoadNIEPC_byRRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public LodgedEPCtDetails DownLoadNIEPC_byRRNResult;

    public DownLoadNIEPC_byRRNResponseBody()
    {
    }

    public DownLoadNIEPC_byRRNResponseBody(LodgedEPCtDetails DownLoadNIEPC_byRRNResult) => this.DownLoadNIEPC_byRRNResult = DownLoadNIEPC_byRRNResult;
  }
}
