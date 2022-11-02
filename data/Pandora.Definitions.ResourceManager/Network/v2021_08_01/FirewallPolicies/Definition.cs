using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.FirewallPolicies;

internal class Definition : ResourceDefinition
{
    public string Name => "FirewallPolicies";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new FirewallPolicyIdpsSignaturesFilterValuesListOperation(),
        new FirewallPolicyIdpsSignaturesListOperation(),
        new FirewallPolicyIdpsSignaturesOverridesGetOperation(),
        new FirewallPolicyIdpsSignaturesOverridesListOperation(),
        new FirewallPolicyIdpsSignaturesOverridesPatchOperation(),
        new FirewallPolicyIdpsSignaturesOverridesPutOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListAllOperation(),
        new UpdateTagsOperation(),
    };
}
