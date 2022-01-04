
// Type: SAP2012.SAPRef.ValidateSAPUserResponseBody




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
  public class ValidateSAPUserResponseBody
  {
    [DataMember(Order = 0)]
    public bool ValidateSAPUserResult;

    public ValidateSAPUserResponseBody()
    {
    }

    public ValidateSAPUserResponseBody(bool ValidateSAPUserResult) => this.ValidateSAPUserResult = ValidateSAPUserResult;
  }
}
