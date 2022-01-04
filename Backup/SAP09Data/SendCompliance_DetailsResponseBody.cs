
// Type: SAP2012.SAP09Data.SendCompliance_DetailsResponseBody




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
  public class SendCompliance_DetailsResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string SendCompliance_DetailsResult;

    public SendCompliance_DetailsResponseBody()
    {
    }

    public SendCompliance_DetailsResponseBody(string SendCompliance_DetailsResult) => this.SendCompliance_DetailsResult = SendCompliance_DetailsResult;
  }
}
