
// Type: SAP2012.ScotlandService.Stroma_DomesticScotlandSoapClient




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SAP2012.ScotlandService
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class Stroma_DomesticScotlandSoapClient : 
    ClientBase<Stroma_DomesticScotlandSoap>,
    Stroma_DomesticScotlandSoap
  {
    public Stroma_DomesticScotlandSoapClient()
    {
    }

    public Stroma_DomesticScotlandSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public Stroma_DomesticScotlandSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public Stroma_DomesticScotlandSoapClient(
      string endpointConfigurationName,
      EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public Stroma_DomesticScotlandSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public AddressSearchResponse ScotlandService_Stroma_DomesticScotlandSoap_AddressSearch(
      AddressSearchRequest request)
    {
      return this.Channel.AddressSearch(request);
    }

    public ReturnObject AddressSearch(
      bool SharedService,
      string Postcode,
      string TransactionID,
      string Encrypt)
    {
      AddressSearchRequest request = new AddressSearchRequest()
      {
        Body = new AddressSearchRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.Postcode = Postcode;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).AddressSearch(request).Body.AddressSearchResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public AddressSearch_byUPRNResponse ScotlandService_Stroma_DomesticScotlandSoap_AddressSearch_byUPRN(
      AddressSearch_byUPRNRequest request)
    {
      return this.Channel.AddressSearch_byUPRN(request);
    }

    public ReturnObject AddressSearch_byUPRN(
      bool SharedService,
      string UPRN,
      string TransactionID,
      string Encrypt)
    {
      AddressSearch_byUPRNRequest request = new AddressSearch_byUPRNRequest()
      {
        Body = new AddressSearch_byUPRNRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.UPRN = UPRN;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).AddressSearch_byUPRN(request).Body.AddressSearch_byUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public GenerateRRNByUPRNResponse ScotlandService_Stroma_DomesticScotlandSoap_GenerateRRNByUPRN(
      GenerateRRNByUPRNRequest request)
    {
      return this.Channel.GenerateRRNByUPRN(request);
    }

    public string GenerateRRNByUPRN(
      string UPRN,
      string InspectionDate,
      string TransactionID,
      string Encrypt)
    {
      GenerateRRNByUPRNRequest request = new GenerateRRNByUPRNRequest()
      {
        Body = new GenerateRRNByUPRNRequestBody()
      };
      request.Body.UPRN = UPRN;
      request.Body.InspectionDate = InspectionDate;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).GenerateRRNByUPRN(request).Body.GenerateRRNByUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadEPC_byUPRNResponse ScotlandService_Stroma_DomesticScotlandSoap_DownLoadEPC_byUPRN(
      DownLoadEPC_byUPRNRequest request)
    {
      return this.Channel.DownLoadEPC_byUPRN(request);
    }

    public string DownLoadEPC_byUPRN(
      bool SharedService,
      string UPRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      DownLoadEPC_byUPRNRequest request = new DownLoadEPC_byUPRNRequest()
      {
        Body = new DownLoadEPC_byUPRNRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.UPRN = UPRN;
      request.Body.Assessor = Assessor;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).DownLoadEPC_byUPRN(request).Body.DownLoadEPC_byUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadEPC_byRRNResponse ScotlandService_Stroma_DomesticScotlandSoap_DownLoadEPC_byRRN(
      DownLoadEPC_byRRNRequest request)
    {
      return this.Channel.DownLoadEPC_byRRN(request);
    }

    public string DownLoadEPC_byRRN(
      bool SharedService,
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      DownLoadEPC_byRRNRequest request = new DownLoadEPC_byRRNRequest()
      {
        Body = new DownLoadEPC_byRRNRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.RRN = RRN;
      request.Body.Assessor = Assessor;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).DownLoadEPC_byRRN(request).Body.DownLoadEPC_byRRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadXML_byRRNResponse ScotlandService_Stroma_DomesticScotlandSoap_DownLoadXML_byRRN(
      DownLoadXML_byRRNRequest request)
    {
      return this.Channel.DownLoadXML_byRRN(request);
    }

    public string DownLoadXML_byRRN(
      bool SharedService,
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      DownLoadXML_byRRNRequest request = new DownLoadXML_byRRNRequest()
      {
        Body = new DownLoadXML_byRRNRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.RRN = RRN;
      request.Body.Assessor = Assessor;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).DownLoadXML_byRRN(request).Body.DownLoadXML_byRRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DraftEPCResponse ScotlandService_Stroma_DomesticScotlandSoap_DraftEPC(
      DraftEPCRequest request)
    {
      return this.Channel.DraftEPC(request);
    }

    public string DraftEPC(
      bool SharedService,
      string XML,
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      DraftEPCRequest request = new DraftEPCRequest()
      {
        Body = new DraftEPCRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.XML = XML;
      request.Body.RRN = RRN;
      request.Body.Assessor = Assessor;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).DraftEPC(request).Body.DraftEPCResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public LodgeEPCResponse ScotlandService_Stroma_DomesticScotlandSoap_LodgeEPC(
      LodgeEPCRequest request)
    {
      return this.Channel.LodgeEPC(request);
    }

    public string LodgeEPC(
      bool SharedService,
      string XML,
      string RRN,
      string Assessor,
      string UserName,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      LodgeEPCRequest request = new LodgeEPCRequest()
      {
        Body = new LodgeEPCRequestBody()
      };
      request.Body.SharedService = SharedService;
      request.Body.XML = XML;
      request.Body.RRN = RRN;
      request.Body.Assessor = Assessor;
      request.Body.UserName = UserName;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((Stroma_DomesticScotlandSoap) this).LodgeEPC(request).Body.LodgeEPCResult;
    }
  }
}
