﻿
// Type: SAP2012.SAPRef.RequestScotlandAddressRequest




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
  public class RequestScotlandAddressRequest
  {
    [MessageBodyMember(Name = "RequestScotlandAddress", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public RequestScotlandAddressRequestBody Body;

    public RequestScotlandAddressRequest()
    {
    }

    public RequestScotlandAddressRequest(RequestScotlandAddressRequestBody Body) => this.Body = Body;
  }
}
