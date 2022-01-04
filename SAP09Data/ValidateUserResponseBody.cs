
// Type: SAP2012.SAP09Data.ValidateUserResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  public class ValidateUserResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string ValidateUserResult;

    public ValidateUserResponseBody()
    {
    }

    public ValidateUserResponseBody(string ValidateUserResult) => this.ValidateUserResult = ValidateUserResult;
  }
}
