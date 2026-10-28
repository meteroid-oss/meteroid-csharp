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

/// <summary>The <c>credit_units.prices</c> operations, as <see cref="ICreditUnitsApi.Prices"/> exposes them; mock it in tests.</summary>
public interface ICreditUnitsPricesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICreditUnitsPricesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List a credit unit's selling prices
    /// </summary>
    /// <remarks>
    /// The active price per currency, and archived ones when asked, newest first.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnitPriceListResponse> ListAsync(
        string id,
        CreditUnitsPricesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set a credit unit's selling price
    /// </summary>
    /// <remarks>
    /// The price of one credit in a currency, used to sell the unit through top-ups and automatic
    /// top-ups (taxed at purchase under the unit's <c>product_id</c>). Replaces the active price in that
    /// currency, which is archived: a top-up already priced keeps its terms.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="currency">The <c>currency</c> path parameter.</param>
    /// <param name="creditUnitPriceSetRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnitPrice> UpdateAsync(
        string id,
        string currency,
        CreditUnitPriceSetRequest creditUnitPriceSetRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a credit unit's selling price
    /// </summary>
    /// <remarks>
    /// Archives the active price in a currency: the unit can no longer be sold in it (top-ups and
    /// automatic top-ups included) until a new price is set.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="currency">The <c>currency</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditUnitPrice> ArchiveAsync(
        string id,
        string currency,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credit_units.prices</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICreditUnitsPricesApiWithRawResponse
{
    /// <summary><see cref="ICreditUnitsPricesApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnitPriceListResponse>> ListAsync(
        string id,
        CreditUnitsPricesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditUnitsPricesApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="currency">The <c>currency</c> path parameter.</param>
    /// <param name="creditUnitPriceSetRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnitPrice>> UpdateAsync(
        string id,
        string currency,
        CreditUnitPriceSetRequest creditUnitPriceSetRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditUnitsPricesApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="currency">The <c>currency</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditUnitPrice>> ArchiveAsync(
        string id,
        string currency,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credit_units.prices</c> operations. Get it from <see cref="CreditUnitsApi.Prices"/>.</summary>
public sealed partial class CreditUnitsPricesApi : ICreditUnitsPricesApi
{
    internal CreditUnitsPricesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICreditUnitsPricesApi.WithRawResponse"/>
    public CreditUnitsPricesApiWithRawResponse WithRawResponse { get; }

    ICreditUnitsPricesApiWithRawResponse ICreditUnitsPricesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<CreditUnitPriceListResponse> ListAsync(
        string id,
        CreditUnitsPricesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListAsync(id, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CreditUnitPrice> UpdateAsync(
        string id,
        string currency,
        CreditUnitPriceSetRequest creditUnitPriceSetRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(id, currency, creditUnitPriceSetRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CreditUnitPrice> ArchiveAsync(
        string id,
        string currency,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ArchiveAsync(id, currency, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>credit_units.prices</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CreditUnitsPricesApiWithRawResponse : ICreditUnitsPricesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CreditUnitsPricesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnitPriceListResponse>> ListAsync(
        string id,
        CreditUnitsPricesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/credit-units/{Uri.EscapeDataString(id)}/prices",
            "credit_units_prices.list"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("include_archived", options?.IncludeArchived);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditUnitPriceListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnitPrice>> UpdateAsync(
        string id,
        string currency,
        CreditUnitPriceSetRequest creditUnitPriceSetRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);
        ArgumentException.ThrowIfNullOrEmpty(currency);
        ArgumentNullException.ThrowIfNull(creditUnitPriceSetRequest);

        var request = new ApiRequest(
            HttpMethod.Put,
            $"/api/v1/credit-units/{Uri.EscapeDataString(id)}/prices/{Uri.EscapeDataString(currency)}",
            "credit_units_prices.update"
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
        request.SetJsonBody(creditUnitPriceSetRequest, MeteroidJsonContext.Default.CreditUnitPriceSetRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditUnitPrice,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditUnitPrice>> ArchiveAsync(
        string id,
        string currency,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);
        ArgumentException.ThrowIfNullOrEmpty(currency);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/credit-units/{Uri.EscapeDataString(id)}/prices/{Uri.EscapeDataString(currency)}",
            "credit_units_prices.archive"
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
            MeteroidJsonContext.Default.CreditUnitPrice,
            requestOptions,
            cancellationToken
        );
    }
}
