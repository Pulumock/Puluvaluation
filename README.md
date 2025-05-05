# Puluvaluation

You will write two unit tests targeting the `CoreStack.DefineResourcesAsync()` method in the `PulumiProgram` project. 
These tests will be implemented twice: once using **default Pulumi unit testing capabilities**, and once using **Pulumock**.

## Pre-requisites

- A code editor such as Rider, Visual Studio, or Visual Studio Code.
- [.NET 9.0 SDK.](https://dotnet.microsoft.com/en-us/download)

## Understanding the Program

The `PulumiProgram` defines and provisions infrastructure resources. The `CoreStack.DefineResourcesAsync()` method performs the core logic and is the focus of testing. It does the following:

- Reads configuration values from the **Stack Configuration** (`Pulumi.dev.yaml`).
  - Uses the `namespace:key: value` format (e.g., `azure-native:location: "swedencentral"`)
- Creates a **Resource** (`ResourceGroup`).
  - Takes **Inputs**, in this case the `Location` coming from **Stack Configuration**.
  - Returns **Outputs** that can be used by other components in the program.
- Exposes selected **Outputs** as **Stack Outputs**, making them accessible to other stacks.

## Implementing Tests

You will work only in the `Tests` classes, where you will:

- **Mock**:
  - The **Stack Configuration** value for *location* (`azure-native:location: "swedencentral"`)
  - The **Resource** *Azure API version* Output (`ResourceGroup.AzureApiVersion`)
- **Run** the test to simulate the deployment and capture the result.
- **Assert** that the inputs and outputs behave as expected.

## Resources You Can Use

You're encouraged to use the internet, tools, and all provided resources to complete the task as you normally would. See relevant resources:

- [Docs for tests without Pulumock](./Source/PulumiProgram.Tests.WithoutPulumock/DOCS.md)
- [Docs for tests with Pulumock](./Source/PulumiProgram.Tests.WithPulumock/DOCS.md)
