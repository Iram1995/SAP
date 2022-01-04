
// Type: SAP2012.SAPRef.DownLoadScotlandEPCRequestBody




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
  public class DownLoadScotlandEPCRequestBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string FileName;
    [DataMember(EmitDefaultValue = false, Order = 1)]
    public string TranasctionID;
    [DataMember(EmitDefaultValue = false, Order = 2)]
    public string Encryption;

    public DownLoadScotlandEPCRequestBody()
    {
    }

    public DownLoadScotlandEPCRequestBody(string FileName, string TranasctionID, string Encryption)
    {
      this.FileName = FileName;
      this.TranasctionID = TranasctionID;
      this.Encryption = Encryption;
    }
  }
}
