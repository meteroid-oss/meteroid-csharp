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

/// <summary>The <c>features</c> operations, as <see cref="IMeteroidClient.Features"/> exposes them; mock it in tests.</summary>
public interface IFeaturesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IFeaturesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List features
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<FeatureListResponse> ListAsync(
        FeaturesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a feature
    /// </summary>
    /// <param name="createFeatureRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Feature> CreateAsync(
        CreateFeatureRequest createFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get feature details
    /// </summary>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Feature> RetrieveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a feature
    /// </summary>
    /// <remarks>
    /// Partially update feature fields. Code, feature type and product are immutable.
    /// </remarks>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="updateFeatureRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Feature> UpdateAsync(
        string idOrCode,
        UpdateFeatureRequest updateFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a feature
    /// </summary>
    /// <remarks>
    /// Keeps the feature and its entitlements but hides them from resolution.
    /// </remarks>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task ArchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unarchive a feature
    /// </summary>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task UnarchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>features</c> operations, returning the status and headers of the response with its body.</summary>
public interface IFeaturesApiWithRawResponse
{
    /// <summary><see cref="IFeaturesApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<FeatureListResponse>> ListAsync(
        FeaturesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IFeaturesApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createFeatureRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Feature>> CreateAsync(
        CreateFeatureRequest createFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IFeaturesApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Feature>> RetrieveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IFeaturesApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="updateFeatureRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Feature>> UpdateAsync(
        string idOrCode,
        UpdateFeatureRequest updateFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IFeaturesApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> ArchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IFeaturesApi.UnarchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrCode">The <c>id_or_code</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> UnarchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>features</c> operations. Get it from <see cref="MeteroidClient.Features"/>.</summary>
public sealed partial class FeaturesApi : IFeaturesApi
{
    internal FeaturesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IFeaturesApi.WithRawResponse"/>
    public FeaturesApiWithRawResponse WithRawResponse { get; }

    IFeaturesApiWithRawResponse IFeaturesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<FeatureListResponse> ListAsync(
        FeaturesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListAsync(options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Feature> CreateAsync(
        CreateFeatureRequest createFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createFeatureRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Feature> RetrieveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(idOrCode, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Feature> UpdateAsync(
        string idOrCode,
        UpdateFeatureRequest updateFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(idOrCode, updateFeatureRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task ArchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.ArchiveAsync(idOrCode, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public Task UnarchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.UnarchiveAsync(idOrCode, requestOptions, cancellationToken);
}

/// <summary>The <c>features</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class FeaturesApiWithRawResponse : IFeaturesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal FeaturesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<FeatureListResponse>> ListAsync(
        FeaturesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/features", "features.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("statuses", options?.Statuses);
        request.AddQuery("product_id", options?.ProductId);
        request.AddQuery("search", options?.Search);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.FeatureListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Feature>> CreateAsync(
        CreateFeatureRequest createFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createFeatureRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/features", "features.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createFeatureRequest, MeteroidJsonContext.Default.CreateFeatureRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Feature,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Feature>> RetrieveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrCode);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/features/{Uri.EscapeDataString(idOrCode)}",
            "features.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Feature,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Feature>> UpdateAsync(
        string idOrCode,
        UpdateFeatureRequest updateFeatureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrCode);
        ArgumentNullException.ThrowIfNull(updateFeatureRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/features/{Uri.EscapeDataString(idOrCode)}",
            "features.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateFeatureRequest, MeteroidJsonContext.Default.UpdateFeatureRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Feature,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> ArchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrCode);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/features/{Uri.EscapeDataString(idOrCode)}/archive",
            "features.archive"
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
    public Task<ApiResponse> UnarchiveAsync(
        string idOrCode,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrCode);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/features/{Uri.EscapeDataString(idOrCode)}/unarchive",
            "features.unarchive"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }
}
