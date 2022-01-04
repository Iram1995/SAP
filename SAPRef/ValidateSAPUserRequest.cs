
// Type: SAP2012.SAPRef.ValidateSAPUserRequest




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
  public class ValidateSAPUserRequest
  {
    [MessageBodyMember(Name = "ValidateSAPUser", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public ValidateSAPUserRequestBody Body;

    public ValidateSAPUserRequest()
    {
    }

    public ValidateSAPUserRequest(ValidateSAPUserRequestBody Body) => this.Body = Body;
  }
}
