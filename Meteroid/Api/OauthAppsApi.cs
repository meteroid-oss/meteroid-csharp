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

/// <summary>The <c>oauth_apps</c> operations, as <see cref="IMeteroidClient.OauthApps"/> exposes them; mock it in tests.</summary>
public interface IOauthAppsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IOauthAppsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List OAuth apps
    /// </summary>
    /// <remarks>
    /// List all OAuth applications registered for this platform.
    /// </remarks>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<OAuthAppsResponse> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create OAuth app
    /// </summary>
    /// <remarks>
    /// Register a new OAuth application. Returns the app with its client secret
    /// (only shown once).
    /// </remarks>
    /// <param name="createOAuthAppRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<OAuthAppWithSecret> CreateAsync(
        CreateOAuthAppRequest createOAuthAppRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get OAuth app
    /// </summary>
    /// <remarks>
    /// Retrieve an OAuth application by ID.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<OAuthApp> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete OAuth app
    /// </summary>
    /// <remarks>
    /// Delete an OAuth application and revoke all associated tokens.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task DeleteAsync(string id, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Rotate client secret
    /// </summary>
    /// <remarks>
    /// Generate a new client secret for an OAuth app. The old secret is
    /// immediately invalidated.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<RotatedSecret> RotateAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>oauth_apps</c> operations, returning the status and headers of the response with its body.</summary>
public interface IOauthAppsApiWithRawResponse
{
    /// <summary><see cref="IOauthAppsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<OAuthAppsResponse>> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IOauthAppsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createOAuthAppRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<OAuthAppWithSecret>> CreateAsync(
        CreateOAuthAppRequest createOAuthAppRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IOauthAppsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<OAuthApp>> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IOauthAppsApi.DeleteAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> DeleteAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IOauthAppsApi.RotateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<RotatedSecret>> RotateAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>oauth_apps</c> operations. Get it from <see cref="MeteroidClient.OauthApps"/>.</summary>
public sealed partial class OauthAppsApi : IOauthAppsApi
{
    internal OauthAppsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IOauthAppsApi.WithRawResponse"/>
    public OauthAppsApiWithRawResponse WithRawResponse { get; }

    IOauthAppsApiWithRawResponse IOauthAppsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<OAuthAppsResponse> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.ListAsync(requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<OAuthAppWithSecret> CreateAsync(
        CreateOAuthAppRequest createOAuthAppRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createOAuthAppRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<OAuthApp> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.RetrieveAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task DeleteAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.DeleteAsync(id, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<RotatedSecret> RotateAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.RotateAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>oauth_apps</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class OauthAppsApiWithRawResponse : IOauthAppsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal OauthAppsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<OAuthAppsResponse>> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/oauth-apps", "oauth_apps.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.OAuthAppsResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<OAuthAppWithSecret>> CreateAsync(
        CreateOAuthAppRequest createOAuthAppRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createOAuthAppRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/oauth-apps", "oauth_apps.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createOAuthAppRequest, MeteroidJsonContext.Default.CreateOAuthAppRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.OAuthAppWithSecret,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<OAuthApp>> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/oauth-apps/{Uri.EscapeDataString(id)}",
            "oauth_apps.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.OAuthApp,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> DeleteAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/oauth-apps/{Uri.EscapeDataString(id)}",
            "oauth_apps.delete"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<RotatedSecret>> RotateAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/oauth-apps/{Uri.EscapeDataString(id)}/rotate",
            "oauth_apps.rotate"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.RotatedSecret,
            requestOptions,
            cancellationToken
        );
    }
}
