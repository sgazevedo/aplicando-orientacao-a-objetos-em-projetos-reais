using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
  public class Utm
  {
    /// <summary>
    /// Generate a new Utm.
    /// </summary>
    /// <param name="url"></param>
    /// <param name="campaign"></param>
    public Utm(Url url, Campaign campaign)
    {
      Url = url;
      Campaign = campaign;
    }

    /// <summary>
    /// URL (Website Link)
    /// </summary>
    public Url Url { get; set; }

    /// <summary>
    /// Campaign Details
    /// </summary>
    public Campaign Campaign { get; set; }
  }
}
