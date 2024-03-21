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
    public partial class Sample_AdminRuleGroupCollection
    {
        // List security admin rule collections
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSecurityAdminRuleCollections()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerAdminRuleCollectionList.json
            // this example is just showing the usage of "AdminRuleCollections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // get the collection of this AdminRuleGroupResource
            AdminRuleGroupCollection collection = securityAdminConfiguration.GetAdminRuleGroups();

            // invoke the operation and iterate over the result
            await foreach (AdminRuleGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AdminRuleGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets security admin rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsSecurityAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerAdminRuleCollectionGet.json
            // this example is just showing the usage of "AdminRuleCollections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // get the collection of this AdminRuleGroupResource
            AdminRuleGroupCollection collection = securityAdminConfiguration.GetAdminRuleGroups();

            // invoke the operation
            string ruleCollectionName = "testRuleCollection";
            AdminRuleGroupResource result = await collection.GetAsync(ruleCollectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdminRuleGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets security admin rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsSecurityAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerAdminRuleCollectionGet.json
            // this example is just showing the usage of "AdminRuleCollections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // get the collection of this AdminRuleGroupResource
            AdminRuleGroupCollection collection = securityAdminConfiguration.GetAdminRuleGroups();

            // invoke the operation
            string ruleCollectionName = "testRuleCollection";
            bool result = await collection.ExistsAsync(ruleCollectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets security admin rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsSecurityAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerAdminRuleCollectionGet.json
            // this example is just showing the usage of "AdminRuleCollections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // get the collection of this AdminRuleGroupResource
            AdminRuleGroupCollection collection = securityAdminConfiguration.GetAdminRuleGroups();

            // invoke the operation
            string ruleCollectionName = "testRuleCollection";
            NullableResponse<AdminRuleGroupResource> response = await collection.GetIfExistsAsync(ruleCollectionName);
            AdminRuleGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AdminRuleGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or Update an admin rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAnAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerAdminRuleCollectionPut.json
            // this example is just showing the usage of "AdminRuleCollections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityAdminConfigurationResource created on azure
            // for more information of creating SecurityAdminConfigurationResource, please refer to the document of SecurityAdminConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            ResourceIdentifier securityAdminConfigurationResourceId = SecurityAdminConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            SecurityAdminConfigurationResource securityAdminConfiguration = client.GetSecurityAdminConfigurationResource(securityAdminConfigurationResourceId);

            // get the collection of this AdminRuleGroupResource
            AdminRuleGroupCollection collection = securityAdminConfiguration.GetAdminRuleGroups();

            // invoke the operation
            string ruleCollectionName = "testRuleCollection";
            AdminRuleGroupData data = new AdminRuleGroupData()
            {
                Description = "A sample policy",
                AppliesToGroups =
{
new NetworkManagerSecurityGroupItem(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager/networkGroups/testGroup"))
},
            };
            ArmOperation<AdminRuleGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleCollectionName, data);
            AdminRuleGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdminRuleGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
