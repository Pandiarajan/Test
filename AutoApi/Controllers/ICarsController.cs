﻿using AutoApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutoApi.Controllers
{
    public interface ICarsController
    {
        ActionResult<IEnumerable<Car>> Get();
        ActionResult<Car> Get(int id);
        ActionResult<Car> Post(CarContract car);
        void Delete(int carId);
    }
}