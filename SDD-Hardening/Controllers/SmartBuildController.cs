﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SDD_Hardening.Repository;

namespace SDD_Hardening.Controllers
{
    [Authorize]
    public class SmartBuildController : Controller
    {
        private readonly IProjectRepository _repository;
        public SmartBuildController(IProjectRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetBarometric()
        {
            return Ok(_repository.GetAllBarometricPressure());
        }

        [HttpGet]
        public IActionResult GetBattery()
        {
            return Ok(_repository.GetAllBatteries());
        }

        [HttpGet]
        public IActionResult GetHumidity()
        {
            return Ok(_repository.GetAllHumidities());
        }

        [HttpGet]
        public IActionResult GetLuminance()
        {
            return Ok(_repository.GetAllLuminance());
        }

        [HttpGet]
        public IActionResult GetTemperature()
        {
            return Ok(_repository.GetAllTemperatures());
        }
    }
}