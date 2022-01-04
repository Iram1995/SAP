
// Type: SAP2012.SAPRef.HomeInspectorDetailsRequestBody




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
  public class HomeInspectorDetailsRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string UserName;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string CertificateNo;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Encryption;

    public HomeInspectorDetailsRequestBody()
    {
    }

    public HomeInspectorDetailsRequestBody(
      string UserName,
      string Password,
      string CertificateNo,
      string TransactionID,
      string Encryption)
    {
      this.UserName = UserName;
      this.Password = Password;
      this.CertificateNo = CertificateNo;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
