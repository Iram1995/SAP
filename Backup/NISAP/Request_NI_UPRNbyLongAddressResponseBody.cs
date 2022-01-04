
// Type: SAP2012.NISAP.Request_NI_UPRNbyLongAddressResponseBody




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
  public class Request_NI_UPRNbyLongAddressResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public ShortAddress[] Request_NI_UPRNbyLongAddressResult;

    public Request_NI_UPRNbyLongAddressResponseBody()
    {
    }

    public Request_NI_UPRNbyLongAddressResponseBody(
      ShortAddress[] Request_NI_UPRNbyLongAddressResult)
    {
      this.Request_NI_UPRNbyLongAddressResult = Request_NI_UPRNbyLongAddressResult;
    }
  }
}
