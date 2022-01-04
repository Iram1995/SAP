
// Type: SAP2012.SAP09Data.Upload_ComplianceSheetRequestBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  public class Upload_ComplianceSheetRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Data;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string FileName;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encrypt;

    public Upload_ComplianceSheetRequestBody()
    {
    }

    public Upload_ComplianceSheetRequestBody(
      string Data,
      string FileName,
      string TransactionID,
      string Encrypt)
    {
      this.Data = Data;
      this.FileName = FileName;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
