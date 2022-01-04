
// Type: SAP2012.SAPRef.ValidateUserRequest




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
  public class ValidateUserRequest
  {
    [MessageBodyMember(Name = "ValidateUser", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public ValidateUserRequestBody Body;

    public ValidateUserRequest()
    {
    }

    public ValidateUserRequest(ValidateUserRequestBody Body) => this.Body = Body;
  }
}
