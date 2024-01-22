using System.Text.Json;

namespace Models;

public static class SerializerOptions
{
    public static JsonSerializerOptions ApiServerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };
}