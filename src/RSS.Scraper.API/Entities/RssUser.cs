using Microsoft.AspNetCore.Identity;

namespace RSS.Scraper.API.Entities;

public class RssUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
