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
    /// A class representing a collection of <see cref="ExpressRouteCircuitResource"/> and their operations.
    /// Each <see cref="ExpressRouteCircuitResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ExpressRouteCircuitCollection"/> instance call the GetExpressRouteCircuits method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ExpressRouteCircuitCollection : ArmCollection, IEnumerable<ExpressRouteCircuitResource>, IAsyncEnumerable<ExpressRouteCircuitResource>
    {
        private readonly ClientDiagnostics _expressRouteCircuitClientDiagnostics;
        private readonly ExpressRouteCircuitsRestOperations _expressRouteCircuitRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteCircuitResource.ResourceType, out string expressRouteCircuitApiVersion);
            _expressRouteCircuitRestClient = new ExpressRouteCircuitsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCircuitApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string circuitName, ExpressRouteCircuitData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitResource>(new ExpressRouteCircuitOperationSource(Client), _expressRouteCircuitClientDiagnostics, Pipeline, _expressRouteCircuitRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, circuitName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitResource> CreateOrUpdate(WaitUntil waitUntil, string circuitName, ExpressRouteCircuitData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, circuitName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitResource>(new ExpressRouteCircuitOperationSource(Client), _expressRouteCircuitClientDiagnostics, Pipeline, _expressRouteCircuitRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, circuitName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuitResource>> GetAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitResource> Get(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the express route circuits in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitResource(Client, ExpressRouteCircuitData.DeserializeExpressRouteCircuitData(e)), _expressRouteCircuitClientDiagnostics, Pipeline, "ExpressRouteCircuitCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the express route circuits in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitResource(Client, ExpressRouteCircuitData.DeserializeExpressRouteCircuitData(e)), _expressRouteCircuitClientDiagnostics, Pipeline, "ExpressRouteCircuitCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<bool> Exists(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRouteCircuitResource>> GetIfExistsAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteCircuitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual NullableResponse<ExpressRouteCircuitResource> GetIfExists(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuitResource> IEnumerable<ExpressRouteCircuitResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitResource> IAsyncEnumerable<ExpressRouteCircuitResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
