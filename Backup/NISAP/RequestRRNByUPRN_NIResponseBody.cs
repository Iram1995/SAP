
// Type: SAP2012.NISAP.RequestRRNByUPRN_NIResponseBody




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
  public class RequestRRNByUPRN_NIResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string RequestRRNByUPRN_NIResult;

    public RequestRRNByUPRN_NIResponseBody()
    {
    }

    public RequestRRNByUPRN_NIResponseBody(string RequestRRNByUPRN_NIResult) => this.RequestRRNByUPRN_NIResult = RequestRRNByUPRN_NIResult;
  }
}
