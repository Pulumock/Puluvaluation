using Pulumi;
using PulumiProgram;

return await Deployment.RunAsync(async () => await CoreStack.DefineResourcesAsync());