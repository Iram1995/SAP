
// Type: SAP2012.NISAP.NISAPSoapClient




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SAP2012.NISAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class NISAPSoapClient : ClientBase<NISAPSoap>, NISAPSoap
  {
    public NISAPSoapClient()
    {
    }

    public NISAPSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public NISAPSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public NISAPSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public NISAPSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Request_NI_LongAddressByUPRNResponse NISAP_NISAPSoap_Request_NI_LongAddressByUPRN(
      Request_NI_LongAddressByUPRNRequest request)
    {
      return this.Channel.Request_NI_LongAddressByUPRN(request);
    }

    public LongAddress Request_NI_LongAddressByUPRN(
      string UPRN,
      string username,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      Request_NI_LongAddressByUPRNRequest request = new Request_NI_LongAddressByUPRNRequest()
      {
        Body = new Request_NI_LongAddressByUPRNRequestBody()
      };
      request.Body.UPRN = UPRN;
      request.Body.username = username;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Request_NI_LongAddressByUPRN(request).Body.Request_NI_LongAddressByUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Request_NI_FormatedAddressByUPRNResponse NISAP_NISAPSoap_Request_NI_FormatedAddressByUPRN(
      Request_NI_FormatedAddressByUPRNRequest request)
    {
      return this.Channel.Request_NI_FormatedAddressByUPRN(request);
    }

    public FormattedAddress Request_NI_FormatedAddressByUPRN(
      string UPRN,
      string Username,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      Request_NI_FormatedAddressByUPRNRequest request = new Request_NI_FormatedAddressByUPRNRequest()
      {
        Body = new Request_NI_FormatedAddressByUPRNRequestBody()
      };
      request.Body.UPRN = UPRN;
      request.Body.Username = Username;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Request_NI_FormatedAddressByUPRN(request).Body.Request_NI_FormatedAddressByUPRNResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Add_New_AddressNIResponse NISAP_NISAPSoap_Add_New_AddressNI(
      Add_New_AddressNIRequest request)
    {
      return this.Channel.Add_New_AddressNI(request);
    }

    public string Add_New_AddressNI(
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
      Add_New_AddressNIRequest request = new Add_New_AddressNIRequest()
      {
        Body = new Add_New_AddressNIRequestBody()
      };
      request.Body.HouseNo = HouseNo;
      request.Body.Street = Street;
      request.Body.Locality = Locality;
      request.Body.City = City;
      request.Body.Postcode = Postcode;
      request.Body.AssessorNo = AssessorNo;
      request.Body.Notes = Notes;
      request.Body.UserName = UserName;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Add_New_AddressNI(request).Body.Add_New_AddressNIResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Request_NI_UPRNByStreetNumberAndPostCodeResponse NISAP_NISAPSoap_Request_NI_UPRNByStreetNumberAndPostCode(
      Request_NI_UPRNByStreetNumberAndPostCodeRequest request)
    {
      return this.Channel.Request_NI_UPRNByStreetNumberAndPostCode(request);
    }

    public LongAddress Request_NI_UPRNByStreetNumberAndPostCode(
      string StreetNumber,
      string PostCode,
      string username,
      string password,
      string TransactionID,
      string Encrypt)
    {
      Request_NI_UPRNByStreetNumberAndPostCodeRequest request = new Request_NI_UPRNByStreetNumberAndPostCodeRequest()
      {
        Body = new Request_NI_UPRNByStreetNumberAndPostCodeRequestBody()
      };
      request.Body.StreetNumber = StreetNumber;
      request.Body.PostCode = PostCode;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Request_NI_UPRNByStreetNumberAndPostCode(request).Body.Request_NI_UPRNByStreetNumberAndPostCodeResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResponse NISAP_NISAPSoap_Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode(
      Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest request)
    {
      return this.Channel.Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode(request);
    }

    public FormattedAddress Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode(
      string StreetNumber,
      string PostCode,
      string username,
      string password,
      string TransactionID,
      string Encrypt)
    {
      Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest request = new Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequest()
      {
        Body = new Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeRequestBody()
      };
      request.Body.StreetNumber = StreetNumber;
      request.Body.PostCode = PostCode;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Request_NI_FormattedAddressUPRNByStreetNumberAndPostCode(request).Body.Request_NI_FormattedAddressUPRNByStreetNumberAndPostCodeResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Request_NI_UPRNbyLongAddressResponse NISAP_NISAPSoap_Request_NI_UPRNbyLongAddress(
      Request_NI_UPRNbyLongAddressRequest request)
    {
      return this.Channel.Request_NI_UPRNbyLongAddress(request);
    }

    public ShortAddress[] Request_NI_UPRNbyLongAddress(
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
      Request_NI_UPRNbyLongAddressRequest request = new Request_NI_UPRNbyLongAddressRequest()
      {
        Body = new Request_NI_UPRNbyLongAddressRequestBody()
      };
      request.Body.PropertyNumber = PropertyNumber;
      request.Body.RoadName = RoadName;
      request.Body.County = County;
      request.Body.Town = Town;
      request.Body.PostCode = PostCode;
      request.Body.Username = Username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Request_NI_UPRNbyLongAddress(request).Body.Request_NI_UPRNbyLongAddressResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Request_NI_UPRNbyTempIDResponse NISAP_NISAPSoap_Request_NI_UPRNbyTempID(
      Request_NI_UPRNbyTempIDRequest request)
    {
      return this.Channel.Request_NI_UPRNbyTempID(request);
    }

    public FormattedAddress Request_NI_UPRNbyTempID(
      string TempID,
      string username,
      string password,
      string TransactionID,
      string Encrypt)
    {
      Request_NI_UPRNbyTempIDRequest request = new Request_NI_UPRNbyTempIDRequest()
      {
        Body = new Request_NI_UPRNbyTempIDRequestBody()
      };
      request.Body.TempID = TempID;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).Request_NI_UPRNbyTempID(request).Body.Request_NI_UPRNbyTempIDResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public RequestUPRNbyTempIDNIResponse NISAP_NISAPSoap_RequestUPRNbyTempIDNI(
      RequestUPRNbyTempIDNIRequest request)
    {
      return this.Channel.RequestUPRNbyTempIDNI(request);
    }

    public FormattedAddress RequestUPRNbyTempIDNI(
      string TempID,
      string TransactionID,
      string Encrypt)
    {
      RequestUPRNbyTempIDNIRequest request = new RequestUPRNbyTempIDNIRequest()
      {
        Body = new RequestUPRNbyTempIDNIRequestBody()
      };
      request.Body.TempID = TempID;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).RequestUPRNbyTempIDNI(request).Body.RequestUPRNbyTempIDNIResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public LodgeXML_NIResponse NISAP_NISAPSoap_LodgeXML_NI(
      LodgeXML_NIRequest request)
    {
      return this.Channel.LodgeXML_NI(request);
    }

    public string LodgeXML_NI(
      string XMLdata,
      string RRN,
      string username,
      string password,
      string AssessorNO,
      string TransactionID,
      string Encryption)
    {
      LodgeXML_NIRequest request = new LodgeXML_NIRequest()
      {
        Body = new LodgeXML_NIRequestBody()
      };
      request.Body.XMLdata = XMLdata;
      request.Body.RRN = RRN;
      request.Body.username = username;
      request.Body.password = password;
      request.Body.AssessorNO = AssessorNO;
      request.Body.TransactionID = TransactionID;
      request.Body.Encryption = Encryption;
      return ((NISAPSoap) this).LodgeXML_NI(request).Body.LodgeXML_NIResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public SAP_StatusResult_BYRRN_NIResponse NISAP_NISAPSoap_SAP_StatusResult_BYRRN_NI(
      SAP_StatusResult_BYRRN_NIRequest request)
    {
      return this.Channel.SAP_StatusResult_BYRRN_NI(request);
    }

    public string SAP_StatusResult_BYRRN_NI(
      string RRN,
      string EnergyAssessor,
      string userName,
      string Password,
      string TransactionID,
      string Encrypt)
    {
      SAP_StatusResult_BYRRN_NIRequest request = new SAP_StatusResult_BYRRN_NIRequest()
      {
        Body = new SAP_StatusResult_BYRRN_NIRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.EnergyAssessor = EnergyAssessor;
      request.Body.userName = userName;
      request.Body.Password = Password;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).SAP_StatusResult_BYRRN_NI(request).Body.SAP_StatusResult_BYRRN_NIResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public RequestRRNByUPRN_NIResponse NISAP_NISAPSoap_RequestRRNByUPRN_NI(
      RequestRRNByUPRN_NIRequest request)
    {
      return this.Channel.RequestRRNByUPRN_NI(request);
    }

    public string RequestRRNByUPRN_NI(
      string UPRN,
      string InspectionDate,
      string TransactionID,
      string Encrypt)
    {
      RequestRRNByUPRN_NIRequest request = new RequestRRNByUPRN_NIRequest()
      {
        Body = new RequestRRNByUPRN_NIRequestBody()
      };
      request.Body.UPRN = UPRN;
      request.Body.InspectionDate = InspectionDate;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).RequestRRNByUPRN_NI(request).Body.RequestRRNByUPRN_NIResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public DownLoadNIEPC_byRRNResponse NISAP_NISAPSoap_DownLoadNIEPC_byRRN(
      DownLoadNIEPC_byRRNRequest request)
    {
      return this.Channel.DownLoadNIEPC_byRRN(request);
    }

    public LodgedEPCtDetails DownLoadNIEPC_byRRN(
      string RRN,
      string TransactionID,
      string Encrypt)
    {
      DownLoadNIEPC_byRRNRequest request = new DownLoadNIEPC_byRRNRequest()
      {
        Body = new DownLoadNIEPC_byRRNRequestBody()
      };
      request.Body.RRN = RRN;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((NISAPSoap) this).DownLoadNIEPC_byRRN(request).Body.DownLoadNIEPC_byRRNResult;
    }
  }
}
