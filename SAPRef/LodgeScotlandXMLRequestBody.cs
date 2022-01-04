
// Type: SAP2012.SAPRef.LodgeScotlandXMLRequestBody




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
  public class LodgeScotlandXMLRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string XMLdata;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string username;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string AssessorNO;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string RRN;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string Encryption;

    public LodgeScotlandXMLRequestBody()
    {
    }

    public LodgeScotlandXMLRequestBody(
      string XMLdata,
      string username,
      string password,
      string AssessorNO,
      string RRN,
      string TransactionID,
      string Encryption)
    {
      this.XMLdata = XMLdata;
      this.username = username;
      this.password = password;
      this.AssessorNO = AssessorNO;
      this.RRN = RRN;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
