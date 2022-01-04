
// Type: SAP2012.SAPRef.SAPSoapClient




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class SAPSoapClient : ClientBase<SAPSoap>, SAPSoap
  {
    public SAPSoapClient()
    {
    }

    public SAPSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public SAPSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public SAPSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public SAPSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ChecksapimportpermissionResponse SAPRef_SAPSoap_Checksapimportpermission(
      ChecksapimportpermissionRequest request)
    {
      return this.Channel.Checksapimportpermission(request);
    }

    public sapImportpermissionclass Checksapimportpermission(
      string Assessor,
      string UserName,
      string Password,
      string TransactionID,
      string Encryption)
    {
      ChecksapimportpermissionRequest request = new ChecksapimportpermissionRequest()
      {
        Body = new ChecksapimportpermissionRequestBody()
      };
      request.Body.Assessor = Assessor;
      request.Body.UserName = UserName;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).Checksapimportpermission(request).Body.ChecksapimportpermissionResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public HomeInspectorDetailsResponse SAPRef_SAPSoap_HomeInspectorDetails(
      HomeInspectorDetailsRequest request)
    {
      return this.Channel.HomeInspectorDetails(request);
    }

    public string HomeInspectorDetails(
      string UserName,
      string Password,
      string CertificateNo,
      string TransactionID,
      string Encryption)
    {
      HomeInspectorDetailsRequest request = new HomeInspectorDetailsRequest()
      {
        Body = new HomeInspectorDetailsRequestBody()
      };
      request.Body.UserName = UserName;
      request.Body.Password = Password;
      request.Body.CertificateNo = CertificateNo;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).HomeInspectorDetails(request).Body.HomeInspectorDetailsResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public LodgeXMLResponse SAPRef_SAPSoap_LodgeXML(LodgeXMLRequest request) => this.Channel.LodgeXML(request);

    public string LodgeXML(
      string XMLdata,
      string RRN,
      string username,
      string password,
      string AssessorNO,
      string TransactionID,
      string Encryption,
      CountryType Country)
    {
      LodgeXMLRequest request = new LodgeXMLRequest()
      {
        Body = new LodgeXMLRequestBody()
      };
      request.Body.XMLdata = XMLdata;
      request.Body.RRN = RRN;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.AssessorNO = AssessorNO;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      request.Body.Country = Country;
      return ((SAPSoap) this).LodgeXML(request).Body.LodgeXMLResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoad_lodgedEPC_In_ScotlandResponse SAPRef_SAPSoap_DownLoad_lodgedEPC_In_Scotland(
      DownLoad_lodgedEPC_In_ScotlandRequest request)
    {
      return this.Channel.DownLoad_lodgedEPC_In_Scotland(request);
    }

    public string DownLoad_lodgedEPC_In_Scotland(
      string AssessorNO,
      string RRN,
      string TransactionID,
      string Encryption)
    {
      DownLoad_lodgedEPC_In_ScotlandRequest request = new DownLoad_lodgedEPC_In_ScotlandRequest()
      {
        Body = new DownLoad_lodgedEPC_In_ScotlandRequestBody()
      };
      request.Body.AssessorNO = AssessorNO;
      request.Body.RRN = RRN;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).DownLoad_lodgedEPC_In_Scotland(request).Body.DownLoad_lodgedEPC_In_ScotlandResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public LodgeScotlandXMLResponse SAPRef_SAPSoap_LodgeScotlandXML(
      LodgeScotlandXMLRequest request)
    {
      return this.Channel.LodgeScotlandXML(request);
    }

    public string LodgeScotlandXML(
      string XMLdata,
      string username,
      string password,
      string AssessorNO,
      string RRN,
      string TransactionID,
      string Encryption)
    {
      LodgeScotlandXMLRequest request = new LodgeScotlandXMLRequest()
      {
        Body = new LodgeScotlandXMLRequestBody()
      };
      request.Body.XMLdata = XMLdata;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.AssessorNO = AssessorNO;
      request.Body.RRN = RRN;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).LodgeScotlandXML(request).Body.LodgeScotlandXMLResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public SAP_DraftsResponse SAPRef_SAPSoap_SAP_Drafts(SAP_DraftsRequest request) => this.Channel.SAP_Drafts(request);

    public DraftDetails SAP_Drafts(
      string XMLdata,
      string AssessorNO,
      string RRN,
      int Country,
      string username,
      string password,
      string TransactionID,
      string Encryption)
    {
      SAP_DraftsRequest request = new SAP_DraftsRequest()
      {
        Body = new SAP_DraftsRequestBody()
      };
      request.Body.XMLdata = XMLdata;
      request.Body.AssessorNO = AssessorNO;
      request.Body.RRN = RRN;
      request.Body.Country = Country;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).SAP_Drafts(request).Body.SAP_DraftsResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public RequestScotlandAddressResponse SAPRef_SAPSoap_RequestScotlandAddress(
      RequestScotlandAddressRequest request)
    {
      return this.Channel.RequestScotlandAddress(request);
    }

    public string RequestScotlandAddress(string Postcode, string TransactionID, string Encrypt)
    {
      RequestScotlandAddressRequest request = new RequestScotlandAddressRequest()
      {
        Body = new RequestScotlandAddressRequestBody()
      };
      request.Body.Postcode = Postcode;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAPSoap) this).RequestScotlandAddress(request).Body.RequestScotlandAddressResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public AddressByUPRNResponse SAPRef_SAPSoap_AddressByUPRN(
      AddressByUPRNRequest request)
    {
      return this.Channel.AddressByUPRN(request);
    }

    public AddressResult AddressByUPRN(string UPRN, AddressRequest Request)
    {
      AddressByUPRNRequest request = new AddressByUPRNRequest()
      {
        Body = new AddressByUPRNRequestBody()
      };
      request.Body.UPRN = UPRN;
      request.Body.Request = Request;
      return ((SAPSoap) this).AddressByUPRN(request).Body.AddressByUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public AddressSearchResponse SAPRef_SAPSoap_AddressSearch(
      AddressSearchRequest request)
    {
      return this.Channel.AddressSearch(request);
    }

    public AddressResult AddressSearch(string Postcode, AddressRequest Request)
    {
      AddressSearchRequest request = new AddressSearchRequest()
      {
        Body = new AddressSearchRequestBody()
      };
      request.Body.Postcode = Postcode;
      request.Body.Request = Request;
      return ((SAPSoap) this).AddressSearch(request).Body.AddressSearchResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public AddressNewAddressIDResponse SAPRef_SAPSoap_AddressNewAddressID(
      AddressNewAddressIDRequest request)
    {
      return this.Channel.AddressNewAddressID(request);
    }

    public int AddressNewAddressID(AddressRequest Request)
    {
      AddressNewAddressIDRequest request = new AddressNewAddressIDRequest()
      {
        Body = new AddressNewAddressIDRequestBody()
      };
      request.Body.Request = Request;
      return ((SAPSoap) this).AddressNewAddressID(request).Body.AddressNewAddressIDResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ValidateUserResponse SAPRef_SAPSoap_ValidateUser(
      ValidateUserRequest request)
    {
      return this.Channel.ValidateUser(request);
    }

    public bool ValidateUser(
      string Username,
      string password,
      string TransactionID,
      string Encryption)
    {
      ValidateUserRequest request = new ValidateUserRequest()
      {
        Body = new ValidateUserRequestBody()
      };
      request.Body.Username = Username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).ValidateUser(request).Body.ValidateUserResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ValidateSAPUserResponse SAPRef_SAPSoap_ValidateSAPUser(
      ValidateSAPUserRequest request)
    {
      return this.Channel.ValidateSAPUser(request);
    }

    public bool ValidateSAPUser(
      string Username,
      string password,
      string TransactionID,
      string Encryption)
    {
      ValidateSAPUserRequest request = new ValidateSAPUserRequest()
      {
        Body = new ValidateSAPUserRequestBody()
      };
      request.Body.Username = Username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).ValidateSAPUser(request).Body.ValidateSAPUserResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public RequestRRNByUPRNResponse SAPRef_SAPSoap_RequestRRNByUPRN(
      RequestRRNByUPRNRequest request)
    {
      return this.Channel.RequestRRNByUPRN(request);
    }

    public string RequestRRNByUPRN(
      string UPRN,
      string InspectionDate,
      string TransactionID,
      string Encrypt)
    {
      RequestRRNByUPRNRequest request = new RequestRRNByUPRNRequest()
      {
        Body = new RequestRRNByUPRNRequestBody()
      };
      request.Body.UPRN = UPRN;
      request.Body.InspectionDate = InspectionDate;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAPSoap) this).RequestRRNByUPRN(request).Body.RequestRRNByUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public StromaDetailsResponse SAPRef_SAPSoap_StromaDetails(
      StromaDetailsRequest request)
    {
      return this.Channel.StromaDetails(request);
    }

    public string StromaDetails(
      string Username,
      string Password,
      string TransactionID,
      string Encryption)
    {
      StromaDetailsRequest request = new StromaDetailsRequest()
      {
        Body = new StromaDetailsRequestBody()
      };
      request.Body.Username = Username;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).StromaDetails(request).Body.StromaDetailsResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public HomeInspectorDetailsByUserNamePasswordResponse SAPRef_SAPSoap_HomeInspectorDetailsByUserNamePassword(
      HomeInspectorDetailsByUserNamePasswordRequest request)
    {
      return this.Channel.HomeInspectorDetailsByUserNamePassword(request);
    }

    public string HomeInspectorDetailsByUserNamePassword(
      string UserName,
      string Password,
      string TransactionID,
      string Encryption)
    {
      HomeInspectorDetailsByUserNamePasswordRequest request = new HomeInspectorDetailsByUserNamePasswordRequest()
      {
        Body = new HomeInspectorDetailsByUserNamePasswordRequestBody()
      };
      request.Body.UserName = UserName;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).HomeInspectorDetailsByUserNamePassword(request).Body.HomeInspectorDetailsByUserNamePasswordResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public SAP_StatusResult_BYRRNResponse SAPRef_SAPSoap_SAP_StatusResult_BYRRN(
      SAP_StatusResult_BYRRNRequest request)
    {
      return this.Channel.SAP_StatusResult_BYRRN(request);
    }

    public string SAP_StatusResult_BYRRN(
      string RRN,
      string EACertificateNo,
      string Username,
      string Password,
      string TransactionID,
      string Encryption)
    {
      SAP_StatusResult_BYRRNRequest request = new SAP_StatusResult_BYRRNRequest()
      {
        Body = new SAP_StatusResult_BYRRNRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.EACertificateNo = EACertificateNo;
      request.Body.Username = Username;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).SAP_StatusResult_BYRRN(request).Body.SAP_StatusResult_BYRRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadScotlandEPCResponse SAPRef_SAPSoap_DownLoadScotlandEPC(
      DownLoadScotlandEPCRequest request)
    {
      return this.Channel.DownLoadScotlandEPC(request);
    }

    public string DownLoadScotlandEPC(string FileName, string TranasctionID, string Encryption)
    {
      DownLoadScotlandEPCRequest request = new DownLoadScotlandEPCRequest()
      {
        Body = new DownLoadScotlandEPCRequestBody()
      };
      request.Body.FileName = FileName;
      request.Body.TranasctionID = TranasctionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).DownLoadScotlandEPC(request).Body.DownLoadScotlandEPCResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public CheckInsuranceResponse SAPRef_SAPSoap_CheckInsurance(
      CheckInsuranceRequest request)
    {
      return this.Channel.CheckInsurance(request);
    }

    public Insurance CheckInsurance(
      string Assessor,
      string UserName,
      string Password,
      string TransactionID,
      string Encryption)
    {
      CheckInsuranceRequest request = new CheckInsuranceRequest()
      {
        Body = new CheckInsuranceRequestBody()
      };
      request.Body.Assessor = Assessor;
      request.Body.UserName = UserName;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((SAPSoap) this).CheckInsurance(request).Body.CheckInsuranceResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadEngland_WalesEPC_byRRNResponse SAPRef_SAPSoap_DownLoadEngland_WalesEPC_byRRN(
      DownLoadEngland_WalesEPC_byRRNRequest request)
    {
      return this.Channel.DownLoadEngland_WalesEPC_byRRN(request);
    }

    public LodgedEPCtDetails DownLoadEngland_WalesEPC_byRRN(
      string RRN,
      string TransactionID,
      string Encrypt)
    {
      DownLoadEngland_WalesEPC_byRRNRequest request = new DownLoadEngland_WalesEPC_byRRNRequest()
      {
        Body = new DownLoadEngland_WalesEPC_byRRNRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAPSoap) this).DownLoadEngland_WalesEPC_byRRN(request).Body.DownLoadEngland_WalesEPC_byRRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadEngland_WalesEPC_byRRN_RDSAPResponse SAPRef_SAPSoap_DownLoadEngland_WalesEPC_byRRN_RDSAP(
      DownLoadEngland_WalesEPC_byRRN_RDSAPRequest request)
    {
      return this.Channel.DownLoadEngland_WalesEPC_byRRN_RDSAP(request);
    }

    public LodgedEPCtDetails DownLoadEngland_WalesEPC_byRRN_RDSAP(
      string RRN,
      string TransactionID,
      string Encrypt)
    {
      DownLoadEngland_WalesEPC_byRRN_RDSAPRequest request = new DownLoadEngland_WalesEPC_byRRN_RDSAPRequest()
      {
        Body = new DownLoadEngland_WalesEPC_byRRN_RDSAPRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAPSoap) this).DownLoadEngland_WalesEPC_byRRN_RDSAP(request).Body.DownLoadEngland_WalesEPC_byRRN_RDSAPResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadEnglandWalesOAEPC_byRRNResponse SAPRef_SAPSoap_DownLoadEnglandWalesOAEPC_byRRN(
      DownLoadEnglandWalesOAEPC_byRRNRequest request)
    {
      return this.Channel.DownLoadEnglandWalesOAEPC_byRRN(request);
    }

    public string DownLoadEnglandWalesOAEPC_byRRN(
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      DownLoadEnglandWalesOAEPC_byRRNRequest request = new DownLoadEnglandWalesOAEPC_byRRNRequest()
      {
        Body = new DownLoadEnglandWalesOAEPC_byRRNRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.Assessor = Assessor;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAPSoap) this).DownLoadEnglandWalesOAEPC_byRRN(request).Body.DownLoadEnglandWalesOAEPC_byRRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadEnglandWalesOAEPC_byRRN_ForDGResponse SAPRef_SAPSoap_DownLoadEnglandWalesOAEPC_byRRN_ForDG(
      DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest request)
    {
      return this.Channel.DownLoadEnglandWalesOAEPC_byRRN_ForDG(request);
    }

    public string DownLoadEnglandWalesOAEPC_byRRN_ForDG(
      string RRN,
      string Assessor,
      string TransactionID,
      string Encrypt)
    {
      DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest request = new DownLoadEnglandWalesOAEPC_byRRN_ForDGRequest()
      {
        Body = new DownLoadEnglandWalesOAEPC_byRRN_ForDGRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.Assessor = Assessor;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAPSoap) this).DownLoadEnglandWalesOAEPC_byRRN_ForDG(request).Body.DownLoadEnglandWalesOAEPC_byRRN_ForDGResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public UploadHQMXMLResponse SAPRef_SAPSoap_UploadHQMXML(
      UploadHQMXMLRequest request)
    {
      return this.Channel.UploadHQMXML(request);
    }

    public HQMResult UploadHQMXML(HQMRequest Request)
    {
      UploadHQMXMLRequest request = new UploadHQMXMLRequest()
      {
        Body = new UploadHQMXMLRequestBody()
      };
      request.Body.Request = Request;
      return ((SAPSoap) this).UploadHQMXML(request).Body.UploadHQMXMLResult;
    }
  }
}
