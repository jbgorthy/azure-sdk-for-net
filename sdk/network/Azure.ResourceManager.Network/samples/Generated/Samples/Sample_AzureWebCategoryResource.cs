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
    public partial class Sample_AzureWebCategoryResource
    {
        // Get Azure Web Category by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureWebCategoryByName()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/AzureWebCategoryGet.json
            // this example is just showing the usage of "WebCategories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureWebCategoryResource created on azure
            // for more information of creating AzureWebCategoryResource, please refer to the document of AzureWebCategoryResource
            string subscriptionId = "4de8428a-4a92-4cea-90ff-b47128b8cab8";
            string name = "Arts";
            ResourceIdentifier azureWebCategoryResourceId = AzureWebCategoryResource.CreateResourceIdentifier(subscriptionId, name);
            AzureWebCategoryResource azureWebCategory = client.GetAzureWebCategoryResource(azureWebCategoryResourceId);

            // invoke the operation
            AzureWebCategoryResource result = await azureWebCategory.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureWebCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
