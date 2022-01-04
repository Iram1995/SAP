﻿
// Type: SAP2012.SAPRef.ValidateUserResponse




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
  public class ValidateUserResponse
  {
    [MessageBodyMember(Name = "ValidateUserResponse", Namespace = "https://www.stromamembers.co.uk/sap.asmx", Order = 0)]
    public ValidateUserResponseBody Body;

    public ValidateUserResponse()
    {
    }

    public ValidateUserResponse(ValidateUserResponseBody Body) => this.Body = Body;
  }
}