
// Type: SAP2012.NISAP.Request_NI_LongAddressByUPRNRequestBody




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
  public class Request_NI_LongAddressByUPRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string UPRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string username;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Encrypt;

    public Request_NI_LongAddressByUPRNRequestBody()
    {
    }

    public Request_NI_LongAddressByUPRNRequestBody(
      string UPRN,
      string username,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      this.UPRN = UPRN;
      this.username = username;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
