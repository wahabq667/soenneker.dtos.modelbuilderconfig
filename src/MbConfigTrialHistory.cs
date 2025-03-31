using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents a single trial or experiment in a model training run.
/// </summary>
public class MbConfigTrial
{
    /// <summary>
    /// Gets or sets the version of the trial schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the type of trial (e.g., "baseline", "automated").
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the name of the trainer (algorithm) used in this trial.
    /// </summary>
    [JsonPropertyName("TrainerName")]
    public string? TrainerName { get; set; }

    /// <summary>
    /// Gets or sets the evaluation score (e.g., accuracy, F1 score) achieved in this trial.
    /// </summary>
    [JsonPropertyName("Score")]
    public double? Score { get; set; }

    /// <summary>
    /// Gets or sets the time taken to complete the trial, in seconds.
    /// </summary>
    [JsonPropertyName("RuntimeInSeconds")]
    public double? RuntimeInSeconds { get; set; }
}