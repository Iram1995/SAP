
// Type: SAP2012.SAP09Data.ValidateUserRequestBody




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
  public class ValidateUserRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Username;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string password;

    public ValidateUserRequestBody()
    {
    }

    public ValidateUserRequestBody(string Username, string password)
    {
      this.Username = Username;
      this.password = password;
    }
  }
}
