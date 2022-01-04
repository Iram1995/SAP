
// Type: SAP2012.SAPRef.EnviornmentType




using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "EnviornmentType", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  public enum EnviornmentType
  {
    [EnumMember] LIVE,
    [EnumMember] UAT,
    [EnumMember] OTE,
    [EnumMember] DEV,
  }
}
