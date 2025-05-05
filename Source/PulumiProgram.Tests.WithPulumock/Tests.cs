using Pulumi;
using Shouldly;
using Xunit;

namespace PulumiProgram.Tests.WithPulumock;

public class Tests
{
    // [Fact]
    // public async Task MissingRequiredStackConfigurationValue_ShouldThrowRunException()
    // {
    //     var ex = await Should.ThrowAsync<RunException>(async () =>
    //     {
    //         // Setup mocks and run test here
    //         // - Ensure that the stack configuration property "azure-native:location" is NOT mocked
    //     });
    //
    //     // Verify that the exception message indicates the missing configuration.
    //     ex.Message.ShouldContain("Missing Required configuration variable 'azure-native:location'");
    // }
    
    // [Fact]
    // public async Task ResourceGroup_Location_Input_ShouldBeStackConfigurationLocationValue()
    // {
    //     // Setup mocks and run test
    //     // - Ensure that the stack configuration property "azure-native:location" is mocked
    //
    //     // Get the ResourceGroup
    //
    //     // Get the Location value from the ResourceGroup
    //
    //     // Assert that the value is the same as the mocked value
    //     // resourceGroupLocation.ShouldBe("your-mocked-value-here");
    // }
    
    // [Fact]
    // public async Task StackOutput_AzureApiVersion_ShouldBe_ResourceGroup_AzureApiVersion_Output()
    // {
    //     // Setup mocks and run test
    //     // - Ensure that the stack configuration property "azure-native:location" is mocked
    //     // - Ensure that the ResourceGroup.AzureApiVersion property is mocked
    //     
    //     // Access the Stack Output "azureApiVersion" value. It is an Output<string> so you need to extract the plain string value.
    //     
    //     // Assert the stack output value should match the mocked Azure API version from the ResourceGroup.
    //     // stackOutAzureApiVersion.ShouldBe("your-mocked-value-here");
    // }
}