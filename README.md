# GoogleSheetCRUD

This project is a C# console application that demonstrates how to perform CRUD (Create, Read, Update, Delete) operations on Google Sheets using the Google Sheets API.

## Project Overview

- **Language:** C# (.NET 10.0)
- **Purpose:** Provides a simple interface to interact with Google Sheets as if they were a database, allowing you to manage data for entities such as `Product`.
- **Key Files:**
  - `Program.cs`: Entry point of the application. Handles user interaction and orchestrates CRUD operations.
  - `GoogleSheetService.cs`: Contains logic for authenticating with Google and performing CRUD operations on the sheet.
  - `Product.cs`: Example entity representing a product with properties like Id, Name, and Price.
  - `IEntityWithId.cs`: Interface to ensure entities have an Id property.
  - `Constant.cs`: Stores constants such as spreadsheet ID, sheet names, and other configuration values.

## Prerequisites

- .NET 10.0 SDK or later
- Google Cloud project with Sheets API enabled
- OAuth 2.0 credentials (client_secret.json) downloaded from Google Cloud Console
- The following NuGet packages installed:
  - `Google.Apis.Sheets.v4`
  - `Google.Apis.Auth`
  - `Newtonsoft.Json`

## Setup Instructions

1. **Clone the repository**

   ```sh
   git clone <your-repo-url>
   cd GoogleSheetCRUD
   ```

2. **Add Google API Credentials**

   - Download `client_secret.json` from your Google Cloud Console.
   - Place it in the project root directory.

3. **Restore NuGet Packages**

   ```sh
   dotnet restore
   ```

4. **Build the Project**

   ```sh
   dotnet build
   ```

5. **Run the Application**

   ```sh
   dotnet run
   ```

   The application will prompt you to authenticate with your Google account the first time you run it.

## Usage

- The application provides a menu-driven interface to:
  - List all products
  - Add a new product
  - Update an existing product
  - Delete a product

- All data is stored in a Google Sheet specified by the spreadsheet ID in `Constant.cs`.

## Project Structure

- `GoogleSheetService.cs`: Handles all communication with the Google Sheets API, including authentication and CRUD operations.
- `Product.cs`: Defines the data model for products.
- `IEntityWithId.cs`: Interface for entities with an Id.
- `Constant.cs`: Contains configuration constants.
- `Program.cs`: Main program logic and user interface.

## Customization

- To use a different entity, create a new class implementing `IEntityWithId` and update the logic in `GoogleSheetService.cs` and `Program.cs` accordingly.
- Update `Constant.cs` to change the spreadsheet ID or sheet name.

## License

This project is provided for educational purposes. Please check the repository for license details.
