using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents the validation strategy and settings used during model training.
/// </summary>
public class MbConfigValidationOption
{
    /// <summary>
    /// Gets or sets the version of the validation option schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the type of validation (e.g., "trainTestSplit", "crossValidation").
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the ratio of data used for training versus validation.
    /// For example, 0.8 means 80% training and 20% validation.
    /// </summary>
    [JsonPropertyName("SplitRatio")]
    public double? SplitRatio { get; set; }
}