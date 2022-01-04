
// Type: SAP2012.SAPRef.RequestRRNByUPRNRequestBody




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
  public class RequestRRNByUPRNRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string UPRN;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string InspectionDate;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encrypt;

    public RequestRRNByUPRNRequestBody()
    {
    }

    public RequestRRNByUPRNRequestBody(
      string UPRN,
      string InspectionDate,
      string TransactionID,
      string Encrypt)
    {
      this.UPRN = UPRN;
      this.InspectionDate = InspectionDate;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
