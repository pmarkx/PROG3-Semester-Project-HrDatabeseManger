﻿using Microsoft.AspNetCore.Http;
using DCQEB4_HFT_2021221.Logic;
using DCQEB4_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCQEB4_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeLogic emp;
        public EmployeeController(IEmployeeLogic emp)
        {
            this.emp = emp;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emp.GetAll();
        }
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return emp.GetOne(id);
        }
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            emp.Create(value);
        }
        [HttpPut]
        public void Put([FromBody] Employee value)
        {
            emp.Update(value);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            emp.Delete(id);
        }
    }
}
