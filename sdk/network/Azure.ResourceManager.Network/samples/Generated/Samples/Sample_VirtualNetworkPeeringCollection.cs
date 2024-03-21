// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualNetworkPeeringCollection
    {
        // Get peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringGet.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            VirtualNetworkPeeringResource result = await collection.GetAsync(virtualNetworkPeeringName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringGet.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            bool result = await collection.ExistsAsync(virtualNetworkPeeringName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringGet.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            NullableResponse<VirtualNetworkPeeringResource> response = await collection.GetIfExistsAsync(virtualNetworkPeeringName);
            VirtualNetworkPeeringResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkPeeringData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get peering with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPeeringWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringGetWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            VirtualNetworkPeeringResource result = await collection.GetAsync(virtualNetworkPeeringName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get peering with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPeeringWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringGetWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            bool result = await collection.ExistsAsync(virtualNetworkPeeringName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get peering with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetPeeringWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringGetWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            NullableResponse<VirtualNetworkPeeringResource> response = await collection.GetIfExistsAsync(virtualNetworkPeeringName);
            VirtualNetworkPeeringResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkPeeringData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringCreate.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
            };
            ArmOperation<VirtualNetworkPeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkPeeringName, data);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create peering with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePeeringWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringCreateWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
            };
            ArmOperation<VirtualNetworkPeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkPeeringName, data);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sync Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SyncPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringSync.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation
            string virtualNetworkPeeringName = "peer";
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
            };
            SyncRemoteAddressSpace? syncRemoteAddressSpace = SyncRemoteAddressSpace.True;
            ArmOperation<VirtualNetworkPeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkPeeringName, data, syncRemoteAddressSpace: syncRemoteAddressSpace);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List peerings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPeerings()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringList.json
            // this example is just showing the usage of "VirtualNetworkPeerings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkPeeringResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkPeeringData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List peerings with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPeeringsWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkPeeringListWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkResource created on azure
            // for more information of creating VirtualNetworkResource, please refer to the document of VirtualNetworkResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            ResourceIdentifier virtualNetworkResourceId = VirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName);
            VirtualNetworkResource virtualNetwork = client.GetVirtualNetworkResource(virtualNetworkResourceId);

            // get the collection of this VirtualNetworkPeeringResource
            VirtualNetworkPeeringCollection collection = virtualNetwork.GetVirtualNetworkPeerings();

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkPeeringResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkPeeringData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
