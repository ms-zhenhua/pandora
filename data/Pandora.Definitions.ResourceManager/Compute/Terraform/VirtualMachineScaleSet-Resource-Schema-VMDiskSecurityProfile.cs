using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Compute.Terraform;

public class VirtualMachineScaleSetResourceVMDiskSecurityProfileSchema
{

    [HclName("disk_encryption_set")]
    [Optional]
    public VirtualMachineScaleSetResourceSubResourceSchema DiskEncryptionSet { get; set; }


    [HclName("security_encryption_type")]
    [Optional]
    [PossibleValuesFromConstant(typeof(v2021_11_01.VirtualMachineScaleSets.SecurityEncryptionTypesConstant))]
    public string SecurityEncryptionType { get; set; }

}