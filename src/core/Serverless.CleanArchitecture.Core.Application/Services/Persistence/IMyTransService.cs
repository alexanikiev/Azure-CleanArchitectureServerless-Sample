// Copyright (c) 2024 alexanikiev.dev.

using Serverless.CleanArchitecture.Core.Domain.Entities;

namespace Serverless.CleanArchitecture.Core.Application.Services.Persistence
{
    public interface IMyTransService
    {
        /// <summary>
        /// Gets a MyTrans.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<MyTrans> ReadMyTransAsync(string id);

        /// <summary>
        /// Gets all MyTrans.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<List<MyTrans>> ReadAllMyTransAsync();

        /// <summary>
        /// Adds a MyTrans.
        /// </summary>
        /// <param name="myTrans"></param>
        /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
        Task AddMyTransAsync(MyTrans myTrans);

        /// <summary>
        /// Adds a MyTrans array.
        /// </summary>
        /// <param name="myTransArray"></param>
        /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
        Task AddMyTransArrayAsync(MyTrans[] myTransArray);
    }
}
