
// Type: SAP2012.SAPRef.DownLoad_lodgedEPC_In_ScotlandResponseBody




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
  public class DownLoad_lodgedEPC_In_ScotlandResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string DownLoad_lodgedEPC_In_ScotlandResult;

    public DownLoad_lodgedEPC_In_ScotlandResponseBody()
    {
    }

    public DownLoad_lodgedEPC_In_ScotlandResponseBody(string DownLoad_lodgedEPC_In_ScotlandResult) => this.DownLoad_lodgedEPC_In_ScotlandResult = DownLoad_lodgedEPC_In_ScotlandResult;
  }
}
