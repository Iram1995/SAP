
// Type: SAP2012.SAPRef.AddressNewAddressIDRequest




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
  public class AddressNewAddressIDRequest
  {
    [MessageBodyMember(Name = "AddressNewAddressID", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public AddressNewAddressIDRequestBody Body;

    public AddressNewAddressIDRequest()
    {
    }

    public AddressNewAddressIDRequest(AddressNewAddressIDRequestBody Body) => this.Body = Body;
  }
}
