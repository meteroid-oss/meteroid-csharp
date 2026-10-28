// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="CreditsWalletsApi.CheckAsync"/>.</summary>
public sealed record CreditsWalletsCheckOptions
{
    /// <summary>
    /// Defaults to the customer's currency.
    /// </summary>
    public Currency? Currency { get; init; }

    /// <summary>
    /// Checks the wallet of this credit unit (its code) instead of a currency.
    /// </summary>
    public string? CreditUnit { get; init; }

    /// <summary>
    /// Checks only the credit that can pay for this product: credit not restricted to products,
    /// and credit restricted to it. Absent checks all credit.
    /// </summary>
    public string? ProductId { get; init; }

    /// <summary>
    /// Checks only the credit this subscription (<c>sub_…</c>) can spend, net of its own usage no
    /// credit pays: the credit that belongs to it and the customer's credit that belongs to no
    /// subscription, once every subscription's unbilled usage is paid. <c>has_access</c> is then the
    /// decision the access gate makes for that subscription's usage. Absent checks the
    /// customer's credit as a whole.
    /// </summary>
    public string? SubscriptionId { get; init; }
}
