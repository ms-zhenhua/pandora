using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.P2SVpnGateways;

internal class Definition : ResourceDefinition
{
    public string Name => "P2SVpnGateways";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DisconnectP2sVpnConnectionsOperation(),
        new GenerateVpnProfileOperation(),
        new GetP2sVpnConnectionHealthOperation(),
        new GetP2sVpnConnectionHealthDetailedOperation(),
        new ResetOperation(),
        new UpdateTagsOperation(),
    };
}
