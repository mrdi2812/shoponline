using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string TagID { set; get; }

        [StringLength(50)]
        public string Name { set; get; }

        [StringLength(50)]
        public string Type { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}