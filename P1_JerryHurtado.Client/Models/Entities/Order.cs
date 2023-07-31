using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Client.Models.Entities
{
    public class Order
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Cliente Id")]
        [Required(ErrorMessage = "El id del cliente es requerido.")]
        public string CustomerId { get; set; }

        [DisplayName("Plato Id")]
        [Required(ErrorMessage = "El id del plato es requerido.")]
        public int DishId { get; set; }

        [DisplayName("Fecha de pedido")]
        public DateTime? DateOrder { get; set; }
    }
}