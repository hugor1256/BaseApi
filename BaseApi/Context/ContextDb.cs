using BaseApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseApi.Context;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> opts) :base(opts) { }

    public DbSet<Usuario> Usuario { get; set; }
}