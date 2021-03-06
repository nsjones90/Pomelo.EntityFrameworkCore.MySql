// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

//ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore.Metadata
{
    public enum MySqlValueGenerationStrategy
    {
        None,
        IdentityColumn,
        ComputedColumn // TODO: Remove this and only use .HasComputedColumnSql() instead in EF Core 5
    }
}
