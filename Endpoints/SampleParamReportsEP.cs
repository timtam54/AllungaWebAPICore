using AllungaWebAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace AllungaWebAPI.Endpoints;
public static class SampleParamReportsEP
{
    public static void MapSampleParamReportsEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/SampleParamReports").WithTags(nameof(SampleParamReportsEP));

        group.MapGet("/id/ParamID", async (int id,int ParamID,dbcontext db) =>
        {
            return await db.chrtdtetme.FromSql($"exec ChartReportSamplesParams {id},{ParamID}").ToListAsync();
        })
        .WithName("GetSampleParamReports")
        .WithOpenApi();
    }
}


