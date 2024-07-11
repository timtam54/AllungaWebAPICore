using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllungaWebAPI.Model
{

    public class ReportParam
    {
        [Key]
        public int id { get; set; }
        public int reportid { get; set; }
        public int paramid { get; set; }
        public bool? deleted { get; set; }
    }
}
