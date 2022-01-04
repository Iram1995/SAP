
// Type: SAP2012.SAPRef.DownLoadEngland_WalesEPC_byRRN_RDSAPResponse




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
  public class DownLoadEngland_WalesEPC_byRRN_RDSAPResponse
  {
    [MessageBodyMember(Name = "DownLoadEngland_WalesEPC_byRRN_RDSAPResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoadEngland_WalesEPC_byRRN_RDSAPResponseBody Body;

    public DownLoadEngland_WalesEPC_byRRN_RDSAPResponse()
    {
    }

    public DownLoadEngland_WalesEPC_byRRN_RDSAPResponse(
      DownLoadEngland_WalesEPC_byRRN_RDSAPResponseBody Body)
    {
      this.Body = Body;
    }
  }
}
