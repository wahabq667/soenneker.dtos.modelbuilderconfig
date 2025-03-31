using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents environment-specific settings or metadata for the model builder configuration.
/// </summary>
public class MbConfigEnvironment
{
    /// <summary>
    /// Gets or sets the type of environment (e.g., "local", "cloud", "production", "staging").
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the version of the environment configuration schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }
}