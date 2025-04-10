namespace WebAppForTeamCityDeploy.Api;

public static class ApiExtensions
{
    public static IEndpointRouteBuilder MapApi(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/", () => Results.Ok("Hello TeamCity!"));
        return builder;
    }
}
