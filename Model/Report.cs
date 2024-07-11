using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllungaWebAPI.Model
{

    public class Report
    {
        [Key]
      
        public int reportid { get; set; }
        public int seriesid { get; set; }
       
    }
}
