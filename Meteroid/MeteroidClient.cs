// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Meteroid;

/// <summary>The Meteroid API, as <see cref="MeteroidClient"/> implements it; mock it in tests.</summary>
public interface IMeteroidClient : IDisposable
{
    /// <summary>The <c>add_ons</c> operations.</summary>
    IAddOnsApi AddOns { get; }

    /// <summary>The <c>batch_jobs</c> operations.</summary>
    IBatchJobsApi BatchJobs { get; }

    /// <summary>The <c>checkout_sessions</c> operations.</summary>
    ICheckoutSessionsApi CheckoutSessions { get; }

    /// <summary>The <c>connect</c> operations.</summary>
    IConnectApi Connect { get; }

    /// <summary>The <c>coupons</c> operations.</summary>
    ICouponsApi Coupons { get; }

    /// <summary>The <c>credit_notes</c> operations.</summary>
    ICreditNotesApi CreditNotes { get; }

    /// <summary>The <c>custom_properties</c> operations.</summary>
    ICustomPropertiesApi CustomProperties { get; }

    /// <summary>The <c>customers</c> operations.</summary>
    ICustomersApi Customers { get; }

    /// <summary>The <c>entitlements</c> operations.</summary>
    IEntitlementsApi Entitlements { get; }

    /// <summary>The <c>events</c> operations.</summary>
    IEventsApi Events { get; }

    /// <summary>The <c>features</c> operations.</summary>
    IFeaturesApi Features { get; }

    /// <summary>The <c>invoices</c> operations.</summary>
    IInvoicesApi Invoices { get; }

    /// <summary>The <c>metrics</c> operations.</summary>
    IMetricsApi Metrics { get; }

    /// <summary>The <c>oauth</c> operations.</summary>
    IOauthApi Oauth { get; }

    /// <summary>The <c>oauth_apps</c> operations.</summary>
    IOauthAppsApi OauthApps { get; }

    /// <summary>The <c>plans</c> operations.</summary>
    IPlansApi Plans { get; }

    /// <summary>The <c>product_families</c> operations.</summary>
    IProductFamiliesApi ProductFamilies { get; }

    /// <summary>The <c>products</c> operations.</summary>
    IProductsApi Products { get; }

    /// <summary>The <c>subscriptions</c> operations.</summary>
    ISubscriptionsApi Subscriptions { get; }

    /// <summary>The <c>usage</c> operations.</summary>
    IUsageApi Usage { get; }

    /// <summary>The <c>webhook_endpoints</c> operations.</summary>
    IWebhookEndpointsApi WebhookEndpoints { get; }
}

/// <summary>
/// Entry point of the Meteroid API. Thread-safe: create one and reuse it.
/// </summary>
/// <example>
/// <code>
/// using var client = new MeteroidClient(); // reads METEROID_API_KEY
/// </code>
/// With <c>IHttpClientFactory</c>: <c>new MeteroidClient(factory.CreateClient("meteroid"), "your-api-key")</c>.
/// </example>
public sealed partial class MeteroidClient : IMeteroidClient
{
    private static readonly ApiAuth s_auth = new(
        new Dictionary<string, SecurityScheme> { ["bearer_auth"] = new(SchemeKind.Bearer) },
        [
            ["bearer_auth"],
        ]
    );

    private readonly ApiTransport _transport;

    /// <summary>Creates a client with its own connection pool.</summary>
    /// <param name="token">The bearer token; when null, <c>Token</c> of the options, else the <c>METEROID_API_KEY</c> environment variable.</param>
    /// <param name="options">Base URL, timeout, retries, middleware and credentials.</param>
    public MeteroidClient(string? token = null, MeteroidClientOptions? options = null)
    {
        _transport = CreateTransport(token, options ?? new(), http: null);
        AddOns = new(_transport);
        BatchJobs = new(_transport);
        CheckoutSessions = new(_transport);
        Connect = new(_transport);
        Coupons = new(_transport);
        CreditNotes = new(_transport);
        CustomProperties = new(_transport);
        Customers = new(_transport);
        Entitlements = new(_transport);
        Events = new(_transport);
        Features = new(_transport);
        Invoices = new(_transport);
        Metrics = new(_transport);
        Oauth = new(_transport);
        OauthApps = new(_transport);
        Plans = new(_transport);
        ProductFamilies = new(_transport);
        Products = new(_transport);
        Subscriptions = new(_transport);
        Usage = new(_transport);
        WebhookEndpoints = new(_transport);
    }

    /// <summary>
    /// Creates a client sending requests through <paramref name="httpClient"/>, for instance one from
    /// <c>IHttpClientFactory</c>. The caller keeps ownership of it.
    /// </summary>
    /// <param name="httpClient">The HTTP client, whose own <c>Timeout</c> also applies.</param>
    /// <param name="token">The bearer token; when null, <c>Token</c> of the options, else the <c>METEROID_API_KEY</c> environment variable.</param>
    /// <param name="options">Base URL, timeout, retries, middleware and credentials.</param>
    public MeteroidClient(HttpClient httpClient, string? token, MeteroidClientOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        _transport = CreateTransport(token, options ?? new(), httpClient);
        AddOns = new(_transport);
        BatchJobs = new(_transport);
        CheckoutSessions = new(_transport);
        Connect = new(_transport);
        Coupons = new(_transport);
        CreditNotes = new(_transport);
        CustomProperties = new(_transport);
        Customers = new(_transport);
        Entitlements = new(_transport);
        Events = new(_transport);
        Features = new(_transport);
        Invoices = new(_transport);
        Metrics = new(_transport);
        Oauth = new(_transport);
        OauthApps = new(_transport);
        Plans = new(_transport);
        ProductFamilies = new(_transport);
        Products = new(_transport);
        Subscriptions = new(_transport);
        Usage = new(_transport);
        WebhookEndpoints = new(_transport);
    }

