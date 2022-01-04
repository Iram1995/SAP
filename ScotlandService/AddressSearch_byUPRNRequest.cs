
// Type: SAP2012.ScotlandService.AddressSearch_byUPRNRequest




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
  public class AddressSearch_byUPRNRequest
  {
    [MessageBodyMember(Name = "AddressSearch_byUPRN", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx", Order = 0)]
    public AddressSearch_byUPRNRequestBody Body;

    public AddressSearch_byUPRNRequest()
    {
    }

    public AddressSearch_byUPRNRequest(AddressSearch_byUPRNRequestBody Body) => this.Body = Body;
  }
}
