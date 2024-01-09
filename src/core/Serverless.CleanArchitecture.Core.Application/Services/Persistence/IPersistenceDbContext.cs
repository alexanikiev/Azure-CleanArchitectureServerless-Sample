// Copyright (c) 2024 alexanikiev.dev.

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serverless.CleanArchitecture.Core.Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Numerics;

namespace Serverless.CleanArchitecture.Core.Application.Services
{
    /// <summary>
    /// Exposes interface of the relational persistance implementation.
    /// </summary>
    public interface IPersistenceDbContext
    {
        /// <summary>
        /// Gets or sets a MyTrans.
        /// </summary>
        DbSet<MyTrans> MyTrans { get; set; }

        /// <summary>
        /// Calls <see cref="Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(System.Threading.CancellationToken)"/>.
        /// </summary>
        /// <returns>A task that represents the asynchronous save operation. The task result contains the number of state entries written to the database.</returns>
        Task<int> SaveChangesAsync();
    }
}