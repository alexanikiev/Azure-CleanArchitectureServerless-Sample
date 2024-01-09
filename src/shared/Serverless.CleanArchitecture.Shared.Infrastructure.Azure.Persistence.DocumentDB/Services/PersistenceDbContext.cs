// Copyright (c) 2024 alexanikiev.dev.

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serverless.CleanArchitecture.Core.Application.Services;
using Serverless.CleanArchitecture.Core.Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Persistence.DocumentDB.Services
{
    /// <summary>
    /// Implements interface for relational persistance.
    /// </summary>
    public class PersistenceDbContext : DbContext, IPersistenceDbContext // TODO: Split reader/writer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersistenceDbContext"/> class.
        /// </summary>
        /// <param name="options">IDbContextOptionsExtension.</param>
        public PersistenceDbContext(DbContextOptions<PersistenceDbContext> options)
            : base(options)
        {
        }

        public PersistenceDbContext()
        {
        }

        /// <inheritdoc/>
        public DbSet<MyTrans> MyTrans { get; set; }

        /// <inheritdoc/>
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
