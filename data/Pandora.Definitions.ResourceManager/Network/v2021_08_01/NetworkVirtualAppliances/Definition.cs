using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.NetworkVirtualAppliances;

internal class Definition : ResourceDefinition
{
    public string Name => "NetworkVirtualAppliances";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new InboundSecurityRuleCreateOrUpdateOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateTagsOperation(),
    };
}
