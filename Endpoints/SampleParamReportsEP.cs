using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class SampleParamReportsEP
{
    public static void MapSampleParamReportsEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/SampleParamReports").WithTags(nameof(SampleParamReportsEP));

        group.MapGet("/", async (dbcontext db) =>
        {
            return await db.chrtdtetme.FromSql($"exec ChartReportSamplesParams").ToListAsync();
        })
        .WithName("GetSampleParamReports")
        .WithOpenApi();
    }
}


