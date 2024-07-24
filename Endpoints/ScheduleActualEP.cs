using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class ScheduleActualEP
{
    public static void MapScheduleActualEPEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ScheduleActual").WithTags(nameof(ScheduleActualEP));

        group.MapGet("/id/From/To", async (int id,DateTime From, DateTime To, dbcontext db) =>
        {
            return await db.schedule.FromSql($"exec ScheduleActual {id},{From},{To}").ToListAsync();
        })
        .WithName("GetScheduleActual")
        .WithOpenApi();
    }
}


