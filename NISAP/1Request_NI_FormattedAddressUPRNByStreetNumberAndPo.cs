
// Type: SAP2012.NISAP.Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody




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
  public class Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string StreetNumber;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string PostCode;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string username;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Encrypt;

    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody()
    {
    }

    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody(
      string StreetNumber,
      string PostCode,
      string username,
      string password,
      string TransactionID,
      string Encrypt)
    {
      this.StreetNumber = StreetNumber;
      this.PostCode = PostCode;
      this.username = username;
      this.password = password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
