# Project Description
   This project is a simple ASP.NET Core API that provides two main functionalities:
       1. Weather Forecast API – Returns weather forecasts for the next five days.
       2. Product Management API – Supports CRUD operations for managing product


# Project Structure :
   # 1- Weather Forecast
       1. WeatherForecastController.cs :
            The controller that handles incoming HTTP requests and returns weather forecasts.
            Uses dependency injection to access the WeatherForcastService.

       2. IWeatherForcastSevices.cs :
            The interface that defines the contract for the weather forecast service.

       3. WeatherForcastSevices.cs :
            The service that generates random weather forecasts for the next 5 days.

       4. WeatherForecast.cs :
            The model class that represents a weather forecast.

   # 2- Product Management :
      1. ProductController.cs: Handles CRUD operations for products.
      2. ApplicationDbContext.cs: Configures database access using Entity Framework Core.
      3. Products.cs: Model representing product data.


# Key Features
   1. Weather Forecast Endpoint:
       Retrieve a list of weather forecasts for the next 5 days.
        - Each forecast includes:
             Date
             Temperature in Celsius
             Temperature in Fahrenheit
             Weather summary (e.g., "Freezing", "Hot", "Mild")

   2. Dependency Injection:
        The WeatherForecastService is injected into the WeatherForecastController using dependency 
         injection.

   3. CRUD Operations: The API provides endpoints to create, read, update, and delete products.
        - Create Product: Add a new product to the database.
        - Read Products: Retrieve a list of all products or a single product by its ID.
        - Update Product: Modify an existing product's details.
        - Delete Product: Remove a product from the database.

          
   4. RESTful API:
        The API follows RESTful principles and returns JSON data.
   
