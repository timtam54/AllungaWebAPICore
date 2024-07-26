using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class SampleOnOffSiteActualEP
{
    public static void MapSampleOnOffSiteActualEPEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/SampleOnOffSiteActual").WithTags(nameof(SampleOnOffSiteActualEP));

        group.MapGet("/id/From/To", async (int id,DateTime From, DateTime To, dbcontext db) =>
        {
            return await db.schedule.FromSql($"exec SampleOnOffSiteActual {id},{From},{To}").ToListAsync();
        })
        .WithName("GetSampleOnOffSiteActual")
        .WithOpenApi();
    }
}


