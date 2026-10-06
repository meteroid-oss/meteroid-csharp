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
[JsonConverter(typeof(ProductFeeStructureConverter))]
public abstract partial record ProductFeeStructure
{
    private ProductFeeStructure() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>RATE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Rate(RateFeeStructure Value) : ProductFeeStructure
    {
        /// <inheritdoc/>
        public override string Type => "RATE";
    }

    /// <summary>The <c>SLOT</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Slot(SlotFeeStructure Value) : ProductFeeStructure
    {
        /// <inheritdoc/>
        public override string Type => "SLOT";
    }

    /// <summary>The <c>CAPACITY</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Capacity(CapacityFeeStructure Value) : ProductFeeStructure
    {
        /// <inheritdoc/>
        public override string Type => "CAPACITY";
    }

    /// <summary>The <c>USAGE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Usage(UsageFeeStructure Value) : ProductFeeStructure
    {
        /// <inheritdoc/>
        public override string Type => "USAGE";
    }

    /// <summary>The <c>EXTRA_RECURRING</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record ExtraRecurring(ExtraRecurringFeeStructure Value) : ProductFeeStructure
    {
        /// <inheritdoc/>
        public override string Type => "EXTRA_RECURRING";
    }

    /// <summary>The <c>ONE_TIME</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record OneTime(OneTimeFeeStructure Value) : ProductFeeStructure
    {
        /// <inheritdoc/>
        public override string Type => "ONE_TIME";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : ProductFeeStructure
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

internal sealed class ProductFeeStructureConverter : JsonConverter<ProductFeeStructure>
{
    public override ProductFeeStructure Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "RATE" => new ProductFeeStructure.Rate(Json.Deserialize<RateFeeStructure>(root, options)),
            "SLOT" => new ProductFeeStructure.Slot(Json.Deserialize<SlotFeeStructure>(root, options)),
            "CAPACITY" => new ProductFeeStructure.Capacity(Json.Deserialize<CapacityFeeStructure>(root, options)),
            "USAGE" => new ProductFeeStructure.Usage(Json.Deserialize<UsageFeeStructure>(root, options)),
            "EXTRA_RECURRING" => new ProductFeeStructure.ExtraRecurring(
                Json.Deserialize<ExtraRecurringFeeStructure>(root, options)
            ),
            "ONE_TIME" => new ProductFeeStructure.OneTime(Json.Deserialize<OneTimeFeeStructure>(root, options)),
            var tag => new ProductFeeStructure.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, ProductFeeStructure value, JsonSerializerOptions options)
    {
        if (value is ProductFeeStructure.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case ProductFeeStructure.Rate variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ProductFeeStructure.Slot variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ProductFeeStructure.Capacity variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ProductFeeStructure.Usage variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ProductFeeStructure.ExtraRecurring variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ProductFeeStructure.OneTime variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
