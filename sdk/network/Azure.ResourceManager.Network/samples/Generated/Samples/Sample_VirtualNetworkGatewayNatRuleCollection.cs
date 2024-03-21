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
    public partial class Sample_VirtualNetworkGatewayNatRuleCollection
    {
        // VirtualNetworkGatewayNatRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualNetworkGatewayNatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkGatewayNatRuleGet.json
            // this example is just showing the usage of "VirtualNetworkGatewayNatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayResource created on azure
            // for more information of creating VirtualNetworkGatewayResource, please refer to the document of VirtualNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayName = "gateway1";
            ResourceIdentifier virtualNetworkGatewayResourceId = VirtualNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            VirtualNetworkGatewayResource virtualNetworkGateway = client.GetVirtualNetworkGatewayResource(virtualNetworkGatewayResourceId);

            // get the collection of this VirtualNetworkGatewayNatRuleResource
            VirtualNetworkGatewayNatRuleCollection collection = virtualNetworkGateway.GetVirtualNetworkGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            VirtualNetworkGatewayNatRuleResource result = await collection.GetAsync(natRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayNatRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualNetworkGatewayNatRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VirtualNetworkGatewayNatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkGatewayNatRuleGet.json
            // this example is just showing the usage of "VirtualNetworkGatewayNatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayResource created on azure
            // for more information of creating VirtualNetworkGatewayResource, please refer to the document of VirtualNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayName = "gateway1";
            ResourceIdentifier virtualNetworkGatewayResourceId = VirtualNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            VirtualNetworkGatewayResource virtualNetworkGateway = client.GetVirtualNetworkGatewayResource(virtualNetworkGatewayResourceId);

            // get the collection of this VirtualNetworkGatewayNatRuleResource
            VirtualNetworkGatewayNatRuleCollection collection = virtualNetworkGateway.GetVirtualNetworkGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            bool result = await collection.ExistsAsync(natRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualNetworkGatewayNatRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VirtualNetworkGatewayNatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkGatewayNatRuleGet.json
            // this example is just showing the usage of "VirtualNetworkGatewayNatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayResource created on azure
            // for more information of creating VirtualNetworkGatewayResource, please refer to the document of VirtualNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayName = "gateway1";
            ResourceIdentifier virtualNetworkGatewayResourceId = VirtualNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            VirtualNetworkGatewayResource virtualNetworkGateway = client.GetVirtualNetworkGatewayResource(virtualNetworkGatewayResourceId);

            // get the collection of this VirtualNetworkGatewayNatRuleResource
            VirtualNetworkGatewayNatRuleCollection collection = virtualNetworkGateway.GetVirtualNetworkGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            NullableResponse<VirtualNetworkGatewayNatRuleResource> response = await collection.GetIfExistsAsync(natRuleName);
            VirtualNetworkGatewayNatRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkGatewayNatRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // VirtualNetworkGatewayNatRulePut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualNetworkGatewayNatRulePut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkGatewayNatRulePut.json
            // this example is just showing the usage of "VirtualNetworkGatewayNatRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayResource created on azure
            // for more information of creating VirtualNetworkGatewayResource, please refer to the document of VirtualNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayName = "gateway1";
            ResourceIdentifier virtualNetworkGatewayResourceId = VirtualNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            VirtualNetworkGatewayResource virtualNetworkGateway = client.GetVirtualNetworkGatewayResource(virtualNetworkGatewayResourceId);

            // get the collection of this VirtualNetworkGatewayNatRuleResource
            VirtualNetworkGatewayNatRuleCollection collection = virtualNetworkGateway.GetVirtualNetworkGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            VirtualNetworkGatewayNatRuleData data = new VirtualNetworkGatewayNatRuleData()
            {
                VpnNatRuleType = VpnNatRuleType.Static,
                Mode = VpnNatRuleMode.EgressSnat,
                InternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "10.4.0.0/24",
PortRange = "200-300",
}
},
                ExternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "192.168.21.0/24",
PortRange = "300-400",
}
},
                IPConfigurationId = "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/gateway1/ipConfigurations/default",
            };
            ArmOperation<VirtualNetworkGatewayNatRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, natRuleName, data);
            VirtualNetworkGatewayNatRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkGatewayNatRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualNetworkGatewayNatRuleList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualNetworkGatewayNatRuleList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VirtualNetworkGatewayNatRuleList.json
            // this example is just showing the usage of "VirtualNetworkGatewayNatRules_ListByVirtualNetworkGateway" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkGatewayResource created on azure
            // for more information of creating VirtualNetworkGatewayResource, please refer to the document of VirtualNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualNetworkGatewayName = "gateway1";
            ResourceIdentifier virtualNetworkGatewayResourceId = VirtualNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            VirtualNetworkGatewayResource virtualNetworkGateway = client.GetVirtualNetworkGatewayResource(virtualNetworkGatewayResourceId);

            // get the collection of this VirtualNetworkGatewayNatRuleResource
            VirtualNetworkGatewayNatRuleCollection collection = virtualNetworkGateway.GetVirtualNetworkGatewayNatRules();

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkGatewayNatRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkGatewayNatRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
