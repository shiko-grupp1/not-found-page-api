namespace NotFound.Api.Models;

public record NotFoundItem(
    string Title,
    string Description,
    string ImageUrl,
    IReadOnlyList<LinkItem> LinkItems
    )
    { 
        public IReadOnlyList<LinkItem> LinkItems { get; init; } = LinkItems ?? []; 
    }
