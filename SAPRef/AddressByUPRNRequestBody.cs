
// Type: SAP2012.SAPRef.AddressByUPRNRequestBody




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
  public class AddressByUPRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string UPRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public AddressRequest Request;

    public AddressByUPRNRequestBody()
    {
    }

    public AddressByUPRNRequestBody(string UPRN, AddressRequest Request)
    {
      this.UPRN = UPRN;
      this.Request = Request;
    }
  }
}
