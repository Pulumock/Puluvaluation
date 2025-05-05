using Pulumi;
using Pulumi.AzureNative.Resources;

namespace PulumiProgram;

internal static class CoreStack
{
    // The method under test
    public static Task<Dictionary<string, object?>> DefineResourcesAsync()
    {
        // Resource
        // - Takes Inputs in the constructor
        // - Returns Outputs available on the "resourceGroup" variable
        var resourceGroup = new ResourceGroup("rg-logical-name", new ResourceGroupArgs
        {
            // Depends on Stack Configuration value coming from "Pulumi.dev.yaml" (has to be mocked) 🚨
            // - "azure-native" is the namespace
            // - "location" is the key
            Location = new Config("azure-native").Require("location")
        });
        
        // Stack Outputs
        return Task.FromResult(new Dictionary<string, object?>
        {
            // Depends on 'resourceGroup.AzureApiVersion' Output value (has to be mocked) 🚨 
            {"azureApiVersion", resourceGroup.AzureApiVersion }
        });
    }
}
