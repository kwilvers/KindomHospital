﻿namespace KindomHospital.Application.DTOs;

public record WeatherDto(DateOnly Date, int TemperatureC, int TemperatureF, string? Summary);

