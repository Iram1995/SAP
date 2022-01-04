
// Type: SAP2012.NISAP.Add_New_AddressNIResponse




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class Add_New_AddressNIResponse
  {
    [MessageBodyMember(Name = "Add_New_AddressNIResponse", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Add_New_AddressNIResponseBody Body;

    public Add_New_AddressNIResponse()
    {
    }

    public Add_New_AddressNIResponse(Add_New_AddressNIResponseBody Body) => this.Body = Body;
  }
}
