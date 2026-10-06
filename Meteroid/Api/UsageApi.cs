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

/// <summary>The <c>usage</c> operations, as <see cref="IMeteroidClient.Usage"/> exposes them; mock it in tests.</summary>
public interface IUsageApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IUsageApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Get customer usage
    /// </summary>
    /// <remarks>
    /// Retrieve aggregated usage data for a customer over a specified period.
    /// </remarks>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageResponse> RetrieveCustomerAsync(
        string customerId,
        UsageRetrieveCustomerOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get subscription usage
    /// </summary>
    /// <remarks>
    /// Retrieve aggregated usage data for a subscription's usage-based components.
    /// If start_date/end_date are omitted, defaults to the current billing period.
    /// </remarks>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageResponse> RetrieveSubscriptionAsync(
        string subscriptionId,
        UsageRetrieveSubscriptionOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get usage summary
    /// </summary>
    /// <remarks>
    /// Retrieve aggregated usage data across all customers for the tenant.
    /// </remarks>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageResponse> RetrieveSummaryAsync(
        UsageRetrieveSummaryOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage</c> operations, returning the status and headers of the response with its body.</summary>
public interface IUsageApiWithRawResponse
{
    /// <summary><see cref="IUsageApi.RetrieveCustomerAsync"/>, with the status and headers of the response.</summary>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageResponse>> RetrieveCustomerAsync(
        string customerId,
        UsageRetrieveCustomerOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IUsageApi.RetrieveSubscriptionAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageResponse>> RetrieveSubscriptionAsync(
        string subscriptionId,
        UsageRetrieveSubscriptionOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IUsageApi.RetrieveSummaryAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageResponse>> RetrieveSummaryAsync(
        UsageRetrieveSummaryOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage</c> operations. Get it from <see cref="MeteroidClient.Usage"/>.</summary>
public sealed partial class UsageApi : IUsageApi
{
    internal UsageApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IUsageApi.WithRawResponse"/>
    public UsageApiWithRawResponse WithRawResponse { get; }

    IUsageApiWithRawResponse IUsageApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<UsageResponse> RetrieveCustomerAsync(
        string customerId,
        UsageRetrieveCustomerOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveCustomerAsync(customerId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<UsageResponse> RetrieveSubscriptionAsync(
        string subscriptionId,
        UsageRetrieveSubscriptionOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveSubscriptionAsync(subscriptionId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<UsageResponse> RetrieveSummaryAsync(
        UsageRetrieveSummaryOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveSummaryAsync(options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>usage</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class UsageApiWithRawResponse : IUsageApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal UsageApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageResponse>> RetrieveCustomerAsync(
        string customerId,
        UsageRetrieveCustomerOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(customerId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/customer/{Uri.EscapeDataString(customerId)}",
            "usage.retrieve_customer"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("start_date", options.StartDate);
        request.AddQuery("end_date", options.EndDate);
        request.AddQuery("metric_id", options.MetricId);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.UsageResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageResponse>> RetrieveSubscriptionAsync(
        string subscriptionId,
        UsageRetrieveSubscriptionOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/subscription/{Uri.EscapeDataString(subscriptionId)}",
            "usage.retrieve_subscription"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("start_date", options?.StartDate);
        request.AddQuery("end_date", options?.EndDate);
        request.AddQuery("metric_id", options?.MetricId);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.UsageResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageResponse>> RetrieveSummaryAsync(
        UsageRetrieveSummaryOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(HttpMethod.Get, "/api/v1/usage/summary", "usage.retrieve_summary");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("start_date", options.StartDate);
        request.AddQuery("end_date", options.EndDate);
        request.AddQuery("metric_id", options.MetricId);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.UsageResponse,
            requestOptions,
            cancellationToken
        );
    }
}
