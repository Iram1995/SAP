
// Type: SAP2012.ScotlandService.DraftEPCRequestBody




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
  public class DraftEPCRequestBody
  {
    [DataMember(Order = 0)]
    public bool SharedService;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string XML;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Assessor;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Encrypt;

    public DraftEPCRequestBody()
    {
    }

    public DraftEPCRequestBody(
      bool SharedService,
      string XML,
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      this.SharedService = SharedService;
      this.XML = XML;
      this.RRN = RRN;
      this.Assessor = Assessor;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
