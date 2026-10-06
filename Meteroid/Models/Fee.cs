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
[JsonConverter(typeof(FeeConverter))]
public abstract partial record Fee
{
    private Fee() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>RATE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Rate(RatePlanFee Value) : Fee
    {
        /// <inheritdoc/>
        public override string Type => "RATE";
    }

    /// <summary>The <c>SLOT</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Slot(SlotPlanFee Value) : Fee
    {
        /// <inheritdoc/>
        public override string Type => "SLOT";
    }

    /// <summary>The <c>CAPACITY</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Capacity(CapacityPlanFee Value) : Fee
    {
        /// <inheritdoc/>
        public override string Type => "CAPACITY";
    }

    /// <summary>The <c>USAGE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Usage(UsagePlanFee Value) : Fee
    {
        /// <inheritdoc/>
        public override string Type => "USAGE";
    }

    /// <summary>The <c>EXTRA_RECURRING</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record ExtraRecurring(ExtraRecurringPlanFee Value) : Fee
    {
        /// <inheritdoc/>
        public override string Type => "EXTRA_RECURRING";
    }

    /// <summary>The <c>ONE_TIME</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record OneTime(OneTimePlanFee Value) : Fee
    {
        /// <inheritdoc/>
        public override string Type => "ONE_TIME";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : Fee
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

internal sealed class FeeConverter : JsonConverter<Fee>
{
    public override Fee Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "RATE" => new Fee.Rate(Json.Deserialize<RatePlanFee>(root, options)),
            "SLOT" => new Fee.Slot(Json.Deserialize<SlotPlanFee>(root, options)),
            "CAPACITY" => new Fee.Capacity(Json.Deserialize<CapacityPlanFee>(root, options)),
            "USAGE" => new Fee.Usage(Json.Deserialize<UsagePlanFee>(root, options)),
            "EXTRA_RECURRING" => new Fee.ExtraRecurring(Json.Deserialize<ExtraRecurringPlanFee>(root, options)),
            "ONE_TIME" => new Fee.OneTime(Json.Deserialize<OneTimePlanFee>(root, options)),
            var tag => new Fee.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, Fee value, JsonSerializerOptions options)
    {
        if (value is Fee.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case Fee.Rate variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case Fee.Slot variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case Fee.Capacity variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case Fee.Usage variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case Fee.ExtraRecurring variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case Fee.OneTime variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
