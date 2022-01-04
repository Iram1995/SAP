
// Type: SAP2012.SAPRef.CheckInsuranceResponseBody




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
  public class CheckInsuranceResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public Insurance CheckInsuranceResult;

    public CheckInsuranceResponseBody()
    {
    }

    public CheckInsuranceResponseBody(Insurance CheckInsuranceResult) => this.CheckInsuranceResult = CheckInsuranceResult;
  }
}
