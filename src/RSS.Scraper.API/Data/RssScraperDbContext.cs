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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
