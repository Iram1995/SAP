
// Type: SAP2012.SAPRef.DownLoadEngland_WalesEPC_byRRN_RDSAPResponseBody




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DataContract(Namespace = "https://www.stromamembers.co.uk/sap.asmx")]
  public class DownLoadEngland_WalesEPC_byRRN_RDSAPResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public LodgedEPCtDetails DownLoadEngland_WalesEPC_byRRN_RDSAPResult;

    public DownLoadEngland_WalesEPC_byRRN_RDSAPResponseBody()
    {
    }

    public DownLoadEngland_WalesEPC_byRRN_RDSAPResponseBody(
      LodgedEPCtDetails DownLoadEngland_WalesEPC_byRRN_RDSAPResult)
    {
      this.DownLoadEngland_WalesEPC_byRRN_RDSAPResult = DownLoadEngland_WalesEPC_byRRN_RDSAPResult;
    }
  }
}
