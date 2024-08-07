using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class SampleOnOffSiteProjectedEP
{
    public static void MapSampleOnOffSiteProjectedEPEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/SampleOnOffSiteProjected").WithTags(nameof(SampleOnOffSiteProjectedEP));

        group.MapGet("/id/From/To", async (int id,DateTime From, DateTime To, dbcontext db) =>
        {
            return await db.schedule.FromSql($"exec SampleOnOffSiteProjected {id},{From},{To}").ToListAsync();
        })
        .WithName("GetSampleOnOffSiteProjected")
        .WithOpenApi();
    }
}


