// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Meteroid.Models;

namespace Meteroid;

/// <summary>The <c>checks</c> operations, as <see cref="IMeteroidClient.Checks"/> exposes them; mock it in tests.</summary>
public interface IChecksApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IChecksApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Check customer entitlement
    /// </summary>
    /// <remarks>
    /// <para>
    /// Whether the customer may consume <c>requested</c> more of a feature right now, given their
    /// entitlement, the hard budgets that count the feature's usage, and their prepaid credit.
    /// Boolean features answer from their enabled state; config features grant access and return
    /// their <c>value</c>. An <c>ALLOW</c> limit never refuses: <c>in_overage</c> tells when the requested units go
    /// beyond it. Sliding windows send no threshold webhooks. Pass the group as
    /// <c>group[&lt;property&gt;]=&lt;value&gt;</c>: it is required when the entitlement is grouped. Pass
    /// <c>subscription_id</c> when the usage belongs to one subscription, so that a hard budget on another
    /// subscription does not refuse it.
    /// </para>
    /// <para>
    /// The answer reflects usage up to <c>as_of</c>: typically less than a minute old, and less than 10
    /// seconds old once <c>near_limit</c> is true. A hard limit can therefore be exceeded by the usage of
    /// those few seconds. While <c>near_limit</c> is true, check before every request with its actual
    /// <c>requested</c> and do not cache the answer; <c>retry_after_ms</c> says when to check again. Use the
    /// check to gate access, not to bill.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="featureIdOrCode">The <c>feature_id_or_code</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500, 503: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500, 503: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EntitlementCheck> CheckEntitlementAsync(
        string idOrAlias,
        string featureIdOrCode,
        ChecksCheckEntitlementOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>checks</c> operations, returning the status and headers of the response with its body.</summary>
public interface IChecksApiWithRawResponse
{
    /// <summary><see cref="IChecksApi.CheckEntitlementAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="featureIdOrCode">The <c>feature_id_or_code</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EntitlementCheck>> CheckEntitlementAsync(
        string idOrAlias,
        string featureIdOrCode,
        ChecksCheckEntitlementOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>checks</c> operations. Get it from <see cref="MeteroidClient.Checks"/>.</summary>
public sealed partial class ChecksApi : IChecksApi
{
    internal ChecksApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IChecksApi.WithRawResponse"/>
    public ChecksApiWithRawResponse WithRawResponse { get; }

    IChecksApiWithRawResponse IChecksApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<EntitlementCheck> CheckEntitlementAsync(
        string idOrAlias,
        string featureIdOrCode,
        ChecksCheckEntitlementOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CheckEntitlementAsync(idOrAlias, featureIdOrCode, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>checks</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class ChecksApiWithRawResponse : IChecksApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal ChecksApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<EntitlementCheck>> CheckEntitlementAsync(
        string idOrAlias,
        string featureIdOrCode,
        ChecksCheckEntitlementOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentException.ThrowIfNullOrEmpty(featureIdOrCode);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/entitlements/{Uri.EscapeDataString(featureIdOrCode)}/check",
            "checks.check_entitlement"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
            new("503", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("requested", options?.Requested);
        request.AddQuery("subscription_id", options?.SubscriptionId);
        request.AddStructuredQuery(
            "group",
            options?.Group,
            MeteroidJsonContext.Default.JsonDictionaryStringString,
            true,
            true
        );
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.EntitlementCheck,
            requestOptions,
            cancellationToken
        );
    }
}
