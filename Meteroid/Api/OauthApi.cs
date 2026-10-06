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

/// <summary>The <c>oauth</c> operations, as <see cref="IMeteroidClient.Oauth"/> exposes them; mock it in tests.</summary>
public interface IOauthApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IOauthApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Introspect token
    /// </summary>
    /// <remarks>
    /// Token introspection endpoint (RFC 7662). Requires client credentials
    /// via HTTP Basic auth.
    /// </remarks>
    /// <param name="introspectionRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.OAuthErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<TokenIntrospectionResponse> IntrospectAsync(
        IntrospectionRequest introspectionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Revoke token
    /// </summary>
    /// <remarks>
    /// Token revocation endpoint (RFC 7009). Always returns 200 per spec.
    /// Requires client credentials via HTTP Basic auth.
    /// </remarks>
    /// <param name="revocationRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.OAuthErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task RevokeAsync(
        RevocationRequest revocationRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Exchange tokens
    /// </summary>
    /// <remarks>
    /// <para>
    /// OAuth 2.0 token endpoint. Supports two grant types:
    /// - <c>authorization_code</c>: Exchange an authorization code for tokens
    /// - <c>refresh_token</c>: Refresh an access token
    /// </para>
    /// <para>
    /// Authenticate via HTTP Basic auth (<c>client_id:client_secret</c>) or body parameters.
    /// </para>
    /// </remarks>
    /// <param name="tokenRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.OAuthErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.OAuthErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<TokenResponse> TokenAsync(
        TokenRequest tokenRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>oauth</c> operations, returning the status and headers of the response with its body.</summary>
public interface IOauthApiWithRawResponse
{
    /// <summary><see cref="IOauthApi.IntrospectAsync"/>, with the status and headers of the response.</summary>
    /// <param name="introspectionRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<TokenIntrospectionResponse>> IntrospectAsync(
        IntrospectionRequest introspectionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IOauthApi.RevokeAsync"/>, with the status and headers of the response.</summary>
    /// <param name="revocationRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> RevokeAsync(
        RevocationRequest revocationRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IOauthApi.TokenAsync"/>, with the status and headers of the response.</summary>
    /// <param name="tokenRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<TokenResponse>> TokenAsync(
        TokenRequest tokenRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>oauth</c> operations. Get it from <see cref="MeteroidClient.Oauth"/>.</summary>
public sealed partial class OauthApi : IOauthApi
{
    internal OauthApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IOauthApi.WithRawResponse"/>
    public OauthApiWithRawResponse WithRawResponse { get; }

    IOauthApiWithRawResponse IOauthApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<TokenIntrospectionResponse> IntrospectAsync(
        IntrospectionRequest introspectionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .IntrospectAsync(introspectionRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task RevokeAsync(
        RevocationRequest revocationRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.RevokeAsync(revocationRequest, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<TokenResponse> TokenAsync(
        TokenRequest tokenRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .TokenAsync(tokenRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>oauth</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class OauthApiWithRawResponse : IOauthApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal OauthApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<TokenIntrospectionResponse>> IntrospectAsync(
        IntrospectionRequest introspectionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(introspectionRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/oauth/introspect", "oauth.introspect");
        request.Security = [];
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.OAuthErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetFormBody(introspectionRequest, MeteroidJsonContext.Default.IntrospectionRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.TokenIntrospectionResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> RevokeAsync(
        RevocationRequest revocationRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(revocationRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/oauth/revoke", "oauth.revoke");
        request.Security = [];
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.OAuthErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetFormBody(revocationRequest, MeteroidJsonContext.Default.RevocationRequest);
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<TokenResponse>> TokenAsync(
        TokenRequest tokenRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(tokenRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/oauth/token", "oauth.token");
        request.Security = [];
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.OAuthErrorResponse),
            new("401", MeteroidJsonContext.Default.OAuthErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetFormBody(tokenRequest, MeteroidJsonContext.Default.TokenRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.TokenResponse,
            requestOptions,
            cancellationToken
        );
    }
}
