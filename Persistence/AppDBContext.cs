using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Activity> Activities { get; set; }
}
