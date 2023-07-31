using System.ComponentModel;

namespace P1_JerryHurtado.Client.Models.ViewModels
{
    public class OrderViewModel
    {
        [DisplayName("Pedido Id")]
        public int Id { get; set; }

        [DisplayName("Cliente Id")]
        public string CustomerId { get; set; }

        [DisplayName("Plato Id")]
        public int DishId { get; set; }

        [DisplayName("Fecha de pedido")]
        public DateTime? DateOrder { get; set; }

        [DisplayName("Cliente")]
        public string CustomerName { get; set; }

        [DisplayName("Plato")]
        public string DishName { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }
    }
}