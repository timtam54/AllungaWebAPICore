using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class ReportsPerDayEP
{
    public static void MapReportsPerDayEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ReportsPerDay").WithTags(nameof(ReportsPerDayEP));

        group.MapGet("/", async (dbcontext db) =>
        {
            return await db.chrtdtetme.FromSql($"exec ReportByDate").ToListAsync();
        })
        .WithName("GetReportsPerDay")
        .WithOpenApi();
    }
}


