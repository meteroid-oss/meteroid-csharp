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

/// <summary>The <c>entitlements</c> operations, as <see cref="IMeteroidClient.Entitlements"/> exposes them; mock it in tests.</summary>
public interface IEntitlementsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IEntitlementsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Get entitlement details
    /// </summary>
    /// <param name="entitlementId">The <c>entitlement_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Entitlement> RetrieveAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete an entitlement
    /// </summary>
    /// <param name="entitlementId">The <c>entitlement_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task DeleteAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an entitlement
    /// </summary>
    /// <remarks>
    /// The new value must match the feature's declared type.
    /// </remarks>
    /// <param name="entitlementId">The <c>entitlement_id</c> path parameter.</param>
    /// <param name="updateEntitlementRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Entitlement> UpdateAsync(
        string entitlementId,
        UpdateEntitlementRequest updateEntitlementRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>entitlements</c> operations, returning the status and headers of the response with its body.</summary>
public interface IEntitlementsApiWithRawResponse
{
    /// <summary><see cref="IEntitlementsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="entitlementId">The <c>entitlement_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Entitlement>> RetrieveAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IEntitlementsApi.DeleteAsync"/>, with the status and headers of the response.</summary>
    /// <param name="entitlementId">The <c>entitlement_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> DeleteAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IEntitlementsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="entitlementId">The <c>entitlement_id</c> path parameter.</param>
    /// <param name="updateEntitlementRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Entitlement>> UpdateAsync(
        string entitlementId,
        UpdateEntitlementRequest updateEntitlementRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>entitlements</c> operations. Get it from <see cref="MeteroidClient.Entitlements"/>.</summary>
public sealed partial class EntitlementsApi : IEntitlementsApi
{
    internal EntitlementsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IEntitlementsApi.WithRawResponse"/>
    public EntitlementsApiWithRawResponse WithRawResponse { get; }

    IEntitlementsApiWithRawResponse IEntitlementsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<Entitlement> RetrieveAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(entitlementId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task DeleteAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.DeleteAsync(entitlementId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<Entitlement> UpdateAsync(
        string entitlementId,
        UpdateEntitlementRequest updateEntitlementRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(entitlementId, updateEntitlementRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>entitlements</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class EntitlementsApiWithRawResponse : IEntitlementsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal EntitlementsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Entitlement>> RetrieveAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(entitlementId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/entitlements/{Uri.EscapeDataString(entitlementId)}",
            "entitlements.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Entitlement,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> DeleteAsync(
        string entitlementId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(entitlementId);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/entitlements/{Uri.EscapeDataString(entitlementId)}",
            "entitlements.delete"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Entitlement>> UpdateAsync(
        string entitlementId,
        UpdateEntitlementRequest updateEntitlementRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(entitlementId);
        ArgumentNullException.ThrowIfNull(updateEntitlementRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/entitlements/{Uri.EscapeDataString(entitlementId)}",
            "entitlements.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateEntitlementRequest, MeteroidJsonContext.Default.UpdateEntitlementRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Entitlement,
            requestOptions,
            cancellationToken
        );
    }
}
