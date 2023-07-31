using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace P1_JerryHurtado.Client.Helpers
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Retorna el valor del atributo Name del enum.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns>string: Valor de atributo Name del enum</returns>
        public static string GetDisplayName(this Enum enumValue)
            => enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
    }
}