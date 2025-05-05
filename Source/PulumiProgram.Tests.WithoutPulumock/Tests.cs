using Pulumi;
using Pulumi.Testing;
using Pulumi.Utilities;
using Shouldly;
using Xunit;

namespace PulumiProgram.Tests.WithoutPulumock;

public class Tests
{
    [Fact]
    public async Task ResourceGroup_Location_Input_ShouldBeStackConfigurationLocationValue()
    {
        // 1. Setup mocks and run test
        //   - 🔧 Mock Stack Configuration: Ensure that the Stack Configuration key "azure-native:location" is mocked (see docs: https://github.com/pulumi/pulumi/issues/4472#issuecomment-618053293)
        var result = await Deployment.TestAsync(
            new EmptyMocks(), 
            new TestOptions { IsPreview = false },
            async () => await CoreStack.DefineResourcesAsync());
    
        // 2. Extract values
        //   - 🔧 Get the ResourceGroup
        //   - 🔧 Get the Location value from the ResourceGroup (Try to get the raw Input value, but fetching the Output value is also fine)
        //     - If accessing it from Output, the value is an Output<string>, so you need to extract the plain string value (hint: use OutputUtilities.GetValueAsync())
    
        // 3. Assert
        //   - 🔧 Assert that the extracted value is the same as the mocked value
        //   - Example: resourceGroupLocation.ShouldBe("your-mocked-location-here");
    }
    
    [Fact]
    public async Task StackOutput_AzureApiVersion_ShouldBe_ResourceGroup_AzureApiVersion_Output()
    {
        // 1. Setup mocks and run test
        //   - 🔧 Mock Stack Configuration: Ensure that the Stack Configuration key "azure-native:location" is mocked (same as above)
        //   - 🔧 Mock Resource: Ensure that the "AzureApiVersion" property of the "ResourceGroup" resource is mocked (see docs: https://www.pulumi.com/docs/iac/concepts/testing/unit/#add-mocks)
        var result = await Deployment.TestAsync(
            new EmptyMocks(), // Pass your mocks class here
            new TestOptions { IsPreview = false },
            async () => await CoreStack.DefineResourcesAsync());
        
        // 2. Extract values
        //   - 🔧 Access the value from the "azureApiVersion" Stack Output. It's an Output<string> so you need to extract the plain string value (hint: use OutputUtilities.GetValueAsync())
        
        // 3. Assert
        //   - 🔧 Assert the Stack Output value matches the mocked value.
        //   - Example: stackOutAzureApiVersion.ShouldBe("your-mocked-azure-api-version-here");
    }
}

public class Mocks : IMocks
{
    // 🔧 This is where you implement your resource mocks
    public Task<(string? id, object state)> NewResourceAsync(MockResourceArgs args)
    {
        throw new NotImplementedException();
    }

    // Ignore this, not used in the test cases
    public Task<object> CallAsync(MockCallArgs args)
    {
        return Task.FromResult<object>(args.Args);
    }
}