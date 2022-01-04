
// Type: SAP2012.SAP09Data.Upload_ComplianceSheetResponseBody




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
  public class Upload_ComplianceSheetResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Upload_ComplianceSheetResult;

    public Upload_ComplianceSheetResponseBody()
    {
    }

    public Upload_ComplianceSheetResponseBody(string Upload_ComplianceSheetResult) => this.Upload_ComplianceSheetResult = Upload_ComplianceSheetResult;
  }
}
