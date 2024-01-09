// Copyright (c) 2024 alexanikiev.dev.

using System.Diagnostics.CodeAnalysis;

namespace Serverless.CleanArchitecture.Core.Domain.Models
{
    /// <summary>
    /// QueryBase.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class QueryBase
    {
        /// <summary>
        /// Gets or sets the identifier of the request.
        /// </summary>
        public int Id { get; set; }
    }
}