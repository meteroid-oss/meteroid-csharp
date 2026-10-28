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

/// <summary>The <c>usage_costs</c> operations, as <see cref="IMeteroidClient.UsageCosts"/> exposes them; mock it in tests.</summary>
public interface IUsageCostsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IUsageCostsApiWithRawResponse WithRawResponse { get; }

    /// <summary>The <c>customer</c> operations.</summary>
    IUsageCostsCustomerApi Customer { get; }

    /// <summary>The <c>subscription</c> operations.</summary>
    IUsageCostsSubscriptionApi Subscription { get; }
}

/// <summary>The <c>usage_costs</c> operations, returning the status and headers of the response with its body.</summary>
public interface IUsageCostsApiWithRawResponse
{
    /// <summary>The <c>customer</c> operations, returning the status and headers of the response with its body.</summary>
    IUsageCostsCustomerApiWithRawResponse Customer { get; }

    /// <summary>The <c>subscription</c> operations, returning the status and headers of the response with its body.</summary>
    IUsageCostsSubscriptionApiWithRawResponse Subscription { get; }
}

/// <summary>The <c>usage_costs</c> operations. Get it from <see cref="MeteroidClient.UsageCosts"/>.</summary>
public sealed partial class UsageCostsApi : IUsageCostsApi
{
    internal UsageCostsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
        Customer = new(transport);
        Subscription = new(transport);
    }

    /// <inheritdoc cref="IUsageCostsApi.WithRawResponse"/>
    public UsageCostsApiWithRawResponse WithRawResponse { get; }

    IUsageCostsApiWithRawResponse IUsageCostsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc cref="IUsageCostsApi.Customer"/>
    public UsageCostsCustomerApi Customer { get; }

    IUsageCostsCustomerApi IUsageCostsApi.Customer => Customer;

    /// <inheritdoc cref="IUsageCostsApi.Subscription"/>
    public UsageCostsSubscriptionApi Subscription { get; }

    IUsageCostsSubscriptionApi IUsageCostsApi.Subscription => Subscription;
}

/// <summary>The <c>usage_costs</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class UsageCostsApiWithRawResponse : IUsageCostsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal UsageCostsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
        Customer = new(transport);
        Subscription = new(transport);
    }

    /// <inheritdoc cref="IUsageCostsApiWithRawResponse.Customer"/>
    public UsageCostsCustomerApiWithRawResponse Customer { get; }

    IUsageCostsCustomerApiWithRawResponse IUsageCostsApiWithRawResponse.Customer => Customer;

    /// <inheritdoc cref="IUsageCostsApiWithRawResponse.Subscription"/>
    public UsageCostsSubscriptionApiWithRawResponse Subscription { get; }

    IUsageCostsSubscriptionApiWithRawResponse IUsageCostsApiWithRawResponse.Subscription => Subscription;
}
