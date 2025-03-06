# Project Description
   This project is a simple ASP.NET Core API that provides two main functionalities:
       1. Weather Forecast API – Returns weather forecasts for the next five days.
       2. Product Management API – Supports CRUD operations for managing product Additionally,
       the project includes middleware for request profiling and rate limiting, which enhance the API's functionality and security.

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

   # 3. Middleware
      1. ProfilingMiddleware.cs: Middleware that logs the time taken to process each HTTP request.
      2. RateLimitingMiddleware.cs: Middleware that limits the number of requests from a client within a specified time frame.


# Key Features
   1. Weather Forecast Endpoint:
        - Retrieve a list of weather forecasts for the next 5 days.
        - Each forecast includes:
             Date
             Temperature in Celsius
             Temperature in Fahrenheit
             Weather summary (e.g., "Freezing", "Hot", "Mild")

 2. Product Management Endpoints :
    
   1. Dependency Injection:
      - The WeatherForecastService is injected into the WeatherForecastController using dependency injection.
      - The ApplicationDbContext is injected into the ProductController for database operations.

   2. CRUD Operations: The API provides endpoints to create, read, update, and delete products.
        - Create Product: Add a new product to the database.
        - Read Products: Retrieve a list of all products or a single product by its ID.
        - Update Product: Modify an existing product's details.
        - Delete Product: Remove a product from the database.

   3. Middleware : 
       - Profiling Middleware: Logs the time taken to process each HTTP request, helping to monitor and optimize performance.
       - Rate Limiting Middleware: Limits the number of requests from a client to 5 requests per 10 seconds, preventing abuse and ensuring fair usage.
          
   4. RESTful API:
        The API follows RESTful principles and returns JSON data.


# Middleware Details :
     ~ Profiling Middleware
        - Purpose: Logs the time taken to process each HTTP request.
        - Implementation: 
            1. Uses Stopwatch to measure the elapsed time.
            2. Logs the request time in milliseconds using ILogger.

     ~ Rate Limiting Middleware
        - Purpose: Limits the number of requests from a client to 5 requests per 10 seconds.
        - Implementation:
            1. Tracks the number of requests (_counter) and the time of the last request (_lastRequestDate).
            2. If the limit is exceeded, the middleware returns a "Rate Limit Exceeded" message.


 # Conclusion : 
     This project demonstrates how to build a simple ASP.NET Core API with two main functionalities: weather forecasting and product management.
     It also includes middleware for request profiling and rate limiting, showcasing essential concepts such as dependency injection, RESTful API design, and middleware implementation. 
     The project is a great starting point for learning ASP.NET Core and building more complex applications.  
