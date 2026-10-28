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

/// <summary>The <c>credit_units</c> operations, as <see cref="IMeteroidClient.CreditUnits"/> exposes them; mock it in tests.</summary>
public interface ICreditUnitsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICreditUnitsApiWithRawResponse WithRawResponse { get; }

    /// <summary>The <c>prices</c> operations.</summary>
    ICreditUnitsPricesApi Prices { get; }

    /// <summary>
    /// List credit units
    /// </summary>
    /// <remarks>
    /// The tenant's credit units (e.g. "Halyard credits"): denominations usage can be priced and
    /// credit granted in, instead of money, each with its selling prices.
    /// </remarks>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnitListResponse> ListAsync(
        CreditUnitsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a credit unit
    /// </summary>
    /// <remarks>
    /// <c>code</c> and <c>precision</c> are immutable once created. Price usage in the unit with a plan fee's
    /// <c>credit_unit</c>, grant it with a credit pack or a credit grant, and sell it with a top-up once
    /// it has a <c>product_id</c> and a selling price.
    /// </remarks>
    /// <param name="creditUnitCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnit> CreateAsync(
        CreditUnitCreateRequest creditUnitCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a credit unit
    /// </summary>
    /// <remarks>
    /// The unit with its active selling prices.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnit> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a credit unit
    /// </summary>
    /// <remarks>
    /// Partial update: an absent field is left unchanged. <c>code</c> and <c>precision</c> are immutable and
    /// cannot be changed here. Setting <c>archived: true</c> blocks the unit from new prices, packs and
    /// grants; existing ones keep working.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="creditUnitUpdateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnit> UpdateAsync(
        string id,
        CreditUnitUpdateRequest creditUnitUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credit_units</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICreditUnitsApiWithRawResponse
{
    /// <summary>The <c>prices</c> operations, returning the status and headers of the response with its body.</summary>
    ICreditUnitsPricesApiWithRawResponse Prices { get; }

    /// <summary><see cref="ICreditUnitsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnitListResponse>> ListAsync(
        CreditUnitsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditUnitsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="creditUnitCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnit>> CreateAsync(
        CreditUnitCreateRequest creditUnitCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditUnitsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnit>> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditUnitsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="creditUnitUpdateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnit>> UpdateAsync(
        string id,
        CreditUnitUpdateRequest creditUnitUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credit_units</c> operations. Get it from <see cref="MeteroidClient.CreditUnits"/>.</summary>
public sealed partial class CreditUnitsApi : ICreditUnitsApi
{
    internal CreditUnitsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
        Prices = new(transport);
    }

    /// <inheritdoc cref="ICreditUnitsApi.WithRawResponse"/>
    public CreditUnitsApiWithRawResponse WithRawResponse { get; }

    ICreditUnitsApiWithRawResponse ICreditUnitsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc cref="ICreditUnitsApi.Prices"/>
    public CreditUnitsPricesApi Prices { get; }

    ICreditUnitsPricesApi ICreditUnitsApi.Prices => Prices;

    /// <inheritdoc/>
    public async Task<CreditUnitListResponse> ListAsync(
        CreditUnitsListOptions? options = null,
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
    public async Task<CreditUnit> CreateAsync(
        CreditUnitCreateRequest creditUnitCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(creditUnitCreateRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CreditUnit> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.RetrieveAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CreditUnit> UpdateAsync(
        string id,
        CreditUnitUpdateRequest creditUnitUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(id, creditUnitUpdateRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>credit_units</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CreditUnitsApiWithRawResponse : ICreditUnitsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CreditUnitsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
        Prices = new(transport);
    }

    /// <inheritdoc cref="ICreditUnitsApiWithRawResponse.Prices"/>
    public CreditUnitsPricesApiWithRawResponse Prices { get; }

    ICreditUnitsPricesApiWithRawResponse ICreditUnitsApiWithRawResponse.Prices => Prices;

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnitListResponse>> ListAsync(
        CreditUnitsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/credit-units", "credit_units.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("include_archived", options?.IncludeArchived);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditUnitListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnit>> CreateAsync(
        CreditUnitCreateRequest creditUnitCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(creditUnitCreateRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/credit-units", "credit_units.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(creditUnitCreateRequest, MeteroidJsonContext.Default.CreditUnitCreateRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditUnit,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnit>> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/credit-units/{Uri.EscapeDataString(id)}",
            "credit_units.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditUnit,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnit>> UpdateAsync(
        string id,
        CreditUnitUpdateRequest creditUnitUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);
        ArgumentNullException.ThrowIfNull(creditUnitUpdateRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/credit-units/{Uri.EscapeDataString(id)}",
            "credit_units.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(creditUnitUpdateRequest, MeteroidJsonContext.Default.CreditUnitUpdateRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditUnit,
            requestOptions,
            cancellationToken
        );
    }
}
