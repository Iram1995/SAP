
// Type: SAP2012.NISAP.Add_New_AddressNIRequestBody




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
  public class Add_New_AddressNIRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string HouseNo;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string Street;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Locality;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string City;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string Postcode;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string AssessorNo;
    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string Notes;
    [DataMember(EmitDefaultValue = false, Order = 7)]
    public string UserName;
    [DataMember(EmitDefaultValue = false, Order = 8)]
    public string Password;
    [DataMember(EmitDefaultValue = false, Order = 9)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 10)]
    public string Encrypt;

    public Add_New_AddressNIRequestBody()
    {
    }

    public Add_New_AddressNIRequestBody(
      string HouseNo,
      string Street,
      string Locality,
      string City,
      string Postcode,
      string AssessorNo,
      string Notes,
      string UserName,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      this.HouseNo = HouseNo;
      this.Street = Street;
      this.Locality = Locality;
      this.City = City;
      this.Postcode = Postcode;
      this.AssessorNo = AssessorNo;
      this.Notes = Notes;
      this.UserName = UserName;
      this.Password = Password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
