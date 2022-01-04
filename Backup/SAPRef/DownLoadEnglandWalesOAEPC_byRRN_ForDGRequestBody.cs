
// Type: SAP2012.SAPRef.DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody




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
  public class DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Assessor;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encrypt;

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody()
    {
    }

    public DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody(
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      this.RRN = RRN;
      this.Assessor = Assessor;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
