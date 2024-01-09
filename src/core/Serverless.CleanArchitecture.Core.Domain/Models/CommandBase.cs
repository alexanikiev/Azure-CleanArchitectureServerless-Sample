// Copyright (c) 2024 alexanikiev.dev.

using System.Diagnostics.CodeAnalysis;

namespace Serverless.CleanArchitecture.Core.Domain.Models
{
    /// <summary>
    /// CommandBase.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class CommandBase
    {
        /// <summary>
        /// Gets or sets the identifier of the request.
        /// </summary>
        public string Id { get; set; }
    }
}
