# AS-MSSQL-API [![.NET](https://github.com/MishkaMishka/AS-MSSQL-API/actions/workflows/dotnet.yml/badge.svg?branch=master)](https://github.com/MishkaMishka/AS-MSSQL-API/actions/workflows/dotnet.yml)

## Overview

`AS-MSSQL-API` is an ASP.NET Core Web API designed to manage articles and their associated prices using a Microsoft SQL Server database. The API provides endpoints to retrieve and manipulate data related to articles and their prices.

## Features

- **Retrieve Articles**: Get all articles or fetch a specific article by its ID.
- **Retrieve Prices**: Fetch all prices associated with a specific article.
- **Add New Prices**: Add new prices to an existing article.
- **Add New Articles**: Create new articles and optionally associate prices with them.

## API Endpoints

### 1. Get All Articles

- **Endpoint**: `GET /api/articles`
- **Description**: Retrieves a list of all articles.
- **Response**: JSON array of articles.

### 2. Get Article By ID

- **Endpoint**: `GET /api/articles/{id}`
- **Description**: Retrieves a single article by its ID.
- **Parameters**: 
  - `id` (int): The ID of the article.
- **Response**: JSON object of the article or `404 Not Found` if the article does not exist.

### 3. Get Prices for Article

- **Endpoint**: `GET /api/articles/{articleId}/prices`
- **Description**: Retrieves all prices associated with a specific article.
- **Parameters**: 
  - `articleId` (int): The ID of the article.
- **Response**: JSON array of prices.

### 4. Add Price to Article

- **Endpoint**: `POST /api/articles/{articleId}/prices`
- **Description**: Adds a new price for a specific article.
- **Parameters**: 
  - `articleId` (int): The ID of the article.
- **Request Body**: JSON object with price details.
- **Response**: 
  - `201 Created` with details of the newly added price.
  - `404 Not Found` if the article does not exist.

### 5. Add New Article

- **Endpoint**: `POST /api/articles`
- **Description**: Adds a new article.
- **Request Body**: JSON object with article details.
- **Response**: 
  - `201 Created` with details of the newly created article.

## Setup and Launch Guide

### 1. Publish `WarehouseDB`
- Restore or import the `WarehouseDB` database to your local SQL Server instance using SQL Server Management Studio (SSMS).

### 2. Execute `LoadDummyData`
- Open SSMS and execute the `LoadDummyData` stored procedure in the `WarehouseDB` database to populate the necessary tables.

### 3. Configure `appsettings.json`
- Update the connection string in `appsettings.json` to connect to your local SQL Server instance with the `WarehouseDB` database. Ensure to replace placeholder values with your SQL Server credentials.

### 4. Launch the Application

- **Swagger:** Start the application and navigate to `http://localhost:{port}/swagger` to view and test the API endpoints.
- **Postman:** Use Postman to test API endpoints at `http://localhost:{port}/api/Articles` or other relevant URLs.
- **AS-MSSQL-API.http:** Run pre-configured HTTP requests to interact with the API.

### 5. Verify Functionality

- Ensure that API endpoints are working as expected and interacting correctly with the `WarehouseDB` database. Use logging for debugging if necessary.

## Additional Notes

- Ensure your local SQL Server instance is running and accessible.
- Update the `appsettings.json` file as needed for different environments or credentials.

For more information on the API and its endpoints, refer to the Swagger documentation or the `AS-MSSQL-API.http` file.


## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
