// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// What reaching the amount does. A SOFT budget only sends alerts; a HARD budget also makes the
/// entitlement check answer BUDGET_EXCEEDED for the features whose usage counts in its spend. A
/// HARD budget on one subscription refuses the checks naming that subscription, and the checks
/// naming none once every subscription charging the feature's metric is refused by its own.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<BudgetBehavior>))]
public readonly partial record struct BudgetBehavior(string Value) : IStringEnum<BudgetBehavior>
{
    /// <summary><c>SOFT</c></summary>
    public static BudgetBehavior Soft { get; } = new("SOFT");

    /// <summary><c>HARD</c></summary>
    public static BudgetBehavior Hard { get; } = new("HARD");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "SOFT" or "HARD";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>SOFT</c></summary>
        public const string Soft = "SOFT";

        /// <summary><c>HARD</c></summary>
        public const string Hard = "HARD";
    }

    static BudgetBehavior IStringEnum<BudgetBehavior>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator BudgetBehavior(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
