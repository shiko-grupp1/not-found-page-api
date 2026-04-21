using NotFound.Api.Models;

namespace NotFound.Api.Dtos;

public static class NotFoundData
{
    public static NotFoundItem NotFoundItem()
    {
        return new(
        Title: "Page Not Found!",
        Description: "Sorry, the page you are looking for doesn’t exist or has been removed. Keep exploring out site.",
        ImageUrl: "https://i.ibb.co/PvV16pHZ/Not-Found-Image.png",
        LinkItems:
        [
            new("Back To Home", "/", LinkTarget.Self),
        ]
        );
    }
}
