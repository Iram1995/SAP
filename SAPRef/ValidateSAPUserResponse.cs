
// Type: SAP2012.SAPRef.ValidateSAPUserResponse




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
  public class ValidateSAPUserResponse
  {
    [MessageBodyMember(Name = "ValidateSAPUserResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public ValidateSAPUserResponseBody Body;

    public ValidateSAPUserResponse()
    {
    }

    public ValidateSAPUserResponse(ValidateSAPUserResponseBody Body) => this.Body = Body;
  }
}
