
// Type: SAP2012.ScotlandService.AddressSearch_byUPRNResponse




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.ScotlandService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class AddressSearch_byUPRNResponse
  {
    [MessageBodyMember(Name = "AddressSearch_byUPRNResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public AddressSearch_byUPRNResponseBody Body;

    public AddressSearch_byUPRNResponse()
    {
    }

    public AddressSearch_byUPRNResponse(AddressSearch_byUPRNResponseBody Body) => this.Body = Body;
  }
}
