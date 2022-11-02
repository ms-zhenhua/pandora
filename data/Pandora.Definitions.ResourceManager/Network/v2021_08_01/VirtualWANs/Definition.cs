using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.VirtualWANs;

internal class Definition : ResourceDefinition
{
    public string Name => "VirtualWANs";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ConfigurationPolicyGroupsCreateOrUpdateOperation(),
        new ConfigurationPolicyGroupsDeleteOperation(),
        new ConfigurationPolicyGroupsGetOperation(),
        new ConfigurationPolicyGroupsListByVpnServerConfigurationOperation(),
        new GeneratevirtualwanvpnserverconfigurationvpnprofileOperation(),
        new HubRouteTablesCreateOrUpdateOperation(),
        new HubRouteTablesDeleteOperation(),
        new HubRouteTablesGetOperation(),
        new HubRouteTablesListOperation(),
        new HubVirtualNetworkConnectionsCreateOrUpdateOperation(),
        new HubVirtualNetworkConnectionsDeleteOperation(),
        new HubVirtualNetworkConnectionsGetOperation(),
        new HubVirtualNetworkConnectionsListOperation(),
        new NatRulesCreateOrUpdateOperation(),
        new NatRulesDeleteOperation(),
        new NatRulesGetOperation(),
        new NatRulesListByVpnGatewayOperation(),
        new P2sVpnGatewaysCreateOrUpdateOperation(),
        new P2sVpnGatewaysDeleteOperation(),
        new P2sVpnGatewaysGetOperation(),
        new P2sVpnGatewaysListOperation(),
        new P2sVpnGatewaysListByResourceGroupOperation(),
        new RoutingIntentCreateOrUpdateOperation(),
        new RoutingIntentDeleteOperation(),
        new RoutingIntentGetOperation(),
        new RoutingIntentListOperation(),
        new SupportedSecurityProvidersOperation(),
        new UpdateTagsOperation(),
        new VirtualHubBgpConnectionCreateOrUpdateOperation(),
        new VirtualHubBgpConnectionDeleteOperation(),
        new VirtualHubBgpConnectionGetOperation(),
        new VirtualHubBgpConnectionsListOperation(),
        new VirtualHubBgpConnectionsListAdvertisedRoutesOperation(),
        new VirtualHubBgpConnectionsListLearnedRoutesOperation(),
        new VirtualHubIPConfigurationCreateOrUpdateOperation(),
        new VirtualHubIPConfigurationDeleteOperation(),
        new VirtualHubIPConfigurationGetOperation(),
        new VirtualHubIPConfigurationListOperation(),
        new VirtualHubRouteTableV2sCreateOrUpdateOperation(),
        new VirtualHubRouteTableV2sDeleteOperation(),
        new VirtualHubRouteTableV2sGetOperation(),
        new VirtualHubRouteTableV2sListOperation(),
        new VirtualHubsCreateOrUpdateOperation(),
        new VirtualHubsDeleteOperation(),
        new VirtualHubsGetOperation(),
        new VirtualHubsGetEffectiveVirtualHubRoutesOperation(),
        new VirtualHubsListOperation(),
        new VirtualHubsListByResourceGroupOperation(),
        new VirtualHubsUpdateTagsOperation(),
        new VirtualWansCreateOrUpdateOperation(),
        new VirtualWansDeleteOperation(),
        new VirtualWansGetOperation(),
        new VirtualWansListOperation(),
        new VirtualWansListByResourceGroupOperation(),
        new VpnConnectionsCreateOrUpdateOperation(),
        new VpnConnectionsDeleteOperation(),
        new VpnConnectionsGetOperation(),
        new VpnConnectionsListByVpnGatewayOperation(),
        new VpnConnectionsStartPacketCaptureOperation(),
        new VpnConnectionsStopPacketCaptureOperation(),
        new VpnGatewaysCreateOrUpdateOperation(),
        new VpnGatewaysDeleteOperation(),
        new VpnGatewaysGetOperation(),
        new VpnGatewaysListOperation(),
        new VpnGatewaysListByResourceGroupOperation(),
        new VpnLinkConnectionsGetIkeSasOperation(),
        new VpnLinkConnectionsListByVpnConnectionOperation(),
        new VpnServerConfigurationsAssociatedWithVirtualWanListOperation(),
        new VpnServerConfigurationsCreateOrUpdateOperation(),
        new VpnServerConfigurationsDeleteOperation(),
        new VpnServerConfigurationsGetOperation(),
        new VpnServerConfigurationsListOperation(),
        new VpnServerConfigurationsListByResourceGroupOperation(),
        new VpnSiteLinkConnectionsGetOperation(),
        new VpnSiteLinksGetOperation(),
        new VpnSiteLinksListByVpnSiteOperation(),
        new VpnSitesConfigurationDownloadOperation(),
        new VpnSitesCreateOrUpdateOperation(),
        new VpnSitesDeleteOperation(),
        new VpnSitesGetOperation(),
        new VpnSitesListOperation(),
        new VpnSitesListByResourceGroupOperation(),
    };
}
