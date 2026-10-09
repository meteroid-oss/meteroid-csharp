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

/// <summary>The <c>webhook_endpoints</c> operations, as <see cref="IMeteroidClient.WebhookEndpoints"/> exposes them; mock it in tests.</summary>
public interface IWebhookEndpointsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IWebhookEndpointsApiWithRawResponse WithRawResponse { get; }

    /// <summary>The <c>endpoints</c> operations.</summary>
    IWebhookEndpointsEndpointsApi Endpoints { get; }

    /// <summary>
    /// Resend a webhook delivery
    /// </summary>
    /// <remarks>
    /// Re-queues the same event for the same endpoint. Fails if the endpoint is disabled.
    /// </remarks>
    /// <param name="deliveryId">The <c>delivery_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WebhookDelivery> ResendWebhookDeliveryAsync(
        string deliveryId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>webhook_endpoints</c> operations, returning the status and headers of the response with its body.</summary>
public interface IWebhookEndpointsApiWithRawResponse
{
    /// <summary>The <c>endpoints</c> operations, returning the status and headers of the response with its body.</summary>
    IWebhookEndpointsEndpointsApiWithRawResponse Endpoints { get; }

    /// <summary><see cref="IWebhookEndpointsApi.ResendWebhookDeliveryAsync"/>, with the status and headers of the response.</summary>
    /// <param name="deliveryId">The <c>delivery_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookDelivery>> ResendWebhookDeliveryAsync(
        string deliveryId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>webhook_endpoints</c> operations. Get it from <see cref="MeteroidClient.WebhookEndpoints"/>.</summary>
public sealed partial class WebhookEndpointsApi : IWebhookEndpointsApi
{
    internal WebhookEndpointsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
        Endpoints = new(transport);
    }

    /// <inheritdoc cref="IWebhookEndpointsApi.WithRawResponse"/>
    public WebhookEndpointsApiWithRawResponse WithRawResponse { get; }

    IWebhookEndpointsApiWithRawResponse IWebhookEndpointsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc cref="IWebhookEndpointsApi.Endpoints"/>
    public WebhookEndpointsEndpointsApi Endpoints { get; }

    IWebhookEndpointsEndpointsApi IWebhookEndpointsApi.Endpoints => Endpoints;

    /// <inheritdoc/>
    public async Task<WebhookDelivery> ResendWebhookDeliveryAsync(
        string deliveryId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ResendWebhookDeliveryAsync(deliveryId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>webhook_endpoints</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class WebhookEndpointsApiWithRawResponse : IWebhookEndpointsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal WebhookEndpointsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
        Endpoints = new(transport);
    }

    /// <inheritdoc cref="IWebhookEndpointsApiWithRawResponse.Endpoints"/>
    public WebhookEndpointsEndpointsApiWithRawResponse Endpoints { get; }

    IWebhookEndpointsEndpointsApiWithRawResponse IWebhookEndpointsApiWithRawResponse.Endpoints => Endpoints;

    /// <inheritdoc/>
    public Task<ApiResponse<WebhookDelivery>> ResendWebhookDeliveryAsync(
        string deliveryId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(deliveryId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/webhooks/deliveries/{Uri.EscapeDataString(deliveryId)}/resend",
            "webhook_endpoints.resend_webhook_delivery"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookDelivery,
            requestOptions,
            cancellationToken
        );
    }
}
