
// Type: SAP2012.NISAP.Request_NI_UPRNbyTempIDResponseBody




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
  public class Request_NI_UPRNbyTempIDResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public FormattedAddress Request_NI_UPRNbyTempIDResult;

    public Request_NI_UPRNbyTempIDResponseBody()
    {
    }

    public Request_NI_UPRNbyTempIDResponseBody(FormattedAddress Request_NI_UPRNbyTempIDResult) => this.Request_NI_UPRNbyTempIDResult = Request_NI_UPRNbyTempIDResult;
  }
}
