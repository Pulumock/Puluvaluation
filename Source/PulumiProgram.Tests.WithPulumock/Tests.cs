using Pulumock.TestFixtures;
using Shouldly;
using Xunit;

namespace PulumiProgram.Tests.WithPulumock;

public class Tests
{
    [Fact]
    public async Task ResourceGroup_Location_Input_ShouldBeStackConfigurationLocationValue()
    {
        // 1. Setup mocks and run test
        //   - 🔧 Mock Stack Configuration: Ensure that the Stack Configuration key "azure-native:location" is mocked
        var fixture = await new FixtureBuilder()
            // Chain your mocks here
            .BuildAsync(async () => await CoreStack.DefineResourcesAsync());
    
        // 2. Extract values
        //   - 🔧 Get the ResourceGroup
        //   - 🔧 Get the Location value from the ResourceGroup (Try to get the raw Input value, but fetching the Output value is also fine)
    
        // 3. Assert
        //   - 🔧 Assert that the extracted value is the same as the mocked value
        //   - Example: resourceGroupLocation.ShouldBe("your-mocked-location-here");
    }
    
    [Fact]
    public async Task StackOutput_AzureApiVersion_ShouldBe_ResourceGroup_AzureApiVersion_Output()
    {
        // 1. Setup mocks and run test
        //   - 🔧 Mock Stack Configuration: Ensure that the Stack Configuration key "azure-native:location" is mocked (same as above)
        //   - 🔧 Mock Resource: Ensure that the "AzureApiVersion" property of the "ResourceGroup" resource is mocked
        var fixture = await new FixtureBuilder()
            // Chain your mocks here
            .BuildAsync(async () => await CoreStack.DefineResourcesAsync());
        
        // 2. Extract values
        //   - 🔧 Access the value from the "azureApiVersion" Stack Output. It's an Output<string> so you need to extract the plain string value
        
        // 3. Assert
        //   - 🔧 Assert the Stack Output value matches the mocked value.
        //   - Example: stackOutAzureApiVersion.ShouldBe("your-mocked-azure-api-version-here");
    }
}