﻿using ship_request_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship_request_app.Services
{
    public static class AppService
    {
        public static void RegisterUser(string name, string email, string password, string buildingNumber, string apartmentNumber)
        {
            var register = new Register()
            { 
                Name = name,
                Email = email,
                Password = password,
                BuildingNumber = buildingNumber,
                ApartmentNumber= apartmentNumber 
            };

            // TODO: Update the User Table in the database

        }
    }
}
