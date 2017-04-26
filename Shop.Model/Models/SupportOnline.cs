using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [StringLength(500)]
        public string Name { set; get; }

        [StringLength(500)]
        public string Department { set; get; }

        [StringLength(250)]
        public string Skype { set; get; }

        [StringLength(250)]
        public string Facebook { set; get; }

        [StringLength(250)]
        public string Gmail { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(250)]
        public string Mobile { set; get; }

        public bool? Status { set; get; }
    }
}
