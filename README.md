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

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
