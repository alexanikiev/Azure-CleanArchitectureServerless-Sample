// Copyright (c) 2024 alexanikiev.dev.

using System.Threading.Tasks;
using Serverless.CleanArchitecture.Core.Domain.Models;

namespace Serverless.CleanArchitecture.Core.Application.Services
{
    /// <summary>
    /// Provides notification delivery.
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Publishes a notification.
        /// </summary>
        /// <param name="notification">notification.</param>
        /// <returns>RequestResult.</returns>
        Task<OperationResult> PublishNotificationAsync(NotificationBase notification);
    }
}
