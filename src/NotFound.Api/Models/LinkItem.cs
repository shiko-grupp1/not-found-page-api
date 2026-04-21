using System.Text.Json.Serialization;

namespace NotFound.Api.Models;

public enum LinkTarget
{
    [JsonStringEnumMemberName("_blank")]
    Blank,

    [JsonStringEnumMemberName("_self")]
    Self,

    [JsonStringEnumMemberName("_parent")]
    Parent,

    [JsonStringEnumMemberName("_top")]
    Top
}

public sealed record LinkItem(
    string Title,
    string LinkUrl,
    LinkTarget? Target
    );