using System.ComponentModel;

namespace P1_JerryHurtado.Client.Models.ViewModels
{
    public class DishViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }

        [DisplayName("Categoría Id")]
        public int CategoryId { get; set; }

        [DisplayName("Categoría")]
        public string CategoryName { get; set; }
    }
}