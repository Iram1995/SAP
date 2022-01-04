
// Type: SAP2012.SAP09Data.Upload_ComplianceSheetResponse




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
  public class Upload_ComplianceSheetResponse
  {
    [MessageBodyMember(Name = "Upload_ComplianceSheetResponse", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx", Order = 0)]
    public Upload_ComplianceSheetResponseBody Body;

    public Upload_ComplianceSheetResponse()
    {
    }

    public Upload_ComplianceSheetResponse(Upload_ComplianceSheetResponseBody Body) => this.Body = Body;
  }
}
