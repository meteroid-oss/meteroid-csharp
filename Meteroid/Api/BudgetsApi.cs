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

/// <summary>The <c>budgets</c> operations, as <see cref="IMeteroidClient.Budgets"/> exposes them; mock it in tests.</summary>
public interface IBudgetsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IBudgetsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List budgets
    /// </summary>
    /// <remarks>
    /// <para>
    /// A customer's budgets, oldest first, with their estimated spend in the current billing period.
    /// Archived ones are left out unless requested.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="BudgetsListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<BudgetsListPage, Budget> ListAsync(
        string idOrAlias,
        BudgetsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a budget
    /// </summary>
    /// <remarks>
    /// <para>
    /// Sets a spending limit for one currency the customer is billed in, with alerts at percentages
    /// of it, on the customer's whole spend or on one subscription's. A customer has one active
    /// budget per currency, and per subscription.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="createBudgetRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Budget> CreateAsync(
        string idOrAlias,
        CreateBudgetRequest createBudgetRequest,
        BudgetsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a budget
    /// </summary>
    /// <remarks>
    /// <para>
    /// Changes the amount, thresholds or behavior. Send the <c>version</c> you read as <c>expected_version</c>; a newer
    /// stored version, for instance after the customer edited it, is refused with 409.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="budgetId">The <c>budget_id</c> path parameter.</param>
    /// <param name="patchBudgetRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Budget> UpdateAsync(
        string idOrAlias,
        string budgetId,
        PatchBudgetRequest patchBudgetRequest,
        BudgetsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a budget
    /// </summary>
    /// <remarks>
    /// <para>
    /// Stops the budget from sending alerts and, for a HARD budget, from refusing access. Archiving an
    /// archived budget returns it unchanged.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="budgetId">The <c>budget_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Budget> ArchiveAsync(
        string idOrAlias,
        string budgetId,
        BudgetsArchiveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>budgets</c> operations, returning the status and headers of the response with its body.</summary>
public interface IBudgetsApiWithRawResponse
{
    /// <summary>The single request of a page of <see cref="IBudgetsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<BudgetListResponse>> ListAsync(
        string idOrAlias,
        BudgetsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IBudgetsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="createBudgetRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Budget>> CreateAsync(
        string idOrAlias,
        CreateBudgetRequest createBudgetRequest,
        BudgetsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IBudgetsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="budgetId">The <c>budget_id</c> path parameter.</param>
    /// <param name="patchBudgetRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Budget>> UpdateAsync(
        string idOrAlias,
        string budgetId,
        PatchBudgetRequest patchBudgetRequest,
        BudgetsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IBudgetsApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="budgetId">The <c>budget_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Budget>> ArchiveAsync(
        string idOrAlias,
        string budgetId,
        BudgetsArchiveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>budgets</c> operations. Get it from <see cref="MeteroidClient.Budgets"/>.</summary>
public sealed partial class BudgetsApi : IBudgetsApi
{
    internal BudgetsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IBudgetsApi.WithRawResponse"/>
    public BudgetsApiWithRawResponse WithRawResponse { get; }

    IBudgetsApiWithRawResponse IBudgetsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public AsyncPager<BudgetsListPage, Budget> ListAsync(
        string idOrAlias,
        BudgetsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        return Paging.Numbered<BudgetsListPage, BudgetListResponse, Budget>(
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
    public async Task<Budget> CreateAsync(
        string idOrAlias,
        CreateBudgetRequest createBudgetRequest,
        BudgetsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(idOrAlias, createBudgetRequest, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Budget> UpdateAsync(
        string idOrAlias,
        string budgetId,
        PatchBudgetRequest patchBudgetRequest,
        BudgetsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(idOrAlias, budgetId, patchBudgetRequest, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Budget> ArchiveAsync(
        string idOrAlias,
        string budgetId,
        BudgetsArchiveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ArchiveAsync(idOrAlias, budgetId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>budgets</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class BudgetsApiWithRawResponse : IBudgetsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal BudgetsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<BudgetListResponse>> ListAsync(
        string idOrAlias,
        BudgetsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/budgets",
            "budgets.list"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("include_archived", options?.IncludeArchived);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.BudgetListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Budget>> CreateAsync(
        string idOrAlias,
        CreateBudgetRequest createBudgetRequest,
        BudgetsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentNullException.ThrowIfNull(createBudgetRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/budgets",
            "budgets.create"
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
        request.SetJsonBody(createBudgetRequest, MeteroidJsonContext.Default.CreateBudgetRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Budget, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Budget>> UpdateAsync(
        string idOrAlias,
        string budgetId,
        PatchBudgetRequest patchBudgetRequest,
        BudgetsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentException.ThrowIfNullOrEmpty(budgetId);
        ArgumentNullException.ThrowIfNull(patchBudgetRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/budgets/{Uri.EscapeDataString(budgetId)}",
            "budgets.update"
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
        request.SetJsonBody(patchBudgetRequest, MeteroidJsonContext.Default.PatchBudgetRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Budget, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Budget>> ArchiveAsync(
        string idOrAlias,
        string budgetId,
        BudgetsArchiveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentException.ThrowIfNullOrEmpty(budgetId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/budgets/{Uri.EscapeDataString(budgetId)}/archive",
            "budgets.archive"
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
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Budget, requestOptions, cancellationToken);
    }
}

/// <summary>A page of <see cref="BudgetsApi.ListAsync"/>: its <see cref="BudgetListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class BudgetsListPage : Page<BudgetsListPage, BudgetListResponse, Budget>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public BudgetsListPage(
        BudgetListResponse body,
        IReadOnlyList<Budget> items,
        Func<CancellationToken, Task<BudgetsListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="BudgetListResponse.Data"/>
    public IReadOnlyList<Budget> Data => Body.Data;

    /// <inheritdoc cref="BudgetListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
