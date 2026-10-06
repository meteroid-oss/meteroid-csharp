// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Authoritative value type of a Config feature. <c>MAP</c>/<c>JSON</c> both carry a JSON value.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ConfigValueType>))]
public readonly partial record struct ConfigValueType(string Value) : IStringEnum<ConfigValueType>
{
    /// <summary><c>NUMBER</c></summary>
    public static ConfigValueType Number { get; } = new("NUMBER");

    /// <summary><c>BOOLEAN</c></summary>
    public static ConfigValueType Boolean { get; } = new("BOOLEAN");

    /// <summary><c>TEXT</c></summary>
    public static ConfigValueType Text { get; } = new("TEXT");

    /// <summary><c>MAP</c></summary>
    public static ConfigValueType Map { get; } = new("MAP");

    /// <summary><c>JSON</c></summary>
    public static ConfigValueType Json { get; } = new("JSON");

    /// <summary><c>SELECT</c></summary>
    public static ConfigValueType Select { get; } = new("SELECT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "NUMBER" or "BOOLEAN" or "TEXT" or "MAP" or "JSON" or "SELECT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>NUMBER</c></summary>
        public const string Number = "NUMBER";

        /// <summary><c>BOOLEAN</c></summary>
        public const string Boolean = "BOOLEAN";

        /// <summary><c>TEXT</c></summary>
        public const string Text = "TEXT";

        /// <summary><c>MAP</c></summary>
        public const string Map = "MAP";

        /// <summary><c>JSON</c></summary>
        public const string Json = "JSON";

        /// <summary><c>SELECT</c></summary>
        public const string Select = "SELECT";
    }

    static ConfigValueType IStringEnum<ConfigValueType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ConfigValueType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
