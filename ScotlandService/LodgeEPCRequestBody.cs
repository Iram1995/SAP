
// Type: SAP2012.ScotlandService.LodgeEPCRequestBody




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
  public class LodgeEPCRequestBody
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
    public string UserName;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 7)]
    public string Encrypt;

    public LodgeEPCRequestBody()
    {
    }

    public LodgeEPCRequestBody(
      bool SharedService,
      string XML,
      string RRN,
      string Assessor,
      string UserName,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      this.SharedService = SharedService;
      this.XML = XML;
      this.RRN = RRN;
      this.Assessor = Assessor;
      this.UserName = UserName;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
