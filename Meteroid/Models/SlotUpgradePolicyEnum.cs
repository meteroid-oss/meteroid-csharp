// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<SlotUpgradePolicyEnum>))]
public readonly partial record struct SlotUpgradePolicyEnum(string Value) : IStringEnum<SlotUpgradePolicyEnum>
{
    /// <summary><c>PRORATED</c></summary>
    public static SlotUpgradePolicyEnum Prorated { get; } = new("PRORATED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PRORATED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PRORATED</c></summary>
        public const string Prorated = "PRORATED";
    }

    static SlotUpgradePolicyEnum IStringEnum<SlotUpgradePolicyEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator SlotUpgradePolicyEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
