﻿
// Type: SAP2012.NISAP.Request_NI_UPRNbyLongAddressRequestBody




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
  public class Request_NI_UPRNbyLongAddressRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string PropertyNumber;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string RoadName;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string County;
    [DataMember(EmitDefaultValue = false, Order = 3)]
    public string Town;
    [DataMember(EmitDefaultValue = false, Order = 4)]
    public string PostCode;
    [DataMember(EmitDefaultValue = false, Order = 5)]
    public string Username;
    [DataMember(EmitDefaultValue = false, Order = 6)]
    public string password;
    [DataMember(EmitDefaultValue = false, Order = 7)]
    public string TransactionID;
    [DataMember(EmitDefaultValue = false, Order = 8)]
    public string Encrypt;

    public Request_NI_UPRNbyLongAddressRequestBody()
    {
    }

    public Request_NI_UPRNbyLongAddressRequestBody(
      string PropertyNumber,
      string RoadName,
      string County,
      string Town,
      string PostCode,
      string Username,
      string password,
      string TransactionID,
      string Encrypt)
    {
      this.PropertyNumber = PropertyNumber;
      this.RoadName = RoadName;
      this.County = County;
      this.Town = Town;
      this.PostCode = PostCode;
      this.Username = Username;
      this.password = password;
      this.TransactionID = TransactionID;
      this.Encrypt = Encrypt;
    }
  }
}
