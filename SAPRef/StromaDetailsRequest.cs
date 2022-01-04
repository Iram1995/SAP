
// Type: SAP2012.SAPRef.StromaDetailsRequest




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class StromaDetailsRequest
  {
    [MessageBodyMember(Name = "StromaDetails", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public StromaDetailsRequestBody Body;

    public StromaDetailsRequest()
    {
    }

    public StromaDetailsRequest(StromaDetailsRequestBody Body) => this.Body = Body;
  }
}
