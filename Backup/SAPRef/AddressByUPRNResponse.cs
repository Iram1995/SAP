
// Type: SAP2012.SAPRef.AddressByUPRNResponse




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
  public class AddressByUPRNResponse
  {
    [MessageBodyMember(Name = "AddressByUPRNResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public AddressByUPRNResponseBody Body;

    public AddressByUPRNResponse()
    {
    }

    public AddressByUPRNResponse(AddressByUPRNResponseBody Body) => this.Body = Body;
  }
}
