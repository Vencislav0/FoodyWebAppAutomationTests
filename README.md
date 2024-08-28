# Foody Web App Automation Tests

This repository contains End-to-End (E2E) automation tests for the Foody Web Application, developed using C#. The tests cover essential functionalities, ensuring that critical features such as login, creation, editing, and deletion work as intended.

## Overview

The Foody Web App is a platform that allows users to manage their food-related activities. This test suite automates the verification of key functionalities to ensure that the application is reliable and performs as expected.

## Covered Functionalities

The automation tests focus on the following core functionalities:

1. **Login**:
   - **Objective**: Verify that users can log in with valid credentials.
   - **Test Scenarios**:
     - Successful login with correct username and password.
     - Display of validation messages on login failure with incorrect credentials.

2. **Create**:
   - **Objective**: Ensure users can create new items in the application.
   - **Test Scenarios**:
     - Creation of a new item with valid input data.
     - Handling of edge cases, such as creation with missing or invalid data.

3. **Edit**:
   - **Objective**: Verify that users can edit existing items.
   - **Test Scenarios**:
     - Successful editing of an existing item with valid changes.
     - Validation that changes are correctly saved and displayed.

4. **Delete**:
   - **Objective**: Confirm that users can delete items.
   - **Test Scenarios**:
     - Successful deletion of an item and verification that it is removed from the list.
     - Handling cases where the item no longer exists or the deletion is canceled.

## Technology Stack

- **Programming Language**: C#
- **Testing Framework**: [NUnit](https://nunit.org/), [xUnit](https://xunit.net/), or [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/) (choose based on your actual implementation)
- **Package Manager**: NuGet

## Prerequisites

- Visual Studio (2019 or later recommended)
- .NET SDK (compatible version with your project)
- Git

## Installation and Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Vencislav0/FoodyWebAppAutomationTests.git
3. Restore NuGet packages:
   - Visual Studio will automatically restore NuGet packages upon opening the solution. If not, you can manually restore them by right-clicking on the solution in the **Solution Explorer** and selecting **Restore NuGet Packages**.

4. Build the solution:
   - Build the solution to ensure all dependencies are correctly installed and the project is configured properly.

## Running the Tests

To run the tests, follow these steps:

1. Open the **Test Explorer** in Visual Studio by navigating to **Test** > **Test Explorer**.
2. Click **Run All** to execute all tests in the suite.

Alternatively, you can run tests using the command line:

    ```bash
    dotnet test

## Continuous Integration

The project can be integrated with a Continuous Integration (CI) system such as GitHub Actions, Azure DevOps, or Jenkins to automatically run the test suite on every push or pull request.

## Reporting

Test results are available in the Test Explorer in Visual Studio. For more detailed reporting, you can configure output formats using extensions or built-in features within the chosen testing framework (e.g., NUnit, xUnit, MSTest).












