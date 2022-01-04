
// Type: SAP2012.NISAP.RequestUPRNbyTempIDNIRequestBody




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
  public class RequestUPRNbyTempIDNIRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string TempID;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Encrypt;

    public RequestUPRNbyTempIDNIRequestBody()
    {
    }

    public RequestUPRNbyTempIDNIRequestBody(string TempID, string TransactionID, string Encrypt)
    {
      this.TempID = TempID;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
