
// Type: SAP2012.SAPRef.AssessmentType




using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "AssessmentType", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  public enum AssessmentType
  {
    [EnumMember] EPC,
    [EnumMember] SAP,
    [EnumMember] EPR,
    [EnumMember] OA,
    [EnumMember] GD,
    [EnumMember] GDIP,
    [EnumMember] Forms,
    [EnumMember] Finance,
    [EnumMember] ECO,
  }
}
