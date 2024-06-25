# GraphQL .NET Core Application Template

This repository provides a template for a .NET Core application that implements GraphQL following the Clean Architecture principles. This template aims to provide a solid foundation for building scalable and maintainable applications.

## Table of Contents

- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Dependencies](#dependencies)
- [Running the Application](#running-the-application)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get started with this template, follow these steps:

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/AndrewMaurice/GraphQLNet.git
   cd your-project
   ```
2. Restore the .NET dependencies:

   ```sh
   dotnet restore
   ```

## Project Structure

The project follows the Clean Architecture principles, separating concerns into different layers:

- **src**: Contains the source code
  - **Domain**: The core domain layer containing domain entities
  - **Application**: The application layer containing use cases, interfaces and the application business logic
  - **Persistence**: The infrastructure layer containing data access implementations
  - **API**: The presentation layer containing the GraphQL API and any web-related logic

### Folder Structure

```plaintext
├── src
│   ├── Domain
│   │   ├── Entities
│   ├── Application
│   │   ├── DTOs
│   │   ├── IServices
│   │   └── Services
│   ├── Persistence
│   │   ├── DB
│   │   ├── Repositories
│   │   └── IRepositories
│   └── API
│       ├── GraphQL
│       ├── Extensions
│       └── Program.cs
└── README.md
```

## Dependencies

The template includes the following dependencies:

* [HotChocolate](https://hotchocolate.io/) for GraphQL
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) for data access

## Running The Application

```shell
dotnet watch run --project ./MyGraphQlNet.API/MyGraphQlNet.API.csproj
```

The GraphQL Playground will be available at  `https://localhost:5001/graphql`.

## Contribution

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE]() file for details.
