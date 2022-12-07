using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using WebApiPractice2.model;
using WebApiPractice2.repository;

namespace WebApiPractice2.Controllers
{ 

    [EnableCors(origins: "", headers: "", methods: "*")]
        [ApiController]
        [Route("[Controller]")]

    public class KabaddiController : ControllerBase
    {
    public readonly IKabaddiRepository _kabaddiRepository;
    public KabaddiController(IKabaddiRepository kabaddiRepository) {
        _kabaddiRepository = kabaddiRepository;
    }



    [HttpGet]
    [Route("Kabaddi/Get")]
    public IEnumerable<Kabaddi> GetKabaddi() {
        return _kabaddiRepository.GetAllKabaddi();
    }



    [HttpGet]
    [Route("Kabaddi/Get/{id}")]
    public Kabaddi GetKabaddiById(int id) {
        return _kabaddiRepository.GetKabaddi(id);
    }


    [HttpPost]
    [Route("Kabaddi/Post")]
    public Kabaddi AddCar(Kabaddi kabaddi) {
        var newKPlayer = _kabaddiRepository.Add(kabaddi);
        return newKPlayer;
    } //hardcoded so not executable


    [HttpDelete]
    [Route("Kabaddi/Delete/{id}")]
    public Kabaddi DeleteKabaddi(int id) {
        var deletekabaddi = _kabaddiRepository.Delete(id);
        return deletekabaddi;
    }


}
}
