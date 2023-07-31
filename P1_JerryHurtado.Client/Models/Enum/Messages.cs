using System.ComponentModel.DataAnnotations;

namespace P1_JerryHurtado.Client.Models.Enum
{
    public enum Messages
    {
        [Display(Name = "Los datos se han guardado correctamente.")]
        Success,

        [Display(Name = "No se pudo establecer la conexión, verifique que el servidor este activo.")]
        ConnectionError,

        [Display(Name = "Ha ocurrido un error, verifique que el servidor este activo.")]
        BadRequest,

        [Display(Name = "No hay datos disponibles")]
        DataEmpty,
    }
}