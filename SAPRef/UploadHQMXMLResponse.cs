
// Type: SAP2012.SAPRef.UploadHQMXMLResponse




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
  public class UploadHQMXMLResponse
  {
    [MessageBodyMember(Name = "UploadHQMXMLResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public UploadHQMXMLResponseBody Body;

    public UploadHQMXMLResponse()
    {
    }

    public UploadHQMXMLResponse(UploadHQMXMLResponseBody Body) => this.Body = Body;
  }
}
