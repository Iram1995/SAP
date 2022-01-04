
// Type: SAP2012.SAPRef.AddressNewAddressIDResponse




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
  public class AddressNewAddressIDResponse
  {
    [MessageBodyMember(Name = "AddressNewAddressIDResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public AddressNewAddressIDResponseBody Body;

    public AddressNewAddressIDResponse()
    {
    }

    public AddressNewAddressIDResponse(AddressNewAddressIDResponseBody Body) => this.Body = Body;
  }
}
