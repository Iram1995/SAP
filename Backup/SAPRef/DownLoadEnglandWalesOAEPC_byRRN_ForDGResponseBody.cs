
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRN_ForDGResponseBody




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
  public class DownLoadEnglandWalesOAEPC_byRRN_ForDGResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string DownLoadEnglandWalesOAEPC_byRRN_ForDGResult;

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGResponseBody()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGResponseBody(
      string DownLoadEnglandWalesOAEPC_byRRN_ForDGResult)
    {
      this.DownLoadEnglandWalesOAEPC_byRRN_ForDGResult = DownLoadEnglandWalesOAEPC_byRRN_ForDGResult;
    }
  }
}
