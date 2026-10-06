// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Type of connection between platform and connected account
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ConnectionType>))]
public readonly partial record struct ConnectionType(string Value) : IStringEnum<ConnectionType>
{
    /// <summary><c>standard</c></summary>
    public static ConnectionType Standard { get; } = new("standard");

    /// <summary><c>express</c></summary>
    public static ConnectionType Express { get; } = new("express");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "standard" or "express";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>standard</c></summary>
        public const string Standard = "standard";

        /// <summary><c>express</c></summary>
        public const string Express = "express";
    }

    static ConnectionType IStringEnum<ConnectionType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ConnectionType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
