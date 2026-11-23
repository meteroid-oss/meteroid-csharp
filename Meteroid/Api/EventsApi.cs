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

/// <summary>The <c>events</c> operations, as <see cref="IMeteroidClient.Events"/> exposes them; mock it in tests.</summary>
public interface IEventsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IEventsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Ingest events
    /// </summary>
    /// <remarks>
    /// <para>
    /// Ingest usage events for metering and billing purposes.
    /// </para>
    /// <para>
    /// Events are deduplicated by <c>(event_id, customer_id)</c> — re-sending the same pair will not be
    /// double-counted. The first copy received is kept and later copies are ignored, whatever they change.
    /// </para>
    /// <para>
    /// By default, any invalid event rejects the entire batch. Set <c>allow_partial_failures</c> to <c>true</c> to ingest valid events and receive per-event failure details in the response body.
    /// </para>
    /// </remarks>
    /// <param name="ingestEventsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<IngestEventsResponse> IngestAsync(
        IngestEventsRequest ingestEventsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Amend an event
    /// </summary>
    /// <remarks>
    /// <para>
    /// Replaces the timestamp and the properties of an ingested event. The code and the customer
    /// cannot change: void the event and send a new one instead. The change is applied asynchronously,
    /// in order with the event's other copies.
    /// </para>
    /// <para>
    /// Only events ingested in the last 35 days can be amended, and neither their current nor their
    /// new timestamp can be in an invoiced period. Tenants that keep the last copy of an event correct
    /// it by sending it again instead.
    /// </para>
    /// <para>
    /// An event is found once metering has stored it: a just-ingested event can still return <c>404</c>.
    /// Wait until an amend is visible before sending the next change to the same event; concurrent
    /// changes resolve by <c>ingested_at</c>, the latest wins.
    /// </para>
    /// </remarks>
    /// <param name="eventId">The <c>event_id</c> path parameter.</param>
    /// <param name="amendEventRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500, 503: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500, 503: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EventChangeResponse> AmendAsync(
        string eventId,
        AmendEventRequest amendEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Void an event
    /// </summary>
    /// <remarks>
    /// <para>
    /// Cancels an ingested event: it no longer counts in usage. The change is applied asynchronously,
    /// in order with the event's other copies.
    /// </para>
    /// <para>
    /// Only events ingested in the last 35 days, outside an invoiced period, can be voided. Tenants
    /// that keep the last copy of an event correct it by sending it again instead.
    /// </para>
    /// <para>
    /// An event is found once metering has stored it: a just-ingested event can still return <c>404</c>,
    /// and so does a retried void once the first one is applied. Wait until a change is visible
    /// before sending the next one to the same event; concurrent changes resolve by <c>ingested_at</c>.
    /// </para>
    /// </remarks>
    /// <param name="eventId">The <c>event_id</c> path parameter.</param>
    /// <param name="voidEventRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ForbiddenException">403: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500, 503: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500, 503: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EventChangeResponse> VoidAsync(
        string eventId,
        VoidEventRequest voidEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>events</c> operations, returning the status and headers of the response with its body.</summary>
public interface IEventsApiWithRawResponse
{
    /// <summary><see cref="IEventsApi.IngestAsync"/>, with the status and headers of the response.</summary>
    /// <param name="ingestEventsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<IngestEventsResponse>> IngestAsync(
        IngestEventsRequest ingestEventsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IEventsApi.AmendAsync"/>, with the status and headers of the response.</summary>
    /// <param name="eventId">The <c>event_id</c> path parameter.</param>
    /// <param name="amendEventRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EventChangeResponse>> AmendAsync(
        string eventId,
        AmendEventRequest amendEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IEventsApi.VoidAsync"/>, with the status and headers of the response.</summary>
    /// <param name="eventId">The <c>event_id</c> path parameter.</param>
    /// <param name="voidEventRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EventChangeResponse>> VoidAsync(
        string eventId,
        VoidEventRequest voidEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>events</c> operations. Get it from <see cref="MeteroidClient.Events"/>.</summary>
public sealed partial class EventsApi : IEventsApi
{
    internal EventsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IEventsApi.WithRawResponse"/>
    public EventsApiWithRawResponse WithRawResponse { get; }

    IEventsApiWithRawResponse IEventsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<IngestEventsResponse> IngestAsync(
        IngestEventsRequest ingestEventsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .IngestAsync(ingestEventsRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EventChangeResponse> AmendAsync(
        string eventId,
        AmendEventRequest amendEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .AmendAsync(eventId, amendEventRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EventChangeResponse> VoidAsync(
        string eventId,
        VoidEventRequest voidEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .VoidAsync(eventId, voidEventRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>events</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class EventsApiWithRawResponse : IEventsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal EventsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<IngestEventsResponse>> IngestAsync(
        IngestEventsRequest ingestEventsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(ingestEventsRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/events/ingest", "events.ingest");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(ingestEventsRequest, MeteroidJsonContext.Default.IngestEventsRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.IngestEventsResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<EventChangeResponse>> AmendAsync(
        string eventId,
        AmendEventRequest amendEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(eventId);
        ArgumentNullException.ThrowIfNull(amendEventRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/events/{Uri.EscapeDataString(eventId)}/amend",
            "events.amend"
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
            new("503", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(amendEventRequest, MeteroidJsonContext.Default.AmendEventRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.EventChangeResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<EventChangeResponse>> VoidAsync(
        string eventId,
        VoidEventRequest voidEventRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(eventId);
        ArgumentNullException.ThrowIfNull(voidEventRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/events/{Uri.EscapeDataString(eventId)}/void",
            "events.void"
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
            new("503", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(voidEventRequest, MeteroidJsonContext.Default.VoidEventRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.EventChangeResponse,
            requestOptions,
            cancellationToken
        );
    }
}
