using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class ScheduleProjectedEP
{
    public static void MapScheduleProjectedEPEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ScheduleProjected").WithTags(nameof(ScheduleProjectedEP));

        group.MapGet("/id/From/To", async (int id,DateTime From, DateTime To, dbcontext db) =>
        {
            return await db.schedule.FromSql($"exec ScheduleProjected {id},{From},{To}").ToListAsync();
        })
        .WithName("GetScheduleProjected")
        .WithOpenApi();
    }
}


