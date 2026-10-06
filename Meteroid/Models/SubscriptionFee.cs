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
[JsonConverter(typeof(SubscriptionFeeConverter))]
public abstract partial record SubscriptionFee
{
    private SubscriptionFee() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>RATE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Rate(RateFee Value) : SubscriptionFee
    {
        /// <inheritdoc/>
        public override string Type => "RATE";
    }

    /// <summary>The <c>ONE_TIME</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record OneTime(OneTimeFee Value) : SubscriptionFee
    {
        /// <inheritdoc/>
        public override string Type => "ONE_TIME";
    }

    /// <summary>The <c>RECURRING</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Recurring(RecurringFee Value) : SubscriptionFee
    {
        /// <inheritdoc/>
        public override string Type => "RECURRING";
    }

    /// <summary>The <c>CAPACITY</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Capacity(CapacityFee Value) : SubscriptionFee
    {
        /// <inheritdoc/>
        public override string Type => "CAPACITY";
    }

    /// <summary>The <c>SLOT</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Slot(SlotFee Value) : SubscriptionFee
    {
        /// <inheritdoc/>
        public override string Type => "SLOT";
    }

    /// <summary>The <c>USAGE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Usage(UsageFee Value) : SubscriptionFee
    {
        /// <inheritdoc/>
        public override string Type => "USAGE";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : SubscriptionFee
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

internal sealed class SubscriptionFeeConverter : JsonConverter<SubscriptionFee>
{
    public override SubscriptionFee Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "RATE" => new SubscriptionFee.Rate(Json.Deserialize<RateFee>(root, options)),
            "ONE_TIME" => new SubscriptionFee.OneTime(Json.Deserialize<OneTimeFee>(root, options)),
            "RECURRING" => new SubscriptionFee.Recurring(Json.Deserialize<RecurringFee>(root, options)),
            "CAPACITY" => new SubscriptionFee.Capacity(Json.Deserialize<CapacityFee>(root, options)),
            "SLOT" => new SubscriptionFee.Slot(Json.Deserialize<SlotFee>(root, options)),
            "USAGE" => new SubscriptionFee.Usage(Json.Deserialize<UsageFee>(root, options)),
            var tag => new SubscriptionFee.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, SubscriptionFee value, JsonSerializerOptions options)
    {
        if (value is SubscriptionFee.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case SubscriptionFee.Rate variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case SubscriptionFee.OneTime variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case SubscriptionFee.Recurring variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case SubscriptionFee.Capacity variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case SubscriptionFee.Slot variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case SubscriptionFee.Usage variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
