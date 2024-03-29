﻿using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Absatractions
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
