
// Type: SAP2012.SAPRef.SAP_StatusResult_BYRRNResponseBody




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
  public class SAP_StatusResult_BYRRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string SAP_StatusResult_BYRRNResult;

    public SAP_StatusResult_BYRRNResponseBody()
    {
    }

    public SAP_StatusResult_BYRRNResponseBody(string SAP_StatusResult_BYRRNResult) => this.SAP_StatusResult_BYRRNResult = SAP_StatusResult_BYRRNResult;
  }
}
