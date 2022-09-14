using Microsoft.AspNetCore.Identity;

namespace RSS.Scraper.API.Entities;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
