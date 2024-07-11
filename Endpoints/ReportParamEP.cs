using AllungaWebAPI.Data;
using AllungaWebAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
namespace AllungaWebAPI.Endpoints;
public static class ReportsParamEP
{
    public static void MapReportsParamEndpoints(this IEndpointRouteBuilder routes)
    {

        var group = routes.MapGroup("/api/ReportParams").WithTags(nameof(ReportsParamEP));

        group.MapGet("/id", async (int SeriesID,dbcontext db) =>
        {
            return await (from rp in db.reportparam join re in db.report on rp.reportid equals re.reportid where re.seriesid == SeriesID select rp).ToListAsync();
        })
        .WithName("GetReportsParam")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int SeriesID, List<ReportParam> rps, dbcontext db) =>
        {
            try
            {
                var dbrps= await (from rp in db.reportparam join re in db.report on rp.reportid equals re.reportid where re.seriesid == SeriesID select rp).ToListAsync();

                foreach (var rp in rps)
                {
                    var dd =  dbrps.Where(model => model.id == rp.id).FirstOrDefault();
                    if (dd == null)
                    {
                        dd = new ReportParam();
                        dd.reportid = rp.reportid;
                        dd.paramid = rp.paramid;
                        dd.deleted = rp.deleted;
                        db.Add(dd);
                    }
                    else
                    {
                        dd.paramid = rp.paramid;
                        dd.reportid = rp.reportid;
                        dd.deleted = rp.deleted;

                    }
                    await db.SaveChangesAsync();
                }
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
             
            }
            return TypedResults.NotFound();
        })
        .WithName("UpdateReportsParam")
       .WithOpenApi();

       /* group.MapPost("/", async (Notes notes, dbcontext db) =>
        {
            db.notes.Add(notes);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Notes/{notes.notesid}", notes);
        })
        .WithName("CreateNotes")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, dbcontext db) =>
        {
            var affected = await db.notes
                .Where(model => model.notesid == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteNotes")
        .WithOpenApi();*/
    }
}


