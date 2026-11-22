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

/// <summary>The <c>invoices.payments</c> operations, as <see cref="IInvoicesApi.Payments"/> exposes them; mock it in tests.</summary>
public interface IInvoicesPaymentsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IInvoicesPaymentsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Record an invoice payment
    /// </summary>
    /// <remarks>
    /// Record a partial or full payment received outside Meteroid against a finalized invoice.
    /// Paying the remaining balance marks the invoice paid.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="recordInvoicePaymentRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Transaction> CreateAsync(
        string invoiceId,
        RecordInvoicePaymentRequest recordInvoicePaymentRequest,
        InvoicesPaymentsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reverse an invoice payment
    /// </summary>
    /// <remarks>
    /// Record the full reversal of a settled manual payment.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="transactionId">The <c>transaction_id</c> path parameter.</param>
    /// <param name="reverseInvoicePaymentRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Transaction> ReverseAsync(
        string invoiceId,
        string transactionId,
        ReverseInvoicePaymentRequest reverseInvoicePaymentRequest,
        InvoicesPaymentsReverseOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>invoices.payments</c> operations, returning the status and headers of the response with its body.</summary>
public interface IInvoicesPaymentsApiWithRawResponse
{
    /// <summary><see cref="IInvoicesPaymentsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="recordInvoicePaymentRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Transaction>> CreateAsync(
        string invoiceId,
        RecordInvoicePaymentRequest recordInvoicePaymentRequest,
        InvoicesPaymentsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IInvoicesPaymentsApi.ReverseAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="transactionId">The <c>transaction_id</c> path parameter.</param>
    /// <param name="reverseInvoicePaymentRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Transaction>> ReverseAsync(
        string invoiceId,
        string transactionId,
        ReverseInvoicePaymentRequest reverseInvoicePaymentRequest,
        InvoicesPaymentsReverseOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>invoices.payments</c> operations. Get it from <see cref="InvoicesApi.Payments"/>.</summary>
public sealed partial class InvoicesPaymentsApi : IInvoicesPaymentsApi
{
    internal InvoicesPaymentsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IInvoicesPaymentsApi.WithRawResponse"/>
    public InvoicesPaymentsApiWithRawResponse WithRawResponse { get; }

    IInvoicesPaymentsApiWithRawResponse IInvoicesPaymentsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<Transaction> CreateAsync(
        string invoiceId,
        RecordInvoicePaymentRequest recordInvoicePaymentRequest,
        InvoicesPaymentsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(invoiceId, recordInvoicePaymentRequest, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Transaction> ReverseAsync(
        string invoiceId,
        string transactionId,
        ReverseInvoicePaymentRequest reverseInvoicePaymentRequest,
        InvoicesPaymentsReverseOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ReverseAsync(
                invoiceId,
                transactionId,
                reverseInvoicePaymentRequest,
                options,
                requestOptions,
                cancellationToken
            )
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>invoices.payments</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class InvoicesPaymentsApiWithRawResponse : IInvoicesPaymentsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal InvoicesPaymentsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Transaction>> CreateAsync(
        string invoiceId,
        RecordInvoicePaymentRequest recordInvoicePaymentRequest,
        InvoicesPaymentsCreateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);
        ArgumentNullException.ThrowIfNull(recordInvoicePaymentRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}/payments",
            "invoices_payments.create"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("403", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetHeader("Idempotency-Key", options.IdempotencyKey);
        request.SetJsonBody(recordInvoicePaymentRequest, MeteroidJsonContext.Default.RecordInvoicePaymentRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Transaction,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Transaction>> ReverseAsync(
        string invoiceId,
        string transactionId,
        ReverseInvoicePaymentRequest reverseInvoicePaymentRequest,
        InvoicesPaymentsReverseOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);
        ArgumentException.ThrowIfNullOrEmpty(transactionId);
        ArgumentNullException.ThrowIfNull(reverseInvoicePaymentRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}/payments/{Uri.EscapeDataString(transactionId)}/reverse",
            "invoices_payments.reverse"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("403", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetHeader("Idempotency-Key", options.IdempotencyKey);
        request.SetJsonBody(reverseInvoicePaymentRequest, MeteroidJsonContext.Default.ReverseInvoicePaymentRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Transaction,
            requestOptions,
            cancellationToken
        );
    }
}
