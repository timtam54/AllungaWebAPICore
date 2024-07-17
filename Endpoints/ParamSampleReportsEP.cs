using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class ParamSampleReportsEP
{
    public static void MapParamSampleReportsEPEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ParamSampleReports").WithTags(nameof(ParamSampleReportsEP));

        group.MapGet("/id/SampleID", async (int id,int SampleID, dbcontext db) =>
        {
            return await db.chrtdtetme.FromSql($"exec ChartReportParamsSamples {id},{SampleID}").ToListAsync();
        })
        .WithName("GetParamSampleReports")
        .WithOpenApi();
    }
}


