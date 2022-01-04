
// Type: SAP2012.SAPRef.RequestScotlandAddressResponse




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
  public class RequestScotlandAddressResponse
  {
    [MessageBodyMember(Name = "RequestScotlandAddressResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public RequestScotlandAddressResponseBody Body;

    public RequestScotlandAddressResponse()
    {
    }

    public RequestScotlandAddressResponse(RequestScotlandAddressResponseBody Body) => this.Body = Body;
  }
}
