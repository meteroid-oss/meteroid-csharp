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
[JsonConverter(typeof(PlanUsagePricingModelConverter))]
public abstract partial record PlanUsagePricingModel
{
    private PlanUsagePricingModel() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>PER_UNIT</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record PerUnit(PerUnitPlanPricing Value) : PlanUsagePricingModel
    {
        /// <inheritdoc/>
        public override string Type => "PER_UNIT";
    }

    /// <summary>The <c>TIERED</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Tiered(TieredPlanPricing Value) : PlanUsagePricingModel
    {
        /// <inheritdoc/>
        public override string Type => "TIERED";
    }

    /// <summary>The <c>VOLUME</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Volume(VolumePlanPricing Value) : PlanUsagePricingModel
    {
        /// <inheritdoc/>
        public override string Type => "VOLUME";
    }

    /// <summary>The <c>PACKAGE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Package(PackagePlanPricing Value) : PlanUsagePricingModel
    {
        /// <inheritdoc/>
        public override string Type => "PACKAGE";
    }

    /// <summary>The <c>MATRIX</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Matrix(MatrixPlanPricing Value) : PlanUsagePricingModel
    {
        /// <inheritdoc/>
        public override string Type => "MATRIX";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : PlanUsagePricingModel
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

internal sealed class PlanUsagePricingModelConverter : JsonConverter<PlanUsagePricingModel>
{
    public override PlanUsagePricingModel Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "PER_UNIT" => new PlanUsagePricingModel.PerUnit(Json.Deserialize<PerUnitPlanPricing>(root, options)),
            "TIERED" => new PlanUsagePricingModel.Tiered(Json.Deserialize<TieredPlanPricing>(root, options)),
            "VOLUME" => new PlanUsagePricingModel.Volume(Json.Deserialize<VolumePlanPricing>(root, options)),
            "PACKAGE" => new PlanUsagePricingModel.Package(Json.Deserialize<PackagePlanPricing>(root, options)),
            "MATRIX" => new PlanUsagePricingModel.Matrix(Json.Deserialize<MatrixPlanPricing>(root, options)),
            var tag => new PlanUsagePricingModel.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, PlanUsagePricingModel value, JsonSerializerOptions options)
    {
        if (value is PlanUsagePricingModel.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case PlanUsagePricingModel.PerUnit variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PlanUsagePricingModel.Tiered variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PlanUsagePricingModel.Volume variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PlanUsagePricingModel.Package variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PlanUsagePricingModel.Matrix variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
