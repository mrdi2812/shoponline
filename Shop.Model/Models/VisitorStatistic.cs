using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { set; get; }

        public DateTime VisitedDate { set; get; }

        [Required]
        [StringLength(50)]
        public string IPAddress { set; get; }
    }
}
