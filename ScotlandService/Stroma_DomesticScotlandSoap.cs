
// Type: SAP2012.ScotlandService.Stroma_DomesticScotlandSoap




using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SAP2012.ScotlandService
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "ScotlandService.Stroma_DomesticScotlandSoap", Namespace = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx")]
  public interface Stroma_DomesticScotlandSoap
  {
    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/AddressSearch", ReplyAction = "*")]
    AddressSearchResponse AddressSearch(AddressSearchRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/AddressSearch_byUPRN", ReplyAction = "*")]
    AddressSearch_byUPRNResponse AddressSearch_byUPRN(
      AddressSearch_byUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/GenerateRRNByUPRN", ReplyAction = "*")]
    GenerateRRNByUPRNResponse GenerateRRNByUPRN(
      GenerateRRNByUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/DownLoadEPC_byUPRN", ReplyAction = "*")]
    DownLoadEPC_byUPRNResponse DownLoadEPC_byUPRN(
      DownLoadEPC_byUPRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/DownLoadEPC_byRRN", ReplyAction = "*")]
    DownLoadEPC_byRRNResponse DownLoadEPC_byRRN(
      DownLoadEPC_byRRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/DownLoadXML_byRRN", ReplyAction = "*")]
    DownLoadXML_byRRNResponse DownLoadXML_byRRN(
      DownLoadXML_byRRNRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/DraftEPC", ReplyAction = "*")]
    DraftEPCResponse DraftEPC(DraftEPCRequest request);

    [OperationContract(Action = "https://www.stromamembers.co.uk/Stroma_DomesticScotland.asmx/LodgeEPC", ReplyAction = "*")]
    LodgeEPCResponse LodgeEPC(LodgeEPCRequest request);
  }
}
