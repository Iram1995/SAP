
// Type: SAP2012.NISAP.SAP_StatusResult_BYRRN_NIResponseBody




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
  public class SAP_StatusResult_BYRRN_NIResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string SAP_StatusResult_BYRRN_NIResult;

    public SAP_StatusResult_BYRRN_NIResponseBody()
    {
    }

    public SAP_StatusResult_BYRRN_NIResponseBody(string SAP_StatusResult_BYRRN_NIResult) => this.SAP_StatusResult_BYRRN_NIResult = SAP_StatusResult_BYRRN_NIResult;
  }
}
