
// Type: SAP2012.SAPRef.DownLoad_lodgedEPC_In_ScotlandRequest




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
  public class DownLoad_lodgedEPC_In_ScotlandRequest
  {
    [MessageBodyMember(Name = "DownLoad_lodgedEPC_In_Scotland", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public DownLoad_lodgedEPC_In_ScotlandRequestBody Body;

    public DownLoad_lodgedEPC_In_ScotlandRequest()
    {
    }

    public DownLoad_lodgedEPC_In_ScotlandRequest(DownLoad_lodgedEPC_In_ScotlandRequestBody Body) => this.Body = Body;
  }
}
