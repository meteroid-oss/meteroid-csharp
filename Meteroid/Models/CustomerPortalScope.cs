// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// What a customer portal token may do.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CustomerPortalScope>))]
public readonly partial record struct CustomerPortalScope(string Value) : IStringEnum<CustomerPortalScope>
{
    /// <summary><c>read</c></summary>
    public static CustomerPortalScope Read { get; } = new("read");

    /// <summary><c>manage</c></summary>
    public static CustomerPortalScope Manage { get; } = new("manage");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "read" or "manage";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>read</c></summary>
        public const string Read = "read";

        /// <summary><c>manage</c></summary>
        public const string Manage = "manage";
    }

    static CustomerPortalScope IStringEnum<CustomerPortalScope>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CustomerPortalScope(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
