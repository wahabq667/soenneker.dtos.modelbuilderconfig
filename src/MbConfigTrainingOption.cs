using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents configurable options for training a machine learning model.
/// </summary>
public class MbConfigTrainingOption
{
    /// <summary>
    /// Gets or sets the version of the training option schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the type of training option (e.g., "auto", "custom").
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the maximum amount of training time in seconds.
    /// </summary>
    [JsonPropertyName("TrainingTime")]
    public int? TrainingTime { get; set; }

    /// <summary>
    /// Gets or sets the name of the metric to optimize during model training (e.g., "accuracy", "f1").
    /// </summary>
    [JsonPropertyName("OptimizeMetric")]
    public string? OptimizeMetric { get; set; }

    /// <summary>
    /// Gets or sets the name of the label (target) column in the dataset.
    /// </summary>
    [JsonPropertyName("LabelColumn")]
    public string? LabelColumn { get; set; }

    /// <summary>
    /// Gets or sets the list of available trainers (algorithms) to use for model training.
    /// </summary>
    [JsonPropertyName("AvailableTrainers")]
    public List<string>? AvailableTrainers { get; set; }

    /// <summary>
    /// Gets or sets the random seed for reproducibility of training results.
    /// </summary>
    [JsonPropertyName("Seed")]
    public int? Seed { get; set; }

    /// <summary>
    /// Gets or sets the validation option configuration used during training.
    /// </summary>
    [JsonPropertyName("ValidationOption")]
    public MbConfigValidationOption? ValidationOption { get; set; }
}