// Copyright (c) 2024 alexanikiev.dev.

using MediatR;
using Serverless.CleanArchitecture.Core.Domain.Models;

namespace Serverless.CleanArchitecture.Core.Domain.DTO.Notifications
{
    /// <summary>
    /// Provides an acknowledgement of a request.
    /// </summary>
    public class Acknowledgement : NotificationBase, IRequest
    {
        /// <summary>
        /// Gets or sets the identifier of the request being acknowledged.
        /// </summary>
        public string RequestIdAcknowledged { get; set; }
    }
}