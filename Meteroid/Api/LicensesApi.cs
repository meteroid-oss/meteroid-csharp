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

/// <summary>The <c>licenses</c> operations, as <see cref="IMeteroidClient.Licenses"/> exposes them; mock it in tests.</summary>
public interface ILicensesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ILicensesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List licenses
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<LicenseListResponse> ListAsync(
        LicensesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Issue a license
    /// </summary>
    /// <remarks>
    /// Issues a license to a customer, optionally tied to one of its subscriptions. Online, the
    /// license is pending until their installation activates it with the returned one-time code.
    /// Offline, it is returned signed at once, for an installation that can't reach the server.
    /// </remarks>
    /// <param name="issueLicenseRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<IssueLicenseResponse> CreateAsync(
        IssueLicenseRequest issueLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a license
    /// </summary>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<License> RetrieveAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a license's activation code
    /// </summary>
    /// <remarks>
    /// Available until the license is activated or revoked.
    /// </remarks>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<LicenseActivationCode> RetrieveActivationCodeAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Issue an offline license
    /// </summary>
    /// <remarks>
    /// Signs a long-lived license for an air-gapped installation from an existing license, e.g. to
    /// renew an offline license before it expires. Given an instance id, binds the license to it.
    /// </remarks>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="issueOfflineLicenseRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<OfflineLicense> OfflineAsync(
        string licenseId,
        IssueOfflineLicenseRequest issueOfflineLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Revoke a license
    /// </summary>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="revokeLicenseRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<License> RevokeAsync(
        string licenseId,
        RevokeLicenseRequest revokeLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the licensing signing keys
    /// </summary>
    /// <remarks>
    /// The keys licenses are signed with, and the public endpoints installations talk to.
    /// </remarks>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<LicenseSigningKeysResponse> ListLicensingSigningKeysAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>licenses</c> operations, returning the status and headers of the response with its body.</summary>
public interface ILicensesApiWithRawResponse
{
    /// <summary><see cref="ILicensesApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<LicenseListResponse>> ListAsync(
        LicensesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ILicensesApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="issueLicenseRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<IssueLicenseResponse>> CreateAsync(
        IssueLicenseRequest issueLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ILicensesApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<License>> RetrieveAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ILicensesApi.RetrieveActivationCodeAsync"/>, with the status and headers of the response.</summary>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<LicenseActivationCode>> RetrieveActivationCodeAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ILicensesApi.OfflineAsync"/>, with the status and headers of the response.</summary>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="issueOfflineLicenseRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<OfflineLicense>> OfflineAsync(
        string licenseId,
        IssueOfflineLicenseRequest issueOfflineLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ILicensesApi.RevokeAsync"/>, with the status and headers of the response.</summary>
    /// <param name="licenseId">The <c>license_id</c> path parameter.</param>
    /// <param name="revokeLicenseRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<License>> RevokeAsync(
        string licenseId,
        RevokeLicenseRequest revokeLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ILicensesApi.ListLicensingSigningKeysAsync"/>, with the status and headers of the response.</summary>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<LicenseSigningKeysResponse>> ListLicensingSigningKeysAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>licenses</c> operations. Get it from <see cref="MeteroidClient.Licenses"/>.</summary>
public sealed partial class LicensesApi : ILicensesApi
{
    internal LicensesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ILicensesApi.WithRawResponse"/>
    public LicensesApiWithRawResponse WithRawResponse { get; }

    ILicensesApiWithRawResponse ILicensesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<LicenseListResponse> ListAsync(
        LicensesListOptions? options = null,
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
    public async Task<IssueLicenseResponse> CreateAsync(
        IssueLicenseRequest issueLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(issueLicenseRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<License> RetrieveAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(licenseId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<LicenseActivationCode> RetrieveActivationCodeAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveActivationCodeAsync(licenseId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<OfflineLicense> OfflineAsync(
        string licenseId,
        IssueOfflineLicenseRequest issueOfflineLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .OfflineAsync(licenseId, issueOfflineLicenseRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<License> RevokeAsync(
        string licenseId,
        RevokeLicenseRequest revokeLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RevokeAsync(licenseId, revokeLicenseRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<LicenseSigningKeysResponse> ListLicensingSigningKeysAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListLicensingSigningKeysAsync(requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>licenses</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class LicensesApiWithRawResponse : ILicensesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal LicensesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<LicenseListResponse>> ListAsync(
        LicensesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/licenses", "licenses.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("customer_id", options?.CustomerId);
        request.AddQuery("subscription_id", options?.SubscriptionId);
        request.AddQuery("include_revoked", options?.IncludeRevoked);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.LicenseListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<IssueLicenseResponse>> CreateAsync(
        IssueLicenseRequest issueLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(issueLicenseRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/licenses", "licenses.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("403", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(issueLicenseRequest, MeteroidJsonContext.Default.IssueLicenseRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.IssueLicenseResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<License>> RetrieveAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(licenseId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/licenses/{Uri.EscapeDataString(licenseId)}",
            "licenses.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.License,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<LicenseActivationCode>> RetrieveActivationCodeAsync(
        string licenseId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(licenseId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/licenses/{Uri.EscapeDataString(licenseId)}/activation-code",
            "licenses.retrieve_activation_code"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.LicenseActivationCode,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<OfflineLicense>> OfflineAsync(
        string licenseId,
        IssueOfflineLicenseRequest issueOfflineLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(licenseId);
        ArgumentNullException.ThrowIfNull(issueOfflineLicenseRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/licenses/{Uri.EscapeDataString(licenseId)}/offline",
            "licenses.offline"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("403", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(issueOfflineLicenseRequest, MeteroidJsonContext.Default.IssueOfflineLicenseRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.OfflineLicense,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<License>> RevokeAsync(
        string licenseId,
        RevokeLicenseRequest revokeLicenseRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(licenseId);
        ArgumentNullException.ThrowIfNull(revokeLicenseRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/licenses/{Uri.EscapeDataString(licenseId)}/revoke",
            "licenses.revoke"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(revokeLicenseRequest, MeteroidJsonContext.Default.RevokeLicenseRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.License,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<LicenseSigningKeysResponse>> ListLicensingSigningKeysAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(
            HttpMethod.Get,
            "/api/v1/licensing/signing-keys",
            "licenses.list_licensing_signing_keys"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("403", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.LicenseSigningKeysResponse,
            requestOptions,
            cancellationToken
        );
    }
}
