using System;
namespace AnimalShelterAPI.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public DateTime ArrivalDate { get; set; }
        
    }
}