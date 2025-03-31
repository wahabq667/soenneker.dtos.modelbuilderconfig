using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents the run history for a model training session, including trial data and evaluation metrics.
/// </summary>
public class MbConfigRunHistory
{
    /// <summary>
    /// Gets or sets the version of the run history schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the type of run history (e.g., "automated", "manual").
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the list of individual trials performed during the run.
    /// </summary>
    [JsonPropertyName("Trials")]
    public List<MbConfigTrial>? Trials { get; set; }

    /// <summary>
    /// Gets or sets the schema identifier or version associated with the run history.
    /// </summary>
    [JsonPropertyName("Schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Gets or sets the name of the evaluation metric used to assess model performance (e.g., "accuracy", "rmse").
    /// </summary>
    [JsonPropertyName("MetricName")]
    public string? MetricName { get; set; }
}