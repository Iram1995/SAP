
// Type: SAP2012.SAPRef.SAP_DraftsResponseBody




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
  public class SAP_DraftsResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public DraftDetails SAP_DraftsResult;

    public SAP_DraftsResponseBody()
    {
    }

    public SAP_DraftsResponseBody(DraftDetails SAP_DraftsResult) => this.SAP_DraftsResult = SAP_DraftsResult;
  }
}
