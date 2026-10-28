// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<EntitlementCheckReason>))]
public readonly partial record struct EntitlementCheckReason(string Value) : IStringEnum<EntitlementCheckReason>
{
    /// <summary><c>WITHIN_LIMIT</c></summary>
    public static EntitlementCheckReason WithinLimit { get; } = new("WITHIN_LIMIT");

    /// <summary><c>LIMIT_REACHED</c></summary>
    public static EntitlementCheckReason LimitReached { get; } = new("LIMIT_REACHED");

    /// <summary><c>NO_ENTITLEMENT</c></summary>
    public static EntitlementCheckReason NoEntitlement { get; } = new("NO_ENTITLEMENT");

    /// <summary><c>DISABLED</c></summary>
    public static EntitlementCheckReason Disabled { get; } = new("DISABLED");

    /// <summary><c>BUDGET_EXCEEDED</c></summary>
    public static EntitlementCheckReason BudgetExceeded { get; } = new("BUDGET_EXCEEDED");

    /// <summary><c>INSUFFICIENT_BALANCE</c></summary>
    public static EntitlementCheckReason InsufficientBalance { get; } = new("INSUFFICIENT_BALANCE");

    /// <summary><c>TOO_MANY_GROUPS</c></summary>
    public static EntitlementCheckReason TooManyGroups { get; } = new("TOO_MANY_GROUPS");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "WITHIN_LIMIT"
                or "LIMIT_REACHED"
                or "NO_ENTITLEMENT"
                or "DISABLED"
                or "BUDGET_EXCEEDED"
                or "INSUFFICIENT_BALANCE"
                or "TOO_MANY_GROUPS";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>WITHIN_LIMIT</c></summary>
        public const string WithinLimit = "WITHIN_LIMIT";

        /// <summary><c>LIMIT_REACHED</c></summary>
        public const string LimitReached = "LIMIT_REACHED";

        /// <summary><c>NO_ENTITLEMENT</c></summary>
        public const string NoEntitlement = "NO_ENTITLEMENT";

        /// <summary><c>DISABLED</c></summary>
        public const string Disabled = "DISABLED";

        /// <summary><c>BUDGET_EXCEEDED</c></summary>
        public const string BudgetExceeded = "BUDGET_EXCEEDED";

        /// <summary><c>INSUFFICIENT_BALANCE</c></summary>
        public const string InsufficientBalance = "INSUFFICIENT_BALANCE";

        /// <summary><c>TOO_MANY_GROUPS</c></summary>
        public const string TooManyGroups = "TOO_MANY_GROUPS";
    }

    static EntitlementCheckReason IStringEnum<EntitlementCheckReason>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator EntitlementCheckReason(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
