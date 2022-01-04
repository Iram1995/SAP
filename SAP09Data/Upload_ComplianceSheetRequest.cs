
// Type: SAP2012.SAP09Data.Upload_ComplianceSheetRequest




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class Upload_ComplianceSheetRequest
  {
    [MessageBodyMember(Name = "Upload_ComplianceSheet", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx", Order = 0)]
    public Upload_ComplianceSheetRequestBody Body;

    public Upload_ComplianceSheetRequest()
    {
    }

    public Upload_ComplianceSheetRequest(Upload_ComplianceSheetRequestBody Body) => this.Body = Body;
  }
}
