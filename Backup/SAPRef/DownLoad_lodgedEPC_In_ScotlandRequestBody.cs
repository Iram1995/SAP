
// Type: SAP2012.SAPRef.DownLoad_lodgedEPC_In_ScotlandRequestBody




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
  public class DownLoad_lodgedEPC_In_ScotlandRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string AssessorNO;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Encryption;

    public DownLoad_lodgedEPC_In_ScotlandRequestBody()
    {
    }

    public DownLoad_lodgedEPC_In_ScotlandRequestBody(
      string AssessorNO,
      string RRN,
      string TransactionID,
      string Encryption)
    {
      this.AssessorNO = AssessorNO;
      this.RRN = RRN;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
