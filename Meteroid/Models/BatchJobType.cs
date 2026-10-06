// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<BatchJobType>))]
public readonly partial record struct BatchJobType(string Value) : IStringEnum<BatchJobType>
{
    /// <summary><c>EVENT_CSV_IMPORT</c></summary>
    public static BatchJobType EventCsvImport { get; } = new("EVENT_CSV_IMPORT");

    /// <summary><c>CUSTOMER_CSV_IMPORT</c></summary>
    public static BatchJobType CustomerCsvImport { get; } = new("CUSTOMER_CSV_IMPORT");

    /// <summary><c>SUBSCRIPTION_CSV_IMPORT</c></summary>
    public static BatchJobType SubscriptionCsvImport { get; } = new("SUBSCRIPTION_CSV_IMPORT");

    /// <summary><c>SUBSCRIPTION_PLAN_MIGRATION</c></summary>
    public static BatchJobType SubscriptionPlanMigration { get; } = new("SUBSCRIPTION_PLAN_MIGRATION");

    /// <summary><c>TAX_REPORT_EXPORT</c></summary>
    public static BatchJobType TaxReportExport { get; } = new("TAX_REPORT_EXPORT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "EVENT_CSV_IMPORT"
                or "CUSTOMER_CSV_IMPORT"
                or "SUBSCRIPTION_CSV_IMPORT"
                or "SUBSCRIPTION_PLAN_MIGRATION"
                or "TAX_REPORT_EXPORT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>EVENT_CSV_IMPORT</c></summary>
        public const string EventCsvImport = "EVENT_CSV_IMPORT";

        /// <summary><c>CUSTOMER_CSV_IMPORT</c></summary>
        public const string CustomerCsvImport = "CUSTOMER_CSV_IMPORT";

        /// <summary><c>SUBSCRIPTION_CSV_IMPORT</c></summary>
        public const string SubscriptionCsvImport = "SUBSCRIPTION_CSV_IMPORT";

        /// <summary><c>SUBSCRIPTION_PLAN_MIGRATION</c></summary>
        public const string SubscriptionPlanMigration = "SUBSCRIPTION_PLAN_MIGRATION";

        /// <summary><c>TAX_REPORT_EXPORT</c></summary>
        public const string TaxReportExport = "TAX_REPORT_EXPORT";
    }

    static BatchJobType IStringEnum<BatchJobType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator BatchJobType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
