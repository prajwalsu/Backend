using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using WebApiPractice.model;
using WebApiPractice.repository;

namespace WebApiPractice.Controllers
{
    
        //[EnableCors(origins: "", headers: "", methods: "*")]
        [ApiController]
        [Route("[Controller]")]
    public class CarController : ControllerBase
    {

        public readonly ICarRepository _carRepository;
            public CarController(ICarRepository carRepository) {
                _carRepository = carRepository;
            }

            public IActionResult Index() {

            var items =
        }



            [HttpGet]
            [Route("Car/Get")]
            public IEnumerable<Car> GetCar() {
                return _carRepository.GetAllCar();
            }



            [HttpGet]
            [Route("Car/Get/{Id}")]
            public Car GetCarById(int Id) {
                return _carRepository.GetCar(Id);
            }


            [HttpPost]
            [Route("Car/Post")]
            public Car AddCar(Car car) {
                var newcar = _carRepository.Add(car);
                return newcar;
            } //hardcoded so not executable


            [HttpDelete]
            [Route("Car/Delete/{Id}")]
            public Car DeleteCar(int Id) {
                var deletecar = _carRepository.Delete(Id);
                return deletecar;
            }


        }
    }

