using System.Text.Json.Serialization;

namespace budget_api.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CategoryGroup
{
    Income = 1,
    Housing,
    Food,
    Transport,
    Healthcare,
    Financial,
    Other
}