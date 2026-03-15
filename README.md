# Mortgage Calculator

![.NET](https://img.shields.io/badge/.NET-Framework%204.8-blue) ![Entity
Framework](https://img.shields.io/badge/EntityFramework-6.5-green)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET-MVC-orange)
![Windows
Forms](https://img.shields.io/badge/Desktop-WinForms-lightgrey)
![NUnit](https://img.shields.io/badge/Test-NUnit-red)

A **Mortgage Calculator application** developed as part of a technical
machine test.

The original repository contained **unfinished code and compilation
issues**.\
This solution focuses on **troubleshooting the existing project, fixing
architectural problems, and completing the application**.

The completed project supports **both Web and Windows desktop
platforms** and follows a **clean N-Layer Architecture** for
maintainability and scalability.

------------------------------------------------------------------------

# Application Preview

### Web Application

Add screenshot later: `docs/web-ui.png`

### Windows Forms Application

Add screenshot later: `docs/winforms-ui.png`

------------------------------------------------------------------------

#  System Architecture

The solution is designed using **N-Layer Architecture** to separate
responsibilities across layers.

    Presentation Layer
    │
    ├── MortgageCalculator.Web
    │       ASP.NET MVC Web Application
    │
    ├── MortgageCalculator.WinFormsUI
    │       Windows Desktop Application
    │
    Business Layer
    │
    ├── MortgageCalculator.Services
    │       Business logic and mortgage calculation
    │
    Data Access Layer
    │
    ├── MortgageCalculator.Data
    │       Entity models
    │       DbContext
    │       Repository pattern
    │
    Shared Layer
    │
    ├── MortgageCalculator.Dto
    │       Data transfer objects
    │
    Testing Layer
    │
    └── MortgageCalculator.UnitTests
            NUnit test project

------------------------------------------------------------------------

#  Features

## Mortgage Listing

Retrieve **active mortgages** based on:

-   Effective Start Date
-   Effective End Date

------------------------------------------------------------------------

## Sorting Support

Mortgage records can be sorted by:

-   Mortgage Type
-   Interest Rate

------------------------------------------------------------------------

## Mortgage Type Autocomplete

The Web UI supports **smart autocomplete** using:

-   **jQuery**
-   **Select2**

------------------------------------------------------------------------

## Mortgage Calculator

Users can enter:

-   Loan Amount
-   Interest Rate
-   Loan Duration (Years)

The system calculates:

-   Monthly repayment
-   Total repayment
-   Total interest paid

------------------------------------------------------------------------

## Windows Desktop UI

The Windows Forms application includes:

-   Mortgage list display
-   Mortgage type dropdown
-   Loan calculation fields
-   Clear/reset functionality

------------------------------------------------------------------------

## Unit Testing

Implemented using **NUnit**.

Test scenarios include:

-   Mortgage calculation accuracy
-   Zero interest scenarios
-   Invalid input validation
-   Active mortgage filtering
-   Sorting behavior

------------------------------------------------------------------------

# Technology Stack

 | Technology           | Purpose                |
| -------------------- | ---------------------- |
| .NET Framework 4.8   | Application Framework  |
| Entity Framework 6.5 | Data access ORM        |
| ASP.NET MVC          | Web UI                 |
| Windows Forms        | Desktop UI             |
| jQuery               | Client scripting       |
| Select2              | Autocomplete dropdown  |
| NUnit                | Unit testing framework |

------------------------------------------------------------------------

#  Database Setup

The application uses **SQL Server LocalDB**.

Connection string configuration is located in:

-   `Web.config`
-   `App.config`

Example:

    Data Source=(localdb)\MSSQLLocalDB
    Initial Catalog=MortgageCalculatorDb
    Integrated Security=True

------------------------------------------------------------------------

#  How to Run the Project

### 1. Restore NuGet Packages

    NuGet Restore

### 2. Setup Database

Create the database or run the provided SQL scripts.

### 3. Update Connection String

Modify connection string if required.

### 4. Run Application

Run either:

-   `MortgageCalculator.Web`
-   `MortgageCalculator.WinFormsUI`

------------------------------------------------------------------------

#  Project Structure

    MortgageCalculator
    │
    ├── MortgageCalculator.Dto
    ├── MortgageCalculator.Data
    ├── MortgageCalculator.Services
    ├── MortgageCalculator.Web
    ├── MortgageCalculator.WinFormsUI
    └── MortgageCalculator.UnitTests

------------------------------------------------------------------------

#  Author

Machine Test Submission By Arivazhagan

------------------------------------------------------------------------

#  Future Improvements

Possible enhancements:

-   REST API for mortgage services
-   ASP.NET Core migration
-   Docker containerization
-   CI/CD pipeline
