# MTG Card Manager

MTG Card Manager is an API application designed to help Magic: The Gathering (MTG) enthusiasts manage their card collections and decks. The application provides functionality to recognize cards from images, retrieve specific data using Azure services, and enhance the data by calling the Scryfall API. It supports creating and managing collections and playdecks, with a SQL Server backend for data persistence.

A **Vite Vue.ts frontend** is planned for a smooth and modern user interface, allowing users to easily interact with the card recognition, collections, and deck-building features.


## Features
- **MTG Card Recognition**: Upload a photograph of your MTG cards, and the app will use Azure Custom Vision to recognize the cards.
- **Scryfall API Integration**: Once recognized, the app fetches detailed card data from the Scryfall API, including card text, rarity, types, and more.
- **Card Collection Management**: Create, update, and manage card collections.
- **Deck Management**: Build and manage play decks from your collection.
- **SQL Server Integration**: Uses SQL Server for data persistence.
- **Unit Testing**: Thoroughly tested using xUnit and FluentAssertions.

## Project Structure

The project follows a clean, modular architecture with distinct responsibilities for each component. Here is an overview of the structure:

### 1. **Shared Project**
   This project contains the shared models and DTOs (Data Transfer Objects) that are used across the application. It includes representations for MTG cards, collections, playdecks, and more.

### 2. **DataAccess Project**
   This layer handles database interactions, using the repository pattern to manage access to SQL Server. It contains:
   - **Repositories**: Interfaces and implementations for interacting with database entities (e.g., `CardRepository`, `CollectionRepository`).
   - **Database Context**: Configuration and management of the SQL Server database using Entity Framework Core.

### 3. **Recognition Project**
   This project integrates with Azure services to handle the recognition of MTG cards from photographs. It leverages:
   - **Azure Custom Vision** for card recognition.
   - **Azure Computer Vision (OCR)** for extracting any text from the cards.
   - **Scryfall API**: Once a card is recognized, the Scryfall API is used to fetch additional card information and metadata.

### 4. **Core Project**
   The Core project holds the business logic for the application. It serves as the middle layer between the `DataAccess` project and the controllers in the API. It contains:
   - **Services**: Business logic for handling cards, collections, and decks.
   - **Card Processing Logic**: Includes recognition, data enhancement, and validation rules.
   - **DTO Mappers**: Mapping logic between domain models and DTOs.

### 5. **API Project**
   This is the entry point for the application, exposing endpoints that allow clients to interact with the system. The API handles:
   - **Card recognition endpoint**: Allows users to upload images for card recognition.
   - **Collection and Deck Management**: Endpoints to manage collections and playdecks.
   - **Swagger**: The API is documented using Swagger for easy access and testing of endpoints.

### 6. **Test Project**
   The test project is built using `xUnit` and `FluentAssertions` to ensure the correctness of the business logic and data interactions. Unit tests are written to cover:
   - **Core Logic**: Ensure that all business logic works as expected.
   - **Repository Tests**: Validate the interactions with the database.
   - **API Tests**: Testing the API endpoints for correctness.

## Prerequisites

To run this project, you will need:
- **SQL Server**: For data storage.
- **Azure Account**: To use Custom Vision and Computer Vision services.
- **Scryfall API**: For MTG card data.

## Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repo/mtg-card-manager.git
   cd mtg-card-manager
2. **Configure SQL Server**:

    Update the connection string in appsettings.json with your SQL Server credentials.

3. **Configure Azure Services**:

    Set up Azure Custom Vision and Computer Vision services.
    Add your Azure API keys and endpoints to the environment or appsettings.json.

4. **Run Migrations**:

    Apply migrations to set up the database schema.

    ```bash

    dotnet ef database update

5. **Run the Application**:

   ```bash
   
    dotnet run --project API

    Access API Documentation:
        Visit https://localhost:<port>/swagger to view and interact with the API documentation.

## Architecture

The application follows a clean architecture, dividing the application into layers with clear separation of concerns:

    DataAccess: Manages all data interactions with SQL Server. The repository pattern ensures loose coupling between the business logic and the database.
    Core: The business logic layer that processes requests, handles recognition results, and manages collections and decks.
    API: The presentation layer that exposes functionality to clients via HTTP endpoints.
    Recognition: Handles integration with Azure services to recognize MTG cards from images and enhances the data with the Scryfall API.
    Test Project: Contains unit and integration tests to ensure system reliability.

## Contributing

Contributions are welcome! Please submit a pull request with a clear description of the changes you’ve made. Ensure that all tests pass before submitting.
License

This project is licensed under the MIT License.

## Key Sections:
1. **Features**: A summary of the application’s functionality.
2. **Project Structure**: Explains the architecture and purpose of each project.
3. **Prerequisites**: Outlines the necessary setup for running the project.
4. **Setup Instructions**: Step-by-step guide to getting the app up and running.
5. **Architecture**: Describes the clean architecture approach.
6. **Contributing**: Guidelines for contributing to the project.
7. **License**: Open-source license details (if applicable).

Let me know if you'd like any changes or additions!
