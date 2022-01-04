
// Type: SAP2012.NISAP.Add_New_AddressNIRequest




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
  public class Add_New_AddressNIRequest
  {
    [MessageBodyMember(Name = "Add_New_AddressNI", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx", Order = 0)]
    public Add_New_AddressNIRequestBody Body;

    public Add_New_AddressNIRequest()
    {
    }

    public Add_New_AddressNIRequest(Add_New_AddressNIRequestBody Body) => this.Body = Body;
  }
}
