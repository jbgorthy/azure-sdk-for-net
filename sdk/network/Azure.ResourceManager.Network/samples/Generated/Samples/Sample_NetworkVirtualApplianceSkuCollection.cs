// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkVirtualApplianceSkuCollection
    {
        // NetworkVirtualApplianceSkuListResult
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_NetworkVirtualApplianceSkuListResult()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkVirtualApplianceSkuList.json
            // this example is just showing the usage of "VirtualApplianceSkus_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkVirtualApplianceSkuResource
            NetworkVirtualApplianceSkuCollection collection = subscriptionResource.GetNetworkVirtualApplianceSkus();

            // invoke the operation and iterate over the result
            await foreach (NetworkVirtualApplianceSkuResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceSkuData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NetworkVirtualApplianceSkuGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkVirtualApplianceSkuGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkVirtualApplianceSkuGet.json
            // this example is just showing the usage of "VirtualApplianceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkVirtualApplianceSkuResource
            NetworkVirtualApplianceSkuCollection collection = subscriptionResource.GetNetworkVirtualApplianceSkus();

            // invoke the operation
            string skuName = "ciscoSdwan";
            NetworkVirtualApplianceSkuResource result = await collection.GetAsync(skuName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkVirtualApplianceSkuGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_NetworkVirtualApplianceSkuGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkVirtualApplianceSkuGet.json
            // this example is just showing the usage of "VirtualApplianceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkVirtualApplianceSkuResource
            NetworkVirtualApplianceSkuCollection collection = subscriptionResource.GetNetworkVirtualApplianceSkus();

            // invoke the operation
            string skuName = "ciscoSdwan";
            bool result = await collection.ExistsAsync(skuName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NetworkVirtualApplianceSkuGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_NetworkVirtualApplianceSkuGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkVirtualApplianceSkuGet.json
            // this example is just showing the usage of "VirtualApplianceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkVirtualApplianceSkuResource
            NetworkVirtualApplianceSkuCollection collection = subscriptionResource.GetNetworkVirtualApplianceSkus();

            // invoke the operation
            string skuName = "ciscoSdwan";
            NullableResponse<NetworkVirtualApplianceSkuResource> response = await collection.GetIfExistsAsync(skuName);
            NetworkVirtualApplianceSkuResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceSkuData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
