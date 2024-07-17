using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class ReportsPerDayEP
{
    public static void MapReportsPerDayEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ReportsPerDay").WithTags(nameof(ReportsPerDayEP));

        group.MapGet("/SampleID/ParamID", async (int SampleID,int ParamID,dbcontext db) =>
        {
            return await db.chrtdtetme.FromSql($"exec ReportByDate {SampleID}, {ParamID}").ToListAsync();
        })
        .WithName("GetReportsPerDay")
        .WithOpenApi();
    }
}


