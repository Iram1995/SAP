
// Type: SAP2012.ScotlandService.AddressSearchRequest




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
  public class AddressSearchRequest
  {
    [MessageBodyMember(Name = "AddressSearch", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public AddressSearchRequestBody Body;

    public AddressSearchRequest()
    {
    }

    public AddressSearchRequest(AddressSearchRequestBody Body) => this.Body = Body;
  }
}
