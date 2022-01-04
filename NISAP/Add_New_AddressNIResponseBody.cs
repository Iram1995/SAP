
// Type: SAP2012.NISAP.Add_New_AddressNIResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  public class Add_New_AddressNIResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string Add_New_AddressNIResult;

    public Add_New_AddressNIResponseBody()
    {
    }

    public Add_New_AddressNIResponseBody(string Add_New_AddressNIResult) => this.Add_New_AddressNIResult = Add_New_AddressNIResult;
  }
}
