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

/// <summary>The <c>credit_notes</c> operations, as <see cref="IMeteroidClient.CreditNotes"/> exposes them; mock it in tests.</summary>
public interface ICreditNotesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICreditNotesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List credit notes
    /// </summary>
    /// <remarks>
    /// List a tenant's credit notes, optionally filtered by customer, invoice or status.
    /// </remarks>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditNoteListResponse> ListAsync(
        CreditNotesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get credit note
    /// </summary>
    /// <remarks>
    /// Retrieve a single credit note by ID.
    /// </remarks>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditNote> RetrieveAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update credit note custom properties
    /// </summary>
    /// <remarks>
    /// Merge custom property values onto a credit note (send a key with <c>null</c> to remove it).
    /// Values are validated against the tenant's <c>CREDIT_NOTE</c> property definitions. Allowed at any
    /// status — custom properties are external workflow metadata and stay editable after the credit
    /// note is finalized.
    /// </remarks>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="creditNoteCustomPropertiesRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreditNote> UpdateCustomPropertiesAsync(
        string creditNoteId,
        CreditNoteCustomPropertiesRequest creditNoteCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>Calls <c>GET /api/v1/credit-notes/{credit_note_id}/download</c>.</summary>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<byte[]> DownloadAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Download credit note e-invoice XML
    /// </summary>
    /// <remarks>
    /// Download the structured e-invoice (EN 16931 XML) issued with a credit note. For
    /// Factur-X the same XML is also embedded in the PDF.
    /// </remarks>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<byte[]> DownloadXmlAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credit_notes</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICreditNotesApiWithRawResponse
{
    /// <summary><see cref="ICreditNotesApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditNoteListResponse>> ListAsync(
        CreditNotesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditNotesApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditNote>> RetrieveAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditNotesApi.UpdateCustomPropertiesAsync"/>, with the status and headers of the response.</summary>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="creditNoteCustomPropertiesRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreditNote>> UpdateCustomPropertiesAsync(
        string creditNoteId,
        CreditNoteCustomPropertiesRequest creditNoteCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditNotesApi.DownloadAsync"/>, with the status and headers of the response.</summary>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<byte[]>> DownloadAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditNotesApi.DownloadXmlAsync"/>, with the status and headers of the response.</summary>
    /// <param name="creditNoteId">The <c>credit_note_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<byte[]>> DownloadXmlAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credit_notes</c> operations. Get it from <see cref="MeteroidClient.CreditNotes"/>.</summary>
public sealed partial class CreditNotesApi : ICreditNotesApi
{
    internal CreditNotesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICreditNotesApi.WithRawResponse"/>
    public CreditNotesApiWithRawResponse WithRawResponse { get; }

    ICreditNotesApiWithRawResponse ICreditNotesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<CreditNoteListResponse> ListAsync(
        CreditNotesListOptions? options = null,
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
    public async Task<CreditNote> RetrieveAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(creditNoteId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CreditNote> UpdateCustomPropertiesAsync(
        string creditNoteId,
        CreditNoteCustomPropertiesRequest creditNoteCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateCustomPropertiesAsync(
                creditNoteId,
                creditNoteCustomPropertiesRequest,
                requestOptions,
                cancellationToken
            )
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<byte[]> DownloadAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .DownloadAsync(creditNoteId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<byte[]> DownloadXmlAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .DownloadXmlAsync(creditNoteId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>credit_notes</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CreditNotesApiWithRawResponse : ICreditNotesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CreditNotesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditNoteListResponse>> ListAsync(
        CreditNotesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/credit-notes", "credit_notes.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("customer_id", options?.CustomerId);
        request.AddQuery("invoice_id", options?.InvoiceId);
        request.AddQuery("status", options?.Status);
        request.AddQuery("search", options?.Search);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditNoteListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditNote>> RetrieveAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(creditNoteId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/credit-notes/{Uri.EscapeDataString(creditNoteId)}",
            "credit_notes.retrieve"
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
            MeteroidJsonContext.Default.CreditNote,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreditNote>> UpdateCustomPropertiesAsync(
        string creditNoteId,
        CreditNoteCustomPropertiesRequest creditNoteCustomPropertiesRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(creditNoteId);
        ArgumentNullException.ThrowIfNull(creditNoteCustomPropertiesRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/credit-notes/{Uri.EscapeDataString(creditNoteId)}/custom-properties",
            "credit_notes.update_custom_properties"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(
            creditNoteCustomPropertiesRequest,
            MeteroidJsonContext.Default.CreditNoteCustomPropertiesRequest
        );
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreditNote,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<byte[]>> DownloadAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(creditNoteId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/credit-notes/{Uri.EscapeDataString(creditNoteId)}/download",
            "credit_notes.download"
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
    public Task<ApiResponse<byte[]>> DownloadXmlAsync(
        string creditNoteId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(creditNoteId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/credit-notes/{Uri.EscapeDataString(creditNoteId)}/xml",
            "credit_notes.download_xml"
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
