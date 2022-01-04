
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest




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
  public class DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest
  {
    [MessageBodyMember(Name = "DownLoadEnglandWalesOAEPC_byRRN_ForDG", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody Body;

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest(
      DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody Body)
    {
      this.Body = Body;
    }
  }
}
