
// Type: SAP2012.SAPRef.SAPSoap




using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SAP2012.SAPRef
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "SAPRef.SAPSoap", Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  public interface SAPSoap
  {
    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/Checksapimportpermission", ReplyAction = "*")]
    ChecksapimportpermissionResponse Checksapimportpermission(
      ChecksapimportpermissionRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/HomeInspectorDetails", ReplyAction = "*")]
    HomeInspectorDetailsResponse HomeInspectorDetails(
      HomeInspectorDetailsRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/LodgeXML", ReplyAction = "*")]
    LodgeXMLResponse LodgeXML(LodgeXMLRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/DownLoad_lodgedEPC_In_Scotland", ReplyAction = "*")]
    DownLoad_lodgedEPC_In_ScotlandResponse DownLoad_lodgedEPC_In_Scotland(
      DownLoad_lodgedEPC_In_ScotlandRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/LodgeScotlandXML", ReplyAction = "*")]
    LodgeScotlandXMLResponse LodgeScotlandXML(
      LodgeScotlandXMLRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/SAP_Drafts", ReplyAction = "*")]
    SAP_DraftsResponse SAP_Drafts(SAP_DraftsRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/RequestScotlandAddress", ReplyAction = "*")]
    RequestScotlandAddressResponse RequestScotlandAddress(
      RequestScotlandAddressRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/AddressByUPRN", ReplyAction = "*")]
    AddressByUPRNResponse AddressByUPRN(AddressByUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/AddressSearch", ReplyAction = "*")]
    AddressSearchResponse AddressSearch(AddressSearchRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/AddressNewAddressID", ReplyAction = "*")]
    AddressNewAddressIDResponse AddressNewAddressID(
      AddressNewAddressIDRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/ValidateUser", ReplyAction = "*")]
    ValidateUserResponse ValidateUser(ValidateUserRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/ValidateSAPUser", ReplyAction = "*")]
    ValidateSAPUserResponse ValidateSAPUser(ValidateSAPUserRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/RequestRRNByUPRN", ReplyAction = "*")]
    RequestRRNByUPRNResponse RequestRRNByUPRN(
      RequestRRNByUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/StromaDetails", ReplyAction = "*")]
    StromaDetailsResponse StromaDetails(StromaDetailsRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/HomeInspectorDetailsByUserNamePassword", ReplyAction = "*")]
    HomeInspectorDetailsByUserNamePasswordResponse HomeInspectorDetailsByUserNamePassword(
      HomeInspectorDetailsByUserNamePasswordRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/SAP_StatusResult_BYRRN", ReplyAction = "*")]
    SAP_StatusResult_BYRRNResponse SAP_StatusResult_BYRRN(
      SAP_StatusResult_BYRRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/DownLoadScotlandEPC", ReplyAction = "*")]
    DownLoadScotlandEPCResponse DownLoadScotlandEPC(
      DownLoadScotlandEPCRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/CheckInsurance", ReplyAction = "*")]
    CheckInsuranceResponse CheckInsurance(CheckInsuranceRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/DownLoadEngland_WalesEPC_byRRN", ReplyAction = "*")]
    DownLoadEngland_WalesEPC_byRRNResponse DownLoadEngland_WalesEPC_byRRN(
      DownLoadEngland_WalesEPC_byRRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/DownLoadEngland_WalesEPC_byRRN_RDSAP", ReplyAction = "*")]
    DownLoadEngland_WalesEPC_byRRN_RDSAPResponse DownLoadEngland_WalesEPC_byRRN_RDSAP(
      DownLoadEngland_WalesEPC_byRRN_RDSAPRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/DownLoadEnglandWalesOAEPC_byRRN", ReplyAction = "*")]
    DownLoadEnglandWalesOAEPC_byRRNResponse DownLoadEnglandWalesOAEPC_byRRN(
      DownLoadEnglandWalesOAEPC_byRRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/DownLoadEnglandWalesOAEPC_byRRN_ForDG", ReplyAction = "*")]
    DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse DownLoadEnglandWalesOAEPC_byRRN_ForDG(
      DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/sap.asmx/UploadHQMXML", ReplyAction = "*")]
    UploadHQMXMLResponse UploadHQMXML(UploadHQMXMLRequest request);
  }
}
