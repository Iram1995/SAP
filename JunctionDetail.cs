
// Type: SAP2012.JunctionDetail




namespace SAP2012
{
  public class JunctionDetail
  {
    public string Ref { get; set; }

    public string Detail { get; set; }

    public float Approved { get; set; }

    public float DefaultValue { get; set; }

    public JunctionDetail.JunctionType JuncType { get; set; }

    public bool ImportLenght { get; set; }

    public enum JunctionType
    {
      ExternalWall,
      PartyWall,
      Roof,
    }
  }
}
