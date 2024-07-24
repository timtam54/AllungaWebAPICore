using System.ComponentModel.DataAnnotations;

namespace AllungaWebAPI.Model
{
    public class Schedule
    {
        [Key]
        public string? id {  get; set; }
        public int? cntsamplesonsite{ get; set; }
        public string? rackno { get; set; }
        public DateTime? date { get; set; }
        public string? reportname { get; set; }
        public  string? bookandpage { get; set; }
        public  string? allungareference { get; set; }
        public  string? clientreference { get; set; }
        public int? seriesid { get; set; }
        public  string? shortdescription { get; set; }
        public  string? exposuretype { get; set; }
        public int? reportid { get; set; }
        public string? companyname { get; set; }
        public string? clientcontactname { get; set; }
        public string? clientcontactemail { get; set; }
        public bool? actual_elseprojected { get; set; }
        public bool? return_elsereport { get; set; }
        public int? cnt { get; set; }
        public int? physicalsamples { get; set; }
        public decimal? equivalentsamplesonsite { get; set; }
       public int? physicalsampleonsite { get; set; }
    }
}
