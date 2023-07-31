using System.ComponentModel;

namespace P1_JerryHurtado.Client.Models.Entities
{
    public class ExtraOrder
    {
        [DisplayName("Orden Id")]
        public int OrderId { get; set; }

        [DisplayName("Plato Id")]
        public int DishId { get; set; }

        [DisplayName("Extra Id")]
        public int ExtraId { get; set; }
    }
}