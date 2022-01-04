
// Type: SAP2012.SAP09Data.SendSAP_detailsRequestBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  public class SendSAP_detailsRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public Dwelling Dwell;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string userID;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encrypt;

    public SendSAP_detailsRequestBody()
    {
    }

    public SendSAP_detailsRequestBody(
      Dwelling Dwell,
      string userID,
      string TransactionID,
      string Encrypt)
    {
      this.Dwell = Dwell;
      this.userID = userID;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
