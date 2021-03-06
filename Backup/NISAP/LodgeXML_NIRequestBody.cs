
// Type: SAP2012.NISAP.LodgeXML_NIRequestBody




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
  public class LodgeXML_NIRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string XMLdata;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string username;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string AssessorNO;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string Encryption;

    public LodgeXML_NIRequestBody()
    {
    }

    public LodgeXML_NIRequestBody(
      string XMLdata,
      string RRN,
      string username,
      string password,
      string AssessorNO,
      string TransactionID,
      string Encryption)
    {
      this.XMLdata = XMLdata;
      this.RRN = RRN;
      this.username = username;
      this.password = password;
      this.AssessorNO = AssessorNO;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
