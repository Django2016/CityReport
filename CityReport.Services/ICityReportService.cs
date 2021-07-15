using CityReport.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityReport.Services
{
    public interface ICityReportService
    {
        Task<LocationDTO> GetLocation(string name);
        Task<CurrentDTO> GetCurrent(string name);
        Task<AstronomyDTO> GetAstronomy(string name);
    }
}
