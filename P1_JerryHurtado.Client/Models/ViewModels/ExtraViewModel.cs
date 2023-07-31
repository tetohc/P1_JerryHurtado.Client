using System.ComponentModel;

namespace P1_JerryHurtado.Client.Models.ViewModels
{
    public class ExtraViewModel
    {
        [DisplayName("Id de Extra")]
        public int Id { get; set; }

        [DisplayName("Id de Categoría")]
        public int CategoryId { get; set; }

        [DisplayName("Categoría")]
        public string Category { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Estado")]
        public string Status { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }
    }
}