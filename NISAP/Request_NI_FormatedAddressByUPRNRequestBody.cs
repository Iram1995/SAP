
// Type: SAP2012.NISAP.Request_NI_FormatedAddressByUPRNRequestBody




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
  public class Request_NI_FormatedAddressByUPRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string UPRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Username;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Encrypt;

    public Request_NI_FormatedAddressByUPRNRequestBody()
    {
    }

    public Request_NI_FormatedAddressByUPRNRequestBody(
      string UPRN,
      string Username,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      this.UPRN = UPRN;
      this.Username = Username;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
