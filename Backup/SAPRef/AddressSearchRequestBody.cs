
// Type: SAP2012.SAPRef.AddressSearchRequestBody




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
  public class AddressSearchRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Postcode;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public AddressRequest Request;

    public AddressSearchRequestBody()
    {
    }

    public AddressSearchRequestBody(string Postcode, AddressRequest Request)
    {
      this.Postcode = Postcode;
      this.Request = Request;
    }
  }
}
