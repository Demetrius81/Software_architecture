using CloudService.Model;
using Microsoft.EntityFrameworkCore;

namespace CloudService.DAL.Context;
public class CloudServiceDb : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Cloud> Clouds { get; set; }
    public DbSet<IpAddress> IpAddresses { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<ServerPool> ServerPools { get; set; }

    public CloudServiceDb(DbContextOptions<CloudServiceDb> options) : base(options)
    {

    }
}
