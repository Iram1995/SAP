
// Type: SAP2012.NISAP.Request_NI_UPRNbyTempIDRequestBody




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
  public class Request_NI_UPRNbyTempIDRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string TempID;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string username;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Encrypt;

    public Request_NI_UPRNbyTempIDRequestBody()
    {
    }

    public Request_NI_UPRNbyTempIDRequestBody(
      string TempID,
      string username,
      string password,
      string TransactionID,
      string Encrypt)
    {
      this.TempID = TempID;
      this.username = username;
      this.password = password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
