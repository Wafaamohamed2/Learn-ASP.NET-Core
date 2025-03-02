# Project Description
   This project is a simple Weather Forecast API built using ASP.NET Core. It provides endpoints to retrieve weather forecasts for the next few days.
   The API is designed to demonstrate basic concepts of ASP.NET Core, including dependency injection, services, and controllers.


# Project Structure :
   1. WeatherForecastController.cs
       The controller that handles incoming HTTP requests and returns weather forecasts.
       Uses dependency injection to access the WeatherForcastService.

2. IWeatherForcastSevices.cs :
       The interface that defines the contract for the weather forecast service.

3. WeatherForcastSevices.cs :
      The service that generates random weather forecasts for the next 5 days.

4. WeatherForecast.cs :
     The model class that represents a weather forecast.


# Key Features
   1. Weather Forecast Endpoint:
       Retrieve a list of weather forecasts for the next 5 days.
        - Each forecast includes:
             Date
             Temperature in Celsius
             Temperature in Fahrenheit
             Weather summary (e.g., "Freezing", "Hot", "Mild")

   2. Dependency Injection:
        The WeatherForecastService is injected into the WeatherForecastController using dependency injection.

   3. RESTful API:
        The API follows RESTful principles and returns JSON data.
   
