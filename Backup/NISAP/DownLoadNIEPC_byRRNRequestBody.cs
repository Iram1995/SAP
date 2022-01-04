
// Type: SAP2012.NISAP.DownLoadNIEPC_byRRNRequestBody




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
  public class DownLoadNIEPC_byRRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Encrypt;

    public DownLoadNIEPC_byRRNRequestBody()
    {
    }

    public DownLoadNIEPC_byRRNRequestBody(string RRN, string TransactionID, string Encrypt)
    {
      this.RRN = RRN;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
