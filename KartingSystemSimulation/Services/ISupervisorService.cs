﻿using KartingSystemSimulation.DTOs;
using KartingSystemSimulation.Models;

namespace KartingSystemSimulation.Services
{
    public interface ISupervisorService
    {
        int AddSupervisor(SupervisorInputDTO supervisor);
        void DeleteSupervisor(int supervisorId);
        IEnumerable<Supervisor> GetAllSupervisors();
        Supervisor GetSupervisorById(int supervisorId);
        void UpdateSupervisor(Supervisor supervisor);
    }
}