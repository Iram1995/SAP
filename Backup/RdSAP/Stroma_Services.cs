
// Type: SAP2012.RdSAP.Stroma_Services




using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace SAP2012.RdSAP
{
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [ServiceContract(ConfigurationName = "RdSAP.Stroma_Services")]
  public interface Stroma_Services
  {
    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_Survey_Details", ReplyAction = "http://tempuri.org/Stroma_Services/Get_Survey_DetailsResponse")]
    Survey_Class Get_Survey_Details(string RDSAPID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_Survey_Details_Notes", ReplyAction = "http://tempuri.org/Stroma_Services/Get_Survey_Details_NotesResponse")]
    LoadReturn Get_Survey_Details_Notes(string RDSAPID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Upload_Survey_Notes", ReplyAction = "http://tempuri.org/Stroma_Services/Upload_Survey_NotesResponse")]
    UploadResult Upload_Survey_Notes(
      Survey_Class Survey,
      string Notes,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Upload_Survey", ReplyAction = "http://tempuri.org/Stroma_Services/Upload_SurveyResponse")]
    UploadResult Upload_Survey(Survey_Class Survey, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Create_New", ReplyAction = "http://tempuri.org/Stroma_Services/Create_NewResponse")]
    int Create_New(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Create_Survey_Report", ReplyAction = "http://tempuri.org/Stroma_Services/Create_Survey_ReportResponse")]
    string Create_Survey_Report(int RDSAPID, bool Show_Images, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Create_Survey_ReportBySurvey", ReplyAction = "http://tempuri.org/Stroma_Services/Create_Survey_ReportBySurveyResponse")]
    string Create_Survey_ReportBySurvey(
      Survey_Class Survey,
      int AssessorID,
      bool Show_Images,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_News", ReplyAction = "http://tempuri.org/Stroma_Services/Get_NewsResponse")]
    RdSAPNews[] Get_News(SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_Documents", ReplyAction = "http://tempuri.org/Stroma_Services/Get_DocumentsResponse")]
    RdSAPDocuments[] Get_Documents(SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Cancel_Recommendation", ReplyAction = "http://tempuri.org/Stroma_Services/Cancel_RecommendationResponse")]
    UploadResult Cancel_Recommendation(
      int RdSAPID,
      string Recommendation,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Cancel_RecommendationList", ReplyAction = "http://tempuri.org/Stroma_Services/Cancel_RecommendationListResponse")]
    UploadResult Cancel_RecommendationList(
      int RdSAPID,
      string[] Recommendation,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Reset_Recommendations", ReplyAction = "http://tempuri.org/Stroma_Services/Reset_RecommendationsResponse")]
    UploadResult Reset_Recommendations(int RdSAPID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_CancelledRecommendations", ReplyAction = "http://tempuri.org/Stroma_Services/Get_CancelledRecommendationsResponse")]
    ReturnRecommendsations Get_CancelledRecommendations(
      int RdSAPID,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Change_Password", ReplyAction = "http://tempuri.org/Stroma_Services/Change_PasswordResponse")]
    bool Change_Password(int UserID, string NewPassword, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Check_iApp", ReplyAction = "http://tempuri.org/Stroma_Services/Check_iAppResponse")]
    bool Check_iApp(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Check_iAppToriga", ReplyAction = "http://tempuri.org/Stroma_Services/Check_iAppTorigaResponse")]
    bool Check_iAppToriga(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Logon", ReplyAction = "http://tempuri.org/Stroma_Services/LogonResponse")]
    LogonClass Logon(string Version, string OSVersion, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Assessor", ReplyAction = "http://tempuri.org/Stroma_Services/AssessorResponse")]
    AssessorDetail Assessor(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Assessors_Insurance", ReplyAction = "http://tempuri.org/Stroma_Services/Assessors_InsuranceResponse")]
    AssessorInsurance Assessors_Insurance(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_UserSurveys", ReplyAction = "http://tempuri.org/Stroma_Services/Get_UserSurveysResponse")]
    UserSurveys[] Get_UserSurveys(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_UserSurveys50", ReplyAction = "http://tempuri.org/Stroma_Services/Get_UserSurveys50Response")]
    UserSurveys[] Get_UserSurveys50(int UserID, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/GetUser_Surveys_Filtered", ReplyAction = "http://tempuri.org/Stroma_Services/GetUser_Surveys_FilteredResponse")]
    UserSurveys[] GetUser_Surveys_Filtered(
      int UserID,
      string Address,
      string PostCode,
      string ReferenceId,
      DateTime ToDate,
      DateTime FromDate,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_UserPermissions", ReplyAction = "http://tempuri.org/Stroma_Services/Get_UserPermissionsResponse")]
    Permissions Get_UserPermissions(
      int UserID,
      int CompanyID,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_PCDF", ReplyAction = "http://tempuri.org/Stroma_Services/Get_PCDFResponse")]
    PCDF_Return Get_PCDF(
      string CurrentVersion,
      DateTime FileDate,
      SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Update_PCDF", ReplyAction = "http://tempuri.org/Stroma_Services/Update_PCDFResponse")]
    string Update_PCDF(SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_Revision", ReplyAction = "http://tempuri.org/Stroma_Services/Get_RevisionResponse")]
    int Get_Revision(int RDSAPID);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_SurveyDetails_ByRRN", ReplyAction = "http://tempuri.org/Stroma_Services/Get_SurveyDetails_ByRRNResponse")]
    LoadReturn Get_SurveyDetails_ByRRN(string RRN, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Save_ByXML", ReplyAction = "http://tempuri.org/Stroma_Services/Save_ByXMLResponse")]
    UploadResult Save_ByXML(int RDSAPID, string XML, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/UpdateRatings", ReplyAction = "http://tempuri.org/Stroma_Services/UpdateRatingsResponse")]
    bool UpdateRatings(int RDSAPID, RatingsValues values, SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/Get_OSA_Details", ReplyAction = "http://tempuri.org/Stroma_Services/Get_OSA_DetailsResponse")]
    string Get_OSA_Details(SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/GetFullUsersList", ReplyAction = "http://tempuri.org/Stroma_Services/GetFullUsersListResponse")]
    AssociatedUsers GetFullUsersList(SecurityData SecurityData);

    [OperationContract(Action = "http://tempuri.org/Stroma_Services/GetRDSAPIDsByUserList", ReplyAction = "http://tempuri.org/Stroma_Services/GetRDSAPIDsByUserListResponse")]
    RDSAPIDList GetRDSAPIDsByUserList(
      User[] userList,
      DateTime startDate,
      DateTime endDate,
      SecurityData securityData);
  }
}
