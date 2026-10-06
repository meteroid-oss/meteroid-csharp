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

/// <summary>The <c>connect</c> operations, as <see cref="IMeteroidClient.Connect"/> exposes them; mock it in tests.</summary>
public interface IConnectApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IConnectApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List connected accounts
    /// </summary>
    /// <remarks>
    /// List all connected accounts for this platform.
    /// </remarks>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ConnectedAccountsResponse> ListConnectedAccountsAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create connected account
    /// </summary>
    /// <remarks>
    /// Create a new connected account (Express flow). Returns the account
    /// and an onboarding link for the user to complete setup.
    /// </remarks>
    /// <param name="createConnectedAccountRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ConnectedAccount> CreateConnectedAccountAsync(
        CreateConnectedAccountRequest createConnectedAccountRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get connected account
    /// </summary>
    /// <remarks>
    /// Retrieve a connected account by ID.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ConnectedAccount> RetrieveConnectedAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Disconnect account
    /// </summary>
    /// <remarks>
    /// Revoke a connected account. All associated tokens are invalidated.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task DisconnectAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create onboarding link
    /// </summary>
    /// <remarks>
    /// Generate a new onboarding link for a connected account. Any existing
    /// unused link is invalidated. The link expires after a configured duration.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="createOnboardingLinkRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<OnboardingLinkResponse> CreateOnboardingLinkAsync(
        string id,
        CreateOnboardingLinkRequest createOnboardingLinkRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>connect</c> operations, returning the status and headers of the response with its body.</summary>
public interface IConnectApiWithRawResponse
{
    /// <summary><see cref="IConnectApi.ListConnectedAccountsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ConnectedAccountsResponse>> ListConnectedAccountsAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IConnectApi.CreateConnectedAccountAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createConnectedAccountRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ConnectedAccount>> CreateConnectedAccountAsync(
        CreateConnectedAccountRequest createConnectedAccountRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IConnectApi.RetrieveConnectedAccountAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ConnectedAccount>> RetrieveConnectedAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IConnectApi.DisconnectAccountAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> DisconnectAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IConnectApi.CreateOnboardingLinkAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="createOnboardingLinkRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<OnboardingLinkResponse>> CreateOnboardingLinkAsync(
        string id,
        CreateOnboardingLinkRequest createOnboardingLinkRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>connect</c> operations. Get it from <see cref="MeteroidClient.Connect"/>.</summary>
public sealed partial class ConnectApi : IConnectApi
{
    internal ConnectApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IConnectApi.WithRawResponse"/>
    public ConnectApiWithRawResponse WithRawResponse { get; }

    IConnectApiWithRawResponse IConnectApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<ConnectedAccountsResponse> ListConnectedAccountsAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListConnectedAccountsAsync(requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<ConnectedAccount> CreateConnectedAccountAsync(
        CreateConnectedAccountRequest createConnectedAccountRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateConnectedAccountAsync(createConnectedAccountRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<ConnectedAccount> RetrieveConnectedAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveConnectedAccountAsync(id, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task DisconnectAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.DisconnectAccountAsync(id, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<OnboardingLinkResponse> CreateOnboardingLinkAsync(
        string id,
        CreateOnboardingLinkRequest createOnboardingLinkRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateOnboardingLinkAsync(id, createOnboardingLinkRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>connect</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class ConnectApiWithRawResponse : IConnectApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal ConnectApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ConnectedAccountsResponse>> ListConnectedAccountsAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/connected-accounts", "connect.list_connected_accounts");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ConnectedAccountsResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ConnectedAccount>> CreateConnectedAccountAsync(
        CreateConnectedAccountRequest createConnectedAccountRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createConnectedAccountRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/connected-accounts", "connect.create_connected_account");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createConnectedAccountRequest, MeteroidJsonContext.Default.CreateConnectedAccountRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ConnectedAccount,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ConnectedAccount>> RetrieveConnectedAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/connected-accounts/{Uri.EscapeDataString(id)}",
            "connect.retrieve_connected_account"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ConnectedAccount,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> DisconnectAccountAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/connected-accounts/{Uri.EscapeDataString(id)}",
            "connect.disconnect_account"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<OnboardingLinkResponse>> CreateOnboardingLinkAsync(
        string id,
        CreateOnboardingLinkRequest createOnboardingLinkRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);
        ArgumentNullException.ThrowIfNull(createOnboardingLinkRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/connected-accounts/{Uri.EscapeDataString(id)}/onboarding",
            "connect.create_onboarding_link"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createOnboardingLinkRequest, MeteroidJsonContext.Default.CreateOnboardingLinkRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.OnboardingLinkResponse,
            requestOptions,
            cancellationToken
        );
    }
}
