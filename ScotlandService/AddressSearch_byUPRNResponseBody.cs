
// Type: SAP2012.ScotlandService.AddressSearch_byUPRNResponseBody




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
  public class AddressSearch_byUPRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public ReturnObject AddressSearch_byUPRNResult;

    public AddressSearch_byUPRNResponseBody()
    {
    }

    public AddressSearch_byUPRNResponseBody(ReturnObject AddressSearch_byUPRNResult) => this.AddressSearch_byUPRNResult = AddressSearch_byUPRNResult;
  }
}
