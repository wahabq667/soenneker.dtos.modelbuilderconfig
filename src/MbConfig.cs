using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents the configuration for a machine learning or model-building scenario.
/// </summary>
public class MbConfig
{
    /// <summary>
    /// Gets or sets the scenario name or identifier for the configuration.
    /// </summary>
    [JsonPropertyName("Scenario")]
    public string? Scenario { get; set; }

    /// <summary>
    /// Gets or sets the type of configuration or model.
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the version number of the configuration schema or format.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the data source configuration details.
    /// </summary>
    [JsonPropertyName("DataSource")]
    public MbConfigDataSource? DataSource { get; set; }

    /// <summary>
    /// Gets or sets the environment settings for the configuration.
    /// </summary>
    [JsonPropertyName("Environment")]
    public MbConfigEnvironment? Environment { get; set; }

    /// <summary>
    /// Gets or sets the training options related to the configuration.
    /// </summary>
    [JsonPropertyName("TrainingOption")]
    public MbConfigTrainingOption? TrainingOption { get; set; }

    /// <summary>
    /// Gets or sets the run history information for previous executions.
    /// </summary>
    [JsonPropertyName("RunHistory")]
    public MbConfigRunHistory? RunHistory { get; set; }
}