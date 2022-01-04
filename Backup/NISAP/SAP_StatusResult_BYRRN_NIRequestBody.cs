
// Type: SAP2012.NISAP.SAP_StatusResult_BYRRN_NIRequestBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  public class SAP_StatusResult_BYRRN_NIRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string EnergyAssessor;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string userName;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Encrypt;

    public SAP_StatusResult_BYRRN_NIRequestBody()
    {
    }

    public SAP_StatusResult_BYRRN_NIRequestBody(
      string RRN,
      string EnergyAssessor,
      string userName,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      this.RRN = RRN;
      this.EnergyAssessor = EnergyAssessor;
      this.userName = userName;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
