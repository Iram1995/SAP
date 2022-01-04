
// Type: SAP2012.ImportsArea.PSI




using System.Collections.Generic;

namespace SAP2012.ImportsArea
{
  public class PSI
  {
    public PSI()
    {
      this.Elements = new List<string>();
      this.Length = new List<string>();
      this.Value = new List<string>();
    }

    public List<string> Elements { get; set; }

    public List<string> Length { get; set; }

    public List<string> Value { get; set; }
  }
}
