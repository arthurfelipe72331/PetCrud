using System.ComponentModel.DataAnnotations;

namespace PetCrud.Models
{
    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string raca { get; set; }
    }
}
