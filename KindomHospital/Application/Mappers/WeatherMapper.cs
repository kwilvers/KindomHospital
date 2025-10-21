using KindomHospital.Application.DTOs;
using KindomHospital.Domain.Entities;

namespace KindomHospital.Application.Mappers;

public class WeatherMapper
{
    public WeatherDto ToDto(WeatherForecast entity)
    {
        //A NE PAS FAIRE VOUS DEVEZ UTILISER MAPPERLY cf slides
        //A NE PAS FAIRE VOUS DEVEZ UTILISER MAPPERLY cf slides
        //A NE PAS FAIRE VOUS DEVEZ UTILISER MAPPERLY cf slides
        return new WeatherDto(entity.Date,
            entity.TemperatureC,
            32 + (int) (entity.TemperatureC / 0.5556),
            entity.Summary);
    }
}