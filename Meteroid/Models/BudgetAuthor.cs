// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Who set the budget: you (TENANT) or the customer, from the portal (CUSTOMER).
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<BudgetAuthor>))]
public readonly partial record struct BudgetAuthor(string Value) : IStringEnum<BudgetAuthor>
{
    /// <summary><c>TENANT</c></summary>
    public static BudgetAuthor Tenant { get; } = new("TENANT");

    /// <summary><c>CUSTOMER</c></summary>
    public static BudgetAuthor Customer { get; } = new("CUSTOMER");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "TENANT" or "CUSTOMER";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>TENANT</c></summary>
        public const string Tenant = "TENANT";

        /// <summary><c>CUSTOMER</c></summary>
        public const string Customer = "CUSTOMER";
    }

    static BudgetAuthor IStringEnum<BudgetAuthor>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator BudgetAuthor(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
