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
[JsonConverter(typeof(MetricSegmentationMatrixConverter))]
public abstract partial record MetricSegmentationMatrix
{
    private MetricSegmentationMatrix() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>SINGLE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Single(MetricDimension Value) : MetricSegmentationMatrix
    {
        /// <inheritdoc/>
        public override string Type => "SINGLE";
    }

    /// <summary>The <c>DOUBLE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Double(DoubleSegmentationMatrix Value) : MetricSegmentationMatrix
    {
        /// <inheritdoc/>
        public override string Type => "DOUBLE";
    }

    /// <summary>The <c>LINKED</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Linked(LinkedSegmentationMatrix Value) : MetricSegmentationMatrix
    {
        /// <inheritdoc/>
        public override string Type => "LINKED";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : MetricSegmentationMatrix
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

internal sealed class MetricSegmentationMatrixConverter : JsonConverter<MetricSegmentationMatrix>
{
    public override MetricSegmentationMatrix Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "SINGLE" => new MetricSegmentationMatrix.Single(Json.Deserialize<MetricDimension>(root, options)),
            "DOUBLE" => new MetricSegmentationMatrix.Double(Json.Deserialize<DoubleSegmentationMatrix>(root, options)),
            "LINKED" => new MetricSegmentationMatrix.Linked(Json.Deserialize<LinkedSegmentationMatrix>(root, options)),
            var tag => new MetricSegmentationMatrix.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, MetricSegmentationMatrix value, JsonSerializerOptions options)
    {
        if (value is MetricSegmentationMatrix.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case MetricSegmentationMatrix.Single variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case MetricSegmentationMatrix.Double variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case MetricSegmentationMatrix.Linked variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
