// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <remarks>
/// Match on the nested variant records. <see cref="Unrecognized"/> holds variants added to the API
/// after this SDK version, as raw JSON.
/// </remarks>
[JsonConverter(typeof(ResetPeriodConverter))]
public abstract partial record ResetPeriod
{
    private ResetPeriod() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>BILLING_CYCLE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record BillingCycle(BillingCycleResetPeriod Value) : ResetPeriod
    {
        /// <inheritdoc/>
        public override string Type => "BILLING_CYCLE";
    }

    /// <summary>The <c>CALENDAR</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Calendar(CalendarResetPeriod Value) : ResetPeriod
    {
        /// <inheritdoc/>
        public override string Type => "CALENDAR";
    }

    /// <summary>The <c>FIXED_WINDOW</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record FixedWindow(FixedWindowResetPeriod Value) : ResetPeriod
    {
        /// <inheritdoc/>
        public override string Type => "FIXED_WINDOW";
    }

    /// <summary>The <c>SLIDING_WINDOW</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record SlidingWindow(SlidingWindowResetPeriod Value) : ResetPeriod
    {
        /// <inheritdoc/>
        public override string Type => "SLIDING_WINDOW";
    }

    /// <summary>The <c>NEVER</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Never(NeverResetPeriod Value) : ResetPeriod
    {
        /// <inheritdoc/>
        public override string Type => "NEVER";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : ResetPeriod
    {
        /// <inheritdoc/>
        public override string Type => Tag;

        /// <inheritdoc/>
        public bool Equals(Unrecognized? other) =>
            other is not null
            && base.Equals(other)
            && Tag == other.Tag
            && global::Meteroid.Equality.Equal(Raw, other.Raw);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Tag);
    }
}

internal sealed class ResetPeriodConverter : JsonConverter<ResetPeriod>
{
    public override ResetPeriod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "BILLING_CYCLE" => new ResetPeriod.BillingCycle(Json.Deserialize<BillingCycleResetPeriod>(root, options)),
            "CALENDAR" => new ResetPeriod.Calendar(Json.Deserialize<CalendarResetPeriod>(root, options)),
            "FIXED_WINDOW" => new ResetPeriod.FixedWindow(Json.Deserialize<FixedWindowResetPeriod>(root, options)),
            "SLIDING_WINDOW" => new ResetPeriod.SlidingWindow(
                Json.Deserialize<SlidingWindowResetPeriod>(root, options)
            ),
            "NEVER" => new ResetPeriod.Never(Json.Deserialize<NeverResetPeriod>(root, options)),
            var tag => new ResetPeriod.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, ResetPeriod value, JsonSerializerOptions options)
    {
        if (value is ResetPeriod.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case ResetPeriod.BillingCycle variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ResetPeriod.Calendar variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ResetPeriod.FixedWindow variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ResetPeriod.SlidingWindow variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ResetPeriod.Never variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
