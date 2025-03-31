using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.ModelBuilderConfig;

/// <summary>
/// Represents the data source configuration for the model builder, including file and formatting details.
/// </summary>
public class MbConfigDataSource
{
    /// <summary>
    /// Gets or sets the type of data source (e.g., "csv", "json", etc.).
    /// </summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the version of the data source configuration schema.
    /// </summary>
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the file path to the data source.
    /// </summary>
    [JsonPropertyName("FilePath")]
    public string? FilePath { get; set; }

    /// <summary>
    /// Gets or sets the delimiter used in the data file (e.g., ",", ";", "\t").
    /// </summary>
    [JsonPropertyName("Delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>
    /// Gets or sets the character used as a decimal marker (e.g., ".", ",").
    /// </summary>
    [JsonPropertyName("DecimalMarker")]
    public string? DecimalMarker { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the data file includes a header row.
    /// </summary>
    [JsonPropertyName("HasHeader")]
    public bool HasHeader { get; set; }

    /// <summary>
    /// Gets or sets the list of column properties describing individual columns in the data source.
    /// </summary>
    [JsonPropertyName("ColumnProperties")]
    public List<MbConfigColumnProperty>? ColumnProperties { get; set; }
}