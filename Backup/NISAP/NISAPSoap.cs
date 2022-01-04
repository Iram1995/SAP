
// Type: SAP2012.NISAP.NISAPSoap




using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SAP2012.NISAP
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "NISAP.NISAPSoap", Namespace = "https://www.stromamembers.co.uk/NISAP.asmx")]
  public interface NISAPSoap
  {
    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Request_NI_LongAddressByUPRN", ReplyAction = "*")]
    Request_NI_LongAddressByUPRNResponse Request_NI_LongAddressByUPRN(
      Request_NI_LongAddressByUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Request_NI_FormatedAddressByUPRN", ReplyAction = "*")]
    Request_NI_FormatedAddressByUPRNResponse Request_NI_FormatedAddressByUPRN(
      Request_NI_FormatedAddressByUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Add_New_AddressNI", ReplyAction = "*")]
    Add_New_AddressNIResponse Add_New_AddressNI(
      Add_New_AddressNIRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Request_NI_UPRNByStreetNumberAndPostCode", ReplyAction = "*")]
    Request_NI_UPRNByStreetNumberAndPostCodeResponse Request_NI_UPRNByStreetNumberAndPostCode(
      Request_NI_UPRNByStreetNumberAndPostCodeRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode", ReplyAction = "*")]
    Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode(
      Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Request_NI_UPRNbyLongAddress", ReplyAction = "*")]
    Request_NI_UPRNbyLongAddressResponse Request_NI_UPRNbyLongAddress(
      Request_NI_UPRNbyLongAddressRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/Request_NI_UPRNbyTempID", ReplyAction = "*")]
    Request_NI_UPRNbyTempIDResponse Request_NI_UPRNbyTempID(
      Request_NI_UPRNbyTempIDRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/RequestUPRNbyTempIDNI", ReplyAction = "*")]
    RequestUPRNbyTempIDNIResponse RequestUPRNbyTempIDNI(
      RequestUPRNbyTempIDNIRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/LodgeXML_NI", ReplyAction = "*")]
    LodgeXML_NIResponse LodgeXML_NI(LodgeXML_NIRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/SAP_StatusResult_BYRRN_NI", ReplyAction = "*")]
    SAP_StatusResult_BYRRN_NIResponse SAP_StatusResult_BYRRN_NI(
      SAP_StatusResult_BYRRN_NIRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/RequestRRNByUPRN_NI", ReplyAction = "*")]
    RequestRRNByUPRN_NIResponse RequestRRNByUPRN_NI(
      RequestRRNByUPRN_NIRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/NISAP.asmx/DownLoadNIEPC_byRRN", ReplyAction = "*")]
    DownLoadNIEPC_byRRNResponse DownLoadNIEPC_byRRN(
      DownLoadNIEPC_byRRNRequest request);
  }
}
