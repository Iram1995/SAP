
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRNResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  public class DownLoadEnglandWalesOAEPC_byRRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string DownLoadEnglandWalesOAEPC_byRRNResult;

    public DownLoadEnglandWalesOAEPC_byRRNResponseBody()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRNResponseBody(string DownLoadEnglandWalesOAEPC_byRRNResult) => this.DownLoadEnglandWalesOAEPC_byRRNResult = DownLoadEnglandWalesOAEPC_byRRNResult;
  }
}
