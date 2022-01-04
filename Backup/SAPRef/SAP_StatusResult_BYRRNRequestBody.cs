
// Type: SAP2012.SAPRef.SAP_StatusResult_BYRRNRequestBody




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
  public class SAP_StatusResult_BYRRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string EACertificateNo;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Username;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Encryption;

    public SAP_StatusResult_BYRRNRequestBody()
    {
    }

    public SAP_StatusResult_BYRRNRequestBody(
      string RRN,
      string EACertificateNo,
      string Username,
      string Password,
      string TransactionID,
      string Encryption)
    {
      this.RRN = RRN;
      this.EACertificateNo = EACertificateNo;
      this.Username = Username;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
