
// Type: SAP2012.SAPRef.AddressNewAddressIDResponseBody




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
  public class AddressNewAddressIDResponseBody
  {
    [DataMember(Order = 0)]
    public int AddressNewAddressIDResult;

    public AddressNewAddressIDResponseBody()
    {
    }

    public AddressNewAddressIDResponseBody(int AddressNewAddressIDResult) => this.AddressNewAddressIDResult = AddressNewAddressIDResult;
  }
}
