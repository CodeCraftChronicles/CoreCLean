using System.Text.Json;

namespace BlazorHero.CleanArchitecture.Application.Interfaces.Serialization.Options
{
    public interface IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; }
    }
}