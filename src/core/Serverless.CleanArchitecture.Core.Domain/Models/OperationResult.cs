// Copyright (c) 2024 alexanikiev.dev.

using System.Diagnostics.CodeAnalysis;

namespace Serverless.CleanArchitecture.Core.Domain.Models
{
    /// <summary>
    /// OperationResult.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class OperationResult
    {
        /// <summary>
        /// Gets or sets the detail of the operation.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets the detail type of the operation.
        /// </summary>
        public string DetailType { get; set; }
    }
}