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

/// <summary>The <c>add_ons.entitlements</c> operations, as <see cref="IAddOnsApi.Entitlements"/> exposes them; mock it in tests.</summary>
public interface IAddOnsEntitlementsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IAddOnsEntitlementsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List add-on entitlements
    /// </summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ResolvedEntitlementListResponse> ListAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create add-on entitlements
    /// </summary>
    /// <remarks>
    /// Entitlements already present on this add-on are skipped.
    /// </remarks>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EntitlementListResponse> CreateAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>add_ons.entitlements</c> operations, returning the status and headers of the response with its body.</summary>
public interface IAddOnsEntitlementsApiWithRawResponse
{
    /// <summary><see cref="IAddOnsEntitlementsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ResolvedEntitlementListResponse>> ListAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsEntitlementsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EntitlementListResponse>> CreateAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>add_ons.entitlements</c> operations. Get it from <see cref="AddOnsApi.Entitlements"/>.</summary>
public sealed partial class AddOnsEntitlementsApi : IAddOnsEntitlementsApi
{
    internal AddOnsEntitlementsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IAddOnsEntitlementsApi.WithRawResponse"/>
    public AddOnsEntitlementsApiWithRawResponse WithRawResponse { get; }

    IAddOnsEntitlementsApiWithRawResponse IAddOnsEntitlementsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<ResolvedEntitlementListResponse> ListAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListAsync(addonId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EntitlementListResponse> CreateAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(addonId, createEntitlementsRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>add_ons.entitlements</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class AddOnsEntitlementsApiWithRawResponse : IAddOnsEntitlementsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal AddOnsEntitlementsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ResolvedEntitlementListResponse>> ListAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}/entitlements",
            "add_ons_entitlements.list"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ResolvedEntitlementListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<EntitlementListResponse>> CreateAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);
        ArgumentNullException.ThrowIfNull(createEntitlementsRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}/entitlements",
            "add_ons_entitlements.create"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createEntitlementsRequest, MeteroidJsonContext.Default.CreateEntitlementsRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.EntitlementListResponse,
            requestOptions,
            cancellationToken
        );
    }
}
