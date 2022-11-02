using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.NetworkInterfaces;

internal class VirtualMachineScaleSetIPConfigurationId : ResourceID
{
    public string? CommonAlias => "VirtualMachineScaleSetIPConfiguration";

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{virtualMachineScaleSetName}/virtualMachines/{virtualMachineIndex}/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("subscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("resourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("providers", "providers"),
        ResourceIDSegment.ResourceProvider("resourceProvider", "Microsoft.Compute"),
        ResourceIDSegment.Static("virtualMachineScaleSets", "virtualMachineScaleSets"),
        ResourceIDSegment.UserSpecified("virtualMachineScaleSetName"),
        ResourceIDSegment.Static("virtualMachines", "virtualMachines"),
        ResourceIDSegment.UserSpecified("virtualMachineIndex"),
        ResourceIDSegment.Static("networkInterfaces", "networkInterfaces"),
        ResourceIDSegment.UserSpecified("networkInterfaceName"),
        ResourceIDSegment.Static("ipConfigurations", "ipConfigurations"),
        ResourceIDSegment.UserSpecified("ipConfigurationName"),
    };
}
