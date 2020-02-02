using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterContext _dataBase;
        public AnimalsController(AnimalShelterContext dataBase)
        {
            _dataBase = dataBase;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(string name, string type, DateTime arrivalDate)
        {
            var query = _dataBase.Animals.AsQueryable();
            if(name!=null)
            {
                query = query.Where(animals => animals.AnimalName==name);
            }
            else if(type!=null)
            {
                query = query.Where(animals => animals.AnimalType==type);
            }
            else if(arrivalDate!=null)
            {
                query = query.Where(animals => animals.ArrivalDate==arrivalDate);
            }
            return query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            Animal foundAnimal = _dataBase.Animals.FirstOrDefault(row=>row.AnimalId==id);
            return foundAnimal;
        }

        // POST api/animal
        [HttpPost]
        public void Post([FromBody] Animal new_animal)
        {
            _dataBase.Animals.Add(new_animal);
            _dataBase.SaveChanges();
        }

        //PUT api/animals/id (update animal)
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal new_animal)
        {
            new_animal.AnimalId = id;
            _dataBase.Entry(new_animal).State=EntityState.Modified;
            _dataBase.SaveChanges();
        }

        //DELETE api/animals/id (delete animal)
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Animal foundAnimal = _dataBase.Animals.FirstOrDefault(animals => animals.AnimalId==id);
            _dataBase.Animals.Remove(foundAnimal);
            _dataBase.SaveChanges();
        }
    }
}
