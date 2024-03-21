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
    public partial class Sample_VpnSiteLinkConnectionResource
    {
        // ResetVpnLinkConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResetConnectionVpnLinkConnection_ResetVpnLinkConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VpnSiteLinkConnectionReset.json
            // this example is just showing the usage of "VpnLinkConnections_ResetConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnSiteLinkConnectionResource created on azure
            // for more information of creating VpnSiteLinkConnectionResource, please refer to the document of VpnSiteLinkConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            string linkConnectionName = "Connection-Link1";
            ResourceIdentifier vpnSiteLinkConnectionResourceId = VpnSiteLinkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            VpnSiteLinkConnectionResource vpnSiteLinkConnection = client.GetVpnSiteLinkConnectionResource(vpnSiteLinkConnectionResourceId);

            // invoke the operation
            await vpnSiteLinkConnection.ResetConnectionVpnLinkConnectionAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // GetVpnLinkConnectionIkeSa
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIkeSasVpnLinkConnection_GetVpnLinkConnectionIkeSa()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VpnSiteLinkConnectionGetIkeSas.json
            // this example is just showing the usage of "VpnLinkConnections_GetIkeSas" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnSiteLinkConnectionResource created on azure
            // for more information of creating VpnSiteLinkConnectionResource, please refer to the document of VpnSiteLinkConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            string linkConnectionName = "Connection-Link1";
            ResourceIdentifier vpnSiteLinkConnectionResourceId = VpnSiteLinkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            VpnSiteLinkConnectionResource vpnSiteLinkConnection = client.GetVpnSiteLinkConnectionResource(vpnSiteLinkConnectionResourceId);

            // invoke the operation
            ArmOperation<string> lro = await vpnSiteLinkConnection.GetIkeSasVpnLinkConnectionAsync(WaitUntil.Completed);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // VpnSiteLinkConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VpnSiteLinkConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/VpnSiteLinkConnectionGet.json
            // this example is just showing the usage of "VpnSiteLinkConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnSiteLinkConnectionResource created on azure
            // for more information of creating VpnSiteLinkConnectionResource, please refer to the document of VpnSiteLinkConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            string linkConnectionName = "Connection-Link1";
            ResourceIdentifier vpnSiteLinkConnectionResourceId = VpnSiteLinkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            VpnSiteLinkConnectionResource vpnSiteLinkConnection = client.GetVpnSiteLinkConnectionResource(vpnSiteLinkConnectionResourceId);

            // invoke the operation
            VpnSiteLinkConnectionResource result = await vpnSiteLinkConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnSiteLinkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
