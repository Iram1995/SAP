
// Type: SAP2012.SAPRef.CheckInsuranceRequestBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  public class CheckInsuranceRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Assessor;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string UserName;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Encryption;

    public CheckInsuranceRequestBody()
    {
    }

    public CheckInsuranceRequestBody(
      string Assessor,
      string UserName,
      string Password,
      string TransactionID,
      string Encryption)
    {
      this.Assessor = Assessor;
      this.UserName = UserName;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
