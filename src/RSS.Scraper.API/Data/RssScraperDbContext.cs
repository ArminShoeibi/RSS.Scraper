using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RSS.Scraper.API.Entities;

namespace RSS.Scraper.API.Data;

public class RssScraperDbContext : IdentityDbContext<RssUser>
{
    public RssScraperDbContext(DbContextOptions<RssScraperDbContext> dbContextOptions)
        : base(dbContextOptions)
    {

    }
}
