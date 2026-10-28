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

/// <summary>The <c>usage.customer</c> operations, as <see cref="IUsageApi.Customer"/> exposes them; mock it in tests.</summary>
public interface IUsageCustomerApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IUsageCustomerApiWithRawResponse WithRawResponse { get; }

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
    Task<UsageResponse> RetrieveAsync(
        string customerId,
        UsageCustomerRetrieveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get unattributed usage
    /// </summary>
    /// <remarks>
    /// Retrieve a customer's usage that no subscription bills. When subscriptions of the customer
    /// pricing a metric set a usage filter, events matching none of the filters are billed by a
    /// subscription without one; when every such subscription has a filter, those events are kept
    /// and reported here instead of being billed.
    /// </remarks>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UnattributedUsageResponse> RetrieveUnattributedAsync(
        string customerId,
        UsageCustomerRetrieveUnattributedOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage.customer</c> operations, returning the status and headers of the response with its body.</summary>
public interface IUsageCustomerApiWithRawResponse
{
    /// <summary><see cref="IUsageCustomerApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageResponse>> RetrieveAsync(
        string customerId,
        UsageCustomerRetrieveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IUsageCustomerApi.RetrieveUnattributedAsync"/>, with the status and headers of the response.</summary>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UnattributedUsageResponse>> RetrieveUnattributedAsync(
        string customerId,
        UsageCustomerRetrieveUnattributedOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage.customer</c> operations. Get it from <see cref="UsageApi.Customer"/>.</summary>
public sealed partial class UsageCustomerApi : IUsageCustomerApi
{
    internal UsageCustomerApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IUsageCustomerApi.WithRawResponse"/>
    public UsageCustomerApiWithRawResponse WithRawResponse { get; }

    IUsageCustomerApiWithRawResponse IUsageCustomerApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<UsageResponse> RetrieveAsync(
        string customerId,
        UsageCustomerRetrieveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(customerId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<UnattributedUsageResponse> RetrieveUnattributedAsync(
        string customerId,
        UsageCustomerRetrieveUnattributedOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveUnattributedAsync(customerId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>usage.customer</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class UsageCustomerApiWithRawResponse : IUsageCustomerApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal UsageCustomerApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageResponse>> RetrieveAsync(
        string customerId,
        UsageCustomerRetrieveOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(customerId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/customer/{Uri.EscapeDataString(customerId)}",
            "usage_customer.retrieve"
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
    public Task<ApiResponse<UnattributedUsageResponse>> RetrieveUnattributedAsync(
        string customerId,
        UsageCustomerRetrieveUnattributedOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(customerId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/customer/{Uri.EscapeDataString(customerId)}/unattributed",
            "usage_customer.retrieve_unattributed"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("start_date", options?.StartDate);
        request.AddQuery("end_date", options?.EndDate);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.UnattributedUsageResponse,
            requestOptions,
            cancellationToken
        );
    }
}
