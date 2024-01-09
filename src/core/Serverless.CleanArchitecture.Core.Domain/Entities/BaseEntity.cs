// Copyright (c) 2024 alexanikiev.dev.

namespace Serverless.CleanArchitecture.Core.Domain.Entities
{
    /// <summary>
    /// Abstract base entity.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets entity Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets entity Name.
        /// </summary>
        public string Name { get; set; }
    }
}