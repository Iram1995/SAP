
// Type: SAP2012.ScotlandService.AddressSearchResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.ScotlandService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx")]
  public class AddressSearchResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public ReturnObject AddressSearchResult;

    public AddressSearchResponseBody()
    {
    }

    public AddressSearchResponseBody(ReturnObject AddressSearchResult) => this.AddressSearchResult = AddressSearchResult;
  }
}
