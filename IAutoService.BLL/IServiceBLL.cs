﻿using System.Collections;
using System.Collections.Generic;
using IAutoService.DAL.Entities;

namespace IAutoService.BLL
{
    public interface IServiceBLL
    {
        Service Create(string name, double price);
        IEnumerable<Service> GetAll();
        int Delete(long id);
        // ServiceEmployee WriteEmployee(long serviceId, long employeeId);
        // int WriteOutEmployee(long serviceId, long employeeId);
        // IEnumerable<Employee> GetAllByService(long serviceId);
    }
}