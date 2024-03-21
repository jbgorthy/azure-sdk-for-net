// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ApplicationGatewayWafDynamicManifestResource"/> and their operations.
    /// Each <see cref="ApplicationGatewayWafDynamicManifestResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get an <see cref="ApplicationGatewayWafDynamicManifestCollection"/> instance call the GetApplicationGatewayWafDynamicManifests method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ApplicationGatewayWafDynamicManifestCollection : ArmCollection, IEnumerable<ApplicationGatewayWafDynamicManifestResource>, IAsyncEnumerable<ApplicationGatewayWafDynamicManifestResource>
    {
        private readonly ClientDiagnostics _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics;
        private readonly ApplicationGatewayWafDynamicManifestsDefaultRestOperations _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient;
        private readonly ClientDiagnostics _applicationGatewayWafDynamicManifestClientDiagnostics;
        private readonly ApplicationGatewayWafDynamicManifestsRestOperations _applicationGatewayWafDynamicManifestRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayWafDynamicManifestCollection"/> class for mocking. </summary>
        protected ApplicationGatewayWafDynamicManifestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayWafDynamicManifestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The region where the nrp are located at. </param>
        internal ApplicationGatewayWafDynamicManifestCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationGatewayWafDynamicManifestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApplicationGatewayWafDynamicManifestResource.ResourceType, out string applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultApiVersion);
            _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient = new ApplicationGatewayWafDynamicManifestsDefaultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultApiVersion);
            _applicationGatewayWafDynamicManifestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationGatewayWafDynamicManifestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApplicationGatewayWafDynamicManifestResource.ResourceType, out string applicationGatewayWafDynamicManifestApiVersion);
            _applicationGatewayWafDynamicManifestRestClient = new ApplicationGatewayWafDynamicManifestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, applicationGatewayWafDynamicManifestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the regional application gateway waf manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationGatewayWafDynamicManifestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayWafDynamicManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the regional application gateway waf manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGatewayWafDynamicManifestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayWafDynamicManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the regional application gateway waf manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGatewayWafDynamicManifestResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGatewayWafDynamicManifestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _applicationGatewayWafDynamicManifestRestClient.CreateGetRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _applicationGatewayWafDynamicManifestRestClient.CreateGetNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApplicationGatewayWafDynamicManifestResource(Client, ApplicationGatewayWafDynamicManifestData.DeserializeApplicationGatewayWafDynamicManifestData(e)), _applicationGatewayWafDynamicManifestClientDiagnostics, Pipeline, "ApplicationGatewayWafDynamicManifestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the regional application gateway waf manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGatewayWafDynamicManifestResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGatewayWafDynamicManifestResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _applicationGatewayWafDynamicManifestRestClient.CreateGetRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _applicationGatewayWafDynamicManifestRestClient.CreateGetNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApplicationGatewayWafDynamicManifestResource(Client, ApplicationGatewayWafDynamicManifestData.DeserializeApplicationGatewayWafDynamicManifestData(e)), _applicationGatewayWafDynamicManifestClientDiagnostics, Pipeline, "ApplicationGatewayWafDynamicManifestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ApplicationGatewayWafDynamicManifestResource>> GetIfExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApplicationGatewayWafDynamicManifestResource>(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayWafDynamicManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ApplicationGatewayWafDynamicManifestResource> GetIfExists(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApplicationGatewayWafDynamicManifestResource>(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayWafDynamicManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApplicationGatewayWafDynamicManifestResource> IEnumerable<ApplicationGatewayWafDynamicManifestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationGatewayWafDynamicManifestResource> IAsyncEnumerable<ApplicationGatewayWafDynamicManifestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
