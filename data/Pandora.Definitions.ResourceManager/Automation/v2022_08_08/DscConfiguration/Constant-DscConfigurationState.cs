using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Automation.v2022_08_08.DscConfiguration;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DscConfigurationStateConstant
{
    [Description("Edit")]
    Edit,

    [Description("New")]
    New,

    [Description("Published")]
    Published,
}