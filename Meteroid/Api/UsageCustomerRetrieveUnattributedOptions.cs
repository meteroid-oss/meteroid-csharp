// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="UsageCustomerApi.RetrieveUnattributedAsync"/>.</summary>
public sealed record UsageCustomerRetrieveUnattributedOptions
{
    /// <summary>
    /// First day of the range. Defaults to the first day of the current month (UTC).
    /// </summary>
    public DateOnly? StartDate { get; init; }

    /// <summary>
    /// Day after the range (exclusive). Defaults to the first day of the next month.
    /// </summary>
    public DateOnly? EndDate { get; init; }
}
