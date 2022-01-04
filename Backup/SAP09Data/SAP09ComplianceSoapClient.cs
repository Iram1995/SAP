
// Type: SAP2012.SAP09Data.SAP09ComplianceSoapClient




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SAP2012.SAP09Data
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class SAP09ComplianceSoapClient : ClientBase<SAP09ComplianceSoap>, SAP09ComplianceSoap
  {
    public SAP09ComplianceSoapClient()
    {
    }

    public SAP09ComplianceSoapClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public SAP09ComplianceSoapClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public SAP09ComplianceSoapClient(
      string endpointConfigurationName,
      EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public SAP09ComplianceSoapClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public SendCompliance_DetailsResponse SAP09Data_SAP09ComplianceSoap_SendCompliance_Details(
      SendCompliance_DetailsRequest request)
    {
      return this.Channel.SendCompliance_Details(request);
    }

    public string SendCompliance_Details(
      ComplianceDetails SDetails,
      string TransactionID,
      string Encrypt)
    {
      SendCompliance_DetailsRequest request = new SendCompliance_DetailsRequest()
      {
        Body = new SendCompliance_DetailsRequestBody()
      };
      request.Body.SDetails = SDetails;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAP09ComplianceSoap) this).SendCompliance_Details(request).Body.SendCompliance_DetailsResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public SendSAP_detailsResponse SAP09Data_SAP09ComplianceSoap_SendSAP_details(
      SendSAP_detailsRequest request)
    {
      return this.Channel.SendSAP_details(request);
    }

    public string SendSAP_details(
      Dwelling Dwell,
      string userID,
      string TransactionID,
      string Encrypt)
    {
      SendSAP_detailsRequest request = new SendSAP_detailsRequest()
      {
        Body = new SendSAP_detailsRequestBody()
      };
      request.Body.Dwell = Dwell;
      request.Body.userID = userID;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAP09ComplianceSoap) this).SendSAP_details(request).Body.SendSAP_detailsResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Upload_ComplianceSheetResponse SAP09Data_SAP09ComplianceSoap_Upload_ComplianceSheet(
      Upload_ComplianceSheetRequest request)
    {
      return this.Channel.Upload_ComplianceSheet(request);
    }

    public string Upload_ComplianceSheet(
      string Data,
      string FileName,
      string TransactionID,
      string Encrypt)
    {
      Upload_ComplianceSheetRequest request = new Upload_ComplianceSheetRequest()
      {
        Body = new Upload_ComplianceSheetRequestBody()
      };
      request.Body.Data = Data;
      request.Body.FileName = FileName;
      request.Body.TransactionID = TransactionID;
      request.Body.Encrypt = Encrypt;
      return ((SAP09ComplianceSoap) this).Upload_ComplianceSheet(request).Body.Upload_ComplianceSheetResult;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ValidateUserResponse SAP09Data_SAP09ComplianceSoap_ValidateUser(
      ValidateUserRequest request)
    {
      return this.Channel.ValidateUser(request);
    }

    public string ValidateUser(string Username, string password)
    {
      ValidateUserRequest request = new ValidateUserRequest()
      {
        Body = new ValidateUserRequestBody()
      };
      request.Body.Username = Username;
      request.Body.password = password;
      return ((SAP09ComplianceSoap) this).ValidateUser(request).Body.ValidateUserResult;
    }
  }
}
