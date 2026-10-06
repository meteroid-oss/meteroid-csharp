// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CustomPropertyType>))]
public readonly partial record struct CustomPropertyType(string Value) : IStringEnum<CustomPropertyType>
{
    /// <summary><c>TEXT</c></summary>
    public static CustomPropertyType Text { get; } = new("TEXT");

    /// <summary><c>NUMBER</c></summary>
    public static CustomPropertyType Number { get; } = new("NUMBER");

    /// <summary><c>BOOLEAN</c></summary>
    public static CustomPropertyType Boolean { get; } = new("BOOLEAN");

    /// <summary><c>DATE</c></summary>
    public static CustomPropertyType Date { get; } = new("DATE");

    /// <summary><c>DATETIME</c></summary>
    public static CustomPropertyType Datetime { get; } = new("DATETIME");

    /// <summary><c>SINGLE_SELECT</c></summary>
    public static CustomPropertyType SingleSelect { get; } = new("SINGLE_SELECT");

    /// <summary><c>MULTI_SELECT</c></summary>
    public static CustomPropertyType MultiSelect { get; } = new("MULTI_SELECT");

    /// <summary><c>JSON</c></summary>
    public static CustomPropertyType Json { get; } = new("JSON");

    /// <summary><c>URL</c></summary>
    public static CustomPropertyType Url { get; } = new("URL");

    /// <summary><c>EMAIL</c></summary>
    public static CustomPropertyType Email { get; } = new("EMAIL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "TEXT"
                or "NUMBER"
                or "BOOLEAN"
                or "DATE"
                or "DATETIME"
                or "SINGLE_SELECT"
                or "MULTI_SELECT"
                or "JSON"
                or "URL"
                or "EMAIL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>TEXT</c></summary>
        public const string Text = "TEXT";

        /// <summary><c>NUMBER</c></summary>
        public const string Number = "NUMBER";

        /// <summary><c>BOOLEAN</c></summary>
        public const string Boolean = "BOOLEAN";

        /// <summary><c>DATE</c></summary>
        public const string Date = "DATE";

        /// <summary><c>DATETIME</c></summary>
        public const string Datetime = "DATETIME";

        /// <summary><c>SINGLE_SELECT</c></summary>
        public const string SingleSelect = "SINGLE_SELECT";

        /// <summary><c>MULTI_SELECT</c></summary>
        public const string MultiSelect = "MULTI_SELECT";

        /// <summary><c>JSON</c></summary>
        public const string Json = "JSON";

        /// <summary><c>URL</c></summary>
        public const string Url = "URL";

        /// <summary><c>EMAIL</c></summary>
        public const string Email = "EMAIL";
    }

    static CustomPropertyType IStringEnum<CustomPropertyType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CustomPropertyType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
