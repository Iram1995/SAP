﻿
// Type: SAP2012.SAPRef.HomeInspectorDetailsResponseBody




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
  public class HomeInspectorDetailsResponseBody
  {
    [DataMember(EmitDefaultValue = false, Order = 0)]
    public string HomeInspectorDetailsResult;

    public HomeInspectorDetailsResponseBody()
    {
    }

    public HomeInspectorDetailsResponseBody(string HomeInspectorDetailsResult) => this.HomeInspectorDetailsResult = HomeInspectorDetailsResult;
  }
}
