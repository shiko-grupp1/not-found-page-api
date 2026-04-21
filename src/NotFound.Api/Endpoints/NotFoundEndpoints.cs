using NotFound.Api.Dtos;
using NotFound.Api.Security;

namespace NotFound.Api.Endpoints;

public static class NotFoundEndPoints
{
    public static void MapNotFoundEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/not-found").AddEndpointFilter<ApiKeyAuthFilter>();

        group.MapGet("/", GetNotFound);
    }

    private static async Task<IResult> GetNotFound()
    {
        var item = NotFoundData.NotFoundItem();

        return Results.Ok(item);
    }

}
