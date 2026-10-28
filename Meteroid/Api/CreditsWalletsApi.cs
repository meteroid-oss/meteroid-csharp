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

/// <summary>The <c>credits.wallets</c> operations, as <see cref="ICreditsApi.Wallets"/> exposes them; mock it in tests.</summary>
public interface ICreditsWalletsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICreditsWalletsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List wallets
    /// </summary>
    /// <remarks>
    /// A customer's credit per currency and credit unit: the credit on account, the usage not
    /// invoiced yet and the balance left after it, with the wallet's alerts and automatic top-up. The
    /// customer's own currency comes first, even when empty. With <c>subscription_id</c>, each wallet
    /// counts only the credit that subscription can use.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WalletListResponse> ListAsync(
        string idOrAlias,
        CreditsWalletsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Check wallet access
    /// </summary>
    /// <remarks>
    /// Whether the customer's prepaid credit in a currency or credit unit still covers them, net of
    /// usage not invoiced yet. Denies only when the wallet blocks usage once its credit is used up;
    /// otherwise access stays allowed and <c>exhausted</c> signals the empty balance on its own. With
    /// <c>subscription_id</c>, only the credit that subscription can use counts: pass it when the
    /// customer has several subscriptions, since one subscription's credit cannot pay another's
    /// usage. The balance follows usage within a few seconds near zero or a threshold, within a
    /// minute otherwise, and the answer is cached for one second: use it to gate consumption, not
    /// to bill.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WalletCheck> CheckAsync(
        string idOrAlias,
        CreditsWalletsCheckOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Configure a wallet
    /// </summary>
    /// <remarks>
    /// Settings of a customer's wallet in one currency or credit unit: whether usage is refused
    /// once its credit is used up, the balances that fire <c>wallet.balance_low</c>, and its automatic
    /// top-up. Opens the wallet if it does not exist yet. Partial update: omit a field to leave it
    /// unchanged.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="currency">The <c>currency</c> path parameter.</param>
    /// <param name="patchWalletRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Wallet> UpdateAsync(
        string idOrAlias,
        string currency,
        PatchWalletRequest patchWalletRequest,
        CreditsWalletsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credits.wallets</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICreditsWalletsApiWithRawResponse
{
    /// <summary><see cref="ICreditsWalletsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WalletListResponse>> ListAsync(
        string idOrAlias,
        CreditsWalletsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditsWalletsApi.CheckAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WalletCheck>> CheckAsync(
        string idOrAlias,
        CreditsWalletsCheckOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICreditsWalletsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="currency">The <c>currency</c> path parameter.</param>
    /// <param name="patchWalletRequest">The request body.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Wallet>> UpdateAsync(
        string idOrAlias,
        string currency,
        PatchWalletRequest patchWalletRequest,
        CreditsWalletsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>credits.wallets</c> operations. Get it from <see cref="CreditsApi.Wallets"/>.</summary>
public sealed partial class CreditsWalletsApi : ICreditsWalletsApi
{
    internal CreditsWalletsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICreditsWalletsApi.WithRawResponse"/>
    public CreditsWalletsApiWithRawResponse WithRawResponse { get; }

    ICreditsWalletsApiWithRawResponse ICreditsWalletsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<WalletListResponse> ListAsync(
        string idOrAlias,
        CreditsWalletsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListAsync(idOrAlias, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<WalletCheck> CheckAsync(
        string idOrAlias,
        CreditsWalletsCheckOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CheckAsync(idOrAlias, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Wallet> UpdateAsync(
        string idOrAlias,
        string currency,
        PatchWalletRequest patchWalletRequest,
        CreditsWalletsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(idOrAlias, currency, patchWalletRequest, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>credits.wallets</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CreditsWalletsApiWithRawResponse : ICreditsWalletsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CreditsWalletsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WalletListResponse>> ListAsync(
        string idOrAlias,
        CreditsWalletsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/wallets",
            "credits_wallets.list"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("subscription_id", options?.SubscriptionId);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WalletListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WalletCheck>> CheckAsync(
        string idOrAlias,
        CreditsWalletsCheckOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/wallets/check",
            "credits_wallets.check"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("currency", options?.Currency);
        request.AddQuery("credit_unit", options?.CreditUnit);
        request.AddQuery("product_id", options?.ProductId);
        request.AddQuery("subscription_id", options?.SubscriptionId);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WalletCheck,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Wallet>> UpdateAsync(
        string idOrAlias,
        string currency,
        PatchWalletRequest patchWalletRequest,
        CreditsWalletsUpdateOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);
        ArgumentException.ThrowIfNullOrEmpty(currency);
        ArgumentNullException.ThrowIfNull(patchWalletRequest);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/customers/{Uri.EscapeDataString(idOrAlias)}/wallets/{Uri.EscapeDataString(currency)}",
            "credits_wallets.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetHeader("Idempotency-Key", options.IdempotencyKey);
        request.SetJsonBody(patchWalletRequest, MeteroidJsonContext.Default.PatchWalletRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Wallet, requestOptions, cancellationToken);
    }
}
