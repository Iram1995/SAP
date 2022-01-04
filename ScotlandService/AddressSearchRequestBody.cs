
// Type: SAP2012.ScotlandService.AddressSearchRequestBody




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
  public class AddressSearchRequestBody
  {
    [DataMember(Order = 0)]
    public bool SharedService;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Postcode;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encrypt;

    public AddressSearchRequestBody()
    {
    }

    public AddressSearchRequestBody(
      bool SharedService,
      string Postcode,
      string TransactionID,
      string Encrypt)
    {
      this.SharedService = SharedService;
      this.Postcode = Postcode;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
