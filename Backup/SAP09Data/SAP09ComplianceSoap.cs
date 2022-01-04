
// Type: SAP2012.SAP09Data.SAP09ComplianceSoap




using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SAP2012.SAP09Data
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "SAP09Data.SAP09ComplianceSoap", Namespace = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx")]
  public interface SAP09ComplianceSoap
  {
    [OperationContract(Action = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx/SendCompliance_Details", ReplyAction = "*")]
    SendCompliance_DetailsResponse SendCompliance_Details(
      SendCompliance_DetailsRequest request);

    [OperationContract(Action = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx/SendSAP_details", ReplyAction = "*")]
    SendSAP_detailsResponse SendSAP_details(SendSAP_detailsRequest request);

    [OperationContract(Action = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx/Upload_ComplianceSheet", ReplyAction = "*")]
    Upload_ComplianceSheetResponse Upload_ComplianceSheet(
      Upload_ComplianceSheetRequest request);

    [OperationContract(Action = "http://rdsap2009.stroma.com/SAPData/SAP09Compliance.asmx/ValidateUser", ReplyAction = "*")]
    ValidateUserResponse ValidateUser(ValidateUserRequest request);
  }
}
