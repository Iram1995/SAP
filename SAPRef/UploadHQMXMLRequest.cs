
// Type: SAP2012.SAPRef.UploadHQMXMLRequest




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace SAP2012.SAPRef
{
  [DebuggerStepThrough]
  [GeneratedCode("System.ServiceModel", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MessageContract(IsWrapped = false)]
  public class UploadHQMXMLRequest
  {
    [MessageBodyMember(Name = "UploadHQMXML", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public UploadHQMXMLRequestBody Body;

    public UploadHQMXMLRequest()
    {
    }

    public UploadHQMXMLRequest(UploadHQMXMLRequestBody Body) => this.Body = Body;
  }
}
