// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Nginx
{
    internal class NginxConfigurationOperationSource : IOperationSource<NginxConfigurationResource>
    {
        private readonly ArmClient _client;

        internal NginxConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        NginxConfigurationResource IOperationSource<NginxConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NginxConfigurationData.DeserializeNginxConfigurationData(document.RootElement);
            return new NginxConfigurationResource(_client, data);
        }

        async ValueTask<NginxConfigurationResource> IOperationSource<NginxConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NginxConfigurationData.DeserializeNginxConfigurationData(document.RootElement);
            return new NginxConfigurationResource(_client, data);
        }
    }
}
