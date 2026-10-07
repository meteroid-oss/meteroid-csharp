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

/// <summary>The <c>invoices</c> operations, as <see cref="IMeteroidClient.Invoices"/> exposes them; mock it in tests.</summary>
public interface IInvoicesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IInvoicesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List invoices with optional filtering by customer, subscription, or status.
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="InvoicesListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<InvoicesListPage, Invoice> ListAsync(
        InvoicesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get invoice
    /// </summary>
    /// <remarks>
    /// Retrieve a single invoice with its payment transactions.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Invoice> RetrieveAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update invoice custom properties
    /// </summary>
    /// <remarks>
    /// Merge custom property values onto an invoice (send a key with <c>null</c> to remove it).
    /// Values are validated against the tenant's <c>INVOICE</c> property definitions. Allowed at any
    /// status — custom properties are external workflow metadata and stay editable after the invoice
    /// is finalized.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="invoiceCustomPropertiesRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Invoice> UpdateCustomPropertiesAsync(
        string invoiceId,
        InvoiceCustomPropertiesRequest invoiceCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Download invoice PDF
    /// </summary>
    /// <remarks>
    /// Download the PDF document for an invoice.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<byte[]> DownloadAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Refresh invoice
    /// </summary>
    /// <remarks>
    /// Recompute a draft invoice against current usage, credits, coupons and tax, and return it.
    /// Drafts are also refreshed periodically in the background; use this to force it, e.g. after
    /// ingesting late events. Rejected while a payment for the invoice is in progress or when the
    /// invoice was merged into a consolidated parent.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Invoice> RefreshAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Download invoice e-invoice XML
    /// </summary>
    /// <remarks>
    /// Download the structured e-invoice (EN 16931 XML) issued with an invoice. For
    /// Factur-X the same XML is also embedded in the PDF.
    /// </remarks>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<byte[]> DownloadXmlAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>invoices</c> operations, returning the status and headers of the response with its body.</summary>
public interface IInvoicesApiWithRawResponse
{
    /// <summary>The single request of a page of <see cref="IInvoicesApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<InvoiceListResponse>> ListAsync(
        InvoicesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IInvoicesApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Invoice>> RetrieveAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IInvoicesApi.UpdateCustomPropertiesAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="invoiceCustomPropertiesRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Invoice>> UpdateCustomPropertiesAsync(
        string invoiceId,
        InvoiceCustomPropertiesRequest invoiceCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IInvoicesApi.DownloadAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<byte[]>> DownloadAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IInvoicesApi.RefreshAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Invoice>> RefreshAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IInvoicesApi.DownloadXmlAsync"/>, with the status and headers of the response.</summary>
    /// <param name="invoiceId">The <c>invoice_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<byte[]>> DownloadXmlAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>invoices</c> operations. Get it from <see cref="MeteroidClient.Invoices"/>.</summary>
public sealed partial class InvoicesApi : IInvoicesApi
{
    internal InvoicesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IInvoicesApi.WithRawResponse"/>
    public InvoicesApiWithRawResponse WithRawResponse { get; }

    IInvoicesApiWithRawResponse IInvoicesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public AsyncPager<InvoicesListPage, Invoice> ListAsync(
        InvoicesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        return Paging.Numbered<InvoicesListPage, InvoiceListResponse, Invoice>(
            options?.Page ?? 0,
            0,
            pages: true,
            (param, ct) => WithRawResponse.ListAsync((options ?? new()) with { Page = (int)param }, requestOptions, ct),
            (body, items, next) => new(body, items, next),
            body => body.Data,
            null,
            body => (long?)body.PaginationMeta?.TotalPages,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<Invoice> RetrieveAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(invoiceId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Invoice> UpdateCustomPropertiesAsync(
        string invoiceId,
        InvoiceCustomPropertiesRequest invoiceCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateCustomPropertiesAsync(invoiceId, invoiceCustomPropertiesRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<byte[]> DownloadAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .DownloadAsync(invoiceId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Invoice> RefreshAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RefreshAsync(invoiceId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<byte[]> DownloadXmlAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .DownloadXmlAsync(invoiceId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>invoices</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class InvoicesApiWithRawResponse : IInvoicesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal InvoicesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<InvoiceListResponse>> ListAsync(
        InvoicesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/invoices", "invoices.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("customer_id", options?.CustomerId);
        request.AddQuery("subscription_id", options?.SubscriptionId);
        request.AddQuery("statuses", options?.Statuses);
        request.AddQuery("einvoicing_status", options?.EinvoicingStatus);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.InvoiceListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Invoice>> RetrieveAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}",
            "invoices.retrieve"
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
            MeteroidJsonContext.Default.Invoice,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Invoice>> UpdateCustomPropertiesAsync(
        string invoiceId,
        InvoiceCustomPropertiesRequest invoiceCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);
        ArgumentNullException.ThrowIfNull(invoiceCustomPropertiesRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}/custom-properties",
            "invoices.update_custom_properties"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(invoiceCustomPropertiesRequest, MeteroidJsonContext.Default.InvoiceCustomPropertiesRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Invoice,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<byte[]>> DownloadAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}/download",
            "invoices.download"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendBytesAsync(request, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Invoice>> RefreshAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}/refresh",
            "invoices.refresh"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Invoice,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<byte[]>> DownloadXmlAsync(
        string invoiceId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(invoiceId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/invoices/{Uri.EscapeDataString(invoiceId)}/xml",
            "invoices.download_xml"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendBytesAsync(request, requestOptions, cancellationToken);
    }
}

/// <summary>A page of <see cref="InvoicesApi.ListAsync"/>: its <see cref="InvoiceListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class InvoicesListPage : Page<InvoicesListPage, InvoiceListResponse, Invoice>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public InvoicesListPage(
        InvoiceListResponse body,
        IReadOnlyList<Invoice> items,
        Func<CancellationToken, Task<InvoicesListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="InvoiceListResponse.Data"/>
    public IReadOnlyList<Invoice> Data => Body.Data;

    /// <inheritdoc cref="InvoiceListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
