using System.Text.Json.Serialization;

namespace BudgetApi.Models;

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