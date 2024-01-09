// Copyright (c) 2024 alexanikiev.dev.

namespace Serverless.CleanArchitecture.Core.Domain.Entities
{
    /// <summary>
    /// Abstract base entity.
    /// </summary>
    public class MyTrans
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets MyId.
        /// </summary>
        public string MyId { get; set; }

        /// <summary>
        /// Gets or sets Comment.
        /// </summary>
        public string Comment { get; set; }
    }
}