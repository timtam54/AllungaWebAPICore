using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllungaWebAPI.Model
{

    public class ChartDteTme
    {
        [Key]
        public string ky { get; set; }
        public DateTime date { get; set; }
        public int cnt { get; set; }
        public string title { get; set; }
    }
}
