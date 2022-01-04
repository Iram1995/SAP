
// Type: SAP2012.NISAP.Request_NI_LongAddressByUPRNResponseBody




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
  public class Request_NI_LongAddressByUPRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public LongAddress Request_NI_LongAddressByUPRNResult;

    public Request_NI_LongAddressByUPRNResponseBody()
    {
    }

    public Request_NI_LongAddressByUPRNResponseBody(LongAddress Request_NI_LongAddressByUPRNResult) => this.Request_NI_LongAddressByUPRNResult = Request_NI_LongAddressByUPRNResult;
  }
}
