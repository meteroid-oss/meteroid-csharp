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
    /// double-counted. If timestamps differ across duplicates, the event with the latest timestamp is used.
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
}
