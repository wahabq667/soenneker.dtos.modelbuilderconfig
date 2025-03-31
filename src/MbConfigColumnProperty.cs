using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents metadata and configuration properties for a specific column in a dataset.
/// </summary>
public class MbConfigColumnProperty
{
    /// <summary>
    /// Gets or sets the name of the column.
    /// </summary>
    [JsonPropertyName("ColumnName")]
    public string? ColumnName { get; set; }

    /// <summary>
    /// Gets or sets the intended purpose of the column (e.g., label, feature, ignore).
    /// </summary>
    [JsonPropertyName("ColumnPurpose")]
    public string? ColumnPurpose { get; set; }

    /// <summary>
    /// Gets or sets the format of the data in the column (e.g., numeric, text, datetime).
    /// </summary>
    [JsonPropertyName("ColumnDataFormat")]
    public string? ColumnDataFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the column is treated as categorical.
    /// </summary>
    [JsonPropertyName("IsCategorical")]
    public bool IsCategorical { get; set; }

    /// <summary>
    /// Gets or sets the type of the column, possibly used for internal classification or processing.
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the version number of the column property schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }
}