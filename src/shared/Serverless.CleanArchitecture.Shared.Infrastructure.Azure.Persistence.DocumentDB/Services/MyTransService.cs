// Copyright (c) 2024 alexanikiev.dev.

using Microsoft.EntityFrameworkCore;
using Serverless.CleanArchitecture.Core.Application.Services.Persistence;
using Serverless.CleanArchitecture.Core.Domain.Entities;

namespace Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Persistence.DocumentDB.Services
{
    public class MyTransService : IMyTransService
    {
        private readonly PersistenceDbContext _context;

        public MyTransService(PersistenceDbContext context)
        {
            _context = context;
        }

        public async Task<MyTrans> ReadMyTransAsync(string id)
        {
            return await _context.MyTrans.FindAsync(id);
        }

        public async Task<List<MyTrans>> ReadAllMyTransAsync()
        {
            return await _context.MyTrans.ToListAsync();
        }

        public async Task AddMyTransAsync(MyTrans myTrans)
        {
            _context.MyTrans.Add(myTrans);
            await _context.SaveChangesAsync();
        }

        public async Task AddMyTransArrayAsync(MyTrans[] myTransArray)
        {
            _context.MyTrans.AddRange(myTransArray);
            await _context.SaveChangesAsync();
        }
    }
}