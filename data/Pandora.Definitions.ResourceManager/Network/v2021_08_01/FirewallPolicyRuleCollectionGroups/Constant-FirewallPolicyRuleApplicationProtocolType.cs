using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.FirewallPolicyRuleCollectionGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FirewallPolicyRuleApplicationProtocolTypeConstant
{
    [Description("Http")]
    HTTP,

    [Description("Https")]
    HTTPS,
}
