// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_RoutingConfigurationCollection
    {
        // List routing configurations in a network manager
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRoutingConfigurationsInANetworkManager()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2023-03-01-preview/examples/NetworkManagerRoutingConfigurationList.json
            // this example is just showing the usage of "RoutingConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this RoutingConfigurationResource
            RoutingConfigurationCollection collection = networkManager.GetRoutingConfigurations();

            // invoke the operation and iterate over the result
            await foreach (RoutingConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoutingConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get routing configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoutingConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2023-03-01-preview/examples/NetworkManagerRoutingConfigurationGet.json
            // this example is just showing the usage of "RoutingConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this RoutingConfigurationResource
            RoutingConfigurationCollection collection = networkManager.GetRoutingConfigurations();

            // invoke the operation
            string configurationName = "myTestRoutingConfig";
            RoutingConfigurationResource result = await collection.GetAsync(configurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoutingConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get routing configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRoutingConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2023-03-01-preview/examples/NetworkManagerRoutingConfigurationGet.json
            // this example is just showing the usage of "RoutingConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this RoutingConfigurationResource
            RoutingConfigurationCollection collection = networkManager.GetRoutingConfigurations();

            // invoke the operation
            string configurationName = "myTestRoutingConfig";
            bool result = await collection.ExistsAsync(configurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get routing configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRoutingConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2023-03-01-preview/examples/NetworkManagerRoutingConfigurationGet.json
            // this example is just showing the usage of "RoutingConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this RoutingConfigurationResource
            RoutingConfigurationCollection collection = networkManager.GetRoutingConfigurations();

            // invoke the operation
            string configurationName = "myTestRoutingConfig";
            NullableResponse<RoutingConfigurationResource> response = await collection.GetIfExistsAsync(configurationName);
            RoutingConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoutingConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create network manager routing configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNetworkManagerRoutingConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/preview/2023-03-01-preview/examples/NetworkManagerRoutingConfigurationPut.json
            // this example is just showing the usage of "RoutingConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this RoutingConfigurationResource
            RoutingConfigurationCollection collection = networkManager.GetRoutingConfigurations();

            // invoke the operation
            string configurationName = "myTestRoutingConfig";
            RoutingConfigurationData data = new RoutingConfigurationData()
            {
                Description = "A sample policy",
            };
            ArmOperation<RoutingConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationName, data);
            RoutingConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoutingConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