    private static ApiTransport CreateTransport(string? token, MeteroidClientOptions options, HttpClient? http)
    {
        var credentials = new Credentials(
            token ?? options.Token ?? ApiTransport.NonEmpty(Environment.GetEnvironmentVariable("METEROID_API_KEY")),
            options.TokenProvider,
            null,
            new Dictionary<string, string?>()
        );
        return new ApiTransport(s_auth, credentials, options, http);
    }

    /// <summary>The <c>add_ons</c> operations.</summary>
    public AddOnsApi AddOns { get; }

    IAddOnsApi IMeteroidClient.AddOns => AddOns;

    /// <summary>The <c>batch_jobs</c> operations.</summary>
    public BatchJobsApi BatchJobs { get; }

    IBatchJobsApi IMeteroidClient.BatchJobs => BatchJobs;

    /// <summary>The <c>checkout_sessions</c> operations.</summary>
    public CheckoutSessionsApi CheckoutSessions { get; }

    ICheckoutSessionsApi IMeteroidClient.CheckoutSessions => CheckoutSessions;

    /// <summary>The <c>connect</c> operations.</summary>
    public ConnectApi Connect { get; }

    IConnectApi IMeteroidClient.Connect => Connect;

    /// <summary>The <c>coupons</c> operations.</summary>
    public CouponsApi Coupons { get; }

    ICouponsApi IMeteroidClient.Coupons => Coupons;

    /// <summary>The <c>credit_notes</c> operations.</summary>
    public CreditNotesApi CreditNotes { get; }

    ICreditNotesApi IMeteroidClient.CreditNotes => CreditNotes;

    /// <summary>The <c>custom_properties</c> operations.</summary>
    public CustomPropertiesApi CustomProperties { get; }

    ICustomPropertiesApi IMeteroidClient.CustomProperties => CustomProperties;

    /// <summary>The <c>customers</c> operations.</summary>
    public CustomersApi Customers { get; }

    ICustomersApi IMeteroidClient.Customers => Customers;

    /// <summary>The <c>entitlements</c> operations.</summary>
    public EntitlementsApi Entitlements { get; }

    IEntitlementsApi IMeteroidClient.Entitlements => Entitlements;

    /// <summary>The <c>events</c> operations.</summary>
    public EventsApi Events { get; }

    IEventsApi IMeteroidClient.Events => Events;

    /// <summary>The <c>features</c> operations.</summary>
    public FeaturesApi Features { get; }

    IFeaturesApi IMeteroidClient.Features => Features;

    /// <summary>The <c>invoices</c> operations.</summary>
    public InvoicesApi Invoices { get; }

    IInvoicesApi IMeteroidClient.Invoices => Invoices;

    /// <summary>The <c>metrics</c> operations.</summary>
    public MetricsApi Metrics { get; }

    IMetricsApi IMeteroidClient.Metrics => Metrics;

    /// <summary>The <c>oauth</c> operations.</summary>
    public OauthApi Oauth { get; }

    IOauthApi IMeteroidClient.Oauth => Oauth;

    /// <summary>The <c>oauth_apps</c> operations.</summary>
    public OauthAppsApi OauthApps { get; }

    IOauthAppsApi IMeteroidClient.OauthApps => OauthApps;

    /// <summary>The <c>plans</c> operations.</summary>
    public PlansApi Plans { get; }

    IPlansApi IMeteroidClient.Plans => Plans;

    /// <summary>The <c>product_families</c> operations.</summary>
    public ProductFamiliesApi ProductFamilies { get; }

    IProductFamiliesApi IMeteroidClient.ProductFamilies => ProductFamilies;

    /// <summary>The <c>products</c> operations.</summary>
    public ProductsApi Products { get; }

    IProductsApi IMeteroidClient.Products => Products;

    /// <summary>The <c>subscriptions</c> operations.</summary>
    public SubscriptionsApi Subscriptions { get; }

    ISubscriptionsApi IMeteroidClient.Subscriptions => Subscriptions;

    /// <summary>The <c>usage</c> operations.</summary>
    public UsageApi Usage { get; }

    IUsageApi IMeteroidClient.Usage => Usage;

    /// <summary>The <c>webhook_endpoints</c> operations.</summary>
    public WebhookEndpointsApi WebhookEndpoints { get; }

    IWebhookEndpointsApi IMeteroidClient.WebhookEndpoints => WebhookEndpoints;

    /// <summary>Releases the connection pool and middleware, unless the caller owns the <see cref="HttpClient"/>.</summary>
    public void Dispose() => _transport.Dispose();
}

/// <summary>The default base URL and the credentials the API's security schemes take.</summary>
public sealed partial class MeteroidClientOptions
{
    /// <summary>The API endpoint used when neither <see cref="BaseUrl"/> nor the
    /// <c>METEROID_BASE_URL</c> environment variable is set.</summary>
    public const string DefaultBaseUrl = "https://api.meteroid.com";

    /// <summary>Called before each request for a fresh bearer token, e.g. an OAuth2 access token,
    /// instead of the constructor token.</summary>
    public Func<CancellationToken, ValueTask<string>>? TokenProvider { get; set; }
}

/// <summary>The error model of this API.</summary>
public static partial class ApiExceptionExtensions
{
    /// <summary>The body parsed as <see cref="Models.RestErrorResponse"/>, the error model of this API, or <c>null</c>.</summary>
    public static Models.RestErrorResponse? GetError(this ApiException exception) =>
        exception.GetError<Models.RestErrorResponse>();
}
