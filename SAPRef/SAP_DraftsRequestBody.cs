
// Type: SAP2012.SAPRef.SAP_DraftsRequestBody




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
  public class SAP_DraftsRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string XMLdata;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string AssessorNO;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string RRN;
    [DataMember(Order = 3)]
    public int Country;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string username;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 7)]
    public string Encryption;

    public SAP_DraftsRequestBody()
    {
    }

    public SAP_DraftsRequestBody(
      string XMLdata,
      string AssessorNO,
      string RRN,
      int Country,
      string username,
      string password,
      string TransactionID,
      string Encryption)
    {
      this.XMLdata = XMLdata;
      this.AssessorNO = AssessorNO;
      this.RRN = RRN;
      this.Country = Country;
      this.username = username;
      this.password = password;
      this.TransactionID = TransactionID;
      this.Encryption = Encryption;
    }
  }
}
