
// Type: SAP2012.SAPRef.ValidateSAPUserRequestBody




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
  public class ValidateSAPUserRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Username;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encryption;

    public ValidateSAPUserRequestBody()
    {
    }

    public ValidateSAPUserRequestBody(
      string Username,
      string password,
      string TransactionID,
      string Encryption)
    {
      this.Username = Username;
      this.password = password;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
