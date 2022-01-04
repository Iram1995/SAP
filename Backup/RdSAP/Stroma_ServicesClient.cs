
// Type: SAP2012.RdSAP.Stroma_ServicesClient




using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  public class Stroma_ServicesClient : ClientBase<Stroma_Services>, Stroma_Services
  {
    public Stroma_ServicesClient()
    {
    }

    public Stroma_ServicesClient(string endpointConfigurationName)
      : base(endpointConfigurationName)
    {
    }

    public Stroma_ServicesClient(string endpointConfigurationName, string remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public Stroma_ServicesClient(string endpointConfigurationName, EndpointAddress remoteAddress)
      : base(endpointConfigurationName, remoteAddress)
    {
    }

    public Stroma_ServicesClient(Binding binding, EndpointAddress remoteAddress)
      : base(binding, remoteAddress)
    {
    }

    public Survey_Class Get_Survey_Details(string RDSAPID, SecurityData SecurityData) => this.Channel.Get_Survey_Details(RDSAPID, SecurityData);

    public LoadReturn Get_Survey_Details_Notes(string RDSAPID, SecurityData SecurityData) => this.Channel.Get_Survey_Details_Notes(RDSAPID, SecurityData);

    public UploadResult Upload_Survey_Notes(
      Survey_Class Survey,
      string Notes,
      SecurityData SecurityData)
    {
      return this.Channel.Upload_Survey_Notes(Survey, Notes, SecurityData);
    }

    public UploadResult Upload_Survey(Survey_Class Survey, SecurityData SecurityData) => this.Channel.Upload_Survey(Survey, SecurityData);

    public int Create_New(int UserID, SecurityData SecurityData) => this.Channel.Create_New(UserID, SecurityData);

    public string Create_Survey_Report(int RDSAPID, bool Show_Images, SecurityData SecurityData) => this.Channel.Create_Survey_Report(RDSAPID, Show_Images, SecurityData);

    public string Create_Survey_ReportBySurvey(
      Survey_Class Survey,
      int AssessorID,
      bool Show_Images,
      SecurityData SecurityData)
    {
      return this.Channel.Create_Survey_ReportBySurvey(Survey, AssessorID, Show_Images, SecurityData);
    }

    public RdSAPNews[] Get_News(SecurityData SecurityData) => this.Channel.Get_News(SecurityData);

    public RdSAPDocuments[] Get_Documents(SecurityData SecurityData) => this.Channel.Get_Documents(SecurityData);

    public UploadResult Cancel_Recommendation(
      int RdSAPID,
      string Recommendation,
      SecurityData SecurityData)
    {
      return this.Channel.Cancel_Recommendation(RdSAPID, Recommendation, SecurityData);
    }

    public UploadResult Cancel_RecommendationList(
      int RdSAPID,
      string[] Recommendation,
      SecurityData SecurityData)
    {
      return this.Channel.Cancel_RecommendationList(RdSAPID, Recommendation, SecurityData);
    }

    public UploadResult Reset_Recommendations(int RdSAPID, SecurityData SecurityData) => this.Channel.Reset_Recommendations(RdSAPID, SecurityData);

    public ReturnRecommendsations Get_CancelledRecommendations(
      int RdSAPID,
      SecurityData SecurityData)
    {
      return this.Channel.Get_CancelledRecommendations(RdSAPID, SecurityData);
    }

    public bool Change_Password(int UserID, string NewPassword, SecurityData SecurityData) => this.Channel.Change_Password(UserID, NewPassword, SecurityData);

    public bool Check_iApp(int UserID, SecurityData SecurityData) => this.Channel.Check_iApp(UserID, SecurityData);

    public bool Check_iAppToriga(int UserID, SecurityData SecurityData) => this.Channel.Check_iAppToriga(UserID, SecurityData);

    public LogonClass Logon(string Version, string OSVersion, SecurityData SecurityData) => this.Channel.Logon(Version, OSVersion, SecurityData);

    public AssessorDetail Assessor(int UserID, SecurityData SecurityData) => this.Channel.Assessor(UserID, SecurityData);

    public AssessorInsurance Assessors_Insurance(
      int UserID,
      SecurityData SecurityData)
    {
      return this.Channel.Assessors_Insurance(UserID, SecurityData);
    }

    public UserSurveys[] Get_UserSurveys(int UserID, SecurityData SecurityData) => this.Channel.Get_UserSurveys(UserID, SecurityData);

    public UserSurveys[] Get_UserSurveys50(int UserID, SecurityData SecurityData) => this.Channel.Get_UserSurveys50(UserID, SecurityData);

    public UserSurveys[] GetUser_Surveys_Filtered(
      int UserID,
      string Address,
      string PostCode,
      string ReferenceId,
      DateTime ToDate,
      DateTime FromDate,
      SecurityData SecurityData)
    {
      return this.Channel.GetUser_Surveys_Filtered(UserID, Address, PostCode, ReferenceId, ToDate, FromDate, SecurityData);
    }

    public Permissions Get_UserPermissions(
      int UserID,
      int CompanyID,
      SecurityData SecurityData)
    {
      return this.Channel.Get_UserPermissions(UserID, CompanyID, SecurityData);
    }

    public PCDF_Return Get_PCDF(
      string CurrentVersion,
      DateTime FileDate,
      SecurityData SecurityData)
    {
      return this.Channel.Get_PCDF(CurrentVersion, FileDate, SecurityData);
    }

    public string Update_PCDF(SecurityData SecurityData) => this.Channel.Update_PCDF(SecurityData);

    public int Get_Revision(int RDSAPID) => this.Channel.Get_Revision(RDSAPID);

    public LoadReturn Get_SurveyDetails_ByRRN(string RRN, SecurityData SecurityData) => this.Channel.Get_SurveyDetails_ByRRN(RRN, SecurityData);

    public UploadResult Save_ByXML(int RDSAPID, string XML, SecurityData SecurityData) => this.Channel.Save_ByXML(RDSAPID, XML, SecurityData);

    public bool UpdateRatings(int RDSAPID, RatingsValues values, SecurityData SecurityData) => this.Channel.UpdateRatings(RDSAPID, values, SecurityData);

    public string Get_OSA_Details(SecurityData SecurityData) => this.Channel.Get_OSA_Details(SecurityData);

    public AssociatedUsers GetFullUsersList(SecurityData SecurityData) => this.Channel.GetFullUsersList(SecurityData);

    public RDSAPIDList GetRDSAPIDsByUserList(
      User[] userList,
      DateTime startDate,
      DateTime endDate,
      SecurityData securityData)
    {
      return this.Channel.GetRDSAPIDsByUserList(userList, startDate, endDate, securityData);
    }
  }
}
