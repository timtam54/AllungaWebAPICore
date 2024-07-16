using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class ParamReportsEP
{
    public static void MapParmReportsEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ParamReports").WithTags(nameof(ParamReportsEP));

        group.MapGet("/", async (dbcontext db) =>
        {
            return await db.chartKey.FromSql($"exec ParamReportCount").ToListAsync();
        })
        .WithName("GetParamReportCount")
        .WithOpenApi();
    }
}


