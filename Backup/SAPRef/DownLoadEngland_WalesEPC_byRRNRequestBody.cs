
// Type: SAP2012.SAPRef.DownLoadEngland_WalesEPC_byRRNRequestBody




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
  public class DownLoadEngland_WalesEPC_byRRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Encrypt;

    public DownLoadEngland_WalesEPC_byRRNRequestBody()
    {
    }

    public DownLoadEngland_WalesEPC_byRRNRequestBody(
      string RRN,
      string TransactionID,
      string Encrypt)
    {
      this.RRN = RRN;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
