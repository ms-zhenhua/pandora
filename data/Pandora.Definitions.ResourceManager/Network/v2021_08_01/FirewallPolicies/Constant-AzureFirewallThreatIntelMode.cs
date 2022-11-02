using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.FirewallPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AzureFirewallThreatIntelModeConstant
{
    [Description("Alert")]
    Alert,

    [Description("Deny")]
    Deny,

    [Description("Off")]
    Off,
}
