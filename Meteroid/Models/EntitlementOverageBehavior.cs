// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// What happens once usage reaches the limit.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<EntitlementOverageBehavior>))]
public readonly partial record struct EntitlementOverageBehavior(string Value) : IStringEnum<EntitlementOverageBehavior>
{
    /// <summary><c>BLOCK</c></summary>
    public static EntitlementOverageBehavior Block { get; } = new("BLOCK");

    /// <summary><c>ALLOW</c></summary>
    public static EntitlementOverageBehavior Allow { get; } = new("ALLOW");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "BLOCK" or "ALLOW";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>BLOCK</c></summary>
        public const string Block = "BLOCK";

        /// <summary><c>ALLOW</c></summary>
        public const string Allow = "ALLOW";
    }

    static EntitlementOverageBehavior IStringEnum<EntitlementOverageBehavior>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator EntitlementOverageBehavior(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
