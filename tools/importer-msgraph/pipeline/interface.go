package pipeline

import (
	"fmt"
	"github.com/hashicorp/go-hclog"
	"github.com/hashicorp/pandora/tools/sdk/config/definitions"
	"path/filepath"
)

const namespace = "Pandora.Definitions.MicrosoftGraph"

type RunInput struct {
	Logger hclog.Logger

	MetadataDirectory        string
	OpenApiFile              string
	OutputDirectory          string
	ProviderPrefix           string
	Tags                     []string
	TerraformDefinitionsPath string
}

func Run(input RunInput) error {
	logger := input.Logger

	resources, err := definitions.LoadFromDirectory(input.TerraformDefinitionsPath)
	if err != nil {
		return fmt.Errorf("loading terraform definitions from %q: %+v", input.TerraformDefinitionsPath, err)
	}

	metadataGitSha, err := determineGitSha(input.MetadataDirectory, logger)
	if err != nil {
		return fmt.Errorf("determining Git SHA at %q: %+v", input.MetadataDirectory, err)
	}

	input.OutputDirectory = filepath.Join(input.OutputDirectory, namespace)

	return runImporter(input, resources, *metadataGitSha)
}
