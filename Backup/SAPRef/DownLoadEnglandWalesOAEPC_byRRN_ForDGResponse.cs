
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse




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
  public class DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse
  {
    [MessageBodyMember(Name = "DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadEnglandWalesOAEPC_byRRN_ForDGResponseBody Body;

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse(
      DownLoadEnglandWalesOAEPC_byRRN_ForDGResponseBody Body)
    {
      this.Body = Body;
    }
  }
}
