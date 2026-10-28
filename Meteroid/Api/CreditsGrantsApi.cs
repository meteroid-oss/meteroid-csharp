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

/// <summary>The <c>credits.grants</c> operations, as <see cref="ICreditsApi.Grants"/> exposes them; mock it in tests.</summary>
public interface ICreditsGrantsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICreditsGrantsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List credit grants
    /// </summary>
    /// <remarks>
    /// A customer's credit grants, newest first, in every currency and credit unit unless filtered.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="CreditsGrantsListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<CreditsGrantsListPage, CreditGrant> ListAsync(
        string idOrAlias,
        CreditsGrantsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a credit grant
    /// </summary>
    /// <remarks>
    /// Grants credit without charging or invoicing: PROMOTIONAL credit for free, or PAID credit the
    /// customer paid for outside Meteroid ("Paid outside Meteroid"). A PAID currency grant whose
    /// <c>cost</c> is below its <c>amount</c> is split into a PAID grant for the cost and a PROMOTIONAL bonus
    /// grant for the rest, returned as <c>bonus_grant_id</c>; a <c>cost</c> above the <c>amount</c> is refused.
    /// For a customer of a French invoicing entity, PAID credit that cost more than zero needs a
    /// <c>reference</c> to the invoice or receipt of its payment. Sell credit through Meteroid with a
    /// top-up.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="createCreditGrantRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditGrant> CreateAsync(
        string idOrAlias,
        CreateCreditGrantRequest createCreditGrantRequest,
        CreditsGrantsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credits.grants</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICreditsGrantsApiWithRawResponse
{
    /// <summary>The single request of a page of <see cref="ICreditsGrantsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditGrantListResponse>> ListAsync(
        string idOrAlias,
        CreditsGrantsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditsGrantsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="createCreditGrantRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditGrant>> CreateAsync(
        string idOrAlias,
        CreateCreditGrantRequest createCreditGrantRequest,
        CreditsGrantsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credits.grants</c> operations. Get it from <see cref="CreditsApi.Grants"/>.</summary>
public sealed partial class CreditsGrantsApi : ICreditsGrantsApi
{
    internal CreditsGrantsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICreditsGrantsApi.WithRawResponse"/>
    public CreditsGrantsApiWithRawResponse WithRawResponse { get; }

    ICreditsGrantsApiWithRawResponse ICreditsGrantsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public AsyncPager<CreditsGrantsListPage, CreditGrant> ListAsync(
        string idOrAlias,
        CreditsGrantsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        return Paging.Numbered<CreditsGrantsListPage, CreditGrantListResponse, CreditGrant>(
            options?.Page ?? 0,
            0,
            pages: true,
            (param, ct) =>
                WithRawResponse.ListAsync(idOrAlias, (options ?? new()) with { Page = (int)param }, requestOptions, ct),
            (body, items, next) => new(body, items, next),
            body => body.Data,
            null,
            body => (long?)body.PaginationMeta?.TotalPages,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<CreditGrant> CreateAsync(
        string idOrAlias,
        CreateCreditGrantRequest createCreditGrantRequest,
        CreditsGrantsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(idOrAlias, createCreditGrantRequest, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>credits.grants</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CreditsGrantsApiWithRawResponse : ICreditsGrantsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CreditsGrantsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditGrantListResponse>> ListAsync(
        string idOrAlias,
        CreditsGrantsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/credit-grants",
            "credits_grants.list"
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
        request.AddQuery("status", options?.Status);
        request.AddQuery("subscription_id", options?.SubscriptionId);
        request.AddQuery("usable_by_subscription_id", options?.UsableBySubscriptionId);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditGrantListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditGrant>> CreateAsync(
        string idOrAlias,
        CreateCreditGrantRequest createCreditGrantRequest,
        CreditsGrantsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentNullException.ThrowIfNull(createCreditGrantRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/credit-grants",
            "credits_grants.create"
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
        request.SetJsonBody(createCreditGrantRequest, MeteroidJsonContext.Default.CreateCreditGrantRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditGrant,
            requestOptions,
            cancellationToken
        );
    }
}

/// <summary>A page of <see cref="CreditsGrantsApi.ListAsync"/>: its <see cref="CreditGrantListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class CreditsGrantsListPage : Page<CreditsGrantsListPage, CreditGrantListResponse, CreditGrant>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public CreditsGrantsListPage(
        CreditGrantListResponse body,
        IReadOnlyList<CreditGrant> items,
        Func<CancellationToken, Task<CreditsGrantsListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="CreditGrantListResponse.Data"/>
    public IReadOnlyList<CreditGrant> Data => Body.Data;

    /// <inheritdoc cref="CreditGrantListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
