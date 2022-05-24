using System.Text.Json.Serialization;

namespace Mistral_Internship.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric,

    }
}
