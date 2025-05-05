using Pulumi;
using PulumiProgram;

#pragma warning disable CA2007
return await Deployment.RunAsync(async () => await CoreStack.DefineResourcesAsync());
#pragma warning restore CA2007
