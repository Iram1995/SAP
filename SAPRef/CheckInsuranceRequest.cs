
// Type: SAP2012.SAPRef.CheckInsuranceRequest




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
  public class CheckInsuranceRequest
  {
    [MessageBodyMember(Name = "CheckInsurance", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public CheckInsuranceRequestBody Body;

    public CheckInsuranceRequest()
    {
    }

    public CheckInsuranceRequest(CheckInsuranceRequestBody Body) => this.Body = Body;
  }
}
