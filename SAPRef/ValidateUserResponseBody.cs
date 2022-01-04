
// Type: SAP2012.SAPRef.ValidateUserResponseBody




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
  public class ValidateUserResponseBody
  {
    [DataMember(Order = 0)]
    public bool ValidateUserResult;

    public ValidateUserResponseBody()
    {
    }

    public ValidateUserResponseBody(bool ValidateUserResult) => this.ValidateUserResult = ValidateUserResult;
  }
}
