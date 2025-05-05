# pulumock-evaluation

## Pulumi (without Pulumock)

- [Pulumi .NET repository](https://github.com/pulumi/pulumi-dotnet)
- [Official Unit Testing docs](https://www.pulumi.com/docs/iac/concepts/testing/unit/) (select C# in the guide)
- [Example (modern syntax used in the Program under test)](https://github.com/pulumi/examples/tree/master/testing-unit-cs-top-level-program): 
- Examples using the old syntax (can still be useful):
  - [Example 1](https://github.com/pulumi/examples/tree/master/testing-unit-cs)
  - [Example 2](https://github.com/pulumi/examples/tree/master/testing-unit-cs-mocks)
- [General Pulumi concepts](https://www.pulumi.com/docs/iac/concepts/)

### Specifics

- [Workaround for mocking Stack Configuration](https://github.com/pulumi/pulumi/issues/4472#issuecomment-618053293)

## Pulumock

- [Pulumock Repository](https://github.com/Pulumock/Pulumock)
- [Wiki](https://github.com/Pulumock/Pulumock/wiki) which is the official docs for Pulumock. Most interesting parts:
  - [Getting Started](https://github.com/Pulumock/Pulumock/wiki/Getting-Started)
  - [Cheat Sheet](https://github.com/Pulumock/Pulumock/wiki/Cheat-Sheet)
- [Example Project](https://github.com/Pulumock/Pulumock/tree/main/Source/Example.Tests.WithPulumock) containing a practical demonstration of how to use Pulumock.