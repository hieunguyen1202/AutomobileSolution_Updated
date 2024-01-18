﻿using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carId) => CarDBContext.Instance.GetCarByID(carId);
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarsList;
        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);
        public void DeleteCar(int carID) => CarDBContext.Instance.Remove(carID);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}