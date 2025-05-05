using Pulumi;
using Pulumi.Testing;
using Shouldly;
using Xunit;

namespace PulumiProgram.Tests.WithoutPulumock;

public class ExampleTests
{
    // This test verifies that missing mocking of the required Stack Configuration causes the Program to crash.
    // You should not implement this.
    [Fact]
    public async Task MissingRequiredStackConfigurationValue_ShouldThrowRunException()
    {
        var ex = await Should.ThrowAsync<RunException>(async () =>
        {
            _ = await Deployment.TestAsync(
                new EmptyMocks(), 
                new TestOptions { IsPreview = false },
                async () => await CoreStack.DefineResourcesAsync());
        });
        
        ex.Message.ShouldContain("Missing Required configuration variable 'azure-native:location'");
    }
}