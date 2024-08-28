Foody Web App Automation Tests
This repository contains End-to-End (E2E) automation tests for the Foody Web Application. The tests are designed to cover critical functionalities of the application, ensuring that key user interactions perform as expected.

Overview
The Foody Web App allows users to manage their food-related activities through various functionalities, such as creating, editing, and deleting items. This test suite automates the verification of these functionalities to ensure the application's reliability and robustness.

Covered Functionalities
The automation tests focus on the following core functionalities:

Login:

Objective: Ensure that users can log in successfully with valid credentials.
Test Scenarios:
Valid login with correct username and password.
Validation error on login with incorrect credentials.
Create:

Objective: Verify that users can create new entries in the application.
Test Scenarios:
Creating a new item with valid data.
Handling edge cases, such as creating with missing or invalid data.
Edit:

Objective: Ensure that users can edit existing entries.
Test Scenarios:
Editing an existing item with valid changes.
Validating that changes are correctly saved and reflected.
Delete:

Objective: Confirm that users can delete existing entries.
Test Scenarios:
Deleting an item and verifying it is removed from the list.
Ensuring the system handles cases where the item no longer exists or the deletion is canceled.
Technology Stack
Testing Framework: NUnit, xUnit, or MSTest (choose based on your actual implementation)
Programming Language: C#
CI/CD Integration: GitHub Actions (if applicable)
Prerequisites
Visual Studio (2019 or later recommended)
.NET SDK (compatible version with your project)
Git
Installation and Setup
Clone the repository:

bash
Copy code
git clone https://github.com/Vencislav0/FoodyWebAppAutomationTests.git
Open the solution in Visual Studio:

Navigate to the project directory and open the .sln file.
Restore NuGet packages:

Visual Studio will automatically restore NuGet packages upon opening the solution. If not, you can manually restore them by right-clicking on the solution in the Solution Explorer and selecting Restore NuGet Packages.
Build the solution:

Build the solution to ensure all dependencies are correctly installed and the project is configured properly.
Running the Tests
To run the tests, follow these steps:

Open the Test Explorer in Visual Studio by navigating to Test > Test Explorer.
Click Run All to execute all tests in the suite.
Alternatively, you can run tests using the command line:

bash
Copy code
dotnet test
This command will run all the tests in the solution and output the results to the console.

Test Structure
The tests are organized into the following directories:

/Tests: Contains all test files, organized by feature (e.g., LoginTests.cs, CreateTests.cs).
/Fixtures: Holds any mock data or JSON files used to simulate API responses or input data.
/Helpers: Contains utility classes and methods that support test operations.
Continuous Integration
The project can be integrated with a Continuous Integration (CI) system such as GitHub Actions, Azure DevOps, or Jenkins to automatically run the test suite on every push or pull request.

Reporting
Test results are available in the Test Explorer in Visual Studio. For more detailed reporting, you can configure output formats using extensions or built-in features within the chosen testing framework (e.g., NUnit, xUnit, MSTest).


License
This project is licensed under the MIT License - see the LICENSE file for details.











