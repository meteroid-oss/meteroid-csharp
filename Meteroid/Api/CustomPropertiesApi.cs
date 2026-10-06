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

/// <summary>The <c>custom_properties</c> operations, as <see cref="IMeteroidClient.CustomProperties"/> exposes them; mock it in tests.</summary>
public interface ICustomPropertiesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICustomPropertiesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List custom property definitions
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CustomPropertyDefinitionListResponse> ListCustomPropertyDefinitionsAsync(
        CustomPropertiesListCustomPropertyDefinitionsOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a custom property definition
    /// </summary>
    /// <param name="customPropertyDefinitionCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CustomPropertyDefinition> CreateCustomPropertyDefinitionAsync(
        CustomPropertyDefinitionCreateRequest customPropertyDefinitionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a custom property definition
    /// </summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CustomPropertyDefinition> RetrieveCustomPropertyDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a custom property definition
    /// </summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="customPropertyDefinitionUpdateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CustomPropertyDefinition> UpdateCustomPropertyDefinitionAsync(
        string id,
        CustomPropertyDefinitionUpdateRequest customPropertyDefinitionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a custom property definition
    /// </summary>
    /// <remarks>
    /// Soft-deletes the definition. Existing property values on entities are preserved; the definition
    /// simply stops being enforced on new writes.
    /// </remarks>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CustomPropertyDefinition> ArchiveDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>custom_properties</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICustomPropertiesApiWithRawResponse
{
    /// <summary><see cref="ICustomPropertiesApi.ListCustomPropertyDefinitionsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CustomPropertyDefinitionListResponse>> ListCustomPropertyDefinitionsAsync(
        CustomPropertiesListCustomPropertyDefinitionsOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICustomPropertiesApi.CreateCustomPropertyDefinitionAsync"/>, with the status and headers of the response.</summary>
    /// <param name="customPropertyDefinitionCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CustomPropertyDefinition>> CreateCustomPropertyDefinitionAsync(
        CustomPropertyDefinitionCreateRequest customPropertyDefinitionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICustomPropertiesApi.RetrieveCustomPropertyDefinitionAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CustomPropertyDefinition>> RetrieveCustomPropertyDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICustomPropertiesApi.UpdateCustomPropertyDefinitionAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="customPropertyDefinitionUpdateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CustomPropertyDefinition>> UpdateCustomPropertyDefinitionAsync(
        string id,
        CustomPropertyDefinitionUpdateRequest customPropertyDefinitionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICustomPropertiesApi.ArchiveDefinitionAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CustomPropertyDefinition>> ArchiveDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>custom_properties</c> operations. Get it from <see cref="MeteroidClient.CustomProperties"/>.</summary>
public sealed partial class CustomPropertiesApi : ICustomPropertiesApi
{
    internal CustomPropertiesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICustomPropertiesApi.WithRawResponse"/>
    public CustomPropertiesApiWithRawResponse WithRawResponse { get; }

    ICustomPropertiesApiWithRawResponse ICustomPropertiesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<CustomPropertyDefinitionListResponse> ListCustomPropertyDefinitionsAsync(
        CustomPropertiesListCustomPropertyDefinitionsOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListCustomPropertyDefinitionsAsync(options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CustomPropertyDefinition> CreateCustomPropertyDefinitionAsync(
        CustomPropertyDefinitionCreateRequest customPropertyDefinitionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateCustomPropertyDefinitionAsync(
                customPropertyDefinitionCreateRequest,
                requestOptions,
                cancellationToken
            )
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CustomPropertyDefinition> RetrieveCustomPropertyDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveCustomPropertyDefinitionAsync(id, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CustomPropertyDefinition> UpdateCustomPropertyDefinitionAsync(
        string id,
        CustomPropertyDefinitionUpdateRequest customPropertyDefinitionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateCustomPropertyDefinitionAsync(
                id,
                customPropertyDefinitionUpdateRequest,
                requestOptions,
                cancellationToken
            )
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CustomPropertyDefinition> ArchiveDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ArchiveDefinitionAsync(id, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>custom_properties</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CustomPropertiesApiWithRawResponse : ICustomPropertiesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CustomPropertiesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CustomPropertyDefinitionListResponse>> ListCustomPropertyDefinitionsAsync(
        CustomPropertiesListCustomPropertyDefinitionsOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(
            HttpMethod.Get,
            "/api/v1/custom-property-definitions",
            "custom_properties.list_custom_property_definitions"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("entity_type", options?.EntityType);
        request.AddQuery("include_archived", options?.IncludeArchived);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CustomPropertyDefinitionListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CustomPropertyDefinition>> CreateCustomPropertyDefinitionAsync(
        CustomPropertyDefinitionCreateRequest customPropertyDefinitionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(customPropertyDefinitionCreateRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            "/api/v1/custom-property-definitions",
            "custom_properties.create_custom_property_definition"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(
            customPropertyDefinitionCreateRequest,
            MeteroidJsonContext.Default.CustomPropertyDefinitionCreateRequest
        );
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CustomPropertyDefinition,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CustomPropertyDefinition>> RetrieveCustomPropertyDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/custom-property-definitions/{Uri.EscapeDataString(id)}",
            "custom_properties.retrieve_custom_property_definition"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CustomPropertyDefinition,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CustomPropertyDefinition>> UpdateCustomPropertyDefinitionAsync(
        string id,
        CustomPropertyDefinitionUpdateRequest customPropertyDefinitionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);
        ArgumentNullException.ThrowIfNull(customPropertyDefinitionUpdateRequest);

        var request = new ApiRequest(
            HttpMethod.Put,
            $"/api/v1/custom-property-definitions/{Uri.EscapeDataString(id)}",
            "custom_properties.update_custom_property_definition"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(
            customPropertyDefinitionUpdateRequest,
            MeteroidJsonContext.Default.CustomPropertyDefinitionUpdateRequest
        );
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CustomPropertyDefinition,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CustomPropertyDefinition>> ArchiveDefinitionAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/custom-property-definitions/{Uri.EscapeDataString(id)}",
            "custom_properties.archive_definition"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CustomPropertyDefinition,
            requestOptions,
            cancellationToken
        );
    }
}
