using Pulumi;
using Pulumi.AzureNative.Resources;

namespace PulumiProgram;

internal static class CoreStack
{
    // The method under test
    public static Task<Dictionary<string, object?>> DefineResourcesAsync()
    {
        // Stack Configuration (values from Pulumi.dev.yaml)
        var stackConfiguration = new Config("azure-native");
        
        // Resource
        var resourceGroup = new ResourceGroup("rg-logical-name", new ResourceGroupArgs
        {
            ResourceGroupName = "rg-name",
            Location = stackConfiguration.Require("location")
        });
        
        // Stack Outputs
        return Task.FromResult(new Dictionary<string, object?>
        {
            {"azureApiVersion", resourceGroup.AzureApiVersion }
        });
    }
}
