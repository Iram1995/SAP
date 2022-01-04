
// Type: SAP2012.SAP09Data.SendCompliance_DetailsRequestBody




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
  public class SendCompliance_DetailsRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public ComplianceDetails SDetails;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Encrypt;

    public SendCompliance_DetailsRequestBody()
    {
    }

    public SendCompliance_DetailsRequestBody(
      ComplianceDetails SDetails,
      string TransactionID,
      string Encrypt)
    {
      this.SDetails = SDetails;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
