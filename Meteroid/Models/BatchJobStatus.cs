// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<BatchJobStatus>))]
public readonly partial record struct BatchJobStatus(string Value) : IStringEnum<BatchJobStatus>
{
    /// <summary><c>PENDING</c></summary>
    public static BatchJobStatus Pending { get; } = new("PENDING");

    /// <summary><c>CHUNKING</c></summary>
    public static BatchJobStatus Chunking { get; } = new("CHUNKING");

    /// <summary><c>PROCESSING</c></summary>
    public static BatchJobStatus Processing { get; } = new("PROCESSING");

    /// <summary><c>COMPLETED</c></summary>
    public static BatchJobStatus Completed { get; } = new("COMPLETED");

    /// <summary><c>COMPLETED_WITH_ERRORS</c></summary>
    public static BatchJobStatus CompletedWithErrors { get; } = new("COMPLETED_WITH_ERRORS");

    /// <summary><c>FAILED</c></summary>
    public static BatchJobStatus Failed { get; } = new("FAILED");

    /// <summary><c>CANCELLED</c></summary>
    public static BatchJobStatus Cancelled { get; } = new("CANCELLED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "PENDING"
                or "CHUNKING"
                or "PROCESSING"
                or "COMPLETED"
                or "COMPLETED_WITH_ERRORS"
                or "FAILED"
                or "CANCELLED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PENDING</c></summary>
        public const string Pending = "PENDING";

        /// <summary><c>CHUNKING</c></summary>
        public const string Chunking = "CHUNKING";

        /// <summary><c>PROCESSING</c></summary>
        public const string Processing = "PROCESSING";

        /// <summary><c>COMPLETED</c></summary>
        public const string Completed = "COMPLETED";

        /// <summary><c>COMPLETED_WITH_ERRORS</c></summary>
        public const string CompletedWithErrors = "COMPLETED_WITH_ERRORS";

        /// <summary><c>FAILED</c></summary>
        public const string Failed = "FAILED";

        /// <summary><c>CANCELLED</c></summary>
        public const string Cancelled = "CANCELLED";
    }

    static BatchJobStatus IStringEnum<BatchJobStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator BatchJobStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
