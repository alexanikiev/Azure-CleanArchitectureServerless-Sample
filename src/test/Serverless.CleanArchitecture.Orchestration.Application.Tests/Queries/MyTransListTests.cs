// Copyright (c) 2024 alexanikiev.dev.

using Microsoft.EntityFrameworkCore;
using Moq;
using Serverless.CleanArchitecture.Core.Domain.Entities;
using Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Persistence.DocumentDB.Services;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Assert = Xunit.Assert;

namespace Serverless.CleanArchitecture.Orchestration.Application.Tests.Queries
{
    [ExcludeFromCodeCoverage]
    public class MyTransServiceTests
    {
        private readonly Mock<PersistenceDbContext> mockContext;
        private readonly MyTransService myTransService;
        private readonly Mock<DbSet<MyTrans>> mockDbSet;

        public MyTransServiceTests()
        {
            this.mockContext = new Mock<PersistenceDbContext>();
            this.mockDbSet = GetQueryableMockDbSet(new List<MyTrans>
            {
                new MyTrans { Id = "testId1" },
                new MyTrans { Id = "testId2" },
                new MyTrans { Id = "testId3" },
            });

            this.mockContext.Setup(c => c.MyTrans).Returns(mockDbSet.Object);
            this.myTransService = new MyTransService(mockContext.Object);

            // TODO:
            this.mockDbSet.Setup(m => m.FindAsync(It.IsAny<string>())).Returns(new ValueTask<MyTrans>(mockDbSet.Object.First()));
        }

        private static Mock<DbSet<T>> GetQueryableMockDbSet<T>(List<T> sourceList)
            where T : class
        {
            var queryable = sourceList.AsQueryable();
            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            //dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbSet.As<IAsyncEnumerable<T>>().Setup(m => m.GetAsyncEnumerator(new CancellationToken())).Returns(new TestAsyncEnumerator<T>(sourceList.GetEnumerator()));
            return dbSet;
        }

        [Fact]
        public async Task ReadMyTransAsync()
        {
            // Arrange
            string id = "testId1";

            // Act
            MyTrans result = await this.myTransService.ReadMyTransAsync(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
        }

        [Fact]
        public async Task ReadAllMyTransAsync()
        {
            // Arrange

            // Act
            List<MyTrans> result = await this.myTransService.ReadAllMyTransAsync();

            // Assert
            Assert.NotNull(result);
            var resultList = result.ToList();
            Assert.Equal(3, resultList.Count);
        }
    }
}