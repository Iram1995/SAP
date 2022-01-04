
// Type: SAP2012.SAPRef.HomeInspectorDetailsByUserNamePasswordRequestBody




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
  public class HomeInspectorDetailsByUserNamePasswordRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string UserName;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encryption;

    public HomeInspectorDetailsByUserNamePasswordRequestBody()
    {
    }

    public HomeInspectorDetailsByUserNamePasswordRequestBody(
      string UserName,
      string Password,
      string TransactionID,
      string Encryption)
    {
      this.UserName = UserName;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
