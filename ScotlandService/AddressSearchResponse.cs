
// Type: SAP2012.ScotlandService.AddressSearchResponse




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
  public class AddressSearchResponse
  {
    [MessageBodyMember(Name = "AddressSearchResponse", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public AddressSearchResponseBody Body;

    public AddressSearchResponse()
    {
    }

    public AddressSearchResponse(AddressSearchResponseBody Body) => this.Body = Body;
  }
}
