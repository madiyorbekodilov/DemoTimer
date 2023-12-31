﻿using DemoTimer.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoTimer.Api.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {   }
    public DbSet<OldTime> oldTime { get; set; }
}