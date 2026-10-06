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
[JsonConverter(typeof(PriceEntryConverter))]
public abstract partial record PriceEntry
{
    private PriceEntry() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>EXISTING</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Existing(ExistingPriceRef Value) : PriceEntry
    {
        /// <inheritdoc/>
        public override string Type => "EXISTING";
    }

    /// <summary>The <c>NEW</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record New(PriceInput Value) : PriceEntry
    {
        /// <inheritdoc/>
        public override string Type => "NEW";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : PriceEntry
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

internal sealed class PriceEntryConverter : JsonConverter<PriceEntry>
{
    public override PriceEntry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "EXISTING" => new PriceEntry.Existing(Json.Deserialize<ExistingPriceRef>(root, options)),
            "NEW" => new PriceEntry.New(Json.Deserialize<PriceInput>(root, options)),
            var tag => new PriceEntry.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, PriceEntry value, JsonSerializerOptions options)
    {
        if (value is PriceEntry.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case PriceEntry.Existing variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PriceEntry.New variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
