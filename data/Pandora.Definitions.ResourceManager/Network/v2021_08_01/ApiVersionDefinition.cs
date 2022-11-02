using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2021-08-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new ApplicationGatewayPrivateEndpointConnections.Definition(),
        new ApplicationGatewayPrivateLinkResources.Definition(),
        new ApplicationGateways.Definition(),
        new ApplicationSecurityGroups.Definition(),
        new AvailableDelegations.Definition(),
        new AvailableServiceAliases.Definition(),
        new AzureFirewalls.Definition(),
        new BastionHosts.Definition(),
        new BastionShareableLink.Definition(),
        new BgpServiceCommunities.Definition(),
        new CheckDnsAvailabilities.Definition(),
        new CloudServicePublicIPAddresses.Definition(),
        new ConnectionMonitors.Definition(),
        new CustomIPPrefixes.Definition(),
        new DdosCustomPolicies.Definition(),
        new DdosProtectionPlans.Definition(),
        new DscpConfiguration.Definition(),
        new DscpConfigurations.Definition(),
        new EndpointServices.Definition(),
        new ExpressRouteCircuitArpTable.Definition(),
        new ExpressRouteCircuitAuthorizations.Definition(),
        new ExpressRouteCircuitConnections.Definition(),
        new ExpressRouteCircuitPeerings.Definition(),
        new ExpressRouteCircuitRoutesTable.Definition(),
        new ExpressRouteCircuitRoutesTableSummary.Definition(),
        new ExpressRouteCircuitStats.Definition(),
        new ExpressRouteCircuits.Definition(),
        new ExpressRouteConnections.Definition(),
        new ExpressRouteCrossConnectionArpTable.Definition(),
        new ExpressRouteCrossConnectionPeerings.Definition(),
        new ExpressRouteCrossConnectionRouteTable.Definition(),
        new ExpressRouteCrossConnectionRouteTableSummary.Definition(),
        new ExpressRouteCrossConnections.Definition(),
        new ExpressRouteGateways.Definition(),
        new ExpressRouteLinks.Definition(),
        new ExpressRoutePortAuthorizations.Definition(),
        new ExpressRoutePorts.Definition(),
        new ExpressRoutePortsLocations.Definition(),
        new ExpressRouteServiceProviders.Definition(),
        new FirewallPolicies.Definition(),
        new FirewallPolicyRuleCollectionGroups.Definition(),
        new FlowLogs.Definition(),
        new IPAllocations.Definition(),
        new IPGroups.Definition(),
        new LoadBalancers.Definition(),
        new LocalNetworkGateways.Definition(),
        new NatGateways.Definition(),
        new NetworkInterfaces.Definition(),
        new NetworkProfiles.Definition(),
        new NetworkSecurityGroups.Definition(),
        new NetworkVirtualAppliances.Definition(),
        new NetworkWatchers.Definition(),
        new P2SVpnGateways.Definition(),
        new PacketCaptures.Definition(),
        new PeerExpressRouteCircuitConnections.Definition(),
        new PrivateDnsZoneGroups.Definition(),
        new PrivateEndpoints.Definition(),
        new PrivateLinkService.Definition(),
        new PrivateLinkServices.Definition(),
        new PublicIPAddresses.Definition(),
        new PublicIPPrefixes.Definition(),
        new RouteFilterRules.Definition(),
        new RouteFilters.Definition(),
        new RouteTables.Definition(),
        new Routes.Definition(),
        new SecurityPartnerProviders.Definition(),
        new SecurityRules.Definition(),
        new ServiceEndpointPolicies.Definition(),
        new ServiceEndpointPolicyDefinitions.Definition(),
        new ServiceTags.Definition(),
        new Subnets.Definition(),
        new TrafficAnalytics.Definition(),
        new Usages.Definition(),
        new VirtualApplianceSites.Definition(),
        new VirtualApplianceSkus.Definition(),
        new VirtualNetworkGatewayConnections.Definition(),
        new VirtualNetworkGateways.Definition(),
        new VirtualNetworkPeerings.Definition(),
        new VirtualNetworkTap.Definition(),
        new VirtualNetworkTaps.Definition(),
        new VirtualNetworks.Definition(),
        new VirtualRouterPeerings.Definition(),
        new VirtualRouters.Definition(),
        new VirtualWANs.Definition(),
        new VmssPublicIPAddresses.Definition(),
        new VpnGateways.Definition(),
        new VpnLinkConnections.Definition(),
        new VpnServerConfigurations.Definition(),
        new VpnSites.Definition(),
        new WebApplicationFirewallPolicies.Definition(),
        new WebCategories.Definition(),
    };
}
