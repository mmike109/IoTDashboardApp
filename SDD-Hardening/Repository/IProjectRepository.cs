using SDD_Hardening.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SDD_Hardening.Repository
{
    public interface IProjectRepository
    {
        List<barometricpressure> GetAllBarometricPressure();
        List<battery> GetAllBatteries();
        List<humidity> GetAllHumidities();
        List<luminance> GetAllLuminance();
        List<temperature> GetAllTemperatures();
    }
}
