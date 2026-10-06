// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<SlotDowngradePolicyEnum>))]
public readonly partial record struct SlotDowngradePolicyEnum(string Value) : IStringEnum<SlotDowngradePolicyEnum>
{
    /// <summary><c>REMOVE_AT_END_OF_PERIOD</c></summary>
    public static SlotDowngradePolicyEnum RemoveAtEndOfPeriod { get; } = new("REMOVE_AT_END_OF_PERIOD");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "REMOVE_AT_END_OF_PERIOD";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>REMOVE_AT_END_OF_PERIOD</c></summary>
        public const string RemoveAtEndOfPeriod = "REMOVE_AT_END_OF_PERIOD";
    }

    static SlotDowngradePolicyEnum IStringEnum<SlotDowngradePolicyEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator SlotDowngradePolicyEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
