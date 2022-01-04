
// Type: SAP2012.SAP09Data.SendSAP_detailsResponseBody




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
  public class SendSAP_detailsResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string SendSAP_detailsResult;

    public SendSAP_detailsResponseBody()
    {
    }

    public SendSAP_detailsResponseBody(string SendSAP_detailsResult) => this.SendSAP_detailsResult = SendSAP_detailsResult;
  }
}
