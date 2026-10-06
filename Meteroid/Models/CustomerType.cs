// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Company vs. individual (B2C). Defaults to <c>COMPANY</c>.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CustomerType>))]
public readonly partial record struct CustomerType(string Value) : IStringEnum<CustomerType>
{
    /// <summary><c>COMPANY</c></summary>
    public static CustomerType Company { get; } = new("COMPANY");

    /// <summary><c>INDIVIDUAL</c></summary>
    public static CustomerType Individual { get; } = new("INDIVIDUAL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "COMPANY" or "INDIVIDUAL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>COMPANY</c></summary>
        public const string Company = "COMPANY";

        /// <summary><c>INDIVIDUAL</c></summary>
        public const string Individual = "INDIVIDUAL";
    }

    static CustomerType IStringEnum<CustomerType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CustomerType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
