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
    public partial class Sample_LocalNetworkGatewayResource
    {
        // GetLocalNetworkGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetLocalNetworkGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LocalNetworkGatewayGet.json
            // this example is just showing the usage of "LocalNetworkGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalNetworkGatewayResource created on azure
            // for more information of creating LocalNetworkGatewayResource, please refer to the document of LocalNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string localNetworkGatewayName = "localgw";
            ResourceIdentifier localNetworkGatewayResourceId = LocalNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localNetworkGatewayName);
            LocalNetworkGatewayResource localNetworkGateway = client.GetLocalNetworkGatewayResource(localNetworkGatewayResourceId);

            // invoke the operation
            LocalNetworkGatewayResource result = await localNetworkGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalNetworkGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteLocalNetworkGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteLocalNetworkGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LocalNetworkGatewayDelete.json
            // this example is just showing the usage of "LocalNetworkGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalNetworkGatewayResource created on azure
            // for more information of creating LocalNetworkGatewayResource, please refer to the document of LocalNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string localNetworkGatewayName = "localgw";
            ResourceIdentifier localNetworkGatewayResourceId = LocalNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localNetworkGatewayName);
            LocalNetworkGatewayResource localNetworkGateway = client.GetLocalNetworkGatewayResource(localNetworkGatewayResourceId);

            // invoke the operation
            await localNetworkGateway.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // UpdateLocalNetworkGatewayTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateLocalNetworkGatewayTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LocalNetworkGatewayUpdateTags.json
            // this example is just showing the usage of "LocalNetworkGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalNetworkGatewayResource created on azure
            // for more information of creating LocalNetworkGatewayResource, please refer to the document of LocalNetworkGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string localNetworkGatewayName = "lgw";
            ResourceIdentifier localNetworkGatewayResourceId = LocalNetworkGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localNetworkGatewayName);
            LocalNetworkGatewayResource localNetworkGateway = client.GetLocalNetworkGatewayResource(localNetworkGatewayResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            LocalNetworkGatewayResource result = await localNetworkGateway.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalNetworkGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
