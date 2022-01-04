
// Type: SAP2012.SAPRef.DownLoadEngland_WalesEPC_byRRNResponseBody




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
  public class DownLoadEngland_WalesEPC_byRRNResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public LodgedEPCtDetails DownLoadEngland_WalesEPC_byRRNResult;

    public DownLoadEngland_WalesEPC_byRRNResponseBody()
    {
    }

    public DownLoadEngland_WalesEPC_byRRNResponseBody(
      LodgedEPCtDetails DownLoadEngland_WalesEPC_byRRNResult)
    {
      this.DownLoadEngland_WalesEPC_byRRNResult = DownLoadEngland_WalesEPC_byRRNResult;
    }
  }
}
