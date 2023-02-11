﻿using System.Text.Json.Serialization;

namespace OpenAI.NET.SDK.V1.Contracts.Files;

public record ListFilesResponse
{
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    [JsonPropertyName("data")]
    public List<ListFilesResponseData> Data { get; set; } = null!;

    public record ListFilesResponseData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        [JsonPropertyName("object")]
        public string Object { get; set; } = null!;

        [JsonPropertyName("bytes")]
        public int? Bytes { get; set; }

        [JsonPropertyName("created_at")]
        public int CreatedAt { get; set; }

        [JsonPropertyName("filename")]
        public string FileName { get; set; } = null!;

        [JsonPropertyName("purpose")]
        public string Purpose { get; set; } = null!;
    }
}
