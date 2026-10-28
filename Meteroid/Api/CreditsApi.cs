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

/// <summary>The <c>credits</c> operations, as <see cref="IMeteroidClient.Credits"/> exposes them; mock it in tests.</summary>
public interface ICreditsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICreditsApiWithRawResponse WithRawResponse { get; }

    /// <summary>The <c>grants</c> operations.</summary>
    ICreditsGrantsApi Grants { get; }

    /// <summary>The <c>wallets</c> operations.</summary>
    ICreditsWalletsApi Wallets { get; }

    /// <summary>
    /// List credit ledger entries
    /// </summary>
    /// <remarks>
    /// Every movement of a customer's credit in one currency or credit unit, newest first, with the
    /// credit on account after it: credit granted, applied to invoices, given back, expired or
    /// rolled over.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="CreditsListCustomerCreditLedgerPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<CreditsListCustomerCreditLedgerPage, LedgerEntry> ListCustomerCreditLedgerAsync(
        string idOrAlias,
        CreditsListCustomerCreditLedgerOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a top-up
    /// </summary>
    /// <remarks>
    /// Sells credit: CHARGE bills a saved payment method now, SEND_INVOICE grants it once paid. The
    /// credit is PAID and applies to ALL charges. Currency credit is sold one for one, untaxed, as
    /// its usage is taxed when invoiced. With <c>credit_unit</c>, sells credits of that unit at its
    /// selling price in the customer's currency, taxed at purchase under the unit's product; refused
    /// when the unit has no price in that currency or no product. Without a saved payment method,
    /// CHARGE returns a hosted <c>checkout_url</c> where the customer pays.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="createTopUpRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<TopUpResponse> CreateCustomerTopUpAsync(
        string idOrAlias,
        CreateTopUpRequest createTopUpRequest,
        CreditsCreateCustomerTopUpOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credits</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICreditsApiWithRawResponse
{
    /// <summary>The <c>grants</c> operations, returning the status and headers of the response with its body.</summary>
    ICreditsGrantsApiWithRawResponse Grants { get; }

    /// <summary>The <c>wallets</c> operations, returning the status and headers of the response with its body.</summary>
    ICreditsWalletsApiWithRawResponse Wallets { get; }

    /// <summary>The single request of a page of <see cref="ICreditsApi.ListCustomerCreditLedgerAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<LedgerListResponse>> ListCustomerCreditLedgerAsync(
        string idOrAlias,
        CreditsListCustomerCreditLedgerOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditsApi.CreateCustomerTopUpAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="createTopUpRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<TopUpResponse>> CreateCustomerTopUpAsync(
        string idOrAlias,
        CreateTopUpRequest createTopUpRequest,
        CreditsCreateCustomerTopUpOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credits</c> operations. Get it from <see cref="MeteroidClient.Credits"/>.</summary>
public sealed partial class CreditsApi : ICreditsApi
{
    internal CreditsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
        Grants = new(transport);
        Wallets = new(transport);
    }

    /// <inheritdoc cref="ICreditsApi.WithRawResponse"/>
    public CreditsApiWithRawResponse WithRawResponse { get; }

    ICreditsApiWithRawResponse ICreditsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc cref="ICreditsApi.Grants"/>
    public CreditsGrantsApi Grants { get; }

    ICreditsGrantsApi ICreditsApi.Grants => Grants;

    /// <inheritdoc cref="ICreditsApi.Wallets"/>
    public CreditsWalletsApi Wallets { get; }

    ICreditsWalletsApi ICreditsApi.Wallets => Wallets;

    /// <inheritdoc/>
    public AsyncPager<CreditsListCustomerCreditLedgerPage, LedgerEntry> ListCustomerCreditLedgerAsync(
        string idOrAlias,
        CreditsListCustomerCreditLedgerOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        return Paging.Numbered<CreditsListCustomerCreditLedgerPage, LedgerListResponse, LedgerEntry>(
            options?.Page ?? 0,
            0,
            pages: true,
            (param, ct) =>
                WithRawResponse.ListCustomerCreditLedgerAsync(
                    idOrAlias,
                    (options ?? new()) with
                    {
                        Page = (int)param,
                    },
                    requestOptions,
                    ct
                ),
            (body, items, next) => new(body, items, next),
            body => body.Data,
            null,
            body => (long?)body.PaginationMeta?.TotalPages,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<TopUpResponse> CreateCustomerTopUpAsync(
        string idOrAlias,
        CreateTopUpRequest createTopUpRequest,
        CreditsCreateCustomerTopUpOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateCustomerTopUpAsync(idOrAlias, createTopUpRequest, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>credits</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CreditsApiWithRawResponse : ICreditsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CreditsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
        Grants = new(transport);
        Wallets = new(transport);
    }

    /// <inheritdoc cref="ICreditsApiWithRawResponse.Grants"/>
    public CreditsGrantsApiWithRawResponse Grants { get; }

    ICreditsGrantsApiWithRawResponse ICreditsApiWithRawResponse.Grants => Grants;

    /// <inheritdoc cref="ICreditsApiWithRawResponse.Wallets"/>
    public CreditsWalletsApiWithRawResponse Wallets { get; }

    ICreditsWalletsApiWithRawResponse ICreditsApiWithRawResponse.Wallets => Wallets;

    /// <inheritdoc/>
    public Task<ApiResponse<LedgerListResponse>> ListCustomerCreditLedgerAsync(
        string idOrAlias,
        CreditsListCustomerCreditLedgerOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/credit-ledger",
            "credits.list_customer_credit_ledger"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("currency", options?.Currency);
        request.AddQuery("credit_unit", options?.CreditUnit);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.LedgerListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<TopUpResponse>> CreateCustomerTopUpAsync(
        string idOrAlias,
        CreateTopUpRequest createTopUpRequest,
        CreditsCreateCustomerTopUpOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentNullException.ThrowIfNull(createTopUpRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/top-ups",
            "credits.create_customer_top_up"
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
        request.SetHeader("Idempotency-Key", options.IdempotencyKey);
        request.SetJsonBody(createTopUpRequest, MeteroidJsonContext.Default.CreateTopUpRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.TopUpResponse,
            requestOptions,
            cancellationToken
        );
    }
}

/// <summary>A page of <see cref="CreditsApi.ListCustomerCreditLedgerAsync"/>: its <see cref="LedgerListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class CreditsListCustomerCreditLedgerPage
    : Page<CreditsListCustomerCreditLedgerPage, LedgerListResponse, LedgerEntry>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public CreditsListCustomerCreditLedgerPage(
        LedgerListResponse body,
        IReadOnlyList<LedgerEntry> items,
        Func<CancellationToken, Task<CreditsListCustomerCreditLedgerPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="LedgerListResponse.Data"/>
    public IReadOnlyList<LedgerEntry> Data => Body.Data;

    /// <inheritdoc cref="LedgerListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
